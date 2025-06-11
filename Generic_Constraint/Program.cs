namespace Generic_Constraint;

// Contraints ( Mehdudiyyetler ) where

/*
1. Struct                   -> Value
2. Class                    -> Reference
3. new                      -> objecti yaranan 1 tip
4. Base inferface name      -> 
5. Base class name          ->
6. T  : U                   ->

elave 

7. default
8. notnull
9. unmanaged
 
 
 */


class Base<T> where T : IPerson, new()
{

}

class Base2<T, B> where T : B { }

class Person { }
abstract class Human { }
interface IPerson { }
interface IHuman : IPerson { }
class HumanRef : IHuman { }


class Program
{
    static void Main(string[] args)
    {
        var bs = new Base<HumanRef>();


        var bs2 = new Base2<IHuman, IPerson>();
    }
}