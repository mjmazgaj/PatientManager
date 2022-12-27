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
using PatientMenager.Data;

namespace PatientManager.Control
{
    public partial class PatientEditPage : UserControl
    {
        private PatientDataService _patientData;
        public bool isEditMode { get; set; }
        public PatientEditPage()
        {
            InitializeComponent();
            _patientData = new PatientDataService();
        }

        public void SetUp(PatientModel PatientModel)
        {
            DisplayEditMode();
            PopulateTextBoxesWithPatientData(PatientModel);
        }

        private void DisplayEditMode()
        {
            dgvTreatment.Visible = isEditMode;
            lblTreatment.Visible = isEditMode;

            txtPatients.Visible = isEditMode;
            lblPatients.Visible = isEditMode;
        }

        private void PopulateTextBoxesWithPatientData(PatientModel PatientModel)
        {
            if (isEditMode)
            {
                txtId.Text = PatientModel.Id.ToString();
                txtName.Text = PatientModel.Name;
                txtDescription.Text = PatientModel.Description;
            }
            else
                txtId.Text = PatientModel.Id.ToString();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (isEditMode)
            {
                PatientModel PatientModel = _patientData.GetById(Convert.ToInt32(txtId.Text));
                PatientModel.Name = txtName.Text;
                PatientModel.Description = txtDescription.Text;

                _patientData.Update(PatientModel);
            }
            else
            {
                PatientModel PatientModel = new PatientModel();
                PatientModel.Id = Convert.ToInt32(txtId.Text);
                PatientModel.Name = txtName.Text;
                PatientModel.Description = txtDescription.Text;

                _patientData.Add(PatientModel);
            }

            ResetListPage();

            UserControlVisibility("patientEditPage1", false);
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
            UserControlVisibility("patientEditPage1", false);
            UserControlVisibility("modelsListPage1", true);
        }

        public void ResetListPage()
        {
            var form = Application.OpenForms["MainForm"];
            var userControl = (ModelsListPage)form.Controls.Find("modelsListPage1", true).FirstOrDefault();

            if (userControl != null)
                userControl.Reset(FileNameType.Patient);
        }
    }
}
