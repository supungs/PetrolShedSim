using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceModel;
using PSS_Pump.PumpServiceReference;

namespace PSS_Pump
{
    class MyClass : IPumpServiceCallback
    {
        #region IPumpServiceCallback Members

        public void activateMe(float price)
        {
            Console.WriteLine("Pump activated");
            PumpingProgress.update();
         
        }

        #endregion
    }

    class CustomerGenerator 
    {
         InstanceContext ins ;
         PumpServiceClient x;

         public CustomerGenerator()
         {
             ins = new InstanceContext(new MyClass());
             x = new PumpServiceClient(ins);
         }

        public void activatePump(int id)
        {
          
           x.subscribePump(id);
           
        }

        public void customerReady(int id)
        {
            x.customerReady(id, "");
        }

        public void pumpingFinished(int id)
        {
            x.PumpingFinished(id, "");
        }

        public void pumpProgress(Object o, int id, PumpingProgressEvent e)
        {
            x.pumpProgress(id," ", e.Litres);
        }
    }
}
