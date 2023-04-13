
namespace BD_Ecole_JS
{
    partial class ConsultSchedule
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
            this.gbTeacher = new System.Windows.Forms.GroupBox();
            this.bGoT = new System.Windows.Forms.Button();
            this.lTId = new System.Windows.Forms.Label();
            this.cbTId = new System.Windows.Forms.ComboBox();
            this.gbStudent = new System.Windows.Forms.GroupBox();
            this.bGoS = new System.Windows.Forms.Button();
            this.lStId = new System.Windows.Forms.Label();
            this.cbStId = new System.Windows.Forms.ComboBox();
            this.bStudent = new System.Windows.Forms.Button();
            this.bTeacher = new System.Windows.Forms.Button();
            this.dgvSchedule = new System.Windows.Forms.DataGridView();
            this.ScheduleID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SchDuration = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SchDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SchStart_Time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClassID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CourseID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CoName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bClear = new System.Windows.Forms.Button();
            this.gbTeacher.SuspendLayout();
            this.gbStudent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSchedule)).BeginInit();
            this.SuspendLayout();
            // 
            // gbTeacher
            // 
            this.gbTeacher.Controls.Add(this.bGoT);
            this.gbTeacher.Controls.Add(this.lTId);
            this.gbTeacher.Controls.Add(this.cbTId);
            this.gbTeacher.Enabled = false;
            this.gbTeacher.Location = new System.Drawing.Point(12, 52);
            this.gbTeacher.Name = "gbTeacher";
            this.gbTeacher.Size = new System.Drawing.Size(478, 244);
            this.gbTeacher.TabIndex = 0;
            this.gbTeacher.TabStop = false;
            this.gbTeacher.Text = "Teacher";
            // 
            // bGoT
            // 
            this.bGoT.Enabled = false;
            this.bGoT.Location = new System.Drawing.Point(1, 152);
            this.bGoT.Name = "bGoT";
            this.bGoT.Size = new System.Drawing.Size(477, 86);
            this.bGoT.TabIndex = 4;
            this.bGoT.Text = "GO";
            this.bGoT.UseVisualStyleBackColor = true;
            this.bGoT.Click += new System.EventHandler(this.bGoT_Click);
            // 
            // lTId
            // 
            this.lTId.AutoSize = true;
            this.lTId.Location = new System.Drawing.Point(6, 65);
            this.lTId.Name = "lTId";
            this.lTId.Size = new System.Drawing.Size(84, 20);
            this.lTId.TabIndex = 1;
            this.lTId.Text = "TeacherID";
            // 
            // cbTId
            // 
            this.cbTId.FormattingEnabled = true;
            this.cbTId.Location = new System.Drawing.Point(1, 88);
            this.cbTId.Name = "cbTId";
            this.cbTId.Size = new System.Drawing.Size(477, 28);
            this.cbTId.TabIndex = 0;
            this.cbTId.TextChanged += new System.EventHandler(this.cbTId_TextChanged);
            // 
            // gbStudent
            // 
            this.gbStudent.Controls.Add(this.bGoS);
            this.gbStudent.Controls.Add(this.lStId);
            this.gbStudent.Controls.Add(this.cbStId);
            this.gbStudent.Enabled = false;
            this.gbStudent.Location = new System.Drawing.Point(577, 52);
            this.gbStudent.Name = "gbStudent";
            this.gbStudent.Size = new System.Drawing.Size(478, 244);
            this.gbStudent.TabIndex = 1;
            this.gbStudent.TabStop = false;
            this.gbStudent.Text = "Student";
            // 
            // bGoS
            // 
            this.bGoS.Enabled = false;
            this.bGoS.Location = new System.Drawing.Point(0, 158);
            this.bGoS.Name = "bGoS";
            this.bGoS.Size = new System.Drawing.Size(478, 86);
            this.bGoS.TabIndex = 5;
            this.bGoS.Text = "GO";
            this.bGoS.UseVisualStyleBackColor = true;
            this.bGoS.Click += new System.EventHandler(this.bGoS_Click);
            // 
            // lStId
            // 
            this.lStId.AutoSize = true;
            this.lStId.Location = new System.Drawing.Point(6, 65);
            this.lStId.Name = "lStId";
            this.lStId.Size = new System.Drawing.Size(83, 20);
            this.lStId.TabIndex = 3;
            this.lStId.Text = "StudentID";
            // 
            // cbStId
            // 
            this.cbStId.FormattingEnabled = true;
            this.cbStId.Location = new System.Drawing.Point(1, 88);
            this.cbStId.Name = "cbStId";
            this.cbStId.Size = new System.Drawing.Size(477, 28);
            this.cbStId.TabIndex = 2;
            this.cbStId.TextChanged += new System.EventHandler(this.cbStId_TextChanged);
            // 
            // bStudent
            // 
            this.bStudent.Location = new System.Drawing.Point(577, 12);
            this.bStudent.Name = "bStudent";
            this.bStudent.Size = new System.Drawing.Size(478, 34);
            this.bStudent.TabIndex = 0;
            this.bStudent.Text = "Student";
            this.bStudent.UseVisualStyleBackColor = true;
            this.bStudent.Click += new System.EventHandler(this.bStudent_Click);
            // 
            // bTeacher
            // 
            this.bTeacher.Location = new System.Drawing.Point(12, 12);
            this.bTeacher.Name = "bTeacher";
            this.bTeacher.Size = new System.Drawing.Size(478, 34);
            this.bTeacher.TabIndex = 2;
            this.bTeacher.Text = "Teacher";
            this.bTeacher.UseVisualStyleBackColor = true;
            this.bTeacher.Click += new System.EventHandler(this.bTeacher_Click);
            // 
            // dgvSchedule
            // 
            this.dgvSchedule.AllowUserToAddRows = false;
            this.dgvSchedule.AllowUserToDeleteRows = false;
            this.dgvSchedule.ColumnHeadersHeight = 34;
            this.dgvSchedule.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ScheduleID,
            this.SchDuration,
            this.SchDate,
            this.SchStart_Time,
            this.ClassID,
            this.CourseID,
            this.ClName,
            this.CoName});
            this.dgvSchedule.Location = new System.Drawing.Point(12, 302);
            this.dgvSchedule.MultiSelect = false;
            this.dgvSchedule.Name = "dgvSchedule";
            this.dgvSchedule.ReadOnly = true;
            this.dgvSchedule.RowHeadersVisible = false;
            this.dgvSchedule.RowHeadersWidth = 62;
            this.dgvSchedule.RowTemplate.Height = 28;
            this.dgvSchedule.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSchedule.Size = new System.Drawing.Size(1043, 332);
            this.dgvSchedule.TabIndex = 3;
            // 
            // ScheduleID
            // 
            this.ScheduleID.DataPropertyName = "ScheduleID";
            this.ScheduleID.HeaderText = "ScheduleID";
            this.ScheduleID.MinimumWidth = 8;
            this.ScheduleID.Name = "ScheduleID";
            this.ScheduleID.ReadOnly = true;
            this.ScheduleID.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ScheduleID.Visible = false;
            this.ScheduleID.Width = 120;
            // 
            // SchDuration
            // 
            this.SchDuration.DataPropertyName = "SchDuration";
            this.SchDuration.HeaderText = "Duration";
            this.SchDuration.MinimumWidth = 8;
            this.SchDuration.Name = "SchDuration";
            this.SchDuration.ReadOnly = true;
            this.SchDuration.Width = 153;
            // 
            // SchDate
            // 
            this.SchDate.DataPropertyName = "SchDate";
            this.SchDate.HeaderText = "Date";
            this.SchDate.MinimumWidth = 8;
            this.SchDate.Name = "SchDate";
            this.SchDate.ReadOnly = true;
            this.SchDate.Width = 84;
            // 
            // SchStart_Time
            // 
            this.SchStart_Time.DataPropertyName = "SchStartTime";
            this.SchStart_Time.HeaderText = "Start Time";
            this.SchStart_Time.MinimumWidth = 8;
            this.SchStart_Time.Name = "SchStart_Time";
            this.SchStart_Time.ReadOnly = true;
            this.SchStart_Time.Width = 70;
            // 
            // ClassID
            // 
            this.ClassID.DataPropertyName = "ClassID";
            this.ClassID.HeaderText = "ClassID";
            this.ClassID.MinimumWidth = 8;
            this.ClassID.Name = "ClassID";
            this.ClassID.ReadOnly = true;
            this.ClassID.Width = 50;
            // 
            // CourseID
            // 
            this.CourseID.DataPropertyName = "CourseID";
            this.CourseID.HeaderText = "CourseID";
            this.CourseID.MinimumWidth = 8;
            this.CourseID.Name = "CourseID";
            this.CourseID.ReadOnly = true;
            this.CourseID.Width = 70;
            // 
            // ClName
            // 
            this.ClName.DataPropertyName = "ClName";
            this.ClName.HeaderText = "Class Name";
            this.ClName.MinimumWidth = 8;
            this.ClName.Name = "ClName";
            this.ClName.ReadOnly = true;
            this.ClName.Width = 120;
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
            // bClear
            // 
            this.bClear.Location = new System.Drawing.Point(12, 640);
            this.bClear.Name = "bClear";
            this.bClear.Size = new System.Drawing.Size(1043, 130);
            this.bClear.TabIndex = 4;
            this.bClear.Text = "Clear";
            this.bClear.UseVisualStyleBackColor = true;
            this.bClear.Click += new System.EventHandler(this.bClear_Click);
            // 
            // ConsultSchedule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 782);
            this.Controls.Add(this.bClear);
            this.Controls.Add(this.dgvSchedule);
            this.Controls.Add(this.bTeacher);
            this.Controls.Add(this.bStudent);
            this.Controls.Add(this.gbStudent);
            this.Controls.Add(this.gbTeacher);
            this.Name = "ConsultSchedule";
            this.Text = "ConsultSchedule";
            this.Load += new System.EventHandler(this.ConsultSchedule_Load);
            this.gbTeacher.ResumeLayout(false);
            this.gbTeacher.PerformLayout();
            this.gbStudent.ResumeLayout(false);
            this.gbStudent.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSchedule)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbTeacher;
        private System.Windows.Forms.Button bGoT;
        private System.Windows.Forms.Label lTId;
        private System.Windows.Forms.ComboBox cbTId;
        private System.Windows.Forms.GroupBox gbStudent;
        private System.Windows.Forms.Button bGoS;
        private System.Windows.Forms.Label lStId;
        private System.Windows.Forms.ComboBox cbStId;
        private System.Windows.Forms.Button bStudent;
        private System.Windows.Forms.Button bTeacher;
        private System.Windows.Forms.DataGridView dgvSchedule;
        private System.Windows.Forms.DataGridViewTextBoxColumn ScheduleID;
        private System.Windows.Forms.DataGridViewTextBoxColumn SchDuration;
        private System.Windows.Forms.DataGridViewTextBoxColumn SchDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn SchStart_Time;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClassID;
        private System.Windows.Forms.DataGridViewTextBoxColumn CourseID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClName;
        private System.Windows.Forms.DataGridViewTextBoxColumn CoName;
        private System.Windows.Forms.Button bClear;
    }
}