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
 public class A_T_Student : ADBase
 {
  #region Constructeurs
  public A_T_Student(string sChaineConnexion)
  	: base(sChaineConnexion)
  { }
  #endregion
  public int Ajouter(DateTime SDoB, string SName, string SSurname, string SEmail, string SYear, string SSection)
  {
   CreerCommande("AjouterT_Student");
   int res = 0;
   Commande.Parameters.Add("StudentID", SqlDbType.Int);
   Direction("StudentID", ParameterDirection.Output);
   Commande.Parameters.AddWithValue("@SDoB", SDoB);
   if(SName == null) Commande.Parameters.AddWithValue("@SName", Convert.DBNull);
   else Commande.Parameters.AddWithValue("@SName", SName);
   Commande.Parameters.AddWithValue("@SSurname", SSurname);
   if(SEmail == null) Commande.Parameters.AddWithValue("@SEmail", Convert.DBNull);
   else Commande.Parameters.AddWithValue("@SEmail", SEmail);
   Commande.Parameters.AddWithValue("@SYear", SYear);
   Commande.Parameters.AddWithValue("@SSection", SSection);
   Commande.Connection.Open();
   Commande.ExecuteNonQuery();
   res = int.Parse(LireParametre("StudentID"));
   Commande.Connection.Close();
   return res;
  }
  public int Modifier(int StudentID, DateTime SDoB, string SName, string SSurname, string SEmail, string SYear, string SSection)
  {
   CreerCommande("ModifierT_Student");
   int res = 0;
   Commande.Parameters.AddWithValue("@StudentID", StudentID);
   Commande.Parameters.AddWithValue("@SDoB", SDoB);
   if(SName == null) Commande.Parameters.AddWithValue("@SName", Convert.DBNull);
   else Commande.Parameters.AddWithValue("@SName", SName);
   Commande.Parameters.AddWithValue("@SSurname", SSurname);
   if(SEmail == null) Commande.Parameters.AddWithValue("@SEmail", Convert.DBNull);
   else Commande.Parameters.AddWithValue("@SEmail", SEmail);
   Commande.Parameters.AddWithValue("@SYear", SYear);
   Commande.Parameters.AddWithValue("@SSection", SSection);
   Commande.Connection.Open();
   Commande.ExecuteNonQuery();
   Commande.Connection.Close();
   return res;
  }
  public List<C_T_Student> Lire(string Index)
  {
   CreerCommande("SelectionnerT_Student");
   Commande.Parameters.AddWithValue("@Index", Index);
   Commande.Connection.Open();
   SqlDataReader dr = Commande.ExecuteReader();
   List<C_T_Student> res = new List<C_T_Student>();
   while (dr.Read())
   {
    C_T_Student tmp = new C_T_Student();
    tmp.StudentID = int.Parse(dr["StudentID"].ToString());
    tmp.SDoB = DateTime.Parse(dr["SDoB"].ToString());
    tmp.SName = dr["SName"].ToString();
    tmp.SSurname = dr["SSurname"].ToString();
    tmp.SEmail = dr["SEmail"].ToString();
    tmp.SYear = dr["SYear"].ToString();
    tmp.SSection = dr["SSection"].ToString();
    res.Add(tmp);
			}
			dr.Close();
			Commande.Connection.Close();
			return res;
		}
  public C_T_Student Lire_ID(int StudentID)
  {
   CreerCommande("SelectionnerT_Student_ID");
   Commande.Parameters.AddWithValue("@StudentID", StudentID);
   Commande.Connection.Open();
   SqlDataReader dr = Commande.ExecuteReader();
   C_T_Student res = new C_T_Student();
   while (dr.Read())
   {
    res.StudentID = int.Parse(dr["StudentID"].ToString());
    res.SDoB = DateTime.Parse(dr["SDoB"].ToString());
    res.SName = dr["SName"].ToString();
    res.SSurname = dr["SSurname"].ToString();
    res.SEmail = dr["SEmail"].ToString();
    res.SYear = dr["SYear"].ToString();
    res.SSection = dr["SSection"].ToString();
   }
			dr.Close();
			Commande.Connection.Close();
			return res;
		}
  public int Supprimer(int StudentID)
  {
   CreerCommande("SupprimerT_Student");
   int res = 0;
   Commande.Parameters.AddWithValue("@StudentID", StudentID);
   Commande.Connection.Open();
   res = Commande.ExecuteNonQuery();
			Commande.Connection.Close();
			return res;
		}
 }
}
