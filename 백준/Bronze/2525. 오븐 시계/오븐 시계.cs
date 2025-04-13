using System;


namespace ConsoleApp1;

class Program
{
    static void Main(string[] args)
    {
        string[] input = Console.ReadLine().Split();
        int c =int.Parse(Console.ReadLine());
        int a = int.Parse(input[0]);
        int b = int.Parse(input[1]);
        int h, s;
        h = c / 60;
        s = c % 60;
        if ((b+s)>=60)
        {
            s = b + s - 60;
           if (a+h >=23)
                h =a+h-23;
           else
                h = a+h+1;
        }
        else
        {
            s = b + s;
            if (a + h >= 24)
                h = a + h - 24;
            else
                h = a + h;
        }
        Console.WriteLine(h+" "+s);
       
    }
}


