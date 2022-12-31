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
            this.btnSummary = new System.Windows.Forms.Button();
            this.btnMedicines = new System.Windows.Forms.Button();
            this.btnPatients = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnTreatment = new System.Windows.Forms.Button();
            this.medicineEditPage1 = new PatientManager.Control.MedicineEditPage();
            this.patientEditPage1 = new PatientManager.Control.PatientEditPage();
            this.treatmentEditPage1 = new PatientManager.Control.TreatmentEditPage();
            this.treatmentsSummary1 = new PatientManager.Control.TreatmentsSummary();
            this.SuspendLayout();
            // 
            // modelsListPage1
            // 
            this.modelsListPage1.BackColor = System.Drawing.SystemColors.Control;
            this.modelsListPage1.Location = new System.Drawing.Point(12, 12);
            this.modelsListPage1.Name = "modelsListPage1";
            this.modelsListPage1.Size = new System.Drawing.Size(825, 530);
            this.modelsListPage1.TabIndex = 0;
            this.modelsListPage1.Visible = false;
            // 
            // btnSummary
            // 
            this.btnSummary.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSummary.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSummary.Location = new System.Drawing.Point(854, 498);
            this.btnSummary.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnSummary.Name = "btnSummary";
            this.btnSummary.Size = new System.Drawing.Size(114, 43);
            this.btnSummary.TabIndex = 9;
            this.btnSummary.TabStop = false;
            this.btnSummary.Text = "Bilans";
            this.btnSummary.UseVisualStyleBackColor = true;
            this.btnSummary.Click += new System.EventHandler(this.btnSummary_Click);
            // 
            // btnMedicines
            // 
            this.btnMedicines.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMedicines.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnMedicines.Location = new System.Drawing.Point(854, 447);
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
            this.btnPatients.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPatients.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnPatients.Location = new System.Drawing.Point(854, 396);
            this.btnPatients.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnPatients.Name = "btnPatients";
            this.btnPatients.Size = new System.Drawing.Size(114, 43);
            this.btnPatients.TabIndex = 9;
            this.btnPatients.Text = "Pacjenci";
            this.btnPatients.UseVisualStyleBackColor = true;
            this.btnPatients.Click += new System.EventHandler(this.btnPatients_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAdd.Location = new System.Drawing.Point(854, 12);
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
            this.btnEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEdit.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnEdit.Location = new System.Drawing.Point(854, 63);
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
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnDelete.Location = new System.Drawing.Point(854, 114);
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
            this.btnTreatment.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTreatment.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnTreatment.Location = new System.Drawing.Point(854, 345);
            this.btnTreatment.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnTreatment.Name = "btnTreatment";
            this.btnTreatment.Size = new System.Drawing.Size(114, 43);
            this.btnTreatment.TabIndex = 9;
            this.btnTreatment.Text = "Kuracje";
            this.btnTreatment.UseVisualStyleBackColor = true;
            this.btnTreatment.Click += new System.EventHandler(this.btnTreatment_Click);
            // 
            // medicineEditPage1
            // 
            this.medicineEditPage1.isEditMode = false;
            this.medicineEditPage1.Location = new System.Drawing.Point(12, 12);
            this.medicineEditPage1.Name = "medicineEditPage1";
            this.medicineEditPage1.Size = new System.Drawing.Size(825, 530);
            this.medicineEditPage1.TabIndex = 10;
            this.medicineEditPage1.Visible = false;
            // 
            // patientEditPage1
            // 
            this.patientEditPage1.isEditMode = false;
            this.patientEditPage1.Location = new System.Drawing.Point(12, 12);
            this.patientEditPage1.Name = "patientEditPage1";
            this.patientEditPage1.Size = new System.Drawing.Size(825, 530);
            this.patientEditPage1.TabIndex = 11;
            this.patientEditPage1.Visible = false;
            // 
            // treatmentEditPage1
            // 
            this.treatmentEditPage1.isEditMode = false;
            this.treatmentEditPage1.Location = new System.Drawing.Point(12, 12);
            this.treatmentEditPage1.Name = "treatmentEditPage1";
            this.treatmentEditPage1.Size = new System.Drawing.Size(825, 530);
            this.treatmentEditPage1.TabIndex = 12;
            this.treatmentEditPage1.Visible = false;
            // 
            // treatmentsSummary1
            // 
            this.treatmentsSummary1.Location = new System.Drawing.Point(12, 12);
            this.treatmentsSummary1.Name = "treatmentsSummary1";
            this.treatmentsSummary1.Size = new System.Drawing.Size(825, 530);
            this.treatmentsSummary1.TabIndex = 13;
            this.treatmentsSummary1.Visible = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(982, 553);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnTreatment);
            this.Controls.Add(this.btnPatients);
            this.Controls.Add(this.btnMedicines);
            this.Controls.Add(this.btnSummary);
            this.Controls.Add(this.treatmentsSummary1);
            this.Controls.Add(this.treatmentEditPage1);
            this.Controls.Add(this.patientEditPage1);
            this.Controls.Add(this.medicineEditPage1);
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
        private Button btnSummary;
        private Button btnMedicines;
        private Button btnPatients;
        private Button btnAdd;
        private Button btnEdit;
        private Button btnDelete;
        private Button btnTreatment;
        private Control.MedicineEditPage medicineEditPage1;
        private Control.PatientEditPage patientEditPage1;
        private Control.TreatmentEditPage treatmentEditPage1;
        private Control.TreatmentsSummary treatmentsSummary1;
    }
}