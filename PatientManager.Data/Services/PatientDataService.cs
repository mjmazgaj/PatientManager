using PatientManager.Core;
using PatientMenager.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatientManager.Data.Services
{
    public class PatientDataService : IPatientData
    {
        private readonly FileDataService _fileData;

        public PatientDataService()
        {
            _fileData = new FileDataService();
        }
        public void Add(PatientModel model)
        {
            _fileData.AddJsonObject(PatientModelConvert.ToPatientJsonModel(model), FileNameType.Patient);
        }

        public int Count()
        {
            return _fileData.GetJsonObjects<PatientJsonModel>(FileNameType.Patient).Count;
        }

        public bool Delete(int id)
        {
            var patient = GetById(id);

            if (patient == null)
                return false;
            else
                _fileData.DeleteJsonPatient(id);

            return true;
        }

        public List<PatientModel> GetAll()
        {
            return _fileData.GetJsonObjects<PatientJsonModel>(FileNameType.Patient)
                            .Select(x => PatientModelConvert.ToPatientModel(x))
                            .OrderBy(x => x.Id)
                            .ToList();
        }

        public PatientModel GetById(int id)
        {
            var jsonModel = _fileData.GetJsonObjects<PatientJsonModel>(FileNameType.Patient)
                                     .OrderBy(x => x.Id)
                                     .FirstOrDefault(x => x.Id == id);

            return PatientModelConvert.ToPatientModel(jsonModel);
        }

        public List<PatientModel> GetAllReletedToName(string name)
        {
            return _fileData.GetJsonObjects<PatientJsonModel>(FileNameType.Patient)
                            .Where(x => string.IsNullOrEmpty(name) || x.Name.Contains(name))
                            .Select(x => PatientModelConvert.ToPatientModel(x))
                            .ToList();
        }

        public void Update(PatientModel model)
        {
            _fileData.EditJsonPatient(PatientModelConvert.ToPatientJsonModel(model));
        }
    }
}