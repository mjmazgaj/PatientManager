namespace PatientManager.Core
{
    public class PatientJsonModel : BaseModel
    {
        public List<int> TreatmentIds { get; set; }
        public string Description { get; set; }
    }
}