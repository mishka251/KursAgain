namespace KursAgain
{
    /// <summary>
    /// Начальные данные для симуляции
    /// </summary>
    public class SimulationParams
    {
        public int PressureMin { get; set; }
        public int PressureMax { get; set; }

        public int ConcentrationsMin { get; set; }
        public int ConcentrationMax { get; set; }

        public int StorageV { get; set; }
        public int TankV { get; set; }
        public int NeededTemperature { get; set; }

        public int TanksCount
        {
            get => this.StorageV / this.TankV;
        }

        public SimulationParams(int pressureMin, int pressureMax, int concentrationsMin, int concentrationMax, int storageV, int tankV, int neededTemperature)
        {
            PressureMin = pressureMin;
            PressureMax = pressureMax;
            ConcentrationsMin = concentrationsMin;
            ConcentrationMax = concentrationMax;
            StorageV = storageV;
            TankV = tankV;
            NeededTemperature = neededTemperature;
        }

        public bool IsValid()
        {
            return ((PressureMin <= PressureMax) &&
                    ((ConcentrationMax - ConcentrationsMin) >= 15) &&
                    (StorageV % TankV == 0));
        }
    }
}