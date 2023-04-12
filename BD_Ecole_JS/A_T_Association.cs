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
 public class A_T_Association : ADBase
 {
  #region Constructeurs
  public A_T_Association(string sChaineConnexion)
  	: base(sChaineConnexion)
  { }
  #endregion
  public int Ajouter(int CourseID, int StudentID)
  {
   CreerCommande("AjouterT_Association");
   int res = 0;
   Commande.Parameters.Add("AssociationID", SqlDbType.Int);
   Direction("AssociationID", ParameterDirection.Output);
   Commande.Parameters.AddWithValue("@CourseID", CourseID);
   Commande.Parameters.AddWithValue("@StudentID", StudentID);
   Commande.Connection.Open();
   Commande.ExecuteNonQuery();
   res = int.Parse(LireParametre("AssociationID"));
   Commande.Connection.Close();
   return res;
  }
  public int Modifier(int AssociationID, int CourseID, int StudentID)
  {
   CreerCommande("ModifierT_Association");
   int res = 0;
   Commande.Parameters.AddWithValue("@AssociationID", AssociationID);
   Commande.Parameters.AddWithValue("@CourseID", CourseID);
   Commande.Parameters.AddWithValue("@StudentID", StudentID);
   Commande.Connection.Open();
   Commande.ExecuteNonQuery();
   Commande.Connection.Close();
   return res;
  }
  public List<C_T_Association> Lire(string Index)
  {
   CreerCommande("SelectionnerT_Association");
   Commande.Parameters.AddWithValue("@Index", Index);
   Commande.Connection.Open();
   SqlDataReader dr = Commande.ExecuteReader();
   List<C_T_Association> res = new List<C_T_Association>();
   while (dr.Read())
   {
    C_T_Association tmp = new C_T_Association();
    tmp.AssociationID = int.Parse(dr["AssociationID"].ToString());
    tmp.CourseID = int.Parse(dr["CourseID"].ToString());
    tmp.StudentID = int.Parse(dr["StudentID"].ToString());
    res.Add(tmp);
			}
			dr.Close();
			Commande.Connection.Close();
			return res;
		}
  public C_T_Association Lire_ID(int AssociationID)
  {
   CreerCommande("SelectionnerT_Association_ID");
   Commande.Parameters.AddWithValue("@AssociationID", AssociationID);
   Commande.Connection.Open();
   SqlDataReader dr = Commande.ExecuteReader();
   C_T_Association res = new C_T_Association();
   while (dr.Read())
   {
    res.AssociationID = int.Parse(dr["AssociationID"].ToString());
    res.CourseID = int.Parse(dr["CourseID"].ToString());
    res.StudentID = int.Parse(dr["StudentID"].ToString());
   }
			dr.Close();
			Commande.Connection.Close();
			return res;
		}
  public int Supprimer(int AssociationID)
  {
   CreerCommande("SupprimerT_Association");
   int res = 0;
   Commande.Parameters.AddWithValue("@AssociationID", AssociationID);
   Commande.Connection.Open();
   res = Commande.ExecuteNonQuery();
			Commande.Connection.Close();
			return res;
		}
 }
}
