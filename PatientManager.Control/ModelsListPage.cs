using PatientManager.Core;
using PatientManager.Data;
using PatientManager.Data.Services;
using PatientMenager.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PatientManager.Control
{
    public partial class ModelsListPage : UserControl
    {
        private MedicineDataService _medicineData;
        private PatientDataService _patientData;
        private FileNameType _fileNameType;

        public MedicineModel medicineModel;
        public PatientModel patientModel;

        public int CurrentModelId = 0;
        public ModelsListPage()
        {
            InitializeComponent();
        }

        public void SetUpDataGridView(FileNameType fileNameType)
        {
            _fileNameType = fileNameType;

            var bindingSource1 = new BindingSource();

            switch (_fileNameType)
            {
                case FileNameType.Medicine:
                    _medicineData = new MedicineDataService();
                    SetUpDataGridViewWithMedicines(bindingSource1);
                    break;
                case FileNameType.Patient:
                    _patientData = new PatientDataService();
                    SetUpDataGridViewWithPatients(bindingSource1);
                    break;
                default:
                    return;
            }

            if (bindingSource1.DataSource != null)
            {
                dgvModels.Columns["Id"].DisplayIndex = 0;
                dgvModels.Columns["Name"].DisplayIndex = 1;
                dgvModels.Columns["Description"].DisplayIndex = 3;

                dgvModels.Columns["Id"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                dgvModels.Columns["Name"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                dgvModels.Columns["Name"].HeaderText = "Nazwa";
                dgvModels.Columns["Description"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dgvModels.Columns["Description"].HeaderText = "Uwagi";
            }
        }

        private void SetUpDataGridViewWithMedicines(BindingSource bindingSource1)
        {
            if (_medicineData?.GetAll() != null)
            {
                bindingSource1.DataSource = _medicineData.GetAll();
                dgvModels.DataSource = bindingSource1.DataSource;

                dgvModels.Columns["NumberOfPatients"].DisplayIndex = 2;

                dgvModels.Columns["NumberOfPatients"].HeaderText = "Pacjenci";
                dgvModels.Columns["NumberOfPatients"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                dgvModels.Columns["NumberOfPatients"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            }

        }
        private void SetUpDataGridViewWithPatients(BindingSource bindingSource1)
        {
            if (_medicineData?.GetAll() != null)
            {
                bindingSource1.DataSource = _patientData.GetAll();
                dgvModels.DataSource = bindingSource1.DataSource;

                dgvModels.Columns["NumberOfTreatments"].DisplayIndex = 2;

                dgvModels.Columns["NumberOfTreatments"].HeaderText = "Kuracje";
                dgvModels.Columns["NumberOfTreatments"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                dgvModels.Columns["NumberOfTreatments"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            }
        }
        private void dgvModels_SelectionChanged(object sender, EventArgs e)
        {

            if (dgvModels.SelectedRows.Count > 0)
                CurrentModelId = Convert.ToInt32(dgvModels.SelectedRows[0].Cells["Id"].Value.ToString());

            if (CurrentModelId > 0)
            {
                BindingSource bindingSource = new BindingSource();

                switch (_fileNameType)
                {
                    case FileNameType.Medicine:
                        medicineModel = _medicineData.GetById(CurrentModelId);
                        txtName.Text = medicineModel?.Name;

                        bindingSource.DataSource = medicineModel?.Patients;
                        break;
                    case FileNameType.Patient:
                        patientModel = _patientData.GetById(CurrentModelId);
                        txtName.Text = patientModel?.Name;

                        bindingSource.DataSource = patientModel?.Treatments;
                        break;
                    default:
                        break;
                }

                cbModels.DataSource = bindingSource;
            }
        }

        public void Reset(FileNameType fileName)
        {
            SetUpDataGridView(fileName);
        }
    }
}
