using PatientManager.Core.Enum;

namespace PatientManager.Core
{
    public class MedicineJsonModel : BaseModel
    {
        public decimal Count { get; set; }
        public MedicineUnits Unit { get; set; }
        public string Description { get; set; }
    }
}
