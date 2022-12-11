using PatientManager.Core;
using PatientManager.Data.Services;
using PatientMenager.Data;

namespace PatientManager
{
    public partial class MainForm : Form
    {
        private MedicineDataService _medicineDataService;
        private FileNameType _activeUserControlName;
        public MainForm()
        {
            InitializeComponent();
            _medicineDataService = new MedicineDataService();
        }

        private void btnMedicines_Click(object sender, EventArgs e)
        {
            modelsListPage1.SetUpDataGridView(FileNameType.Medicine);
            EnableUserControl(modelsListPage1, FileNameType.Medicine);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            BaseModel model = null;

            switch (_activeUserControlName)
            {
                case FileNameType.Medicine:
                    model = _medicineDataService.GetById(modelsListPage1.CurrentMedicineId);
                    break;
                default:
                    break;
            }

            if (model != null)
            {
                string dialogTitle = "Usuwanie";
                string dialogQuestion = $"Czy na pewno chcesz usunac pozycje \"{model.Name}\"?";
                var result = MessageBox.Show(dialogQuestion, dialogTitle, MessageBoxButtons.OKCancel);

                if (result == DialogResult.OK)
                {
                    _medicineDataService.Delete(model.Id);
                    this.modelsListPage1.Reset(_activeUserControlName);
                }
                EnableUserControl(modelsListPage1);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            medicineEditPage1.isEditMode = false;
            EnableUserControl(medicineEditPage1);
            medicineEditPage1.SetUp(modelsListPage1.medicineModel);
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            medicineEditPage1.isEditMode = true;
            EnableUserControl(medicineEditPage1);
            medicineEditPage1.SetUp(modelsListPage1.medicineModel);
        }

        public void DisableAllUserControls()
        {
            modelsListPage1.Visible = false;
            medicineEditPage1.Visible = false;
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
    }
}