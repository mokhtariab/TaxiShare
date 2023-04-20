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
    public partial class ServiceOnlineFrm : UserControl
    {
        public ServiceOnlineFrm()
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
                FinalOK_btn.Command = newValue.ServiceOnlineCommands.Save;
                cancelButton.Command = newValue.ServiceOnlineCommands.Cancel;
            }
            else
            {
                FinalOK_btn.Command = null;
                cancelButton.Command = null;
            }
        }

        private void ServiceOnlineFrm_Load(object sender, EventArgs e)
        {
            TBL_ReqMachine tbhc = DCM.TBL_ReqMachines.First(thfh => thfh.UserCode.Equals(_UserCode));
            lblTelCust.Text = tbhc.TelCust;
            lblMobileCust.Text = tbhc.MobileCust;
            lblPartDest.Text = tbhc.PartDest.ToString();
            lblServicePrice.Text = tbhc.ServicePrice.ToString();
            lblReqMTime.Text = tbhc.ReqMTime.ToString();
            lblMaxTime.Text = tbhc.MaxTime.ToString();
            lblCarName.Text = tbhc.CarName;
            LblDsc.Text = tbhc.ReqMDsc;
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            try
            {
                TBL_ReqCustomer THF = new TBL_ReqCustomer
                {
                    
                };

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
