// C# Enumerations Type - Enum

// In C#, an enum (or enumeration type) is used to assign constant names to a group of numeric integer values. It makes constant values more readable, 
// for example, WeekDays.Monday is more readable then number 0 when referring to the day in a week.
// An enum is defined using the enum keyword, directly inside a namespace, class, or structure. All the constant names can be declared inside the curly brackets and separated by a comma. 
// The following defines an enum for the weekdays.

enum WeekDays
{
    Monday,     // 0
    Tuesday,    // 1
    Wednesday,  // 2
    Thursday,   // 3
    Friday,     // 4
    Saturday,   // 5
    Sunday      // 6
}

enum Categories
{
    Electronics,    // 0
    Food,           // 1
    Automotive = 6, // 6
    Arts,           // 7
    BeautyCare,     // 8
    Fashion         // 9
}

//Access to enums
enum WeekDays
{
    Monday, 
    Tuesday,
    Wednesday,
    Thursday, 
    Friday, 
    Saturday,
    Sunday 
}

Console.WriteLine(WeekDays.Monday); // Monday
Console.WriteLine(WeekDays.Tuesday); // Tuesday
Console.WriteLine(WeekDays.Wednesday); // Wednesday
Console.WriteLine(WeekDays.Thursday); // Thursday
Console.WriteLine(WeekDays.Friday); // Friday
Console.WriteLine(WeekDays.Saturday); // Saturday
Console.WriteLine(WeekDays.Sunday); // Sunday

//Conversion
enum WeekDays
{
    Monday, 
    Tuesday,
    Wednesday,
    Thursday, 
    Friday, 
    Saturday,
    Sunday 
}

Console.WriteLine(WeekDays.Friday); //output: Friday 
int day = (int) WeekDays.Friday; // enum to int conversion
Console.WriteLine(day); //output: 4 
		
var wd = (WeekDays) 5; // int to enum conversion
Console.WriteLine(wd);//output: Saturday 