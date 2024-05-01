using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace NonGenericCollection
{
    /// <summary>
    /// its FIFO 
    /// FIRST IN FIRST OUT
    /// Enqueue method is used to add object end of the collection
    /// dequeue method is used to remove object from the start of the collection
    /// peek method retrieve the first item in the queue without removing it
    /// </summary>
    internal class QueueCollection
    {
        public void queueClass() {
            Queue myQueue = new Queue(); // Create a Queue instance

            while (true)
            {
                Console.WriteLine("Enter a command (Enqueue, Dequeue, Peek, Exit):");
                string command = Console.ReadLine().ToLower();

                switch (command)
                {
                    case "enqueue":
                        Console.WriteLine("Enter Flight name");
                        string flightName = Console.ReadLine();
                        Console.WriteLine("Enter Flight number");
                        int flightNumber = int.Parse(Console.ReadLine());
                        Flight flight = new Flight(flightName, flightNumber);
                        myQueue.Enqueue(flight);
                        break;

                    case "dequeue":
                        if (myQueue.Count == 0)
                        {
                            Console.WriteLine("Queue is empty. Nothing to dequeue.");
                        }
                        else
                        {
                            Flight dequeuedFlight = (Flight)myQueue.Dequeue();
                            Console.WriteLine($"Dequeued item: {dequeuedFlight}"); 
                        }
                        break;

                    case "peek":
                        if (myQueue.Count == 0)
                        {
                            Console.WriteLine("Queue is empty. Nothing to peek.");
                        }
                        else
                        {
                            Flight topFlight = (Flight)myQueue.Peek();
                            Console.WriteLine($"Top item: {topFlight}");
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
