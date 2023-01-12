//The private members of the base class cannot be accessed directly 
//from the derived class and cannot be part of the derived class object.

class Person
{
    private string FirstName { get; set; }  // cannot be inherited
}

class Employee : Person
{
   
}

Employee emp = new Employee();
emp.FirstName; // Compile-time error