using Projet_BDEcole.Classes;
using Projet_BDEcole.Gestion;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Windows.Forms;

namespace BD_Ecole_JS
{
    public partial class GestionAssociation : Form
    {
        public GestionAssociation()
        {
            InitializeComponent();
            sConnection = ConfigurationManager.ConnectionStrings["BD_Ecole_JS.Properties.Settings.ConnectionString_Couche"].ConnectionString;
            FillDGV();
            if (dgvAssociation.Rows.Count > 0)
                Activer(true);
            else
                Activer(false);
        }

        string sConnection;
        DataTable dtAssociation;
        BindingSource bsAssociation;

        private void GestionAssociation_Load(object sender, EventArgs e)
        {
            var lTmp = new G_T_Course(sConnection).Lire("N");
            foreach (var p in lTmp)
            {
                string tmp = (p.CourseID + "- " + p.CoName).ToString();
                cbTId.Items.Add(tmp);
            }

            var lTmp2 = new G_T_Student(sConnection).Lire("N");
            foreach (var p in lTmp2)
            {
                string tmp = (p.StudentID + "- " + p.SName + " " + p.SSurname).ToString();
                cbStId.Items.Add(tmp);
            }
            if (cbTId.Items.Count == 0 || cbStId.Items.Count == 0)
            {
                if (MessageBox.Show("No Association Added or No Student Added", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error) == DialogResult.OK)
                {
                    Close();
                }

            }
        }

        int Convert_CB_to_Int(string WorkingString)
        {
            var Res = WorkingString.Split('-');
            return int.Parse(Res[0]);
        }

        void FillDGV()
        {
            dtAssociation = new DataTable();
            dtAssociation.Columns.Add(new DataColumn("AId", Type.GetType("System.Int32")));
            dtAssociation.Columns.Add(new DataColumn("CoId"));
            dtAssociation.Columns.Add(new DataColumn("StId"));
            dtAssociation.Columns.Add(new DataColumn("CoName"));
            dtAssociation.Columns.Add(new DataColumn("StName"));
            List<C_T_Association> lTmp = new G_T_Association(sConnection).Lire("N");
            foreach (var p in lTmp)
            {
                string coursename = new G_T_Course(sConnection).Lire_ID(p.CourseID).CoName,
                    studentname = new G_T_Student(sConnection).Lire_ID(p.StudentID).SName
                    + " " + new G_T_Student(sConnection).Lire_ID(p.StudentID).SSurname;
                dtAssociation.Rows.Add(p.AssociationID, p.CourseID, p.StudentID, coursename, studentname);
            }
            bsAssociation = new BindingSource();
            bsAssociation.DataSource = dtAssociation;
            dgvAssociation.DataSource = bsAssociation;
        }

        void Activer(bool lPrincipal)
        {
            dgvAssociation.Enabled = lPrincipal;
            bAdd.Enabled = bModi.Enabled = bDel.Enabled = lPrincipal;
            cbStId.Enabled = cbTId.Enabled = !lPrincipal;
            bConf.Enabled = bCan.Enabled = !lPrincipal;
        }

        void RemoveAssociation()
        {
            int iID = (int)dgvAssociation.SelectedRows[0].Cells["AId"].Value;
            new G_T_Association(sConnection).Supprimer(iID);
            bsAssociation.RemoveCurrent();
        }

        void AddAssociation(int courseID, int studentID)
        {
            int iID = new G_T_Association(sConnection).Ajouter(studentID, courseID);
            tbId.Text = iID.ToString();
            dtAssociation.Rows.Add(iID, studentID, courseID);
        }

        private void bAdd_Click(object sender, EventArgs e)
        {
            tbId.Text = cbTId.Text = cbStId.Text = "";
            Activer(false);
            cbTId.Focus();
        }

        private void bModi_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Modifying the association table cascades over to the grade table and schedule table proceed with caution");
            if (dgvAssociation.SelectedRows.Count > 0)
            {
                tbId.Text = dgvAssociation.SelectedRows[0].Cells["AId"].Value.ToString();
                var pTmp = new G_T_Association(sConnection).Lire_ID(int.Parse(tbId.Text));
                cbStId.Text = pTmp.StudentID.ToString();
                cbTId.Text = pTmp.CourseID.ToString();
                Activer(false);
            }
            else
            {
                MessageBox.Show("Please select a row");
            }
        }

        private void bDel_Click(object sender, EventArgs e)
        {
            if (dgvAssociation.SelectedRows.Count > 0)
                if (MessageBox.Show("Confirm delete", "Are you fucking sure??", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                    RemoveAssociation();
        }

        private void bCan_Click(object sender, EventArgs e)
        {
            Activer(true);
        }

        private void bConf_Click(object sender, EventArgs e)
        {
            if (cbTId.Text.Trim() == "")
                MessageBox.Show("Please put a name");
            else
            {
                int TId = Convert_CB_to_Int(cbTId.Text);
                int StId = Convert_CB_to_Int(cbStId.Text);
                if (tbId.Text == "")
                //Ajout
                {
                    AddAssociation(StId, TId);
                }
                else
                //Modification
                {
                    new G_T_Association(sConnection).Modifier(int.Parse(tbId.Text), StId, TId);
                    dgvAssociation.SelectedRows[0].Cells["CoName"].Value = cbStId.Text;
                    bsAssociation.EndEdit();

                }
                Activer(true);
                FillDGV();
            }
        }
    }
}
