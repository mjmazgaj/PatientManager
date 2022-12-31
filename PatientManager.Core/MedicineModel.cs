using PatientManager.Core.Enum;

namespace PatientManager.Core
{
    public class MedicineModel : BaseModel
    {
        public string FullName
        {
            get { return $"{Name} ({Count} {Unit})"; }
        }
        public decimal Count { get; set; }
        public MedicineUnits Unit { get; set; }
        public string Description { get; set; }
    }
}
