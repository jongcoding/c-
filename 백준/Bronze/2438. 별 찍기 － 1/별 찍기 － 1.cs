using System;
using System.IO;
using System.Text;

namespace _04_FastAddition
{
    class Program
    {
        static void Main(string[] args)
        {
            int numOfTimes = int.Parse(Console.ReadLine());

            for (int i = 0; i < numOfTimes; i++)
            {
                for (int j = 0; j < i+1; j++)
                {
                    Console.Write("*");
                }
                Console.Write("\n");
            }

        }
    }

}