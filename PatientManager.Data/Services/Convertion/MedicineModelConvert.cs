﻿using PatientManager.Core;

namespace PatientManager.Data
{
    public static class MedicineModelConvert
    {
        //TODO
        //MedicineJsonModel has only Patient's Ids, MedicineModel should have list of PatientModels.
        public static MedicineModel ToMedicineModel(MedicineJsonModel jsonModel)
        {
            MedicineModel medicineModel = null;

            if (jsonModel != null)
            {
                medicineModel = new MedicineModel();

                medicineModel.Id = jsonModel.Id;
                medicineModel.Name = jsonModel.Name;
                medicineModel.Description = jsonModel.Description;
                medicineModel.Unit = jsonModel.Unit;
                medicineModel.Count = jsonModel.Count;
            };

            return medicineModel;
        }

        public static MedicineJsonModel ToMedicineJsonModel(MedicineModel medicineModel)
        {
            MedicineJsonModel medicineJsonModel = null;

            if (medicineModel != null)
            {
                medicineJsonModel = new MedicineJsonModel();

                medicineJsonModel.Id = medicineModel.Id;
                medicineJsonModel.Name = medicineModel.Name;
                medicineJsonModel.Description = medicineModel.Description;
                medicineJsonModel.Unit = medicineModel.Unit;
                medicineJsonModel.Count = medicineModel.Count;
            };

            return medicineJsonModel;
        }
    }
}
