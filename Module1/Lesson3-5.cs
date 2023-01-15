// C# Arrays

// Array Declaration and Initialization

// Declaration
int[] evenNums;  // integer array
string[] cities; // string array

//Initialization
int[] evenNums = new int[5]{ 2, 4, 6, 8, 10 }; 
string[] cities = new string[3]{ "Mumbai", "London", "New York" };

// Example: Array Declaration using var
var evenNums = new int[]{ 2, 4, 6, 8, 10}; 
var cities = new string[]{ "Mumbai", "London", "New York" }; 

// Accessing Array Elements
int[] evenNums = new int[5];
evenNums[0] = 2;
evenNums[1] = 4;
//evenNums[6] = 12;  //Throws run-time exception IndexOutOfRange

Console.WriteLine(evenNums[0]);  //prints 2
Console.WriteLine(evenNums[1]);  //prints 4

//Accessing Array using for Loop
int[] evenNums = { 2, 4, 6, 8, 10 };

for(int i = 0; i < evenNums.Length; i++)
    Console.WriteLine(evenNums[i]);  

for(int i = 0; i < evenNums.Length; i++)
    evenNums[i] = evenNums[i] + 10;  // update the value of each element by 10

// Accessing Array using foreach Loop
int[] evenNums = { 2, 4, 6, 8, 10}; 
string[] cities = { "Mumbai", "London", "New York" }; 

foreach(var item in evenNums)
    Console.WriteLine(item);   

foreach(var city in cities)
    Console.WriteLine(city); 

// LINQ Methods
// All the arrays in C# are derived from an abstract base class System.Array.
// The Array class implements the IEnumerable interface, so you can LINQ extension methods such as Max(), Min(), Sum(), reverse(), etc.
int[] nums = new int[5]{ 10, 15, 16, 8, 6 };

nums.Max(); // returns 16
nums.Min(); // returns 6
nums.Sum(); // returns 55
nums.Average(); // returns 55

//Example: Array Methods
int[] nums = new int[5]{ 10, 15, 16, 8, 6 };

Array.Sort(nums); // sorts array 
Array.Reverse(nums); // sorts array in descending order
Array.ForEach(nums, n => Console.WriteLine(n)); // iterates array
Array.BinarySearch(nums, 5);// binary search 