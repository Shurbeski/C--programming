// While loop

// C# provides the while loop to repeatedly execute a block of code as long as the specified condition returns true
// The while loop starts with the while keyword, and it must include a boolean conditional expression inside brackets that returns either true or false. 
// It executes the code block until the specified conditional expression returns false.
int i = 0; // initialization

while (i < 10) // condition
{
    Console.WriteLine("i = {0}", i);

    i++; // increment
}

// Use the break or return keyword to exit from a while loop on some condition, as shown below.
int i = 0;

while (true)
{
    Console.WriteLine("i = {0}", i);

    i++;

    if (i > 10)
        break;
}

// Infinite While Loop
int i = 1;

while (i > 0)
{
    Console.WriteLine("i = {0}", i);
    i++;
}

// Bonus
// Nested while Loop
int i = 0, j = 1;

while (i < 2)
{
    Console.WriteLine("i = {0}", i);
    i++;

    while (j < 2)
    {
        Console.WriteLine("j = {0}", j);
        j++;
    }
}
