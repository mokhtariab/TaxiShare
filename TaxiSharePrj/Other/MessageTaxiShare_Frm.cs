using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TaxiSharePrj
{
    public partial class MessageTaxiShare_Frm : Form
    {
        public MessageTaxiShare_Frm()
        {
            InitializeComponent();
        }

        private void MessageTaxiShare_Frm_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Escape))
                this.Close();
        }

        private void button_Details_Click(object sender, EventArgs e)
        {
            if (Height == 270) Height = 158;
            else Height = 270;
        }



    }
}
