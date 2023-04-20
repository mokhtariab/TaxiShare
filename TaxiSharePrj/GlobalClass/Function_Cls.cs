﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using TaxiSharePrj.Properties;
using System.Configuration;
using System.IO;
using System.Collections.Specialized;
using System.Threading;
using System.Management;

namespace TaxiSharePrj
{
    class Function_Cls
    {

        #region BackUp & Restore DB

        //static public void SetBackUpDBAll(string PathSaveBackup)
        //{
        //    SqlConnection SqlConn = new SqlConnection(Global_Cls.ConnectionStr);
        //    SqlCommand SqlCmd = new SqlCommand();
        //    SqlCmd.CommandText = " BACKUP DATABASE [CarRent] TO  DISK = N'" + PathSaveBackup + "' " +
        //                         " WITH FORMAT, INIT, NAME = N'CarRent-Full Database Backup', SKIP, NOREWIND, NOUNLOAD,  STATS = 10 ";

        //    SqlCmd.CommandType = CommandType.Text;
        //    SqlCmd.Connection = SqlConn;

        //    SqlConn.Open();

        //    try
        //    {
        //        SqlCmd.ExecuteReader();
                
        //        SetBackUpPicFilm_DesignRep(Path.GetDirectoryName(PathSaveBackup), Path.GetFileName(PathSaveBackup).Replace(Path.GetExtension(PathSaveBackup), ""));
                
        //        //Global_Cls.Message_TaxiShare(0, Global_Cls.MessageType.SConfirmation, false, "عمل پشتیبانی با موفقیت انجام شد");
        //    }
        //    catch (Exception ex)
        //    {
        //        string ex_str = Convert.ToString(ex);
        //        if (ex_str.IndexOf("Cannot open backup device") > 0)
        //            Global_Cls.Message_TaxiShare(0, Global_Cls.MessageType.SError, false, "مسیر پشتیبانی را عوض کنید!");
        //        else
        //            MessageBox.Show(Convert.ToString(ex));
        //    }
        //    SqlConn.Close();
        //}

        //static public void SetBackUpPicFilm_DesignRep(string PathSaveBackup, string FileName)
        //{
        //    if (Global_Cls.BkpRstPicsFilms)
        //        CopyFolder(Global_Cls.RootSaveLoad() + "\\PicsFilms", PathSaveBackup + "\\" + FileName + "_BkpPicsFilms");
        //    if (Global_Cls.BkpRstDesignReport) 
        //        CopyFolder(Global_Cls.RootSaveLoad() + "\\Report", PathSaveBackup + "\\" + FileName + "_BkpReport");
        //}

        //static public void CopyFolder( string sourceFolder, string destFolder ) 
        //{ 
        //    if (!Directory.Exists( destFolder )) 
        //    Directory.CreateDirectory( destFolder ); 
        //    string[] files = Directory.GetFiles( sourceFolder ); 
        //    foreach (string file in files) 
        //    { 
        //        string name = Path.GetFileName( file ); 
        //        string dest = Path.Combine( destFolder, name );
        //        try { File.Copy(file, dest); }
        //        catch { }
        //    } 
        //    string[] folders = Directory.GetDirectories( sourceFolder ); 
        //    foreach (string folder in folders) 
        //    { 
        //        string name = Path.GetFileName( folder ); 
        //        string dest = Path.Combine( destFolder, name );
        //        try { CopyFolder(folder, dest); }
        //        catch { }
        //    } 
        //} 

        //static public void SetRestoreDBAll(string PathSaveRestore)
        //{
        //    SqlConnection SqlConn = new SqlConnection(Global_Cls.ConnectionStr);
        //    SqlCommand SqlCmd = new SqlCommand();

        //    SqlCmd.CommandText =
        //        "use master " +
        //        "ALTER DATABASE [CarRent] SET SINGLE_USER WITH ROLLBACK IMMEDIATE " +
        //        "RESTORE DATABASE [CarRent] FROM  DISK = N'" + PathSaveRestore +
        //        "' WITH  FILE = 1,  NOUNLOAD,  REPLACE,  STATS = 10";
        //    //@"' WITH FILE = 1,  NOUNLOAD,  REPLACE, MOVE 'APPSERVER' TO 'C:\Program Files\Microsoft SQL Server\MSSQL.1\MSSQL\Data\APPSERVER_Data.MDF', " +
        //    //@"MOVE 'APPSERVER_Log' TO 'C:\Program Files\Microsoft SQL Server\MSSQL.1\MSSQL\Data\APPSERVER_Log.LDF' ";
            
