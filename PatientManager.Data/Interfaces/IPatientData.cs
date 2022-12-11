using PatientManager.Core;

namespace PatientManager.Data
{
    public interface IPatientData : IBaseData
    {
        public void Add(PatientModel model);
        public bool Delete(int id);
        public void Update(PatientModel model);
        public List<PatientModel> GetAll();
        public List<PatientModel> GetAllReletedToName(string name);
        public PatientModel GetById(int id);
    }
}