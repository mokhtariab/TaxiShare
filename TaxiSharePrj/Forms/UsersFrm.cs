using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using TaxiSharePrj.DataLinq;
using System.Linq;

namespace TaxiSharePrj
{
    public partial class UsersFrm : UserControl
    {
        public UsersFrm()
        {
            InitializeComponent();
        }
        DataClassesMainDataContext DCM = new DataClassesMainDataContext(Global_Cls.ConnectionStr);
        int _UserCode = 1;
        private TaxiSharePrjCommands _Commands;
        /// <summary>
        /// Gets or sets the commands associated with the control.
        /// </summary>
        public TaxiSharePrjCommands Commands
        {
            get { return _Commands; }
            set
            {
                if (value != _Commands)
                {
                    TaxiSharePrjCommands oldValue = _Commands;
                    _Commands = value;
                    OnCommandsChanged(oldValue, value);
                }
            }
        }
        /// <summary>
        /// Called when Commands property has changed.
        /// </summary>
        /// <param name="oldValue">Old property value</param>
        /// <param name="newValue">New property value</param>
        protected virtual void OnCommandsChanged(TaxiSharePrjCommands oldValue, TaxiSharePrjCommands newValue)
        {
            if (newValue != null)
            {
                saveButton.Command = newValue.UsersCommands.Save;
                cancelButton.Command = newValue.UsersCommands.Cancel;
            }
            else
            {
                saveButton.Command = null;
                cancelButton.Command = null;
            }
        }

        private void UsersFrm_Load(object sender, EventArgs e)
        {
            lblCreateDate.Text = Global_Cls.MiladiDateToShamsi(DateTime.Today);
           
            try
            {
                TBL_User tbhc = DCM.TBL_Users.First(thfr => thfr.UserCode.Equals(_UserCode));
                lblAgencyName.Text = tbhc.AgencyName;
                lblAgencyCode.Text = tbhc.AgencyCode.ToString();
                lblAgencyManager.Text = tbhc.AgencyManager;
                lblCreateDate.Text = (Global_Cls.MiladiDateToShamsi(Convert.ToDateTime(tbhc.GenerateDate))).ToString();
                lblPartMain.Text = tbhc.PartMain.ToString();
                lblAccountPrice.Text = tbhc.AccountPrice.ToString();
                lblPart1.Text = tbhc.Part1.ToString();
                lblPart2.Text = tbhc.Part2.ToString();
                lblPart3.Text = tbhc.Part3.ToString();
                lblPart4.Text = tbhc.Part4.ToString();
                lblPart5.Text = tbhc.Part5.ToString();
                lblPart6.Text = tbhc.Part6.ToString();
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            
            try
            {
                TBL_User tbhc = DCM.TBL_Users.First(thfr => thfr.UserCode.Equals(_UserCode));

                if (txtUserPassOld.Text == tbhc.UserPass)
                {
                    TBL_User THF = new TBL_User
                    {
                        UserPass = txtUserPassNew.Text,
                    };
                    DCM.TBL_Users.InsertOnSubmit(THF);
                    DCM.SubmitChanges();
                }
                else
                {
                    MessageBox.Show("کلمه عبور قبلی غلط است!!");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
