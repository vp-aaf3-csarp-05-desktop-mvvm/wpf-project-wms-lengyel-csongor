namespace WMS_Projekt
{
    /// <summary>
    /// Dolgozó adatok megjelenítéshez (szabadnapkezelés)
    /// </summary>
    public class EmployeeViewModell
    {
        /// <summary>
        /// Dolgozó neve
        /// </summary>
        public string Name { get; } = "Nagy Hanna";
        /// <summary>
        /// Adószám
        /// </summary>
        public string TaxNumber { get; } = "1112223334";
        /// <summary>
        /// Kivett szabadnapok száma
        /// </summary>
        public int UsedDaysOff { get; } = 3;
    }
}
