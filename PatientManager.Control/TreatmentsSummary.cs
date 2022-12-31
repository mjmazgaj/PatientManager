using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PatientManager.Core;
using PatientManager.Data.Services;

namespace PatientManager.Control
{
    public partial class TreatmentsSummary : UserControl
    {
        private MyCalendar _myCalendar;
        private int _selectedYear;
        private int _selectedMonth;
        private TreatmentDataService _treatmentData;
        public TreatmentsSummary()
        {
            InitializeComponent();

            _treatmentData = new TreatmentDataService();
            _myCalendar = new MyCalendar();
            _selectedMonth = DateTime.Now.Month;
            _selectedYear = DateTime.Now.Year;
            SetupSummary();
        }

        private void btnCalendarNext_Click(object sender, EventArgs e)
        {
            _selectedMonth++;

            if (_selectedMonth > 12)
            {
                _selectedYear++;
                _selectedMonth = 1;
            }

            SetupSummary();
        }

        private void btnCalendarPrev_Click(object sender, EventArgs e)
        {
            _selectedMonth--;

            if (_selectedMonth < 1)
            {
                _selectedYear--;
                _selectedMonth = 12;
            }

            SetupSummary();
        }

        private void btnToday_Click(object sender, EventArgs e)
        {
            _selectedMonth = DateTime.Now.Month;
            _selectedYear = DateTime.Now.Year;

            SetupSummary();
        }
        private void SetuplblDate()
        {
            lblDate.Text = $"{_selectedMonth:00}/{_selectedYear}";
        }
        private void SetupComboBoxSummary()
        {
            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = _treatmentData.GetRecord(_selectedMonth, _selectedYear);

            dgvSummaryTreatment.DataSource = bindingSource.DataSource;

            dgvSummaryTreatment.Columns["MedicineFullName"].HeaderText = "Lek";
            dgvSummaryTreatment.Columns["MedicineFullName"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvSummaryTreatment.Columns["Doses"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvSummaryTreatment.Columns["Doses"].HeaderText = "Ile";
            dgvSummaryTreatment.Columns["MedicineId"].Visible = false;
        }
        public void SetupSummary()
        {
            SetuplblDate();
            SetupComboBoxSummary();
        }
    }
}
