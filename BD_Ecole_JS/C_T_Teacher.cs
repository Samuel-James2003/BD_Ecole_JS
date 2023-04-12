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
 public class C_T_Teacher
 {
  #region Données membres
  private int _TeacherID;
  private string _TName;
  private string _TSurname;
  private DateTime _TDoB;
  private string _TEmail;
  #endregion
  #region Constructeurs
  public C_T_Teacher()
  { }
  public C_T_Teacher(string TName_, string TSurname_, DateTime TDoB_, string TEmail_)
  {
   TName = TName_;
   TSurname = TSurname_;
   TDoB = TDoB_;
   TEmail = TEmail_;
  }
  public C_T_Teacher(int TeacherID_, string TName_, string TSurname_, DateTime TDoB_, string TEmail_)
   : this(TName_, TSurname_, TDoB_, TEmail_)
  {
   TeacherID = TeacherID_;
  }
  #endregion
  #region Accesseurs
  public int TeacherID
  {
   get { return _TeacherID; }
   set { _TeacherID = value; }
  }
  public string TName
  {
   get { return _TName; }
   set { _TName = value; }
  }
  public string TSurname
  {
   get { return _TSurname; }
   set { _TSurname = value; }
  }
  public DateTime TDoB
  {
   get { return _TDoB; }
   set { _TDoB = value; }
  }
  public string TEmail
  {
   get { return _TEmail; }
   set { _TEmail = value; }
  }
  #endregion
 }
}
