using PatientManager.Core;

namespace PatientManager.Data.Services
{
    public class MedicineDataService : IMedicineData
    {
        private readonly FileDataService _fileData;

        public MedicineDataService()
        {
            _fileData = new FileDataService();
        }
        public void Add(MedicineModel model)
        {
            _fileData.AddJsonObject(MedicineModelConvert.ToMedicineJsonModel(model), FileNameType.Medicine);
        }

        public int Count()
        {
            return _fileData.GetJsonObjects<MedicineJsonModel>(FileNameType.Medicine).Count;
        }

        public bool Delete(int id)
        {
            var medicine = GetById(id);

            if (medicine == null)
                return false;
            else
                _fileData.DeleteJsonMedicine(id);

            return true;
        }

        public List<MedicineModel> GetAll()
        {
            return _fileData.GetJsonObjects<MedicineJsonModel>(FileNameType.Medicine)
                            .Select(x => MedicineModelConvert.ToMedicineModel(x))
                            .OrderBy(x => x.Name)
                            .ThenBy(x => x.Id)
                            .ToList();
        }

        public MedicineModel GetById(int id)
        {
            var jsonModel = _fileData.GetJsonObjects<MedicineJsonModel>(FileNameType.Medicine)
                                     .OrderBy(x => x.Id)
                                     .FirstOrDefault(x => x.Id == id);

            return MedicineModelConvert.ToMedicineModel(jsonModel);
        }

        public List<MedicineModel> GetAllReletedToName(string name)
        {
            return _fileData.GetJsonObjects<MedicineJsonModel>(FileNameType.Medicine)
                            .Where(x => string.IsNullOrEmpty(name) || x.Name.Contains(name))
                            .Select(x => MedicineModelConvert.ToMedicineModel(x))
                            .ToList();
        }

        public void Update(MedicineModel model)
        {
            _fileData.EditJsonMedicine(MedicineModelConvert.ToMedicineJsonModel(model));
        }

        public int GetNextId()
        {
            var medicines = GetAll()?.OrderByDescending(x => x.Id).FirstOrDefault()?.Id;
            return medicines.HasValue ? medicines.Value + 1 : 1;
        }
    }
}
