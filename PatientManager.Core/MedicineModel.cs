namespace PatientManager.Core
{
    public class MedicineModel : BaseModel
    {
        //TODO
        //JSON file contains only patient's Ids. Once the PatientModel is created List<PatientModel> is implemented.
        public List<int> Patients { get; set; }
        //public int NumberOfPatients => Patients.Count;
        public int? NumberOfPatients { get => Patients?.Count; }
        public string Description { get; set; }
    }
}
