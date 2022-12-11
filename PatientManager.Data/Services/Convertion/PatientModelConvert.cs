using PatientManager.Core;

namespace PatientManager.Data
{
    public static class PatientModelConvert
    {
        //TODO
        //PatientJsonModel has only Patient's Ids, PatientModel should have list of TreatmentModels.
        public static PatientModel ToPatientModel(PatientJsonModel jsonModel)
        {
            PatientModel patientModel = null;

            if (jsonModel != null)
            {
                patientModel = new PatientModel();

                patientModel.Id = jsonModel.Id;
                patientModel.Name = jsonModel.Name;
                patientModel.Treatments = jsonModel.TreatmentIds;
                patientModel.Description = jsonModel.Description;
            };

            return patientModel;
        }

        public static PatientJsonModel ToPatientJsonModel(PatientModel patientModel)
        {
            PatientJsonModel patientJsonModel = null;

            if (patientModel != null)
            {
                patientJsonModel = new PatientJsonModel();

                patientJsonModel.Id = patientModel.Id;
                patientJsonModel.Name = patientModel.Name;
                patientJsonModel.TreatmentIds = patientModel.Treatments;
                patientJsonModel.Description = patientModel.Description;
            };

            return patientJsonModel;
        }
    }
}
