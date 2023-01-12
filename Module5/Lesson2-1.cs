// Compile-time polymorphism is also known as method overloading. 
// Example: Method Overloading Method Overloading
class ConsolePrinter
{
     public void Print(string str){ 
        Console.WriteLine(str);
    }

    public void Print(string str1, string str2){ 
        Console.WriteLine($"{str1}, {str2}");
    }

    public void Print(string str1, string str2, string str3){ 
        Console.WriteLine($"{str1}, {str2}, {str3}");
    }
	
    public void Print(int a){ 
        Console.WriteLine($"Integer {a}");
    }
	
	 public void Print(int a, string str){ 
        Console.WriteLine($"{a}, {str}");
    }

    public void Print(string str, int a){ 
        Console.WriteLine($"{a}, {str}");
    }
}

//Invoking Overloaded Methods
class Program {
    public static void Main()
    {
        ConsolePrinter cp = new ConsolePrinter();
        cp.Print("Hello World!");
        cp.Print(1, "John");
    }
}