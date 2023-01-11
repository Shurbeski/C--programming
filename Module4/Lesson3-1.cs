class DataStore<T>
{
    public T Data { get; set; }
}

class KeyValuePair<TKey, TValue>
{
    public TKey Key { get; set; }
    public TValue Value { get; set; }
}

public class Program
{
    public static void Main()
    {
        // Instantiating Generic Class

        DataStore<string> store = new DataStore<string>();
        store.Data = "Hello World!";
        //store.Data = 123; //compile-time error

        DataStore<int> intStore = new DataStore<int>();
        intStore.Data = 100;
        //intStore.Data = "Hello World!"; // compile-time error

        KeyValuePair<int, string> kvp1 = new KeyValuePair<int, string>();
        kvp1.Key = 100;
        kvp1.Value = "Hundred";

        KeyValuePair<string, string> kvp2 = new KeyValuePair<string, string>();
        kvp2.Key = "IT";
        kvp2.Value = "Information Technology";
    }
}


/*
Notes:
A generic class increases the reusability. The more type parameters mean more reusable it becomes. However, too much generalization makes code difficult to understand and maintain.
A generic class can be a base class to other generic or non-generic classes or abstract classes.
A generic class can be derived from other generic or non-generic interfaces, classes, or abstract classes.
*/