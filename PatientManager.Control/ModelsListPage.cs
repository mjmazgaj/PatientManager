using PatientManager.Core;
using PatientManager.Data;
using PatientManager.Data.Services;

namespace PatientManager.Control
{
    public partial class ModelsListPage : UserControl
    {
        private MedicineDataService _medicineData;
        private PatientDataService _patientData;
        private TreatmentDataService _treatmentData;

        private FileNameType _fileNameType;

        private MedicineModel medicineModel;
        private PatientModel patientModel;

        public int CurrentModelId = 0;
        public ModelsListPage()
        {
            InitializeComponent();
            _patientData = new PatientDataService();
            _medicineData = new MedicineDataService();
            _treatmentData = new TreatmentDataService();
        }

        public void SetUpDataGridView(FileNameType fileNameType)
        {
            _fileNameType = fileNameType;

            var bindingSource1 = new BindingSource();

            switch (_fileNameType)
            {
                case FileNameType.Medicine:
                    SetUpDataGridViewWithMedicines(bindingSource1);
                    break;
                case FileNameType.Patient:
                    SetUpDataGridViewWithPatients(bindingSource1);
                    break;
                case FileNameType.Treatment:
                    SetUpDataGridViewWithTreatments(bindingSource1);
                    break;
                default:
                    return;
            }

            if (bindingSource1.DataSource != null)
            {
                dgvModels.Columns["Description"].DisplayIndex = dgvModels.ColumnCount - 1;

                

                dgvModels.Columns["Description"].HeaderText = "Uwagi";
            }

            foreach (DataGridViewTextBoxColumn column in dgvModels.Columns)
            {
                column.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            }

            dgvModels.Columns["Id"].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            dgvModels.Columns["Id"].Width = 40;
            dgvModels.Columns["Description"].MinimumWidth = dgvModels.Columns["Description"].Width - 10;
            dgvModels.Columns["Description"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        private void SetUpDataGridViewWithMedicines(BindingSource bindingSource1)
        {
            if (_medicineData?.GetAll() != null)
            {
                bindingSource1.DataSource = _medicineData.GetAll();
                dgvModels.DataSource = bindingSource1.DataSource;

                dgvModels.Columns["Name"].Visible = true;
                dgvModels.Columns["FullName"].Visible = false;

                dgvModels.Columns["Id"].DisplayIndex = 0;
                dgvModels.Columns["Name"].DisplayIndex = 1;

                dgvModels.Columns["Name"].HeaderText = "Nazwa";

                dgvModels.Columns["Count"].HeaderText = "Ilość";
                dgvModels.Columns["Unit"].HeaderText = "J";
            }

        }
        private void SetUpDataGridViewWithPatients(BindingSource bindingSource1)
        {
            if (_patientData?.GetAll() != null)
            {
                bindingSource1.DataSource = _patientData.GetAll();
                dgvModels.DataSource = bindingSource1.DataSource;
                
                dgvModels.Columns["Name"].Visible = true;
                

                dgvModels.Columns["Id"].DisplayIndex = 0;
                dgvModels.Columns["Name"].DisplayIndex = 1;

                dgvModels.Columns["Name"].HeaderText = "Nazwa";
            }
        }

        private void SetUpDataGridViewWithTreatments(BindingSource bindingSource1)
        {
            if (_treatmentData?.GetAll() != null)
            {
                bindingSource1.DataSource = _treatmentData.GetAll();
                dgvModels.DataSource = bindingSource1.DataSource;

                dgvModels.Columns["Id"].DisplayIndex = 0;

                dgvModels.Columns["Name"].Visible = false;
                dgvModels.Columns["Patient"].Visible = false;
                dgvModels.Columns["Medicine"].Visible = false;

                dgvModels.Columns["PatientName"].HeaderText = "Pacjent";
                dgvModels.Columns["MedicineName"].HeaderText = "Lek";
                dgvModels.Columns["DayInterval"].HeaderText = "Dni";
                dgvModels.Columns["Count"].HeaderText = "Ilość";
                dgvModels.Columns["Date"].HeaderText = "Start";
                dgvModels.Columns["Date"].DefaultCellStyle.Format = "dd/MM/yy";
            }
        }
        private void SetUpTreatmentSummary()
        {
            var form = Application.OpenForms["MainForm"];
            var userControl = (TreatmentsSummary)form.Controls.Find("treatmentsSummary1", true).FirstOrDefault();
            userControl?.SetupSummary();
        }
        private void dgvModels_SelectionChanged(object sender, EventArgs e)
        {

            if (dgvModels.SelectedRows.Count > 0)
                CurrentModelId = Convert.ToInt32(dgvModels.SelectedRows[0].Cells["Id"].Value.ToString());

            if (CurrentModelId > 0)
            {
                switch (_fileNameType)
                {
                    case FileNameType.Medicine:
                        medicineModel = _medicineData.GetById(CurrentModelId);
                        txtName.Text = medicineModel?.Name;
                        break;
                    case FileNameType.Patient:
                        patientModel = _patientData.GetById(CurrentModelId);
                        txtName.Text = patientModel?.Name;
                        break;
                    default:
                        break;
                }
            }
        }

        public void Reset(FileNameType fileName)
        {
            SetUpDataGridView(fileName);
            SetUpTreatmentSummary();
        }
    }
}
