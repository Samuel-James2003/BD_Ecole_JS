
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.bCreateSch = new System.Windows.Forms.Button();
            this.bConsultGrade = new System.Windows.Forms.Button();
            this.bConsultSchedule = new System.Windows.Forms.Button();
            this.bGAssocitation = new System.Windows.Forms.Button();
            this.bGCourse = new System.Windows.Forms.Button();
            this.bGGrade = new System.Windows.Forms.Button();
            this.bGDSChedule = new System.Windows.Forms.Button();
            this.bGClass = new System.Windows.Forms.Button();
            this.bGStudent = new System.Windows.Forms.Button();
            this.bGTeacher = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.bCreateSch);
            this.splitContainer1.Panel1.Controls.Add(this.bConsultGrade);
            this.splitContainer1.Panel1.Controls.Add(this.bConsultSchedule);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.bGAssocitation);
            this.splitContainer1.Panel2.Controls.Add(this.bGCourse);
            this.splitContainer1.Panel2.Controls.Add(this.bGGrade);
            this.splitContainer1.Panel2.Controls.Add(this.bGDSChedule);
            this.splitContainer1.Panel2.Controls.Add(this.bGClass);
            this.splitContainer1.Panel2.Controls.Add(this.bGStudent);
            this.splitContainer1.Panel2.Controls.Add(this.bGTeacher);
            this.splitContainer1.Size = new System.Drawing.Size(1614, 736);
            this.splitContainer1.SplitterDistance = 511;
            this.splitContainer1.TabIndex = 0;
            // 
            // bCreateSch
            // 
            this.bCreateSch.Dock = System.Windows.Forms.DockStyle.Left;
            this.bCreateSch.Location = new System.Drawing.Point(1038, 0);
            this.bCreateSch.Name = "bCreateSch";
            this.bCreateSch.Size = new System.Drawing.Size(564, 511);
            this.bCreateSch.TabIndex = 4;
            this.bCreateSch.Text = "Create Schedule";
            this.bCreateSch.UseVisualStyleBackColor = true;
            this.bCreateSch.Click += new System.EventHandler(this.bCreateSch_Click);
            // 
            // bConsultGrade
            // 
            this.bConsultGrade.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.bConsultGrade.Dock = System.Windows.Forms.DockStyle.Left;
            this.bConsultGrade.Location = new System.Drawing.Point(427, 0);
            this.bConsultGrade.Name = "bConsultGrade";
            this.bConsultGrade.Size = new System.Drawing.Size(611, 511);
            this.bConsultGrade.TabIndex = 3;
            this.bConsultGrade.Text = "Consult Grades";
            this.bConsultGrade.UseVisualStyleBackColor = false;
            this.bConsultGrade.Click += new System.EventHandler(this.bConsultGrade_Click);
            // 
            // bConsultSchedule
            // 
            this.bConsultSchedule.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.bConsultSchedule.Dock = System.Windows.Forms.DockStyle.Left;
            this.bConsultSchedule.Location = new System.Drawing.Point(0, 0);
            this.bConsultSchedule.Name = "bConsultSchedule";
            this.bConsultSchedule.Size = new System.Drawing.Size(427, 511);
            this.bConsultSchedule.TabIndex = 2;
            this.bConsultSchedule.Text = "Consult Schedule";
            this.bConsultSchedule.UseVisualStyleBackColor = false;
            this.bConsultSchedule.Click += new System.EventHandler(this.bConsultSchedule_Click);
            // 
            // bGAssocitation
            // 
            this.bGAssocitation.BackColor = System.Drawing.Color.Purple;
            this.bGAssocitation.Dock = System.Windows.Forms.DockStyle.Left;
            this.bGAssocitation.Location = new System.Drawing.Point(1383, 0);
            this.bGAssocitation.Name = "bGAssocitation";
            this.bGAssocitation.Size = new System.Drawing.Size(230, 221);
            this.bGAssocitation.TabIndex = 12;
            this.bGAssocitation.Text = "Gestion Association";
            this.bGAssocitation.UseVisualStyleBackColor = false;
            this.bGAssocitation.Click += new System.EventHandler(this.bGAssocitation_Click);
            // 
            // bGCourse
            // 
            this.bGCourse.BackColor = System.Drawing.Color.Gray;
            this.bGCourse.Dock = System.Windows.Forms.DockStyle.Left;
            this.bGCourse.Location = new System.Drawing.Point(1158, 0);
            this.bGCourse.Name = "bGCourse";
            this.bGCourse.Size = new System.Drawing.Size(225, 221);
            this.bGCourse.TabIndex = 11;
            this.bGCourse.Text = "Gestion Course";
            this.bGCourse.UseVisualStyleBackColor = false;
            this.bGCourse.Click += new System.EventHandler(this.bGCourse_Click);
            // 
            // bGGrade
            // 
            this.bGGrade.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.bGGrade.Dock = System.Windows.Forms.DockStyle.Left;
            this.bGGrade.Location = new System.Drawing.Point(932, 0);
            this.bGGrade.Name = "bGGrade";
            this.bGGrade.Size = new System.Drawing.Size(226, 221);
            this.bGGrade.TabIndex = 10;
            this.bGGrade.Text = "Gestion Grade";
            this.bGGrade.UseVisualStyleBackColor = false;
            this.bGGrade.Click += new System.EventHandler(this.bGGrade_Click);
            // 
            // bGDSChedule
            // 
            this.bGDSChedule.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bGDSChedule.Dock = System.Windows.Forms.DockStyle.Left;
            this.bGDSChedule.Location = new System.Drawing.Point(714, 0);
            this.bGDSChedule.Name = "bGDSChedule";
            this.bGDSChedule.Size = new System.Drawing.Size(218, 221);
            this.bGDSChedule.TabIndex = 9;
            this.bGDSChedule.Text = "Gestion Schedule";
            this.bGDSChedule.UseVisualStyleBackColor = false;
            this.bGDSChedule.Click += new System.EventHandler(this.bGDSChedule_Click);
            // 
            // bGClass
            // 
            this.bGClass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.bGClass.Dock = System.Windows.Forms.DockStyle.Left;
            this.bGClass.Location = new System.Drawing.Point(427, 0);
            this.bGClass.Name = "bGClass";
            this.bGClass.Size = new System.Drawing.Size(287, 221);
            this.bGClass.TabIndex = 8;
            this.bGClass.Text = "Gestion Class";
            this.bGClass.UseVisualStyleBackColor = false;
            this.bGClass.Click += new System.EventHandler(this.bGClass_Click);
            // 
            // bGStudent
            // 
            this.bGStudent.BackColor = System.Drawing.Color.LightCoral;
            this.bGStudent.Dock = System.Windows.Forms.DockStyle.Left;
            this.bGStudent.Location = new System.Drawing.Point(200, 0);
            this.bGStudent.Name = "bGStudent";
            this.bGStudent.Size = new System.Drawing.Size(227, 221);
            this.bGStudent.TabIndex = 7;
            this.bGStudent.Text = "Gestion Student";
            this.bGStudent.UseVisualStyleBackColor = false;
            this.bGStudent.Click += new System.EventHandler(this.bGStudent_Click);
            // 
            // bGTeacher
            // 
            this.bGTeacher.BackColor = System.Drawing.Color.Maroon;
            this.bGTeacher.Dock = System.Windows.Forms.DockStyle.Left;
            this.bGTeacher.Location = new System.Drawing.Point(0, 0);
            this.bGTeacher.Name = "bGTeacher";
            this.bGTeacher.Size = new System.Drawing.Size(200, 221);
            this.bGTeacher.TabIndex = 6;
            this.bGTeacher.Text = "Gestion Teacher";
            this.bGTeacher.UseVisualStyleBackColor = false;
            this.bGTeacher.Click += new System.EventHandler(this.bGTeacher_Click);
            // 
            // MainScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1614, 736);
            this.Controls.Add(this.splitContainer1);
            this.Name = "MainScreen";
            this.Text = "Main Screen Page";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button bGCourse;
        private System.Windows.Forms.Button bGGrade;
        private System.Windows.Forms.Button bGDSChedule;
        private System.Windows.Forms.Button bGClass;
        private System.Windows.Forms.Button bGStudent;
        private System.Windows.Forms.Button bGTeacher;
        private System.Windows.Forms.Button bGAssocitation;
        private System.Windows.Forms.Button bCreateSch;
        private System.Windows.Forms.Button bConsultGrade;
        private System.Windows.Forms.Button bConsultSchedule;
    }
}

