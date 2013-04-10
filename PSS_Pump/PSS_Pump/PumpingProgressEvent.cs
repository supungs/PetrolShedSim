using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PSS_Pump
{
   
    class PumpingProgressEvent :EventArgs
    {
        private float litres;
        private String type;

        public float Litres
        {
            get { return litres; }
            set { litres = value; }
        }

        public String Type
        {
            get { return type; }
            set { type = value; }
        }
    }
}
