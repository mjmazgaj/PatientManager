namespace PatientManager.Control
{
    partial class ModelsListPage
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
            this.dgvModels = new System.Windows.Forms.DataGridView();
            this.lblName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblModels = new System.Windows.Forms.Label();
            this.cbModels = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvModels)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvModels
            // 
            this.dgvModels.AllowUserToAddRows = false;
            this.dgvModels.AllowUserToDeleteRows = false;
            this.dgvModels.AllowUserToResizeColumns = false;
            this.dgvModels.AllowUserToResizeRows = false;
            this.dgvModels.BackgroundColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(4);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvModels.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvModels.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvModels.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dgvModels.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvModels.EnableHeadersVisualStyles = false;
            this.dgvModels.Location = new System.Drawing.Point(0, 0);
            this.dgvModels.Margin = new System.Windows.Forms.Padding(0);
            this.dgvModels.Name = "dgvModels";
            this.dgvModels.RowHeadersVisible = false;
            this.dgvModels.RowHeadersWidth = 51;
            this.dgvModels.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.dgvModels.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dgvModels.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this.dgvModels.RowTemplate.DefaultCellStyle.Padding = new System.Windows.Forms.Padding(4);
            this.dgvModels.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.SystemColors.Control;
            this.dgvModels.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvModels.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvModels.Size = new System.Drawing.Size(600, 389);
            this.dgvModels.TabIndex = 0;
            this.dgvModels.SelectionChanged += new System.EventHandler(this.dgvModels_SelectionChanged);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(13, 412);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(54, 20);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Nazwa";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(73, 409);
            this.txtName.Name = "txtName";
            this.txtName.ReadOnly = true;
            this.txtName.Size = new System.Drawing.Size(201, 27);
            this.txtName.TabIndex = 2;
            // 
            // lblModels
            // 
            this.lblModels.AutoSize = true;
            this.lblModels.Location = new System.Drawing.Point(298, 412);
            this.lblModels.Name = "lblModels";
            this.lblModels.Size = new System.Drawing.Size(62, 20);
            this.lblModels.TabIndex = 1;
            this.lblModels.Text = "Pacjenci";
            // 
            // cbModels
            // 
            this.cbModels.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbModels.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbModels.FormattingEnabled = true;
            this.cbModels.Location = new System.Drawing.Point(366, 408);
            this.cbModels.Name = "cbModels";
            this.cbModels.Size = new System.Drawing.Size(215, 28);
            this.cbModels.TabIndex = 3;
            // 
            // ModelsListPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.cbModels);
            this.Controls.Add(this.lblModels);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.dgvModels);
            this.Name = "ModelsListPage";
            this.Size = new System.Drawing.Size(600, 445);
            ((System.ComponentModel.ISupportInitialize)(this.dgvModels)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dgvModels;
        private Label lblName;
        private TextBox txtName;
        private Label lblModels;
        private ComboBox cbModels;
    }
}
