namespace _6_Boxing_UnBoxing;


// Boxing 

// Reference type-in icerisine value type yazmaqdir

// UnBoxing
// Reference type-dan value type-in alinmasidir


class Program
{
    static void Main(string[] args)
    {
        int number = 55;

        object obj = number;


        int y = (int)obj;

        Console.WriteLine($"{5}");
        Console.WriteLine($"{5.ToString()}");


    }
}