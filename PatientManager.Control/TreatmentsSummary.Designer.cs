namespace PatientManager.Control
{
    partial class TreatmentsSummary
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnCalendarNext = new System.Windows.Forms.Button();
            this.btnCalendarPrev = new System.Windows.Forms.Button();
            this.btnToday = new System.Windows.Forms.Button();
            this.dgvSummaryTreatment = new System.Windows.Forms.DataGridView();
            this.lblDate = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSummaryTreatment)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCalendarNext
            // 
            this.btnCalendarNext.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCalendarNext.Location = new System.Drawing.Point(746, 33);
            this.btnCalendarNext.Name = "btnCalendarNext";
            this.btnCalendarNext.Size = new System.Drawing.Size(50, 29);
            this.btnCalendarNext.TabIndex = 3;
            this.btnCalendarNext.Text = ">>>";
            this.btnCalendarNext.UseVisualStyleBackColor = true;
            this.btnCalendarNext.Click += new System.EventHandler(this.btnCalendarNext_Click);
            // 
            // btnCalendarPrev
            // 
            this.btnCalendarPrev.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCalendarPrev.Location = new System.Drawing.Point(621, 33);
            this.btnCalendarPrev.Name = "btnCalendarPrev";
            this.btnCalendarPrev.Size = new System.Drawing.Size(50, 29);
            this.btnCalendarPrev.TabIndex = 3;
            this.btnCalendarPrev.Text = "<<<";
            this.btnCalendarPrev.UseVisualStyleBackColor = true;
            this.btnCalendarPrev.Click += new System.EventHandler(this.btnCalendarPrev_Click);
            // 
            // btnToday
            // 
            this.btnToday.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnToday.Location = new System.Drawing.Point(683, 0);
            this.btnToday.Name = "btnToday";
            this.btnToday.Size = new System.Drawing.Size(50, 29);
            this.btnToday.TabIndex = 3;
            this.btnToday.Text = "Dziś";
            this.btnToday.UseVisualStyleBackColor = true;
            this.btnToday.Click += new System.EventHandler(this.btnToday_Click);
            // 
            // dgvSummaryTreatment
            // 
            this.dgvSummaryTreatment.AllowUserToAddRows = false;
            this.dgvSummaryTreatment.AllowUserToDeleteRows = false;
            this.dgvSummaryTreatment.AllowUserToResizeColumns = false;
            this.dgvSummaryTreatment.AllowUserToResizeRows = false;
            this.dgvSummaryTreatment.BackgroundColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(4);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSummaryTreatment.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvSummaryTreatment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSummaryTreatment.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dgvSummaryTreatment.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvSummaryTreatment.EnableHeadersVisualStyles = false;
            this.dgvSummaryTreatment.Location = new System.Drawing.Point(0, 0);
            this.dgvSummaryTreatment.Margin = new System.Windows.Forms.Padding(0);
            this.dgvSummaryTreatment.Name = "dgvSummaryTreatment";
            this.dgvSummaryTreatment.RowHeadersVisible = false;
            this.dgvSummaryTreatment.RowHeadersWidth = 51;
            this.dgvSummaryTreatment.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.dgvSummaryTreatment.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dgvSummaryTreatment.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this.dgvSummaryTreatment.RowTemplate.DefaultCellStyle.Padding = new System.Windows.Forms.Padding(4);
            this.dgvSummaryTreatment.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.SystemColors.Control;
            this.dgvSummaryTreatment.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvSummaryTreatment.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSummaryTreatment.Size = new System.Drawing.Size(586, 530);
            this.dgvSummaryTreatment.TabIndex = 14;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(677, 37);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(63, 20);
            this.lblDate.TabIndex = 2;
            this.lblDate.Text = "12/2022";
            // 
            // TreatmentsSummary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgvSummaryTreatment);
            this.Controls.Add(this.btnCalendarPrev);
            this.Controls.Add(this.btnToday);
            this.Controls.Add(this.btnCalendarNext);
            this.Controls.Add(this.lblDate);
            this.Name = "TreatmentsSummary";
            this.Size = new System.Drawing.Size(825, 530);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSummaryTreatment)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Button btnCalendarNext;
        private Button btnCalendarPrev;
        private Button btnToday;
        private DataGridView dgvSummaryTreatment;
        private Label lblDate;
    }
}
