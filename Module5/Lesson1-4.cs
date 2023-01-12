//The public members of the base class are accessible in the derived class and also become part of the derived class object.



class Person
{
    public string FirstName { get; set; } // can be inherited
}

class Employee : Person
{
        
}

Employee emp = new Employee();
emp.FirstName = "Bill"; // valid