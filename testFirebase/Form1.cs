using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;
using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;
using Firebase.Database;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using LiveCharts;
using LiveCharts.Wpf;
using System.Windows.Media;
using System.Security.Cryptography.X509Certificates;
using System.Windows.Threading;
using System.Text.RegularExpressions;

using System.Windows.Forms.DataVisualization.Charting;
using System.Runtime.InteropServices;
using Excel = Microsoft.Office.Interop.Excel;
using Microsoft.Office.Interop.Excel;
using Series = System.Windows.Forms.DataVisualization.Charting.Series;
using System.Drawing.Drawing2D;
using System.Windows;
using System.Windows.Controls;
using Brush = System.Drawing.Brush;
using Color = System.Windows.Media.Color;
using ListBox = System.Windows.Forms.ListBox;

namespace testFirebase
{
    public partial class Form1 : Form
    {
        int[] nData1 = new int[102];
        int[] nData2 = new int[102];
        int[] nDataNew1 = new int[102];
        int[] nDataNew2 = new int[102];
        private bool StatusKoneksi;

        IFirebaseClient client;

        public Form1()
        {
            InitializeComponent();
            GaugeSuhu.Wedge = 200;
            GaugeSuhu.SectionsInnerRadius = 0.9;

            GaugeKelembapan.Wedge = 200;
            GaugeKelembapan.SectionsInnerRadius = 0.9;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            Panel_saveFile.Visible = false;
            Panel_Monitoring.Visible = false;

        }

        void isiChart()
        {
            chart1.Series.Clear();
            Series T = chart1.Series.Add("Data Suhu");
            Series H = chart1.Series.Add("Data Kelembaban");

            T.ChartType = SeriesChartType.Line;
            H.ChartType = SeriesChartType.Line;

            T.BorderWidth = 5;
            H.BorderWidth = 5;

            for (int i = 1; i <= 100; i++)
            {
                T.Points.AddXY(i, nDataNew1[i]);
                H.Points.AddXY(i, nDataNew2[i]);
            }
        }
        private void Form1_Shown(object sender, EventArgs e)
        {
            chart1.Series.Clear();
            chart1.Titles.Add("Data Record");

            for (int i = 1; i <= 100; i++)
            {
                nData1[i] = 100;
                nData2[i] = 100;
                nDataNew1[i] = 100;
                nDataNew2[i] = 100;
            }
            isiChart();

        }

        private void HighlightButton(System.Windows.Forms.Button button)
        {
            button.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(252, 163, 17);
            button.FlatAppearance.BorderSize = 2;
            button.BackColor = System.Drawing.Color.FromArgb(40, 53, 81);
        }

        private void UnhighlightButton(System.Windows.Forms.Button button)
        {
            button.FlatAppearance.BorderColor = System.Drawing.Color.Empty;
            button.FlatAppearance.BorderSize = 0;
            button.BackColor = System.Drawing.Color.FromArgb(20, 33, 61);
        }

        //========================= untuk highlight tombol
        private void Btn_Monitor_Click(object sender, EventArgs e)
        {
            Panel_saveFile.Visible = false;
            Panel_Monitoring.Visible = true;
            Panel_koneksi.Visible = false;

            HighlightButton(Btn_Monitor);
            UnhighlightButton(Btn_nav_save);
            UnhighlightButton(Btn_Connection);
        }

        private void Btn_nav_save_Click(object sender, EventArgs e)
        {

            Panel_saveFile.Visible = true;
            Panel_Monitoring.Visible = false;
            Panel_koneksi.Visible = false;

            HighlightButton(Btn_nav_save);
            UnhighlightButton(Btn_Monitor);
            UnhighlightButton(Btn_Connection);
        }

        private void Btn_Connection_Click(object sender, EventArgs e)
        {
            Panel_saveFile.Visible = false;
            Panel_Monitoring.Visible = false;
            Panel_koneksi.Visible = true;

            HighlightButton(Btn_Connection);
            UnhighlightButton(Btn_Monitor);
            UnhighlightButton(Btn_nav_save);
        }


