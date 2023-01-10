using System;

namespace Method {

  class Program {   

    // method declaration
    static int addNumbers() {
      int sum = 5 + 14;
      return sum;
      
    }

    static void Main(string[] args) {

      // call method 
      int sum = addNumbers();

      Console.WriteLine(sum);
  
      Console.ReadLine();
     
    }
  }
}