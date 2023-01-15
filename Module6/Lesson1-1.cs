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
   
   if (File.Exists(path))
   {
    Console.WriteLine("File Exists");
   }
   Console.ReadKey();
  }
 }
}