using System;
// System all the collections of classes like - Console
// This namespace is a collection of - Interfaces, Structs, enum and Delegates

class Program
{
    static void Main(string[] args)
    {
        sayHi("adib", 12, "CZS");
        Console.WriteLine(cube(2));
    }
    static void sayHi(string name, int age, string school)
    {
        Console.WriteLine("Hello " + name);
        Console.WriteLine("Your age is " + age);
        Console.WriteLine("your school is " + school);
    } 
        
    static int cube(int num)
    {
        int result = num * num * num;
        return result;
    }

}
