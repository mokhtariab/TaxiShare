using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using System.Globalization;
using TaxiSharePrj.DataLinq;
using System.Linq;

namespace TaxiSharePrj
{
    public partial class StartControl : DevComponents.DotNetBar.Controls.SlidePanel
    {
        public StartControl()
        {
            InitializeComponent();

            // Add self-updating chart to the sales tile
            MicroChartItem chart = new MicroChartItem();
            chart.ChartType = eMicroChartType.Column;
            chart.ChartWidth = Users_btn.TileSize.Width - 26;
            chart.ChartHeight = Users_btn.TileSize.Height - 30;
            chart.DataPoints = GetRandomDataPoints(false, 12);
            chart.TooltipValueFormatString = "C"; // Currency format for tooltips
            chart.ColumnChartStyle.PositiveBarColor = Color.White;
           // Users_btn.SubItems.Add(chart);
        }
        DataClassesMainDataContext DCM = new DataClassesMainDataContext(Global_Cls.ConnectionStr);
        int _UserCode = 1;
        protected override void OnResize(EventArgs e)
        {
            // Center the panel
            //itemPanel1.Location = new Point((this.Width - itemPanel1.Width) / 2 + 16, ((this.Height - labelX1.Height - 16) - itemPanel1.Height) / 2 + labelX1.Height + 16);
            base.OnResize(e);
        }

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
                ReqMachine_btn.Command = newValue.ClientCommands.New;
                ReqCustomer_btn.Command = newValue.InvoiceCommands.New;
                Users_btn.Command = newValue.UsersCommands.New;
                RecPay_btn.Command = newValue.RecPayCommands.New;
                ServiceOnline_btn.Command = newValue.ServiceOnlineCommands.New;
                //appViewTile.Command = newValue.ToggleStartControl;
                //devCoTile.Command = newValue.DevComponents;
                //ytdTile.Command = newValue.NotImplemented;
                //helpTile.Command = newValue.GettingStartedCommand;
            }
            else
            {
                ReqMachine_btn.Command = null;
                ReqCustomer_btn.Command = null;
                Users_btn.Command = null;
                //appViewTile.Command = null;
                //devCoTile.Command = null;
                RecPay_btn.Command = null;
                ServiceOnline_btn.Command = null;
                //ytdTile.Command = null;
                //helpTile.Command = null;
            }
        }

        private void chartUpdateTimer_Tick(object sender, EventArgs e)
        {
            //((MicroChartItem)Users_btn.SubItems[0]).DataPoints = GetRandomDataPoints(false, 12);
        }

        private List<double> GetRandomDataPoints(bool allowNegative, int pointsToCreate)
        {
            List<double> points = new List<double>();
            Random rnd = new Random((int)DateTime.Now.Ticks);
            Random rnd2 = new Random();

            for (int i = 0; i < pointsToCreate; i++)
            {
                points.Add(allowNegative ? ((rnd2.Next(500) > 250 ? 1 : -1) * rnd.Next(1000)) : rnd.Next(1000));
            }

            return points;
        }

        private void timer_Main_Tick(object sender, EventArgs e)
        {
            label_main.Text = taghvim() + "           ساعت: " +
                DateTime.Now.TimeOfDay.Hours.ToString() + ":" +
                DateTime.Now.TimeOfDay.Minutes.ToString() + ":" +
                DateTime.Now.TimeOfDay.Seconds.ToString();
                
            //label_main.Left = bar_MainView.Width / 2 - 250;
        }

        private string taghvim()
        {
            string TghvmStr = "";

            string[] fasl = new string[12];
            fasl[0] = "فروردین";
            fasl[1] = "اردیبهشت";
            fasl[2] = "خرداد";
            fasl[3] = "تیر";
            fasl[4] = "مرداد";
            fasl[5] = "شهریور";
            fasl[6] = "مهر";
            fasl[7] = "آبان";
            fasl[8] = "آذر";
            fasl[9] = "دی";
            fasl[10] = "بهمن";
            fasl[11] = "اسفند";
            string[] rooz = new string[7];
            rooz[0] = "شنبه"; rooz[1] = "یکشنبه"; rooz[2] = "دوشنبه"; rooz[3] = "سه شنبه"; rooz[4] = "چهارشنبه"; rooz[5] = "پنج شنبه"; rooz[6] = "جمعه";

            PersianCalendar farsi = new PersianCalendar();
            int a;
            DayOfWeek dd;

            dd = farsi.GetDayOfWeek(DateTime.Now);
            switch (dd.ToString())
            {
                case "Saturday":
                    TghvmStr = rooz[0].ToString();
                    break;
                case "Sunday":
                    TghvmStr = rooz[1].ToString();
                    break;
                case "Monday":
                    TghvmStr = rooz[2].ToString();
                    break;
                case "Tuesday":
                    TghvmStr = rooz[3].ToString();
                    break;
                case "Wednesday":
                    TghvmStr = rooz[4].ToString();
                    break;
                case "Thursday":
                    TghvmStr = rooz[5].ToString();
                    break;
                case "Friday":
                    TghvmStr = rooz[6].ToString();
                    break;
            }
            string str;
            a = farsi.GetDayOfMonth(DateTime.Now);
            TghvmStr += " " + Convert.ToString(a);
            str = Convert.ToString(a);
            a = farsi.GetMonth(DateTime.Now);
            TghvmStr += " " + fasl[a - 1];
            str += "/" + Convert.ToString(a);
            a = farsi.GetYear(DateTime.Now);
            TghvmStr += " " + Convert.ToString(a);
            str += "/" + Convert.ToString(a);

            return TghvmStr;
        }

        private void StartControl_Load(object sender, EventArgs e)
        {
            timer_Main.Enabled = true;
            try
            {
                AgencyName.Text = Global_Cls.UserName_Exist;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ReqCustomer_btn_Click(object sender, EventArgs e)
        {

        }

       
        
    }
}
