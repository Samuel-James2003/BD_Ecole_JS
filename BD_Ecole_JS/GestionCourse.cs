using Projet_BDEcole.Classes;
using Projet_BDEcole.Gestion;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Windows.Forms;

namespace BD_Ecole_JS
{
    public partial class GestionCourse : Form
    {

        public GestionCourse()
        {
            InitializeComponent();
            sConnection = ConfigurationManager.ConnectionStrings["BD_Ecole_JS.Properties.Settings.ConnectionString_Couche"].ConnectionString;
            FillDGV();
            if (dgvCourse.Rows.Count > 0)
                Activer(true);
            else
                Activer(false);
        }

        private void GestionCourse_Load(object sender, EventArgs e)
        {
            List<C_T_Teacher> lTmp = new G_T_Teacher(sConnection).Lire("N");
            foreach (var p in lTmp)
            {
                string tmp = (p.TeacherID + "- " + p.TName + " " + p.TSurname).ToString();
                cbTId.Items.Add(tmp);
            }
            if (cbTId.Items.Count == 0)
            {
                if (MessageBox.Show("No Teacher Added", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error) == DialogResult.OK)
                {
                    Close();
                }

            }
        }

        string sConnection;
        DataTable dtCourse;
        BindingSource bsCourse;

        int Convert_CB_to_Int(string WorkingString)
        {
            var Res = WorkingString.Split('-');
            return int.Parse(Res[0]);
        }

        void FillDGV()
        {
            dtCourse = new DataTable();
            dtCourse.Columns.Add(new DataColumn("CoId", Type.GetType("System.Int32")));
            dtCourse.Columns.Add(new DataColumn("CoName"));
            dtCourse.Columns.Add(new DataColumn("TId"));
            dtCourse.Columns.Add(new DataColumn("TName"));

            List<C_T_Course> lTmp = new G_T_Course(sConnection).Lire("N");
            foreach (var p in lTmp)
            {
                dtCourse.Rows.Add(p.CourseID, p.CoName, p.TeacherID, TeacherName(p));
            }
            bsCourse = new BindingSource();
            bsCourse.DataSource = dtCourse;
            dgvCourse.DataSource = bsCourse;
        }
        string TeacherName(C_T_Course p)
        {
            return new G_T_Teacher(sConnection).Lire_ID(p.TeacherID).TName + " " + new G_T_Teacher(sConnection).Lire_ID(p.TeacherID).TSurname;
        }
        void Activer(bool lPrincipal)
        {
            dgvCourse.Enabled = lPrincipal;
            bAdd.Enabled = bModi.Enabled = bDel.Enabled = lPrincipal;
            tbName.Enabled = cbTId.Enabled = !lPrincipal;
            bConf.Enabled = bCan.Enabled = !lPrincipal;
        }

        void RemoveCourse()
        {
            int iID = (int)dgvCourse.SelectedRows[0].Cells["CoId"].Value;
            new G_T_Course(sConnection).Supprimer(iID);
            bsCourse.RemoveCurrent();
        }

        void AddCourse(string name, int teacherID)
        {
            int iID = new G_T_Course(sConnection).Ajouter(name, teacherID);
            tbId.Text = iID.ToString();
            dtCourse.Rows.Add(iID, name, teacherID);
        }

        private void bAdd_Click(object sender, EventArgs e)
        {
            tbId.Text = cbTId.Text = tbName.Text = "";
            Activer(false);
            tbName.Focus();
        }

        private void bModi_Click(object sender, EventArgs e)
        {
            if (dgvCourse.SelectedRows.Count > 0)
            {
                tbId.Text = dgvCourse.SelectedRows[0].Cells["CoId"].Value.ToString();
                var pTmp = new G_T_Course(sConnection).Lire_ID(int.Parse(tbId.Text));
                tbName.Text = pTmp.CoName;
                cbTId.Text = pTmp.TeacherID.ToString();
                Activer(false);
            }
            else
            {
                MessageBox.Show("Please select a row");
            }
        }

        private void bDel_Click(object sender, EventArgs e)
        {
            if (dgvCourse.SelectedRows.Count > 0)
                if (MessageBox.Show("Confirm delete", "Are you fucking sure??", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                    RemoveCourse();
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
                if (tbId.Text == "")
                //Ajout
                {
                    AddCourse(tbName.Text, TId);
                }
                else
                //Modification
                {
                    new G_T_Course(sConnection).Modifier(int.Parse(tbId.Text), tbName.Text, TId);
                    dgvCourse.SelectedRows[0].Cells["CoName"].Value = tbName.Text;
                    bsCourse.EndEdit();

                }
                Activer(true);
                FillDGV();
            }



        }


    }
}
