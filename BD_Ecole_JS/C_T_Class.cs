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
 public class C_T_Class
 {
  #region Données membres
  private int _ClassID;
  private string _ClName;
  private string _ClLevel;
  #endregion
  #region Constructeurs
  public C_T_Class()
  { }
  public C_T_Class(string ClName_, string ClLevel_)
  {
   ClName = ClName_;
   ClLevel = ClLevel_;
  }
  public C_T_Class(int ClassID_, string ClName_, string ClLevel_)
   : this(ClName_, ClLevel_)
  {
   ClassID = ClassID_;
  }
  #endregion
  #region Accesseurs
  public int ClassID
  {
   get { return _ClassID; }
   set { _ClassID = value; }
  }
  public string ClName
  {
   get { return _ClName; }
   set { _ClName = value; }
  }
  public string ClLevel
  {
   get { return _ClLevel; }
   set { _ClLevel = value; }
  }
  #endregion
 }
}
