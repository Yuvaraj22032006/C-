using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstProject
{
    internal class ForLoopExample
    {
        static void Main(string[] args)
        {
            bool success = true;

            //while loop goes until the correct input is given
            
            while (success)
            {
                Console.WriteLine("Enter a no.: ");
                string numInput = Console.ReadLine();

                if (int.TryParse(numInput, int num);)
                {
                    success = false; //allows the code to exit the while loop when you enter a correct input
                    Console.WriteLine(num);
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a valid integer.");
                }
            }

            Console.ReadLine();
        }
    }
}

