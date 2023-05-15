using Projet_BDEcole.Gestion;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BD_Ecole_JS
{
    public partial class QuickAddGrade : Form
    {
        int AssocID;
        string sConnection;

        public QuickAddGrade(int AssocID, string NAME, string CLASS)
        {
            InitializeComponent();
            this.AssocID = AssocID;
            sConnection = ConfigurationManager.ConnectionStrings["BD_Ecole_JS.Properties.Settings.ConnectionString_Couche"].ConnectionString;
            LOCKED_Class.Text = CLASS;
            LOCKED_Name.Text = NAME;
        }  

        private void bConfirmer_Click(object sender, EventArgs e)
        {

            if (tbName.Text.Trim() == "")
                MessageBox.Show("Please put a Name");
            else
            { 
                new G_T_Grade(sConnection).Ajouter(tbName.Text, int.Parse(tbScore.Text), dtpDate.Value, AssocID);
                Close();
            }
            
        }
    }
}