namespace _4_Generic.Models;

class GenericClass<T>
{
    public T Data { get; set; }

    private readonly T _privateField;


    public T Some()
    {
        T temp = default!;

        return temp;
    }

    public T SomeOtherGeneric<TMethod>()
    {
        T temp = default!;
        TMethod method = default!;

        Console.WriteLine(temp);
        Console.WriteLine(method);

        return temp;
    }

    public void Deserialize<T>(T obj) => Console.WriteLine(obj);

}


