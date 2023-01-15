using System;
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

   String copypath = @"D:\ExampleNew.txt";

   File.Copy(path,copypath);

   Console.ReadKey();
   }
  }
}