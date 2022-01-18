

using System;
using System.Collections;
using System.Collections.Generic;
//You can also re-throw an exception from the catch block to pass on to the caller and let the caller handle it the way they want. 
//The following example re-throws an exception.
public class Program
{
    public static void Main()
    {
        try
        {
            Method1();
        }
        catch (Exception ex)
        {
            Console.Write(ex.StackTrace);
        }
    }

    public static void Method1()
    {
        try
        {
            Method2();
        }
        catch (NullReferenceException ex)
        {
            throw; //throw ex;
        }
    }

    public static void Method2()
    {
        int a = 10;
        int b = 0;
        try
        {
            Console.WriteLine(a/b);
        }
        catch (DivideByZeroException)
        {
            throw;
        }
    }
}