using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PSS_Pump
{
    public delegate void PumpHandler(object sender, CustomerGenerator e);

    class PumpingProgressEvent :EventArgs
    {
        private float litres;
        private String type;

        public float litres { get; set; }

        public float type { get; set; }


    }
}
