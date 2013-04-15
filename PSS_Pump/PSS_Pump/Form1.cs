using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using PumpLibrary;

namespace PSS_Pump
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        public void setType(String fuelType)
        {
            label1.Text = "Fuel Type: "+ fuelType;
        }

        public void setQuantity(float f)
        {
            label2.Text = "Liters: "+ f.ToString();
        }

        public void setPrice(string p)
        {
            label3.Text = "Price: "+ p;
        }

        public void setStatus(string st)
        {
            label4.Text = "Status: " + st;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            Subscriber sub = new Subscriber(this);
            sub.startSubscriber();
        }

       

    }
}
