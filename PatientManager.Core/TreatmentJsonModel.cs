namespace PatientManager.Core
{
    public class TreatmentJsonModel : BaseModel
    {
        public int MedicineId { get; set; }
        public int PatientId { get; set; }
        public string Date { get; set; }
        public int DayInterval { get; set; }
        public string Description { get; set; }
        public new string Name
        {
            get { return $"{Id}. {PatientId}, {MedicineId}"; }
        }
    }
}