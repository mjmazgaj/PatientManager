namespace PatientManager.Control
{
    partial class TreatmentEditPage
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblId = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.lblDetails = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.lblMedicine = new System.Windows.Forms.Label();
            this.cbMedicine = new System.Windows.Forms.ComboBox();
            this.lblPatient = new System.Windows.Forms.Label();
            this.cbPatient = new System.Windows.Forms.ComboBox();
            this.mcCalendar = new System.Windows.Forms.MonthCalendar();
            this.lblInterval = new System.Windows.Forms.Label();
            this.nudInterval = new System.Windows.Forms.NumericUpDown();
            this.nudCount = new System.Windows.Forms.NumericUpDown();
            this.lblCount = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudInterval)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCount)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSave.Location = new System.Drawing.Point(9, 483);
            this.btnSave.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(114, 43);
            this.btnSave.TabIndex = 10;
            this.btnSave.Text = "Zapisz";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCancel.Location = new System.Drawing.Point(133, 483);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(114, 43);
            this.btnCancel.TabIndex = 10;
            this.btnCancel.Text = "Anuluj";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblId.Location = new System.Drawing.Point(0, 29);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(22, 18);
            this.lblId.TabIndex = 11;
            this.lblId.Text = "Id";
            // 
            // txtId
            // 
            this.txtId.Enabled = false;
            this.txtId.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtId.Location = new System.Drawing.Point(0, 0);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(60, 26);
            this.txtId.TabIndex = 12;
            // 
            // lblDetails
            // 
            this.lblDetails.AutoSize = true;
            this.lblDetails.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDetails.Location = new System.Drawing.Point(0, 441);
            this.lblDetails.Name = "lblDetails";
            this.lblDetails.Size = new System.Drawing.Size(40, 18);
            this.lblDetails.TabIndex = 11;
            this.lblDetails.Text = "Opis";
            // 
            // txtDescription
            // 
            this.txtDescription.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtDescription.Location = new System.Drawing.Point(0, 326);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(831, 112);
            this.txtDescription.TabIndex = 12;
            // 
            // lblMedicine
            // 
            this.lblMedicine.AutoSize = true;
            this.lblMedicine.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblMedicine.Location = new System.Drawing.Point(0, 110);
            this.lblMedicine.Name = "lblMedicine";
            this.lblMedicine.Size = new System.Drawing.Size(34, 18);
            this.lblMedicine.TabIndex = 11;
            this.lblMedicine.Text = "Lek";
            // 
            // cbMedicine
            // 
            this.cbMedicine.FormattingEnabled = true;
            this.cbMedicine.Location = new System.Drawing.Point(0, 79);
            this.cbMedicine.Name = "cbMedicine";
            this.cbMedicine.Size = new System.Drawing.Size(352, 28);
            this.cbMedicine.TabIndex = 13;
            // 
            // lblPatient
            // 
            this.lblPatient.AutoSize = true;
            this.lblPatient.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblPatient.Location = new System.Drawing.Point(0, 190);
            this.lblPatient.Name = "lblPatient";
            this.lblPatient.Size = new System.Drawing.Size(63, 18);
            this.lblPatient.TabIndex = 11;
            this.lblPatient.Text = "Pacjent";
            // 
            // cbPatient
            // 
            this.cbPatient.FormattingEnabled = true;
            this.cbPatient.Location = new System.Drawing.Point(0, 159);
            this.cbPatient.Name = "cbPatient";
            this.cbPatient.Size = new System.Drawing.Size(352, 28);
            this.cbPatient.TabIndex = 13;
            // 
            // mcCalendar
            // 
            this.mcCalendar.BackColor = System.Drawing.SystemColors.Control;
            this.mcCalendar.FirstDayOfWeek = System.Windows.Forms.Day.Monday;
            this.mcCalendar.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.mcCalendar.ForeColor = System.Drawing.SystemColors.Control;
            this.mcCalendar.Location = new System.Drawing.Point(537, 60);
            this.mcCalendar.Margin = new System.Windows.Forms.Padding(14);
            this.mcCalendar.MaxDate = new System.DateTime(2099, 12, 31, 0, 0, 0, 0);
            this.mcCalendar.MaxSelectionCount = 1;
            this.mcCalendar.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.mcCalendar.Name = "mcCalendar";
            this.mcCalendar.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.mcCalendar.RightToLeftLayout = true;
            this.mcCalendar.ScrollChange = 1;
            this.mcCalendar.ShowToday = false;
            this.mcCalendar.ShowTodayCircle = false;
            this.mcCalendar.ShowWeekNumbers = true;
            this.mcCalendar.TabIndex = 14;
            this.mcCalendar.TitleBackColor = System.Drawing.Color.DarkSeaGreen;
            this.mcCalendar.TodayDate = new System.DateTime(2022, 12, 27, 0, 0, 0, 0);
            this.mcCalendar.TrailingForeColor = System.Drawing.Color.DarkSeaGreen;
            // 
            // lblInterval
            // 
            this.lblInterval.AutoSize = true;
            this.lblInterval.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblInterval.Location = new System.Drawing.Point(136, 274);
            this.lblInterval.Name = "lblInterval";
            this.lblInterval.Size = new System.Drawing.Size(108, 18);
            this.lblInterval.TabIndex = 11;
            this.lblInterval.Text = "Interwał (dni)";
            // 
            // nudInterval
            // 
            this.nudInterval.Location = new System.Drawing.Point(133, 240);
            this.nudInterval.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.nudInterval.Name = "nudInterval";
            this.nudInterval.Size = new System.Drawing.Size(61, 27);
            this.nudInterval.TabIndex = 15;
            // 
            // nudCount
            // 
            this.nudCount.Location = new System.Drawing.Point(0, 240);
            this.nudCount.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.nudCount.Name = "nudCount";
            this.nudCount.Size = new System.Drawing.Size(61, 27);
            this.nudCount.TabIndex = 17;
            // 
            // lblCount
            // 
            this.lblCount.AutoSize = true;
            this.lblCount.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCount.Location = new System.Drawing.Point(3, 274);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(42, 18);
            this.lblCount.TabIndex = 16;
            this.lblCount.Text = "Ilość";
            // 
            // TreatmentEditPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.nudCount);
            this.Controls.Add(this.lblCount);
            this.Controls.Add(this.nudInterval);
            this.Controls.Add(this.mcCalendar);
            this.Controls.Add(this.cbPatient);
            this.Controls.Add(this.lblInterval);
            this.Controls.Add(this.cbMedicine);
            this.Controls.Add(this.lblPatient);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.lblMedicine);
            this.Controls.Add(this.lblDetails);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Name = "TreatmentEditPage";
            this.Size = new System.Drawing.Size(825, 530);
            ((System.ComponentModel.ISupportInitialize)(this.nudInterval)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnSave;
        private Button btnCancel;
        private Label lblId;
        private TextBox txtId;
        private Label lblDetails;
        private TextBox txtDescription;
        private Label lblMedicine;
        private ComboBox cbMedicine;
        private Label lblPatient;
        private ComboBox cbPatient;
        private MonthCalendar mcCalendar;
        private Label lblInterval;
        private NumericUpDown nudInterval;
        private NumericUpDown nudCount;
        private Label lblCount;
    }
}