        private void BTN_SvExcel_Click_1(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();
            save.FileName = ".xls";
            save.Filter = "Excel file (*.xls)|*.xls|Excel files (*xlsx)|*.xlsx";

            if (save.ShowDialog() == DialogResult.OK)
            {
                Excel.Application xlApp = new Microsoft.Office.Interop.Excel.Application();
                if (xlApp == null)
                {
                    System.Windows.Forms.MessageBox.Show("excel is not porperly installed  ");
                    return;
                }
                Excel.Workbook xlWorkBook;
                Excel.Worksheet xlWorkSheet;
                object misValue = System.Reflection.Missing.Value;

                xlWorkBook = xlApp.Workbooks.Add();
                xlWorkSheet = (Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);

                xlWorkSheet.Cells[1, 1] = "waktu";
                xlWorkSheet.Cells[1, 2] = "Suhu";
                xlWorkSheet.Cells[1, 3] = "Kelembapan";

                for (int i = 0; i < LB_dataLogger.Items.Count; i++)
                {
                    string dataSuhu = LB_dataLogger.Items[i].ToString();
                    string dataWaktu = LB_jam.Items[i].ToString();
                    string[] parts = dataSuhu.Split('+');
                    string parts2 = dataWaktu;
                   /* xlWorkSheet.Cells[i + 1, 1] = LB_dataLogger.Items[i].ToString();*/
                    if (parts.Length == 2)
                    {
                        xlWorkSheet.Cells[i + 2, 1] = parts2;
                        xlWorkSheet.Cells[i + 2, 2] = parts[0].Trim();
                        xlWorkSheet.Cells[i + 2, 3] = parts[1].Trim();
                    }
                }

                xlWorkBook.SaveAs(save.FileName, Microsoft.Office.Interop.Excel.XlFileFormat.xlWorkbookDefault, Type.Missing, Type.Missing,
                    false, false, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlShared,
                    Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
                xlWorkBook.Close();
                xlApp.Quit();

                Marshal.ReleaseComObject(xlWorkSheet);
                Marshal.ReleaseComObject(xlWorkBook);
                Marshal.ReleaseComObject(xlApp);

                System.Windows.Forms.MessageBox.Show("excel sudah selesai disimpan");
            }
        }

        private void timerJam_Tick_1(object sender, EventArgs e)
        {
            //timer jam
            DateTime currentTime = DateTime.Now;
            string formattedTime = currentTime.ToString("HH:mm:ss");
            Lbl_Clock.Text = formattedTime;
        }

        private void Reconnect()
        {
            IFirebaseConfig config = new FirebaseConfig
            {

                AuthSecret = TB_AuthSecret.Text,
                BasePath = TB_BasePath.Text,
            };
            client = new FireSharp.FirebaseClient(config);    
           
        }

        private async void timerChart_Tick(object sender, EventArgs e)
        {
            try
            {
                if (StatusKoneksi == true && client != null)
                {
                    timerChart.Interval = 15000;
                    Gb_mati.Visible = false;
                    GB_nyala.Visible = true;

                    //grafik dan data logger akan berjalan hanya jika ada koneksi ke firebase
                    //struktur penyimpanan di firebase terdahulu, silahkan ubah sesuai kebutuhan 
                    FirebaseResponse response = await client.GetAsync("data1/data2/data3");
                    Data obj = response.ResultAs<Data>();

                    string nilaiAwalS = obj.Kelembapan;
                    string nilaiAwalK = obj.Suhu;
                    string[] parts1 = nilaiAwalS.Split('.');
                    string[] parts2 = nilaiAwalK.Split('.');

                    string Bagian1 = parts1[0];
                    string Bagian2 = parts2[0];

                    //untuk gauge
                    GaugeSuhu.Value = int.Parse(Bagian2);
                    GaugeKelembapan.Value = int.Parse(Bagian1);
                    LBL_kelembapan.Text = $"{nilaiAwalS}  %Rh";
                    LBL_suhu.Text = $"{nilaiAwalK}  °C";

                    LBL_status.Text = "Berhasi Tersambung";


                    //untuk chart dan data logger
                    string dataRecord;
                    dataRecord = " " + Bagian2 + " + " + Bagian1;
                    LB_dataLogger.Items.Add(dataRecord);

                    DateTime currentTime = DateTime.Now;
                    string formattedTime = currentTime.ToString("HH:mm:ss");
                    // untuk data logger listbox tanggal
                    LB_jam.Items.Add(formattedTime);

                    nData1[101] = int.Parse(parts2[0]);
                    nData2[101] = int.Parse(parts1[0]);

                    //kontrol eror
                    if (nData1[101] > 100)
                    {
                        nData1[101] = 100;
                        GaugeSuhu.Value = 100;

                    }
                    if (nData2[101] > 100)
                    {
                        nData2[101] = 100;
                        GaugeKelembapan.Value = 100;
                    }

                    for (int i = 1; i <= 100; i++)
                    {
                        nDataNew1[i] = nData1[i + 1];
                        nDataNew2[i] = nData2[i + 1];
                    }
                    isiChart();

                    for (int i = 1; i <= 100; i++)
                    {
                        nData1[i] = nDataNew1[i];
                        nData2[i] = nDataNew2[i];
                    }
                }
            }
            catch(Exception)
            {
                timerChart.Stop();
                LBL_status.Text = "Connecting...";
                LBL_kelembapan.Text = "NaN";
                LBL_suhu.Text = "NaN";
                Gb_mati.Visible = true;
                GB_nyala.Visible = false;
                /*System.Windows.Forms.MessageBox.Show("Terjadi kesalahan: " + ex.Message, "Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Error);*/
                timerChart.Interval = 1000;
                Reconnect();
                timerChart.Start();
                timerChart.Interval = 3000;
            }

           
        }

        private async void BTN_saveDataTelur_Click(object sender, EventArgs e)
        {
            var firebaseClient = new FirebaseClient(TB_BasePath.Text);
            var data = await firebaseClient
                .Child("Userdata/5Zl6OlsaCYZXJ2wy4gpNoWBFMPB3")
                .OnceAsync<object>();

            // Konversi data ke format JSON
            string jsonData = Newtonsoft.Json.JsonConvert.SerializeObject(data);

            JArray jsonArray2 = JArray.Parse(jsonData);

            string text = jsonArray2[0].ToString();
            string text2 = jsonArray2[1].ToString();
            string text3 = jsonArray2[2].ToString();
            string pattern = "\\d+";

            MatchCollection matches = Regex.Matches(text, pattern);
            MatchCollection matches1 = Regex.Matches(text2, pattern);
            MatchCollection matches2 = Regex.Matches(text3, pattern);

            int[] angkaArray = matches.Cast<Match>().Select(match => int.Parse(match.Value)).ToArray();
            int[] angkaArray1 = matches1.Cast<Match>().Select(match => int.Parse(match.Value)).ToArray();
            int[] angkaArray2 = matches2.Cast<Match>().Select(match => int.Parse(match.Value)).ToArray();

            //MENGHAPUS ARRAY KE 1 DI DATA(ANGKA 1,2,3 PADA FORM1, FORM2, FORM3) AGAR DATA LEBIH BERSIH
            angkaArray = angkaArray.Skip(1).ToArray();
            angkaArray1 = angkaArray1.Skip(1).ToArray();
            angkaArray2 = angkaArray2.Skip(1).ToArray();

            //MENGISI DATA KE LISTBOX BERBEDA (format form1)
            for (int i = 0; i < angkaArray.Length; i++)
            {
                int listBoxIndex = (i % 4) + 1; // Determine the ListBox to add to (1-4)
                ListBox targetListBox = Controls.Find("listBox" + listBoxIndex, true)[0] as ListBox;

                targetListBox.Items.Add(angkaArray[i]);
            }
            for (int i = 0; i < listBox1.Items.Count; i++)
            {
                listBox16.Items.Add($"{listBox4.Items[i]}+{listBox4.Items[i]}");
            }
            //MENGISI DATA KE LISTBOX BERBEDA (format form2)
            for (int i = 0; i < angkaArray1.Length; i++)
            {
                int listBoxIndex = (i % 5) + 5; // Determine the ListBox to add to (1-4)
                ListBox targetListBox = Controls.Find("listBox" + listBoxIndex, true)[0] as ListBox;

                targetListBox.Items.Add(angkaArray1[i]);
            }
            for (int i = 0; i < listBox5.Items.Count; i++)
            {
                listBox17.Items.Add($"{listBox8.Items[i]}+{listBox9.Items[i]}");
            }
            //MENGISI DATA KE LISTBOX BERBEDA (format form3)
            for (int i = 0; i < angkaArray2.Length; i++)
            {
                int listBoxIndex = (i % 6) + 10; // Determine the ListBox to add to (1-4)
                ListBox targetListBox = Controls.Find("listBox" + listBoxIndex, true)[0] as ListBox;

                targetListBox.Items.Add(angkaArray2[i]);
            }
            for (int i = 0; i < listBox10.Items.Count; i++)
            {
                listBox18.Items.Add($"{listBox13.Items[i]}+{listBox14.Items[i]}+{listBox15.Items[i]}");
            }

            //=====================================================================================
            //|>>>>>>>>>>>>>>>>> Proses penyimpanan data telur ke excel <<<<<<<<<<<<<<<<<<<<<<<<<<|
            //=====================================================================================
            SaveFileDialog save = new SaveFileDialog();
            save.FileName = ".xls";
            save.Filter = "Excel file (*.xls)|*.xls|Excel files (*xlsx)|*.xlsx";

            if (save.ShowDialog() == DialogResult.OK)
            {
                Excel.Application xlApp = new Microsoft.Office.Interop.Excel.Application();
                if (xlApp == null)
                {
                    System.Windows.Forms.MessageBox.Show("excel is not porperly installed  ");
                    return;
                }
                Excel.Workbook xlWorkBook;
                Excel.Worksheet xlWorkSheet;
                object misValue = System.Reflection.Missing.Value;

                xlWorkBook = xlApp.Workbooks.Add();
                xlWorkSheet = (Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);
                //pembuatan header
                xlWorkSheet.Cells[1, 1] = "Tanggal";
                xlWorkSheet.Cells[1, 2] = "Jumlah Telur";
                xlWorkSheet.Cells[1, 4] = "Tanggal";
                xlWorkSheet.Cells[1, 5] = "Invertil ";
                xlWorkSheet.Cells[1, 6] = "Vertil";
                xlWorkSheet.Cells[1, 8] = "Tanggal";
                xlWorkSheet.Cells[1, 9] = "Gagal Menetas";
                xlWorkSheet.Cells[1, 11] = "Keseluruhan ";
                xlWorkSheet.Cells[1, 10] = "Berhasil menetas";
                //=================


                //metode simpan untuk form 1 
                for (int i = 0; i < listBox1.Items.Count; i++)
                {
                    string tanggal = $"{listBox1.Items[i]}/{listBox2.Items[i]}/{listBox3.Items[i]}";
                    string JumlahTelur = listBox16.Items[i].ToString();
                    string[] parts = JumlahTelur.Split('+');
                    string parts2 = tanggal;
                    //* xlWorkSheet.Cells[i + 1, 1] = LB_dataLogger.Items[i].ToString();*//*
                    if (parts.Length >= 1)
                    {
                        xlWorkSheet.Cells[i + 2, 1] = parts2;
                        xlWorkSheet.Cells[i + 2, 2] = parts[0].Trim();
                    }
                }
                //metode simpan untuk form 2
                for (int i = 0; i < listBox5.Items.Count; i++)
                {
                    string tanggal = $"{listBox5.Items[i]}/{listBox6.Items[i]}/{listBox7.Items[i]}";
                    string Invertil = listBox17.Items[i].ToString();
                    string[] parts = Invertil.Split('+');
                    string parts2 = tanggal;
                    //* xlWorkSheet.Cells[i + 1, 1] = LB_dataLogger.Items[i].ToString();*//*
                    if (parts.Length >= 1)
                    {
                        xlWorkSheet.Cells[i + 2, 4] = parts2;
                        xlWorkSheet.Cells[i + 2, 5] = parts[0].Trim();
                        xlWorkSheet.Cells[i + 2, 6] = parts[1].Trim();
                    }
                }
                //metode simpan untuk form 3
                for (int i = 0; i < listBox10.Items.Count; i++)
                {
                    string tanggal = $"{listBox10.Items[i]}/{listBox11.Items[i]}/{listBox12.Items[i]}";
                    string KondisiTelur = listBox18.Items[i].ToString();
                    string[] parts = KondisiTelur.Split('+');
                    string parts2 = tanggal;
                    //* xlWorkSheet.Cells[i + 1, 1] = LB_dataLogger.Items[i].ToString();*//*
                    if (parts.Length >= 1)
                    {
                        xlWorkSheet.Cells[i + 2, 8] = parts2;
                        xlWorkSheet.Cells[i + 2, 9] = parts[0].Trim();
                        xlWorkSheet.Cells[i + 2, 10] = parts[2].Trim();
                        xlWorkSheet.Cells[i + 2, 11] = parts[1].Trim();
                    }
                }

                xlWorkBook.SaveAs(save.FileName, Microsoft.Office.Interop.Excel.XlFileFormat.xlWorkbookDefault, Type.Missing, Type.Missing,
                    false, false, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlShared,
                    Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
                xlWorkBook.Close();
                xlApp.Quit();

                Marshal.ReleaseComObject(xlWorkSheet);
                Marshal.ReleaseComObject(xlWorkBook);
                Marshal.ReleaseComObject(xlApp);

                System.Windows.Forms.MessageBox.Show("excel sudah selesai disimpan");
                listBox1.Items.Clear();
                listBox2.Items.Clear();
                listBox3.Items.Clear();
                listBox4.Items.Clear();
                listBox5.Items.Clear();
                listBox6.Items.Clear();
                listBox7.Items.Clear();
                listBox8.Items.Clear();
                listBox9.Items.Clear();
                listBox10.Items.Clear();
                listBox11.Items.Clear();
                listBox11.Items.Clear();
                listBox12.Items.Clear();
                listBox13.Items.Clear();
                listBox14.Items.Clear();
                listBox15.Items.Clear();
                listBox16.Items.Clear();
                listBox17.Items.Clear();
                listBox18.Items.Clear();

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            IFirebaseConfig config = new FirebaseConfig
            {
                AuthSecret = TB_AuthSecret.Text,
                BasePath = TB_BasePath.Text,
            };

            client = new FireSharp.FirebaseClient(config);

            if (client != null && !string.IsNullOrWhiteSpace(TB_AuthSecret.Text) && !string.IsNullOrWhiteSpace(TB_BasePath.Text))
            {
                StatusKoneksi = true;
            }
            else
            {
                System.Windows.Forms.MessageBox.Show("Gagal tersambung", "Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Error);
                StatusKoneksi = false;
            }
        }

        private void CB_autoFill_CheckedChanged(object sender, EventArgs e)
        {
            if (CB_autoFill.Checked == true)
            {
                TB_AuthSecret.Text = "R51TxvBJSYklilDDQBNsU76qRM4m2jMMfVVvD5AE";
                TB_BasePath.Text = "https://incubator-v2-default-rtdb.firebaseio.com/";
                TB_BasePath.Enabled = false;
                TB_AuthSecret.Enabled = false;
            }
            else
            {
                TB_BasePath.Enabled = true;
                TB_AuthSecret.Enabled = true;
                TB_AuthSecret.Text = "";
                TB_BasePath.Text = "";
            }
            
        }
    }
}
