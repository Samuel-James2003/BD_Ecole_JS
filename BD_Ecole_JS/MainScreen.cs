using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BD_Ecole_JS
{
    public partial class MainScreen : Form
    {
        public MainScreen()
        {
            InitializeComponent();
        }
        
        void OpenForm(Form form)
        {
            Hide();
            form.ShowDialog();
            Show();
        }

        


        private void bGCourse_Click(object sender, EventArgs e)
        {
            OpenForm(new GestionCourse());
        }

        private void bGTeacher_Click(object sender, EventArgs e)
        {
            OpenForm(new GestionTeacher());
        }

        private void bGStudent_Click(object sender, EventArgs e)
        {
            OpenForm(new GestionStudent());
        }

        private void bGDSChedule_Click(object sender, EventArgs e)
        {
            OpenForm(new GestionSchedule());
        }

        private void bGClass_Click(object sender, EventArgs e)
        {
            OpenForm(new GestionClass());
        }

        private void bGGrade_Click(object sender, EventArgs e)
        {

        }
    }
}
