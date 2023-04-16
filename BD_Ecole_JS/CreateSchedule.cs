using Projet_BDEcole.Classes;
using Projet_BDEcole.Gestion;
using System;
using System.Configuration;
using System.IO;
using System.Windows.Forms;

namespace BD_Ecole_JS
{
    public partial class CreateSchedule : Form
    {
        string sConnection, MyPath = Directory.GetCurrentDirectory();
        char ast = '"';

        public CreateSchedule()
        {
            InitializeComponent();
            sConnection = ConfigurationManager.ConnectionStrings["BD_Ecole_JS.Properties.Settings.ConnectionString_Couche"].ConnectionString;
            SetDirs();
            CreateSch();
            Uri uri = new Uri(MyPath + @"\schedules\index.html");
            wbSchedule.Url = uri;
        }

        string TimeFormatting(TimeSpan p)
        {
            string duration;
            if (p.Minutes == 0)
                duration = $"{p.Hours}:00";
            else
                duration = $"{p.Hours}:{p.Minutes}";
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

        void HtmlIndex(C_T_Student student, string path)
        {
            string index = MyPath + @"\schedules\index.html";
            string html = $"<a href={ast}{path}{ast}>{student.SSection} {student.SYear}</a>";
            using (StreamWriter sw = new StreamWriter(index, true))
            {
                sw.WriteLine(html);
            }
        }

        void HtmlAppend(C_T_Schedule Sched, C_T_Student Student)
        {
            string coursename = CourseNameIfNull(Sched);
            string classname = new G_T_Class(sConnection).Lire_ID(Sched.ClassID).ClName;
            string duration = TimeFormatting(Sched.SchDuration);
            

            string[] data = new string[]
            {
                $"<tr> <td> {duration} </td>",
                $"<td>{Sched.SchDate.ToShortDateString()}</td>",
                $"<td>{Sched.SchStart_Time.ToShortTimeString()}</td>",
                $"<td>{Sched.ClassID}</td>",
                $"<td>{Sched.CourseID}</td>",
                $"<td>{classname}</td>",
                $"<td>{coursename}</td></tr>"
            };



            string WorkingDir = MyPath + $@"\schedules\{Student.SSection}\{Student.SYear}\{Student.SSection}_{Student.SYear}.html";
            using (StreamWriter sw = new StreamWriter(WorkingDir, true))
            {
                foreach (var line in data)
                    sw.WriteLine(line);
            }
            
        }

        void SetFile(C_T_Student Student)
        {
            string header = Student.SSection + Student.SYear;
            string html = "<!DOCTYPE html>\n" +
                              "<html>\n" +
                              "<head>\n" +
                              "  <title>Schedule</title>\n" +
                              "</head>\n" +
                              "<body>\n" +
                              "  <h1>" + header + "</h1>\n" +
                              "  <table border=\"1\">\n" +
                              "    <tr>\n" +
                              "      <th>Duration</th>\n" +
                              "      <th>Date</th>\n" +
                              "      <th>Start Time</th>\n" +
                              "      <th>ClassID</th>\n" +
                              "      <th>CourseID</th>\n" +
                              "      <th>Class Name</th>\n" +
                              "      <th>Course Name</th>\n" +
                              "    </tr>\n";

            string WorkingDir = MyPath + $@"\schedules\{Student.SSection}\{Student.SYear}\{Student.SSection}_{Student.SYear}.html";
            using (StreamWriter sw = new StreamWriter(WorkingDir, true))
            {
                sw.Write(html);
            }
        }

        void HtmlEnd(C_T_Student Student)
        {
            string index = MyPath + @"\schedules\index.html";
            string WorkingDir = MyPath + $@"\schedules\{Student.SSection}\{Student.SYear}\{Student.SSection}_{Student.SYear}.html";

            using (StreamWriter sw = new StreamWriter(WorkingDir, true))
            {
                sw.Write($"</table>\n <a href={ast}{index}{ast}>Index</a>\n </body>\n</html>");
            }
        }

        void CreateSch()
        {
            foreach (var student in new G_T_Student(sConnection).Lire("N"))
            {
                int tmp = 0;

                foreach (var Schedule in new G_T_Schedule(sConnection).Lire("N"))
                {
                    foreach (var Assoc in new G_T_Association(sConnection).Lire("N"))
                    {
                        if (Schedule.CourseID == Assoc.CourseID && Assoc.StudentID == student.StudentID && tmp == 0)
                        {
                            SetFile(student);
                            HtmlAppend(Schedule, student);
                            tmp++;
                        }
                        else if (Schedule.CourseID == Assoc.CourseID && Assoc.StudentID == student.StudentID && tmp != 0)
                        {
                            HtmlAppend(Schedule,student);
                        }
                    }
                }
                HtmlEnd(student);
            }


        }

        void SetDirs()
        {
            if (!Directory.Exists(MyPath + @"\schedules"))
                Directory.CreateDirectory(MyPath + @"\schedules");

            string index = MyPath + @"\schedules\index.html";
            if (File.Exists(index))
                File.Delete(index);

            string html = "<!DOCTYPE html>\n" +
                          "<html>\n" +
                          "<head>\n" +
                          "  <title>Index</title>\n" +
                          "</head>\n" +
                          "<body>\n" +
                          "  <h1> Index </h1>\n";
            File.WriteAllText(index, html);

            foreach (var student in new G_T_Student(sConnection).Lire("N"))
            {
                string WorkingDir = MyPath + @"\schedules\" + student.SSection + @"\" + student.SYear;
                string WorkingFile = WorkingDir + $@"\{student.SSection}_{student.SYear}.html";
                if (!Directory.Exists(WorkingDir))
                    Directory.CreateDirectory(WorkingDir);

                if (File.Exists(WorkingFile))
                    File.Delete(WorkingFile);

                File.Create(WorkingFile).Close();
                HtmlIndex(student, WorkingFile);
            }

            using (StreamWriter sw = new StreamWriter(index, true))
            {
                sw.Write("</table>\n </body>\n</html>");
                sw.Close();
            }


        }
    }
}
