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
 public class C_T_Association
 {
  #region Données membres
  private int _AssociationID;
  private int _CourseID;
  private int _StudentID;
  #endregion
  #region Constructeurs
  public C_T_Association()
  { }
  public C_T_Association(int CourseID_, int StudentID_)
  {
   CourseID = CourseID_;
   StudentID = StudentID_;
  }
  public C_T_Association(int AssociationID_, int CourseID_, int StudentID_)
   : this(CourseID_, StudentID_)
  {
   AssociationID = AssociationID_;
  }
  #endregion
  #region Accesseurs
  public int AssociationID
  {
   get { return _AssociationID; }
   set { _AssociationID = value; }
  }
  public int CourseID
  {
   get { return _CourseID; }
   set { _CourseID = value; }
  }
  public int StudentID
  {
   get { return _StudentID; }
   set { _StudentID = value; }
  }
  #endregion
 }
}
