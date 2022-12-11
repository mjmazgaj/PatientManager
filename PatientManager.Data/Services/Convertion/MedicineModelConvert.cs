using PatientManager.Core;
using System.Text.Json.Nodes;

namespace PatientManager.Data
{
    public static class MedicineModelConvert
    {
        //TODO
        //MedicineJsonModel has only Patient's Ids, MedicineModel should have list of PatientModels.
        public static MedicineModel ToMedicineModel(MedicineJsonModel jsonModel)
        {
            var medicineModel = new MedicineModel();

            if (medicineModel != null && jsonModel != null)
            {
                medicineModel.Id = jsonModel.Id;
                medicineModel.Name = jsonModel.Name;
                medicineModel.Patients = jsonModel.PatientIds;
                medicineModel.Description = jsonModel.Description;
            };

            return medicineModel;
        }

        public static MedicineJsonModel ToMedicineJsonModel(MedicineModel medicineModel)
        {
            var medicineJsonModel = new MedicineJsonModel();

            if (medicineJsonModel != null && medicineModel != null)
            {
                medicineJsonModel.Id = medicineModel.Id;
                medicineJsonModel.Name = medicineModel.Name;
                medicineJsonModel.PatientIds = medicineModel.Patients;
                medicineJsonModel.Description = medicineModel.Description;
            };

            return medicineJsonModel;
        }
    }
}
