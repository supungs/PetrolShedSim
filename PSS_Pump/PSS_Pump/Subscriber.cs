using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceModel;
using PSS_Pump.PumpServiceReference;
using PumpLibrary;

namespace PSS_Pump
{
    class MyClass : IPumpServiceCallback
    {
        CustomerGenerator cGen;
        public MyClass(CustomerGenerator c)
        {
            cGen = c;
        }

        #region IPumpServiceCallback Members

        public void activateMe(float price)
        {
            cGen.ActivatePump();
            Console.WriteLine("Pump activated");
            
         
        }

        #endregion
    }

  public  class Subscriber 
    {
         static int id;
         InstanceContext ins ;
         PumpServiceClient pClient;
         CustomerGenerator gen;
         Form1 form;

         public Subscriber(CustomerGenerator cGen)
         {
             ins = new InstanceContext(new MyClass(cGen));
             pClient= new PumpServiceClient(ins);
             gen = cGen;
             form = new Form1();

             if (id <= 20)
             {
                 id = id + 1;
             }
             else
             {
                 id = 1;
             }
             
             ready();
             progress();
             finish();
         }

         public void ready()
         {
             gen.CustomerReady += new CustomerGenerator.CustomerReadyHandler(gen_CustomerReady);
            
         }

         void gen_CustomerReady(object sender, CustomerReadyEventArgs e)
         {
             
             pClient.subscribePump(id);
             form.setType(e.SelectedFuel.ToString());
             form.setQuantity(0);
             form.setPrice(0);
         }

         public void progress()
         {
             gen.PumpProgress += new CustomerGenerator.PumpProgressHandler(gen_PumpProgress);
         }

         void gen_PumpProgress(object sender, PumpProgressEventArgs e)
         {
             
             pClient.pumpProgress(id, (float)e.LitresPumped);
             form.setQuantity((float)e.LitresPumped);
             
         }

         public void finish()
         {
             gen.PumpingFinished += new CustomerGenerator.PumpingFinishedHandler(gen_PumpingFinished);
         }

         void gen_PumpingFinished(object sender, EventArgs e)
         {
             pClient.PumpingFinished(id);
         }

         public int ID
         {
             get { return id; }
             set { id = value; }
         }
    }
}
