using PatientManager.Core;
using PatientManager.Data.Services;

namespace PatientManager.Data
{
    public static class TreatmentModelConvert
    {
        public static TreatmentModel ToTreatmentModel(TreatmentJsonModel jsonModel)
        {
            TreatmentModel treatmentModel = null;

            if (jsonModel != null)
            {
                treatmentModel = new TreatmentModel();

                treatmentModel.Id = jsonModel.Id;
                treatmentModel.Patient = new PatientDataService().GetById(jsonModel.PatientId);
                treatmentModel.Medicine = new MedicineDataService().GetById(jsonModel.MedicineId);
                treatmentModel.Date = DateOnly.FromDateTime(Convert.ToDateTime(jsonModel.Date));
                treatmentModel.DayInterval = jsonModel.DayInterval;
                treatmentModel.Description = jsonModel.Description;
            };

            return treatmentModel;
        }

        public static TreatmentJsonModel ToTreatmentJsonModel(TreatmentModel treatmentModel)
        {
            TreatmentJsonModel treatmentJsonModel = null;

            if (treatmentModel != null)
            {
                treatmentJsonModel = new TreatmentJsonModel();

                treatmentJsonModel.Id = treatmentModel.Id;
                treatmentJsonModel.PatientId = treatmentModel.Patient?.Id != null ? treatmentModel.Patient.Id : 0;
                treatmentJsonModel.MedicineId = treatmentModel.Medicine?.Id != null ? treatmentModel.Medicine.Id : 0;
                treatmentJsonModel.Date = treatmentModel.Date.ToString();
                treatmentJsonModel.DayInterval = treatmentModel.DayInterval;
                treatmentJsonModel.Description = treatmentModel.Description;
            };

            return treatmentJsonModel;
        }
    }
}
