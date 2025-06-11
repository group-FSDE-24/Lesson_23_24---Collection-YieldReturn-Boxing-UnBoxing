namespace _3_Iterator;

// Iterator -> foreach istifade etmek ucundur

class Program
{
    static void Main(string[] args)
    {
        //var list = new List<int>() { 1, 2, 3 };

        List<int> list = Enumerable.Range(5, 10).ToList();

        //Console.WriteLine(list);
        //foreach (var item in list)
        //    Console.WriteLine(item);


        // IEnumerator<int> iterator = list.GetEnumerator();
        //
        //
        // while (iterator.MoveNext())
        // {
        //     Console.WriteLine(iterator.Current);
        // }
        //
        // iterator.Reset();
        //
        // while (iterator.MoveNext())
        // {
        //     Console.WriteLine(iterator.Current);
        // }

        foreach (var item in list)
            Console.WriteLine(item);


    }
}