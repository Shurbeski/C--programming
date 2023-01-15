// C# String builder

// In C#, the string type is immutable. It means a string cannot be changed once created. For example, a new string, "Hello World!" will occupy a memory space on the heap. 
// Now, by changing the initial string "Hello World!" to "Hello World! from Tutorials Teacher" will create a new string object on the memory heap instead of modifying an original string at the same memory address. 
// This behavior would hinder the performance if the original string changed multiple times by replacing, appending, removing, or inserting new strings in the original string.

// Creating a StringBuilder Object
using System.Text; // include at the top
            
StringBuilder sb = new StringBuilder(); //string will be appended later
// or
StringBuilder sb = new StringBuilder("Hello World!");

// Optionally, you can also specify the maximum capacity of the StringBuilder object using overloaded constructors, as shown below.
StringBuilder sb = new StringBuilder(50); //string will be appended later
// or
StringBuilder sb = new StringBuilder("Hello World!", 50);

// You can iterate the using for loop to get or set a character at the specified index.

StringBuilder sb = new StringBuilder("Hello World!");

for(int i = 0; i < sb.Length; i++)
    Console.Write(sb[i]); // output: Hello World!

// Retrieve String from StringBuilder
// The StringBuilder is not the string. Use the ToString() method to retrieve a string from the StringBuilder object.
StringBuilder sb = new StringBuilder("Hello World!");

var greet = sb.ToString(); //returns "Hello World!"

// Add/Append String to StringBuilder
StringBuilder sb = new StringBuilder();
sb.Append("Hello ");
sb.AppendLine("World!");
sb.AppendLine("Hello C#");
Console.WriteLine(sb);

//Append Formated String to StringBuilder
StringBuilder sbAmout = new StringBuilder("Your total amount is ");
sbAmout.AppendFormat("{0:C} ", 25);
Console.WriteLine(sbAmout);//output: Your total amount is $ 25.00

//Insert String into StringBuilder
StringBuilder sb = new StringBuilder("Hello World!");
sb.Insert(5," C#"); 

Console.WriteLine(sb); //output: Hello C# World!

//Remove String in StringBuilder
StringBuilder sb = new StringBuilder("Hello World!",50);
sb.Remove(6, 7);

Console.WriteLine(sb); //output: Hello

//Replace String in StringBuilder
StringBuilder sb = new StringBuilder("Hello World!");
sb.Replace("World", "C#");

Console.WriteLine(sb);//output: Hello C#!

/*---------------------------------------------------Points to remember---------------------------------
StringBuilder is mutable.
StringBuilder performs faster than string when appending multiple string values.
Use StringBuilder when you need to append more than three or four strings.
Use the Append() method to add or append strings to the StringBuilder object.
Use the ToString() method to retrieve a string from the StringBuilder object.