        //    SqlCmd.CommandType = CommandType.Text;
        //    SqlCmd.Connection = SqlConn;

        //    SqlDataAdapter SDA = new SqlDataAdapter(SqlCmd.CommandText, SqlConn);
        //    SDA.UpdateCommand = new SqlCommand(SqlCmd.CommandText, SqlConn);

        //    SqlConn.Open();

        //    try
        //    {
        //        SDA.UpdateCommand.ExecuteReader();

        //        RestorePicFilm_DesignRep(Path.GetDirectoryName(PathSaveRestore), Path.GetFileName(PathSaveRestore).Replace(Path.GetExtension(PathSaveRestore), ""));

        //        Global_Cls.Message_TaxiShare(0, Global_Cls.MessageType.SConfirmation, false, "عمل بازیابی با موفقیت انجام شد");
        //    }
        //    catch (Exception ex)
        //    {
        //        string ex_str = Convert.ToString(ex);
        //        if (ex_str.IndexOf("Cannot open backup device") > 0)
        //            Global_Cls.Message_TaxiShare(0, Global_Cls.MessageType.SError, false, "مسیر بازیابی را عوض کنید!");
        //        else
        //            MessageBox.Show(Convert.ToString(ex));
        //    }

        //    SqlConn.Close();
        //}

        //static public void RestorePicFilm_DesignRep(string PathSaveRst, string FileName)
        //{
        //    if (Global_Cls.BkpRstPicsFilms)
        //        CopyFolder(PathSaveRst + "\\" + FileName + "_BkpPicsFilms", Global_Cls.RootSaveLoad() + "\\PicsFilms");
        //    if (Global_Cls.BkpRstDesignReport)
        //        CopyFolder(PathSaveRst + "\\" + FileName + "_BkpReport", Global_Cls.RootSaveLoad() + "\\Report");
        //}

        //static public void Restore_Func(bool EditPass_EnterPass)
        //{
        //    RstPass_frm RPF = new RstPass_frm();

        //    RPF.Edit_Enter = EditPass_EnterPass;
        //    if (EditPass_EnterPass)
        //    {
        //        RPF.groupPanel_NewPass.Visible = true;
        //        RPF.Height = 212; 
        //    }
        //    else
        //    {
        //        RPF.groupPanel_EnterPass.Visible = true;
        //        RPF.Height = 140;
        //    }

        //    RPF.ShowDialog();
        //}

        #endregion
       
        
        #region SearchInternet
        //public static void SearchInternet(int SearchType)
        //{
        //    //1: Search  2: Map Search
        //    SearchInternet_frm SIf = new SearchInternet_frm();
        //    SIf.SearchTypeEnter = SearchType;
        //    SIf.ShowDialog();
        //}

        #endregion


        #region Security
        
        public static bool ExitForce = false;


        public static void SetConnectionString()
        {
            if (System.IO.File.Exists(System.Windows.Forms.Application.StartupPath + @"\Initial.txt"))
            {
                try
                {
                    Global_Cls.ConnectionStr = SoftwareCode(System.Windows.Forms.Application.StartupPath + @"\Initial.txt");
                    SqlConnection SqlConn = new SqlConnection(Global_Cls.ConnectionStr);

                    try
                    {
                        SqlConn.Open();
                        SqlConn.Close();
                    }
                    catch
                    {
                        Global_Cls.Message_TaxiShare(0, Global_Cls.MessageType.SError, false, " Initial File: 'Data Not Correct!' ");
                        ExitForce = true;
                        Application.Exit();

                    }
                }
                catch
                {
                    Global_Cls.Message_TaxiShare(0, Global_Cls.MessageType.SError, false, " Initial File: 'Data Not Correct!' ");
                    ExitForce = true;
                    Application.Exit();
                }
            }
            else
            {
                Global_Cls.Message_TaxiShare(0, Global_Cls.MessageType.SError, false,
                    " Initial File: 'Not Found!' ");
                ExitForce = true;
                Application.Exit();
            }

        }


        
        public static void CheckKeyFile()
        {
            if (System.IO.File.Exists(System.Windows.Forms.Application.StartupPath + @"\KeyFile.txt"))
            {
                     string SC = SoftwareCode(System.Windows.Forms.Application.StartupPath + @"\KeyFile.txt");
               try
                {
                    if (HddDef(SC.Substring(0, SC.IndexOf("+++"))) != SoftwareCode(System.Windows.Forms.Application.StartupPath + @"\KeyFile.txt"))
                    {
                        Global_Cls.Message_TaxiShare(0, Global_Cls.MessageType.SError, false, "امکان راه اندازی برنامه در این محیط (سیستم) وجود ندارد");
                        ExitForce = true;
                        Application.Exit();
                    }
                }
                catch
                {
                    try
                    {
                        if (HddDefSet(SC.Substring(0, SC.IndexOf("+++"))) != SoftwareCode(System.Windows.Forms.Application.StartupPath + @"\KeyFile.txt"))
                        {
                            Global_Cls.Message_TaxiShare(0, Global_Cls.MessageType.SError, false, "امکان راه اندازی برنامه در این محیط (سیستم) وجود ندارد");
                            ExitForce = true;
                            Application.Exit();
                        }
                    }
                    catch (Exception ex)
                    {
                        Global_Cls.Message_TaxiShare(0, Global_Cls.MessageType.SError, false, "امکان راه اندازی برنامه در این محیط (سیستم) وجود ندارد", ex.Message);
                        ExitForce = true;
                        Application.Exit();
                    }
                }
            }
            else
            {
                Global_Cls.Message_TaxiShare(0, Global_Cls.MessageType.SError, false,
                    "لطفا کدهای ذیل را جهت گرفتن فایل راه انداز ارسال نمایید ",
                    HddDef());
                ExitForce = true;
                Application.Exit();
            }

        }

