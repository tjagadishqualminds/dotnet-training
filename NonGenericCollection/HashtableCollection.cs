using System.Collections;


using NonGenericCollection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NonGenericCollection
{
    /// <summary>
    /// hashable class is key value
    /// it is added on key value based
    /// use key we can retrive the value
    /// using key we can remove the object
    /// </summary>
    internal class HashtableCollection
    {
        public void hashclass()
        {
            Hashtable myHashtable = new Hashtable();

            while (true)
            {
                Console.WriteLine("Enter a command (Add, Get, Remove, Exit):");
                string command = Console.ReadLine().ToLower();

                switch (command)
                {
                    case "add":
                        Console.WriteLine("Enter Flight Name:");
                        string flightName = Console.ReadLine();
                        Console.WriteLine("Enter Flight Number:");
                        int flightNumber = int.Parse(Console.ReadLine());
                        Flight flight = new Flight( flightNumber,flightName);
                        myHashtable.Add(flightNumber, flight); // Key: Flight Number, Value: Flight object
                        break;

                    case "get":
                        Console.WriteLine("Enter Flight Number to search:");
                        int searchNumber = int.Parse(Console.ReadLine());
                        if (myHashtable.ContainsKey(searchNumber))
                        {

                        Flight retrievedFlight = (Flight)myHashtable[searchNumber];
                            Console.WriteLine("Flight Information");                      
                            Console.WriteLine(retrievedFlight);
                        }
                  
                        else
                        {
                            Console.WriteLine("Flight not found.");
                        }
                        break;

                    case "remove":
                        Console.WriteLine("Enter Flight Number to remove:");
                        int removeNumber = int.Parse(Console.ReadLine());

                        if (myHashtable.ContainsKey(removeNumber))
                        {
                                      myHashtable.Remove(removeNumber);
                            Console.WriteLine("Flight removed successfully");
      

                        }
                        else
                        {
                            Console.WriteLine("Flight not found.");
                        }
                        break;

                    case "exit":
                        Environment.Exit(0);
                        break;

                    default:
                        Console.WriteLine("Invalid command. Please try again.");
                        break;
                }
            }


        }
    }
}
