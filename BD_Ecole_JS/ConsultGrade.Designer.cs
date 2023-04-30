
namespace BD_Ecole_JS
{
    partial class ConsultGrade
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gbStudent = new System.Windows.Forms.GroupBox();
            this.bGoS = new System.Windows.Forms.Button();
            this.lStId = new System.Windows.Forms.Label();
            this.cbStId = new System.Windows.Forms.ComboBox();
            this.CoName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gscore = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvGrade = new System.Windows.Forms.DataGridView();
            this.gbStudent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGrade)).BeginInit();
            this.SuspendLayout();
            // 
            // gbStudent
            // 
            this.gbStudent.Controls.Add(this.bGoS);
            this.gbStudent.Controls.Add(this.lStId);
            this.gbStudent.Controls.Add(this.cbStId);
            this.gbStudent.Enabled = false;
            this.gbStudent.Location = new System.Drawing.Point(12, 12);
            this.gbStudent.Name = "gbStudent";
            this.gbStudent.Size = new System.Drawing.Size(1173, 244);
            this.gbStudent.TabIndex = 2;
            this.gbStudent.TabStop = false;
            this.gbStudent.Text = "Student";
            // 
            // bGoS
            // 
            this.bGoS.Enabled = false;
            this.bGoS.Location = new System.Drawing.Point(0, 158);
            this.bGoS.Name = "bGoS";
            this.bGoS.Size = new System.Drawing.Size(1173, 86);
            this.bGoS.TabIndex = 5;
            this.bGoS.Text = "GO";
            this.bGoS.UseVisualStyleBackColor = true;
            this.bGoS.Click += new System.EventHandler(this.bGoS_Click);
            // 
            // lStId
            // 
            this.lStId.Location = new System.Drawing.Point(6, 55);
            this.lStId.Name = "lStId";
            this.lStId.Size = new System.Drawing.Size(1167, 30);
            this.lStId.TabIndex = 3;
            this.lStId.Text = "StudentID";
            this.lStId.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cbStId
            // 
            this.cbStId.FormattingEnabled = true;
            this.cbStId.Location = new System.Drawing.Point(1, 88);
            this.cbStId.Name = "cbStId";
            this.cbStId.Size = new System.Drawing.Size(1166, 28);
            this.cbStId.TabIndex = 2;
            this.cbStId.TextChanged += new System.EventHandler(this.cbStId_TextChanged);
            // 
            // CoName
            // 
            this.CoName.DataPropertyName = "CoName";
            this.CoName.HeaderText = "Course Name";
            this.CoName.MinimumWidth = 8;
            this.CoName.Name = "CoName";
            this.CoName.ReadOnly = true;
            this.CoName.Width = 130;
            // 
            // StName
            // 
            this.StName.DataPropertyName = "StName";
            this.StName.HeaderText = "Student Name";
            this.StName.MinimumWidth = 8;
            this.StName.Name = "StName";
            this.StName.ReadOnly = true;
            this.StName.Width = 120;
            // 
            // AId
            // 
            this.AId.DataPropertyName = "AId";
            this.AId.HeaderText = "AssociationID";
            this.AId.MinimumWidth = 8;
            this.AId.Name = "AId";
            this.AId.ReadOnly = true;
            this.AId.Width = 50;
            // 
            // GDate
            // 
            this.GDate.DataPropertyName = "GDate";
            this.GDate.HeaderText = "Date";
            this.GDate.MinimumWidth = 8;
            this.GDate.Name = "GDate";
            this.GDate.ReadOnly = true;
            this.GDate.Width = 70;
            // 
            // Gscore
            // 
            this.Gscore.DataPropertyName = "Gscore";
            this.Gscore.HeaderText = "Score";
            this.Gscore.MinimumWidth = 8;
            this.Gscore.Name = "Gscore";
            this.Gscore.ReadOnly = true;
            this.Gscore.Width = 84;
            // 
            // GName
            // 
            this.GName.DataPropertyName = "GName";
            this.GName.HeaderText = "Name";
            this.GName.MinimumWidth = 8;
            this.GName.Name = "GName";
            this.GName.ReadOnly = true;
            this.GName.Width = 153;
            // 
            // GId
            // 
            this.GId.DataPropertyName = "GId";
            this.GId.HeaderText = "GradeID";
            this.GId.MinimumWidth = 8;
            this.GId.Name = "GId";
            this.GId.ReadOnly = true;
            this.GId.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.GId.Visible = false;
            this.GId.Width = 120;
            // 
            // dgvGrade
            // 
            this.dgvGrade.AllowUserToAddRows = false;
            this.dgvGrade.AllowUserToDeleteRows = false;
            this.dgvGrade.ColumnHeadersHeight = 34;
            this.dgvGrade.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.GId,
            this.GName,
            this.Gscore,
            this.GDate,
            this.AId,
            this.StName,
            this.CoName});
            this.dgvGrade.Location = new System.Drawing.Point(13, 279);
            this.dgvGrade.MultiSelect = false;
            this.dgvGrade.Name = "dgvGrade";
            this.dgvGrade.ReadOnly = true;
            this.dgvGrade.RowHeadersVisible = false;
            this.dgvGrade.RowHeadersWidth = 62;
            this.dgvGrade.RowTemplate.Height = 28;
            this.dgvGrade.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvGrade.Size = new System.Drawing.Size(1172, 368);
            this.dgvGrade.TabIndex = 3;
            // 
            // ConsultGrade
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1197, 659);
            this.Controls.Add(this.dgvGrade);
            this.Controls.Add(this.gbStudent);
            this.Name = "ConsultGrade";
            this.Text = "ConsultGrade";
            this.Load += new System.EventHandler(this.ConsultGrade_Load);
            this.gbStudent.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGrade)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbStudent;
        private System.Windows.Forms.Button bGoS;
        private System.Windows.Forms.Label lStId;
        private System.Windows.Forms.ComboBox cbStId;
        private System.Windows.Forms.DataGridViewTextBoxColumn CoName;
        private System.Windows.Forms.DataGridViewTextBoxColumn StName;
        private System.Windows.Forms.DataGridViewTextBoxColumn AId;
        private System.Windows.Forms.DataGridViewTextBoxColumn GDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gscore;
        private System.Windows.Forms.DataGridViewTextBoxColumn GName;
        private System.Windows.Forms.DataGridViewTextBoxColumn GId;
        private System.Windows.Forms.DataGridView dgvGrade;
    }
}