
namespace BD_Ecole_JS
{
    partial class CreateSchedule
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
            this.wbSchedule = new System.Windows.Forms.WebBrowser();
            this.SuspendLayout();
            // 
            // wbSchedule
            // 
            this.wbSchedule.Dock = System.Windows.Forms.DockStyle.Fill;
            this.wbSchedule.Location = new System.Drawing.Point(0, 0);
            this.wbSchedule.MinimumSize = new System.Drawing.Size(20, 20);
            this.wbSchedule.Name = "wbSchedule";
            this.wbSchedule.Size = new System.Drawing.Size(990, 663);
            this.wbSchedule.TabIndex = 0;
            // 
            // CreateSchedule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(990, 663);
            this.Controls.Add(this.wbSchedule);
            this.Name = "CreateSchedule";
            this.Text = "CreateSchedule";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.WebBrowser wbSchedule;
    }
}