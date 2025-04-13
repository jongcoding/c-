using System;


namespace ConsoleApp1;

class Program
{
    static void Main(string[] args)
    {
        string[] input = Console.ReadLine().Split();
        int x = int.Parse(input[0]);
        int y = int.Parse(input[1]);

        if (y>=45)
        {
            y = y - 45;
            Console.WriteLine(x+" "+y);
            
        }
        else
        {
            y = y + 15;
            if (x==0)
            {
                Console.WriteLine("23 " + y);
            }
            else
            {
                Console.WriteLine((x-1)+" "+y);
            }

        }
       
    }
}


