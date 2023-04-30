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
    public partial class MainScreen : Form
    {
        string sConnection;
        DataTable dtGrade, dtSchedule;
        BindingSource bsGrade, bsSchedule;
        List<C_T_Association> Links = new List<C_T_Association>();
        List<int> IdsInLink = new List<int>();

        public MainScreen()
        {
            InitializeComponent();
            sConnection = ConfigurationManager.ConnectionStrings["BD_Ecole_JS.Properties.Settings.ConnectionString_Couche"].ConnectionString;
        }

        #region Events

        void OpenForm(Form form)
        {
            Hide();
            form.ShowDialog();
            Show();
        }

         private void tscGrade_Click(object sender, EventArgs e)
        {
            OpenForm(new ConsultGrade());
        }

        private void tscSchedule_Click(object sender, EventArgs e)
        {
            OpenForm(new ConsultSchedule());
        }

        private void tsCreateSched_Click(object sender, EventArgs e)
        {
            OpenForm(new CreateSchedule());
        }

        private void tsgTeacher_Click(object sender, EventArgs e)
        {
            OpenForm(new GestionTeacher());
        }

        private void tsgClass_Click(object sender, EventArgs e)
        {
            OpenForm(new GestionClass());
        }

        private void tsgStudent_Click(object sender, EventArgs e)
        {
            OpenForm(new GestionStudent());
        }

        private void tsgSchedule_Click(object sender, EventArgs e)
        {
            OpenForm(new GestionSchedule());
        }

        private void tsgGrade_Click(object sender, EventArgs e)
        {
            OpenForm(new GestionGrade());
        }

        private void tsgCourse_Click(object sender, EventArgs e)
        {
            OpenForm(new GestionCourse());
        }

        private void tsgAssoc_Click(object sender, EventArgs e)
        {
            OpenForm(new GestionAssociation());
        }
        #endregion

        void SetDGVGrade()
        {
            dtGrade = new DataTable();
            dtGrade.Columns.Add(new DataColumn("GId", Type.GetType("System.Int32")));
            dtGrade.Columns.Add(new DataColumn("GName"));
            dtGrade.Columns.Add(new DataColumn("Gscore"));
            dtGrade.Columns.Add(new DataColumn("GDate"));
            dtGrade.Columns.Add(new DataColumn("AId"));
            dtGrade.Columns.Add(new DataColumn("StName"));
            dtGrade.Columns.Add(new DataColumn("CoName"));

            bsGrade = new BindingSource();
            bsGrade.DataSource = dtGrade;
            dgvGrade.DataSource = bsGrade;
        }

        void SetDGVSched()
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

        void MainScreen_Load(object sender, EventArgs e)
        {
            TreeNode SchedT = new TreeNode("Teacher Schedules");
            var lTmp = new G_T_Teacher(sConnection).Lire("N");
            foreach (var p in lTmp)
            {
                string tmp = $"{p.TeacherID} - {p.TName} {p.TSurname}";
                SchedT.Nodes.Add(tmp);
            }
            tvSchool.Nodes.Add(SchedT);

            TreeNode SchedS = new TreeNode("Student Schedules");
            var lTmp2 = new G_T_Student(sConnection).Lire("N");
            foreach (var p in lTmp2)
            {
                string tmp = $"{p.StudentID}- {p.SName} {p.SSurname}";
                SchedS.Nodes.Add(tmp);
            }
            tvSchool.Nodes.Add(SchedS);

            TreeNode Grade = new TreeNode("Grades");
            var ltmp3 = new G_T_Student(sConnection).Lire("N");
            foreach (var p in ltmp3)
            {
                string tmp = $"{p.StudentID}- {p.SName} {p.SSurname}";
                Grade.Nodes.Add(tmp);
            }
            tvSchool.Nodes.Add(Grade);

        }

        int ConvertTreeNodeToInt(string WorkingString)
        {
            var Res = WorkingString.Split('-');
            return int.Parse(Res[0]);
        }

        string ConvertTreeNodeToName(string WorkingString)
        {
            var Res = WorkingString.Split('-');
            return Res.Last();
        }

        void SchedTeacher(string text)
        {
            var teacherid = ConvertTreeNodeToInt(text);
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
        }

        void SchedStudent(string text)
        {
            var studentid = ConvertTreeNodeToInt(text);
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
        }

        void Grade(string text)
        {
            Links.Clear();
            foreach (var item in new G_T_Association(sConnection).Lire("N"))
                if (item.StudentID == ConvertTreeNodeToInt(text))
                    Links.Add(item);

            foreach (var item in new G_T_Grade(sConnection).Lire("N"))
                foreach (var Assoc in Links)
                    if (item.AssociationID == Assoc.AssociationID)
                        FillDGV(CourseName(Assoc), item, text);
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

        void FillDGV(string coursename, C_T_Grade g, string text)
        {

            dtGrade.Rows.Add(g.GradeID, g.GName, g.Gscore, GDateIfNull(g).ToShortDateString(), g.AssociationID, ConvertTreeNodeToName(text), coursename);

            bsGrade = new BindingSource();
            bsGrade.DataSource = dtGrade;
            dgvGrade.DataSource = bsGrade;
        }

        string CourseName(C_T_Association p)
        {
            var tmp = new G_T_Association(sConnection).Lire_ID(p.AssociationID).CourseID;
            return new G_T_Course(sConnection).Lire_ID(tmp).CoName;
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

        void tvSchool_AfterSelect(object sender, TreeViewEventArgs e)
        {
            dgvGrade.Visible = dgvSchedule.Visible = false;
            if (e.Node.Text == "Teacher Schedules" || e.Node.Text == "Student Schedules" || e.Node.Text == "Grades")
                return;

            if (e.Node.Parent.Text == "Teacher Schedules")
            {
                SetDGVSched();
                dgvSchedule.Visible = true;
                SchedTeacher(e.Node.Text);
            }

            else if (e.Node.Parent.Text == "Student Schedules")
            {
                SetDGVSched();
                dgvSchedule.Visible = true;
                SchedStudent(e.Node.Text);
            }

            else if (e.Node.Parent.Text == "Grades")
            {
                SetDGVGrade();
                dgvGrade.Visible = true;
                Grade(e.Node.Text);
            }

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

        DateTime GDateIfNull(C_T_Grade p)
        {
            DateTime date;
            if (!(p.GDate is null))
                date = (DateTime)new G_T_Grade(sConnection).Lire_ID(p.GradeID).GDate;
            else
                date = new DateTime(0, 0, 0);
            return date;
        }



    }
}
