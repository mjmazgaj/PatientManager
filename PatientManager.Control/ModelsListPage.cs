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

        public MedicineModel medicineModel;
        public PatientModel patientModel;
        public TreatmentModel treatmentModel;

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
                dgvModels.Columns["Id"].DisplayIndex = 0;
                dgvModels.Columns["Description"].DisplayIndex = dgvModels.ColumnCount - 1;

                

                dgvModels.Columns["Description"].HeaderText = "Uwagi";
            }

            foreach (var item in dgvModels.Columns)
            {
                ((DataGridViewTextBoxColumn)item).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            }

            dgvModels.Columns["Description"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        private void SetUpDataGridViewWithMedicines(BindingSource bindingSource1)
        {
            if (_medicineData?.GetAll() != null)
            {
                bindingSource1.DataSource = _medicineData.GetAll();
                dgvModels.DataSource = bindingSource1.DataSource;

                dgvModels.Columns["Name"].Visible = true;
                dgvModels.Columns["Name"].DisplayIndex = 1;
                dgvModels.Columns["Name"].HeaderText = "Nazwa";
            }

        }
        private void SetUpDataGridViewWithPatients(BindingSource bindingSource1)
        {
            if (_patientData?.GetAll() != null)
            {
                bindingSource1.DataSource = _patientData.GetAll();
                dgvModels.DataSource = bindingSource1.DataSource;
                
                dgvModels.Columns["Name"].Visible = true;
                
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

                dgvModels.Columns["Name"].Visible = false;
                dgvModels.Columns["Patient"].Visible = false;
                dgvModels.Columns["Medicine"].Visible = false;

                dgvModels.Columns["DayInterval"].HeaderText = "Interwał";
                dgvModels.Columns["Date"].HeaderText = "Kuracje";
                dgvModels.Columns["Date"].DefaultCellStyle.Format = "dd/MM/yyyy";
            }
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
        }
    }
}
