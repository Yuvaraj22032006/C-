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

            while (success)
            {
                Console.WriteLine("Enter a no.: ");
                string numInput = Console.ReadLine();

                if (int.TryParse(numInput, int num);)
                {
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
