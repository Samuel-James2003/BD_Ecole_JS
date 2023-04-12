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
 public class G_T_Association : G_Base
 {
  #region Constructeurs
  public G_T_Association()
   : base()
  { }
  public G_T_Association(string sChaineConnexion)
   : base(sChaineConnexion)
  { }
  #endregion
  public int Ajouter(int CourseID, int StudentID)
  { return new A_T_Association(ChaineConnexion).Ajouter(CourseID, StudentID); }
  public int Modifier(int AssociationID, int CourseID, int StudentID)
  { return new A_T_Association(ChaineConnexion).Modifier(AssociationID, CourseID, StudentID); }
  public List<C_T_Association> Lire(string Index)
  { return new A_T_Association(ChaineConnexion).Lire(Index); }
  public C_T_Association Lire_ID(int AssociationID)
  { return new A_T_Association(ChaineConnexion).Lire_ID(AssociationID); }
  public int Supprimer(int AssociationID)
  { return new A_T_Association(ChaineConnexion).Supprimer(AssociationID); }
 }
}
