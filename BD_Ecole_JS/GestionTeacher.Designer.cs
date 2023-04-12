
namespace BD_Ecole_JS
{
    partial class GestionTeacher
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
            this.sButtonText = new System.Windows.Forms.SplitContainer();
            this.bDel = new System.Windows.Forms.Button();
            this.bModi = new System.Windows.Forms.Button();
            this.bAdd = new System.Windows.Forms.Button();
            this.scTextExits = new System.Windows.Forms.SplitContainer();
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
            this.dgvTeacher = new System.Windows.Forms.DataGridView();
            this.TId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TDob = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.scScreen = new System.Windows.Forms.SplitContainer();
            ((System.ComponentModel.ISupportInitialize)(this.sButtonText)).BeginInit();
            this.sButtonText.Panel1.SuspendLayout();
            this.sButtonText.Panel2.SuspendLayout();
            this.sButtonText.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scTextExits)).BeginInit();
            this.scTextExits.Panel1.SuspendLayout();
            this.scTextExits.Panel2.SuspendLayout();
            this.scTextExits.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTeacher)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.scScreen)).BeginInit();
            this.scScreen.Panel1.SuspendLayout();
            this.scScreen.Panel2.SuspendLayout();
            this.scScreen.SuspendLayout();
            this.SuspendLayout();
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
            this.sButtonText.Size = new System.Drawing.Size(1006, 462);
            this.sButtonText.SplitterDistance = 83;
            this.sButtonText.TabIndex = 19;
            // 
            // bDel
            // 
            this.bDel.Dock = System.Windows.Forms.DockStyle.Left;
            this.bDel.Location = new System.Drawing.Point(670, 0);
            this.bDel.Name = "bDel";
            this.bDel.Size = new System.Drawing.Size(335, 83);
            this.bDel.TabIndex = 4;
            this.bDel.Text = "Delete";
            this.bDel.UseVisualStyleBackColor = true;
            this.bDel.Click += new System.EventHandler(this.bDel_Click);
            // 
            // bModi
            // 
            this.bModi.Dock = System.Windows.Forms.DockStyle.Left;
            this.bModi.Location = new System.Drawing.Point(335, 0);
            this.bModi.Name = "bModi";
            this.bModi.Size = new System.Drawing.Size(335, 83);
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
            this.bAdd.Size = new System.Drawing.Size(335, 83);
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
            this.scTextExits.Size = new System.Drawing.Size(1006, 375);
            this.scTextExits.SplitterDistance = 298;
            this.scTextExits.TabIndex = 37;
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
            this.bCan.Location = new System.Drawing.Point(4, 0);
            this.bCan.Name = "bCan";
            this.bCan.Size = new System.Drawing.Size(501, 73);
            this.bCan.TabIndex = 35;
            this.bCan.Text = "Cancel";
            this.bCan.UseVisualStyleBackColor = true;
            this.bCan.Click += new System.EventHandler(this.bCan_Click);
            // 
            // bConf
            // 
            this.bConf.Dock = System.Windows.Forms.DockStyle.Right;
            this.bConf.Location = new System.Drawing.Point(505, 0);
            this.bConf.Name = "bConf";
            this.bConf.Size = new System.Drawing.Size(501, 73);
            this.bConf.TabIndex = 36;
            this.bConf.Text = "Confirm";
            this.bConf.UseVisualStyleBackColor = true;
            this.bConf.Click += new System.EventHandler(this.bConf_Click);
            // 
            // dgvTeacher
            // 
            this.dgvTeacher.AllowUserToAddRows = false;
            this.dgvTeacher.AllowUserToDeleteRows = false;
            this.dgvTeacher.ColumnHeadersHeight = 34;
            this.dgvTeacher.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TId,
            this.TName,
            this.TDob,
            this.TEmail});
            this.dgvTeacher.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvTeacher.Location = new System.Drawing.Point(0, 0);
            this.dgvTeacher.MultiSelect = false;
            this.dgvTeacher.Name = "dgvTeacher";
            this.dgvTeacher.ReadOnly = true;
            this.dgvTeacher.RowHeadersVisible = false;
            this.dgvTeacher.RowHeadersWidth = 62;
            this.dgvTeacher.RowTemplate.Height = 28;
            this.dgvTeacher.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTeacher.Size = new System.Drawing.Size(1006, 319);
            this.dgvTeacher.TabIndex = 0;
            // 
            // TId
            // 
            this.TId.DataPropertyName = "TId";
            this.TId.HeaderText = "TeacherID";
            this.TId.MinimumWidth = 8;
            this.TId.Name = "TId";
            this.TId.ReadOnly = true;
            this.TId.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.TId.Visible = false;
            this.TId.Width = 120;
            // 
            // TName
            // 
            this.TName.DataPropertyName = "TName";
            this.TName.HeaderText = "Teacher Name ";
            this.TName.MinimumWidth = 8;
            this.TName.Name = "TName";
            this.TName.ReadOnly = true;
            this.TName.Width = 153;
            // 
            // TDob
            // 
            this.TDob.DataPropertyName = "TDob";
            this.TDob.HeaderText = "Date of Birth";
            this.TDob.MinimumWidth = 8;
            this.TDob.Name = "TDob";
            this.TDob.ReadOnly = true;
            this.TDob.Width = 135;
            // 
            // TEmail
            // 
            this.TEmail.DataPropertyName = "TEmail";
            this.TEmail.HeaderText = "Email";
            this.TEmail.MinimumWidth = 8;
            this.TEmail.Name = "TEmail";
            this.TEmail.ReadOnly = true;
            this.TEmail.Width = 84;
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
            this.scScreen.Panel1.Controls.Add(this.dgvTeacher);
            // 
            // scScreen.Panel2
            // 
            this.scScreen.Panel2.Controls.Add(this.sButtonText);
            this.scScreen.Size = new System.Drawing.Size(1006, 785);
            this.scScreen.SplitterDistance = 319;
            this.scScreen.TabIndex = 0;
            // 
            // GestionTeacher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1006, 785);
            this.Controls.Add(this.scScreen);
            this.Name = "GestionTeacher";
            this.Text = "GestionBD";
            this.sButtonText.Panel1.ResumeLayout(false);
            this.sButtonText.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.sButtonText)).EndInit();
            this.sButtonText.ResumeLayout(false);
            this.scTextExits.Panel1.ResumeLayout(false);
            this.scTextExits.Panel1.PerformLayout();
            this.scTextExits.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.scTextExits)).EndInit();
            this.scTextExits.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTeacher)).EndInit();
            this.scScreen.Panel1.ResumeLayout(false);
            this.scScreen.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.scScreen)).EndInit();
            this.scScreen.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer sButtonText;
        private System.Windows.Forms.Button bDel;
        private System.Windows.Forms.Button bModi;
        private System.Windows.Forms.Button bAdd;
        private System.Windows.Forms.SplitContainer scTextExits;
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
        private System.Windows.Forms.DataGridView dgvTeacher;
        private System.Windows.Forms.DataGridViewTextBoxColumn TId;
        private System.Windows.Forms.DataGridViewTextBoxColumn TName;
        private System.Windows.Forms.DataGridViewTextBoxColumn TDob;
        private System.Windows.Forms.DataGridViewTextBoxColumn TEmail;
        private System.Windows.Forms.SplitContainer scScreen;
    }
}