        public static string SoftwareCode(string PathFile)
        {
            string text = System.IO.File.ReadAllText(PathFile);

            RSaEncryptionLib.BaseCom BS = new RSaEncryptionLib.BaseCom();
            BS.LoadPublicKey();
            BS.LoadPrivateKey();


            string Result = "";
            try
            {
                Result = BS.PrivateDecryption(text);
            }
            catch { }

            return Result;
        }

        private static string HddDef(string model)
        {
            string S = "", M = "", TC = "", TS = "";
            ManagementObjectSearcher mosDisks = new ManagementObjectSearcher(
                "SELECT * FROM Win32_DiskDrive WHERE Model = '" + model + "'");

            foreach (ManagementObject moDisk in mosDisks.Get())
            {
                S = moDisk["SerialNumber"].ToString();
                M = moDisk["Model"].ToString();
                TC = moDisk["TotalCylinders"].ToString();
                TS = moDisk["TotalSectors"].ToString();
            }
            return M + "+++" + S + "+++" + TC + "+++" + TS;
        }

        private static string HddDefSet(string model)
        {
            string M = "", TC = "", TS = "";
            ManagementObjectSearcher mosDisks = new ManagementObjectSearcher(
                "SELECT * FROM Win32_DiskDrive WHERE Model = '" + model + "'");

            foreach (ManagementObject moDisk in mosDisks.Get())
            {
                M = moDisk["Model"].ToString();
                TC = moDisk["TotalCylinders"].ToString();
                TS = moDisk["TotalSectors"].ToString();
            }
            return M + "+++" + TC + "+++" + TS;
        }

        private static string HddDef()
        {
            string S = "", M = "", TC = "", TS = "", AllHDDDef = "";
            ManagementObjectSearcher mosDisks = new ManagementObjectSearcher(
                "SELECT  * FROM Win32_DiskDrive ");

            foreach (ManagementObject moDisk in mosDisks.Get())
            {
                try { S = moDisk["SerialNumber"].ToString(); }
                catch { S = ""; }
                try { M = moDisk["Model"].ToString(); }
                catch { M = ""; }

                try { TC = moDisk["TotalCylinders"].ToString(); }
                catch { TC = ""; }

                try { TS = moDisk["TotalSectors"].ToString(); }
                catch { TS = ""; }

                AllHDDDef += M + "\\" + S + "\\" + TC + "\\" + TS + "//////////////";
            }

            return AllHDDDef;
        }

        #endregion



        #region Read&Write ConfigFile & Settings

        //public static void ReadFromXmlFiles()
        //{
        //    if (File.Exists("LocalConfig.xml"))
        //    {
        //        XDocument loaded = XDocument.Load("LocalConfig.xml");

        //        var q = (from c in loaded.Descendants("setting")
        //                 select c).ToList();


        //        Global_Cls.CityLimit = q.Find(j => j.FirstAttribute.Value == "CityLimit").Value;
        //        Global_Cls.FineKillometer = Convert.ToDouble(q.Find(j => j.FirstAttribute.Value == "FineKillometer").Value);
        //        Global_Cls.FineTime = Convert.ToDouble(q.Find(j => j.FirstAttribute.Value == "FineTime").Value);
        //        Global_Cls.FineDay = Convert.ToDouble(q.Find(j => j.FirstAttribute.Value == "FineDay").Value);

