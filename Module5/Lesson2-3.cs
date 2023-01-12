// Custom Exception Type in C#

class Student
{
    public int StudentID { get; set; }
    public string StudentName { get; set; }
}

//Serialization is the process of converting an object into a stream of bytes to store the object or transmit it to memory,
// a database, or a file. Its main purpose is to save the state of an object in order to be able to recreate it when needed.
[Serializable] 
class InvalidStudentNameException : Exception
{
    public InvalidStudentNameException() {  }

    public InvalidStudentNameException(string name)
        : base(String.Format("Invalid Student Name: {0}", name))
    {

    }
}

class Program
{
    static void Main(string[] args)
    {
        Student newStudent = null;
          
        try
        {               
            newStudent = new Student();
            newStudent.StudentName = "James007";
            
            ValidateStudent(newStudent);
        }
        catch(InvalidStudentNameException ex)
        {
            Console.WriteLine(ex.Message );
        }
          

        Console.ReadKey();
    }

    private static void ValidateStudent(Student std)
    {
        Regex regex = new Regex("^[a-zA-Z]+$");

        if (!regex.IsMatch(std.StudentName))
             throw new InvalidStudentNameException(std.StudentName);
            
    }
}
// Output: 
// Invalid Student Name: James000
