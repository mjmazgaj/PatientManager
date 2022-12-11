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
        public MedicineModel medicineModel;

        public int CurrentMedicineId = 0;
        public ModelsListPage()
        {
            InitializeComponent();
            _medicineData = new MedicineDataService();
        }

        public void SetUpDataGridView(FileNameType fileNameType)
        {
            var medicines = _medicineData.GetAll();

            var bindingSource1 = new BindingSource();

            if (medicines.Count() != 0)
            {
                bindingSource1.DataSource = medicines;
            }
            else
            {
                bindingSource1.DataSource = new List<MedicineModel>() { new() { Name = "Brak" } };
            } 

            dgvModels.DataSource = bindingSource1.DataSource;
            dgvModels.Columns["Id"].DisplayIndex = 0;
            dgvModels.Columns["Name"].DisplayIndex = 1;
            dgvModels.Columns["NumberOfPatients"].DisplayIndex = 2;
            dgvModels.Columns["Description"].DisplayIndex = 3;

            dgvModels.Columns["Id"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvModels.Columns["Name"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvModels.Columns["Name"].HeaderText = "Nazwa leku";
            dgvModels.Columns["NumberOfPatients"].HeaderText = "Pacjenci";
            dgvModels.Columns["NumberOfPatients"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvModels.Columns["NumberOfPatients"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvModels.Columns["Description"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvModels.Columns["Description"].HeaderText = "Uwagi";
        }

        private void dgvModels_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvModels.SelectedRows.Count > 0)
                CurrentMedicineId = Convert.ToInt32(dgvModels.SelectedRows[0].Cells["Id"].Value.ToString());

            if (CurrentMedicineId > 0)
            {
                medicineModel = _medicineData.GetById(CurrentMedicineId);
                txtName.Text = medicineModel.Name;

                BindingSource bindingSource = new BindingSource();
                bindingSource.DataSource = medicineModel.Patients;

                cbPatients.DataSource = bindingSource;
            }
        }

        public void Reset(FileNameType fileName)
        {
            SetUpDataGridView(fileName);
        }        
    }
}
