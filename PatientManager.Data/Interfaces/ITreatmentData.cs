using PatientManager.Core;

namespace PatientManager.Data
{
    public interface ITreatmentData : IBaseData
    {
        public void Add(TreatmentModel model);
        public bool Delete(int id);
        public void Update(TreatmentModel model);
        public List<TreatmentModel> GetAll();
        public List<TreatmentModel> GetAllReletedToName(string name);
        public TreatmentModel GetById(int id);
    }
}