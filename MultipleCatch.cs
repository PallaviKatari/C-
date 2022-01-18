using System;
namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            int [ ] firstArr = { 3,9,18,36,72,144,288,576 };
            int [ ] secondArr = { 3, 0, 6, 6, 0, 9 };
            for (int i = 0; i < firstArr.Length; i++)
            {
                try
                {
                    Console.WriteLine(firstArr[i] + " / " +
                    secondArr[i] + " is " +
                    firstArr[i] / secondArr[i]);
                }
                catch (DivideByZeroException e)
                {
                    Console.WriteLine("ERROR : "+e.Message);
                }
                catch (IndexOutOfRangeException e)
                {
                    Console.WriteLine("ERROR : " + e.Message);
                }
               
            }
                 Console.ReadLine();
        }
    }
}