using Projet_BDEcole.Classes;
using Projet_BDEcole.Gestion;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Windows.Forms;

namespace BD_Ecole_JS
{
    public partial class GestionClass : Form
    {
        public GestionClass()
        {
            InitializeComponent();
            sConnection = ConfigurationManager.ConnectionStrings["BD_Ecole_JS.Properties.Settings.ConnectionString_Couche"].ConnectionString;
            FillDGV();
            if (dgvClass.Rows.Count > 0)
                Activer(true);
            else
                Activer(false);
        }

        DataTable dtClass;
        BindingSource bsClass;
        string sConnection;

        void FillDGV()
        {
            dtClass = new DataTable();
            dtClass.Columns.Add(new DataColumn("ClId", Type.GetType("System.Int32")));
            dtClass.Columns.Add(new DataColumn("ClName"));
            dtClass.Columns.Add(new DataColumn("ClLevel"));
            List<C_T_Class> lTmp = new G_T_Class(sConnection).Lire("N");
            foreach (var p in lTmp)
            {
                dtClass.Rows.Add(p.ClassID, p.ClName, p.ClLevel);
            }
            bsClass = new BindingSource();
            bsClass.DataSource = dtClass;
            dgvClass.DataSource = bsClass;
        }

        void Activer(bool lPrincipal)
        {
            dgvClass.Enabled = lPrincipal;
            bAdd.Enabled = bModi.Enabled = bDel.Enabled = lPrincipal;
            tbName.Enabled = tbLevel.Enabled = !lPrincipal;
            bConf.Enabled = bCan.Enabled = !lPrincipal;
        }

        void RemoveClass()
        {
            int iID = (int)dgvClass.SelectedRows[0].Cells["ClId"].Value;
            new G_T_Class(sConnection).Supprimer(iID);
            bsClass.RemoveCurrent();
        }

        void AddClass(string name, string level)
        {
            int iID = new G_T_Class(sConnection).Ajouter(name, level);
            tbId.Text = iID.ToString();
            dtClass.Rows.Add(iID, name, level);
        }

        private void bAdd_Click(object sender, EventArgs e)
        {
            tbId.Text = tbLevel.Text = tbName.Text = "";
            Activer(false);
            tbName.Focus();
        }

        private void bModi_Click(object sender, EventArgs e)
        {
            if (dgvClass.SelectedRows.Count > 0)
            {
                tbId.Text = dgvClass.SelectedRows[0].Cells["ClId"].Value.ToString();
                var pTmp = new G_T_Class(sConnection).Lire_ID(int.Parse(tbId.Text));
                tbName.Text = pTmp.ClName;
                tbLevel.Text = pTmp.ClLevel;
                Activer(false);
            }
            else
            {
                MessageBox.Show("Please select a row");
            }
        }

        private void bDel_Click(object sender, EventArgs e)
        {
            if (dgvClass.SelectedRows.Count > 0)
                if (MessageBox.Show("Confirm delete", "Are you fucking sure??", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                    RemoveClass();
        }

        private void bCan_Click(object sender, EventArgs e)
        {
            Activer(true);
        }

        private void bConf_Click(object sender, EventArgs e)
        {
            if (tbLevel.Text.Trim() == "")
                MessageBox.Show("Please put a name");
            else
            {
                if (tbId.Text == "")
                //Ajout
                {
                    AddClass(tbName.Text, tbLevel.Text);
                }
                else
                //Modification
                {
                    new G_T_Class(sConnection).Modifier(int.Parse(tbId.Text), tbName.Text, tbLevel.Text);
                    dgvClass.SelectedRows[0].Cells["ClName"].Value = tbName.Text;
                    bsClass.EndEdit();

                }
                Activer(true);
                FillDGV();
            }



        }
    }
}
