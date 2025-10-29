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
            Console.WriteLine("Enter a no.: ");
            string numInput = Console.ReadLine();
            int num = 0;

            bool success = int.TryParse(numInput, out num);

            if (success)
            {
                Console.WriteLine(num);
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid integer.");
            }

            Console.ReadLine();
        }
    }
}
