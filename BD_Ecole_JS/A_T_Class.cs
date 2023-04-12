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
 public class A_T_Class : ADBase
 {
  #region Constructeurs
  public A_T_Class(string sChaineConnexion)
  	: base(sChaineConnexion)
  { }
  #endregion
  public int Ajouter(string ClName, string ClLevel)
  {
   CreerCommande("AjouterT_Class");
   int res = 0;
   Commande.Parameters.Add("ClassID", SqlDbType.Int);
   Direction("ClassID", ParameterDirection.Output);
   if(ClName == null) Commande.Parameters.AddWithValue("@ClName", Convert.DBNull);
   else Commande.Parameters.AddWithValue("@ClName", ClName);
   Commande.Parameters.AddWithValue("@ClLevel", ClLevel);
   Commande.Connection.Open();
   Commande.ExecuteNonQuery();
   res = int.Parse(LireParametre("ClassID"));
   Commande.Connection.Close();
   return res;
  }
  public int Modifier(int ClassID, string ClName, string ClLevel)
  {
   CreerCommande("ModifierT_Class");
   int res = 0;
   Commande.Parameters.AddWithValue("@ClassID", ClassID);
   if(ClName == null) Commande.Parameters.AddWithValue("@ClName", Convert.DBNull);
   else Commande.Parameters.AddWithValue("@ClName", ClName);
   Commande.Parameters.AddWithValue("@ClLevel", ClLevel);
   Commande.Connection.Open();
   Commande.ExecuteNonQuery();
   Commande.Connection.Close();
   return res;
  }
  public List<C_T_Class> Lire(string Index)
  {
   CreerCommande("SelectionnerT_Class");
   Commande.Parameters.AddWithValue("@Index", Index);
   Commande.Connection.Open();
   SqlDataReader dr = Commande.ExecuteReader();
   List<C_T_Class> res = new List<C_T_Class>();
   while (dr.Read())
   {
    C_T_Class tmp = new C_T_Class();
    tmp.ClassID = int.Parse(dr["ClassID"].ToString());
    tmp.ClName = dr["ClName"].ToString();
    tmp.ClLevel = dr["ClLevel"].ToString();
    res.Add(tmp);
			}
			dr.Close();
			Commande.Connection.Close();
			return res;
		}
  public C_T_Class Lire_ID(int ClassID)
  {
   CreerCommande("SelectionnerT_Class_ID");
   Commande.Parameters.AddWithValue("@ClassID", ClassID);
   Commande.Connection.Open();
   SqlDataReader dr = Commande.ExecuteReader();
   C_T_Class res = new C_T_Class();
   while (dr.Read())
   {
    res.ClassID = int.Parse(dr["ClassID"].ToString());
    res.ClName = dr["ClName"].ToString();
    res.ClLevel = dr["ClLevel"].ToString();
   }
			dr.Close();
			Commande.Connection.Close();
			return res;
		}
  public int Supprimer(int ClassID)
  {
   CreerCommande("SupprimerT_Class");
   int res = 0;
   Commande.Parameters.AddWithValue("@ClassID", ClassID);
   Commande.Connection.Open();
   res = Commande.ExecuteNonQuery();
			Commande.Connection.Close();
			return res;
		}
 }
}
