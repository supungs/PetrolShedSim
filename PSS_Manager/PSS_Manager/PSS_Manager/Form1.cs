using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PSS_Manager
{
    public partial class Form1 : Form
    {
        private ManagerSystem msys;
        public Form1()
        {
            InitializeComponent();
            listView1.Hide();
        }

        public void setManagerSystem(ManagerSystem msys)
        {
            this.msys = msys;
        }

        private void fuelLevel_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            String[,] temp = msys.getFuelLevels();
            for (int row = 0; row < 2; row++)
            {
                ListViewItem new_item = listView1.Items.Add(temp[row, 0]);
                new_item.SubItems.Add(temp[row, 1]);
            }

            listView1.Show();
            this.Text = "Fuel Levels";
        }

        private void fuelOrder_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            String[,] temp = msys.getOrderDetails();
            for (int row = 0; row < 2 ; row++)
            {
                ListViewItem new_item = listView1.Items.Add(temp[row, 0]);
                new_item.SubItems.Add(temp[row, 1]);
                new_item.SubItems.Add(temp[row, 2]);
            }

            listView1.Show();
            this.Text = "Fuel Orders";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            DateTime date = dateTimePicker1.Value.Date;
            String[,] temp = msys.getSales(date);

            for (int row = 0; row < 2; row++)
            {
                ListViewItem new_item = listView1.Items.Add(temp[row, 0]);
                new_item.SubItems.Add(temp[row, 1]);
                new_item.SubItems.Add(temp[row, 2]);
            }

            listView1.Show();
            this.Text = "Fuel Sales";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cmbfuel.SelectedIndex = 0;
        }

        private void txtprice_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && !(e.KeyChar == '.');
        }

        private void btnprice_Click(object sender, EventArgs e)
        {
            try
            {
                msys.setPrice(cmbfuel.SelectedItem.ToString().ToLower(), float.Parse(txtprice.Text));
            }
            catch (FormatException) { }
          
        }

        private void btnprofit_Click(object sender, EventArgs e)
        {
            string[,] temp = msys.getProfits();
            listView1.Items.Clear();
            for (int row = 0; row < 2; row++)
            {
                ListViewItem new_item = listView1.Items.Add(temp[row, 0]);
                new_item.SubItems.Add("");
                new_item.SubItems.Add(temp[row, 1]);
            }

            listView1.Show();
            this.Text = "Week Pofits";
        }

        private void btncust_Click(object sender, EventArgs e)
        {
            int num = msys.getNumOfCustomers();
            MessageBox.Show("There are "+num+ " customers at pumps.","Manager");
        }


    }
}
