using System;
namespace ExceptionHandlingDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c;
            Console.WriteLine("ENTER ANY TWO NUBERS");
            try
            {
                a = int.Parse(Console.ReadLine());
                b = int.Parse(Console.ReadLine());
                c = a / b;
                Console.WriteLine("C VALUE = " + c);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.Source);
                Console.WriteLine(ex.StackTrace);
                Console.WriteLine(ex.TargetSite);
                
            }
            Console.ReadKey();
        }
    }
}
--------------------------------------------------------
//Exception HelpLink gets or sets a link to the help file associated with this exception.
//public virtual string HelpLink { get; set; }
using System;
using System.Collections;

class Sample
{
    public static void Main()
    {
        try
        {
            Exception e = new Exception("This statement is the original exception message.");
            string s = "Information.";
            int i = -903;
            DateTime dt = DateTime.Now;
            e.Data.Add("stringInfo", s);
            e.Data["IntInfo"] = i;
            e.Data["DateTimeInfo"] = dt;
            e.HelpLink = "http://google.com";
            throw e;
        }
        catch (Exception e)
        {
            Console.WriteLine("An exception was thrown.");
            Console.WriteLine(e.Message);
            if (e.Data.Count > 0)
            {
                Console.WriteLine("  Extra details:");
                foreach (DictionaryEntry de in e.Data)
                    Console.WriteLine("    Key: {0}      Value: {1}",
                                      "'" + de.Key.ToString() + "'", de.Value);
            }
        }
    }
}
-------------------------------------------------------
using System;

public class AppException : Exception
{
    public AppException(String message) : base(message)
    { }

    public AppException(String message, Exception inner) : base(message, inner) { }
}

public class Example
{
    public static void Main()
    {
        Example ex = new Example();

        try
        {
            ex.CatchInner();
        }
        catch (AppException e)
        {
            Console.WriteLine("In catch block of Main method.");
            Console.WriteLine("Caught: {0}", e.Message);
            if (e.InnerException != null)
                Console.WriteLine("Inner exception: {0}", e.InnerException);
        }
    }

    public void ThrowInner()
    {
        throw new AppException("Exception in ThrowInner method.");
    }

    public void CatchInner()
    {
        try
        {
            this.ThrowInner();
        }
        catch (AppException e)
        {
            throw new AppException("Error in CatchInner caused by calling the ThrowInner method.", e);
        }
    }
}
// The example displays the following output:
//    In catch block of Main method.
//    Caught: Error in CatchInner caused by calling the ThrowInner method.
//    Inner exception: AppException: Exception in ThrowInner method.
//       at Example.ThrowInner()
//       at Example.CatchInner()