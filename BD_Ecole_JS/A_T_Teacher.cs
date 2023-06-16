#region Ressources extérieures
using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using Projet_BDEcole.Classes;
#endregion

namespace Projet_BDEcole.Acces
{
    /// <summary>
    /// Couche d'accès aux données (Data Access Layer)
    /// </summary>
    public class A_T_Teacher : ADBase
    {
        #region Constructeurs
        public A_T_Teacher(string sChaineConnexion)
            : base(sChaineConnexion)
        { }
        #endregion
        public int Ajouter(string TName, string TSurname, DateTime TDoB, string TEmail, string TDiploma)
        {
            CreerCommande("AjouterT_Teacher");
            int res = 0;
            Commande.Parameters.Add("TeacherID", SqlDbType.Int);
            Direction("TeacherID", ParameterDirection.Output);
            Commande.Parameters.AddWithValue("@TName", TName);
            Commande.Parameters.AddWithValue("@TSurname", TSurname);
            Commande.Parameters.AddWithValue("@TDoB", TDoB);
            Commande.Parameters.AddWithValue("@TEmail", TEmail);
            Commande.Parameters.AddWithValue("@TDiploma", TDiploma);
            Commande.Connection.Open();
            Commande.ExecuteNonQuery();
            res = int.Parse(LireParametre("TeacherID"));
            Commande.Connection.Close();
            return res;
        }
        public int Modifier(int TeacherID, string TName, string TSurname, DateTime TDoB, string TEmail, string TDiploma)
        {
            CreerCommande("ModifierT_Teacher");
            int res = 0;
            Commande.Parameters.AddWithValue("@TeacherID", TeacherID);
            Commande.Parameters.AddWithValue("@TName", TName);
            Commande.Parameters.AddWithValue("@TSurname", TSurname);
            Commande.Parameters.AddWithValue("@TDoB", TDoB);
            Commande.Parameters.AddWithValue("@TEmail", TEmail);
            Commande.Parameters.AddWithValue("@TDiploma", TDiploma);
            Commande.Connection.Open();
            Commande.ExecuteNonQuery();
            Commande.Connection.Close();
            return res;
        }
        public List<C_T_Teacher> Lire(string Index)
        {
            CreerCommande("SelectionnerT_Teacher");
            Commande.Parameters.AddWithValue("@Index", Index);
            Commande.Connection.Open();
            SqlDataReader dr = Commande.ExecuteReader();
            List<C_T_Teacher> res = new List<C_T_Teacher>();
            while (dr.Read())
            {
                C_T_Teacher tmp = new C_T_Teacher();
                tmp.TeacherID = int.Parse(dr["TeacherID"].ToString());
                tmp.TName = dr["TName"].ToString();
                tmp.TSurname = dr["TSurname"].ToString();
                tmp.TDoB = DateTime.Parse(dr["TDoB"].ToString());
                tmp.TEmail = dr["TEmail"].ToString();
                if (dr["TDiploma"] != DBNull.Value) tmp.TDiploma = dr["TDiploma"].ToString();
                res.Add(tmp);
            }
            dr.Close();
            Commande.Connection.Close();
            return res;
        }
        public C_T_Teacher Lire_ID(int TeacherID)
        {
            CreerCommande("SelectionnerT_Teacher_ID");
            Commande.Parameters.AddWithValue("@TeacherID", TeacherID);
            Commande.Connection.Open();
            SqlDataReader dr = Commande.ExecuteReader();
            C_T_Teacher res = new C_T_Teacher();
            while (dr.Read())
            {
                res.TeacherID = int.Parse(dr["TeacherID"].ToString());
                res.TName = dr["TName"].ToString();
                res.TSurname = dr["TSurname"].ToString();
                res.TDoB = DateTime.Parse(dr["TDoB"].ToString());
                res.TEmail = dr["TEmail"].ToString();
                if (dr["TDiploma"] != DBNull.Value) res.TDiploma = dr["TDiploma"].ToString();
            }
            dr.Close();
            Commande.Connection.Close();
            return res;
        }
        public int Supprimer(int TeacherID)
        {
            CreerCommande("SupprimerT_Teacher");
            int res = 0;
            Commande.Parameters.AddWithValue("@TeacherID", TeacherID);
            Commande.Connection.Open();
            res = Commande.ExecuteNonQuery();
            Commande.Connection.Close();
            return res;
        }
    }
}
