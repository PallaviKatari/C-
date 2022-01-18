using System;
namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 100;
            int y = 0;
            try
            {                
                Console.WriteLine("Outer try block");
                try
                {
                    Console.WriteLine("First inner try block");
                    int z = x / y;
                }
                catch (ArithmeticException e)
                {
                    Console.WriteLine("Error from first inner try block");
                    Console.WriteLine("ERROR : "+e.Message);
                }
                try
                {
                    int[] a = new int[3];
                    a[3] = 40;
                }
                catch (IndexOutOfRangeException e)
                {
                    Console.WriteLine ("Error from second inner try block");
                    Console.WriteLine ("ERROR : " + e.Message);
                }                
            }
            catch (Exception e)
            {
                Console.WriteLine ("Error from outer try block");
            }
            Console.WriteLine ("Control outside the main try block");
            Console.ReadLine ();
        }        
    }
}