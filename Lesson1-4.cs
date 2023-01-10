using System;

namespace OptionalArguments {

  class Program {  

    void ExampleMethod(int required, string optionalstr = "default string",
    int optionalint = 10){
        Console.WriteLine(required);
        Console.WriteLine(optionalstr);
        Console.WriteLine(optionalint);
    }
    
    static void Main(string[] args) {

      Program p1 = new Program();
      int required = 5;
      ExampleMethod(required);

    }
  }
}