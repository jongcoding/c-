using System;
using System.Threading.Tasks.Dataflow;
namespace 백준
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                while(true)
                {
                    string[] input = Console.ReadLine().Split();
                    int a = int.Parse(input[0]);
                    int b = int.Parse(input[1]);
                    
                    if (a==0 && b==0)
                    {
                        return;
                    }
                    Console.WriteLine(a + b);
                }
                

            }
            catch
            {
                
            }

            
            
        }
    }
}