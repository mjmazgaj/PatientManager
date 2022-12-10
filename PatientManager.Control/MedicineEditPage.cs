using PatientManager.Core;
using PatientManager.Data.Services;
using PatientManager;
using PatientManager.Data;
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
                txtPatients.Text = medicineModel.NumberOfPatients.ToString();
                txtDescription.Text = medicineModel.Description;
            }
            else
                txtId.Text = (_medicineData.Count() + 1).ToString();
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
            UserControlVisibility("medicineListPage1", true);
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
            UserControlVisibility("medicineListPage1", true);
        }

        public void ResetListPage()
        {
            var form = Application.OpenForms["MainForm"];
            var userControl = (MedicineListPage)form.Controls.Find("medicineListPage1", true).FirstOrDefault();
            
            if (userControl != null)
                userControl.Reset();
        }
    }
}
