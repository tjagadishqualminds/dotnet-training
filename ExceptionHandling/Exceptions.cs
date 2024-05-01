using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling
{
    internal class Exceptions
    {
        public void execptions()
        {
            try
            {
                Console.WriteLine("Enter a number for divide");
                int num = int.Parse(Console.ReadLine());
                int result = 10 / num;
                try
                {
                    Console.WriteLine("empid");
                    int empid = int.Parse(Console.ReadLine());
                    Console.WriteLine($"Entered emp id{empid}");
                    int[] arr = { 0, 2, 3 };
                   // Console.WriteLine(arr[3]);
                    string text = null;
                
       
                }

                catch (NullReferenceException ex) { 
                Console.WriteLine(ex.Message);
                }
                catch (FormatException ex)
                {
                    Console.WriteLine($"{ex.Message}");
                }
                catch (IndexOutOfRangeException ex)
                {
                    Console.WriteLine($"{ex.Message}");
                }
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"General Exception: {ex.Message}");
                //it will caught any exception occurs
            }
            finally
            {
                Console.WriteLine("This will always be executed, regardless of whether an exception is thrown or not.");
            }
            Console.ReadLine();

        }
    }
}

