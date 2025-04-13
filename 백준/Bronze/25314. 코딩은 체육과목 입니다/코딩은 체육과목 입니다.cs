using System;
using System.Diagnostics.CodeAnalysis;
using System.Numerics;


namespace ConsoleApp1;

class Program
{
    static void Main(string[] args)
    {

        
        int n = int.Parse(Console.ReadLine());
        int count = n / 4;
        for (int i = 0; i < count; i++)
        {
            Console.Write("long ");
        }
        Console.Write("int");
    }
}


