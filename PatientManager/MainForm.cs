using PatientManager.Core;
using PatientManager.Data.Services;
using PatientManager.Data;

namespace PatientManager
{
    public partial class MainForm : Form
    {
        private MedicineDataService _medicineDataService;
        private PatientDataService _patientDataService;
        private TreatmentDataService _treatmentDataService;

        private FileNameType _activeUserControlName;
        public MainForm()
        {
            InitializeComponent();
            _medicineDataService = new MedicineDataService();
            _patientDataService = new PatientDataService();
            _treatmentDataService = new TreatmentDataService();
        }

        private void btnMedicines_Click(object sender, EventArgs e)
        {
            modelsListPage1.SetUpDataGridView(FileNameType.Medicine);
            EnableUserControl(modelsListPage1, FileNameType.Medicine);
        }
        private void btnPatients_Click(object sender, EventArgs e)
        {
            modelsListPage1.SetUpDataGridView(FileNameType.Patient);
            EnableUserControl(modelsListPage1, FileNameType.Patient);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            BaseModel model = null;

            switch (_activeUserControlName)
            {
                case FileNameType.Medicine:
                    DeleteMedicine();
                    break;
                case FileNameType.Patient:
                    DeletePatient();
                    break;
                default:
                    break;
            }

            this.modelsListPage1.Reset(_activeUserControlName);
            EnableUserControl(modelsListPage1);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            switch (_activeUserControlName)
            {
                case FileNameType.Medicine:
                    EditMedicine(modelsListPage1.CurrentModelId, false);
                    break;
                case FileNameType.Patient:
                    EditPatient(modelsListPage1.CurrentModelId, false);
                    break;
                default:
                    break;
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (modelsListPage1.CurrentModelId >= 1)
            {
                switch (_activeUserControlName)
                {
                    case FileNameType.Medicine:
                        EditMedicine(modelsListPage1.CurrentModelId, true);
                        break;
                    case FileNameType.Patient:
                        EditPatient(modelsListPage1.CurrentModelId, true);
                        break;
                    default:
                        break;
                }
            }
        }

        public void DisableAllUserControls()
        {
            modelsListPage1.Visible = false;
            medicineEditPage1.Visible = false;
            patientEditPage1.Visible = false;
        }

        public void EnableUserControl(UserControl userControl)
        {
            DisableAllUserControls();
            userControl.Visible = true;
        }

        public void EnableUserControl(UserControl userControl, FileNameType fileNameType)
        {
            _activeUserControlName = fileNameType;
            DisableAllUserControls();
            userControl.Visible = true;
        }

        private void EditMedicine(int id, bool isEditMode)
        {
            MedicineModel medicineModel;
            medicineEditPage1.isEditMode = isEditMode;

            medicineModel = _medicineDataService?.GetById(id);

            if (medicineModel != null && isEditMode)
            {
                EnableUserControl(medicineEditPage1);
                medicineEditPage1.SetUp(medicineModel);
            }
            else
            {
                medicineModel = new MedicineModel() { Id = _medicineDataService.GetNextId() };
                EnableUserControl(medicineEditPage1);
                medicineEditPage1.SetUp(medicineModel);
            }
        }

        private void EditPatient(int id, bool isEditMode)
        {
            PatientModel patientModel;
            patientEditPage1.isEditMode = isEditMode;

            patientModel = _patientDataService?.GetById(id);

            if (patientModel != null && isEditMode)
            {
                EnableUserControl(patientEditPage1);
                patientEditPage1.SetUp(patientModel);
            }
            else
            {
                EnableUserControl(patientEditPage1);
                patientModel = new PatientModel() { Id = _patientDataService.GetNextId() };
                patientEditPage1.SetUp(patientModel);
            }
        }
        private bool DoesUserWantToRemoveObject(string name)
        {
            string dialogTitle = "Usuwanie";
            string dialogQuestion = $"Czy na pewno chcesz usunac pozycje \"{name}\"?";
            var result = MessageBox.Show(dialogQuestion, dialogTitle, MessageBoxButtons.OKCancel);

            if (result == DialogResult.OK)
                return true;

            return false;
        }

        private bool IsModelAvailableToDelete(FileNameType fileNameType, BaseModel model)
        {
            bool isUsedInTreatment = false;
            string name = string.Empty;

            switch (fileNameType)
            {
                case FileNameType.Medicine:
                    isUsedInTreatment = _treatmentDataService.GetAll().Any(x => x.Medicine?.Id == model?.Id);
                    name = "leku";
                    break;
                case FileNameType.Patient:
                    isUsedInTreatment = _treatmentDataService.GetAll().Any(x => x.Patient?.Id == model?.Id);
                    name = "pacjenta";
                    break;
                default:
                    break;
            }

            if (isUsedInTreatment)
            {
                string dialogTitle = "Usuwanie";
                string dialogQuestion = $"Nie mozna usunac {name}, gdyz jest obecnie przypisany do przynajmniej jednej kuracji.";
                MessageBox.Show(dialogQuestion, dialogTitle);
            }

            return !isUsedInTreatment;
        }

        private void DeleteMedicine()
        {
            MedicineModel model = _medicineDataService.GetById(modelsListPage1.CurrentModelId);

            if (IsModelAvailableToDelete(FileNameType.Medicine, model) && DoesUserWantToRemoveObject(model.Name))
            {
                _medicineDataService.Delete(model.Id);
            }
        }
        private void DeletePatient()
        {
            PatientModel model = _patientDataService.GetById(modelsListPage1.CurrentModelId);

            if (IsModelAvailableToDelete(FileNameType.Patient, model) && DoesUserWantToRemoveObject(model.Name))
            {
                _patientDataService.Delete(model.Id);
            }
        }
    }

}