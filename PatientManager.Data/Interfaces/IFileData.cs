using PatientManager.Core;
using PatientMenager.Data;

namespace PatientManager.Data
{
    public interface IFileData
    {
        public void AddJsonObject<T>(T newObject, FileNameType fileNameType);
        public List<T> GetJsonObjects<T>(FileNameType fileNameType);
        public void EditJsonMedicine(MedicineJsonModel newObject);
        public void EditJsonPatient(PatientJsonModel newObject);
        public void DeleteJsonMedicine(int id);
        public void DeleteJsonPatient(int id);
    }
}