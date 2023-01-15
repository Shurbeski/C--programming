using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace DemoApplication
{
  class Tutorial
  {
   static void Main(string[] args)
   {
    String path = @"D:\Example.txt";

    String lines;
    lines = File.ReadAllText(path);
    Console.WriteLine(lines);
 
    Console.ReadKey();
   }
  }
}