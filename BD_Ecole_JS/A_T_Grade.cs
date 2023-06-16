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
    public class A_T_Grade : ADBase
    {
        #region Constructeurs
        public A_T_Grade(string sChaineConnexion)
            : base(sChaineConnexion)
        { }
        #endregion
        public int Ajouter(string GName, int Gscore, DateTime? GDate, int AssociationID)
        {
            CreerCommande("AjouterT_Grade");
            int res = 0;
            Commande.Parameters.Add("GradeID", SqlDbType.Int);
            Direction("GradeID", ParameterDirection.Output);
            if (GName == null) Commande.Parameters.AddWithValue("@GName", Convert.DBNull);
            else Commande.Parameters.AddWithValue("@GName", GName);
            Commande.Parameters.AddWithValue("@Gscore", Gscore);
            if (GDate == null) Commande.Parameters.AddWithValue("@GDate", Convert.DBNull);
            else Commande.Parameters.AddWithValue("@GDate", GDate);
            Commande.Parameters.AddWithValue("@AssociationID", AssociationID);
            Commande.Connection.Open();
            Commande.ExecuteNonQuery();
            res = int.Parse(LireParametre("GradeID"));
            Commande.Connection.Close();
            return res;
        }
        public int Modifier(int GradeID, string GName, int Gscore, DateTime? GDate, int AssociationID)
        {
            CreerCommande("ModifierT_Grade");
            int res = 0;
            Commande.Parameters.AddWithValue("@GradeID", GradeID);
            if (GName == null) Commande.Parameters.AddWithValue("@GName", Convert.DBNull);
            else Commande.Parameters.AddWithValue("@GName", GName);
            Commande.Parameters.AddWithValue("@Gscore", Gscore);
            if (GDate == null) Commande.Parameters.AddWithValue("@GDate", Convert.DBNull);
            else Commande.Parameters.AddWithValue("@GDate", GDate);
            Commande.Parameters.AddWithValue("@AssociationID", AssociationID);
            Commande.Connection.Open();
            Commande.ExecuteNonQuery();
            Commande.Connection.Close();
            return res;
        }
        public List<C_T_Grade> Lire(string Index)
        {
            CreerCommande("SelectionnerT_Grade");
            Commande.Parameters.AddWithValue("@Index", Index);
            Commande.Connection.Open();
            SqlDataReader dr = Commande.ExecuteReader();
            List<C_T_Grade> res = new List<C_T_Grade>();
            while (dr.Read())
            {
                C_T_Grade tmp = new C_T_Grade();
                tmp.GradeID = int.Parse(dr["GradeID"].ToString());
                tmp.GName = dr["GName"].ToString();
                tmp.Gscore = int.Parse(dr["Gscore"].ToString());
                if (dr["GDate"] != DBNull.Value) tmp.GDate = DateTime.Parse(dr["GDate"].ToString());
                tmp.AssociationID = int.Parse(dr["AssociationID"].ToString());
                res.Add(tmp);
            }
            dr.Close();
            Commande.Connection.Close();
            return res;
        }
        public C_T_Grade Lire_ID(int GradeID)
        {
            CreerCommande("SelectionnerT_Grade_ID");
            Commande.Parameters.AddWithValue("@GradeID", GradeID);
            Commande.Connection.Open();
            SqlDataReader dr = Commande.ExecuteReader();
            C_T_Grade res = new C_T_Grade();
            while (dr.Read())
            {
                res.GradeID = int.Parse(dr["GradeID"].ToString());
                res.GName = dr["GName"].ToString();
                res.Gscore = int.Parse(dr["Gscore"].ToString());
                if (dr["GDate"] != DBNull.Value) res.GDate = DateTime.Parse(dr["GDate"].ToString());
                res.AssociationID = int.Parse(dr["AssociationID"].ToString());
            }
            dr.Close();
            Commande.Connection.Close();
            return res;
        }
        public int Supprimer(int GradeID)
        {
            CreerCommande("SupprimerT_Grade");
            int res = 0;
            Commande.Parameters.AddWithValue("@GradeID", GradeID);
            Commande.Connection.Open();
            res = Commande.ExecuteNonQuery();
            Commande.Connection.Close();
            return res;
        }
    }
}
