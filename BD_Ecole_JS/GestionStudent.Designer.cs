
namespace BD_Ecole_JS
{
    partial class GestionStudent
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
            this.scScreen = new System.Windows.Forms.SplitContainer();
            this.dgvStudent = new System.Windows.Forms.DataGridView();
            this.sButtonText = new System.Windows.Forms.SplitContainer();
            this.bDel = new System.Windows.Forms.Button();
            this.bModi = new System.Windows.Forms.Button();
            this.bAdd = new System.Windows.Forms.Button();
            this.scTextExits = new System.Windows.Forms.SplitContainer();
            this.label7 = new System.Windows.Forms.Label();
            this.tbSection = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbYear = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.dtpDob = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbSurname = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.tbId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.bCan = new System.Windows.Forms.Button();
            this.bConf = new System.Windows.Forms.Button();
            this.SId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SDob = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SYear = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SSection = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.scScreen)).BeginInit();
            this.scScreen.Panel1.SuspendLayout();
            this.scScreen.Panel2.SuspendLayout();
            this.scScreen.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sButtonText)).BeginInit();
            this.sButtonText.Panel1.SuspendLayout();
            this.sButtonText.Panel2.SuspendLayout();
            this.sButtonText.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scTextExits)).BeginInit();
            this.scTextExits.Panel1.SuspendLayout();
            this.scTextExits.Panel2.SuspendLayout();
            this.scTextExits.SuspendLayout();
            this.SuspendLayout();
            // 
            // scScreen
            // 
            this.scScreen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scScreen.Location = new System.Drawing.Point(0, 0);
            this.scScreen.Name = "scScreen";
            this.scScreen.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // scScreen.Panel1
            // 
            this.scScreen.Panel1.Controls.Add(this.dgvStudent);
            // 
            // scScreen.Panel2
            // 
            this.scScreen.Panel2.Controls.Add(this.sButtonText);
            this.scScreen.Size = new System.Drawing.Size(1039, 718);
            this.scScreen.SplitterDistance = 291;
            this.scScreen.TabIndex = 1;
            // 
            // dgvStudent
            // 
            this.dgvStudent.AllowUserToAddRows = false;
            this.dgvStudent.AllowUserToDeleteRows = false;
            this.dgvStudent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStudent.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SId,
            this.SName,
            this.SDob,
            this.SEmail,
            this.SYear,
            this.SSection});
            this.dgvStudent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvStudent.Location = new System.Drawing.Point(0, 0);
            this.dgvStudent.MultiSelect = false;
            this.dgvStudent.Name = "dgvStudent";
            this.dgvStudent.ReadOnly = true;
            this.dgvStudent.RowHeadersVisible = false;
            this.dgvStudent.RowHeadersWidth = 100;
            this.dgvStudent.RowTemplate.Height = 28;
            this.dgvStudent.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvStudent.Size = new System.Drawing.Size(1039, 291);
            this.dgvStudent.TabIndex = 0;
            // 
            // sButtonText
            // 
            this.sButtonText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sButtonText.Location = new System.Drawing.Point(0, 0);
            this.sButtonText.Name = "sButtonText";
            this.sButtonText.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // sButtonText.Panel1
            // 
            this.sButtonText.Panel1.Controls.Add(this.bDel);
            this.sButtonText.Panel1.Controls.Add(this.bModi);
            this.sButtonText.Panel1.Controls.Add(this.bAdd);
            // 
            // sButtonText.Panel2
            // 
            this.sButtonText.Panel2.Controls.Add(this.scTextExits);
            this.sButtonText.Size = new System.Drawing.Size(1039, 423);
            this.sButtonText.SplitterDistance = 75;
            this.sButtonText.TabIndex = 19;
            // 
            // bDel
            // 
            this.bDel.Dock = System.Windows.Forms.DockStyle.Left;
            this.bDel.Location = new System.Drawing.Point(684, 0);
            this.bDel.Name = "bDel";
            this.bDel.Size = new System.Drawing.Size(342, 75);
            this.bDel.TabIndex = 4;
            this.bDel.Text = "Delete";
            this.bDel.UseVisualStyleBackColor = true;
            this.bDel.Click += new System.EventHandler(this.bDel_Click);
            // 
            // bModi
            // 
            this.bModi.Dock = System.Windows.Forms.DockStyle.Left;
            this.bModi.Location = new System.Drawing.Point(342, 0);
            this.bModi.Name = "bModi";
            this.bModi.Size = new System.Drawing.Size(342, 75);
            this.bModi.TabIndex = 3;
            this.bModi.Text = "Modify";
            this.bModi.UseVisualStyleBackColor = true;
            this.bModi.Click += new System.EventHandler(this.bModi_Click);
            // 
            // bAdd
            // 
            this.bAdd.Dock = System.Windows.Forms.DockStyle.Left;
            this.bAdd.Location = new System.Drawing.Point(0, 0);
            this.bAdd.Name = "bAdd";
            this.bAdd.Size = new System.Drawing.Size(342, 75);
            this.bAdd.TabIndex = 2;
            this.bAdd.Text = "Add";
            this.bAdd.UseVisualStyleBackColor = true;
            this.bAdd.Click += new System.EventHandler(this.bAdd_Click);
            // 
            // scTextExits
            // 
            this.scTextExits.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scTextExits.Location = new System.Drawing.Point(0, 0);
            this.scTextExits.Name = "scTextExits";
            this.scTextExits.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // scTextExits.Panel1
            // 
            this.scTextExits.Panel1.Controls.Add(this.label7);
            this.scTextExits.Panel1.Controls.Add(this.tbSection);
            this.scTextExits.Panel1.Controls.Add(this.label6);
            this.scTextExits.Panel1.Controls.Add(this.tbYear);
            this.scTextExits.Panel1.Controls.Add(this.label5);
            this.scTextExits.Panel1.Controls.Add(this.tbEmail);
            this.scTextExits.Panel1.Controls.Add(this.dtpDob);
            this.scTextExits.Panel1.Controls.Add(this.label4);
            this.scTextExits.Panel1.Controls.Add(this.label3);
            this.scTextExits.Panel1.Controls.Add(this.tbSurname);
            this.scTextExits.Panel1.Controls.Add(this.label2);
            this.scTextExits.Panel1.Controls.Add(this.tbName);
            this.scTextExits.Panel1.Controls.Add(this.tbId);
            this.scTextExits.Panel1.Controls.Add(this.label1);
            // 
            // scTextExits.Panel2
            // 
            this.scTextExits.Panel2.Controls.Add(this.bCan);
            this.scTextExits.Panel2.Controls.Add(this.bConf);
            this.scTextExits.Size = new System.Drawing.Size(1039, 344);
            this.scTextExits.SplitterDistance = 273;
            this.scTextExits.TabIndex = 37;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(82, 172);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 20);
            this.label7.TabIndex = 48;
            this.label7.Text = "Section";
            // 
            // tbSection
            // 
            this.tbSection.Location = new System.Drawing.Point(86, 195);
            this.tbSection.Name = "tbSection";
            this.tbSection.Size = new System.Drawing.Size(264, 26);
            this.tbSection.TabIndex = 47;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(656, 49);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 20);
            this.label6.TabIndex = 46;
            this.label6.Text = "Year";
            // 
            // tbYear
            // 
            this.tbYear.Location = new System.Drawing.Point(660, 72);
            this.tbYear.Name = "tbYear";
            this.tbYear.Size = new System.Drawing.Size(264, 26);
            this.tbYear.TabIndex = 45;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(656, 114);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 20);
            this.label5.TabIndex = 44;
            this.label5.Text = "Email";
            // 
            // tbEmail
            // 
            this.tbEmail.Location = new System.Drawing.Point(660, 137);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(264, 26);
            this.tbEmail.TabIndex = 43;
            // 
            // dtpDob
            // 
            this.dtpDob.Location = new System.Drawing.Point(374, 70);
            this.dtpDob.Name = "dtpDob";
            this.dtpDob.Size = new System.Drawing.Size(263, 26);
            this.dtpDob.TabIndex = 39;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(370, 37);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 20);
            this.label4.TabIndex = 42;
            this.label4.Text = "Date of birth";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(370, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 20);
            this.label3.TabIndex = 41;
            this.label3.Text = "Surname";
            // 
            // tbSurname
            // 
            this.tbSurname.Location = new System.Drawing.Point(374, 137);
            this.tbSurname.Name = "tbSurname";
            this.tbSurname.Size = new System.Drawing.Size(264, 26);
            this.tbSurname.TabIndex = 37;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(82, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 20);
            this.label2.TabIndex = 40;
            this.label2.Text = "Name";
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(86, 137);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(257, 26);
            this.tbName.TabIndex = 35;
            // 
            // tbId
            // 
            this.tbId.Location = new System.Drawing.Point(86, 70);
            this.tbId.Name = "tbId";
            this.tbId.ReadOnly = true;
            this.tbId.Size = new System.Drawing.Size(257, 26);
            this.tbId.TabIndex = 38;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(82, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 20);
            this.label1.TabIndex = 36;
            this.label1.Text = "ID";
            // 
            // bCan
            // 
            this.bCan.Dock = System.Windows.Forms.DockStyle.Right;
            this.bCan.Location = new System.Drawing.Point(-1, 0);
            this.bCan.Name = "bCan";
            this.bCan.Size = new System.Drawing.Size(520, 67);
            this.bCan.TabIndex = 35;
            this.bCan.Text = "Cancel";
            this.bCan.UseVisualStyleBackColor = true;
            this.bCan.Click += new System.EventHandler(this.bCan_Click);
            // 
            // bConf
            // 
            this.bConf.Dock = System.Windows.Forms.DockStyle.Right;
            this.bConf.Location = new System.Drawing.Point(519, 0);
            this.bConf.Name = "bConf";
            this.bConf.Size = new System.Drawing.Size(520, 67);
            this.bConf.TabIndex = 36;
            this.bConf.Text = "Confirm";
            this.bConf.UseVisualStyleBackColor = true;
            this.bConf.Click += new System.EventHandler(this.bConf_Click);
            // 
            // SId
            // 
            this.SId.DataPropertyName = "SId";
            this.SId.HeaderText = "StudentID";
            this.SId.MinimumWidth = 8;
            this.SId.Name = "SId";
            this.SId.ReadOnly = true;
            this.SId.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.SId.Visible = false;
            this.SId.Width = 119;
            // 
            // SName
            // 
            this.SName.DataPropertyName = "SName";
            this.SName.HeaderText = "Student Name ";
            this.SName.MinimumWidth = 8;
            this.SName.Name = "SName";
            this.SName.ReadOnly = true;
            this.SName.Width = 150;
            // 
            // SDob
            // 
            this.SDob.DataPropertyName = "SDob";
            this.SDob.HeaderText = "Date of Birth";
            this.SDob.MinimumWidth = 8;
            this.SDob.Name = "SDob";
            this.SDob.ReadOnly = true;
            this.SDob.Width = 120;
            // 
            // SEmail
            // 
            this.SEmail.DataPropertyName = "SEmail";
            this.SEmail.HeaderText = "Email";
            this.SEmail.MinimumWidth = 8;
            this.SEmail.Name = "SEmail";
            this.SEmail.ReadOnly = true;
            this.SEmail.Width = 150;
            // 
            // SYear
            // 
            this.SYear.DataPropertyName = "SYear";
            this.SYear.HeaderText = "Year";
            this.SYear.MinimumWidth = 8;
            this.SYear.Name = "SYear";
            this.SYear.ReadOnly = true;
            this.SYear.Width = 40;
            // 
            // SSection
            // 
            this.SSection.DataPropertyName = "SSection";
            this.SSection.HeaderText = "Section";
            this.SSection.MinimumWidth = 8;
            this.SSection.Name = "SSection";
            this.SSection.ReadOnly = true;
            // 
            // GestionStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1039, 718);
            this.Controls.Add(this.scScreen);
            this.Name = "GestionStudent";
            this.Text = "GestionStudent";
            this.scScreen.Panel1.ResumeLayout(false);
            this.scScreen.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.scScreen)).EndInit();
            this.scScreen.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudent)).EndInit();
            this.sButtonText.Panel1.ResumeLayout(false);
            this.sButtonText.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.sButtonText)).EndInit();
            this.sButtonText.ResumeLayout(false);
            this.scTextExits.Panel1.ResumeLayout(false);
            this.scTextExits.Panel1.PerformLayout();
            this.scTextExits.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.scTextExits)).EndInit();
            this.scTextExits.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer scScreen;
        private System.Windows.Forms.DataGridView dgvStudent;
        private System.Windows.Forms.SplitContainer sButtonText;
        private System.Windows.Forms.Button bDel;
        private System.Windows.Forms.Button bModi;
        private System.Windows.Forms.Button bAdd;
        private System.Windows.Forms.SplitContainer scTextExits;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbSection;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbYear;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.DateTimePicker dtpDob;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbSurname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.TextBox tbId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bCan;
        private System.Windows.Forms.Button bConf;
        private System.Windows.Forms.DataGridViewTextBoxColumn SId;
        private System.Windows.Forms.DataGridViewTextBoxColumn SName;
        private System.Windows.Forms.DataGridViewTextBoxColumn SDob;
        private System.Windows.Forms.DataGridViewTextBoxColumn SEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn SYear;
        private System.Windows.Forms.DataGridViewTextBoxColumn SSection;
    }
}