interface IFile
{
    void ReadFile();
    void WriteFile(string text);

    void DisplayName()
    {
        Console.WriteLine("IFile");
    }
}

class FileInfo : IFile
{
    public void ReadFile()
    {
        Console.WriteLine("Reading File");
    }

    public void WriteFile(string text)
    {
        Console.WriteLine("Writing to file");
    }
}

public class Program
{
    public static void Main()
    {
        IFile file1 = new FileInfo();
        file1.ReadFile(); 
        file1.WriteFile("content"); 
        file1.DisplayName();

        FileInfo file2 = new FileInfo();
        //file2.DisplayName(); //compile-time error 
    }
}
/* 
Note:
In the above IFile interface, the DisplayName() is the default method. 
The implementation will remain same for all the classes that implements the IFile interface. 
Note that a class does not inherit default methods from its interfaces; so, you cannot access it using the class instance.
/*

/*
Points to remember:
Interface can contain declarations of method, properties, indexers, and events.
Interface cannot include private, protected, or internal members. All the members are public by default.
Interface cannot contain fields, and auto-implemented properties.
A class or a struct can implement one or more interfaces implicitly or explicitly. Use public modifier when implementing interface implicitly, whereas don't use it in case of explicit implementation.
Implement interface explicitly using InterfaceName.MemberName.
An interface can inherit one or more interfaces.
*/