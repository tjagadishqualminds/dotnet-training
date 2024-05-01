using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobileCrudDb
{
    internal class Operations
    {
        MobileOperations mobileOperations = new MobileOperations();


        //add method
        /// <summary>
        /// in add method creating mobilemodal new instance
        /// everytime user select add mob
        /// </summary>
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

           string result =  mobileOperations.ActionOperation($"INSERT INTO mobileInfo VALUES ({mob.MobileId},'{mob.MobileName}',{mob.MobilePrice})");
             Console.WriteLine(result);
            Console.WriteLine("added sucessfully");
                  
        }



        // after user select this option
        //in this method list type will return
        //using foreach print the values

        public void DisplayAllMobile()
        {
          List<MobileModal> mobile = mobileOperations.nonActionOperation($"SELECT * FROM mobileInfo");

            if (mobile != null)
            {
                foreach (MobileModal mobileModal in mobile)
                {
                    
                    Console.WriteLine("Mobile Details");
                    Console.WriteLine($"MobileId:{mobileModal.MobileId}");
                    Console.WriteLine($"MobileName:{mobileModal.MobileName}");
                    Console.WriteLine($"MobilePrice:{mobileModal.MobilePrice}");
                    Console.WriteLine("===========================");
                }
            }
            else
            {
                Console.WriteLine($"mobile not found ");
            }
        }

        //using input id find a single record
        //and ask for user to update the details
        //will pass  mobile
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
              string result =  mobileOperations.ActionOperation($"UPDATE mobileInfo SET mobname = '{mobile1.MobileName}',mobprice={mobile1.MobilePrice} WHERE mobid ={mobile1.MobileId}");
                 Console.WriteLine (result);
            Console.WriteLine("updated sucessfully");
            }
        

        //in this user enter id 
        //using id delete the record
        public void DeleteMobile()
        {
            Console.WriteLine("Enter Mobile ID For Delete Mobile Details");
            int mobid = int.Parse(Console.ReadLine());
           string result = mobileOperations.ActionOperation($"DELETE FROM mobileInfo WHERE mobid ={mobid}");
           Console.WriteLine(result);
            Console.WriteLine("Deleted sucessfully");
        }

    }
}
