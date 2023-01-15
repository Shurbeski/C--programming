// C# - Switch Statement

// The switch statement can be used instead of if else statement when you want to test a variable against three or more conditions.
int x = 10;

// Example 1
switch (x)
{ 
    case 5:
        Console.WriteLine("Value of x is 5");
        break;
    case 10:
        Console.WriteLine("Value of x is 10");
        break;
    case 15:
        Console.WriteLine("Value of x is 15");
        break;
    default:
        Console.WriteLine("Unknown value");
        break;
}

// Example 2
int x = 125;

switch (x % 2)
{ 
    case 0:
        Console.WriteLine($"{x} is an even value");
        break;
    case 1:
        Console.WriteLine($"{x} is an odd Value");
        break;
}

// Example 3
string statementType = "switch";

switch (statementType)
{
    case "if.else":
        Console.WriteLine("if...else statement");
        break;
    case "ternary":
        Console.WriteLine("Ternary operator");
        break;
    case "switch":
        Console.WriteLine("switch statement");
        break;
}

// Example 4
int x = 5;

switch (x)
{ 
    case 1:
        Console.WriteLine("x = 1");
        break;
    case 2:
        Console.WriteLine("x = 2");
        break;
    case 4:
    case 5:
        Console.WriteLine("x = 4 or x = 5");
        break;
    default:
        Console.WriteLine("x > 5");
        break;
}

// Note
// Each case must exit the case explicitly by using break, return, goto statement, or some other way, making sure the program control exits a case and cannot fall through to the default case.

// Bonus
// Nested Switch Statements
 
int j = 5;

switch (j)
{
    case 5:
        Console.WriteLine(5);
        switch (j - 1)
        {
            case 4:
            Console.WriteLine(4);
            switch (j - 2)
            {
                case 3:
                Console.WriteLine(3);
                break;
            }
            break;
        }
        break;
    case 10:
        Console.WriteLine(10);
        break;
    case 15:
        Console.WriteLine(15);
        break;
    default:
        Console.WriteLine(100);
        break;
}


/*----------------------------------------------------Points to remember ---------------------------------
The switch statement is an alternative to if else statement.
The switch statement tests a match expression/variable against a set of constants specified as cases.
The switch case must include break, return, goto keyword to exit a case.
The switch can include one optional default label, which will be executed when no case executed.
C# compiler will give errors on missing :, constant value with cases, exit from a case.
C# 7.0 onward, switch cases can include non-unique values. In this case, the first matching case will be executed.
*/