        //        Global_Cls.FreeKillometer = Convert.ToInt32(q.Find(j => j.FirstAttribute.Value == "FreeKillometer").Value);
        //        Global_Cls.ExpKMService = Convert.ToInt32(q.Find(j => j.FirstAttribute.Value == "ExpKMService").Value);
        //        Global_Cls.ExpDayThirdInsu = Convert.ToInt32(q.Find(j => j.FirstAttribute.Value == "ExpDayThirdInsu").Value);
        //        Global_Cls.ExpDayCarDuty = Convert.ToInt32(q.Find(j => j.FirstAttribute.Value == "ExpDayCarDuty").Value);
        //        Global_Cls.ExpDayBodyInsu = Convert.ToInt32(q.Find(j => j.FirstAttribute.Value == "ExpDayBodyInsu").Value);
        //        Global_Cls.ExpDayCarEnter = Convert.ToInt32(q.Find(j => j.FirstAttribute.Value == "ExpDayCarEnter").Value);
        //        Global_Cls.GetFinePeriod = Convert.ToInt32(q.Find(j => j.FirstAttribute.Value == "GetFinePeriod").Value);
                
        //        Global_Cls.ServerName = q.Find(j => j.FirstAttribute.Value == "ServerName").Value;
        //        Global_Cls.ConnectionDef = q.Find(j => j.FirstAttribute.Value == "ConnectionDef").Value;
        //        Global_Cls.ServerNameForLock = q.Find(j => j.FirstAttribute.Value == "ServerNameForLock").Value;
        //        Global_Cls.ColorDisplay = Convert.ToByte(q.Find(j => j.FirstAttribute.Value == "ColorDisplay").Value);

        //    }

        //    string RootStr = Global_Cls.RootSaveLoad() + "\\MainConfig.xml";

        //    if (File.Exists(RootStr))
        //    {
        //        XDocument loaded = XDocument.Load(RootStr);

        //        var q = (from c in loaded.Descendants("setting")
        //                 select c).ToList();

        //        //Global_Cls.Comm_Port = Convert.ToInt32(q.Find(j => j.FirstAttribute.Value == "Comm_Port").Value);
        //        //Global_Cls.Comm_BaudRate = Convert.ToInt32(q.Find(j => j.FirstAttribute.Value == "Comm_BaudRate").Value);
        //        //Global_Cls.Comm_TimeOut = Convert.ToInt32(q.Find(j => j.FirstAttribute.Value == "Comm_TimeOut").Value);
        //        //Global_Cls.Send_Unicode = Convert.ToBoolean(q.Find(j => j.FirstAttribute.Value == "Send_Unicode").Value);

        //        Global_Cls.BkpExitType = Convert.ToInt32(q.Find(j => j.FirstAttribute.Value == "BkpExitType").Value);
        //        Global_Cls.BkpAutoRoot = q.Find(j => j.FirstAttribute.Value == "BkpAutoRoot").Value;
        //        Global_Cls.PssRstrr = q.Find(j => j.FirstAttribute.Value == "PssRstrr").Value;
        //        Global_Cls.BkpRstPicsFilms = Convert.ToBoolean(q.Find(j => j.FirstAttribute.Value == "BkpRstPicsFilms").Value);
        //        Global_Cls.BkpRstDesignReport = Convert.ToBoolean(q.Find(j => j.FirstAttribute.Value == "BkpRstDesignReport").Value);
        //    }

        //}

        //public static void WriteToXmlFiles()
        //{

