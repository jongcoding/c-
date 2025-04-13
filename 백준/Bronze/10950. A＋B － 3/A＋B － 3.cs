using System;


namespace ConsoleApp1;

class Program
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        for (int i=0; i<n;i++)
        {
            string[] s = Console.ReadLine().Split(" ");
            int a=int.Parse(s[0]);
            int b=int.Parse(s[1]);
            Console.WriteLine(a + b);
        }
        

    }
}


