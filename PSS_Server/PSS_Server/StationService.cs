using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace PSS_Server
{
    public class StationService : IPosService, IPumpService, IManagerService
    {
        static Dictionary<int, PumpCallbackHandler> pumplist = new Dictionary<int, PumpCallbackHandler>();
        static Dictionary<int, PosCallbackHandler> poslist = new Dictionary<int, PosCallbackHandler>();

        //---- Services for the Pump system ---------------------------
        public void subscribePump(int pumpNo)
        {
            if(!pumplist.ContainsKey(pumpNo)){
                pumplist.Add(pumpNo, OperationContext.Current.GetCallbackChannel<PumpCallbackHandler>());
            }
        }

        public void customerReady(int pumpNo, string fueltype)
        {
            throw new NotImplementedException();
        }

        public void pumpProgress(int pumpNo, string fueltype, float amount)
        {
            throw new NotImplementedException();
        }

        public void PumpingFinished(int pumpNo, string fueltype)
        {
            throw new NotImplementedException();
        }



        //---- Services for the POS system  -------------------
        public void subscribePos(int posId)
        {
            if (!poslist.ContainsKey(posId))
            {
                poslist.Add(posId, OperationContext.Current.GetCallbackChannel<PosCallbackHandler>());
            }
        }

        public void activatePump(int pumpNo)
        {
            throw new NotImplementedException();
        }

        public void recordPayment(int posId, float amount)
        {
            throw new NotImplementedException();
        }

        public void unSubscribePos(int posId)
        {
            if (poslist.ContainsKey(posId))
            {
                poslist.Remove(posId);
            }
        }



        //---- Services for the Manager system  ----------------
        public FuelItem[] getFuelLevels()
        {
            throw new NotImplementedException();
        }

        public FuelItem[] getSaleData()
        {
            throw new NotImplementedException();
        }

    }
}
