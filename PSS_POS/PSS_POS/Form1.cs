using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PSS_POS
{
    public partial class PosForm : Form
    {
        private PosSystem poss;
        private Dictionary<int, PumpComponent> pumplist = new Dictionary<int, PumpComponent>();
        private int posID;
        public PosForm()
        {
            InitializeComponent();
        }

        public void setPosSystem(PosSystem poss)
        {
            this.poss = poss;
            cmbofuel.SelectedIndex = 0;
        }

        private void cnctBtn_Click(object sender, EventArgs e)
        {
            if (cnctBtn.Text == "Connect" )
            {
                if (txtPosId.Text != "")
                {
                    posID = int.Parse(txtPosId.Text);
                    if (poss.connectToServer(posID))
                    {
                        txtPosId.Enabled = false;
                        cnctBtn.Text = "Disconnect";
                        grppayment.Enabled = true;
                    }
                }else
                    MessageBox.Show("Please enter a POS ID.","POS System");
            }
            else
            {
                txtPosId.Enabled = true;
                cnctBtn.Text = "Connect";
                grppayment.Enabled = false;
            }
        }

        private void txtPosId_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        public void pumpReady(int pumpNo, string fueltype)
        {
            DialogResult dialogResult = MessageBox.Show("Customer waiting at Pump" + pumpNo
                    + " for " + fueltype + ". Acitivate the pump?", "Customer waiting", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                PumpComponent pump = new PumpComponent();
                pump.initPump(pumpNo, fueltype);
                pumplist.Add(pumpNo, pump);
                flPanel.Controls.Add(pump);
                poss.activatePump(pumpNo);
            }
        }
        public void pumpUpdate(int id, float amount, float price)
        {
            pumplist[id].pumpUpdate(amount, price);
        }

        public void pumpFinish(int id, float amount, float price)
        {
            pumplist[id].endPump(amount, price);
            pumplist.Remove(id);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pumpReady(int.Parse(txtPosId.Text), "AA");
            pumpUpdate(int.Parse(txtPosId.Text), 10, (float) 5.4);
            pumpFinish(int.Parse(txtPosId.Text), 10, (float)5.4);
        }

        private void txtpay_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && !(e.KeyChar=='.');
        }

        private void btnpay_Click(object sender, EventArgs e)
        {
            if (txtpay.Text != "")
            {
                try
                {
                    poss.recordPayment(posID, cmbofuel.SelectedItem.ToString(), float.Parse(txtpay.Text));
                }
                catch
                {
                    MessageBox.Show("Please enter a valid payment value.","Invalid value", MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
            }
        }
    }
}
