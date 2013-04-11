using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

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
            fType.Text = fuelType;
        }

        public void setQuantity(float f)
        {
            quantity.Text = f.ToString();
        }

        public void setPrice(float f)
        {
            rupees.Text = f.ToString();
        }
    }
}
