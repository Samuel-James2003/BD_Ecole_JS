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
 public class G_T_Student : G_Base
 {
  #region Constructeurs
  public G_T_Student()
   : base()
  { }
  public G_T_Student(string sChaineConnexion)
   : base(sChaineConnexion)
  { }
  #endregion
  public int Ajouter(DateTime SDoB, string SName, string SSurname, string SEmail, string SYear, string SSection)
  { return new A_T_Student(ChaineConnexion).Ajouter(SDoB, SName, SSurname, SEmail, SYear, SSection); }
  public int Modifier(int StudentID, DateTime SDoB, string SName, string SSurname, string SEmail, string SYear, string SSection)
  { return new A_T_Student(ChaineConnexion).Modifier(StudentID, SDoB, SName, SSurname, SEmail, SYear, SSection); }
  public List<C_T_Student> Lire(string Index)
  { return new A_T_Student(ChaineConnexion).Lire(Index); }
  public C_T_Student Lire_ID(int StudentID)
  { return new A_T_Student(ChaineConnexion).Lire_ID(StudentID); }
  public int Supprimer(int StudentID)
  { return new A_T_Student(ChaineConnexion).Supprimer(StudentID); }
 }
}
