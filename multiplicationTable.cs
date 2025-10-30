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
            Console.WriteLine("Enter the number to display its multiplication table:");
            int number = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine("{0} x {1} = {2}", number, i, number * i);
                int multiply = number * i;
                Console.WriteLine($"{number} x {i} = {multiply}");
            }

            Console.ReadLine();
        }
    }
}
