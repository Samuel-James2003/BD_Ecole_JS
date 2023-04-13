using Projet_BDEcole.Classes;
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
    public partial class GestionStudent : Form
    {
        DataTable dtStudent;
        BindingSource bsStudent;
        string sConnection;

        public GestionStudent()
        {
            InitializeComponent();
            sConnection = ConfigurationManager.ConnectionStrings["BD_Ecole_JS.Properties.Settings.ConnectionString_Couche"].ConnectionString;
            FillDGV();
            if (dgvStudent.Rows.Count > 0)
                Activer(true);
            else
                Activer(false);
        }

        void FillDGV()
        {
            dtStudent = new DataTable();
            dtStudent.Columns.Add(new DataColumn("SId", Type.GetType("System.Int32")));
            dtStudent.Columns.Add(new DataColumn("SName"));
            dtStudent.Columns.Add(new DataColumn("SDob"));
            dtStudent.Columns.Add(new DataColumn("SEmail"));
            dtStudent.Columns.Add(new DataColumn("SYear"));
            dtStudent.Columns.Add(new DataColumn("SSection"));
            List<C_T_Student> lTmp = new G_T_Student(sConnection).Lire("N");
            foreach (var p in lTmp)
            {
                dtStudent.Rows.Add(p.StudentID, p.SName + " " + p.SSurname, p.SDoB.ToShortDateString(), p.SEmail, p.SYear, p.SSection);
            }
            bsStudent = new BindingSource();
            bsStudent.DataSource = dtStudent;
            dgvStudent.DataSource = bsStudent;
        }

        void Activer(bool lPrincipal)
        {
            dgvStudent.Enabled = lPrincipal;
            bAdd.Enabled = bModi.Enabled = bDel.Enabled = lPrincipal;
            tbName.Enabled = tbSurname.Enabled = dtpDob.Enabled = tbYear.Enabled = tbSection.Enabled = tbEmail.Enabled = !lPrincipal;
            bConf.Enabled = bCan.Enabled = !lPrincipal;
        }

        void RemoveStudent()
        {
            int iID = (int)dgvStudent.SelectedRows[0].Cells["SId"].Value;
            new G_T_Student(sConnection).Supprimer(iID);
            bsStudent.RemoveCurrent();
        }

        void AddStudent(string name, string surname, DateTime DoB, string email, string year, string section)
        {
            int iID = new G_T_Student(sConnection).Ajouter(DoB, name, surname, email, year, section);
            tbId.Text = iID.ToString();
            dtStudent.Rows.Add(iID, name + " " + surname, DoB.ToShortDateString(), email);
        }

        private void bAdd_Click(object sender, EventArgs e)
        {
            tbId.Text = tbSurname.Text = tbName.Text = tbSection.Text = tbYear.Text = tbEmail.Text = "";
            dtpDob.Value = DateTime.Today;
            Activer(false);
            tbName.Focus();
        }

        private void bModi_Click(object sender, EventArgs e)
        {
            if (dgvStudent.SelectedRows.Count > 0)
            {
                tbId.Text = dgvStudent.SelectedRows[0].Cells["SId"].Value.ToString();
                var pTmp = new G_T_Student(sConnection).Lire_ID(int.Parse(tbId.Text));
                tbName.Text = pTmp.SName;
                tbSurname.Text = pTmp.SSurname;
                dtpDob.Value = pTmp.SDoB;
                tbEmail.Text = pTmp.SEmail;
                tbSection.Text = pTmp.SSection;
                tbYear.Text = pTmp.SYear;
                Activer(false);
            }
            else
            {
                MessageBox.Show("Please select a row");
            }
        }

        private void bDel_Click(object sender, EventArgs e)
        {
            if (dgvStudent.SelectedRows.Count > 0)
                if (MessageBox.Show("Confirm delete", "Are you fucking sure??", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                    RemoveStudent();
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
                    AddStudent(tbName.Text, tbSurname.Text, dtpDob.Value, tbEmail.Text, tbYear.Text, tbSection.Text);
                }
                else
                //Modification
                {
                    new G_T_Student(sConnection).Modifier(int.Parse(tbId.Text), dtpDob.Value, tbName.Text, tbSurname.Text, tbEmail.Text, tbYear.Text, tbSection.Text);
                    dgvStudent.SelectedRows[0].Cells["SName"].Value = tbName.Text + " " + tbSurname.Text;
                    bsStudent.EndEdit();
                }
                Activer(true);
                FillDGV();
            }
        }

        private void tbSurname_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
