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
        DataTable dtGrade, dtSchedule, dtNoGrade;
        BindingSource bsGrade, bsSchedule, bsNoGrade;
        List<C_T_Association> Links = new List<C_T_Association>();
        //List<C_T_Grade> Grades = new List<C_T_Grade>();
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
            dtGrade.Columns.Add(new DataColumn("TName"));

            bsGrade = new BindingSource();
            bsGrade.DataSource = dtGrade;
            dgvGrade.DataSource = bsGrade;
        }

        void SetDGVNoGrade()
        {
            dtNoGrade = new DataTable();
            dtNoGrade.Columns.Add(new DataColumn("GId"));
            dtNoGrade.Columns.Add(new DataColumn("GName"));
            dtNoGrade.Columns.Add(new DataColumn("Gscore"));
            dtNoGrade.Columns.Add(new DataColumn("GDate"));
            dtNoGrade.Columns.Add(new DataColumn("AId"));
            dtNoGrade.Columns.Add(new DataColumn("StName"));
            dtNoGrade.Columns.Add(new DataColumn("CoName"));
            dtNoGrade.Columns.Add(new DataColumn("TName"));

            bsNoGrade = new BindingSource();
            bsNoGrade.DataSource = dtGrade;
            dgvNoGrade.DataSource = bsGrade;
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
            List<C_T_Teacher> lTmp = new G_T_Teacher(sConnection).Lire("N");
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
                if (teacherid == item.TeacherID)
                    IdsInLink.Add(item.CourseID);

            foreach (var item in new G_T_Schedule(sConnection).Lire("N"))
                foreach (var id in IdsInLink)
                    if (item.CourseID == id)
                        FillDGV(item);
        }

        void SchedStudent(string text)
        {
            var studentid = ConvertTreeNodeToInt(text);
            IdsInLink.Clear();

            foreach (var item in new G_T_Association(sConnection).Lire("N"))
                if (studentid == item.StudentID)
                    IdsInLink.Add(item.CourseID);

            foreach (var item in new G_T_Schedule(sConnection).Lire("N"))
                foreach (var id in IdsInLink)
                    if (item.CourseID == id)
                        FillDGV(item);
        }

        void Grade(string text)
        {
            Links.Clear();
            foreach (var assoc in new G_T_Association(sConnection).Lire("N"))
                if (assoc.StudentID == ConvertTreeNodeToInt(text))
                    Links.Add(assoc);

            foreach (var Grade in new G_T_Grade(sConnection).Lire("N"))
                foreach (var Assoc in Links)
                    if (Grade.AssociationID == Assoc.AssociationID)
                        FillDGV(CoName_TName(Assoc), Grade, text);
        }

        void FillDGV(C_T_Schedule p)
        {
            string coursename = CourseNameIfNull(p);
            string classname = new G_T_Class(sConnection).Lire_ID(p.ClassID).ClName;
            string duration = TimeFormatting(p);

            dtSchedule.Rows.Add(p.ScheduleID, duration, p.SchDate.ToShortDateString(), p.SchStart_Time.ToShortTimeString(), p.ClassID, p.CourseID, classname, coursename);

            bsSchedule = new BindingSource();
            bsSchedule.DataSource = dtSchedule;
            dgvSchedule.DataSource = bsSchedule;
        }

        void FillDGV(string[] names, C_T_Grade g, string text)
        {
            dtGrade.Rows.Add(g.GradeID, g.GName, g.Gscore, IfNullDateString(g), g.AssociationID, ConvertTreeNodeToName(text), names[0], names[1]);

            bsGrade = new BindingSource();
            bsGrade.DataSource = dtGrade;
            dgvGrade.DataSource = bsGrade;
        }

        void FillDGV(C_T_Association a)
        {
            var names = CoName_TName(a);
            dtNoGrade.Rows.Add("", "", "", "", a.AssociationID, StudentName(a), names[0], names[1]);

            bsNoGrade = new BindingSource();
            bsNoGrade.DataSource = dtNoGrade;
            dgvNoGrade.DataSource = bsNoGrade;
        }

        string StudentName(C_T_Association p)
        {
            var tmp = new G_T_Association(sConnection).Lire_ID(p.AssociationID).StudentID;
            return new G_T_Student(sConnection).Lire_ID(tmp).SName + " " + new G_T_Student(sConnection).Lire_ID(tmp).SSurname;
        }

        string[] CoName_TName(C_T_Association p)
        {
            var tmp = new G_T_Association(sConnection).Lire_ID(p.AssociationID).CourseID;
            string[] res = new string[2];
            res[0] = new G_T_Course(sConnection).Lire_ID(tmp).CoName;
            res[1] = new G_T_Teacher(sConnection).Lire_ID(new G_T_Course(sConnection).Lire_ID(tmp).TeacherID).TName + " " + new G_T_Teacher(sConnection).Lire_ID(new G_T_Course(sConnection).Lire_ID(tmp).TeacherID).TSurname;
            return res;
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

        private void dgvNoGrade_RowEnter(object sender, DataGridViewCellEventArgs e)
        {

            //new G_T_Grade(sConnection).Ajouter(name, score, date, AssocID);
        }

        void tvSchool_AfterSelect(object sender, TreeViewEventArgs e)
        {
            dgvGrade.Visible = dgvSchedule.Visible = dgvNoGrade.Visible = false;
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
                SetDGVNoGrade();
                if (HasAssocWithNoGrade(ConvertTreeNodeToInt(e.Node.Text)))
                    dgvNoGrade.Visible = true;
                dgvGrade.Visible = true;
                Grade(e.Node.Text);
            }

        }

        private void dgvNoGrade_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DateTime date;
                string name = dgvNoGrade.Rows[e.RowIndex].Cells[1].Value.ToString();
                int score = int.Parse(dgvNoGrade.Rows[e.RowIndex].Cells[2].Value.ToString());
                int AssocID = int.Parse(dgvNoGrade.Rows[e.RowIndex].Cells[4].Value.ToString());
                var possible = DateTime.TryParse(dgvNoGrade.Rows[e.RowIndex].Cells[3].Value.ToString(), out date);
                if (!possible)
                {
                    var res = MessageBox.Show($"Name : {name} \nScore : {score} \nAssociation :  {AssocID} \n!!Date is NULL!! ", "This is going to be added do you confirm", MessageBoxButtons.OKCancel);
                    if (res == DialogResult.OK)
                    {
                        new G_T_Grade(sConnection).Ajouter(name, score, null, AssocID);
                        Reset();
                    }
                    return;

                }
                else
                {
                    var res = MessageBox.Show($"Name : {name} \nScore : {score} \nAssociation :  {AssocID} \nDate : {date.ToShortDateString()} ", "This is going to be added do you confirm", MessageBoxButtons.OKCancel);
                    if (res == DialogResult.OK)
                    {
                        new G_T_Grade(sConnection).Ajouter(name, score, date, AssocID);
                        Reset();
                    }
                    return;
                }
            }
            catch (Exception)
            { }

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

        bool HasAssocWithNoGrade(int studentID)
        {
            IdsInLink.Clear();


            foreach (var Grade in new G_T_Grade(sConnection).Lire("N"))
                IdsInLink.Add(Grade.AssociationID);
            foreach (var Assoc in new G_T_Association(sConnection).Lire("N"))
                if (!IdsInLink.Contains(Assoc.AssociationID) && Assoc.StudentID == studentID)
                    FillDGV(Assoc);

            if (dgvNoGrade.RowCount > 0)
                return true;
            else
                return false;
        }

        void Reset()
        {
            bsGrade = new BindingSource();
            bsGrade.DataSource = dtGrade;
            dgvGrade.DataSource = bsGrade;

            bsNoGrade = new BindingSource();
            bsNoGrade.DataSource = dtNoGrade;
            dgvNoGrade.DataSource = bsNoGrade;

        }

    }
}
