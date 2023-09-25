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

    using (StreamReader sr = File.OpenText(path))
    {
     String s = "";

     while ((s = sr.ReadLine()) != null)
     {
      Console.WriteLine(s);
     }
    }
   Console.ReadKey();
  }
 }
}
