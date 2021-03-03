using System;

namespace Task_3
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("How many ticket:");
                var a=double.Parse(Console.ReadLine());
                Console.WriteLine("Ticket price:");
                var b = double.Parse(Console.ReadLine());
                var c = a * b;
                Console.WriteLine($"Price:{c}");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                
            }
            finally
            {
                Console.WriteLine("Please visit us Again");
            }
        }
    }
}
