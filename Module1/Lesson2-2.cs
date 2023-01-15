// Character type

char ch1 = 'A'; // Character literal

//----------------------------------------------------------------------------------------------------------------------------
//String type

//In C#, a string is a series of characters that is used to represent text. 
//It can be a character, a word or a long passage surrounded with the double quotes ". The following are string literals.
//"S"
//"String"
//"This is a string."
string ch = "S";
string word = "String";
string text = "This is a string.";

//There two ways to declare a string variable in C#. Using System.String class and using string keyword. Both are the same and make no difference.
string str1 = "Hello"; // uses string keyword
String str2 = "Hello"; // uses System.String class

//In C#, a string is a collection or an array of characters. So, string can be created using a char array or accessed like a char array.
char[] chars = {'H','e','l','l','o'};

string str1 = new string(chars);  
String str2 = new String(chars); 

foreach (char c in str1)
{
    Console.WriteLine(c);
}
//-----------------------------------------
//Special Characters
//A text in the real world can include any character. 
//In C#, because a string is surrounded with double quotes, it cannot include " in a string. The following will give a compile-time error.
string text = "This is a "string" in C#.";
//C# includes escaping character \ (backslash) before these special characters to include in a string.
string text = "This is a \"string\" in C#.";
string str = "xyzdef\\rabc";
string path = "\\\\mypc\\ shared\\project";
//------------------------------------------
//Verbatium strings
//It is tedious to prefix \ to include every special characters. 
//Verbatim string in C# allows a special characters and line brakes. Verbatim string can be created by prefixing @ symbol before double quotes.

string str1 = "this is a \n" + 
        "multi line \n" + 
        "string";
		
// Verbatim string
string str2 = @"this is a 
        multi line 
        string";
//-------------------------------------------
//String Concatenation
//Multiple strings can be concatenated with + operator.
string name = "Mr." + "James " + "Bond" + ", Code: 007";
 
string firstName = "James";
string lastName = "Bond";
string code = "007";
 
string agent = "Mr." + firstName + " " + lastName + ", Code: " + code;

//String Interpolation
string firstName = "James";
string lastName = "Bond";
string code = "007";
 
string fullName = $"Mr. {firstName} {lastName}, Code: {code}";