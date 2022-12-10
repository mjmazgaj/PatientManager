using PatientManager.Core;
using PatientManager.Data.Services;

namespace PatientManager
{
    public partial class MainForm : Form
    {
        private MedicineDataService _medicineDataService;
        public MainForm()
        {
            InitializeComponent();
            _medicineDataService = new MedicineDataService();
        }

        private void btnMedicines_Click(object sender, EventArgs e)
        {
            EnableUserControl(medicineListPage1);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            MedicineModel medicineModel = _medicineDataService.GetById(medicineListPage1.CurrentMedicineId);
            
            string dialogTitle = "Usuwanie";
            string dialogQuestion = $"Czy na pewno chcesz usunac pozycje \"{medicineModel.Name}\"?";
            var result = MessageBox.Show(dialogQuestion, dialogTitle, MessageBoxButtons.OKCancel);

            if (result == DialogResult.OK)
            {
                _medicineDataService.Delete(medicineModel.Id);
                this.Controls.Clear();
                this.InitializeComponent();
            }
            EnableUserControl(medicineListPage1);
        }
        
        private void btnAdd_Click(object sender, EventArgs e)
        {
            medicineEditPage1.isEditMode = false;
            EnableUserControl(medicineEditPage1);
            medicineEditPage1.SetUp(medicineListPage1.medicineModel);
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            medicineEditPage1.isEditMode = true;
            EnableUserControl(medicineEditPage1);
            medicineEditPage1.SetUp(medicineListPage1.medicineModel);
        }

        public void DisableAllUserControls()
        {
            medicineListPage1.Visible = false;
            medicineEditPage1.Visible = false;
        }

        public void EnableUserControl(UserControl userControl)
        {
            DisableAllUserControls();
            userControl.Visible = true;
        }
    }
}