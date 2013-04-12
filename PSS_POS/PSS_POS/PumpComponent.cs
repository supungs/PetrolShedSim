using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PSS_POS
{
    public partial class PumpComponent : UserControl
    {
        public PumpComponent()
        {
            InitializeComponent();
        }
        public void initPump(int id, string fuelType)
        {
            lbl_pumpid.Text = "Pump" + id;
            lbl_fueltype.Text = "Fuel Type: "+ fuelType;
            lbl_amount.Text = "Pumped Amount: 0 ltrs";
            lbl_cost.Text = "Cost: $0";
            lbl_status.Text = "Pumped Status: Started pumping.";
        }

        public void pumpUpdate(float amount,float price)
        {
            lbl_amount.Text = "Pumped Amount: "+amount+" ltrs";
            lbl_cost.Text = "Cost: $"+amount*price;
            lbl_status.Text = "Pumped Status: Pumping.";
        }

        public void endPump(float amount,float price)
        {
            lbl_amount.Text = "Pumped Amount: " + amount + " ltrs";
            lbl_cost.Text = "Cost: $" + amount * price;
            lbl_status.Text = "Pumped Status: Finished pumping..";
            clsbtn.Visible = true;
            this.BackColor = Color.FromArgb(255, 224, 192);
        }

        private void clsbtn_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
