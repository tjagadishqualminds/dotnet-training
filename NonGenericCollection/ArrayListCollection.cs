using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace NonGenericCollection
{
    internal class ArrayListCollection
    {


      


        public void arraylistlistcollection()
        {
            ArrayList flights = new ArrayList();
            Flight f1 = new Flight("AirIndia", 1234);
            Flight f2 = new Flight("Indigo", 5678);
            Flight f3 = new Flight("SpiceJet", 9012);

            flights.Add(f1);
            flights.Add(f2);
            flights.Add(f3);

            while (true)
            {
                Console.WriteLine("Enter a command (Add, Remove, Contains, Clear, Exit):");
                string command = Console.ReadLine().ToLower();

                switch (command)
                {
                    case "add":
                        Console.WriteLine("Enter Flight name:");
                        string flightname = Console.ReadLine();
                        Console.WriteLine("Enter Flight number:");
                        int flightnumber = int.Parse(Console.ReadLine());

                        Flight flight = new Flight(flightname, flightnumber);
                        flights.Add(flight);
                        Console.WriteLine($"Added flight: {flight}");
                        break;

                    case "remove":
                        Console.WriteLine("Enter Flight name to remove:");
                        string frname = Console.ReadLine();
                        bool flightRemoved = false;

                        for (int i = 0; i < flights.Count; i++)
                        {
                            Flight flightToRemove = (Flight)flights[i];

                            if (flightToRemove.FlightName == frname)
                            {
                                flights.RemoveAt(i);
                                flightRemoved = true;
                                break;
                            }
                        }

                        if (!flightRemoved)
                        {
                            Console.WriteLine("Flight not found.");
                        }
                        else
                        {
                            Console.WriteLine("Flight removed.");
                        }
                        break;

                    case "contains":
                        Console.WriteLine("Enter Flight name to check if it exists:");
                        string checkFlightName = Console.ReadLine();

                        bool flightExists = false;

                        foreach (Flight fligh in flights)
                        {
                            if (fligh.FlightName == checkFlightName)
                            {
                                flightExists = true;
                                break;
                            }
                        }

                        if (flightExists)
                        {
                            Console.WriteLine("Flight exists.");
                        }
                        else
                        {
                            Console.WriteLine("Flight does not exist.");
                        }
                        break;

                        case "clear":
                        flights.Clear();
                        Console.WriteLine("ArrayList cleared.");
                        break;


                    case "exit":
                        Environment.Exit(0);
                        break;

                    default:
                        Console.WriteLine("Invalid command.");
                        break;
                }
            }

        }
    }
}
