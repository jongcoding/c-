using System;
using System.Diagnostics.CodeAnalysis;
using System.Numerics;


namespace ConsoleApp1;

class Program
{
    static void Main(string[] args)
    {

        int x = int.Parse(Console.ReadLine());
        int n = int.Parse(Console.ReadLine());
        int total = 0;
        int a, b;
        for (int i=0;i<n;i++)
        {
            string[] s = Console.ReadLine().Split(" ");
            a = int.Parse(s[0]);
            b = int.Parse(s[1]);
            total +=(a*b); 
        }
        if (total == x)
        {
            Console.WriteLine("Yes");
        }    
        else
        {
            Console.WriteLine("No");
        }

    }
}


