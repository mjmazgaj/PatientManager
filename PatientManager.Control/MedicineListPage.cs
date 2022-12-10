using PatientManager.Core;
using PatientManager.Data;
using PatientManager.Data.Services;
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
    public partial class MedicineListPage : UserControl
    {
        private MedicineDataService _medicineData;
        public MedicineModel medicineModel;

        public int CurrentMedicineId = 0;
        public MedicineListPage()
        {
            InitializeComponent();
            _medicineData = new MedicineDataService();
            SetUpDataGridView();
        }

        public void SetUpDataGridView()
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

            dgvMedicines.DataSource = bindingSource1.DataSource;
            dgvMedicines.Columns["Id"].DisplayIndex = 0;
            dgvMedicines.Columns["Name"].DisplayIndex = 1;
            dgvMedicines.Columns["NumberOfPatients"].DisplayIndex = 2;
            dgvMedicines.Columns["Description"].DisplayIndex = 3;

            dgvMedicines.Columns["Id"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvMedicines.Columns["Name"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvMedicines.Columns["Name"].HeaderText = "Nazwa leku";
            dgvMedicines.Columns["NumberOfPatients"].HeaderText = "Pacjenci";
            dgvMedicines.Columns["NumberOfPatients"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvMedicines.Columns["NumberOfPatients"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvMedicines.Columns["Description"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvMedicines.Columns["Description"].HeaderText = "Uwagi";
        }

        private void dgvMedicines_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvMedicines.SelectedRows.Count > 0)
                CurrentMedicineId = Convert.ToInt32(dgvMedicines.SelectedRows[0].Cells["Id"].Value.ToString());

            if (CurrentMedicineId > 0)
            {
                medicineModel = _medicineData.GetById(CurrentMedicineId);
                txtName.Text = medicineModel.Name;

                BindingSource bindingSource = new BindingSource();
                bindingSource.DataSource = medicineModel.Patients;

                cbPatients.DataSource = bindingSource;
            }
        }

        public void Reset()
        {
            SetUpDataGridView();
        }        
    }
}
