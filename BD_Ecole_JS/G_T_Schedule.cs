#region Ressources extérieures
using System;
using System.Collections.Generic;
using System.Text;
using Projet_BDEcole.Classes;
using Projet_BDEcole.Acces;
#endregion

namespace Projet_BDEcole.Gestion
{
 /// <summary>
 /// Couche intermédiaire de gestion (Business Layer)
 /// </summary>
 public class G_T_Schedule : G_Base
 {
  #region Constructeurs
  public G_T_Schedule()
   : base()
  { }
  public G_T_Schedule(string sChaineConnexion)
   : base(sChaineConnexion)
  { }
  #endregion
  public int Ajouter(TimeSpan SchDuration, DateTime SchDate, DateTime SchStart_Time, int ClassID, int? CourseID)
  { return new A_T_Schedule(ChaineConnexion).Ajouter(SchDuration, SchDate, SchStart_Time, ClassID, CourseID); }
  public int Modifier(int ScheduleID, TimeSpan SchDuration, DateTime SchDate, DateTime SchStart_Time, int ClassID, int? CourseID)
  { return new A_T_Schedule(ChaineConnexion).Modifier(ScheduleID, SchDuration, SchDate, SchStart_Time, ClassID, CourseID); }
  public List<C_T_Schedule> Lire(string Index)
  { return new A_T_Schedule(ChaineConnexion).Lire(Index); }
  public C_T_Schedule Lire_ID(int ScheduleID)
  { return new A_T_Schedule(ChaineConnexion).Lire_ID(ScheduleID); }
  public int Supprimer(int ScheduleID)
  { return new A_T_Schedule(ChaineConnexion).Supprimer(ScheduleID); }
 }
}
