//Generic Methods
class DataStore<T>
{
    private T[] _data = new T[10];
    
    public void AddOrUpdate(int index, T item)
    {
        if(index >= 0 && index < 10)
            _data[index] = item;
    }

    public T GetData(int index)
    {
        if(index >= 0 && index < 10)
            return _data[index];
        else 
            return default(T);
    }
}

public class Program
{
    public static void Main()
    {
        // Instantiating Generic Class

        DataStore<string> cities = new DataStore<string>();
        cities.AddOrUpdate(0, "Mumbai");
        cities.AddOrUpdate(1, "Chicago");
        cities.AddOrUpdate(2, "London");

        DataStore<int> empIds = new DataStore<int>();
        empIds.AddOrUpdate(0, 50);
        empIds.AddOrUpdate(1, 65);
        empIds.AddOrUpdate(2, 89);
    }
}
