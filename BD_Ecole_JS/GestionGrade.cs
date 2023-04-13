﻿using Projet_BDEcole.Classes;
using Projet_BDEcole.Gestion;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Windows.Forms;

namespace BD_Ecole_JS
{
    public partial class GestionGrade : Form
    {
        DataTable dtGrade;
        BindingSource bsGrade;
        string sConnection;

        public GestionGrade()
        {
            InitializeComponent();
            sConnection = ConfigurationManager.ConnectionStrings["BD_Ecole_JS.Properties.Settings.ConnectionString_Couche"].ConnectionString;
            FillDGV();
            if (dgvGrade.Rows.Count > 0)
                Activer(true);
            else
                Activer(false);
        }

        private void GestionGrade_Load(object sender, EventArgs e)
        {
            var lTmp = new G_T_Association(sConnection).Lire("N");
            foreach (var p in lTmp)
            {
                string tmp = (p.AssociationID + "- " + CourseName(p) + " - " + StudentName(p)).ToString();
                cbAId.Items.Add(tmp);
            }
            if (cbAId.Items.Count == 0)
            {
                if (MessageBox.Show("No assoction table found", "Error",
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
            dtGrade = new DataTable();
            dtGrade.Columns.Add(new DataColumn("GId", Type.GetType("System.Int32")));
            dtGrade.Columns.Add(new DataColumn("GName"));
            dtGrade.Columns.Add(new DataColumn("Gscore"));
            dtGrade.Columns.Add(new DataColumn("GDate"));
            dtGrade.Columns.Add(new DataColumn("AId"));
            dtGrade.Columns.Add(new DataColumn("StName"));
            dtGrade.Columns.Add(new DataColumn("CoName"));


            List<C_T_Grade> lTmp = new G_T_Grade(sConnection).Lire("N");
            foreach (var p in lTmp)
            {
                dtGrade.Rows.Add(p.GradeID, p.GName, p.Gscore, p.GDate, p.AssociationID, StudentName(p), CourseName(p));
            }
            bsGrade = new BindingSource();
            bsGrade.DataSource = dtGrade;
            dgvGrade.DataSource = bsGrade;
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

        string CourseName(C_T_Association p)
        {
            var tmp = new G_T_Association(sConnection).Lire_ID(p.AssociationID).CourseID;
            return new G_T_Course(sConnection).Lire_ID(tmp).CoName;
        }

        string StudentName(C_T_Association p)
        {
            var tmp = new G_T_Association(sConnection).Lire_ID(p.AssociationID).StudentID;
            return new G_T_Student(sConnection).Lire_ID(tmp).SName + " " + new G_T_Student(sConnection).Lire_ID(tmp).SSurname;
        }

        string CourseName(C_T_Grade p)
        {
            var tmp = new G_T_Association(sConnection).Lire_ID(p.AssociationID).CourseID;
            return new G_T_Course(sConnection).Lire_ID(tmp).CoName;
        }

        string StudentName(C_T_Grade p)
        {
            var tmp = new G_T_Association(sConnection).Lire_ID(p.AssociationID).StudentID;
            return new G_T_Student(sConnection).Lire_ID(tmp).SName + " " + new G_T_Student(sConnection).Lire_ID(tmp).SSurname;
        }

        void Activer(bool lPrincipal)
        {
            dgvGrade.Enabled = lPrincipal;
            bAdd.Enabled = bModi.Enabled = bDel.Enabled = lPrincipal;
            tbName.Enabled = cbAId.Enabled = dtpDate.Enabled = tbScore.Enabled = !lPrincipal;
            bConf.Enabled = bCan.Enabled = !lPrincipal;
        }

        void RemoveGrade()
        {
            int iID = (int)dgvGrade.SelectedRows[0].Cells["GId"].Value;
            new G_T_Grade(sConnection).Supprimer(iID);
            bsGrade.RemoveCurrent();
        }

        void AddGrade(string name, int score, DateTime date, int aid)
        {
            int iID = new G_T_Grade(sConnection).Ajouter(name, score, date, aid);
            tbId.Text = iID.ToString();

            dtGrade.Rows.Add(iID, name, score, date.ToShortDateString(), aid);
        }

        private void bAdd_Click(object sender, EventArgs e)
        {
            tbId.Text = tbName.Text = tbScore.Text = cbAId.Text = "";
            dtpDate.Value = DateTime.Today;
            Activer(false);
        }

        private void bModi_Click(object sender, EventArgs e)
        {
            if (dgvGrade.SelectedRows.Count > 0)
            {
                tbId.Text = dgvGrade.SelectedRows[0].Cells["GId"].Value.ToString();
                var pTmp = new G_T_Grade(sConnection).Lire_ID(int.Parse(tbId.Text));
                tbName.Text = pTmp.GName.ToString();
                cbAId.Text = pTmp.AssociationID.ToString();
                dtpDate.Value = GDateIfNull(pTmp);
                cbAId.Text = pTmp.AssociationID.ToString();
                Activer(false);
            }
            else
            {
                MessageBox.Show("Please select a row");
            }
        }

        private void bDel_Click(object sender, EventArgs e)
        {
            if (dgvGrade.SelectedRows.Count > 0)
                if (MessageBox.Show("Confirm delete", "Are you fucking sure??", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                    RemoveGrade();
        }

        private void bCan_Click(object sender, EventArgs e)
        {
            Activer(true);
        }

        private void bConf_Click(object sender, EventArgs e)
        {
            if (tbName.Text.Trim() == "")
                MessageBox.Show("Please put a Name");
            else
            {

                if (tbId.Text == "")
                //Ajout
                {
                    AddGrade(tbName.Text, int.Parse(tbScore.Text), dtpDate.Value, Convert_CB_to_Int(cbAId.SelectedItem.ToString()));
                }
                else
                //Modification
                {
                    new G_T_Grade(sConnection).Modifier(int.Parse(tbId.Text), tbName.Text, int.Parse(tbScore.Text), dtpDate.Value, Convert_CB_to_Int(cbAId.SelectedItem.ToString()));
                    bsGrade.EndEdit();
                }
                Activer(true);
                FillDGV();
            }



        }


    }
}

