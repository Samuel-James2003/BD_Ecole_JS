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
 public class G_T_Class : G_Base
 {
  #region Constructeurs
  public G_T_Class()
   : base()
  { }
  public G_T_Class(string sChaineConnexion)
   : base(sChaineConnexion)
  { }
  #endregion
  public int Ajouter(string ClName, string ClLevel)
  { return new A_T_Class(ChaineConnexion).Ajouter(ClName, ClLevel); }
  public int Modifier(int ClassID, string ClName, string ClLevel)
  { return new A_T_Class(ChaineConnexion).Modifier(ClassID, ClName, ClLevel); }
  public List<C_T_Class> Lire(string Index)
  { return new A_T_Class(ChaineConnexion).Lire(Index); }
  public C_T_Class Lire_ID(int ClassID)
  { return new A_T_Class(ChaineConnexion).Lire_ID(ClassID); }
  public int Supprimer(int ClassID)
  { return new A_T_Class(ChaineConnexion).Supprimer(ClassID); }
 }
}
