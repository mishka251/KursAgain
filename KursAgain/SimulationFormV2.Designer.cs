using System;

namespace KursAgain
{
    partial class SimulationFormV2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SimulationFormV2));
            this.btnStart = new System.Windows.Forms.Button();
            this.lbl_pressure = new System.Windows.Forms.Label();
            this.lbl_percent = new System.Windows.Forms.Label();
            this.btnStop = new System.Windows.Forms.Button();
            this.brokePressureBtn = new System.Windows.Forms.Button();
            this.repairPressureBtn = new System.Windows.Forms.Button();
            this.fuelFillTimer = new System.Windows.Forms.Timer(this.components);
            this.tbShowPressure = new System.Windows.Forms.TextBox();
            this.tbShowConcentration = new System.Windows.Forms.TextBox();
            this.temperatureTimer = new System.Windows.Forms.Timer(this.components);
            this.label6 = new System.Windows.Forms.Label();
            this.brokeConcentrationBtn = new System.Windows.Forms.Button();
            this.repairConcentrationBtn = new System.Windows.Forms.Button();
            this.autoRepairPressureTimer = new System.Windows.Forms.Timer(this.components);
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.tbLog = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label18 = new System.Windows.Forms.Label();
            this.tbFillingState = new System.Windows.Forms.TextBox();
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
            this.autoRepairConcentrationTimer = new System.Windows.Forms.Timer(this.components);
            this.btnClear = new System.Windows.Forms.Button();
            this.nuPressureMin = new System.Windows.Forms.NumericUpDown();
            this.nuPressureMax = new System.Windows.Forms.NumericUpDown();
            this.nuTemperatureNeeded = new System.Windows.Forms.NumericUpDown();
            this.nuVStorage = new System.Windows.Forms.NumericUpDown();
            this.nuVTank = new System.Windows.Forms.NumericUpDown();
            this.nuConcentrationMin = new System.Windows.Forms.NumericUpDown();
            this.nuConcentrationMax = new System.Windows.Forms.NumericUpDown();
            this.panelTanks = new System.Windows.Forms.Panel();
            this.currentTime = new System.Windows.Forms.Timer(this.components);
            this.lblCurrentTime = new System.Windows.Forms.Label();
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
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnStart.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnStart.Location = new System.Drawing.Point(271, 86);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(112, 30);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // lbl_pressure
            // 
            this.lbl_pressure.AutoSize = true;
            this.lbl_pressure.Location = new System.Drawing.Point(940, 397);
            this.lbl_pressure.Name = "lbl_pressure";
            this.lbl_pressure.Size = new System.Drawing.Size(13, 13);
            this.lbl_pressure.TabIndex = 2;
            this.lbl_pressure.Text = "_";
            // 
            // lbl_percent
            // 
            this.lbl_percent.AutoSize = true;
            this.lbl_percent.Location = new System.Drawing.Point(954, 327);
            this.lbl_percent.Name = "lbl_percent";
            this.lbl_percent.Size = new System.Drawing.Size(13, 13);
            this.lbl_percent.TabIndex = 3;
            this.lbl_percent.Text = "_";
            // 
            // btnStop
            // 
            this.btnStop.BackColor = System.Drawing.Color.DarkRed;
            this.btnStop.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnStop.Location = new System.Drawing.Point(271, 122);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(112, 30);
            this.btnStop.TabIndex = 4;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = false;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // brokePressureBtn
            // 
            this.brokePressureBtn.BackColor = System.Drawing.Color.Red;
            this.brokePressureBtn.Location = new System.Drawing.Point(653, 361);
            this.brokePressureBtn.Name = "brokePressureBtn";
            this.brokePressureBtn.Size = new System.Drawing.Size(119, 30);
            this.brokePressureBtn.TabIndex = 18;
            this.brokePressureBtn.Text = "Поломка клапана";
            this.brokePressureBtn.UseVisualStyleBackColor = false;
            this.brokePressureBtn.Click += new System.EventHandler(this.brokePressureBtn_Click);
            // 
            // repairPressureBtn
            // 
            this.repairPressureBtn.BackColor = System.Drawing.Color.Green;
            this.repairPressureBtn.Location = new System.Drawing.Point(653, 395);
            this.repairPressureBtn.Name = "repairPressureBtn";
            this.repairPressureBtn.Size = new System.Drawing.Size(119, 26);
            this.repairPressureBtn.TabIndex = 18;
            this.repairPressureBtn.Text = "Ремонт клапана";
            this.repairPressureBtn.UseVisualStyleBackColor = false;
            this.repairPressureBtn.Click += new System.EventHandler(this.repairPressureBtn_Click);
            // 
            // fuelFillTimer
            // 
            this.fuelFillTimer.Interval = 1500;
            this.fuelFillTimer.Tick += new System.EventHandler(this.fuelFillTimer_Tick);
            // 
            // tbShowPressure
            // 
            this.tbShowPressure.AcceptsReturn = true;
            this.tbShowPressure.AcceptsTab = true;
            this.tbShowPressure.AllowDrop = true;
            this.tbShowPressure.Location = new System.Drawing.Point(778, 367);
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
            this.tbShowConcentration.Location = new System.Drawing.Point(778, 296);
            this.tbShowConcentration.Name = "tbShowConcentration";
            this.tbShowConcentration.ReadOnly = true;
            this.tbShowConcentration.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tbShowConcentration.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbShowConcentration.Size = new System.Drawing.Size(233, 20);
            this.tbShowConcentration.TabIndex = 15;
            // 
            // temperatureTimer
            // 
            this.temperatureTimer.Interval = 1500;
            this.temperatureTimer.Tick += new System.EventHandler(this.temperatureTimer_Tick);
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
            // brokeConcentrationBtn
            // 
            this.brokeConcentrationBtn.BackColor = System.Drawing.Color.Red;
            this.brokeConcentrationBtn.Location = new System.Drawing.Point(653, 289);
            this.brokeConcentrationBtn.Name = "brokeConcentrationBtn";
            this.brokeConcentrationBtn.Size = new System.Drawing.Size(119, 30);
            this.brokeConcentrationBtn.TabIndex = 20;
            this.brokeConcentrationBtn.Text = "Поломка насоса";
            this.brokeConcentrationBtn.UseVisualStyleBackColor = false;
            this.brokeConcentrationBtn.Click += new System.EventHandler(this.brokeConcentrationBtn_Click);
            // 
            // repairConcentrationBtn
            // 
            this.repairConcentrationBtn.BackColor = System.Drawing.Color.Green;
            this.repairConcentrationBtn.Location = new System.Drawing.Point(653, 325);
            this.repairConcentrationBtn.Name = "repairConcentrationBtn";
            this.repairConcentrationBtn.Size = new System.Drawing.Size(119, 24);
            this.repairConcentrationBtn.TabIndex = 21;
            this.repairConcentrationBtn.Text = "Ремонт насоса";
            this.repairConcentrationBtn.UseVisualStyleBackColor = false;
            this.repairConcentrationBtn.Click += new System.EventHandler(this.repairConcentrationBtn_Click);
            // 
            // autoRepairPressureTimer
            // 
            this.autoRepairPressureTimer.Interval = 1500;
            this.autoRepairPressureTimer.Tick += new System.EventHandler(this.autoRepairPressureTimer_Tick);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Silver;
            this.label7.Location = new System.Drawing.Point(660, 75);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(0, 13);
            this.label7.TabIndex = 22;
            this.label7.Visible = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Silver;
            this.label8.Location = new System.Drawing.Point(686, 75);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(107, 13);
            this.label8.TabIndex = 23;
            this.label8.Text = "min: 500-900 кг/см2";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Silver;
            this.label9.Location = new System.Drawing.Point(676, 95);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(117, 13);
            this.label9.TabIndex = 24;
            this.label9.Text = "max 1200-1700 кг см2";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Yellow;
            this.label10.Location = new System.Drawing.Point(663, 168);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(49, 13);
            this.label10.TabIndex = 27;
            this.label10.Text = "max 99%";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Yellow;
            this.label11.Location = new System.Drawing.Point(663, 152);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(49, 13);
            this.label11.TabIndex = 26;
            this.label11.Text = "min: 20%";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Yellow;
            this.label12.Location = new System.Drawing.Point(650, 134);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(187, 13);
            this.label12.TabIndex = 25;
            this.label12.Text = "Диапазон концентрации реагентов";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(824, 70);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(27, 13);
            this.label14.TabIndex = 29;
            this.label14.Text = "MIN";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(930, 70);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(30, 13);
            this.label15.TabIndex = 30;
            this.label15.Text = "MAX";
            // 
            // tbLog
            // 
            this.tbLog.AllowDrop = true;
            this.tbLog.Location = new System.Drawing.Point(778, 212);
            this.tbLog.Multiline = true;
            this.tbLog.Name = "tbLog";
            this.tbLog.ReadOnly = true;
            this.tbLog.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbLog.Size = new System.Drawing.Size(233, 56);
            this.tbLog.TabIndex = 31;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(968, 397);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(43, 13);
            this.label16.TabIndex = 33;
            this.label16.Text = "кг/см2";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(996, 327);
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
            this.label18.BackColor = System.Drawing.Color.Yellow;
            this.label18.Location = new System.Drawing.Point(663, 188);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(68, 13);
            this.label18.TabIndex = 35;
            this.label18.Text = "delta >= 15%";
            // 
            // tbFillingState
            // 
            this.tbFillingState.Location = new System.Drawing.Point(479, 248);
            this.tbFillingState.Name = "tbFillingState";
            this.tbFillingState.ReadOnly = true;
            this.tbFillingState.Size = new System.Drawing.Size(175, 20);
            this.tbFillingState.TabIndex = 36;
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button7.Location = new System.Drawing.Point(509, 178);
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
            this.label21.Location = new System.Drawing.Point(506, 86);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(111, 13);
            this.label21.TabIndex = 42;
            this.label21.Text = "Объем цистерны м3";
            // 
            // lbl_speed
            // 
            this.lbl_speed.AutoSize = true;
            this.lbl_speed.Location = new System.Drawing.Point(519, 314);
            this.lbl_speed.Name = "lbl_speed";
            this.lbl_speed.Size = new System.Drawing.Size(13, 13);
            this.lbl_speed.TabIndex = 43;
            this.lbl_speed.Text = "_";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(563, 312);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(31, 13);
            this.label23.TabIndex = 44;
            this.label23.Text = "м3/ч";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (255)))), ((int) (((byte) (192)))), ((int) (((byte) (255)))));
            this.label24.Location = new System.Drawing.Point(620, 215);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(152, 13);
            this.label24.TabIndex = 45;
            this.label24.Text = "Т нефти на поверхности 30С";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(278, 173);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(208, 13);
            this.label25.TabIndex = 47;
            this.label25.Text = "Требуемая температура нетфи (40-45С)";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(268, 232);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(221, 13);
            this.label26.TabIndex = 49;
            this.label26.Text = "Объем хранилища м3(кратен V цистерны)";
            // 
            // lblTemperature
            // 
            this.lblTemperature.AutoSize = true;
            this.lblTemperature.Location = new System.Drawing.Point(334, 276);
            this.lblTemperature.Name = "lblTemperature";
            this.lblTemperature.Size = new System.Drawing.Size(13, 13);
            this.lblTemperature.TabIndex = 50;
            this.lblTemperature.Text = "_";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(369, 276);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(14, 13);
            this.label28.TabIndex = 51;
            this.label28.Text = "С";
            // 
            // lblV1
            // 
            this.lblV1.AutoSize = true;
            this.lblV1.Location = new System.Drawing.Point(313, 306);
            this.lblV1.Name = "lblV1";
            this.lblV1.Size = new System.Drawing.Size(13, 13);
            this.lblV1.TabIndex = 52;
            this.lblV1.Text = "_";
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Location = new System.Drawing.Point(362, 306);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(21, 13);
            this.label30.TabIndex = 53;
            this.label30.Text = "м3";
            // 
            // pbStorage
            // 
            this.pbStorage.Location = new System.Drawing.Point(281, 325);
            this.pbStorage.Name = "pbStorage";
            this.pbStorage.Size = new System.Drawing.Size(150, 23);
            this.pbStorage.TabIndex = 54;
            // 
            // autoRepairConcentrationTimer
            // 
            this.autoRepairConcentrationTimer.Interval = 1500;
            this.autoRepairConcentrationTimer.Tick += new System.EventHandler(this.autoRepairConcentrationTimer_Tick);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(389, 86);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(90, 29);
            this.btnClear.TabIndex = 55;
            this.btnClear.Text = "Очистить";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // nuPressureMin
            // 
            this.nuPressureMin.Location = new System.Drawing.Point(799, 88);
            this.nuPressureMin.Maximum = new decimal(new int[] {900, 0, 0, 0});
            this.nuPressureMin.Minimum = new decimal(new int[] {500, 0, 0, 0});
            this.nuPressureMin.Name = "nuPressureMin";
            this.nuPressureMin.Size = new System.Drawing.Size(80, 20);
            this.nuPressureMin.TabIndex = 56;
            this.nuPressureMin.Value = new decimal(new int[] {500, 0, 0, 0});
            // 
            // nuPressureMax
            // 
            this.nuPressureMax.Location = new System.Drawing.Point(915, 88);
            this.nuPressureMax.Maximum = new decimal(new int[] {1700, 0, 0, 0});
            this.nuPressureMax.Minimum = new decimal(new int[] {1200, 0, 0, 0});
            this.nuPressureMax.Name = "nuPressureMax";
            this.nuPressureMax.Size = new System.Drawing.Size(74, 20);
            this.nuPressureMax.TabIndex = 57;
            this.nuPressureMax.Value = new decimal(new int[] {1200, 0, 0, 0});
            // 
            // nuTemperatureNeeded
            // 
            this.nuTemperatureNeeded.Location = new System.Drawing.Point(313, 192);
            this.nuTemperatureNeeded.Maximum = new decimal(new int[] {45, 0, 0, 0});
            this.nuTemperatureNeeded.Minimum = new decimal(new int[] {40, 0, 0, 0});
            this.nuTemperatureNeeded.Name = "nuTemperatureNeeded";
            this.nuTemperatureNeeded.Size = new System.Drawing.Size(117, 20);
            this.nuTemperatureNeeded.TabIndex = 58;
            this.nuTemperatureNeeded.Value = new decimal(new int[] {40, 0, 0, 0});
            // 
            // nuVStorage
            // 
            this.nuVStorage.Location = new System.Drawing.Point(288, 253);
            this.nuVStorage.Maximum = new decimal(new int[] {10000, 0, 0, 0});
            this.nuVStorage.Name = "nuVStorage";
            this.nuVStorage.Size = new System.Drawing.Size(142, 20);
            this.nuVStorage.TabIndex = 59;
            this.nuVStorage.Value = new decimal(new int[] {3500, 0, 0, 0});
            // 
            // nuVTank
            // 
            this.nuVTank.Location = new System.Drawing.Point(508, 107);
            this.nuVTank.Maximum = new decimal(new int[] {1000, 0, 0, 0});
            this.nuVTank.Name = "nuVTank";
            this.nuVTank.Size = new System.Drawing.Size(105, 20);
            this.nuVTank.TabIndex = 60;
            this.nuVTank.Value = new decimal(new int[] {500, 0, 0, 0});
            // 
            // nuConcentrationMin
            // 
            this.nuConcentrationMin.Location = new System.Drawing.Point(799, 161);
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
            this.nuConcentrationMax.Location = new System.Drawing.Point(915, 159);
            this.nuConcentrationMax.Maximum = new decimal(new int[] {99, 0, 0, 0});
            this.nuConcentrationMax.Name = "nuConcentrationMax";
            this.nuConcentrationMax.Size = new System.Drawing.Size(74, 20);
            this.nuConcentrationMax.TabIndex = 62;
            this.nuConcentrationMax.Value = new decimal(new int[] {99, 0, 0, 0});
            // 
            // panelTanks
            // 
            this.panelTanks.AutoScroll = true;
            this.panelTanks.Location = new System.Drawing.Point(5, 308);
            this.panelTanks.Name = "panelTanks";
            this.panelTanks.Size = new System.Drawing.Size(260, 113);
            this.panelTanks.TabIndex = 63;
            // 
            // currentTime
            // 
            this.currentTime.Enabled = true;
            this.currentTime.Tick += new System.EventHandler(this.currentTime_Tick);
            // 
            // lblCurrentTime
            // 
            this.lblCurrentTime.BackColor = System.Drawing.Color.Black;
            this.lblCurrentTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.lblCurrentTime.ForeColor = System.Drawing.Color.Lime;
            this.lblCurrentTime.Location = new System.Drawing.Point(389, 9);
            this.lblCurrentTime.Name = "lblCurrentTime";
            this.lblCurrentTime.Size = new System.Drawing.Size(205, 43);
            this.lblCurrentTime.TabIndex = 64;
            this.lblCurrentTime.Text = "TIME";
            // 
            // SimulationFormV2
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(1068, 448);
            this.Controls.Add(this.lblCurrentTime);
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
            this.Controls.Add(this.tbFillingState);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.tbLog);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.repairConcentrationBtn);
            this.Controls.Add(this.brokeConcentrationBtn);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbShowConcentration);
            this.Controls.Add(this.tbShowPressure);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.repairPressureBtn);
            this.Controls.Add(this.brokePressureBtn);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.lbl_percent);
            this.Controls.Add(this.lbl_pressure);
            this.Controls.Add(this.btnStart);
            this.Location = new System.Drawing.Point(15, 15);
            this.Name = "SimulationFormV2";
            this.RightToLeftLayout = true;
            this.Load += new System.EventHandler(this.SimulationFormV2_Load);
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

        private System.Windows.Forms.Label lblCurrentTime;

        private System.Windows.Forms.Timer currentTime;


        private System.Windows.Forms.ProgressBar pbStorage;

        private System.Windows.Forms.Panel panelTanks;

        private System.Windows.Forms.Label lbl_percent;

        private System.Windows.Forms.Label lbl_pressure;

        private System.Windows.Forms.Label lbl_speed;

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

        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button brokePressureBtn;
        private System.Windows.Forms.Button repairPressureBtn;
        private System.Windows.Forms.Timer fuelFillTimer;
        private System.Windows.Forms.TextBox tbShowPressure;
        private System.Windows.Forms.TextBox tbShowConcentration;
        private System.Windows.Forms.Timer temperatureTimer;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button brokeConcentrationBtn;
        private System.Windows.Forms.Button repairConcentrationBtn;
        private System.Windows.Forms.Timer autoRepairPressureTimer;
        private System.Windows.Forms.HelpProvider helpProvider1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox tbLog;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox tbFillingState;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label lblTemperature;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.Timer autoRepairConcentrationTimer;
    }
}

