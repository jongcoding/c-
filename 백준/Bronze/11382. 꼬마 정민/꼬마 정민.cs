using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ');
            double a=double.Parse(input[0]);
            double b=double.Parse(input[1]);
            double c=double.Parse(input[2]);
            Console.WriteLine(a + b + c);

        }
    }
}
