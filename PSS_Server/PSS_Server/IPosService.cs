using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace PSS_Server
{
    [ServiceContract(SessionMode = SessionMode.Allowed, CallbackContract = typeof(PosCallbackHandler))]
    public interface IPosService
    {
        [OperationContract(IsOneWay = true)]
        void subscribePos(int posId);

        [OperationContract(IsOneWay = true)]
        void activatePump(int pumpNo);

        [OperationContract(IsOneWay = true)]
        void recordPayment(int posId, string fueltype, float amount);

        [OperationContract]
        void unSubscribePos(int posId);
    }


    public interface PosCallbackHandler
    {
        [OperationContract(IsOneWay = true)]
        void customerWaiting(int pumpNo, string fueltype);

        [OperationContract(IsOneWay = true)]
        void pumpingProgress(int pumpNo, FuelItem update, float price);

        [OperationContract(IsOneWay = true)]
        void finishedPumping(int pumpNo, FuelItem fuel, float price);
    }
}
