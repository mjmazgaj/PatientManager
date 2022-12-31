using PatientManager.Core;
using PatientManager.Data.Services;
using PatientManager.Data;
using PatientManager.Core.Enum;

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
            PopulateComboBoxes();
            PopulateTextBoxesWithMedicineData(medicineModel);
        }

        private void DisplayEditMode()
        {
            dgvTreatment.Visible = isEditMode;
            lblTreatment.Visible = isEditMode;

            lblCount.Visible = isEditMode;
        }

        private void PopulateTextBoxesWithMedicineData(MedicineModel medicineModel)
        {
            if (isEditMode)
            {
                txtId.Text = medicineModel.Id.ToString();
                txtName.Text = medicineModel.Name;
                txtDescription.Text = medicineModel.Description;
                nudCount.Value = medicineModel.Count;
                cbUnits.SelectedItem = medicineModel.Unit;
            }
            else
                txtId.Text = medicineModel.Id.ToString();
        }

        private void btnSave_Click(object sender, EventArgs e)
        private void PopulateComboBoxes()
        {
            cbUnits.DataSource = Enum.GetValues(typeof(MedicineUnits));
        }
        {
            if (isEditMode)
            {
                MedicineModel medicineModel = _medicineData.GetById(Convert.ToInt32(txtId.Text));
                medicineModel.Name = txtName.Text;
                medicineModel.Description = txtDescription.Text;
                medicineModel.Unit = (MedicineUnits)cbUnits.SelectedItem;
                medicineModel.Count = nudCount.Value;

                _medicineData.Update(medicineModel);
            }
            else
            {
                MedicineModel medicineModel = new MedicineModel();
                medicineModel.Id = Convert.ToInt32(txtId.Text);
                medicineModel.Name = txtName.Text;
                medicineModel.Description = txtDescription.Text;
                medicineModel.Unit = (MedicineUnits)cbUnits.SelectedItem;
                medicineModel.Count = nudCount.Value;

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
