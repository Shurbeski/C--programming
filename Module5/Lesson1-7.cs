//Internal members are accessible in the derived class and are part of the derived class object.

class Person
{
    internal string FirstName { get; set; } 
}

class Employee : Person
{
        
}

Employee emp = new Employee();
emp.Name= "Steve";// valid