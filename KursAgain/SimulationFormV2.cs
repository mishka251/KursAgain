using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace KursAgain
{
    //Описание переменных
    public partial class SimulationFormV2 : Form
    {
        private SimulationParams simulationParams;
        private SimulationState simulationState;

        List<ProgressBar> pbTanks = new List<ProgressBar>();
        List<Label> lblTanks = new List<Label>();

        public SimulationFormV2()
        {
            InitializeComponent();
        }

        void parseData()
        {
            int pressureMin = Convert.ToInt32(nuPressureMin.Value);
            int pressureMax = Convert.ToInt32(nuPressureMax.Text);
            int concentrationsMin = Convert.ToInt32(nuConcentrationMin.Text);
            int concentrationMax = Convert.ToInt32(nuConcentrationMax.Text);
            int tankV = Convert.ToInt32(nuVTank.Text);
            int neededTemperature = Convert.ToInt32(nuTemperatureNeeded.Value);
            int storageV = Convert.ToInt32(nuVStorage.Value);


            this.simulationParams = new SimulationParams(pressureMin, pressureMax, concentrationsMin, concentrationMax,
                storageV, tankV, neededTemperature);
        }

        public void btnStart_Click(object sender, EventArgs e)
        {
            parseData();


            if (simulationParams.IsValid())
            {
                pbStorage.Maximum = simulationParams.StorageV;

                autoRepairConcentrationTimer.Stop();
                autoRepairPressureTimer.Stop();
                temperatureTimer.Start();
                fuelFillTimer.Start();

                tbLog.Text += "\r\n" + "Сисетма запущена";
                tbFillingState.Text += "Резервуар наполняется";

                int tanksCount = simulationParams.TanksCount;

                panelTanks.Controls.Clear();
                pbTanks.Clear();

                for (int i = 0; i < tanksCount; i++)
                {
                    ProgressBar pb = new VerticalprogressBar()
                    {
                        Top = 1,
                        Left = 10 + i * (20 + 10),
                        Height = 40,
                        Width = 20,
                        Maximum = simulationParams.TankV
                    };

                    Label lbl = new Label()
                    {
                        Top = 51,
                        Left = 5 + i * (20 + 10),
                        Height = 40,
                        Width = 30,
                    };

                    panelTanks.Controls.Add(pb);
                    pbTanks.Add(pb);

                    lblTanks.Add(lbl);
                    panelTanks.Controls.Add(lbl);
                }

                this.simulationState = new SimulationState(this.simulationParams);
            }
            else
            {
                MessageBox.Show("Неверно введены параметры, смотри справку");
            }
        }


        #region showData

        void showFuelLevel(int fuelInStorage, List<int> fuelInTanks)
        {
            for (int i = 0; i < fuelInTanks.Count; i++)
            {
                this.pbTanks[i].Value = fuelInTanks[i];
                this.lblTanks[i].Text = fuelInTanks[i].ToString();
            }

            this.pbStorage.Value = fuelInStorage;
            lblV1.Text = fuelInStorage.ToString();

            if (fuelInStorage == simulationParams.StorageV)
            {
                tbLog.Text += "\r\n" + "Резервуары наполнены, идет нагрев нефтепродуктов";
                tbFillingState.Text = "Резервуар заполнен";
            }
            else
            {
                tbFillingState.Text = "Резервуар наполняется";
            }
        }

        void ShowPressure(int pressure)
        {
            lbl_pressure.Text = pressure.ToString();
        }

        void showConcentration(int concentration)
        {
            lbl_percent.Text = concentration.ToString();
        }

        void showTemperature(double temperature)
        {
            lblTemperature.Text = Math.Round(temperature, 1).ToString();
        }

        void showSpeed(int speed)
        {
            lbl_speed.Text = (speed).ToString();
        }

        #endregion


        #region ConcentrationBrokeRepair

        //Инициализация аварии клапана
        private void brokeConcentrationBtn_Click(object sender, EventArgs e)
        {
            this.simulationState.BrokeConcentration();
            this.checkConcentrationState(this.simulationState.ConcentrationState);
        }

        private void repairConcentrationBtn_Click(object sender, EventArgs e)
        {
            this.simulationState.RepairConcentration();
            checkConcentrationState(simulationState.ConcentrationState);
        }

        void checkConcentrationState(ConcentrationState concentrationState)
        {
            if (concentrationState == ConcentrationState.OK)
            {
                tbShowConcentration.Text = "Концентрация реагентов в норме.";
                if (this.autoRepairConcentrationTimer.Enabled)
                {
                    this.autoRepairConcentrationTimer.Stop();
                }

                this.brokeConcentrationBtn.Enabled = true;
                this.repairConcentrationBtn.Enabled = false;

                if (!this.temperatureTimer.Enabled &&
                    this.simulationState.CurrentTemperature < this.simulationParams.NeededTemperature &&
                    this.simulationState.IsOk)
                {
                    this.temperatureTimer.Start();
                }

                if (!this.fuelFillTimer.Enabled && !this.simulationState.IsStorageFull && this.simulationState.IsOk)
                {
                    this.fuelFillTimer.Start();
                }
            }
            else
            {
                tbShowConcentration.Text = "Нарушение концентрации реагентов.";
                if (!this.autoRepairConcentrationTimer.Enabled)
                {
                    this.autoRepairConcentrationTimer.Start();
                }

                if (this.temperatureTimer.Enabled)
                {
                    this.temperatureTimer.Stop();
                }

                if (this.fuelFillTimer.Enabled)
                {
                    this.fuelFillTimer.Stop();
                }

                this.brokeConcentrationBtn.Enabled = false;
                this.repairConcentrationBtn.Enabled = true;
            }
            showConcentration(simulationState.CurrentConcentration);
        }

        private void autoRepairConcentrationTimer_Tick(object sender, EventArgs e)
        {
            simulationState.AutoRepairConcentrtion();
            this.checkConcentrationState(simulationState.ConcentrationState);
        }

        #endregion


        #region PressureBrokeRepair

        private void brokePressureBtn_Click(object sender, EventArgs e)
        {
            this.simulationState.BrokePressure();
            checkPressureState(simulationState.PressureState);
        }

        void checkPressureState(PressureState pressureState)
        {
            if (pressureState == PressureState.OK)
            {
                tbShowPressure.Text = "Давление в норме.";
                if (this.autoRepairPressureTimer.Enabled)
                {
                    this.autoRepairPressureTimer.Stop();
                }

                this.brokePressureBtn.Enabled = true;
                this.repairPressureBtn.Enabled = false;

                if (!this.fuelFillTimer.Enabled && !this.simulationState.IsStorageFull&& this.simulationState.IsOk)
                {
                    this.fuelFillTimer.Start();
                }
            }
            else
            {
                tbShowPressure.Text = "Нарушение давления в системе.";
                if (!this.autoRepairPressureTimer.Enabled )
                {
                    this.autoRepairPressureTimer.Start();
                }

                this.brokePressureBtn.Enabled = false;
                this.repairPressureBtn.Enabled = true;

                if (this.fuelFillTimer.Enabled)
                {
                    this.fuelFillTimer.Stop();
                }
            }
            ShowPressure(simulationState.CurrentPressure);
        }

        private void autoRepairPressureTimer_Tick(object sender, EventArgs e)
        {
            this.simulationState.AutoRepairPressure();

            this.checkPressureState(this.simulationState.PressureState);
        }

        private void repairPressureBtn_Click(object sender, EventArgs e)
        {
            this.simulationState.RepairPressure();
            this.checkPressureState(simulationState.PressureState);
        }

        #endregion

        //Инициализация копки СТОП
        private void btnStop_Click(object sender, EventArgs e)
        {
            fuelFillTimer.Stop();
            temperatureTimer.Stop();
            autoRepairPressureTimer.Stop();
            autoRepairConcentrationTimer.Stop();
            tbLog.Text += "\r\n" + "Сисетма остановлена";
        }

        //Инициализация кнопки СТАРТ
        public void fuelFillTimer_Tick(object sender, EventArgs e)
        {
            this.simulationState.UpdateFuelState();

            //Давление в системе
            ShowPressure(simulationState.CurrentPressure);

            //пропорции концентратов
            showConcentration(simulationState.CurrentConcentration);

            showTemperature(simulationState.CurrentTemperature);

            showSpeed(simulationState.CurrentFuelSpeed);

            checkPressureState(simulationState.PressureState);
            checkConcentrationState(simulationState.ConcentrationState);

            showFuelLevel(simulationState.FuelInStorage, simulationState.FuelInTanks);
            if (simulationState.FuelInStorage == simulationParams.StorageV)
            {
                fuelFillTimer.Stop();
                MessageBox.Show("Хранилище заполнено");
            }
        }


        //Таймер температуры
        private void temperatureTimer_Tick(object sender, EventArgs e)
        {
            this.simulationState.UpdateTemperature();
            this.showTemperature(simulationState.CurrentTemperature);
            checkTemperature(simulationState.CurrentTemperature);

            this.showConcentration(this.simulationState.CurrentConcentration);
            this.checkConcentrationState(this.simulationState.ConcentrationState);
        }

        void checkTemperature(double temperature)
        {
            if (temperature >= simulationParams.NeededTemperature)
            {
                temperatureTimer.Stop();
                MessageBox.Show("Нефть в хранилище нагрета");
            }
        }


        private void button7_Click(object sender, EventArgs e)
        {
            if (!this.fuelFillTimer.Enabled)
            {
                this.fuelFillTimer.Start();
            }
            else
            {
                this.fuelFillTimer.Stop();
            }
        }


        private void btnClear_Click(object sender, EventArgs e)
        {
            this.tbLog.Clear();
            this.tbFillingState.Clear();
            this.tbShowConcentration.Clear();
            this.tbShowPressure.Clear();

            this.lbl_percent.Text = "-";
            this.lblV1.Text = "-";
            this.lbl_pressure.Text = "-";
            this.lbl_speed.Text = "-";
            this.lblTemperature.Text = "-";

            this.pbStorage.Value = 0;
            this.panelTanks.Controls.Clear();
            this.pbTanks.Clear();
        }

        
        
        private void currentTime_Tick(object sender, EventArgs e)
        {
            DateTime currentTime = DateTime.Now;
            lblCurrentTime.Text = $"{currentTime.Hour}:{currentTime.Minute}:{currentTime.Second}";
        }

        private void SimulationFormV2_Load(object sender, EventArgs e)
        {
            DateTime currentTime = DateTime.Now;
            lblCurrentTime.Text = $"{currentTime.Hour}:{currentTime.Minute}:{currentTime.Second}";
        }
    }
}