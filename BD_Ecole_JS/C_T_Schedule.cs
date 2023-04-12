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
 public class C_T_Schedule
 {
  #region Données membres
  private int _ScheduleID;
  private TimeSpan _SchDuration;
  private DateTime _SchDate;
  private DateTime _SchStart_Time;
  private int _ClassID;
  private int? _CourseID;
  #endregion
  #region Constructeurs
  public C_T_Schedule()
  { }
  public C_T_Schedule(TimeSpan SchDuration_, DateTime SchDate_, DateTime SchStart_Time_, int ClassID_, int? CourseID_)
  {
   SchDuration = SchDuration_;
   SchDate = SchDate_;
   SchStart_Time = SchStart_Time_;
   ClassID = ClassID_;
   CourseID = CourseID_;
  }
  public C_T_Schedule(int ScheduleID_, TimeSpan SchDuration_, DateTime SchDate_, DateTime SchStart_Time_, int ClassID_, int? CourseID_)
   : this(SchDuration_, SchDate_, SchStart_Time_, ClassID_, CourseID_)
  {
   ScheduleID = ScheduleID_;
  }
  #endregion
  #region Accesseurs
  public int ScheduleID
  {
   get { return _ScheduleID; }
   set { _ScheduleID = value; }
  }
  public TimeSpan SchDuration
  {
   get { return _SchDuration; }
   set { _SchDuration = value; }
  }
  public DateTime SchDate
  {
   get { return _SchDate; }
   set { _SchDate = value; }
  }
  public DateTime SchStart_Time
  {
   get { return _SchStart_Time; }
   set { _SchStart_Time = value; }
  }
  public int ClassID
  {
   get { return _ClassID; }
   set { _ClassID = value; }
  }
  public int? CourseID
  {
   get { return _CourseID; }
   set { _CourseID = value; }
  }
  #endregion
 }
}
