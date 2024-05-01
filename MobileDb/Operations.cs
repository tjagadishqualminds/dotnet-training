using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobileDb
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
                    MobileName =mobname,
                    MobilePrice =mobprice
                };
                      
            string message = mobileOperations.addMobile(mob);
            Console.WriteLine(message);
            //Console.WriteLine("Mobile Added Sucessfully");          
        }

        //in this method pass id in return 
        //mobilemodal object
        public void DisplaySingleMobile()
        {
            Console.WriteLine("Enter Mobile Id");
            int mobid = int.Parse(Console.ReadLine());
            MobileModal mobile = mobileOperations.displaySingleMobile(mobid);
          
            if(mobile != null)
            {
            Console.WriteLine("Single Mobile Details");
            Console.WriteLine($"MobileId:{mobile.MobileId}");
            Console.WriteLine($"MobileName:{mobile.MobileName}");
            Console.WriteLine($"MobilePrice:{mobile.MobilePrice}");
            }
            else
            {
                Console.WriteLine($"mobile not found with id {mobid}");
            }
            
          

        }

        // after user select this option
        //in this method list type will return
        //using foreach print the values
        public void DisplayAllMobile()
        {  
         List<MobileModal> mobile = mobileOperations.DisplayAllMobile();

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
        public void UpdateMobile() {
        
            Console.WriteLine("Enter Mobile Id For Update Mobile Details");
            int mobid = int.Parse(Console.ReadLine());
            MobileModal mobile = mobileOperations.displaySingleMobile(mobid);
             if (mobile != null)
            {
                Console.WriteLine("Enter Mobile Name");
                string mobname = Console.ReadLine();
                Console.WriteLine("Enter Mobile Price");
                decimal mobprice = decimal.Parse(Console.ReadLine());
                mobile.MobilePrice = mobprice;
                mobile.MobileName = mobname;
                string result = mobileOperations.UpdateMobileDetails(mobid,mobile);
                Console.WriteLine(result);
            }
        }

        //in this user enter id 
        //using id delete the record
        public void DeleteMobile() {
            Console.WriteLine("Enter Mobile ID For Delete Mobile Details");
           int mobid = int.Parse(Console.ReadLine()) ;
            string result=mobileOperations.deleteMobile(mobid);
            Console.WriteLine(result);
        }
    }
}
