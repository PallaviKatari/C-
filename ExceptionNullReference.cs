using System;
 
namespace CSharpExamples {
 
    class Program {
        static void Main(string[] args) {
            string str = null;
            try{
                Console.WriteLine(str.Substring(5));
            } catch(NullReferenceException err){
                Console.WriteLine("Please check the string str.");
                Console.WriteLine(err.Message);
            }
            Console.WriteLine("Continuing with other statments..");
        }
    }
}