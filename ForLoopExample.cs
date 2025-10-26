using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstProject
{
    internal class ForLoopExample
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What do you want to repeat?: ");
            string message = Console.ReadLine();

            Console.WriteLine("How many times do you want to repeat it?: ");
            int repeatCount = Convert.ToInt32(Console.ReadLine());

            if (repeatCount <= 0) {
                Console.WriteLine("The number must be greater than zero.");
            } else {
                for (int i = 0; i < repeatCount; i++)
                {
                    Console.WriteLine(message);
                }
            }

            Console.ReadLine();
        }
    }
}
