using PatientManager.Core;
using PatientManager.Data.Services;
using PatientManager.Data;

namespace PatientManager.Control
{
    public partial class TreatmentEditPage : UserControl
    {
        private TreatmentDataService _treatmentData;
        public bool isEditMode { get; set; }
        public TreatmentEditPage()
        {
            InitializeComponent();
            _treatmentData = new TreatmentDataService();
        }

        public void SetUp(TreatmentModel TreatmentModel)
        {
            DisplayEditMode();
            PopulateTextBoxesWithTreatmentData(TreatmentModel);
            PopulateComboBoxes();
        }

        private void DisplayEditMode()
        {
        }

        private void PopulateTextBoxesWithTreatmentData(TreatmentModel TreatmentModel)
        {
            if (isEditMode)
            {
                txtId.Text = TreatmentModel.Id.ToString();
                txtDescription.Text = TreatmentModel.Description;
            }
            else
                txtId.Text = TreatmentModel.Id.ToString();
        }

        private void PopulateComboBoxes()
        {
            BindingSource bindingSourceMedicines = new BindingSource();
            BindingSource bindingSourcePatientes = new BindingSource();
            bindingSourceMedicines.DataSource = _treatmentData.GetAllMedicines();
            bindingSourcePatientes.DataSource = _treatmentData.GetAllPatientes();

            cbMedicine.DisplayMember = "Name";
            cbPatient.DisplayMember = "Name";

            cbMedicine.DataSource = bindingSourceMedicines;
            cbPatient.DataSource = bindingSourcePatientes;

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            PatientModel patient = (PatientModel)cbPatient.SelectedItem;
            MedicineModel medicine = (MedicineModel)cbMedicine.SelectedItem;

            if (isEditMode)
            {
                TreatmentModel TreatmentModel = _treatmentData.GetById(Convert.ToInt32(txtId.Text));

                TreatmentModel.Description = txtDescription.Text;
                TreatmentModel.Patient = patient;
                TreatmentModel.Medicine = medicine;
                TreatmentModel.Description = txtDescription.Text;
                TreatmentModel.Date = DateOnly.FromDateTime(mcCalendar.SelectionStart);
                TreatmentModel.DayInterval = Convert.ToInt32(nudInterval.Value);

                _treatmentData.Update(TreatmentModel);
            }
            else
            {
                TreatmentModel TreatmentModel = new TreatmentModel();
                TreatmentModel.Id = Convert.ToInt32(txtId.Text);
                TreatmentModel.Patient = patient;
                TreatmentModel.Medicine = medicine;
                TreatmentModel.Description = txtDescription.Text;
                TreatmentModel.Date = DateOnly.FromDateTime(mcCalendar.SelectionStart);
                TreatmentModel.DayInterval = Convert.ToInt32(nudInterval.Value);
                
                _treatmentData.Add(TreatmentModel);
            }

            new MedicineDataService().Update(medicine);
            new PatientDataService().Update(patient);

            ResetListPage();

            UserControlVisibility("treatmentEditPage1", false);
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
            UserControlVisibility("treatmentEditPage1", false);
            UserControlVisibility("modelsListPage1", true);
        }

        public void ResetListPage()
        {
            var form = Application.OpenForms["MainForm"];
            var userControl = (ModelsListPage)form.Controls.Find("modelsListPage1", true).FirstOrDefault();

            if (userControl != null)
                userControl.Reset(FileNameType.Treatment);
            
        }
    }
}