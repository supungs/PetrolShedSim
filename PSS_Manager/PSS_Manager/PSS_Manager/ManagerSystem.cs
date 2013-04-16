using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PSS_Manager.ManagerService;

namespace PSS_Manager
{
  public  class ManagerSystem
    {
        private ManagerServiceClient managerClient;
        public String[,] fuelLevels;
        public String[,] fuelOrders;
        public String[,] fuelSales;

        public ManagerSystem()
        {
          
            managerClient = new ManagerServiceClient();
        }

        public String[,] getFuelLevels()
        {
            FuelItem[] x= managerClient.getFuelLevels();
            fuelLevels = new String[x.Length,2];

            for (int i = 0; i < x.Length; i++)
            {
                fuelLevels[i, 0] = x[i].Type;
                fuelLevels[i, 1] = x[i].Amount.ToString();
            }
            return fuelLevels;
        }

        public String[,] getSales(DateTime date)
        {
            FuelItem[] x = managerClient.getSaleData();
            fuelSales = new String[2, 3];
            int j = 0;
            for (int i = 0; i < x.Length; i++)
            {
                if (x[i]!=null && x[i].Date == date)
                {
                    fuelSales[j, 0] = x[i].Type;
                    fuelSales[j, 1] = x[i].Amount.ToString();
                    fuelSales[j, 2] = x[i].Value.ToString();
                    j++;
                }
                
            }
            return fuelSales;
        }

        public String[,] getOrderDetails()
        {
            FuelItem[] x= managerClient.getFuelOrders();
            fuelOrders = new String[2, 3];
            float dieselVol = 0;
            float dieselCost = 0;
            float unleadedVol = 0;
            float unleadedost = 0;

            for (int i = 0; i < x.Length; i++)
            {
                if (x[i].Type == "unleaded")
                {
                    unleadedVol += x[i].Amount;
                    unleadedost += x[i].Value;
                }
                else if(x[i].Type=="diesel")
                {
                    dieselVol += x[i].Amount;
                    dieselCost += x[i].Value;
                }
            }
            fuelOrders[0, 0] = "Unleaded"; fuelOrders[0, 1] = unleadedVol.ToString(); fuelOrders[0, 2] = unleadedost.ToString();
            fuelOrders[1, 0] = "Diesel"; fuelOrders[1, 1] = dieselVol.ToString(); fuelOrders[1, 2] = dieselCost.ToString();
            return fuelOrders;

        }

    }
}
