using System;

namespace KursAgain
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button1 = new System.Windows.Forms.Button();
            this.lbl_pressure = new System.Windows.Forms.Label();
            this.lbl_percent = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.tbShowPressure = new System.Windows.Forms.TextBox();
            this.tbShowConcentration = new System.Windows.Forms.TextBox();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.label6 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label18 = new System.Windows.Forms.Label();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.lblV2 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.button7 = new System.Windows.Forms.Button();
            this.label21 = new System.Windows.Forms.Label();
            this.lbl_speed = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.lblTemperature = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.lblV1 = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.pbStorage = new System.Windows.Forms.ProgressBar();
            this.timer4 = new System.Windows.Forms.Timer(this.components);
            this.btnClear = new System.Windows.Forms.Button();
            this.nuPressureMin = new System.Windows.Forms.NumericUpDown();
            this.nuPressureMax = new System.Windows.Forms.NumericUpDown();
            this.nuTemperatureNeeded = new System.Windows.Forms.NumericUpDown();
            this.nuVStorage = new System.Windows.Forms.NumericUpDown();
            this.nuVTank = new System.Windows.Forms.NumericUpDown();
            this.nuConcentrationMin = new System.Windows.Forms.NumericUpDown();
            this.nuConcentrationMax = new System.Windows.Forms.NumericUpDown();
            this.panelTanks = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize) (this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.nuPressureMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.nuPressureMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.nuTemperatureNeeded)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.nuVStorage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.nuVTank)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.nuConcentrationMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.nuConcentrationMax)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Location = new System.Drawing.Point(273, 16);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 30);
            this.button1.TabIndex = 0;
            this.button1.Text = "Start";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lbl_pressure
            // 
            this.lbl_pressure.AutoSize = true;
            this.lbl_pressure.Location = new System.Drawing.Point(942, 327);
            this.lbl_pressure.Name = "lbl_pressure";
            this.lbl_pressure.Size = new System.Drawing.Size(13, 13);
            this.lbl_pressure.TabIndex = 2;
            this.lbl_pressure.Text = "_";
            // 
            // lbl_percent
            // 
            this.lbl_percent.AutoSize = true;
            this.lbl_percent.Location = new System.Drawing.Point(956, 257);
            this.lbl_percent.Name = "lbl_percent";
            this.lbl_percent.Size = new System.Drawing.Size(13, 13);
            this.lbl_percent.TabIndex = 3;
            this.lbl_percent.Text = "_";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.DarkRed;
            this.button2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button2.Location = new System.Drawing.Point(273, 52);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(112, 30);
            this.button2.TabIndex = 4;
            this.button2.Text = "Stop";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Red;
            this.button3.Location = new System.Drawing.Point(655, 291);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(119, 30);
            this.button3.TabIndex = 18;
            this.button3.Text = "Поломка клапана";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Green;
            this.button4.Location = new System.Drawing.Point(655, 325);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(119, 26);
            this.button4.TabIndex = 18;
            this.button4.Text = "Ремонт клапана";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // tbShowPressure
            // 
            this.tbShowPressure.AcceptsReturn = true;
            this.tbShowPressure.AcceptsTab = true;
            this.tbShowPressure.AllowDrop = true;
            this.tbShowPressure.Location = new System.Drawing.Point(780, 297);
            this.tbShowPressure.Name = "tbShowPressure";
            this.tbShowPressure.ReadOnly = true;
            this.tbShowPressure.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tbShowPressure.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbShowPressure.Size = new System.Drawing.Size(233, 20);
            this.tbShowPressure.TabIndex = 14;
            // 
            // tbShowConcentration
            // 
            this.tbShowConcentration.AcceptsReturn = true;
            this.tbShowConcentration.AcceptsTab = true;
            this.tbShowConcentration.AllowDrop = true;
            this.tbShowConcentration.Location = new System.Drawing.Point(780, 226);
            this.tbShowConcentration.Name = "tbShowConcentration";
            this.tbShowConcentration.ReadOnly = true;
            this.tbShowConcentration.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tbShowConcentration.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbShowConcentration.Size = new System.Drawing.Size(233, 20);
            this.tbShowConcentration.TabIndex = 15;
            // 
            // timer2
            // 
            this.timer2.Interval = 1500;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(60, 229);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 19;
            this.label6.Text = "label6";
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Red;
            this.button5.Location = new System.Drawing.Point(655, 219);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(119, 30);
            this.button5.TabIndex = 20;
            this.button5.Text = "Поломка насоса";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.Green;
            this.button6.Location = new System.Drawing.Point(655, 255);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(119, 24);
            this.button6.TabIndex = 21;
            this.button6.Text = "Ремонт насоса";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // timer3
            // 
            this.timer3.Interval = 1500;
            this.timer3.Tick += new System.EventHandler(this.timer3_Tick);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Silver;
            this.label7.Location = new System.Drawing.Point(662, 5);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(0, 13);
            this.label7.TabIndex = 22;
            this.label7.Visible = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Silver;
            this.label8.Location = new System.Drawing.Point(663, 22);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(107, 13);
            this.label8.TabIndex = 23;
            this.label8.Text = "min: 500-900 кг/см2";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Silver;
            this.label9.Location = new System.Drawing.Point(663, 39);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(117, 13);
            this.label9.TabIndex = 24;
            this.label9.Text = "max 1200-1700 кг см2";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (128)))), ((int) (((byte) (255)))), ((int) (((byte) (255)))));
            this.label10.Location = new System.Drawing.Point(662, 108);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(49, 13);
            this.label10.TabIndex = 27;
            this.label10.Text = "max 99%";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (128)))), ((int) (((byte) (255)))), ((int) (((byte) (255)))));
            this.label11.Location = new System.Drawing.Point(662, 91);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(49, 13);
            this.label11.TabIndex = 26;
            this.label11.Text = "min: 20%";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (128)))), ((int) (((byte) (255)))), ((int) (((byte) (255)))));
            this.label12.Location = new System.Drawing.Point(652, 64);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(132, 13);
            this.label12.TabIndex = 25;
            this.label12.Text = "Диапазон концентрации";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (128)))), ((int) (((byte) (255)))), ((int) (((byte) (255)))));
            this.label13.Location = new System.Drawing.Point(663, 75);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(59, 13);
            this.label13.TabIndex = 28;
            this.label13.Text = "реганетов";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(826, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(27, 13);
            this.label14.TabIndex = 29;
            this.label14.Text = "MIN";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(932, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(30, 13);
            this.label15.TabIndex = 30;
            this.label15.Text = "MAX";
            // 
            // textBox7
            // 
            this.textBox7.AllowDrop = true;
            this.textBox7.Location = new System.Drawing.Point(780, 142);
            this.textBox7.Multiline = true;
            this.textBox7.Name = "textBox7";
            this.textBox7.ReadOnly = true;
            this.textBox7.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox7.Size = new System.Drawing.Size(233, 56);
            this.textBox7.TabIndex = 31;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(970, 327);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(43, 13);
            this.label16.TabIndex = 33;
            this.label16.Text = "кг/см2";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(998, 257);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(15, 13);
            this.label17.TabIndex = 34;
            this.label17.Text = "%";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(85, 437);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(10, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = ",";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(69, 437);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(10, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = ",";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(53, 437);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(10, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = ",";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image) (resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(264, 274);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 32;
            this.pictureBox1.TabStop = false;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (128)))), ((int) (((byte) (255)))), ((int) (((byte) (255)))));
            this.label18.Location = new System.Drawing.Point(665, 125);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(68, 13);
            this.label18.TabIndex = 35;
            this.label18.Text = "delta >= 15%";
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(481, 178);
            this.textBox8.Name = "textBox8";
            this.textBox8.ReadOnly = true;
            this.textBox8.Size = new System.Drawing.Size(175, 20);
            this.textBox8.TabIndex = 36;
            // 
            // lblV2
            // 
            this.lblV2.AutoSize = true;
            this.lblV2.Location = new System.Drawing.Point(521, 206);
            this.lblV2.Name = "lblV2";
            this.lblV2.Size = new System.Drawing.Size(13, 13);
            this.lblV2.TabIndex = 37;
            this.lblV2.Text = "_";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(565, 206);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(21, 13);
            this.label20.TabIndex = 38;
            this.label20.Text = "м3";
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button7.Location = new System.Drawing.Point(511, 108);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(105, 23);
            this.button7.TabIndex = 41;
            this.button7.Text = "Перелив нефти";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(508, 16);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(111, 13);
            this.label21.TabIndex = 42;
            this.label21.Text = "Объем цистерны м3";
            // 
            // lbl_speed
            // 
            this.lbl_speed.AutoSize = true;
            this.lbl_speed.Location = new System.Drawing.Point(521, 244);
            this.lbl_speed.Name = "lbl_speed";
            this.lbl_speed.Size = new System.Drawing.Size(13, 13);
            this.lbl_speed.TabIndex = 43;
            this.lbl_speed.Text = "_";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(565, 242);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(31, 13);
            this.label23.TabIndex = 44;
            this.label23.Text = "м3/ч";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (255)))), ((int) (((byte) (192)))), ((int) (((byte) (255)))));
            this.label24.Location = new System.Drawing.Point(622, 145);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(152, 13);
            this.label24.TabIndex = 45;
            this.label24.Text = "Т нефти на поверхности 30С";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(280, 103);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(208, 13);
            this.label25.TabIndex = 47;
            this.label25.Text = "Требуемая температура нетфи (40-45С)";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(270, 162);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(221, 13);
            this.label26.TabIndex = 49;
            this.label26.Text = "Объем хранилища м3(кратен V цистерны)";
            // 
            // lblTemperature
            // 
            this.lblTemperature.AutoSize = true;
            this.lblTemperature.Location = new System.Drawing.Point(336, 206);
            this.lblTemperature.Name = "lblTemperature";
            this.lblTemperature.Size = new System.Drawing.Size(13, 13);
            this.lblTemperature.TabIndex = 50;
            this.lblTemperature.Text = "_";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(371, 206);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(14, 13);
            this.label28.TabIndex = 51;
            this.label28.Text = "С";
            // 
            // lblV1
            // 
            this.lblV1.AutoSize = true;
            this.lblV1.Location = new System.Drawing.Point(315, 236);
            this.lblV1.Name = "lblV1";
            this.lblV1.Size = new System.Drawing.Size(13, 13);
            this.lblV1.TabIndex = 52;
            this.lblV1.Text = "_";
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Location = new System.Drawing.Point(364, 236);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(21, 13);
            this.label30.TabIndex = 53;
            this.label30.Text = "м3";
            // 
            // pbStorage
            // 
            this.pbStorage.Location = new System.Drawing.Point(283, 255);
            this.pbStorage.Name = "pbStorage";
            this.pbStorage.Size = new System.Drawing.Size(150, 23);
            this.pbStorage.TabIndex = 54;
            // 
            // timer4
            // 
            this.timer4.Interval = 1500;
            this.timer4.Tick += new System.EventHandler(this.timer4_Tick);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(391, 16);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(90, 29);
            this.btnClear.TabIndex = 55;
            this.btnClear.Text = "Очистить";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // nuPressureMin
            // 
            this.nuPressureMin.Location = new System.Drawing.Point(801, 18);
            this.nuPressureMin.Maximum = new decimal(new int[] {900, 0, 0, 0});
            this.nuPressureMin.Minimum = new decimal(new int[] {500, 0, 0, 0});
            this.nuPressureMin.Name = "nuPressureMin";
            this.nuPressureMin.Size = new System.Drawing.Size(80, 20);
            this.nuPressureMin.TabIndex = 56;
            this.nuPressureMin.Value = new decimal(new int[] {500, 0, 0, 0});
            // 
            // nuPressureMax
            // 
            this.nuPressureMax.Location = new System.Drawing.Point(917, 18);
            this.nuPressureMax.Maximum = new decimal(new int[] {1700, 0, 0, 0});
            this.nuPressureMax.Minimum = new decimal(new int[] {1200, 0, 0, 0});
            this.nuPressureMax.Name = "nuPressureMax";
            this.nuPressureMax.Size = new System.Drawing.Size(74, 20);
            this.nuPressureMax.TabIndex = 57;
            this.nuPressureMax.Value = new decimal(new int[] {1200, 0, 0, 0});
            // 
            // nuTemperatureNeeded
            // 
            this.nuTemperatureNeeded.Location = new System.Drawing.Point(315, 122);
            this.nuTemperatureNeeded.Maximum = new decimal(new int[] {45, 0, 0, 0});
            this.nuTemperatureNeeded.Minimum = new decimal(new int[] {40, 0, 0, 0});
            this.nuTemperatureNeeded.Name = "nuTemperatureNeeded";
            this.nuTemperatureNeeded.Size = new System.Drawing.Size(117, 20);
            this.nuTemperatureNeeded.TabIndex = 58;
            this.nuTemperatureNeeded.Value = new decimal(new int[] {40, 0, 0, 0});
            // 
            // nuVStorage
            // 
            this.nuVStorage.Location = new System.Drawing.Point(290, 183);
            this.nuVStorage.Maximum = new decimal(new int[] {10000, 0, 0, 0});
            this.nuVStorage.Name = "nuVStorage";
            this.nuVStorage.Size = new System.Drawing.Size(142, 20);
            this.nuVStorage.TabIndex = 59;
            this.nuVStorage.Value = new decimal(new int[] {35, 0, 0, 0});
            // 
            // nuVTank
            // 
            this.nuVTank.Location = new System.Drawing.Point(510, 37);
            this.nuVTank.Maximum = new decimal(new int[] {1000, 0, 0, 0});
            this.nuVTank.Name = "nuVTank";
            this.nuVTank.Size = new System.Drawing.Size(105, 20);
            this.nuVTank.TabIndex = 60;
            this.nuVTank.Value = new decimal(new int[] {5, 0, 0, 0});
            // 
            // nuConcentrationMin
            // 
            this.nuConcentrationMin.Location = new System.Drawing.Point(801, 91);
            this.nuConcentrationMin.Maximum = new decimal(new int[] {99, 0, 0, 0});
            this.nuConcentrationMin.Minimum = new decimal(new int[] {20, 0, 0, 0});
            this.nuConcentrationMin.Name = "nuConcentrationMin";
            this.nuConcentrationMin.Size = new System.Drawing.Size(80, 20);
            this.nuConcentrationMin.TabIndex = 61;
            this.nuConcentrationMin.Value = new decimal(new int[] {20, 0, 0, 0});
            // 
            // nuConcentrationMax
            // 
            this.nuConcentrationMax.Increment = new decimal(new int[] {20, 0, 0, 0});
            this.nuConcentrationMax.Location = new System.Drawing.Point(917, 89);
            this.nuConcentrationMax.Maximum = new decimal(new int[] {99, 0, 0, 0});
            this.nuConcentrationMax.Name = "nuConcentrationMax";
            this.nuConcentrationMax.Size = new System.Drawing.Size(74, 20);
            this.nuConcentrationMax.TabIndex = 62;
            this.nuConcentrationMax.Value = new decimal(new int[] {99, 0, 0, 0});
            // 
            // panelTanks
            // 
            this.panelTanks.Location = new System.Drawing.Point(29, 310);
            this.panelTanks.Name = "panelTanks";
            this.panelTanks.Size = new System.Drawing.Size(260, 69);
            this.panelTanks.TabIndex = 63;
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(1051, 448);
            this.Controls.Add(this.panelTanks);
            this.Controls.Add(this.nuConcentrationMax);
            this.Controls.Add(this.nuConcentrationMin);
            this.Controls.Add(this.nuVTank);
            this.Controls.Add(this.nuVStorage);
            this.Controls.Add(this.nuTemperatureNeeded);
            this.Controls.Add(this.nuPressureMax);
            this.Controls.Add(this.nuPressureMin);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.pbStorage);
            this.Controls.Add(this.label30);
            this.Controls.Add(this.lblV1);
            this.Controls.Add(this.label28);
            this.Controls.Add(this.lblTemperature);
            this.Controls.Add(this.label26);
            this.Controls.Add(this.label25);
            this.Controls.Add(this.label24);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.lbl_speed);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.lblV2);
            this.Controls.Add(this.textBox8);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbShowConcentration);
            this.Controls.Add(this.tbShowPressure);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.lbl_percent);
            this.Controls.Add(this.lbl_pressure);
            this.Controls.Add(this.button1);
            this.Location = new System.Drawing.Point(15, 15);
            this.Name = "Form1";
            this.RightToLeftLayout = true;
            ((System.ComponentModel.ISupportInitialize) (this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.nuPressureMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.nuPressureMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.nuTemperatureNeeded)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.nuVStorage)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.nuVTank)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.nuConcentrationMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.nuConcentrationMax)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.ProgressBar pbStorage;

        private System.Windows.Forms.Panel panelTanks;

        private System.Windows.Forms.Label lbl_percent;

        private System.Windows.Forms.Label lbl_pressure;

        private System.Windows.Forms.Label lbl_speed;

        private System.Windows.Forms.Label lblV2;

        private System.Windows.Forms.Label lblV1;

        private System.Windows.Forms.NumericUpDown nuConcentrationMax;
        private System.Windows.Forms.NumericUpDown nuConcentrationMin;

        private System.Windows.Forms.NumericUpDown nuVTank;

        private System.Windows.Forms.NumericUpDown nuVStorage;

        private System.Windows.Forms.NumericUpDown nuTemperatureNeeded;

        private System.Windows.Forms.NumericUpDown nuPressureMax;
        private System.Windows.Forms.NumericUpDown nuPressureMin;

        private System.Windows.Forms.Button btnClear;

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox tbShowPressure;
        private System.Windows.Forms.TextBox tbShowConcentration;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Timer timer3;
        private System.Windows.Forms.HelpProvider helpProvider1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label lblTemperature;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.Timer timer4;
    }
}

