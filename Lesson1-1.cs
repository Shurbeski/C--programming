using System;

namespace Method {

  class Program {  
 
    // method declaration
    public void display() {
      Console.WriteLine("Hello World");   
    }

    static void Main(string[] args) {

      // create class object 
      Program p1 = new Program();

      //call method 
      p1.display();   
  
      Console.ReadLine();
     
    }
  }
}