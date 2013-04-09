using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace PSS_Server
{
    [ServiceContract(SessionMode = SessionMode.Allowed, CallbackContract = typeof(PumpCallbackHandler))]
    public interface IPumpService
    {
        [OperationContract(IsOneWay = true)]
        void subscribePump(int pumpNo);

        [OperationContract(IsOneWay = true)]
        void customerReady(int pumpNo,string fueltype);

        [OperationContract(IsOneWay = true)]
        void pumpProgress(int pumpNo,string fueltype, float amount);

        [OperationContract(IsOneWay = true)]
        void PumpingFinished(int pumpNo, string fueltype);
    }


    public interface PumpCallbackHandler
    {
        [OperationContract(IsOneWay = true)]
        void activateMe(float price);
    }

}
