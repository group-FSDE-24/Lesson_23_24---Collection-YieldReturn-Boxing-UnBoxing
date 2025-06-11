using _4_Generic.Models;

namespace _4_Generic;

interface Response { };
interface Response<T> { };


class Response2<T> { }
record Response3<T> { }
struct Response4<T> { }
delegate void SomeDel<T>();



class Program
{
    static void Main(string[] args)
    {
        //var genericClass = new GenericClass<int>();

        //genericClass.Data = 41;

        //Console.WriteLine(genericClass.Data);

        //var genericString = new GenericClass<string>();

        //genericString.Data = "Kamran";
        //Console.WriteLine(genericString.Data);

        var genericClass = new GenericClass<string>();
        // Console.WriteLine(genericClass.Some());

        genericClass.SomeOtherGeneric<int>();


        genericClass.Deserialize<string>("Kamran");
    
    }
}