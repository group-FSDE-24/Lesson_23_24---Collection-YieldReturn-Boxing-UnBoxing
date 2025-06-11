namespace _2_Yield_Return;

class Program
{
    static IEnumerable<int> DoSomething(string name)
    {
        yield return 1;
        yield return 2;
        yield return 3;
        yield return 4;
        yield return 5;
        yield return 6;
        yield return 7;

        if (name == "Kamran")
            yield break;


        yield return 8;
    }

    // Task: 
    static IEnumerable<int> DoSomething(int max)
    {
        for (int i = 1; i < max; i++)
        {
            if (i % 2 == 0)
                yield return i;
        }
    }

    static void Main(string[] args)
    {
        //Console.WriteLine(DoSomething("Salam"));

        //var list = new List<int>();

        //Console.WriteLine(list);

        //foreach (var item in DoSomething("Kamran"))
        //    Console.WriteLine(item);



        foreach (var item in DoSomething(10))
            Console.WriteLine(item);



    }
}