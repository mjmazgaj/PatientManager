namespace PatientManager
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnMedicines_Click(object sender, EventArgs e)
        {
            EnableUserControl(medicineListPage1);
        }

        public void DisableAllUserControls()
        {
            medicineListPage1.Visible = false;
        }

        public void EnableUserControl(UserControl userControl)
        {
            DisableAllUserControls();
            userControl.Visible = true;
        }
    }
}