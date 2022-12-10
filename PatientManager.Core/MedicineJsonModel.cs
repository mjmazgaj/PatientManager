namespace PatientManager.Core
{
    public class MedicineJsonModel : BaseModel
    {
        public List<int> PatientIds { get; set; }
        public string Description { get; set; }
    }
}
