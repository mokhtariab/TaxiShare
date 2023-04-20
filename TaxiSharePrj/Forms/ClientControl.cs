using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar.Controls;
using DevComponents.DotNetBar.Metro;
using System.Data.Linq;
using System.Linq;
using TaxiSharePrj.DataLinq;

namespace TaxiSharePrj
{
    public partial class ClientControl : UserControl
    {
        public ClientControl()
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
                saveButton.Command = newValue.ClientCommands.Save;
                cancelButton.Command = newValue.ClientCommands.Cancel;
            }
            else
            {
                saveButton.Command = null;
                //cancelButton.Command = null;
            }
        }

        private void ReqMachineFrm_Load(object sender, EventArgs e)
        {
            lbl_ReqMDate.Text = Global_Cls.MiladiDateToShamsi(DateTime.Today);
            lbl_ReqMTime.Text = DateTime.Now.Hour.ToString() + ":" + DateTime.Now.Minute.ToString() + ":" + DateTime.Now.Second.ToString();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {

            if (ComboPartBeggining.Text == "")
            { MessageBox.Show("محل حرکت را وارد نمایید"); OnCommandsChanged(null, null); return; }
            if (ComboPartDest.Text == "")
            { MessageBox.Show("محل شروع را وارد نمایید"); OnCommandsChanged(null, null); return; }
            if (TxtTelCust.Text == "")
            { MessageBox.Show("شماره تلفن مشتری را وارد نمایید"); OnCommandsChanged(null, null); return; }
            if (TxtMobileCost.Text == "")
            { MessageBox.Show("شماره موبایل مشتری را وارد نمایید"); OnCommandsChanged(null, null); return; }
            if (TxtServicePrice.Text == "")
            { MessageBox.Show("مبلغ هزینه سرویس را وارد نمایید"); OnCommandsChanged(null, null); return; }
            try
            {
                float.Parse(TxtServicePrice.Text);
            }
            catch
            { MessageBox.Show("مبلغ هزینه سرویس عددی باید باشد"); OnCommandsChanged(null, null); return; }

            //if (nupdownMaxTime.Value == 0)
            //{ MessageBox.Show("حداکثر زمان تا اتمام مهلت تماس با مشتری را وارد نمایید"); return; }
            //if (ComboCarName.Text == "")
            //{ MessageBox.Show("نوع خودروی درخواستی را وارد نمایید"); return; }


            
            long Mx = 0;
            try { Mx = (from j in DCM.TBL_ReqMachines where j.UserCode == Global_Cls.UserCode_Exist select j.ReqMCode).Max(); }
            catch { Mx = 0; }
            try
            {
                TBL_ReqMachine THF = new TBL_ReqMachine
                {
                    UserCode = Global_Cls.UserCode_Exist,
                    ReqMCode = Mx + 1,
                    ReqMDate = DateTime.Today.Date,
                    PartBeggining = ComboPartBeggining.SelectedIndex,
                    PartDest = ComboPartDest.SelectedIndex,
                    TelCust = TxtTelCust.Text,
                    MobileCust = TxtMobileCost.Text,
                    ServicePrice = float.Parse(TxtServicePrice.Text),
                    Active = true,
                    ReqMDsc = TxtReqMDSC.Text,
                    CarName = ComboCarName.Text,
                    MaxTime = int.Parse(nupdownMaxTime.Value.ToString()),
                };

                DCM.TBL_ReqMachines.InsertOnSubmit(THF);
                DCM.SubmitChanges();

                Global_Cls.Message_TaxiShare(0,Global_Cls.MessageType.SConfirmation,false,"درخواست شما با موفقیت ثبت گردید");
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
