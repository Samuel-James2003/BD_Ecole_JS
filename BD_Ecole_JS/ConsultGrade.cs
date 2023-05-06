using Projet_BDEcole.Classes;
using Projet_BDEcole.Gestion;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace BD_Ecole_JS
{
    public partial class ConsultGrade : Form
    {
        string sConnection;
        DataTable dtGrade;
        BindingSource bsGrade;
        List<C_T_Association> Links = new List<C_T_Association>();

        public ConsultGrade()
        {
            InitializeComponent();
            sConnection = ConfigurationManager.ConnectionStrings["BD_Ecole_JS.Properties.Settings.ConnectionString_Couche"].ConnectionString;
            SetDGV();
        }

        private void ConsultGrade_Load(object sender, EventArgs e)
        {
            var ltmp = new G_T_Student(sConnection).Lire("N");
            foreach (var p in ltmp)
            {
                string tmp = (p.StudentID + "- " + p.SName + " " + p.SSurname).ToString();
                cbStId.Items.Add(tmp);
            }

            if (cbStId.Items.Count != 0)
            {
                gbStudent.Enabled = true;
            }

            else
            {
                if (MessageBox.Show(" No Student Added", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error) == DialogResult.OK)
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

        string Convert_CB_to_String(string WorkingString)
        {
            var Res = WorkingString.Split('-');
            return Res.Last();
        }

        string[] CoName_TName(C_T_Association p)
        {
            var tmp = new G_T_Association(sConnection).Lire_ID(p.AssociationID).CourseID;
            string[] res = new string[2];
            res[0] = new G_T_Course(sConnection).Lire_ID(tmp).CoName;
            res[1] = new G_T_Teacher(sConnection).Lire_ID(new G_T_Course(sConnection).Lire_ID(tmp).TeacherID).TName + " " + new G_T_Teacher(sConnection).Lire_ID(new G_T_Course(sConnection).Lire_ID(tmp).TeacherID).TSurname;
            return res;
        }

        string IfNullDateString(C_T_Grade p)
        {
            if (!(p.GDate is null))
            {
                DateTime date = (DateTime)new G_T_Grade(sConnection).Lire_ID(p.GradeID).GDate;
                return date.ToShortDateString();
            }

            else
                return "";
        }

        private void SetDGV()
        {
            dtGrade = new DataTable();
            dtGrade.Columns.Add(new DataColumn("GId", Type.GetType("System.Int32")));
            dtGrade.Columns.Add(new DataColumn("GName"));
            dtGrade.Columns.Add(new DataColumn("Gscore"));
            dtGrade.Columns.Add(new DataColumn("GDate"));
            dtGrade.Columns.Add(new DataColumn("AId"));
            dtGrade.Columns.Add(new DataColumn("StName"));
            dtGrade.Columns.Add(new DataColumn("CoName"));
            dtGrade.Columns.Add(new DataColumn("TName"));

            bsGrade = new BindingSource();
            bsGrade.DataSource = dtGrade;
            dgvGrade.DataSource = bsGrade;
        }

        void FillDGV(string[] CourseAndTeacher, C_T_Grade g)
        {

            dtGrade.Rows.Add(g.GradeID, g.GName, g.Gscore, IfNullDateString(g), g.AssociationID, Convert_CB_to_String(cbStId.Text), CourseAndTeacher[0], CourseAndTeacher[1]);

            bsGrade = new BindingSource();
            bsGrade.DataSource = dtGrade;
            dgvGrade.DataSource = bsGrade;
        }

        private void bGoS_Click(object sender, EventArgs e)
        {
            Links.Clear();
            SetDGV();
            foreach (var item in new G_T_Association(sConnection).Lire("N"))
                if (item.StudentID == Convert_CB_to_Int(cbStId.Text))
                    Links.Add(item);

            foreach (var item in new G_T_Grade(sConnection).Lire("N"))
                foreach (var Assoc in Links)
                    if (item.AssociationID == Assoc.AssociationID)
                        FillDGV(CoName_TName(Assoc), item);
        }

        private void cbStId_TextChanged(object sender, EventArgs e)
        { bGoS.Enabled = true; }
    }
}
