public abstract class Beverage

{

    public double Temperature { get; set; } // deg C

    public double Size { get; set; } // ml

    public override string ToString()

    {

        return "Beverage";

    }

    public virtual string getRecipe()

    {

        if (Temperature > 25) return "Heat some water to " + Temperature + " degrees.";

        else return "Take some cold tap water";

    }

}

public sealed class Coffee : Beverage

{

    public string Bean { get; set; }

    public string Roast { get; set; }

    public string CountryOfOrigin { get; set; }

    public override string ToString()

{

    return "Coffee";

}

}

public sealed class Tea : Beverage

{

    public string Leaf { get; set; }

    public string CountryOfOrigin { get; set; }

    public override string ToString()

    {

      return "Tea, " + Leaf + ", " + (Temperature>80?"hot":"warm");

    }

}

public class Program {
    public static void Main() {
        
        var drink = new Coffee();

        drink.Bean = "Arabica";

        drink.CountryOfOrigin = "Columbian";

        drink.Temperature = 85;

        Console.WriteLine(drink);

        var drink2 = new Tea();

        drink2.Leaf = "Earl Grey";

        drink2.CountryOfOrigin = "Sri Lanka";

        drink2.Temperature = 85;

        Console.WriteLine(drink2);
    }
}
