namespace PatientManager.Core
{
    public class TreatmentModel : BaseModel
    {
        public MedicineModel Medicine { get; set; }
        public string MedicineName
        {
            get { return Medicine?.Name; }
        }
        public PatientModel Patient { get; set; }
        public string PatientName
        {
            get { return Patient?.Name; }
        }
        public DateOnly Date { get; set; }
        public int DayInterval { get; set; }
        public string Description { get; set; }
        public new string Name
        {
            get { return $"{Id}. {Patient?.Id}, {Medicine?.Id}"; }
        }
    }
}