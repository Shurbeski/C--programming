using System;

namespace Method {

  class Exceptions {   
    static void Main(string[] args)
    {
        try
        {
            Console.WriteLine("Enter a number: ");

            var num = int.parse(Console.ReadLine());

            Console.WriteLine($"Squre of {num} is {num * num}");
        }
        catch
        {
            Console.Write("Error occurred.");
        }
        finally
        {
            Console.Write("Re-try with a different number.");
        }
    }
  }
}