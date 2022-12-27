using PatientManager.Core;

namespace PatientManager.Data.Services
{
    public class TreatmentDataService : ITreatmentData
    {
        private readonly FileDataService _fileData;

        public TreatmentDataService()
        {
            _fileData = new FileDataService();
        }
        public void Add(TreatmentModel model)
        {
            _fileData.AddJsonObject(TreatmentModelConvert.ToTreatmentJsonModel(model), FileNameType.Treatment);
        }

        public int Count()
        {
            return _fileData.GetJsonObjects<TreatmentJsonModel>(FileNameType.Treatment).Count;
        }

        public bool Delete(int id)
        {
            var treatment = GetById(id);

            if (treatment == null)
                return false;
            else
                _fileData.DeleteJsonTreatment(id);

            return true;
        }

        public List<TreatmentModel> GetAll()
        {
            return _fileData.GetJsonObjects<TreatmentJsonModel>(FileNameType.Treatment)
                            .Select(x => TreatmentModelConvert.ToTreatmentModel(x))
                            .OrderBy(x => x.Id)
                            .ToList();
        }

        public TreatmentModel GetById(int id)
        {
            var jsonModel = _fileData.GetJsonObjects<TreatmentJsonModel>(FileNameType.Treatment)
                                     .OrderBy(x => x.Id)
                                     .FirstOrDefault(x => x.Id == id);

            return TreatmentModelConvert.ToTreatmentModel(jsonModel);
        }

        public List<TreatmentModel> GetAllReletedToName(string name)
        {
            return _fileData.GetJsonObjects<TreatmentJsonModel>(FileNameType.Treatment)
                            .Where(x => string.IsNullOrEmpty(name) || x.Name.Contains(name))
                            .Select(x => TreatmentModelConvert.ToTreatmentModel(x))
                            .ToList();
        }

        public void Update(TreatmentModel model)
        {
            _fileData.EditJsonTreatment(TreatmentModelConvert.ToTreatmentJsonModel(model));
        }

        public int GetNextId()
        {
            var treatments = GetAll()?.OrderByDescending(x => x.Id).FirstOrDefault()?.Id;
            return treatments.HasValue ? treatments.Value + 1 : 1;
        }

        public List<MedicineModel> GetAllMedicines()
        {
            return new MedicineDataService().GetAll();
        }

        public List<PatientModel> GetAllPatientes()
        {
            return new PatientDataService().GetAll();
        }
        public List<TreatmentModel> GetAllTreatmentRelatedToPatient(int patientId)
        {
            return GetAll()
                    .Where(x => x.Patient.Id == patientId)
                    .ToList();
        }
        public List<PatientModel> GetAllPatientesRelatedToMedicine(int medicineId)
        {
            return GetAll()
                    .Where(x => x.Medicine.Id == medicineId)
                    .Select(x => x.Patient)
                    .ToList();
        }
        public List<MedicineModel> GetAllMedicinesRelatedToPatient(int patientId)
        {
            return GetAll()
                    .Where(x => x.Patient.Id == patientId)
                    .Select(x => x.Medicine)
                    .ToList();
        }
    }
}