using System;
using System.Collections.Generic;

namespace KursAgain
{
    public enum PressureState
    {
        OK,
        BROKEN
    }

    public enum ConcentrationState
    {
        OK,
        BROKEN,
    }

    public class SimulationState
    {
        private SimulationParams initialParams;

        public int CurrentPressure => currentPressure;

        public double CurrentTemperature => currentTemperature;

        public int CurrentConcentration => currentConcentration;

        public int CurrentFuelSpeed => currentFuelSpeed;

        public List<int> FuelInTanks => fuelInTanks;

        public int FuelInStorage => fuelInStorage;

        public bool IsOk
        {
            get => pressureState == PressureState.OK && concentrationState == ConcentrationState.OK;
        }

        int currentPressure;
        private double currentTemperature;
        private int currentConcentration;

        private int currentFuelSpeed;
        private List<int> fuelInTanks;
        private int fuelInStorage;

        public PressureState PressureState => pressureState;

        public ConcentrationState ConcentrationState => concentrationState;

        private PressureState pressureState;
        private ConcentrationState concentrationState;

        private Random random;

        private int timeToRepairPressure = 10;
        private int timeToRepairConcentration = 10;

        private int filledTankIndex;

        private bool isAutoRepairingPressure = false;
        private bool isAutoRepairingConcentration = false;
        


        public bool IsStorageFull
        {
            get => fuelInStorage >= initialParams.StorageV;
        }

        public bool IsNeededTemperature
        {
            get => currentTemperature >= initialParams.NeededTemperature;
        }

        public SimulationState(SimulationParams initialParams)
        {
            this.initialParams = initialParams;
            this.random = new Random();
            this.fuelInTanks = new List<int>();
            for (int i = 0; i < initialParams.TanksCount; i++)
            {
                this.fuelInTanks.Add(0);
            }

            this.filledTankIndex = -1;
        }

        void GenerateNewPressure()
        {
            this.currentPressure = random.Next(initialParams.PressureMin - 40, initialParams.PressureMax + 40);
        }

        void GenerateNewConcentration()
        {
            this.currentConcentration =
                random.Next(initialParams.ConcentrationsMin - 3, initialParams.ConcentrationMax + 3);
        }

        bool IsPressureOk()
        {
            return this.initialParams.PressureMin <= this.currentPressure &&
                   this.currentPressure <= this.initialParams.PressureMax;
        }

        bool IsConcentrationOk()
        {
            return this.initialParams.ConcentrationsMin <= this.currentConcentration &&
                   this.currentConcentration <= this.initialParams.ConcentrationMax;
        }

        void SetFuelSpeed()
        {
            if (this.pressureState == PressureState.OK)
            {
                this.currentFuelSpeed = this.currentPressure / 15;
            }
            else
            {
                //TODO почему в исходной программе было также на давление/15? должно ли менятся?
                this.currentConcentration = 0;
            }
        }

        void FillFuelStorage()
        {
            if (this.filledTankIndex == -1)
            {
                this.filledTankIndex = 0;
            }

            if (this.filledTankIndex >= this.initialParams.TanksCount)
            {
                return;
            }

            if (this.fuelInTanks[this.filledTankIndex] >= this.initialParams.TankV)
            {
                this.filledTankIndex++;
            }

            if (this.filledTankIndex >= this.initialParams.TanksCount)
            {
                return;
            }

            int deltaFuel = Math.Min(currentFuelSpeed,
                this.initialParams.TankV - this.fuelInTanks[this.filledTankIndex]);

            this.fuelInTanks[this.filledTankIndex] += deltaFuel;
            this.fuelInStorage += deltaFuel;
        }

        public void BrokePressure()
        {
            this.timeToRepairPressure = 10;
            this.pressureState = PressureState.BROKEN;
        }

        public void BrokeConcentration()
        {
            this.timeToRepairConcentration = 10;
            this.concentrationState = ConcentrationState.BROKEN;
        }

        public void RepairPressure()
        {
            this.currentPressure =
                (this.initialParams.PressureMin + this.initialParams.PressureMax) / 2;
            this.pressureState = PressureState.OK;
            this.isAutoRepairingPressure = false;
        }

        public void RepairConcentration()
        {
            this.currentConcentration =
                (this.initialParams.ConcentrationMax + this.initialParams.ConcentrationsMin) / 2;
            this.concentrationState = ConcentrationState.OK;
            this.isAutoRepairingConcentration = false;
        }

        public void AutoRepairPressure()
        {
            this.isAutoRepairingPressure = true;
            if (this.pressureState == PressureState.OK)
            {
                return;
            }

            if (this.timeToRepairPressure > 0)
            {
                this.timeToRepairPressure--;
                return;
            }

            this.RepairPressure();
        }

        public void AutoRepairConcentrtion()
        {
            this.isAutoRepairingConcentration = true;
            if (this.concentrationState == ConcentrationState.OK)
            {
                return;
            }

            if (this.timeToRepairConcentration > 0)
            {
                this.timeToRepairConcentration--;
                return;
            }

            this.RepairConcentration();
        }


        public void UpdateTemperature()
        {
            this.GenerateNewConcentration();
            if (!this.IsConcentrationOk())
            {
                this.BrokeConcentration();
            }
            
            const int tempDeltaInFilling = 30; //TODO почему 30?
            if (this.fuelInStorage > 0 && this.fuelInStorage < this.initialParams.StorageV)
            {
                this.currentTemperature =
                    (this.currentTemperature - tempDeltaInFilling) / 2 + tempDeltaInFilling;
            }

            if (this.fuelInStorage == this.initialParams.StorageV)
            {
                this.currentTemperature += 0.3;
            }
        }

        /// <summary>
        /// Перекачка
        /// </summary>
        public void UpdateFuelState()
        {
            this.GenerateNewPressure();
            if (!this.IsPressureOk())
            {
                this.BrokePressure();
            }

            this.GenerateNewConcentration();
            if (!this.IsConcentrationOk())
            {
                this.BrokeConcentration();
            }

            this.SetFuelSpeed();
            this.FillFuelStorage();
        }
    }
}