        //    XElement xmlLoacl = new XElement("userSettings",
        //                new XElement("setting",
        //                    new XAttribute("Name", "CityLimit"),
        //                    new XElement("Value", Global_Cls.CityLimit)
        //                ),
        //                new XElement("setting",
        //                    new XAttribute("Name", "FineKillometer"),
        //                    new XElement("Value", Global_Cls.FineKillometer)
        //                ),
        //                new XElement("setting",
        //                    new XAttribute("Name", "FineTime"),
        //                    new XElement("Value", Global_Cls.FineTime)
        //                ),
        //                new XElement("setting",
        //                    new XAttribute("Name", "FineDay"),
        //                    new XElement("Value", Global_Cls.FineDay)
        //                ),
        //                new XElement("setting",
        //                    new XAttribute("Name", "FreeKillometer"),
        //                    new XElement("Value", Global_Cls.FreeKillometer)
        //                ),
        //                new XElement("setting",
        //                    new XAttribute("Name", "ExpKMService"),
        //                    new XElement("Value", Global_Cls.ExpKMService)
        //                ),
        //                new XElement("setting",
        //                    new XAttribute("Name", "ExpDayThirdInsu"),
        //                    new XElement("Value", Global_Cls.ExpDayThirdInsu)
        //                ),
        //                new XElement("setting",
        //                    new XAttribute("Name", "ExpDayCarDuty"),
        //                    new XElement("Value", Global_Cls.ExpDayCarDuty)
        //                ),
        //                new XElement("setting",
        //                    new XAttribute("Name", "ExpDayBodyInsu"),
        //                    new XElement("Value", Global_Cls.ExpDayBodyInsu)
        //                ),
        //                new XElement("setting",
        //                    new XAttribute("Name", "ExpDayCarEnter"),
        //                    new XElement("Value", Global_Cls.ExpDayCarEnter)
        //                ),
        //                new XElement("setting",
        //                    new XAttribute("Name", "GetFinePeriod"),
        //                    new XElement("Value", Global_Cls.GetFinePeriod)
        //                ),


        //                new XElement("setting",
        //                    new XAttribute("Name", "ServerName"),
        //                    new XElement("Value", Global_Cls.ServerName)
        //                ),
        //                new XElement("setting",
        //                    new XAttribute("Name", "ConnectionDef"),
        //                    new XElement("Value", Global_Cls.ConnectionDef)
        //                ),
        //                new XElement("setting",
        //                    new XAttribute("Name", "ServerNameForLock"),
        //                    new XElement("Value", Global_Cls.ServerNameForLock)
        //                ),

        //                new XElement("setting",
        //                    new XAttribute("Name", "ColorDisplay"),
        //                    new XElement("Value", Global_Cls.ColorDisplay)
        //                )
        //            );
        //    xmlLoacl.Save(@"LocalConfig.xml");



        //    if (!Global_Cls.ClientSoftOK)
        //    {
        //        XElement XmlMain = new XElement("userSettings",
        //            //new XElement("setting",
        //            //    new XAttribute("Name", "Comm_Port"),
        //            //    new XElement("Value", Global_Cls.Comm_Port.ToString())
        //            //),
        //            //new XElement("setting",
        //            //    new XAttribute("Name", "Comm_BaudRate"),
        //            //    new XElement("Value", Global_Cls.Comm_BaudRate.ToString())
        //            //),
        //            //new XElement("setting",
        //            //    new XAttribute("Name", "Comm_TimeOut"),
        //            //    new XElement("Value", Global_Cls.Comm_TimeOut.ToString())
        //            //),
        //            //new XElement("setting",
        //            //    new XAttribute("Name", "Send_Unicode"),
        //            //    new XElement("Value", Global_Cls.Send_Unicode.ToString())
        //            //),
        //                new XElement("setting",
        //                    new XAttribute("Name", "BkpExitType"),
        //                    new XElement("Value", Global_Cls.BkpExitType.ToString())
        //                ),
        //                new XElement("setting",
        //                    new XAttribute("Name", "BkpAutoRoot"),
        //                    new XElement("Value", Global_Cls.BkpAutoRoot)
        //                ),
        //                new XElement("setting",
        //                    new XAttribute("Name", "PssRstrr"),
        //                    new XElement("Value", Global_Cls.PssRstrr)
        //                ),
        //                new XElement("setting",
        //                    new XAttribute("Name", "BkpRstPicsFilms"),
        //                    new XElement("Value", Global_Cls.BkpRstPicsFilms.ToString())
        //                ),
        //                new XElement("setting",
        //                    new XAttribute("Name", "BkpRstDesignReport"),
        //                    new XElement("Value", Global_Cls.BkpRstDesignReport.ToString())
        //                )
        //          );

        //        XmlMain.Save(@"MainConfig.xml");
        //    }

        //}


        //private static void WriteToParameter(string StrEnter, StringCollection StrColect)
        //{
        //    int i = 0;
        //    StrColect.Clear();
        //    while (StrEnter.Length > 0)
        //    {
        //        StrColect.Insert(i, StrEnter.Substring(0, StrEnter.IndexOf(";")));
        //        StrEnter = StrEnter.Remove(0, StrEnter.IndexOf(";") + 1);
        //        i++;
        //    }
        //}

        //public static string ReadFromParameter(StringCollection StrColect)
        //{
        //    string Result = "";
        //    for (int i = 0; i < StrColect.Count; i++)
        //        Result += StrColect[i].ToString() + ";";
        //    return Result;
        //}


        #endregion

    }
}



