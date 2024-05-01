using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NonGenericCollection
{
    /// <summary>
    /// like as hashtable class
    /// stores key value object pair
    /// its key order
    /// </summary>
    internal class SortedListCollection
    {

        public void sortedlistclass()
        {
            SortedList mysortedlist = new SortedList();

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

                        Flight flight = new Flight(flightName, flightNumber);
                        mysortedlist.Add(flightNumber, flight); // Key: Flight Number, Value: Flight object
                        break;

                    case "get":
                        Console.WriteLine("Enter Flight Number to search:");
                        int searchNumber = int.Parse(Console.ReadLine());
                        if (mysortedlist.ContainsKey(searchNumber))
                        {

                            Flight retrievedFlight = (Flight)mysortedlist[searchNumber];
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

                        if (mysortedlist.ContainsKey(removeNumber))
                        {
                            mysortedlist.Remove(removeNumber);
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