using System;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using Microsoft.Win32;
using TaxiSharePrj.DataLinq;
using System.Configuration;

namespace TaxiSharePrj
{
    public partial class StartTaxiShare_frm : Form
    {
        
        public StartTaxiShare_frm()
        {
            InitializeComponent();
        }

        
        private void buttonX_OK_Click(object sender, EventArgs e)
        {
            int FUFLI = FindUserForLogIn();

            if (FUFLI == 3)
            {
                Global_Cls.Message_TaxiShare(0, Global_Cls.MessageType.SError, false, "نام کاربری اشتباه می باشد!");
                textBox_NUser.Focus();
                return;
            }
            if (FUFLI == 0)
            {
                Global_Cls.Message_TaxiShare(0, Global_Cls.MessageType.SError, false, "رمز ورود اشتباه می باشد!");
                textBox_Pass.Focus();
                return;
            } 
            
            MainForm MF = new MainForm();
            MF.Show();
            this.Hide();
        }

        private void buttonX_Exit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private int FindUserForLogIn()
        {
            DataLinq.DataClassesMainDataContext DcMd = new DataLinq.DataClassesMainDataContext(Global_Cls.ConnectionStr);
            var tus = from tu in DcMd.TBL_Users
                      select tu;
            if (tus.Count() == 0) return 2;

            try
            {
                var tus1 = from tu in DcMd.TBL_Users
                           where tu.AgencyCode.ToUpper() == textBox_NUser.Text.ToUpper()
                           select tu;
                if (tus1.Count() == 0) return 3;

                TBL_User tbu123 = DcMd.TBL_Users.First(t123 => t123.AgencyCode.ToUpper().Equals(textBox_NUser.Text.ToUpper()) & t123.UserPass.ToUpper().Equals(textBox_Pass.Text.ToUpper()));
                Global_Cls.UserCode_Exist = tbu123.UserCode;
                Global_Cls.UserName_Exist = tbu123.AgencyName;
                return 1;
            }
            catch
            { }

            return 0;
        }



        private void StartHM_frm_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Escape))
                this.Close();
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
                buttonX_OK_Click(this, null);
        }

        private void StartHM_frm_Load(object sender, EventArgs e)
        {
            Function_Cls.CheckKeyFile(); 
            SetLanguageProgram();
        }

        private void StartHM_frm_Shown(object sender, EventArgs e)
        {
            if (!Global_Cls.ConnectToInternet()) Application.Exit();

            Function_Cls.SetConnectionString();
        }


        private void SetLanguageProgram()
        {
            InputLanguage lang = GetFarsiLanguage();
            if (lang == null)
                throw new NotSupportedException("Farsi Language keyboard is not installed.");
            InputLanguage.CurrentInputLanguage = lang;
        }

        private InputLanguage GetFarsiLanguage()
        {
            foreach (InputLanguage lang in InputLanguage.InstalledInputLanguages)
            {
                if ((lang.LayoutName.ToLower() == "farsi") | (lang.LayoutName == "Persian"))
                    return lang;
            }
            return null;
        }

        
     

        

    }
}
