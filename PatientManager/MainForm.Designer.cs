namespace PatientManager
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.modelsListPage1 = new PatientManager.Control.ModelsListPage();
            this.btnCalendar = new System.Windows.Forms.Button();
            this.btnMedicines = new System.Windows.Forms.Button();
            this.btnPatients = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnTreatment = new System.Windows.Forms.Button();
            this.medicineEditPage1 = new PatientManager.Control.MedicineEditPage();
            this.SuspendLayout();
            // 
            // modelsListPage1
            // 
            this.modelsListPage1.BackColor = System.Drawing.SystemColors.Control;
            this.modelsListPage1.Location = new System.Drawing.Point(12, 12);
            this.modelsListPage1.Name = "modelsListPage1";
            this.modelsListPage1.Size = new System.Drawing.Size(600, 445);
            this.modelsListPage1.TabIndex = 0;
            this.modelsListPage1.Visible = false;
            // 
            // btnCalendar
            // 
            this.btnCalendar.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCalendar.Location = new System.Drawing.Point(656, 406);
            this.btnCalendar.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnCalendar.Name = "btnCalendar";
            this.btnCalendar.Size = new System.Drawing.Size(114, 43);
            this.btnCalendar.TabIndex = 9;
            this.btnCalendar.Text = "Ogólne";
            this.btnCalendar.UseVisualStyleBackColor = true;
            // 
            // btnMedicines
            // 
            this.btnMedicines.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnMedicines.Location = new System.Drawing.Point(656, 355);
            this.btnMedicines.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnMedicines.Name = "btnMedicines";
            this.btnMedicines.Size = new System.Drawing.Size(114, 43);
            this.btnMedicines.TabIndex = 9;
            this.btnMedicines.Text = "Leki";
            this.btnMedicines.UseVisualStyleBackColor = true;
            this.btnMedicines.Click += new System.EventHandler(this.btnMedicines_Click);
            // 
            // btnPatients
            // 
            this.btnPatients.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnPatients.Location = new System.Drawing.Point(656, 304);
            this.btnPatients.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnPatients.Name = "btnPatients";
            this.btnPatients.Size = new System.Drawing.Size(114, 43);
            this.btnPatients.TabIndex = 9;
            this.btnPatients.Text = "Pacjenci";
            this.btnPatients.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAdd.Location = new System.Drawing.Point(656, 12);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(114, 43);
            this.btnAdd.TabIndex = 9;
            this.btnAdd.Text = "Dodaj";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnEdit.Location = new System.Drawing.Point(656, 63);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(114, 43);
            this.btnEdit.TabIndex = 9;
            this.btnEdit.Text = "Edytuj";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnDelete.Location = new System.Drawing.Point(656, 114);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(114, 43);
            this.btnDelete.TabIndex = 9;
            this.btnDelete.Text = "Usuń";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnTreatment
            // 
            this.btnTreatment.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnTreatment.Location = new System.Drawing.Point(656, 253);
            this.btnTreatment.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnTreatment.Name = "btnTreatment";
            this.btnTreatment.Size = new System.Drawing.Size(114, 43);
            this.btnTreatment.TabIndex = 9;
            this.btnTreatment.Text = "Kuracje";
            this.btnTreatment.UseVisualStyleBackColor = true;
            // 
            // medicineEditPage1
            // 
            this.medicineEditPage1.Location = new System.Drawing.Point(12, 12);
            this.medicineEditPage1.Name = "medicineEditPage1";
            this.medicineEditPage1.Size = new System.Drawing.Size(600, 445);
            this.medicineEditPage1.TabIndex = 10;
            this.medicineEditPage1.Visible = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(782, 453);
            this.Controls.Add(this.medicineEditPage1);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnTreatment);
            this.Controls.Add(this.btnPatients);
            this.Controls.Add(this.btnMedicines);
            this.Controls.Add(this.btnCalendar);
            this.Controls.Add(this.modelsListPage1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private Control.ModelsListPage modelsListPage1;
        private Button btnCalendar;
        private Button btnMedicines;
        private Button btnPatients;
        private Button btnAdd;
        private Button btnEdit;
        private Button btnDelete;
        private Button btnTreatment;
        private Control.MedicineEditPage medicineEditPage1;
    }
}