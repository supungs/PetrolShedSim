using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PSS_Pump
{
    
    class PumpingProgress

    {

       public delegate void ProgressHandler(object o, int id, PumpingProgressEvent e);

       public static event ProgressHandler ProgressEvent;

       protected virtual void OnProgressEvent(int id,PumpingProgressEvent e)
       {
           if (ProgressEvent != null)
               ProgressEvent(this,id, e);
       }

       public static void update()
       {
           CustomerGenerator cg = new CustomerGenerator();
           ProgressEvent += new ProgressHandler(cg.pumpProgress);
           notify();
       }

       public static void notify()
       {
       }
    }
}
