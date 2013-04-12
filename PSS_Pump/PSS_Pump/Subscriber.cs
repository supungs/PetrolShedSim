using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceModel;
using PSS_Pump.PumpServiceReference;
using PumpLibrary;
using System.Windows.Forms;

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
            Subscriber.price = price;
        }

        #endregion
    }

  public  class Subscriber 
    {
         static int id;
         public static float price;
         InstanceContext ins ;
         PumpServiceClient pClient;
         CustomerGenerator gen;
         Form1 form;

         public Subscriber(Form1 f)
         {
             if (id <= 20)
             {
                 id = id + 1;
             }
             else
             {
                 id = 1;
             }
             form = f;
             Random rnd = new Random();
             id = rnd.Next(20);
         }

         public void startSubscriber()
         {
                 gen = new CustomerGenerator();
                 gen.CustomerReady += gen_CustomerReady;
                 gen.PumpProgress += gen_PumpProgress;
                 gen.PumpingFinished += gen_PumpingFinished;
         }

         void gen_CustomerReady(object sender, CustomerReadyEventArgs e)
         {
             if (pClient == null)
             {
                 ins = new InstanceContext(new MyClass(gen));
                 pClient = new PumpServiceClient(ins);
                 pClient.subscribePump(id);
             }
             try
             { 
                 form.Invoke((MethodInvoker)delegate
                 {
                     form.setType(e.SelectedFuel.ToString());
                     form.setQuantity(0);
                     form.setPrice("0");
                     form.setStatus("Customer waiting");
                 });
                 pClient.customerReady(id,e.SelectedFuel.ToString().ToLower());
             }
             catch (InvalidOperationException ee)
             {
             }
        }

         void gen_PumpProgress(object sender, PumpProgressEventArgs e)
         {
             try
             {
                 form.Invoke((MethodInvoker)delegate
                 {
                     form.setQuantity((float)e.LitresPumped);
                     form.setPrice( ""+ Subscriber.price * e.LitresPumped);
                     form.setStatus("Customer pumping");
                 });
                 pClient.pumpProgress(id, (float)e.LitresPumped);
             }
             catch (InvalidOperationException ee)
             {
                 MessageBox.Show("InvalidOperationException");
             }
         }

         void gen_PumpingFinished(object sender, EventArgs e)
         {
             pClient.PumpingFinished(id);
             form.Invoke((MethodInvoker)delegate
             {
                 form.setStatus("Customer finished pumping");
             });
         }

         public int ID
         {
             get { return id; }
             set { id = value; }
         }
    }
}
