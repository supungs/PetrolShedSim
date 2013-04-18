using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace PSS_Server
{
    [ServiceContract]
    public interface IManagerService
    {
        [OperationContract]
        FuelItem[] getFuelLevels();

        [OperationContract]
        FuelItem[] getSaleData();

        [OperationContract]
        int getNumofCustomers();

        [OperationContract]
        FuelItem[] getFuelOrders();

        [OperationContract(IsOneWay = true)]
        void setPrice(string fueltype,float price);
    }


    [DataContract]
    public class FuelItem
    {
        public FuelItem(string type, float amount)
        {
            this.Type = type;
            this.Amount = amount;
        }
        public FuelItem(string type, float amount,float value ,DateTime date)
        {
            this.Type = type;
            this.Amount = amount;
            this.Value = value;
            this.Date = date;
        }

        [DataMember]
        public string Type { get; set; }

        [DataMember]
        public float Amount { get; set; }

        [DataMember]
        public float Value { get; set; }

        [DataMember]
        public DateTime Date { get; set; }
    }
}
