using PatientManager.Core;
using PatientManager.Data.Services;
using PatientManager.Data;

namespace PatientManager.Control
{
    public partial class MedicineEditPage : UserControl
    {
        private MedicineDataService _medicineData;
        public bool isEditMode { get; set; }
        public MedicineEditPage()
        {
            InitializeComponent();
            _medicineData = new MedicineDataService();
        }

        public void SetUp(MedicineModel medicineModel)
        {
            DisplayEditMode();
            PopulateTextBoxesWithMedicineData(medicineModel);
        }

        private void DisplayEditMode()
        {
            dgvTreatment.Visible = isEditMode;
            lblTreatment.Visible = isEditMode;

            txtPatients.Visible = isEditMode;
            lblPatients.Visible = isEditMode;
        }

        private void PopulateTextBoxesWithMedicineData(MedicineModel medicineModel)
        {
            if (isEditMode)
            {
                txtId.Text = medicineModel.Id.ToString();
                txtName.Text = medicineModel.Name;
                txtDescription.Text = medicineModel.Description;
            }
            else
                txtId.Text = medicineModel.Id.ToString();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (isEditMode)
            {
                MedicineModel medicineModel = _medicineData.GetById(Convert.ToInt32(txtId.Text));
                medicineModel.Name = txtName.Text;
                medicineModel.Description = txtDescription.Text;

                _medicineData.Update(medicineModel);
            }
            else
            {
                MedicineModel medicineModel = new MedicineModel();
                medicineModel.Id = Convert.ToInt32(txtId.Text);
                medicineModel.Name = txtName.Text;
                medicineModel.Description = txtDescription.Text;

                _medicineData.Add(medicineModel);
            }

            ResetListPage();

            UserControlVisibility("medicineEditPage1", false);
            UserControlVisibility("modelsListPage1", true);
        }

        private void UserControlVisibility(string UserControlName, bool isVisible)
        {
            var form = Application.OpenForms["MainForm"];
            var userControl = form.Controls.Find(UserControlName, true).FirstOrDefault();

            if (userControl != null)
                userControl.Visible = isVisible;

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            UserControlVisibility("medicineEditPage1", false);
            UserControlVisibility("modelsListPage1", true);
        }

        public void ResetListPage()
        {
            var form = Application.OpenForms["MainForm"];
            var userControl = (ModelsListPage)form.Controls.Find("modelsListPage1", true).FirstOrDefault();
            
            if (userControl != null)
                userControl.Reset(FileNameType.Medicine);
        }
    }
}
