class LearnStructs{

    struct Coordinate
    {
        public int x { get; set; }
        public int y { get; set; }

        public void SetOrigin()
        {
            this.x = 0;
            this.y = 0;
        }
    }

    static void Main(string[] args){
        Coordinate point = new Coordinate();
        point.SetOrigin();

        Console.WriteLine(point.x); //output: 0  
        Console.WriteLine(point.y); //output: 0 
        }   
}

//What is a C# Constructor? 
// In C#, a constructor is similar to a method that is invoked when an object of the class is created.
// However, unlike methods, a constructor:
// has the same name as that of the class
// does not have any return type