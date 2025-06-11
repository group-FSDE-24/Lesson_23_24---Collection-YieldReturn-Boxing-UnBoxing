#nullable disable


class Student
{
    public int Id { get; set; }
    public string Name { get; set; } 
    public string Surname { get; set; }
}


class Program
{
    static void DoSomething(Student student)
    {
        Console.WriteLine(student.Id);
        Console.WriteLine(student.Name);
        Console.WriteLine(student.Surname);
    }

    static void DoSomethingWithDelegate(Action<Student> action)
    {
        var st = new Student();

        action.Invoke(st);

        Console.WriteLine(st.Id);
        Console.WriteLine(st.Name);
        Console.WriteLine(st.Surname);
    }

    static void Main(string[] args)
    {
        // var student = new Student()
        // {
        //     Id = 1,
        //     Name = "Kamran",
        //     Surname = "Karimzada"
        // };
           
        // DoSomething(student);

        DoSomethingWithDelegate(s =>
        {
            s.Id = 1;
            s.Name = "Kamran";
            s.Surname = "Karimzada";
        });


    }
}