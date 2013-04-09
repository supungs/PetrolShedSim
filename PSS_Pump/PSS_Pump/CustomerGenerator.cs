using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PSS_Pump
{
    public delegate void PumpHandler(object sender, CustomerGenerator e);

    class CustomerGenerator : EventArgs
    {
        private bool ready;
        private bool activate;
        private bool finish;

        public CustomerGenerator()
        {
            ready = false;
            activate = false;
            finish = false;
        }

        public bool isReady()
        {
            return ready;
        }

        public bool isActivate()
        {
            return activate;
        }

        public bool isFinish()
        {
            return finish;
        }

        public void customerReady()
        {
            ready = true;
        }

        public void activatePump()
        {
            activate = true;
        }

        public void pumpingFinish()
        {
            finish = true;
        }
    }
}
