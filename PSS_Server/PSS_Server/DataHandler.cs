using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data.SQLite;
using System.Data;
using PSS_Server.FuelSupplyService;
using PSS_Server.ReportService;

namespace PSS_Server
{
    class DataHandler
    {
        private static DataHandler instance;
        SQLiteConnection dbConnection = null;
        Dictionary<string, float> prices = new Dictionary<string, float>();

        internal static DataHandler Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new DataHandler();
                }
                return instance;
            }
        }
        public DataHandler()
        {
            this.initDBConnecton();
        }

        public void initDBConnecton(){
            dbConnection = new SQLiteConnection("Data Source=data.sqlite;Version=3;");
            if (!tableExist("tank"))
            {
                createNewDB();
            }
        }

        public void createNewDB()
        {
            dbConnection.Open();

            SQLiteCommand command = new SQLiteCommand("create table tank (fueltype varchar(20) PRIMARY KEY, volume real, capacity real, price real)", dbConnection);
            command.ExecuteNonQuery();
            command = new SQLiteCommand("create table fuelsale (date varchar(20) PRIMARY KEY,volunleaded real,voldiesel real, saleunleaded real,salediesel real )", dbConnection);
            command.ExecuteNonQuery();
            command = new SQLiteCommand("create table fuelorders (orderid varchar(20) PRIMARY KEY, date DATETIME, fueltype varchar(20), volume real,cost real )", dbConnection);
            command.ExecuteNonQuery();

            command = new SQLiteCommand("insert into tank (fueltype, volume,capacity,price) values ('unleaded', 1000,1000,13)", dbConnection);
            command.ExecuteNonQuery();
            command = new SQLiteCommand("insert into tank (fueltype, volume,capacity,price) values ('diesel', 1000,1000,10)", dbConnection);
            command.ExecuteNonQuery();

            dbConnection.Close();
        }

        public  float getPrice(string fueltype)
        {
            if (!prices.ContainsKey(fueltype))
            {
                dbConnection.Open();
                float price = 0;
                SQLiteCommand command = new SQLiteCommand("select * from tank where fueltype='" + fueltype + "'", dbConnection);
                SQLiteDataReader myReader = command.ExecuteReader();
                while (myReader.Read())
                {
                    string a = myReader["price"].ToString();
                    price = float.Parse(a);
                }
                prices.Add(fueltype, price);
                dbConnection.Close();
            }
            return prices[fueltype];
        }

        public void reduceFuel(string fueltype, float amount)
        {
            dbConnection.Open();
            SQLiteCommand command = new SQLiteCommand("update tank set volume=volume-" + amount + " where fueltype='" + fueltype + "'", dbConnection);
            command.ExecuteNonQuery();

            string clm = "vol" + fueltype;
            string rplc = clm + "=" + clm + " + " + amount;
            command = new SQLiteCommand("update fuelsale set " + rplc + " where date=strftime('%Y-%m-%d', 'now')", dbConnection);
            int affect = command.ExecuteNonQuery();
            if (affect == 0)
            {
                command = new SQLiteCommand("insert into fuelsale (date,volunleaded,voldiesel,saleunleaded,salediesel) values(strftime('%Y-%m-%d', 'now'),0,0,0,0)", dbConnection);
                command.ExecuteNonQuery();
                command = new SQLiteCommand("update fuelsale set " + rplc + " where date=strftime('%Y-%m-%d', 'now')", dbConnection);
                command.ExecuteNonQuery();
            }
            dbConnection.Close();

            checkFuelLevels();
        }

        public void updateSale( string fueltype, float amount)
        {
            dbConnection.Open();
            string clm = "sale" + fueltype;
            string rplc=clm + "=" + clm + " + " + amount;
            SQLiteCommand command = new SQLiteCommand("update fuelsale set "+ rplc + " where date=strftime('%Y-%m-%d', 'now')", dbConnection);
            int affect=command.ExecuteNonQuery();
            if (affect == 0)
            {
                command = new SQLiteCommand("insert into fuelsale (date,volunleaded,voldiesel,saleunleaded,salediesel) values(strftime('%Y-%m-%d', 'now'),0,0,0,0)", dbConnection);
                command.ExecuteNonQuery();
                command = new SQLiteCommand("update fuelsale set " + rplc + " where date=strftime('%Y-%m-%d', 'now')", dbConnection);
                command.ExecuteNonQuery();
            }
            dbConnection.Close();
        }

        public FuelItem[] getFuelLevel()
        {
            dbConnection.Open();
            FuelItem[] arr = new FuelItem[2];
            SQLiteCommand command = new SQLiteCommand("select fueltype,volume from tank", dbConnection);
            SQLiteDataReader myReader = command.ExecuteReader();
            int i = 0;
            while (myReader.Read())
            {
                string a = myReader["volume"].ToString();
                string fuel=myReader["fueltype"].ToString();
                arr[i] = new FuelItem(fuel,float.Parse(a));
                i++;
            }
            dbConnection.Close();
            return arr;
        }

        public void checkFuelLevels(){
            FuelItem[] flvl = getFuelLevel();
            for (int i = 0; i < 2; i++)
            {
                if (flvl[i].Amount < 200)
                    orderFuel(flvl[i].Type, 800);
            }
        }

        public FuelItem[] getSaleData()
        {
            dbConnection.Open();
            FuelItem[] arr = new FuelItem[7];
            SQLiteCommand command = new SQLiteCommand("select * from fuelsale", dbConnection);
            SQLiteDataReader myReader = command.ExecuteReader();
            int i = 0;
            while (myReader.Read())
            {
                //date,volunleaded,voldiesel,saleunleaded,salediesel
                DateTime date = DateTime.Parse(myReader["date"].ToString());
                if (date <= DateTime.Now.AddDays(-7))
                    continue;
                arr[i] = new FuelItem("unleaded", float.Parse(myReader["volunleaded"].ToString()), float.Parse(myReader["saleunleaded"].ToString()), date);
                arr[i + 1] = new FuelItem("diesel", float.Parse(myReader["voldiesel"].ToString()), float.Parse(myReader["salediesel"].ToString()), date);
                i = i+ 2;
            }
            dbConnection.Close();
            return arr;
        }

        public void orderFuel(string fueltype, int amount)
        {
            FuelSupplyServiceClient fsclient = new FuelSupplyServiceClient();
            FuelPurchaseOrder fporder = new FuelPurchaseOrder();
            fporder.FuelType = fueltype;
            fporder.Quantity = amount;
            FuelPurchaseConfirmation fpconfirm=  fsclient.PurchaseFuel(fporder);

            dbConnection.Open();
            SQLiteCommand command = new SQLiteCommand("insert into fuelorders (orderid, date, fueltype, volume,cost) values('" +
                    fpconfirm.OrderReference + "',strftime('%Y-%m-%d', 'now'),'" + fueltype + "'," + amount + "," + fpconfirm.TotalPrice + ")", dbConnection);
            command.ExecuteNonQuery();
            command = new SQLiteCommand("update tank set volume=volume+" + amount + " where fueltype='" + fueltype + "'", dbConnection);
            command.ExecuteNonQuery();
            dbConnection.Close();
        }

        public FuelItem[] getFuelOrders()
        {
            dbConnection.Open();
            FuelItem[] arr = new FuelItem[30];
            SQLiteCommand command = new SQLiteCommand("select date, fueltype, volume,cost from fuelorders", dbConnection);
            SQLiteDataReader myReader = command.ExecuteReader();
            int i = 0;
            while (myReader.Read())
            {
                DateTime date = DateTime.Parse(myReader["date"].ToString());
                if (date <= DateTime.Now.AddDays(-7))
                    continue;
                string fuel = myReader["fueltype"].ToString();
                string vol = myReader["volume"].ToString();
                string cost = myReader["cost"].ToString();
                arr[i] = new FuelItem(fuel, float.Parse(vol), float.Parse(vol),date);
                i++;
            }
            dbConnection.Close();
            return arr;
        }

        public void sendReports()
        {
            ReportServiceClient rclient = new ReportServiceClient();
            DailyReport dr = new DailyReport();
            dr.Date = DateTime.Now.Date;
            FuelItem[] prchs=getFuelOrders();
            FuelData[] purchase = new FuelData[2];

            purchase[0] = new FuelData();
            purchase[1] = new FuelData(); 
            for (int i = 0; i < prchs.Length; i++)
			{
			    if(prchs[i]!=null && prchs[i].Date==dr.Date)
                {
                    int ind = 1;
                    if (prchs[i].Type == "unleaded")
                        ind = 0;
                    purchase[ind].FuelType = prchs[i].Type;
                    purchase[ind].Quantity += prchs[i].Amount;
                    purchase[ind].Value += prchs[i].Value;
                 }
			}
            dr.Purchases = purchase;

            FuelItem[] sl = getSaleData();
            FuelData[] sales=new FuelData[2];
            sales[0] = new FuelData();
            sales[1] = new FuelData(); 
            for (int i = 0; i < sl.Length; i++)
            {
                if (sl[i] != null && sl[i].Date == dr.Date)
                {
                    int ind = 1;
                    if (sl[i].Type == "unleaded")
                        ind = 0;
                    sales[ind].FuelType = sl[i].Type;
                    sales[ind].Quantity = sl[i].Amount;
                    sales[ind].Value = sl[i].Value;
                }
            }
            dr.Sales = sales;
            rclient.SendDailyReport(dr);
        }

        public Boolean tableExist(String tableName)
        {
            Boolean rtn;
            dbConnection.Open();
            SQLiteCommand cmd = new SQLiteCommand(dbConnection);
            cmd.CommandText = "SELECT name FROM sqlite_master WHERE name='" + tableName + "'";
            SQLiteDataReader rdr = cmd.ExecuteReader();

            if (rdr.HasRows)
                rtn= true;
            else
                rtn =false;

            dbConnection.Close();
            return rtn;
        }
    }
}
