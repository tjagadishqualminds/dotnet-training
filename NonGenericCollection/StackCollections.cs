using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Collections;
using System.Threading.Tasks;

namespace NonGenericCollection
{
    /// <summary>
    /// LIFO
    /// LASTINFIRSTOUT
    /// Peek()	
    /// Returns the object at the top of the Stack without removing it.
    /// this method returns the top element from stack without removingit
    /// Pop()	
    ///Removes and returns the object at the top of the Stack.
    ///this methods removes and returns the top element from the stack
    ///Push()	
   /// this method adds an element to the start of the stack
   /// clear()
   /// this method remove all element from the stack
   /// clone
   /// this method a shallow copy creates a new object and copies values of the original objectfields to the new object
    /// </summary>
    
    internal class StackCollections
    {
       public void stackclass()
        {
            
        Stack myStack = new Stack();
            while (true)
            {
                Console.WriteLine("Enter a command (Push, Pop, Peek,Clear,Clone Exit):");
                string command = Console.ReadLine().ToLower();
            switch (command)
                {
                    case "push":
                        Console.WriteLine("Enter Flight name");
                        string flightname = Console.ReadLine();
                        Console.WriteLine("Enter Flight number");
                        int flightnumber = int.Parse(Console.ReadLine());
                        Flight flight =new Flight(flightname,flightnumber);
                        myStack.Push(flight);
                        break;

                    case "pop":
                        if (myStack.Count == 0) // Check for empty stack
                        {
                            Console.WriteLine("Stack is empty. Nothing to pop.");
                        }
                        else
                        {
                            Flight poppedItem =  (Flight)myStack.Pop();
                            Console.WriteLine($"Popped item: {poppedItem}");
                        }
                        break;
                    case "peek":
                        if (myStack.Count == 0) // Check for empty stack
                        {
                            Console.WriteLine("Stack is empty. Nothing to peek.");
                        }
                        else
                        {
                            Flight topItem =(Flight)myStack.Peek();
                            Console.WriteLine($"Top item: {topItem}");
                        }
                        break;
                    case "clear":
                        if (myStack.Count == 0)
                        {
                            Console.WriteLine("Stack is empty. Nothing to clear.");

                        }
                        else
                        {
                           myStack.Clear();
                        }
                        break;
                    case "clone":
                        if (myStack.Count == 0)
                        {
                            Console.WriteLine("Stack is empty. Nothing to clone.");

                        }
                        else
                        {
                            myStack.Clone();
                        }

                        break ;

                    case "exit":
                        Environment.Exit(0);
                        break;


                }



            }
                

        }
    }
}
