
namespace BD_Ecole_JS
{
    partial class GestionCourse
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
            this.dgvCourse = new System.Windows.Forms.DataGridView();
            this.sButtonText = new System.Windows.Forms.SplitContainer();
            this.bDel = new System.Windows.Forms.Button();
            this.bModi = new System.Windows.Forms.Button();
            this.bAdd = new System.Windows.Forms.Button();
            this.scTextExits = new System.Windows.Forms.SplitContainer();
            this.cbTId = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.tbId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.bCan = new System.Windows.Forms.Button();
            this.bConf = new System.Windows.Forms.Button();
            this.CoId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CoName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.scScreen)).BeginInit();
            this.scScreen.Panel1.SuspendLayout();
            this.scScreen.Panel2.SuspendLayout();
            this.scScreen.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCourse)).BeginInit();
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
            this.scScreen.Panel1.Controls.Add(this.dgvCourse);
            // 
            // scScreen.Panel2
            // 
            this.scScreen.Panel2.Controls.Add(this.sButtonText);
            this.scScreen.Size = new System.Drawing.Size(1008, 818);
            this.scScreen.SplitterDistance = 331;
            this.scScreen.TabIndex = 2;
            // 
            // dgvCourse
            // 
            this.dgvCourse.AllowUserToAddRows = false;
            this.dgvCourse.AllowUserToDeleteRows = false;
            this.dgvCourse.ColumnHeadersHeight = 34;
            this.dgvCourse.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CoId,
            this.CoName,
            this.TId});
            this.dgvCourse.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCourse.Location = new System.Drawing.Point(0, 0);
            this.dgvCourse.MultiSelect = false;
            this.dgvCourse.Name = "dgvCourse";
            this.dgvCourse.ReadOnly = true;
            this.dgvCourse.RowHeadersVisible = false;
            this.dgvCourse.RowHeadersWidth = 62;
            this.dgvCourse.RowTemplate.Height = 28;
            this.dgvCourse.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCourse.Size = new System.Drawing.Size(1008, 331);
            this.dgvCourse.TabIndex = 0;
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
            this.sButtonText.Size = new System.Drawing.Size(1008, 483);
            this.sButtonText.SplitterDistance = 85;
            this.sButtonText.TabIndex = 19;
            // 
            // bDel
            // 
            this.bDel.Dock = System.Windows.Forms.DockStyle.Left;
            this.bDel.Location = new System.Drawing.Point(670, 0);
            this.bDel.Name = "bDel";
            this.bDel.Size = new System.Drawing.Size(335, 85);
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
            this.bModi.Size = new System.Drawing.Size(335, 85);
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
            this.bAdd.Size = new System.Drawing.Size(335, 85);
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
            this.scTextExits.Panel1.Controls.Add(this.cbTId);
            this.scTextExits.Panel1.Controls.Add(this.label3);
            this.scTextExits.Panel1.Controls.Add(this.label2);
            this.scTextExits.Panel1.Controls.Add(this.tbName);
            this.scTextExits.Panel1.Controls.Add(this.tbId);
            this.scTextExits.Panel1.Controls.Add(this.label1);
            // 
            // scTextExits.Panel2
            // 
            this.scTextExits.Panel2.Controls.Add(this.bCan);
            this.scTextExits.Panel2.Controls.Add(this.bConf);
            this.scTextExits.Size = new System.Drawing.Size(1008, 394);
            this.scTextExits.SplitterDistance = 312;
            this.scTextExits.TabIndex = 37;
            // 
            // cbTId
            // 
            this.cbTId.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbTId.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbTId.FormattingEnabled = true;
            this.cbTId.Location = new System.Drawing.Point(364, 137);
            this.cbTId.Name = "cbTId";
            this.cbTId.Size = new System.Drawing.Size(257, 28);
            this.cbTId.TabIndex = 42;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(370, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(165, 20);
            this.label3.TabIndex = 41;
            this.label3.Text = "Teacher ID and Name";
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
            this.bCan.Location = new System.Drawing.Point(6, 0);
            this.bCan.Name = "bCan";
            this.bCan.Size = new System.Drawing.Size(501, 78);
            this.bCan.TabIndex = 35;
            this.bCan.Text = "Cancel";
            this.bCan.UseVisualStyleBackColor = true;
            this.bCan.Click += new System.EventHandler(this.bCan_Click);
            // 
            // bConf
            // 
            this.bConf.Dock = System.Windows.Forms.DockStyle.Right;
            this.bConf.Location = new System.Drawing.Point(507, 0);
            this.bConf.Name = "bConf";
            this.bConf.Size = new System.Drawing.Size(501, 78);
            this.bConf.TabIndex = 36;
            this.bConf.Text = "Confirm";
            this.bConf.UseVisualStyleBackColor = true;
            this.bConf.Click += new System.EventHandler(this.bConf_Click);
            // 
            // CoId
            // 
            this.CoId.DataPropertyName = "CoId";
            this.CoId.HeaderText = "CourseID";
            this.CoId.MinimumWidth = 8;
            this.CoId.Name = "CoId";
            this.CoId.ReadOnly = true;
            this.CoId.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.CoId.Visible = false;
            this.CoId.Width = 120;
            // 
            // CoName
            // 
            this.CoName.DataPropertyName = "CoName";
            this.CoName.HeaderText = "Course Name ";
            this.CoName.MinimumWidth = 8;
            this.CoName.Name = "CoName";
            this.CoName.ReadOnly = true;
            this.CoName.Width = 153;
            // 
            // TId
            // 
            this.TId.DataPropertyName = "TId";
            this.TId.HeaderText = "Teacher ID";
            this.TId.MinimumWidth = 8;
            this.TId.Name = "TId";
            this.TId.ReadOnly = true;
            this.TId.Width = 84;
            // 
            // GestionCourse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 818);
            this.Controls.Add(this.scScreen);
            this.Name = "GestionCourse";
            this.Text = "GestionCourse";
            this.Load += new System.EventHandler(this.GestionCourse_Load);
            this.scScreen.Panel1.ResumeLayout(false);
            this.scScreen.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.scScreen)).EndInit();
            this.scScreen.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCourse)).EndInit();
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
        private System.Windows.Forms.DataGridView dgvCourse;
        private System.Windows.Forms.SplitContainer sButtonText;
        private System.Windows.Forms.Button bDel;
        private System.Windows.Forms.Button bModi;
        private System.Windows.Forms.Button bAdd;
        private System.Windows.Forms.SplitContainer scTextExits;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.TextBox tbId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bCan;
        private System.Windows.Forms.Button bConf;
        private System.Windows.Forms.ComboBox cbTId;
        private System.Windows.Forms.DataGridViewTextBoxColumn CoId;
        private System.Windows.Forms.DataGridViewTextBoxColumn CoName;
        private System.Windows.Forms.DataGridViewTextBoxColumn TId;
    }
}