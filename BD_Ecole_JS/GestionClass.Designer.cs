
namespace BD_Ecole_JS
{
    partial class GestionClass
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
            this.dgvClass = new System.Windows.Forms.DataGridView();
            this.ClId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClLevel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sButtonText = new System.Windows.Forms.SplitContainer();
            this.bDel = new System.Windows.Forms.Button();
            this.bModi = new System.Windows.Forms.Button();
            this.bAdd = new System.Windows.Forms.Button();
            this.scTextExits = new System.Windows.Forms.SplitContainer();
            this.label3 = new System.Windows.Forms.Label();
            this.tbLevel = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.tbId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.bCan = new System.Windows.Forms.Button();
            this.bConf = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.scScreen)).BeginInit();
            this.scScreen.Panel1.SuspendLayout();
            this.scScreen.Panel2.SuspendLayout();
            this.scScreen.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClass)).BeginInit();
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
            this.scScreen.Panel1.Controls.Add(this.dgvClass);
            // 
            // scScreen.Panel2
            // 
            this.scScreen.Panel2.Controls.Add(this.sButtonText);
            this.scScreen.Size = new System.Drawing.Size(1004, 696);
            this.scScreen.SplitterDistance = 282;
            this.scScreen.TabIndex = 1;
            // 
            // dgvClass
            // 
            this.dgvClass.AllowUserToAddRows = false;
            this.dgvClass.AllowUserToDeleteRows = false;
            this.dgvClass.ColumnHeadersHeight = 34;
            this.dgvClass.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ClId,
            this.ClName,
            this.ClLevel});
            this.dgvClass.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvClass.Location = new System.Drawing.Point(0, 0);
            this.dgvClass.MultiSelect = false;
            this.dgvClass.Name = "dgvClass";
            this.dgvClass.ReadOnly = true;
            this.dgvClass.RowHeadersVisible = false;
            this.dgvClass.RowHeadersWidth = 62;
            this.dgvClass.RowTemplate.Height = 28;
            this.dgvClass.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvClass.Size = new System.Drawing.Size(1004, 282);
            this.dgvClass.TabIndex = 0;
            // 
            // ClId
            // 
            this.ClId.DataPropertyName = "ClId";
            this.ClId.HeaderText = "ClassID";
            this.ClId.MinimumWidth = 8;
            this.ClId.Name = "ClId";
            this.ClId.ReadOnly = true;
            this.ClId.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ClId.Visible = false;
            this.ClId.Width = 120;
            // 
            // ClName
            // 
            this.ClName.DataPropertyName = "ClName";
            this.ClName.HeaderText = "Class Name ";
            this.ClName.MinimumWidth = 8;
            this.ClName.Name = "ClName";
            this.ClName.ReadOnly = true;
            this.ClName.Width = 153;
            // 
            // ClLevel
            // 
            this.ClLevel.DataPropertyName = "ClLevel";
            this.ClLevel.HeaderText = "Level";
            this.ClLevel.MinimumWidth = 8;
            this.ClLevel.Name = "ClLevel";
            this.ClLevel.ReadOnly = true;
            this.ClLevel.Width = 84;
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
            this.sButtonText.Size = new System.Drawing.Size(1004, 410);
            this.sButtonText.SplitterDistance = 73;
            this.sButtonText.TabIndex = 19;
            // 
            // bDel
            // 
            this.bDel.Dock = System.Windows.Forms.DockStyle.Left;
            this.bDel.Location = new System.Drawing.Point(670, 0);
            this.bDel.Name = "bDel";
            this.bDel.Size = new System.Drawing.Size(335, 73);
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
            this.bModi.Size = new System.Drawing.Size(335, 73);
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
            this.bAdd.Size = new System.Drawing.Size(335, 73);
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
            this.scTextExits.Panel1.Controls.Add(this.label3);
            this.scTextExits.Panel1.Controls.Add(this.tbLevel);
            this.scTextExits.Panel1.Controls.Add(this.label2);
            this.scTextExits.Panel1.Controls.Add(this.tbName);
            this.scTextExits.Panel1.Controls.Add(this.tbId);
            this.scTextExits.Panel1.Controls.Add(this.label1);
            // 
            // scTextExits.Panel2
            // 
            this.scTextExits.Panel2.Controls.Add(this.bCan);
            this.scTextExits.Panel2.Controls.Add(this.bConf);
            this.scTextExits.Size = new System.Drawing.Size(1004, 333);
            this.scTextExits.SplitterDistance = 264;
            this.scTextExits.TabIndex = 37;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(370, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 20);
            this.label3.TabIndex = 41;
            this.label3.Text = "Level";
            // 
            // tbLevel
            // 
            this.tbLevel.Location = new System.Drawing.Point(374, 137);
            this.tbLevel.Name = "tbLevel";
            this.tbLevel.Size = new System.Drawing.Size(264, 26);
            this.tbLevel.TabIndex = 37;
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
            this.bCan.Location = new System.Drawing.Point(2, 0);
            this.bCan.Name = "bCan";
            this.bCan.Size = new System.Drawing.Size(501, 65);
            this.bCan.TabIndex = 35;
            this.bCan.Text = "Cancel";
            this.bCan.UseVisualStyleBackColor = true;
            this.bCan.Click += new System.EventHandler(this.bCan_Click);
            // 
            // bConf
            // 
            this.bConf.Dock = System.Windows.Forms.DockStyle.Right;
            this.bConf.Location = new System.Drawing.Point(503, 0);
            this.bConf.Name = "bConf";
            this.bConf.Size = new System.Drawing.Size(501, 65);
            this.bConf.TabIndex = 36;
            this.bConf.Text = "Confirm";
            this.bConf.UseVisualStyleBackColor = true;
            this.bConf.Click += new System.EventHandler(this.bConf_Click);
            // 
            // GestionClass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1004, 696);
            this.Controls.Add(this.scScreen);
            this.Name = "GestionClass";
            this.Text = "GestionClass";
            this.scScreen.Panel1.ResumeLayout(false);
            this.scScreen.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.scScreen)).EndInit();
            this.scScreen.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvClass)).EndInit();
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
        private System.Windows.Forms.DataGridView dgvClass;
        private System.Windows.Forms.SplitContainer sButtonText;
        private System.Windows.Forms.Button bDel;
        private System.Windows.Forms.Button bModi;
        private System.Windows.Forms.Button bAdd;
        private System.Windows.Forms.SplitContainer scTextExits;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbLevel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.TextBox tbId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bCan;
        private System.Windows.Forms.Button bConf;
        private System.Windows.Forms.DataGridViewTextBoxColumn CId;
        private System.Windows.Forms.DataGridViewTextBoxColumn CName;
        private System.Windows.Forms.DataGridViewTextBoxColumn CLevel;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClLevel;
    }
}