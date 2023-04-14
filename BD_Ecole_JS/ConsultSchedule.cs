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
    public partial class ConsultSchedule : Form
    {
        string sConnection;
        DataTable dtSchedule;
        BindingSource bsSchedule;
        List<int> IdsInLink = new List<int>();

        public ConsultSchedule()
        {
            InitializeComponent();
            sConnection = ConfigurationManager.ConnectionStrings["BD_Ecole_JS.Properties.Settings.ConnectionString_Couche"].ConnectionString;
            SetDGV();
        }

        private void SetDGV()
        {
            dtSchedule = new DataTable();
            dtSchedule.Columns.Add(new DataColumn("ScheduleID", Type.GetType("System.Int32")));
            dtSchedule.Columns.Add(new DataColumn("SchDuration"));
            dtSchedule.Columns.Add(new DataColumn("SchDate"));
            dtSchedule.Columns.Add(new DataColumn("SchStartTime"));
            dtSchedule.Columns.Add(new DataColumn("ClassID"));
            dtSchedule.Columns.Add(new DataColumn("CourseID"));
            dtSchedule.Columns.Add(new DataColumn("ClName"));
            dtSchedule.Columns.Add(new DataColumn("CoName"));
            bsSchedule = new BindingSource();
            bsSchedule.DataSource = dtSchedule;
            dgvSchedule.DataSource = bsSchedule;
        }

        string TimeFormatting(C_T_Schedule p)
        {
            string duration;
            if (p.SchDuration.Minutes == 0)
                duration = $"{p.SchDuration.Hours}:00";
            else
                duration = $"{p.SchDuration.Hours}:{p.SchDuration.Minutes}";
            return duration;
        }

        string CourseNameIfNull(C_T_Schedule p)
        {
            string coursename;
            if (!(p.CourseID is null))
                coursename = new G_T_Course(sConnection).Lire_ID((int)p.CourseID).CoName;
            else
                coursename = "No course Id accociated";
            return coursename;
        }

        void FillDGV(C_T_Schedule p)
        {
            string coursename;
            coursename = CourseNameIfNull(p);
            string classname = new G_T_Class(sConnection).Lire_ID(p.ClassID).ClName;
            string duration;
            duration = TimeFormatting(p);

            dtSchedule.Rows.Add(p.ScheduleID, duration, p.SchDate.ToShortDateString(), p.SchStart_Time.ToShortTimeString(), p.ClassID, p.CourseID, classname, coursename);

            bsSchedule = new BindingSource();
            bsSchedule.DataSource = dtSchedule;
            dgvSchedule.DataSource = bsSchedule;
        }

        private void bGoT_Click(object sender, EventArgs e)
        {
            var teacherid = Convert_CB_to_Int(cbTId.Text);
            IdsInLink.Clear();
            foreach (var item in new G_T_Course(sConnection).Lire("N"))
            {
                if (teacherid == item.TeacherID)
                {
                    IdsInLink.Add(item.CourseID);
                }
            }

            foreach (var item in new G_T_Schedule(sConnection).Lire("N"))
            {
                foreach (var id in IdsInLink)
                {
                    if (item.CourseID == id)
                    {
                        FillDGV(item);
                    }
                }
            }

            cbTId.Text = "";
            gbTeacher.Enabled = bGoT.Enabled = bTeacher.Enabled = false;
        }

        int Convert_CB_to_Int(string WorkingString)
        {
            var Res = WorkingString.Split('-');
            return int.Parse(Res[0]);
        }

        private void ConsultSchedule_Load(object sender, EventArgs e)
        {
            var lTmp = new G_T_Teacher(sConnection).Lire("N");
            foreach (var p in lTmp)
            {
                string tmp = (p.TeacherID + "- " + p.TName + " " + p.TSurname).ToString();
                cbTId.Items.Add(tmp);
            }

            var lTmp2 = new G_T_Student(sConnection).Lire("N");
            foreach (var p in lTmp2)
            {
                string tmp = (p.StudentID + "- " + p.SName + " " + p.SSurname).ToString();
                cbStId.Items.Add(tmp);
            }

            NoItemsInCombobox();
        }

        void NoItemsInCombobox()
        {
            if (cbTId.Items.Count == 0)
            {
                bTeacher.Enabled = false;
            }

            else if (cbStId.Items.Count == 0)
            {
                bStudent.Enabled = false;
            }

            else if (cbTId.Items.Count == 0 && cbStId.Items.Count == 0)
            {
                if (MessageBox.Show("No Teacher Added and No Student Added", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error) == DialogResult.OK)
                {
                    Close();
                }

            }
        }

        private void bTeacher_Click(object sender, EventArgs e)
        {
            gbTeacher.Enabled = true;
            bStudent.Enabled = false;
        }

        private void bStudent_Click(object sender, EventArgs e)
        {
            gbStudent.Enabled = true;
            bTeacher.Enabled = false;
        }

        private void bGoS_Click(object sender, EventArgs e)
        {
            var studentid = Convert_CB_to_Int(cbStId.Text);
            IdsInLink.Clear();
            foreach (var item in new G_T_Association(sConnection).Lire("N"))
            {
                if (studentid == item.StudentID)
                {
                    IdsInLink.Add(item.CourseID);
                }
            }

            foreach (var item in new G_T_Schedule(sConnection).Lire("N"))
            {
                foreach (var id in IdsInLink)
                {
                    if (item.CourseID == id)
                    {
                        FillDGV(item);
                    }
                }
            }

            cbStId.Text = "";
            gbStudent.Enabled = bGoS.Enabled = bStudent.Enabled = false;
        }

        private void bClear_Click(object sender, EventArgs e)
        {

            SetDGV();
            bTeacher.Enabled = bStudent.Enabled = true;
            bStudent.Enabled = bTeacher.Enabled = true;
            NoItemsInCombobox();
        }

        private void cbTId_TextChanged(object sender, EventArgs e)
        {
            bGoT.Enabled = true;
        }

        private void cbStId_TextChanged(object sender, EventArgs e)
        {
            bGoS.Enabled = true;
        }
    }
}
