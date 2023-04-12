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
 public class A_T_Course : ADBase
 {
  #region Constructeurs
  public A_T_Course(string sChaineConnexion)
  	: base(sChaineConnexion)
  { }
  #endregion
  public int Ajouter(string CoName, int TeacherID)
  {
   CreerCommande("AjouterT_Course");
   int res = 0;
   Commande.Parameters.Add("CourseID", SqlDbType.Int);
   Direction("CourseID", ParameterDirection.Output);
   Commande.Parameters.AddWithValue("@CoName", CoName);
   Commande.Parameters.AddWithValue("@TeacherID", TeacherID);
   Commande.Connection.Open();
   Commande.ExecuteNonQuery();
   res = int.Parse(LireParametre("CourseID"));
   Commande.Connection.Close();
   return res;
  }
  public int Modifier(int CourseID, string CoName, int TeacherID)
  {
   CreerCommande("ModifierT_Course");
   int res = 0;
   Commande.Parameters.AddWithValue("@CourseID", CourseID);
   Commande.Parameters.AddWithValue("@CoName", CoName);
   Commande.Parameters.AddWithValue("@TeacherID", TeacherID);
   Commande.Connection.Open();
   Commande.ExecuteNonQuery();
   Commande.Connection.Close();
   return res;
  }
  public List<C_T_Course> Lire(string Index)
  {
   CreerCommande("SelectionnerT_Course");
   Commande.Parameters.AddWithValue("@Index", Index);
   Commande.Connection.Open();
   SqlDataReader dr = Commande.ExecuteReader();
   List<C_T_Course> res = new List<C_T_Course>();
   while (dr.Read())
   {
    C_T_Course tmp = new C_T_Course();
    tmp.CourseID = int.Parse(dr["CourseID"].ToString());
    tmp.CoName = dr["CoName"].ToString();
    tmp.TeacherID = int.Parse(dr["TeacherID"].ToString());
    res.Add(tmp);
			}
			dr.Close();
			Commande.Connection.Close();
			return res;
		}
  public C_T_Course Lire_ID(int CourseID)
  {
   CreerCommande("SelectionnerT_Course_ID");
   Commande.Parameters.AddWithValue("@CourseID", CourseID);
   Commande.Connection.Open();
   SqlDataReader dr = Commande.ExecuteReader();
   C_T_Course res = new C_T_Course();
   while (dr.Read())
   {
    res.CourseID = int.Parse(dr["CourseID"].ToString());
    res.CoName = dr["CoName"].ToString();
    res.TeacherID = int.Parse(dr["TeacherID"].ToString());
   }
			dr.Close();
			Commande.Connection.Close();
			return res;
		}
  public int Supprimer(int CourseID)
  {
   CreerCommande("SupprimerT_Course");
   int res = 0;
   Commande.Parameters.AddWithValue("@CourseID", CourseID);
   Commande.Connection.Open();
   res = Commande.ExecuteNonQuery();
			Commande.Connection.Close();
			return res;
		}
 }
}
