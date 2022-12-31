namespace PatientManager.Core
{
    public class MedicineMonthDoses
    {
        public List<DateOnly> Dates { get; set; }
        public int MedicineId { get; set; }
        public string MedicineFullName { get; set; }
        public int Doses { get; set; }
    }
}
