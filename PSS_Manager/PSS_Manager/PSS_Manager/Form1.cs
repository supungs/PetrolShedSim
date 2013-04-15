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
            String[,] temp = msys.getFuelLevels();
            int max_row = temp.GetUpperBound(0);
            int max_col = temp.GetUpperBound(1);
            for (int row = 0; row < max_row; row++)
            {
                ListViewItem new_item = listView1.Items.Add(temp[row, 0]);
                for (int col = 1; col <= max_col; col++)
                {
                    new_item.SubItems.Add(temp[row, col]);
                }
            }

            listView1.Show();
            
            
        }

        private void fuelOrder_Click(object sender, EventArgs e)
        {
            String[,] temp = msys.getOrderDetails();
            int max_row = temp.GetUpperBound(0);
            int max_col = temp.GetUpperBound(1);
            for (int row = 0; row < max_row; row++)
            {
                ListViewItem new_item = listView1.Items.Add(temp[row, 0]);
                for (int col = 1; col <= max_col; col++)
                {
                    new_item.SubItems.Add(temp[row, col]);
                }
            }

            listView1.Show();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime date = dateTimePicker1.Value;
            String[,] temp = msys.getSales(date);

            int max_row = temp.GetUpperBound(0);
            int max_col = temp.GetUpperBound(1);
            for (int row = 0; row < max_row; row++)
            {
                ListViewItem new_item = listView1.Items.Add(temp[row, 0]);
                for (int col = 1; col <= max_col; col++)
                {
                    new_item.SubItems.Add(temp[row, col]);
                }
            }

            listView1.Show();
        }


    }
}
