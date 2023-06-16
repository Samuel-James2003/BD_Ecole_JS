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
 public class G_T_Teacher : G_Base
 {
  #region Constructeurs
  public G_T_Teacher()
   : base()
  { }
  public G_T_Teacher(string sChaineConnexion)
   : base(sChaineConnexion)
  { }
  #endregion
  public int Ajouter(string TName, string TSurname, DateTime TDoB, string TEmail,string TDiploma)
  { return new A_T_Teacher(ChaineConnexion).Ajouter(TName, TSurname, TDoB, TEmail, TDiploma); }
  public int Modifier(int TeacherID, string TName, string TSurname, DateTime TDoB, string TEmail, string TDiploma)
  { return new A_T_Teacher(ChaineConnexion).Modifier(TeacherID, TName, TSurname, TDoB, TEmail, TDiploma); }
  public List<C_T_Teacher> Lire(string Index)
  { return new A_T_Teacher(ChaineConnexion).Lire(Index); }
  public C_T_Teacher Lire_ID(int TeacherID)
  { return new A_T_Teacher(ChaineConnexion).Lire_ID(TeacherID); }
  public int Supprimer(int TeacherID)
  { return new A_T_Teacher(ChaineConnexion).Supprimer(TeacherID); }
 }
}
