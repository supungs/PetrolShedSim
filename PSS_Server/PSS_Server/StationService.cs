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
        static Dictionary<int,int> pumptoPos = new Dictionary<int, int>();
        static Dictionary<int, int> posPumpCount = new Dictionary<int, int>();

        //---- Services for the Pump system ---------------------------
        public void subscribePump(int pumpNo)
        {
            if(!pumplist.ContainsKey(pumpNo)){
                pumplist.Add(pumpNo, OperationContext.Current.GetCallbackChannel<PumpCallbackHandler>());
            }
        }

        public void customerReady(int pumpNo, string fueltype)
        {
            int posId = 0;
            foreach (KeyValuePair<int, int> tuple in posPumpCount){
                if (tuple.Value < 5)
                {
                    posId = tuple.Key;
                    break;
                }
            }
            if (poslist.ContainsKey(posId))
            {
                posPumpCount[posId]++;
                pumptoPos.Add(pumpNo, posId);
                poslist[posId].customerWaiting(pumpNo, fueltype);
            }
            
        }

        public void pumpProgress(int pumpNo, string fueltype, float amount)
        {
            throw new NotImplementedException();
        }

        public void PumpingFinished(int pumpNo, string fueltype)
        {
            int posId = pumptoPos[pumpNo];
            posPumpCount[posId]--;
            pumptoPos.Remove(pumpNo);
            poslist[posId].finishedPumping(pumpNo, fueltype, 10);           // need fuel price
        }



        //---- Services for the POS system  -------------------
        public void subscribePos(int posId)
        {
            if (!poslist.ContainsKey(posId))
            {
                poslist.Add(posId, OperationContext.Current.GetCallbackChannel<PosCallbackHandler>());
                posPumpCount.Add(posId, 0);
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
                posPumpCount.Remove(posId);
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
