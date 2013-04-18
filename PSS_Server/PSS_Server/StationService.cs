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
        static Dictionary<int, Tuple> pumptoPos = new Dictionary<int, Tuple>();
        static Dictionary<int, int> posPumpCount = new Dictionary<int, int>();
        static Dictionary<int, float> fuelConsume = new Dictionary<int, float>();

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
            if (poslist.ContainsKey(posId) && !pumptoPos.ContainsKey(pumpNo))
            {
                posPumpCount[posId]++;
                pumptoPos.Add(pumpNo, new Tuple(posId,new FuelItem(fueltype,0)));
                poslist[posId].customerWaiting(pumpNo, fueltype);
            }
            
        }

        public void pumpProgress(int pumpNo, float amount)
        {
            int posId = pumptoPos[pumpNo].Pos;
            float price = getPrice(pumptoPos[pumpNo].Fuel.Type);
            pumptoPos[pumpNo].Fuel.Amount = amount;
            poslist[posId].pumpingProgress(pumpNo, pumptoPos[pumpNo].Fuel, price);
        }

        public void PumpingFinished(int pumpNo)
        {
            try
            {
                int posId = pumptoPos[pumpNo].Pos;
                posPumpCount[posId]--;
                DataHandler.Instance.reduceFuel(pumptoPos[pumpNo].Fuel.Type, pumptoPos[pumpNo].Fuel.Amount);
                float price = getPrice(pumptoPos[pumpNo].Fuel.Type);
                poslist[posId].finishedPumping(pumpNo, pumptoPos[pumpNo].Fuel, price);
                pumptoPos.Remove(pumpNo);
            }
            catch { }
        }



        //---- Services for the POS system  -------------------
        public void subscribePos(int posId)
        {
            getPrice("unleaded");
            if (!poslist.ContainsKey(posId))
            {
                poslist.Add(posId, OperationContext.Current.GetCallbackChannel<PosCallbackHandler>());
                posPumpCount.Add(posId, 0);
            }
        }

        public void activatePump(int pumpNo)
        {
            float price = getPrice(pumptoPos[pumpNo].Fuel.Type);
            pumplist[pumpNo].activateMe(price);
        }

        public void recordPayment(int posId,string fueltype, float amount)
        {
            DataHandler.Instance.updateSale(fueltype,amount);
        }

        public void unSubscribePos(int posId)
        {
            if (poslist.ContainsKey(posId))
            {
                poslist.Remove(posId);
                posPumpCount.Remove(posId);
                try
                {
                    if (poslist.Count == 0)
                        DataHandler.Instance.sendReports();
                }
                catch { }
            }
        }



        //---- Services for the Manager system  ----------------
        public FuelItem[] getFuelLevels()
        {
            DataHandler.Instance.sendReports();
            return DataHandler.Instance.getFuelLevel();
        }

        public FuelItem[] getSaleData()
        {
            return DataHandler.Instance.getSaleData();
        }

        public int getNumofCustomers()
        {
            DataHandler.Instance.setPrice("diesel", (float)1.2);
            return pumptoPos.Count;
        }

        public FuelItem[] getFuelOrders()
        {
            return DataHandler.Instance.getFuelOrders();
        }

        public void setPrice(string fueltype, float price)
        {
            DataHandler.Instance.setPrice(fueltype, price);
        }

        //common functions
        public float getPrice(string fuelType)
        {
            return DataHandler.Instance.getPrice(fuelType);
        }

    }

    class Tuple
    {
        public Tuple(int pos, FuelItem fuel)
        {
            this.Pos = pos;
            this.Fuel = fuel;
        }
        public int Pos { get; set; }
        public FuelItem Fuel { get; set; }
    }
}
