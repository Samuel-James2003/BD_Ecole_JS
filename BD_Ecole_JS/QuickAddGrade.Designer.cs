
namespace BD_Ecole_JS
{
    partial class QuickAddGrade
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
            this.bAnul = new System.Windows.Forms.Button();
            this.bConfirmer = new System.Windows.Forms.Button();
            this.tbName = new System.Windows.Forms.TextBox();
            this.tbScore = new System.Windows.Forms.TextBox();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.lName = new System.Windows.Forms.Label();
            this.lScore = new System.Windows.Forms.Label();
            this.lDate = new System.Windows.Forms.Label();
            this.LOCKED_Name = new System.Windows.Forms.Label();
            this.LOCKED_Class = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // bAnul
            // 
            this.bAnul.Location = new System.Drawing.Point(12, 236);
            this.bAnul.Name = "bAnul";
            this.bAnul.Size = new System.Drawing.Size(206, 82);
            this.bAnul.TabIndex = 0;
            this.bAnul.Text = "Annuler";
            this.bAnul.UseVisualStyleBackColor = true;
            // 
            // bConfirmer
            // 
            this.bConfirmer.Location = new System.Drawing.Point(587, 244);
            this.bConfirmer.Name = "bConfirmer";
            this.bConfirmer.Size = new System.Drawing.Size(201, 74);
            this.bConfirmer.TabIndex = 1;
            this.bConfirmer.Text = "Confirmer";
            this.bConfirmer.UseVisualStyleBackColor = true;
            this.bConfirmer.Click += new System.EventHandler(this.bConfirmer_Click);
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(22, 140);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(206, 26);
            this.tbName.TabIndex = 2;
            // 
            // tbScore
            // 
            this.tbScore.Location = new System.Drawing.Point(288, 140);
            this.tbScore.Name = "tbScore";
            this.tbScore.Size = new System.Drawing.Size(191, 26);
            this.tbScore.TabIndex = 3;
            // 
            // dtpDate
            // 
            this.dtpDate.Location = new System.Drawing.Point(578, 140);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(210, 26);
            this.dtpDate.TabIndex = 4;
            // 
            // lName
            // 
            this.lName.AutoSize = true;
            this.lName.Location = new System.Drawing.Point(28, 111);
            this.lName.Name = "lName";
            this.lName.Size = new System.Drawing.Size(51, 20);
            this.lName.TabIndex = 5;
            this.lName.Text = "Name";
            // 
            // lScore
            // 
            this.lScore.AutoSize = true;
            this.lScore.Location = new System.Drawing.Point(284, 117);
            this.lScore.Name = "lScore";
            this.lScore.Size = new System.Drawing.Size(51, 20);
            this.lScore.TabIndex = 6;
            this.lScore.Text = "Score";
            // 
            // lDate
            // 
            this.lDate.AutoSize = true;
            this.lDate.Location = new System.Drawing.Point(574, 117);
            this.lDate.Name = "lDate";
            this.lDate.Size = new System.Drawing.Size(44, 20);
            this.lDate.TabIndex = 7;
            this.lDate.Text = "Date";
            // 
            // LOCKED_Name
            // 
            this.LOCKED_Name.Location = new System.Drawing.Point(18, 21);
            this.LOCKED_Name.Name = "LOCKED_Name";
            this.LOCKED_Name.Size = new System.Drawing.Size(205, 70);
            this.LOCKED_Name.TabIndex = 8;
            // 
            // LOCKED_CLASS
            // 
            this.LOCKED_Class.Location = new System.Drawing.Point(583, 21);
            this.LOCKED_Class.Name = "LOCKED_CLASS";
            this.LOCKED_Class.Size = new System.Drawing.Size(205, 70);
            this.LOCKED_Class.TabIndex = 9;
            // 
            // QuickAddGrade
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 330);
            this.Controls.Add(this.LOCKED_Class);
            this.Controls.Add(this.LOCKED_Name);
            this.Controls.Add(this.lDate);
            this.Controls.Add(this.lScore);
            this.Controls.Add(this.lName);
            this.Controls.Add(this.dtpDate);
            this.Controls.Add(this.tbScore);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.bConfirmer);
            this.Controls.Add(this.bAnul);
            this.Name = "QuickAddGrade";
            this.Text = "QuickAddGrade";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bAnul;
        private System.Windows.Forms.Button bConfirmer;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.TextBox tbScore;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.Label lName;
        private System.Windows.Forms.Label lScore;
        private System.Windows.Forms.Label lDate;
        private System.Windows.Forms.Label LOCKED_Name;
        private System.Windows.Forms.Label LOCKED_Class;
    }
}