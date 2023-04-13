
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
            this.bGAssocitation = new System.Windows.Forms.Button();
            this.bGCourse = new System.Windows.Forms.Button();
            this.bGGrade = new System.Windows.Forms.Button();
            this.bGDSChedule = new System.Windows.Forms.Button();
            this.bGClass = new System.Windows.Forms.Button();
            this.bGStudent = new System.Windows.Forms.Button();
            this.bGTeacher = new System.Windows.Forms.Button();
            this.bConsultSchedule = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
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
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.bGAssocitation);
            this.splitContainer1.Panel2.Controls.Add(this.bGCourse);
            this.splitContainer1.Panel2.Controls.Add(this.bGGrade);
            this.splitContainer1.Panel2.Controls.Add(this.bGDSChedule);
            this.splitContainer1.Panel2.Controls.Add(this.bGClass);
            this.splitContainer1.Panel2.Controls.Add(this.bGStudent);
            this.splitContainer1.Panel2.Controls.Add(this.bGTeacher);
            this.splitContainer1.Size = new System.Drawing.Size(1616, 712);
            this.splitContainer1.SplitterDistance = 495;
            this.splitContainer1.TabIndex = 0;
            // 
            // bGAssocitation
            // 
            this.bGAssocitation.Dock = System.Windows.Forms.DockStyle.Left;
            this.bGAssocitation.Location = new System.Drawing.Point(1383, 0);
            this.bGAssocitation.Name = "bGAssocitation";
            this.bGAssocitation.Size = new System.Drawing.Size(230, 213);
            this.bGAssocitation.TabIndex = 12;
            this.bGAssocitation.Text = "Gestion Association";
            this.bGAssocitation.UseVisualStyleBackColor = true;
            this.bGAssocitation.Click += new System.EventHandler(this.bGAssocitation_Click);
            // 
            // bGCourse
            // 
            this.bGCourse.Dock = System.Windows.Forms.DockStyle.Left;
            this.bGCourse.Location = new System.Drawing.Point(1158, 0);
            this.bGCourse.Name = "bGCourse";
            this.bGCourse.Size = new System.Drawing.Size(225, 213);
            this.bGCourse.TabIndex = 11;
            this.bGCourse.Text = "Gestion Course";
            this.bGCourse.UseVisualStyleBackColor = true;
            this.bGCourse.Click += new System.EventHandler(this.bGCourse_Click);
            // 
            // bGGrade
            // 
            this.bGGrade.Dock = System.Windows.Forms.DockStyle.Left;
            this.bGGrade.Location = new System.Drawing.Point(932, 0);
            this.bGGrade.Name = "bGGrade";
            this.bGGrade.Size = new System.Drawing.Size(226, 213);
            this.bGGrade.TabIndex = 10;
            this.bGGrade.Text = "Gestion Grade";
            this.bGGrade.UseVisualStyleBackColor = true;
            this.bGGrade.Click += new System.EventHandler(this.bGGrade_Click);
            // 
            // bGDSChedule
            // 
            this.bGDSChedule.Dock = System.Windows.Forms.DockStyle.Left;
            this.bGDSChedule.Location = new System.Drawing.Point(714, 0);
            this.bGDSChedule.Name = "bGDSChedule";
            this.bGDSChedule.Size = new System.Drawing.Size(218, 213);
            this.bGDSChedule.TabIndex = 9;
            this.bGDSChedule.Text = "Gestion Schedule";
            this.bGDSChedule.UseVisualStyleBackColor = true;
            this.bGDSChedule.Click += new System.EventHandler(this.bGDSChedule_Click);
            // 
            // bGClass
            // 
            this.bGClass.Dock = System.Windows.Forms.DockStyle.Left;
            this.bGClass.Location = new System.Drawing.Point(427, 0);
            this.bGClass.Name = "bGClass";
            this.bGClass.Size = new System.Drawing.Size(287, 213);
            this.bGClass.TabIndex = 8;
            this.bGClass.Text = "Gestion Class";
            this.bGClass.UseVisualStyleBackColor = true;
            this.bGClass.Click += new System.EventHandler(this.bGClass_Click);
            // 
            // bGStudent
            // 
            this.bGStudent.Dock = System.Windows.Forms.DockStyle.Left;
            this.bGStudent.Location = new System.Drawing.Point(200, 0);
            this.bGStudent.Name = "bGStudent";
            this.bGStudent.Size = new System.Drawing.Size(227, 213);
            this.bGStudent.TabIndex = 7;
            this.bGStudent.Text = "Gestion Student";
            this.bGStudent.UseVisualStyleBackColor = true;
            this.bGStudent.Click += new System.EventHandler(this.bGStudent_Click);
            // 
            // bGTeacher
            // 
            this.bGTeacher.Dock = System.Windows.Forms.DockStyle.Left;
            this.bGTeacher.Location = new System.Drawing.Point(0, 0);
            this.bGTeacher.Name = "bGTeacher";
            this.bGTeacher.Size = new System.Drawing.Size(200, 213);
            this.bGTeacher.TabIndex = 6;
            this.bGTeacher.Text = "Gestion Teacher";
            this.bGTeacher.UseVisualStyleBackColor = true;
            this.bGTeacher.Click += new System.EventHandler(this.bGTeacher_Click);
            // 
            // bConsultSchedule
            // 
            this.bConsultSchedule.Location = new System.Drawing.Point(0, 0);
            this.bConsultSchedule.Name = "bConsultSchedule";
            this.bConsultSchedule.Size = new System.Drawing.Size(109, 492);
            this.bConsultSchedule.TabIndex = 1;
            this.bConsultSchedule.Text = "Consult Schedule";
            this.bConsultSchedule.UseVisualStyleBackColor = true;
            this.bConsultSchedule.Click += new System.EventHandler(this.bConsultSchedule_Click);
            // 
            // MainScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1616, 712);
            this.Controls.Add(this.bConsultSchedule);
            this.Controls.Add(this.splitContainer1);
            this.Name = "MainScreen";
            this.Text = "Main Screen Page";
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
        private System.Windows.Forms.Button bConsultSchedule;
    }
}

