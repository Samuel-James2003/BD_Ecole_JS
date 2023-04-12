#region Ressources extérieures
using System;
using System.Collections.Generic;
using System.Text;
#endregion

namespace Projet_BDEcole.Classes
{
 /// <summary>
 /// Classe de définition des données
 /// </summary>
 public class C_T_Grade
 {
  #region Données membres
  private int _GradeID;
  private string _GName;
  private int _Gscore;
  private DateTime? _GDate;
  private int _AssociationID;
  #endregion
  #region Constructeurs
  public C_T_Grade()
  { }
  public C_T_Grade(string GName_, int Gscore_, DateTime? GDate_, int AssociationID_)
  {
   GName = GName_;
   Gscore = Gscore_;
   GDate = GDate_;
   AssociationID = AssociationID_;
  }
  public C_T_Grade(int GradeID_, string GName_, int Gscore_, DateTime? GDate_, int AssociationID_)
   : this(GName_, Gscore_, GDate_, AssociationID_)
  {
   GradeID = GradeID_;
  }
  #endregion
  #region Accesseurs
  public int GradeID
  {
   get { return _GradeID; }
   set { _GradeID = value; }
  }
  public string GName
  {
   get { return _GName; }
   set { _GName = value; }
  }
  public int Gscore
  {
   get { return _Gscore; }
   set { _Gscore = value; }
  }
  public DateTime? GDate
  {
   get { return _GDate; }
   set { _GDate = value; }
  }
  public int AssociationID
  {
   get { return _AssociationID; }
   set { _AssociationID = value; }
  }
  #endregion
 }
}
