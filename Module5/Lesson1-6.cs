//The protected members of the base class can be accessible in the derived class but cannot be a part of the derived class object.


class Person
{
    protected string FirstName { get; set; }
}

class Employee : Person
{
    public int GetName()
    {
        return this.FirstName;// valid
    }
}

Employee emp = new Employee();
emp.GetName();// valid
emp.FirstName; // Compile-time error. 