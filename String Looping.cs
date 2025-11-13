using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace C_PROJECTS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a string : ");
            string input = Console.ReadLine();

            for (int i = 0; i < input.Length; i++)
            {
                Console.Write(input[i]);
                Thread.Sleep(100);
            }
            Console.WriteLine();
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i].Equals('a'))
                {
                    Console.WriteLine("Your string contains 'a' ");
                }
                else if (input[i].Equals('A'))
                {
                    Console.WriteLine("Your string starts with 'A' ");
                }
                else
                {
                    Console.WriteLine("Your can't be considered");
                }
            }

            Console.ReadLine();
        }
    }
}
