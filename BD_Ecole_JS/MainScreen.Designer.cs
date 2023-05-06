
namespace BD_Ecole_JS
{
    partial class MainScreen
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
            this.msNav = new System.Windows.Forms.MenuStrip();
            this.tsGestion = new System.Windows.Forms.ToolStripMenuItem();
            this.tsgTeacher = new System.Windows.Forms.ToolStripMenuItem();
            this.tsgStudent = new System.Windows.Forms.ToolStripMenuItem();
            this.tsgClass = new System.Windows.Forms.ToolStripMenuItem();
            this.tsgSchedule = new System.Windows.Forms.ToolStripMenuItem();
            this.tsgGrade = new System.Windows.Forms.ToolStripMenuItem();
            this.tsgCourse = new System.Windows.Forms.ToolStripMenuItem();
            this.tsgAssoc = new System.Windows.Forms.ToolStripMenuItem();
            this.tsCreateSched = new System.Windows.Forms.ToolStripMenuItem();
            this.tsConsult = new System.Windows.Forms.ToolStripMenuItem();
            this.tscGrade = new System.Windows.Forms.ToolStripMenuItem();
            this.tscSchedule = new System.Windows.Forms.ToolStripMenuItem();
            this.tvSchool = new System.Windows.Forms.TreeView();
            this.dgvSchedule = new System.Windows.Forms.DataGridView();
            this.ScheduleID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SchDuration = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SchDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SchStart_Time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClassID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CourseID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CoName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvGrade = new System.Windows.Forms.DataGridView();
            this.GId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gscore = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvNoGrade = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.msNav.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSchedule)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGrade)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNoGrade)).BeginInit();
            this.SuspendLayout();
            // 
            // msNav
            // 
            this.msNav.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.msNav.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.msNav.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsGestion,
            this.tsCreateSched,
            this.tsConsult});
            this.msNav.Location = new System.Drawing.Point(0, 0);
            this.msNav.Name = "msNav";
            this.msNav.Size = new System.Drawing.Size(1921, 36);
            this.msNav.TabIndex = 9;
            this.msNav.Text = "menuStrip1";
            // 
            // tsGestion
            // 
            this.tsGestion.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsgTeacher,
            this.tsgStudent,
            this.tsgClass,
            this.tsgSchedule,
            this.tsgGrade,
            this.tsgCourse,
            this.tsgAssoc});
            this.tsGestion.Name = "tsGestion";
            this.tsGestion.Size = new System.Drawing.Size(88, 29);
            this.tsGestion.Text = "Gestion";
            // 
            // tsgTeacher
            // 
            this.tsgTeacher.Name = "tsgTeacher";
            this.tsgTeacher.Size = new System.Drawing.Size(205, 34);
            this.tsgTeacher.Text = "Teacher";
            this.tsgTeacher.Click += new System.EventHandler(this.tsgTeacher_Click);
            // 
            // tsgStudent
            // 
            this.tsgStudent.Name = "tsgStudent";
            this.tsgStudent.Size = new System.Drawing.Size(205, 34);
            this.tsgStudent.Text = "Student";
            this.tsgStudent.Click += new System.EventHandler(this.tsgStudent_Click);
            // 
            // tsgClass
            // 
            this.tsgClass.Name = "tsgClass";
            this.tsgClass.Size = new System.Drawing.Size(205, 34);
            this.tsgClass.Text = "Class";
            this.tsgClass.Click += new System.EventHandler(this.tsgClass_Click);
            // 
            // tsgSchedule
            // 
            this.tsgSchedule.Name = "tsgSchedule";
            this.tsgSchedule.Size = new System.Drawing.Size(205, 34);
            this.tsgSchedule.Text = "Schedule";
            this.tsgSchedule.Click += new System.EventHandler(this.tsgSchedule_Click);
            // 
            // tsgGrade
            // 
            this.tsgGrade.Name = "tsgGrade";
            this.tsgGrade.Size = new System.Drawing.Size(205, 34);
            this.tsgGrade.Text = "Grade";
            this.tsgGrade.Click += new System.EventHandler(this.tsgGrade_Click);
            // 
            // tsgCourse
            // 
            this.tsgCourse.Name = "tsgCourse";
            this.tsgCourse.Size = new System.Drawing.Size(205, 34);
            this.tsgCourse.Text = "Course";
            this.tsgCourse.Click += new System.EventHandler(this.tsgCourse_Click);
            // 
            // tsgAssoc
            // 
            this.tsgAssoc.Name = "tsgAssoc";
            this.tsgAssoc.Size = new System.Drawing.Size(205, 34);
            this.tsgAssoc.Text = "Association";
            this.tsgAssoc.Click += new System.EventHandler(this.tsgAssoc_Click);
            // 
            // tsCreateSched
            // 
            this.tsCreateSched.Name = "tsCreateSched";
            this.tsCreateSched.Size = new System.Drawing.Size(154, 29);
            this.tsCreateSched.Text = "Create Schedule";
            this.tsCreateSched.Click += new System.EventHandler(this.tsCreateSched_Click);
            // 
            // tsConsult
            // 
            this.tsConsult.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tscGrade,
            this.tscSchedule});
            this.tsConsult.Name = "tsConsult";
            this.tsConsult.Size = new System.Drawing.Size(88, 29);
            this.tsConsult.Text = "Consult";
            // 
            // tscGrade
            // 
            this.tscGrade.Name = "tscGrade";
            this.tscGrade.Size = new System.Drawing.Size(193, 34);
            this.tscGrade.Text = "Grades";
            this.tscGrade.Click += new System.EventHandler(this.tscGrade_Click);
            // 
            // tscSchedule
            // 
            this.tscSchedule.Name = "tscSchedule";
            this.tscSchedule.Size = new System.Drawing.Size(193, 34);
            this.tscSchedule.Text = "Schedules";
            this.tscSchedule.Click += new System.EventHandler(this.tscSchedule_Click);
            // 
            // tvSchool
            // 
            this.tvSchool.Location = new System.Drawing.Point(12, 50);
            this.tvSchool.Name = "tvSchool";
            this.tvSchool.Size = new System.Drawing.Size(394, 704);
            this.tvSchool.TabIndex = 10;
            this.tvSchool.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tvSchool_AfterSelect);
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
            this.dgvSchedule.Location = new System.Drawing.Point(412, 50);
            this.dgvSchedule.MultiSelect = false;
            this.dgvSchedule.Name = "dgvSchedule";
            this.dgvSchedule.ReadOnly = true;
            this.dgvSchedule.RowHeadersVisible = false;
            this.dgvSchedule.RowHeadersWidth = 62;
            this.dgvSchedule.RowTemplate.Height = 28;
            this.dgvSchedule.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSchedule.Size = new System.Drawing.Size(1151, 704);
            this.dgvSchedule.TabIndex = 13;
            this.dgvSchedule.Visible = false;
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
            this.CourseID.Width = 50;
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
            this.dataGridViewTextBoxColumn1,
            this.TName});
            this.dgvGrade.Location = new System.Drawing.Point(412, 50);
            this.dgvGrade.MultiSelect = false;
            this.dgvGrade.Name = "dgvGrade";
            this.dgvGrade.ReadOnly = true;
            this.dgvGrade.RowHeadersVisible = false;
            this.dgvGrade.RowHeadersWidth = 62;
            this.dgvGrade.RowTemplate.Height = 28;
            this.dgvGrade.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvGrade.Size = new System.Drawing.Size(1151, 315);
            this.dgvGrade.TabIndex = 15;
            this.dgvGrade.Visible = false;
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
            // GName
            // 
            this.GName.DataPropertyName = "GName";
            this.GName.HeaderText = "Name";
            this.GName.MinimumWidth = 8;
            this.GName.Name = "GName";
            this.GName.ReadOnly = true;
            this.GName.Width = 153;
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
            // GDate
            // 
            this.GDate.DataPropertyName = "GDate";
            this.GDate.HeaderText = "Date";
            this.GDate.MinimumWidth = 8;
            this.GDate.Name = "GDate";
            this.GDate.ReadOnly = true;
            this.GDate.Width = 70;
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
            // StName
            // 
            this.StName.DataPropertyName = "StName";
            this.StName.HeaderText = "Student Name";
            this.StName.MinimumWidth = 8;
            this.StName.Name = "StName";
            this.StName.ReadOnly = true;
            this.StName.Width = 120;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "CoName";
            this.dataGridViewTextBoxColumn1.HeaderText = "Course Name";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 130;
            // 
            // TName
            // 
            this.TName.DataPropertyName = "TName";
            this.TName.HeaderText = "Teacher Name";
            this.TName.MinimumWidth = 8;
            this.TName.Name = "TName";
            this.TName.ReadOnly = true;
            this.TName.Width = 150;
            // 
            // dgvNoGrade
            // 
            this.dgvNoGrade.AllowUserToAddRows = false;
            this.dgvNoGrade.AllowUserToDeleteRows = false;
            this.dgvNoGrade.ColumnHeadersHeight = 34;
            this.dgvNoGrade.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9});
            this.dgvNoGrade.Location = new System.Drawing.Point(412, 371);
            this.dgvNoGrade.MultiSelect = false;
            this.dgvNoGrade.Name = "dgvNoGrade";
            this.dgvNoGrade.RowHeadersVisible = false;
            this.dgvNoGrade.RowHeadersWidth = 62;
            this.dgvNoGrade.RowTemplate.Height = 28;
            this.dgvNoGrade.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvNoGrade.Size = new System.Drawing.Size(1151, 383);
            this.dgvNoGrade.TabIndex = 16;
            this.dgvNoGrade.Visible = false;
            this.dgvNoGrade.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvNoGrade_CellDoubleClick);
            this.dgvNoGrade.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvNoGrade_RowEnter);
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "GId";
            this.dataGridViewTextBoxColumn2.HeaderText = "GradeID";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn2.Visible = false;
            this.dataGridViewTextBoxColumn2.Width = 120;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "GName";
            this.dataGridViewTextBoxColumn3.HeaderText = "Name";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 153;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Gscore";
            this.dataGridViewTextBoxColumn4.HeaderText = "Score";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 84;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "GDate";
            this.dataGridViewTextBoxColumn5.HeaderText = "Date";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 70;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "AId";
            this.dataGridViewTextBoxColumn6.HeaderText = "AssociationID";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Width = 50;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "StName";
            this.dataGridViewTextBoxColumn7.HeaderText = "Student Name";
            this.dataGridViewTextBoxColumn7.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.Width = 120;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "CoName";
            this.dataGridViewTextBoxColumn8.HeaderText = "Course Name";
            this.dataGridViewTextBoxColumn8.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            this.dataGridViewTextBoxColumn8.Width = 130;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "TName";
            this.dataGridViewTextBoxColumn9.HeaderText = "Teacher Name";
            this.dataGridViewTextBoxColumn9.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            this.dataGridViewTextBoxColumn9.Width = 150;
            // 
            // MainScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1921, 992);
            this.Controls.Add(this.dgvNoGrade);
            this.Controls.Add(this.tvSchool);
            this.Controls.Add(this.msNav);
            this.Controls.Add(this.dgvGrade);
            this.Controls.Add(this.dgvSchedule);
            this.Name = "MainScreen";
            this.Text = "Main Screen Page";
            this.Load += new System.EventHandler(this.MainScreen_Load);
            this.msNav.ResumeLayout(false);
            this.msNav.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSchedule)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGrade)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNoGrade)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip msNav;
        private System.Windows.Forms.ToolStripMenuItem tsGestion;
        private System.Windows.Forms.ToolStripMenuItem tsgTeacher;
        private System.Windows.Forms.ToolStripMenuItem tsgStudent;
        private System.Windows.Forms.ToolStripMenuItem tsgClass;
        private System.Windows.Forms.ToolStripMenuItem tsgSchedule;
        private System.Windows.Forms.ToolStripMenuItem tsgGrade;
        private System.Windows.Forms.ToolStripMenuItem tsgCourse;
        private System.Windows.Forms.ToolStripMenuItem tsgAssoc;
        private System.Windows.Forms.ToolStripMenuItem tsCreateSched;
        private System.Windows.Forms.TreeView tvSchool;
        private System.Windows.Forms.DataGridView dgvSchedule;
        private System.Windows.Forms.DataGridViewTextBoxColumn ScheduleID;
        private System.Windows.Forms.DataGridViewTextBoxColumn SchDuration;
        private System.Windows.Forms.DataGridViewTextBoxColumn SchDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn SchStart_Time;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClassID;
        private System.Windows.Forms.DataGridViewTextBoxColumn CourseID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClName;
        private System.Windows.Forms.DataGridViewTextBoxColumn CoName;
        private System.Windows.Forms.DataGridView dgvGrade;
        private System.Windows.Forms.ToolStripMenuItem tsConsult;
        private System.Windows.Forms.ToolStripMenuItem tscGrade;
        private System.Windows.Forms.ToolStripMenuItem tscSchedule;
        private System.Windows.Forms.DataGridViewTextBoxColumn GId;
        private System.Windows.Forms.DataGridViewTextBoxColumn GName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gscore;
        private System.Windows.Forms.DataGridViewTextBoxColumn GDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn AId;
        private System.Windows.Forms.DataGridViewTextBoxColumn StName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn TName;
        private System.Windows.Forms.DataGridView dgvNoGrade;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
    }
}

