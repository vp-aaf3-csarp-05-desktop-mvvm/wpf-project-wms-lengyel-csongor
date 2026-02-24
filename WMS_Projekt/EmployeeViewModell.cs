using CommunityToolkit.Mvvm.ComponentModel;

namespace WMS_Projekt
{
    /// <summary>
    /// Dolgozó adatok megjelenítéshez (szabadnapkezelés)
    /// </summary>
    public partial class EmployeeViewModell : ObservableObject 
    {
        /// <summary>
        /// Dolgozó neve
        /// </summary>
        public string Name { get; } = "Nagy Anna";

        /// <summary>
        /// Adószám
        /// </summary>
        public string TaxNumber { get; } = "12345678-1-42";

        /// <summary>
        /// Kivett szabadnapok száma
        /// </summary>
        [ObservableProperty]
        [NotifyPropertyChangedFor(nameof(RemainingDays))]
        private int daysOff = 8;

        /// <summary>
        /// Szabadnapok száma
        /// </summary>
        private static int VacationDays = 45;

        /// <summary>
        /// Hátralévő szabadnapok száma
        /// </summary>
        public int RemainingDays => VacationDays - DaysOff;
    }
}
