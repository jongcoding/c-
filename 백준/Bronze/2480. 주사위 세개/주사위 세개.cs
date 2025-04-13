using System;


namespace ConsoleApp1;

class Program
{
    static void Main(string[] args)
    {
        string[] input = Console.ReadLine().Split();
        int a = int.Parse(input[0]);
        int b = int.Parse(input[1]);
        int c = int.Parse(input[2]);
        int[] x = { a, b, c };
        int result = 0;
        if (a==b && b==c)
        {
            result = 10000 + a * 1000;
        }
        else if(a==b)
            result = 1000+100*a;
        else if(b==c)
            result=1000+100*b;
        else if(a==c)
            result = 1000+100*c;
        else
        {
            Array.Sort(x);
            result = x[2]*100;
        }
        Console.WriteLine(result);
    }
}


