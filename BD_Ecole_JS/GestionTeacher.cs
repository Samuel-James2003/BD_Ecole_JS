using System;
using System.Collections.Generic;
using System.Data;
using Projet_BDEcole.Gestion;
using System.Windows.Forms;
using Projet_BDEcole.Classes;
using System.Configuration;

namespace BD_Ecole_JS
{
    public partial class GestionTeacher : Form
    {
        DataTable dtTeacher;
        BindingSource bsTeacher;
        string sConnection;

        void FillDGV()
        {
            dtTeacher = new DataTable();
            dtTeacher.Columns.Add(new DataColumn("TId", Type.GetType("System.Int32")));
            dtTeacher.Columns.Add(new DataColumn("TName"));
            dtTeacher.Columns.Add(new DataColumn("TDob"));
            dtTeacher.Columns.Add(new DataColumn("TEmail"));
            dtTeacher.Columns.Add(new DataColumn("TDiploma"));
            List<C_T_Teacher> lTmp = new G_T_Teacher(sConnection).Lire("N");
            foreach (var p in lTmp)
            {
                dtTeacher.Rows.Add(p.TeacherID, p.TName + " " + p.TSurname, p.TDoB.ToShortDateString(), p.TEmail, p.TDiploma);
            }
            bsTeacher = new BindingSource();
            bsTeacher.DataSource = dtTeacher;
            dgvTeacher.DataSource = bsTeacher;
        }

        public GestionTeacher()
        {
            InitializeComponent();
            sConnection = ConfigurationManager.ConnectionStrings["BD_Ecole_JS.Properties.Settings.ConnectionString_Couche"].ConnectionString;
            FillDGV();
            if (dgvTeacher.Rows.Count > 0)
                Activer(true);
            else
                Activer(false);
        }

        public GestionTeacher(string Param)
        {
            InitializeComponent();
            sConnection = ConfigurationManager.ConnectionStrings["BD_Ecole_JS.Properties.Settings.ConnectionString_Couche"].ConnectionString;

            if (Param is string)
            {
                //...
            }

        }

        void Activer(bool lPrincipal)
        {
            dgvTeacher.Enabled = lPrincipal;
            bAdd.Enabled = bModi.Enabled = bDel.Enabled = lPrincipal;
            tbName.Enabled = tbSurname.Enabled = dtpDob.Enabled = tbEmail.Enabled = tbDiploma.Enabled = !lPrincipal;
            bConf.Enabled = bCan.Enabled = !lPrincipal;
        }

        void RemoveTeacher()
        {
            int iID = (int)dgvTeacher.SelectedRows[0].Cells["TId"].Value;
            new G_T_Teacher(sConnection).Supprimer(iID);
            bsTeacher.RemoveCurrent();
        }

        void AddTeacher(string name, string surname, DateTime DoB, string email, string diploma)
        {
            int iID = new G_T_Teacher(sConnection).Ajouter(name, surname, DoB, email, diploma);
            tbId.Text = iID.ToString();
            dtTeacher.Rows.Add(iID, name + " " + surname, DoB, email);
        }

        private void bAdd_Click(object sender, EventArgs e)
        {
            tbId.Text = tbSurname.Text = tbName.Text = "";
            dtpDob.Value = DateTime.Today;
            Activer(false);
            tbName.Focus();
        }

        private void bModi_Click(object sender, EventArgs e)
        {
            if (dgvTeacher.SelectedRows.Count > 0)
            {
                tbId.Text = dgvTeacher.SelectedRows[0].Cells["TId"].Value.ToString();
                var pTmp = new G_T_Teacher(sConnection).Lire_ID(int.Parse(tbId.Text));
                tbName.Text = pTmp.TName;
                tbSurname.Text = pTmp.TSurname;
                dtpDob.Value = pTmp.TDoB;
                tbEmail.Text = pTmp.TEmail;
                tbDiploma.Text = pTmp.TDiploma;
                Activer(false);
            }
            else
            {
                MessageBox.Show("Please select a row");
            }
        }

        private void bDel_Click(object sender, EventArgs e)
        {
            if (dgvTeacher.SelectedRows.Count > 0)
                if (MessageBox.Show("Confirm delete", "Are you fucking sure??", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                    RemoveTeacher();
        }

        private void bCan_Click(object sender, EventArgs e)
        {
            Activer(true);
        }

        private void bConf_Click(object sender, EventArgs e)
        {
            if (tbSurname.Text.Trim() == "")
                MessageBox.Show("Please put a name");
            else
            {
                if (tbId.Text == "")
                //Ajout
                {
                    AddTeacher(tbName.Text, tbSurname.Text, dtpDob.Value,tbEmail.Text,tbDiploma.Text);
                }
                else
                //Modification
                {
                    new G_T_Teacher(sConnection).Modifier(int.Parse(tbId.Text), tbName.Text, tbSurname.Text, dtpDob.Value,tbEmail.Text,tbDiploma.Text);
                    dgvTeacher.SelectedRows[0].Cells["TName"].Value = tbName.Text + " " + tbSurname.Text;
                    bsTeacher.EndEdit();

                }
                Activer(true);
                FillDGV();
            }



        }
    }
}
