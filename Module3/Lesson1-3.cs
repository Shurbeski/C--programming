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

Coordinate point = Coordinate();
point.SetOrigin();

Console.WriteLine(point.x); //output: 0  
Console.WriteLine(point.y); //output: 0  