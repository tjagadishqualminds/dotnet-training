using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobileCrudDb
{
    //enums
    enum MobileOptions
    {
        AddMobile,
        DisplayAllMobile,
        UpdateMobile,
        DeleteMobile

    }
    internal class Menu
    {
        public void ReadUserOptions()
        {

            Operations operations = new Operations();
            //loop for showing user select options
            while (true)
            {
                Console.WriteLine("Enter any options");
                Console.WriteLine("0. Add New Mobile Details");
                Console.WriteLine("1. DisplayAllMobile Details");
                Console.WriteLine("2. UpdateMobile");
                Console.WriteLine("3. DeleteMobile");
                //the user's selection and call the appropiate method
                int choice = int.Parse(Console.ReadLine());
                MobileOptions options = (MobileOptions)choice;
                switch (options)
                {
                    case MobileOptions.AddMobile:
                        Console.WriteLine("Add Mobile");
                        operations.addMob();
                        break;

                    case MobileOptions.DisplayAllMobile:
                        Console.WriteLine("DisplayAllMobiles");
                        operations.DisplayAllMobile();
                        break;

                    case MobileOptions.UpdateMobile:
                        Console.WriteLine("UpdateMobile");
                        operations.UpdateMobile();
                        break;

                    case MobileOptions.DeleteMobile:
                        Console.WriteLine("DeleteMobile");
                        operations.DeleteMobile();
                        break;
                }
            }
        }
    }
}
