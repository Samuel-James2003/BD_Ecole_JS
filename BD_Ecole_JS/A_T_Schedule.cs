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
 public class A_T_Schedule : ADBase
 {
  #region Constructeurs
  public A_T_Schedule(string sChaineConnexion)
  	: base(sChaineConnexion)
  { }
  #endregion
  public int Ajouter(TimeSpan SchDuration, DateTime SchDate, DateTime SchStart_Time, int ClassID, int? CourseID)
  {
   CreerCommande("AjouterT_Schedule");
   int res = 0;
   Commande.Parameters.Add("ScheduleID", SqlDbType.Int);
   Direction("ScheduleID", ParameterDirection.Output);
   Commande.Parameters.AddWithValue("@SchDuration", SchDuration);
   Commande.Parameters.AddWithValue("@SchDate", SchDate);
   Commande.Parameters.AddWithValue("@SchStart_Time", SchStart_Time);
   Commande.Parameters.AddWithValue("@ClassID", ClassID);
   if(CourseID == null) Commande.Parameters.AddWithValue("@CourseID", Convert.DBNull);
   else Commande.Parameters.AddWithValue("@CourseID", CourseID);
   Commande.Connection.Open();
   Commande.ExecuteNonQuery();
   res = int.Parse(LireParametre("ScheduleID"));
   Commande.Connection.Close();
   return res;
  }
  public int Modifier(int ScheduleID, TimeSpan SchDuration, DateTime SchDate, DateTime SchStart_Time, int ClassID, int? CourseID)
  {
   CreerCommande("ModifierT_Schedule");
   int res = 0;
   Commande.Parameters.AddWithValue("@ScheduleID", ScheduleID);
   Commande.Parameters.AddWithValue("@SchDuration", SchDuration);
   Commande.Parameters.AddWithValue("@SchDate", SchDate);
   Commande.Parameters.AddWithValue("@SchStart_Time", SchStart_Time);
   Commande.Parameters.AddWithValue("@ClassID", ClassID);
   if(CourseID == null) Commande.Parameters.AddWithValue("@CourseID", Convert.DBNull);
   else Commande.Parameters.AddWithValue("@CourseID", CourseID);
   Commande.Connection.Open();
   Commande.ExecuteNonQuery();
   Commande.Connection.Close();
   return res;
  }
  public List<C_T_Schedule> Lire(string Index)
  {
   CreerCommande("SelectionnerT_Schedule");
   Commande.Parameters.AddWithValue("@Index", Index);
   Commande.Connection.Open();
   SqlDataReader dr = Commande.ExecuteReader();
   List<C_T_Schedule> res = new List<C_T_Schedule>();
   while (dr.Read())
   {
    C_T_Schedule tmp = new C_T_Schedule();
    tmp.ScheduleID = int.Parse(dr["ScheduleID"].ToString());
    tmp.SchDuration = TimeSpan.Parse(dr["SchDuration"].ToString());
    tmp.SchDate = DateTime.Parse(dr["SchDate"].ToString());
    tmp.SchStart_Time = DateTime.Parse(dr["SchStart_Time"].ToString());
    tmp.ClassID = int.Parse(dr["ClassID"].ToString());
   if(dr["CourseID"] != DBNull.Value) tmp.CourseID = int.Parse(dr["CourseID"].ToString());
    res.Add(tmp);
			}
			dr.Close();
			Commande.Connection.Close();
			return res;
		}
  public C_T_Schedule Lire_ID(int ScheduleID)
  {
   CreerCommande("SelectionnerT_Schedule_ID");
   Commande.Parameters.AddWithValue("@ScheduleID", ScheduleID);
   Commande.Connection.Open();
   SqlDataReader dr = Commande.ExecuteReader();
   C_T_Schedule res = new C_T_Schedule();
   while (dr.Read())
   {
    res.ScheduleID = int.Parse(dr["ScheduleID"].ToString());
    res.SchDuration = TimeSpan.Parse(dr["SchDuration"].ToString());
    res.SchDate = DateTime.Parse(dr["SchDate"].ToString());
    res.SchStart_Time = DateTime.Parse(dr["SchStart_Time"].ToString());
    res.ClassID = int.Parse(dr["ClassID"].ToString());
   if(dr["CourseID"] != DBNull.Value) res.CourseID = int.Parse(dr["CourseID"].ToString());
   }
			dr.Close();
			Commande.Connection.Close();
			return res;
		}
  public int Supprimer(int ScheduleID)
  {
   CreerCommande("SupprimerT_Schedule");
   int res = 0;
   Commande.Parameters.AddWithValue("@ScheduleID", ScheduleID);
   Commande.Connection.Open();
   res = Commande.ExecuteNonQuery();
			Commande.Connection.Close();
			return res;
		}
 }
}
