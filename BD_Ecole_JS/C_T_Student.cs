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
 public class C_T_Student
 {
  #region Données membres
  private int _StudentID;
  private DateTime _SDoB;
  private string _SName;
  private string _SSurname;
  private string _SEmail;
  private string _SYear;
  private string _SSection;
  #endregion
  #region Constructeurs
  public C_T_Student()
  { }
  public C_T_Student(DateTime SDoB_, string SName_, string SSurname_, string SEmail_, string SYear_, string SSection_)
  {
   SDoB = SDoB_;
   SName = SName_;
   SSurname = SSurname_;
   SEmail = SEmail_;
   SYear = SYear_;
   SSection = SSection_;
  }
  public C_T_Student(int StudentID_, DateTime SDoB_, string SName_, string SSurname_, string SEmail_, string SYear_, string SSection_)
   : this(SDoB_, SName_, SSurname_, SEmail_, SYear_, SSection_)
  {
   StudentID = StudentID_;
  }
  #endregion
  #region Accesseurs
  public int StudentID
  {
   get { return _StudentID; }
   set { _StudentID = value; }
  }
  public DateTime SDoB
  {
   get { return _SDoB; }
   set { _SDoB = value; }
  }
  public string SName
  {
   get { return _SName; }
   set { _SName = value; }
  }
  public string SSurname
  {
   get { return _SSurname; }
   set { _SSurname = value; }
  }
  public string SEmail
  {
   get { return _SEmail; }
   set { _SEmail = value; }
  }
  public string SYear
  {
   get { return _SYear; }
   set { _SYear = value; }
  }
  public string SSection
  {
   get { return _SSection; }
   set { _SSection = value; }
  }
  #endregion
 }
}
