using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobileCrudDs
{
    internal class Operations
    {
        MobileOperations mobileOperations = new MobileOperations();


        //add method taking user input
       // for adding new mobile
        public void addMob()
        {
            Console.WriteLine("Enter Mobile Name");
            string mobname = Console.ReadLine();
            Console.WriteLine("Enter Mobile Id");
            int mobid = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Mobile Price");
            decimal mobprice = decimal.Parse(Console.ReadLine());
            MobileModal mob = new MobileModal
            {
                MobileId = mobid,
                MobileName = mobname,
                MobilePrice = mobprice
            };
            try
            {
            mobileOperations.addMob(mob);
            Console.WriteLine("added sucessfully");
            }
            catch(SqlException ex) {
            Console.WriteLine(ex.Message);
            }

        }



   
        //method for display all mobile
        //from dataset bringing  all data and displayall
        public void DisplayAllMobile()
        {
            try
            {

            Console.WriteLine("All Mobile Details");
         DataSet dataSet =    mobileOperations.DisplayAllMob();
            foreach(DataRow data in dataSet.Tables[0].Rows)
            {
                Console.WriteLine($"MobileId: {data[0]}, MobileName: {data[1]}, MobilePrice: {data[2]}");
            }
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.Message);
            }

        }

        //in this method taking user id
        //displaying a single record
        public void DisplayMobile()
        {
            try
            {

            Console.WriteLine("Enter Mobile ID For Display Mobile Details");
            int mobid = int.Parse(Console.ReadLine());
         DataRow data =   mobileOperations.DisplayMobile(mobid);
            Console.WriteLine($"MobileId: {data[0]}, MobileName: {data[1]}, MobilePrice: {data[2]}");
            }
            catch(SqlException ex)
            {
                Console.WriteLine(ex.Message);
            }

        }

        //in this method taking user inputs
        //updating updating mobile details
        public void UpdateMobile()
        {
            Console.WriteLine("Enter Mobile Id For Update Mobile Details");
            int mobid = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Mobile Name");
            string mobname = Console.ReadLine();
            Console.WriteLine("Enter Mobile Price");
            decimal mobprice = decimal.Parse(Console.ReadLine());
            MobileModal mobile1 = new MobileModal();
            mobile1.MobileId = mobid;
            mobile1.MobilePrice = mobprice;
            mobile1.MobileName = mobname;
            try
            {
               mobileOperations.UpdateMob(mobile1);
            Console.WriteLine("updated sucessfully");

            }
            catch (SqlException ex) { Console.WriteLine( ex.Message); }
         
        }


        //in this method user enter id 
        //using id deleting the record
        public void DeleteMobile()
        {
            Console.WriteLine("Enter Mobile ID For Delete Mobile Details");
            int mobid = int.Parse(Console.ReadLine());
            try
            {
            mobileOperations.DeletMob(mobid);
            Console.WriteLine($"Deleted successfully of id {mobid}");

            }
            catch(SqlException ex) {
            Console.WriteLine( ex.Message);
            }

        }

    }
}
