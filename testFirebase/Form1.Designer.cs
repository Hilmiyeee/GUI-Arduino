namespace testFirebase
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.PnlFormLoader = new System.Windows.Forms.Panel();
            this.timerChart = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.Panel_dashboard = new System.Windows.Forms.Panel();
            this.timerJam = new System.Windows.Forms.Timer(this.components);
            this.Panel_saveFile = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.Label_save_suhu = new System.Windows.Forms.Label();
            this.BTN_SvExcel = new System.Windows.Forms.Button();
            this.BTN_saveDataTelur = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.LB_jam = new System.Windows.Forms.ListBox();
            this.LBL_suhu = new System.Windows.Forms.Label();
            this.LBL_kelembapan = new System.Windows.Forms.Label();
            this.LB_dataLogger = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.GaugeSuhu = new LiveCharts.WinForms.AngularGauge();
            this.GaugeKelembapan = new LiveCharts.WinForms.AngularGauge();
            this.panel1 = new System.Windows.Forms.Panel();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.Panel_Monitoring = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Btn_Monitor = new System.Windows.Forms.Button();
            this.Btn_nav_save = new System.Windows.Forms.Button();
            this.Pan_clock = new System.Windows.Forms.Panel();
            this.Lbl_Clock = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.listBox3 = new System.Windows.Forms.ListBox();
            this.listBox4 = new System.Windows.Forms.ListBox();
            this.listBox5 = new System.Windows.Forms.ListBox();
            this.listBox6 = new System.Windows.Forms.ListBox();
            this.listBox7 = new System.Windows.Forms.ListBox();
            this.listBox8 = new System.Windows.Forms.ListBox();
            this.listBox9 = new System.Windows.Forms.ListBox();
            this.listBox10 = new System.Windows.Forms.ListBox();
            this.listBox11 = new System.Windows.Forms.ListBox();
            this.listBox12 = new System.Windows.Forms.ListBox();
            this.listBox13 = new System.Windows.Forms.ListBox();
            this.listBox14 = new System.Windows.Forms.ListBox();
            this.listBox15 = new System.Windows.Forms.ListBox();
            this.listBox16 = new System.Windows.Forms.ListBox();
            this.listBox17 = new System.Windows.Forms.ListBox();
            this.listBox18 = new System.Windows.Forms.ListBox();
            this.Btn_Connection = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.CB_autoFill = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.LBL_status = new System.Windows.Forms.Label();
            this.Gb_mati = new System.Windows.Forms.PictureBox();
            this.GB_nyala = new System.Windows.Forms.PictureBox();
            this.TB_BasePath = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.TB_AuthSecret = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.Panel_koneksi = new System.Windows.Forms.Panel();
            this.Panel_dashboard.SuspendLayout();
            this.Panel_saveFile.SuspendLayout();
            this.panel4.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.Panel_Monitoring.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.Pan_clock.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Gb_mati)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GB_nyala)).BeginInit();
            this.Panel_koneksi.SuspendLayout();
            this.SuspendLayout();
            // 
            // PnlFormLoader
            // 
            this.PnlFormLoader.AutoSize = true;
            this.PnlFormLoader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.PnlFormLoader.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PnlFormLoader.Location = new System.Drawing.Point(265, 729);
            this.PnlFormLoader.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PnlFormLoader.Name = "PnlFormLoader";
            this.PnlFormLoader.Size = new System.Drawing.Size(1186, 0);
            this.PnlFormLoader.TabIndex = 3;
            // 
            // timerChart
            // 
            this.timerChart.Enabled = true;
            this.timerChart.Interval = 1000;
            this.timerChart.Tick += new System.EventHandler(this.timerChart_Tick);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Franklin Gothic Medium", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(28, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(513, 49);
            this.label1.TabIndex = 3;
            this.label1.Text = "Monitoring Inkubator Telur Ayam";
            // 
            // Panel_dashboard
            // 
            this.Panel_dashboard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(163)))), ((int)(((byte)(17)))));
            this.Panel_dashboard.Controls.Add(this.label1);
            this.Panel_dashboard.Dock = System.Windows.Forms.DockStyle.Top;
            this.Panel_dashboard.Location = new System.Drawing.Point(265, 0);
            this.Panel_dashboard.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Panel_dashboard.Name = "Panel_dashboard";
            this.Panel_dashboard.Size = new System.Drawing.Size(1186, 91);
            this.Panel_dashboard.TabIndex = 2;
            // 
            // timerJam
            // 
            this.timerJam.Enabled = true;
            this.timerJam.Interval = 1000;
            this.timerJam.Tick += new System.EventHandler(this.timerJam_Tick_1);
            // 
            // Panel_saveFile
            // 
            this.Panel_saveFile.Controls.Add(this.panel4);
            this.Panel_saveFile.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Panel_saveFile.Location = new System.Drawing.Point(265, 91);
            this.Panel_saveFile.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Panel_saveFile.Name = "Panel_saveFile";
            this.Panel_saveFile.Size = new System.Drawing.Size(1186, 638);
            this.Panel_saveFile.TabIndex = 4;
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel4.AutoSize = true;
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(33)))), ((int)(((byte)(61)))));
            this.panel4.Controls.Add(this.label4);
            this.panel4.Controls.Add(this.Label_save_suhu);
            this.panel4.Controls.Add(this.BTN_SvExcel);
            this.panel4.Controls.Add(this.BTN_saveDataTelur);
            this.panel4.ForeColor = System.Drawing.Color.White;
            this.panel4.Location = new System.Drawing.Point(21, 22);
            this.panel4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1146, 279);
            this.panel4.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(75, 153);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(527, 39);
            this.label4.TabIndex = 4;
            this.label4.Text = "Data Excel Jumlah Telur Menetas";
            // 
            // Label_save_suhu
            // 
            this.Label_save_suhu.AutoSize = true;
            this.Label_save_suhu.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_save_suhu.Location = new System.Drawing.Point(75, 74);
            this.Label_save_suhu.Name = "Label_save_suhu";
            this.Label_save_suhu.Size = new System.Drawing.Size(538, 39);
            this.Label_save_suhu.TabIndex = 3;
            this.Label_save_suhu.Text = "Data Excel Suhu dan Kelembaban";
            // 
            // BTN_SvExcel
            // 
            this.BTN_SvExcel.ForeColor = System.Drawing.Color.Black;
            this.BTN_SvExcel.Location = new System.Drawing.Point(691, 74);
            this.BTN_SvExcel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BTN_SvExcel.Name = "BTN_SvExcel";
            this.BTN_SvExcel.Size = new System.Drawing.Size(157, 41);
            this.BTN_SvExcel.TabIndex = 0;
            this.BTN_SvExcel.Text = "Simpan";
            this.BTN_SvExcel.UseVisualStyleBackColor = true;
            this.BTN_SvExcel.Click += new System.EventHandler(this.BTN_SvExcel_Click_1);
            // 
            // BTN_saveDataTelur
            // 
            this.BTN_saveDataTelur.ForeColor = System.Drawing.Color.Black;
            this.BTN_saveDataTelur.Location = new System.Drawing.Point(691, 151);
            this.BTN_saveDataTelur.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BTN_saveDataTelur.Name = "BTN_saveDataTelur";
            this.BTN_saveDataTelur.Size = new System.Drawing.Size(157, 41);
            this.BTN_saveDataTelur.TabIndex = 1;
            this.BTN_saveDataTelur.Text = "Simpan";
            this.BTN_saveDataTelur.UseVisualStyleBackColor = true;
            this.BTN_saveDataTelur.Click += new System.EventHandler(this.BTN_saveDataTelur_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(53)))), ((int)(((byte)(81)))));
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 34.08327F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 31.83346F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 34.08327F));
            this.tableLayoutPanel1.Controls.Add(this.panel5, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel6, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, -1);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.Padding = new System.Windows.Forms.Padding(5);
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 354F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1186, 364);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // panel5
            // 
            this.panel5.AutoSize = true;
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(33)))), ((int)(((byte)(61)))));
            this.panel5.Controls.Add(this.LB_jam);
            this.panel5.Controls.Add(this.LBL_suhu);
            this.panel5.Controls.Add(this.LBL_kelembapan);
            this.panel5.Controls.Add(this.LB_dataLogger);
            this.panel5.Controls.Add(this.label3);
            this.panel5.Controls.Add(this.label5);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(16, 15);
            this.panel5.Margin = new System.Windows.Forms.Padding(11, 10, 11, 10);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(586, 334);
            this.panel5.TabIndex = 0;
            // 
            // LB_jam
            // 
            this.LB_jam.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LB_jam.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_jam.FormattingEnabled = true;
            this.LB_jam.ItemHeight = 29;
            this.LB_jam.Location = new System.Drawing.Point(77, 145);
            this.LB_jam.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.LB_jam.Name = "LB_jam";
            this.LB_jam.Size = new System.Drawing.Size(174, 149);
            this.LB_jam.TabIndex = 5;
            // 
            // LBL_suhu
            // 
            this.LBL_suhu.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LBL_suhu.AutoSize = true;
            this.LBL_suhu.Font = new System.Drawing.Font("Franklin Gothic Medium", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_suhu.ForeColor = System.Drawing.Color.White;
            this.LBL_suhu.Location = new System.Drawing.Point(291, 46);
            this.LBL_suhu.Name = "LBL_suhu";
            this.LBL_suhu.Size = new System.Drawing.Size(58, 29);
            this.LBL_suhu.TabIndex = 4;
            this.LBL_suhu.Text = "NaN";
            // 
            // LBL_kelembapan
            // 
            this.LBL_kelembapan.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LBL_kelembapan.AutoSize = true;
            this.LBL_kelembapan.Font = new System.Drawing.Font("Franklin Gothic Medium", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_kelembapan.ForeColor = System.Drawing.Color.White;
            this.LBL_kelembapan.Location = new System.Drawing.Point(291, 94);
            this.LBL_kelembapan.Name = "LBL_kelembapan";
            this.LBL_kelembapan.Size = new System.Drawing.Size(58, 29);
            this.LBL_kelembapan.TabIndex = 3;
            this.LBL_kelembapan.Text = "NaN";
            // 
            // LB_dataLogger
            // 
            this.LB_dataLogger.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LB_dataLogger.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_dataLogger.FormattingEnabled = true;
            this.LB_dataLogger.ItemHeight = 29;
            this.LB_dataLogger.Location = new System.Drawing.Point(296, 145);
            this.LB_dataLogger.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.LB_dataLogger.Name = "LB_dataLogger";
            this.LB_dataLogger.Size = new System.Drawing.Size(178, 149);
            this.LB_dataLogger.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Franklin Gothic Medium", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(102, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(168, 29);
            this.label3.TabIndex = 1;
            this.label3.Text = "Kelembaban : ";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Franklin Gothic Medium", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(183, 46);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 29);
            this.label5.TabIndex = 0;
            this.label5.Text = "Suhu : ";
            // 
            // panel6
            // 
            this.panel6.AutoSize = true;
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(33)))), ((int)(((byte)(61)))));
            this.panel6.Controls.Add(this.label6);
            this.panel6.Controls.Add(this.label7);
            this.panel6.Controls.Add(this.GaugeSuhu);
            this.panel6.Controls.Add(this.GaugeKelembapan);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel6.Location = new System.Drawing.Point(624, 15);
            this.panel6.Margin = new System.Windows.Forms.Padding(11, 10, 11, 10);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(546, 334);
            this.panel6.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Franklin Gothic Medium", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(296, 59);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(168, 29);
            this.label6.TabIndex = 5;
            this.label6.Text = "Kelembaban : ";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Franklin Gothic Medium", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(52, 59);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(138, 29);
            this.label7.TabIndex = 5;
            this.label7.Text = "Suhu (°C) : ";
            // 
            // GaugeSuhu
            // 
            this.GaugeSuhu.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.GaugeSuhu.BackColor = System.Drawing.Color.White;
            this.GaugeSuhu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.GaugeSuhu.ForeColor = System.Drawing.Color.Black;
            this.GaugeSuhu.Location = new System.Drawing.Point(58, 112);
            this.GaugeSuhu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.GaugeSuhu.Name = "GaugeSuhu";
            this.GaugeSuhu.Size = new System.Drawing.Size(220, 152);
            this.GaugeSuhu.TabIndex = 1;
            this.GaugeSuhu.Text = "angularGauge2";
            // 
            // GaugeKelembapan
            // 
            this.GaugeKelembapan.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.GaugeKelembapan.BackColor = System.Drawing.Color.White;
            this.GaugeKelembapan.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.GaugeKelembapan.ForeColor = System.Drawing.Color.Black;
            this.GaugeKelembapan.Location = new System.Drawing.Point(302, 112);
            this.GaugeKelembapan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.GaugeKelembapan.Name = "GaugeKelembapan";
            this.GaugeKelembapan.Size = new System.Drawing.Size(220, 152);
            this.GaugeKelembapan.TabIndex = 0;
            this.GaugeKelembapan.Text = "angularGauge1";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.AutoSize = true;
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(33)))), ((int)(((byte)(61)))));
            this.panel1.Controls.Add(this.chart1);
            this.panel1.Location = new System.Drawing.Point(15, 375);
            this.panel1.Margin = new System.Windows.Forms.Padding(10);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(30);
            this.panel1.Size = new System.Drawing.Size(1161, 253);
            this.panel1.TabIndex = 5;
            // 
            // chart1
            // 
            this.chart1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(53)))), ((int)(((byte)(81)))));
            this.chart1.BackSecondaryColor = System.Drawing.Color.White;
            this.chart1.BorderlineWidth = 3;
            this.chart1.BorderSkin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(163)))), ((int)(((byte)(17)))));
            this.chart1.BorderSkin.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(163)))), ((int)(((byte)(17)))));
            this.chart1.BorderSkin.PageColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(163)))), ((int)(((byte)(17)))));
            chartArea2.AxisX.TitleForeColor = System.Drawing.Color.White;
            chartArea2.AxisX2.TitleForeColor = System.Drawing.Color.White;
            chartArea2.AxisY.TitleForeColor = System.Drawing.Color.White;
            chartArea2.AxisY2.TitleForeColor = System.Drawing.Color.White;
            chartArea2.BackColor = System.Drawing.Color.Transparent;
            chartArea2.BorderColor = System.Drawing.Color.White;
            chartArea2.BorderWidth = 5;
            chartArea2.Name = "ChartArea1";
            chartArea2.ShadowColor = System.Drawing.Color.White;
            this.chart1.ChartAreas.Add(chartArea2);
            this.chart1.Dock = System.Windows.Forms.DockStyle.Fill;
            legend2.BackColor = System.Drawing.Color.Transparent;
            legend2.BorderColor = System.Drawing.Color.Transparent;
            legend2.BorderWidth = 2;
            legend2.ForeColor = System.Drawing.Color.White;
            legend2.HeaderSeparatorColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(163)))), ((int)(((byte)(17)))));
            legend2.ItemColumnSeparatorColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(163)))), ((int)(((byte)(17)))));
            legend2.Name = "Legend1";
            legend2.TitleBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(163)))), ((int)(((byte)(17)))));
            legend2.TitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(163)))), ((int)(((byte)(17)))));
            legend2.TitleSeparatorColor = System.Drawing.Color.White;
            this.chart1.Legends.Add(legend2);
            this.chart1.Location = new System.Drawing.Point(30, 30);
            this.chart1.Margin = new System.Windows.Forms.Padding(10);
            this.chart1.Name = "chart1";
            this.chart1.Padding = new System.Windows.Forms.Padding(5);
            series2.BackImageTransparentColor = System.Drawing.Color.White;
            series2.BackSecondaryColor = System.Drawing.Color.White;
            series2.BorderColor = System.Drawing.Color.White;
            series2.BorderWidth = 5;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series2.Color = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(163)))), ((int)(((byte)(17)))));
            series2.Font = new System.Drawing.Font("Franklin Gothic Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series2.LabelBackColor = System.Drawing.Color.Yellow;
            series2.LabelBorderColor = System.Drawing.Color.White;
            series2.LabelBorderWidth = 5;
            series2.LabelForeColor = System.Drawing.Color.White;
            series2.Legend = "Legend1";
            series2.MarkerBorderColor = System.Drawing.Color.White;
            series2.MarkerBorderWidth = 3;
            series2.MarkerColor = System.Drawing.Color.White;
            series2.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Circle;
            series2.Name = "Series1";
            series2.ShadowColor = System.Drawing.Color.White;
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(1101, 193);
            this.chart1.TabIndex = 2;
            this.chart1.Text = "chart1";
            // 
            // Panel_Monitoring
            // 
            this.Panel_Monitoring.AutoSize = true;
            this.Panel_Monitoring.Controls.Add(this.panel1);
            this.Panel_Monitoring.Controls.Add(this.tableLayoutPanel1);
            this.Panel_Monitoring.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Panel_Monitoring.Location = new System.Drawing.Point(265, 91);
            this.Panel_Monitoring.Margin = new System.Windows.Forms.Padding(11, 10, 11, 10);
            this.Panel_Monitoring.Name = "Panel_Monitoring";
            this.Panel_Monitoring.Size = new System.Drawing.Size(1186, 638);
            this.Panel_Monitoring.TabIndex = 5;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(33)))), ((int)(((byte)(61)))));
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(265, 180);
            this.panel3.TabIndex = 4;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(41, 41);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(172, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Btn_Monitor
            // 
            this.Btn_Monitor.Dock = System.Windows.Forms.DockStyle.Top;
            this.Btn_Monitor.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(33)))), ((int)(((byte)(61)))));
            this.Btn_Monitor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Monitor.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Monitor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(163)))), ((int)(((byte)(17)))));
            this.Btn_Monitor.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Monitor.Image")));
            this.Btn_Monitor.Location = new System.Drawing.Point(0, 180);
            this.Btn_Monitor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Btn_Monitor.Name = "Btn_Monitor";
            this.Btn_Monitor.Size = new System.Drawing.Size(265, 64);
            this.Btn_Monitor.TabIndex = 5;
            this.Btn_Monitor.Text = "Monitoring";
            this.Btn_Monitor.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.Btn_Monitor.UseVisualStyleBackColor = true;
            this.Btn_Monitor.Click += new System.EventHandler(this.Btn_Monitor_Click);
            // 
            // Btn_nav_save
            // 
            this.Btn_nav_save.Dock = System.Windows.Forms.DockStyle.Top;
            this.Btn_nav_save.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(33)))), ((int)(((byte)(61)))));
            this.Btn_nav_save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_nav_save.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_nav_save.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(163)))), ((int)(((byte)(17)))));
            this.Btn_nav_save.Image = ((System.Drawing.Image)(resources.GetObject("Btn_nav_save.Image")));
            this.Btn_nav_save.Location = new System.Drawing.Point(0, 244);
            this.Btn_nav_save.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Btn_nav_save.Name = "Btn_nav_save";
            this.Btn_nav_save.Size = new System.Drawing.Size(265, 64);
            this.Btn_nav_save.TabIndex = 6;
            this.Btn_nav_save.Text = "Save File";
            this.Btn_nav_save.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.Btn_nav_save.UseVisualStyleBackColor = true;
            this.Btn_nav_save.Click += new System.EventHandler(this.Btn_nav_save_Click);
            // 
            // Pan_clock
            // 
            this.Pan_clock.BackColor = System.Drawing.Color.Black;
            this.Pan_clock.Controls.Add(this.Lbl_Clock);
            this.Pan_clock.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Pan_clock.Location = new System.Drawing.Point(0, 679);
            this.Pan_clock.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Pan_clock.Name = "Pan_clock";
            this.Pan_clock.Size = new System.Drawing.Size(265, 50);
            this.Pan_clock.TabIndex = 15;
            // 
            // Lbl_Clock
            // 
            this.Lbl_Clock.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.Lbl_Clock.AutoSize = true;
            this.Lbl_Clock.Font = new System.Drawing.Font("MDEu PGothic", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Clock.ForeColor = System.Drawing.Color.LimeGreen;
            this.Lbl_Clock.Location = new System.Drawing.Point(21, 2);
            this.Lbl_Clock.Name = "Lbl_Clock";
            this.Lbl_Clock.Size = new System.Drawing.Size(180, 47);
            this.Lbl_Clock.TabIndex = 0;
            this.Lbl_Clock.Text = "00:00:00";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(9, 602);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(58, 68);
            this.listBox1.TabIndex = 31;
            this.listBox1.Visible = false;
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 16;
            this.listBox2.Location = new System.Drawing.Point(73, 603);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(58, 68);
            this.listBox2.TabIndex = 32;
            this.listBox2.Visible = false;
            // 
            // listBox3
            // 
            this.listBox3.FormattingEnabled = true;
            this.listBox3.ItemHeight = 16;
            this.listBox3.Location = new System.Drawing.Point(138, 602);
            this.listBox3.Name = "listBox3";
            this.listBox3.Size = new System.Drawing.Size(58, 68);
            this.listBox3.TabIndex = 33;
            this.listBox3.Visible = false;
            // 
            // listBox4
            // 
            this.listBox4.FormattingEnabled = true;
            this.listBox4.ItemHeight = 16;
            this.listBox4.Location = new System.Drawing.Point(9, 602);
            this.listBox4.Name = "listBox4";
            this.listBox4.Size = new System.Drawing.Size(58, 68);
            this.listBox4.TabIndex = 34;
            this.listBox4.Visible = false;
            // 
            // listBox5
            // 
            this.listBox5.FormattingEnabled = true;
            this.listBox5.ItemHeight = 16;
            this.listBox5.Location = new System.Drawing.Point(74, 602);
            this.listBox5.Name = "listBox5";
            this.listBox5.Size = new System.Drawing.Size(58, 68);
            this.listBox5.TabIndex = 35;
            this.listBox5.Visible = false;
            // 
            // listBox6
            // 
            this.listBox6.FormattingEnabled = true;
            this.listBox6.ItemHeight = 16;
            this.listBox6.Location = new System.Drawing.Point(138, 603);
            this.listBox6.Name = "listBox6";
            this.listBox6.Size = new System.Drawing.Size(58, 68);
            this.listBox6.TabIndex = 36;
            this.listBox6.Visible = false;
            // 
            // listBox7
            // 
            this.listBox7.FormattingEnabled = true;
            this.listBox7.ItemHeight = 16;
            this.listBox7.Location = new System.Drawing.Point(9, 602);
            this.listBox7.Name = "listBox7";
            this.listBox7.Size = new System.Drawing.Size(58, 68);
            this.listBox7.TabIndex = 37;
            this.listBox7.Visible = false;
            // 
            // listBox8
            // 
            this.listBox8.FormattingEnabled = true;
            this.listBox8.ItemHeight = 16;
            this.listBox8.Location = new System.Drawing.Point(73, 602);
            this.listBox8.Name = "listBox8";
            this.listBox8.Size = new System.Drawing.Size(58, 68);
            this.listBox8.TabIndex = 38;
            this.listBox8.Visible = false;
            // 
            // listBox9
            // 
            this.listBox9.FormattingEnabled = true;
            this.listBox9.ItemHeight = 16;
            this.listBox9.Location = new System.Drawing.Point(137, 602);
            this.listBox9.Name = "listBox9";
            this.listBox9.Size = new System.Drawing.Size(58, 68);
            this.listBox9.TabIndex = 39;
            this.listBox9.Visible = false;
            // 
            // listBox10
            // 
            this.listBox10.FormattingEnabled = true;
            this.listBox10.ItemHeight = 16;
            this.listBox10.Location = new System.Drawing.Point(9, 529);
            this.listBox10.Name = "listBox10";
            this.listBox10.Size = new System.Drawing.Size(58, 68);
            this.listBox10.TabIndex = 40;
            this.listBox10.Visible = false;
            // 
            // listBox11
            // 
            this.listBox11.FormattingEnabled = true;
            this.listBox11.ItemHeight = 16;
            this.listBox11.Location = new System.Drawing.Point(73, 529);
            this.listBox11.Name = "listBox11";
            this.listBox11.Size = new System.Drawing.Size(58, 68);
            this.listBox11.TabIndex = 41;
            this.listBox11.Visible = false;
            // 
            // listBox12
            // 
            this.listBox12.FormattingEnabled = true;
            this.listBox12.ItemHeight = 16;
            this.listBox12.Location = new System.Drawing.Point(137, 529);
            this.listBox12.Name = "listBox12";
            this.listBox12.Size = new System.Drawing.Size(58, 68);
            this.listBox12.TabIndex = 42;
            this.listBox12.Visible = false;
            // 
            // listBox13
            // 
            this.listBox13.FormattingEnabled = true;
            this.listBox13.ItemHeight = 16;
            this.listBox13.Location = new System.Drawing.Point(9, 602);
            this.listBox13.Name = "listBox13";
            this.listBox13.Size = new System.Drawing.Size(58, 68);
            this.listBox13.TabIndex = 43;
            this.listBox13.Visible = false;
            // 
            // listBox14
            // 
            this.listBox14.FormattingEnabled = true;
            this.listBox14.ItemHeight = 16;
            this.listBox14.Location = new System.Drawing.Point(73, 602);
            this.listBox14.Name = "listBox14";
            this.listBox14.Size = new System.Drawing.Size(58, 68);
            this.listBox14.TabIndex = 44;
            this.listBox14.Visible = false;
            // 
            // listBox15
            // 
            this.listBox15.FormattingEnabled = true;
            this.listBox15.ItemHeight = 16;
            this.listBox15.Location = new System.Drawing.Point(137, 602);
            this.listBox15.Name = "listBox15";
            this.listBox15.Size = new System.Drawing.Size(58, 68);
            this.listBox15.TabIndex = 45;
            this.listBox15.Visible = false;
            // 
            // listBox16
            // 
            this.listBox16.FormattingEnabled = true;
            this.listBox16.ItemHeight = 16;
            this.listBox16.Location = new System.Drawing.Point(202, 602);
            this.listBox16.Name = "listBox16";
            this.listBox16.Size = new System.Drawing.Size(58, 68);
            this.listBox16.TabIndex = 46;
            this.listBox16.Visible = false;
            // 
            // listBox17
            // 
            this.listBox17.FormattingEnabled = true;
            this.listBox17.ItemHeight = 16;
            this.listBox17.Location = new System.Drawing.Point(202, 602);
            this.listBox17.Name = "listBox17";
            this.listBox17.Size = new System.Drawing.Size(58, 68);
            this.listBox17.TabIndex = 47;
            this.listBox17.Visible = false;
            // 
            // listBox18
            // 
            this.listBox18.FormattingEnabled = true;
            this.listBox18.ItemHeight = 16;
            this.listBox18.Location = new System.Drawing.Point(201, 602);
            this.listBox18.Name = "listBox18";
            this.listBox18.Size = new System.Drawing.Size(58, 68);
            this.listBox18.TabIndex = 48;
            this.listBox18.Visible = false;
            // 
            // Btn_Connection
            // 
            this.Btn_Connection.Dock = System.Windows.Forms.DockStyle.Top;
            this.Btn_Connection.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(33)))), ((int)(((byte)(61)))));
            this.Btn_Connection.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Connection.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Connection.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(163)))), ((int)(((byte)(17)))));
            this.Btn_Connection.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Connection.Image")));
            this.Btn_Connection.Location = new System.Drawing.Point(0, 308);
            this.Btn_Connection.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Btn_Connection.Name = "Btn_Connection";
            this.Btn_Connection.Size = new System.Drawing.Size(265, 64);
            this.Btn_Connection.TabIndex = 49;
            this.Btn_Connection.Text = "Koneksi";
            this.Btn_Connection.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.Btn_Connection.UseVisualStyleBackColor = true;
            this.Btn_Connection.Click += new System.EventHandler(this.Btn_Connection_Click);
            // 
            // panel2
            // 
            this.panel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(33)))), ((int)(((byte)(61)))));
            this.panel2.Controls.Add(this.Btn_Connection);
            this.panel2.Controls.Add(this.listBox18);
            this.panel2.Controls.Add(this.listBox17);
            this.panel2.Controls.Add(this.listBox16);
            this.panel2.Controls.Add(this.listBox15);
            this.panel2.Controls.Add(this.listBox14);
            this.panel2.Controls.Add(this.listBox13);
            this.panel2.Controls.Add(this.listBox12);
            this.panel2.Controls.Add(this.listBox11);
            this.panel2.Controls.Add(this.listBox10);
            this.panel2.Controls.Add(this.listBox9);
            this.panel2.Controls.Add(this.listBox8);
            this.panel2.Controls.Add(this.listBox7);
            this.panel2.Controls.Add(this.listBox6);
            this.panel2.Controls.Add(this.listBox5);
            this.panel2.Controls.Add(this.listBox4);
            this.panel2.Controls.Add(this.listBox3);
            this.panel2.Controls.Add(this.listBox2);
            this.panel2.Controls.Add(this.listBox1);
            this.panel2.Controls.Add(this.Pan_clock);
            this.panel2.Controls.Add(this.Btn_nav_save);
            this.panel2.Controls.Add(this.Btn_Monitor);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(265, 729);
            this.panel2.TabIndex = 1;
            // 
            // panel8
            // 
            this.panel8.AutoSize = true;
            this.panel8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(33)))), ((int)(((byte)(61)))));
            this.panel8.Controls.Add(this.CB_autoFill);
            this.panel8.Controls.Add(this.button1);
            this.panel8.Controls.Add(this.LBL_status);
            this.panel8.Controls.Add(this.Gb_mati);
            this.panel8.Controls.Add(this.GB_nyala);
            this.panel8.Controls.Add(this.TB_BasePath);
            this.panel8.Controls.Add(this.label12);
            this.panel8.Controls.Add(this.label13);
            this.panel8.Controls.Add(this.TB_AuthSecret);
            this.panel8.Controls.Add(this.label14);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel8.Location = new System.Drawing.Point(20, 20);
            this.panel8.Margin = new System.Windows.Forms.Padding(11, 10, 11, 10);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(1146, 598);
            this.panel8.TabIndex = 5;
            // 
            // CB_autoFill
            // 
            this.CB_autoFill.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CB_autoFill.AutoSize = true;
            this.CB_autoFill.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CB_autoFill.ForeColor = System.Drawing.Color.White;
            this.CB_autoFill.Location = new System.Drawing.Point(609, 317);
            this.CB_autoFill.Name = "CB_autoFill";
            this.CB_autoFill.Size = new System.Drawing.Size(197, 36);
            this.CB_autoFill.TabIndex = 29;
            this.CB_autoFill.Text = "Isi Otomatis";
            this.CB_autoFill.UseVisualStyleBackColor = true;
            this.CB_autoFill.CheckedChanged += new System.EventHandler(this.CB_autoFill_CheckedChanged);
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button1.Location = new System.Drawing.Point(342, 385);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(496, 43);
            this.button1.TabIndex = 28;
            this.button1.Text = "Coba Koneksi";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // LBL_status
            // 
            this.LBL_status.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LBL_status.AutoSize = true;
            this.LBL_status.Font = new System.Drawing.Font("Franklin Gothic Medium", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_status.ForeColor = System.Drawing.Color.White;
            this.LBL_status.Location = new System.Drawing.Point(659, 235);
            this.LBL_status.Name = "LBL_status";
            this.LBL_status.Size = new System.Drawing.Size(233, 38);
            this.LBL_status.TabIndex = 27;
            this.LBL_status.Text = "Firebase Status";
            // 
            // Gb_mati
            // 
            this.Gb_mati.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Gb_mati.Image = ((System.Drawing.Image)(resources.GetObject("Gb_mati.Image")));
            this.Gb_mati.Location = new System.Drawing.Point(609, 231);
            this.Gb_mati.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Gb_mati.Name = "Gb_mati";
            this.Gb_mati.Size = new System.Drawing.Size(47, 48);
            this.Gb_mati.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Gb_mati.TabIndex = 26;
            this.Gb_mati.TabStop = false;
            // 
            // GB_nyala
            // 
            this.GB_nyala.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.GB_nyala.Image = ((System.Drawing.Image)(resources.GetObject("GB_nyala.Image")));
            this.GB_nyala.Location = new System.Drawing.Point(609, 231);
            this.GB_nyala.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.GB_nyala.Name = "GB_nyala";
            this.GB_nyala.Size = new System.Drawing.Size(47, 48);
            this.GB_nyala.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.GB_nyala.TabIndex = 25;
            this.GB_nyala.TabStop = false;
            // 
            // TB_BasePath
            // 
            this.TB_BasePath.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TB_BasePath.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_BasePath.Location = new System.Drawing.Point(342, 326);
            this.TB_BasePath.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TB_BasePath.Name = "TB_BasePath";
            this.TB_BasePath.Size = new System.Drawing.Size(221, 27);
            this.TB_BasePath.TabIndex = 24;
            // 
            // label12
            // 
            this.label12.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.label12.Location = new System.Drawing.Point(337, 212);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(133, 25);
            this.label12.TabIndex = 23;
            this.label12.Text = "Auth Secret :";
            // 
            // label13
            // 
            this.label13.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.label13.Location = new System.Drawing.Point(340, 289);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(126, 25);
            this.label13.TabIndex = 22;
            this.label13.Text = "BasePath :  ";
            // 
            // TB_AuthSecret
            // 
            this.TB_AuthSecret.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TB_AuthSecret.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_AuthSecret.Location = new System.Drawing.Point(342, 250);
            this.TB_AuthSecret.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TB_AuthSecret.Name = "TB_AuthSecret";
            this.TB_AuthSecret.Size = new System.Drawing.Size(221, 27);
            this.TB_AuthSecret.TabIndex = 21;
            // 
            // label14
            // 
            this.label14.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Franklin Gothic Medium", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.SystemColors.Window;
            this.label14.Location = new System.Drawing.Point(421, 141);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(322, 38);
            this.label14.TabIndex = 6;
            this.label14.Text = "Pengaturan Koneksi";
            // 
            // Panel_koneksi
            // 
            this.Panel_koneksi.Controls.Add(this.panel8);
            this.Panel_koneksi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Panel_koneksi.Location = new System.Drawing.Point(265, 91);
            this.Panel_koneksi.Margin = new System.Windows.Forms.Padding(5);
            this.Panel_koneksi.Name = "Panel_koneksi";
            this.Panel_koneksi.Padding = new System.Windows.Forms.Padding(20);
            this.Panel_koneksi.Size = new System.Drawing.Size(1186, 638);
            this.Panel_koneksi.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(53)))), ((int)(((byte)(81)))));
            this.ClientSize = new System.Drawing.Size(1451, 729);
            this.Controls.Add(this.Panel_koneksi);
            this.Controls.Add(this.Panel_Monitoring);
            this.Controls.Add(this.Panel_saveFile);
            this.Controls.Add(this.PnlFormLoader);
            this.Controls.Add(this.Panel_dashboard);
            this.Controls.Add(this.panel2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MinimumSize = new System.Drawing.Size(1298, 766);
            this.Name = "Form1";
            this.Text = "Monitor Inkubator Telur";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Shown += new System.EventHandler(this.Form1_Shown);
            this.Panel_dashboard.ResumeLayout(false);
            this.Panel_saveFile.ResumeLayout(false);
            this.Panel_saveFile.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.Panel_Monitoring.ResumeLayout(false);
            this.Panel_Monitoring.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.Pan_clock.ResumeLayout(false);
            this.Pan_clock.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Gb_mati)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GB_nyala)).EndInit();
            this.Panel_koneksi.ResumeLayout(false);
            this.Panel_koneksi.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel PnlFormLoader;
        private System.Windows.Forms.Timer timerChart;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel Panel_dashboard;
        private System.Windows.Forms.Timer timerJam;
        private System.Windows.Forms.Panel Panel_saveFile;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label Label_save_suhu;
        private System.Windows.Forms.Button BTN_SvExcel;
        private System.Windows.Forms.Button BTN_saveDataTelur;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.ListBox LB_jam;
        private System.Windows.Forms.Label LBL_suhu;
        private System.Windows.Forms.Label LBL_kelembapan;
        private System.Windows.Forms.ListBox LB_dataLogger;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private LiveCharts.WinForms.AngularGauge GaugeSuhu;
        private LiveCharts.WinForms.AngularGauge GaugeKelembapan;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Panel Panel_Monitoring;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button Btn_Monitor;
        private System.Windows.Forms.Button Btn_nav_save;
        private System.Windows.Forms.Panel Pan_clock;
        private System.Windows.Forms.Label Lbl_Clock;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.ListBox listBox3;
        private System.Windows.Forms.ListBox listBox4;
        private System.Windows.Forms.ListBox listBox5;
        private System.Windows.Forms.ListBox listBox6;
        private System.Windows.Forms.ListBox listBox7;
        private System.Windows.Forms.ListBox listBox8;
        private System.Windows.Forms.ListBox listBox9;
        private System.Windows.Forms.ListBox listBox10;
        private System.Windows.Forms.ListBox listBox11;
        private System.Windows.Forms.ListBox listBox12;
        private System.Windows.Forms.ListBox listBox13;
        private System.Windows.Forms.ListBox listBox14;
        private System.Windows.Forms.ListBox listBox15;
        private System.Windows.Forms.ListBox listBox16;
        private System.Windows.Forms.ListBox listBox17;
        private System.Windows.Forms.ListBox listBox18;
        private System.Windows.Forms.Button Btn_Connection;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label LBL_status;
        private System.Windows.Forms.PictureBox Gb_mati;
        private System.Windows.Forms.PictureBox GB_nyala;
        private System.Windows.Forms.TextBox TB_BasePath;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox TB_AuthSecret;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Panel Panel_koneksi;
        private System.Windows.Forms.CheckBox CB_autoFill;
    }
}

