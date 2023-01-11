class LearnStructs{

    struct Coordinate
    {
        public int x;
        public int y;
    //A struct cannot contain a parameterless constructor. It can only contain parameterized constructors or a static constructor.
        public Coordinate(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
    }

    static void Main(string[] args){
        Coordinate point = new Coordinate(10, 20);

        Console.WriteLine(point.x); //output: 10  
        Console.WriteLine(point.y); //output: 20  

        }   
}

//What is a C# Constructor? 
// In C#, a constructor is similar to a method that is invoked when an object of the class is created.
// However, unlike methods, a constructor:
// has the same name as that of the class
// does not have any return type