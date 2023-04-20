using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using TaxiSharePrj.DataLinq;

namespace TaxiSharePrj
{
    public partial class ReqCustomerFrm : UserControl
    {
        public ReqCustomerFrm()
        {
            InitializeComponent();
        }
        DataClassesMainDataContext DCM = new DataClassesMainDataContext(Global_Cls.ConnectionStr);
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
                saveButton.Command = newValue.InvoiceCommands.Save;
                cancelButton.Command = newValue.InvoiceCommands.Cancel;
            }
            else
            {
                saveButton.Command = null;
                //cancelButton.Command = null;
            }
        }

        private void ReqCustomerFrm_Load(object sender, EventArgs e)
        {
            lblCreateDate.Text = Global_Cls.MiladiDateToShamsi(DateTime.Today);
            lbl_ReqCTime.Text = DateTime.Now.Hour + ":" + DateTime.Now.Minute;
            analogClockControl1.Enabled = true;
            analogClockControl1.Value = DateTime.Now;
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
           if (ComboPartDest.Text == "")
           { MessageBox.Show("مقصد ماشین را وارد نمایید"); OnCommandsChanged(null, null); return; }
           
            try
           {
               float.Parse(txt_ReciveTime.Text);
           }
           catch
            { MessageBox.Show("ساعت رسیدن عددی باید باشد"); OnCommandsChanged(null, null); return; }

             long Mx = 0;
            try { Mx = (from j in DCM.TBL_ReqCustomers where j.UserCode == Global_Cls.UserCode_Exist select j.ReqCCode).Max(); }
            catch { Mx = 0; }
            try
            {
                TBL_ReqCustomer THF = new TBL_ReqCustomer
                {
                    UserCode = Global_Cls.UserCode_Exist,
                    ReqCCode = Mx + 1,
                    PartDest = ComboPartDest.SelectedIndex,
                    ReqCDate = Global_Cls.ShamsiDateToMiladi(lblCreateDate.Text),
                    ReqCTime = DateTime.Now.Hour*60 + DateTime.Now.Minute,
                    ReciveTime = int.Parse(txt_ReciveTime.Text),
                    DalayTime = int.Parse(nupdownDelay.Value.ToString()),
                    CarName = ComboCarName.Text,
                    Active = true,
                    ReqCDsc = TxtReqDSC.Text,
                    RetUserCode = 0,
                };

                DCM.TBL_ReqCustomers.InsertOnSubmit(THF);
                DCM.SubmitChanges();

                Global_Cls.Message_TaxiShare(0, Global_Cls.MessageType.SConfirmation, false, "درخواست شما با موفقیت ثبت گردید");
                saveButton.Enabled = false;
                //if (ComboPartBeggining.Text != "" && ComboPartDest.Text != "" && TxtTelCust.Text != "" && TxtMobileCost.Text != "" && TxtServicePrice.Text != "" && nupdownMaxTime.Value != 0 && ComboCarName.Text != "")
            }
            catch (Exception s)
            {
                MessageBox.Show(s.Message);
                OnCommandsChanged(null, null);
            }
        }
    }
}
