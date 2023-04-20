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
    public partial class RecPayFrm : UserControl
    {
        public RecPayFrm()
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
                btn_Charche.Command = newValue.RecPayCommands.Save;
                cancelButton.Command = newValue.RecPayCommands.Cancel;
            }
            else
            {
                btn_Charche.Command = null;
                cancelButton.Command = null;
            }
        }

        private void RecPayFrm_Load(object sender, EventArgs e)
        {
            
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            
            try
            {
                TBL_User tbhc = DCM.TBL_Users.First(thfr => thfr.UserCode.Equals(_UserCode));

                
                
                    TBL_User THF = new TBL_User
                    {
                
                    };
                
                
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void panel_BeginDate_Leave(object sender, EventArgs e)
        {
            if (Convert.ToInt16(comboBox_MonthBD.Text) > 6 && Convert.ToInt16(comboBox_DayBD.Text) == 31) comboBox_DayBD.Text = "30";
            if (Convert.ToInt16(comboBox_MonthBD.Text) == 12 && (Convert.ToInt16(comboBox_DayBD.Text) == 31 || Convert.ToInt16(comboBox_DayBD.Text) == 30)) comboBox_DayBD.Text = "29";
        }

        private void panel_RetDate_Leave(object sender, EventArgs e)
        {
            if (Convert.ToInt16(comboBox_MonthRD.Text) > 6 && Convert.ToInt16(comboBox_DayRD.Text) == 31) comboBox_DayRD.Text = "30";
            if (Convert.ToInt16(comboBox_MonthRD.Text) == 12 && (Convert.ToInt16(comboBox_DayRD.Text) == 31 || Convert.ToInt16(comboBox_DayRD.Text) == 30)) comboBox_DayRD.Text = "29";
        }

        
    }
}
