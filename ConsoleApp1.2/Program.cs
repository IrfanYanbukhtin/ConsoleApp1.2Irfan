using System;

namespace ConsoleApp1._2
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;

            a = int.Parse(Console.ReadLine());

            if (a % 2 == 0)
            {
                Console.WriteLine("even number");
            }
            else
            {
                Console.WriteLine("negative number");

            }
        }
    }
}
