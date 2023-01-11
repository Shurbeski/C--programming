class Student
{
    private int id;
    private int scoreMath;
    private int scoreEngl;
    public string FirstName { get; set; }
    public string LastName { get; set; }

    public int StudentId
    {
        get { return id; }
        set { id = value; }
    }

    public int AVG(int scoreEngl, int scoreMath)
    {
        var avg = (scoreEngl + scoreMath)/2;
        return avg;
    }

    public void Greet()
    {
        Console.Write("Hello World!");
    }
    public string GetFullName()
    {
        return FirstName + " " + LastName;
    }

    static void Main(string[] args){
        Student student = new Student();
        student.FirstName = "Hristijan";
        student.LastName = "Shurbeski";
        student.id = 165047;
        student.scoreEngl = 7;
        student.scoreMath = 8;

        student.AVG();
        student.Greet();
        student.GetFullName();
    }
    


}