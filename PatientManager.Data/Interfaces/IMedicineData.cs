using PatientManager.Core;

namespace PatientManager.Data
{
    public interface IMedicineData : IBaseData
    {
        public void Add(MedicineModel model);
        public bool Delete(int id);
        public void Update(MedicineModel model);
        public List<MedicineModel> GetAll();
        public List<MedicineModel> GetAllReletedToName(string name);
        public MedicineModel GetById(int id);
    }
}
