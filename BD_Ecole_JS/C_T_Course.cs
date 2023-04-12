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
 public class C_T_Course
 {
  #region Données membres
  private int _CourseID;
  private string _CoName;
  private int _TeacherID;
  #endregion
  #region Constructeurs
  public C_T_Course()
  { }
  public C_T_Course(string CoName_, int TeacherID_)
  {
   CoName = CoName_;
   TeacherID = TeacherID_;
  }
  public C_T_Course(int CourseID_, string CoName_, int TeacherID_)
   : this(CoName_, TeacherID_)
  {
   CourseID = CourseID_;
  }
  #endregion
  #region Accesseurs
  public int CourseID
  {
   get { return _CourseID; }
   set { _CourseID = value; }
  }
  public string CoName
  {
   get { return _CoName; }
   set { _CoName = value; }
  }
  public int TeacherID
  {
   get { return _TeacherID; }
   set { _TeacherID = value; }
  }
  #endregion
 }
}
