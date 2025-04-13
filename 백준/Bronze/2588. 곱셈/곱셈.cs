using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int input1 = int.Parse(Console.ReadLine());
            int result = 0;
            string input2 = Console.ReadLine();
            int a = input1 * int.Parse(input2[2].ToString());
            int b = input1 * int.Parse(input2[1].ToString());
            int c = input1 * int.Parse(input2[0].ToString());
            result= a + 10*b + 100*c;
            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);
            Console.WriteLine(result);


        }
    }
}
