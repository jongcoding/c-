using System;

namespace 백준
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());

            for(int i =0; i<input; i++)
            {   
                for(int p=i; p<input-1; p++)
                {
                    Console.Write(' ');
                }
                for(int j=0; j<i+1; j++)
                {
                    Console.Write('*');
                }
                Console.WriteLine();
            }
            
            
        }
    }
}