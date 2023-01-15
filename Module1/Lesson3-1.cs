// C# - if, else if, else Statements

// if
int i = 10, j = 20;

if (i < j)
{
    Console.WriteLine("i is less than j");
}        

if (i > j)
{
    Console.WriteLine("i is greater than j");
}

// else if
int i = 10, j = 20;

if (i == j)
{
    Console.WriteLine("i is equal to j");
}
else if (i > j)
{
    Console.WriteLine("i is greater than j");
}
else if (i < j)
{
    Console.WriteLine("i is less than j");
}

// else
int i = 20, j = 20;

if (i > j)
{
    Console.WriteLine("i is greater than j");
}
else if (i < j)
{
    Console.WriteLine("i is less than j");
}
else
{
    Console.WriteLine("i is equal to j");
}