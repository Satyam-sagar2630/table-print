using System;
namespace app
{
    class Program
    {

        static void Main(string[]arg)
        {
             int i, n, t ;
             Console.WriteLine("enter a number :");
             n = Convert.ToInt32(Console.ReadLine());
             Console.WriteLine("Table is :");
             for(i = 1; i <= 10; i++)
             {
                    t = n * i;
                    Console.WriteLine(t);
                
             }

        }
    }
}