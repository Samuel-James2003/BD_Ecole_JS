using System;
using System.Collections.Generic;
using System.Data;
using Projet_BDEcole.Gestion;
using System.Windows.Forms;
using Projet_BDEcole.Classes;
using System.Configuration;

namespace BD_Ecole_JS
{
    public partial class GestionSchedule : Form
    {
        
        DataTable dtSchedule;
        BindingSource bsSchedule;
        string sConnection;
        public GestionSchedule()
        {
            
            InitializeComponent();
            sConnection = ConfigurationManager.ConnectionStrings["BD_Ecole_JS.Properties.Settings.ConnectionString_Couche"].ConnectionString;
            FillDGV();
            if (dgvSchedule.Rows.Count > 0)
                Activer(true);
            else
                Activer(false);

            dtpStartTime.CustomFormat = "hh:mm";
            dtpDuration.CustomFormat = "hh:mm";
        }

        private void Gestion_Schedule_Load(object sender, EventArgs e)
        {
            var lTmp = new G_T_Class(sConnection).Lire("N");
            foreach (var p in lTmp)
            {
                string tmp = (p.ClassID + "- " + p.ClName + " " + p.ClLevel).ToString();
                cbClId.Items.Add(tmp);
            }
            var lTmp2 = new G_T_Course(sConnection).Lire("N");
            foreach (var p in lTmp2)
            {
                string tmp = (p.CourseID + "- " + p.CoName).ToString();
                cbCoId.Items.Add(tmp);
            }
            if (cbClId.Items.Count == 0 || cbCoId.Items.Count == 0)
            {
                if (MessageBox.Show("No course or class added, " +
                    "check in course and class tab to make sure there available classes", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error) == DialogResult.OK)
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
            dtSchedule = new DataTable();
            dtSchedule.Columns.Add(new DataColumn("ScheduleID", Type.GetType("System.Int32")));
            dtSchedule.Columns.Add(new DataColumn("SchDuration"));
            dtSchedule.Columns.Add(new DataColumn("SchDate"));
            dtSchedule.Columns.Add(new DataColumn("SchStartTime"));
            dtSchedule.Columns.Add(new DataColumn("ClassID"));
            dtSchedule.Columns.Add(new DataColumn("CourseID"));

            List<C_T_Schedule> lTmp = new G_T_Schedule(sConnection).Lire("N");
            foreach (var p in lTmp)
            {
               
                dtSchedule.Rows.Add(p.ScheduleID, p.SchDuration, p.SchDate.ToShortDateString(), p.SchStart_Time.ToShortTimeString(), p.ClassID, p.CourseID);
            }
            bsSchedule = new BindingSource();
            bsSchedule.DataSource = dtSchedule;
            dgvSchedule.DataSource = bsSchedule;
        }

        void Activer(bool lPrincipal)
        {
            dgvSchedule.Enabled = lPrincipal;
            bAdd.Enabled = bModi.Enabled = bDel.Enabled = lPrincipal;
            cbClId.Enabled = cbCoId.Enabled = dtpDate.Enabled = dtpDuration.Enabled = dtpStartTime.Enabled = !lPrincipal;
            bConf.Enabled = bCan.Enabled = !lPrincipal;
        }

        void RemoveSchedule()
        {
            int iID = (int)dgvSchedule.SelectedRows[0].Cells["ScheduleID"].Value;
            new G_T_Schedule(sConnection).Supprimer(iID);
            bsSchedule.RemoveCurrent();
        }

        void AddSchedule(TimeSpan duration, DateTime date, DateTime starttime, int ClassID, int CourseID)
        {
            //startyime is going to behave weirdly
            int iID = new G_T_Schedule(sConnection).Ajouter(duration, date, starttime, ClassID, CourseID);
            tbId.Text = iID.ToString();
          
            int totalMinutes = Convert.ToInt32(duration.Minutes);
            dtSchedule.Rows.Add(totalMinutes, date.ToShortDateString(), starttime.ToString(), ClassID, CourseID);
        }

        private void bAdd_Click(object sender, EventArgs e)
        {
            tbId.Text = cbClId.Text = cbCoId.Text = "";
            Activer(false);
        }

        private void bModi_Click(object sender, EventArgs e)
        {
            if (dgvSchedule.SelectedRows.Count > 0)
            {
                tbId.Text = dgvSchedule.SelectedRows[0].Cells["ScheduleID"].Value.ToString();
                var pTmp = new G_T_Schedule(sConnection).Lire_ID(int.Parse(tbId.Text));
                cbClId.Text = pTmp.ClassID.ToString();
                cbCoId.Text = pTmp.CourseID.ToString();
                Activer(false);
            }
            else
            {
                MessageBox.Show("Please select a row");
            }
        }

        private void bDel_Click(object sender, EventArgs e)
        {
            if (dgvSchedule.SelectedRows.Count > 0)
                if (MessageBox.Show("Confirm delete", "Are you fucking sure??", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                    RemoveSchedule();
        }

        private void bCan_Click(object sender, EventArgs e)
        {
            Activer(true);
        }

        private void bConf_Click(object sender, EventArgs e)
        {
            if (cbClId.Text.Trim() == "")
                MessageBox.Show("Please put a ClassID");
            else
            {
                if (tbId.Text == "")
                //Ajout
                {

                    AddSchedule(dtpDuration.Value.TimeOfDay,dtpDate.Value,dtpStartTime.Value,
                        Convert_CB_to_Int(cbClId.SelectedItem.ToString()), Convert_CB_to_Int(cbCoId.SelectedItem.ToString()));
                }
                else
                //Modification
                {
                    new G_T_Schedule(sConnection).Modifier(int.Parse(tbId.Text), dtpDuration.Value.TimeOfDay, dtpDate.Value, dtpStartTime.Value,
                        Convert_CB_to_Int(cbClId.Text.ToString()), Convert_CB_to_Int(cbCoId.Text.ToString()));
                    
                    bsSchedule.EndEdit();

                }
                Activer(true);
                FillDGV();
            }



        }
    }
}
