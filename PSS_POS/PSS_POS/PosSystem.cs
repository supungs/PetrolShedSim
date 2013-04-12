using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.ServiceModel;
using PSS_POS.PosService;

namespace PSS_POS
{
    public class PosSystem
    {
        private InstanceContext ins;
        private PosServiceClient possclient;
        private PosForm posf;
        Boolean Connected { get; set; }

        public PosSystem(PosForm posf)
        {
            this.posf = posf;
        }

        public Boolean connectToServer(int id)
        {
            ins = new InstanceContext(new PosCBHandler(posf));
            possclient = new PosServiceClient(ins);
            try
            {
                possclient.subscribePos(id);
            }
            catch (EndpointNotFoundException enfe)
            {
                MessageBox.Show(enfe.Message,"Connection timedout");
                return false;
            }
            return true;
        }
        public void disconnect(int id)
        {
            possclient.unSubscribePos(id);
        }

        public void activatePump(int pid)
        {
            possclient.activatePump(pid);
        }

        public void recordPayment(int id,string fueltype,float amount)
        {
            possclient.recordPayment(id, fueltype.ToLower(), amount);
        }
    }

    class PosCBHandler:IPosServiceCallback
    {
        PosForm posf;
        public PosCBHandler(PosForm posf)
        {
            this.posf = posf;
        }

        public void customerWaiting(int pumpNo, string fueltype)
        {
                posf.pumpReady(pumpNo,fueltype);
        }

        public void pumpingProgress(int pumpNo, FuelItem update, float price)
        {
            posf.pumpUpdate(pumpNo, update.Amount, price);
        }

        public void finishedPumping(int pumpNo, FuelItem fuel, float price)
        {
            posf.pumpFinish(pumpNo, fuel.Amount, price);
        }
    }
}
