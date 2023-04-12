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
 public class G_T_Course : G_Base
 {
  #region Constructeurs
  public G_T_Course()
   : base()
  { }
  public G_T_Course(string sChaineConnexion)
   : base(sChaineConnexion)
  { }
  #endregion
  public int Ajouter(string CoName, int TeacherID)
  { return new A_T_Course(ChaineConnexion).Ajouter(CoName, TeacherID); }
  public int Modifier(int CourseID, string CoName, int TeacherID)
  { return new A_T_Course(ChaineConnexion).Modifier(CourseID, CoName, TeacherID); }
  public List<C_T_Course> Lire(string Index)
  { return new A_T_Course(ChaineConnexion).Lire(Index); }
  public C_T_Course Lire_ID(int CourseID)
  { return new A_T_Course(ChaineConnexion).Lire_ID(CourseID); }
  public int Supprimer(int CourseID)
  { return new A_T_Course(ChaineConnexion).Supprimer(CourseID); }
 }
}
