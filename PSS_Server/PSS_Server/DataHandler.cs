using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data.SQLite;
using System.Data;

namespace PSS_Server
{
    class DataHandler
    {
        private static DataHandler instance;
        SQLiteConnection dbConnection = null;

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
            command = new SQLiteCommand("create table fuelsale (date DATETIME PRIMARY KEY,volpetrol real,voldiesel real, salepetrol real,salediesel real )", dbConnection);
            command.ExecuteNonQuery();
            command = new SQLiteCommand("create table fuelorders (orderid int PRIMARY KEY, date DATETIME, fueltype varchar(20), volume real,cost real )", dbConnection);
            command.ExecuteNonQuery();

            command = new SQLiteCommand("insert into tank (fueltype, volume,capacity,price) values ('petrol', 1000,1000,10)", dbConnection);
            command.ExecuteNonQuery();
            command = new SQLiteCommand("insert into tank (fueltype, volume,capacity,price) values ('diesel', 1000,1000,10)", dbConnection);
            command.ExecuteNonQuery();

            dbConnection.Close();
        }

        public  float getPrice(string fueltype)
        {
            dbConnection.Open();
            float price = 0;
            SQLiteCommand command = new SQLiteCommand("select * from tank where fueltype='"+ fueltype + "'", dbConnection);
            SQLiteDataReader myReader = command.ExecuteReader();
            while (myReader.Read())
            {
                price = float.Parse(myReader["price"].ToString());
            }
            dbConnection.Close();
            return 0;
        }

        public void reduceFuel(string fueltype, float amount)
        {
            SQLiteCommand command = new SQLiteCommand("update tank set price=price-" + amount + " where fueltype='" + fueltype + "'", dbConnection);
            command.ExecuteNonQuery();
        }


        public Boolean tableExist(String tableName)
        {
            SQLiteCommand cmd = new SQLiteCommand(dbConnection);
            cmd.CommandText = "SELECT name FROM sqlite_master WHERE name='" + tableName + "'";
            SQLiteDataReader rdr = cmd.ExecuteReader();
            if (rdr.HasRows)
                return true;
            else
                return false;
        }
    }
}
