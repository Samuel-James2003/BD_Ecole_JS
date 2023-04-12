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
 public class G_T_Grade : G_Base
 {
  #region Constructeurs
  public G_T_Grade()
   : base()
  { }
  public G_T_Grade(string sChaineConnexion)
   : base(sChaineConnexion)
  { }
  #endregion
  public int Ajouter(string GName, int Gscore, DateTime? GDate, int AssociationID)
  { return new A_T_Grade(ChaineConnexion).Ajouter(GName, Gscore, GDate, AssociationID); }
  public int Modifier(int GradeID, string GName, int Gscore, DateTime? GDate, int AssociationID)
  { return new A_T_Grade(ChaineConnexion).Modifier(GradeID, GName, Gscore, GDate, AssociationID); }
  public List<C_T_Grade> Lire(string Index)
  { return new A_T_Grade(ChaineConnexion).Lire(Index); }
  public C_T_Grade Lire_ID(int GradeID)
  { return new A_T_Grade(ChaineConnexion).Lire_ID(GradeID); }
  public int Supprimer(int GradeID)
  { return new A_T_Grade(ChaineConnexion).Supprimer(GradeID); }
 }
}
