using System;

namespace TypeConversion
{
    class Program
    {
        public class Person
        {
            public string Name;
            
            public void Introduce(string to)
            {
                Console.WriteLine("Hello,{0}..I am {1}",to, Name);
            }
            public static Person Parse(string str)
            {
                var person = new Person();
                person.Name = str;
                return person;
            }
        }

        static void Main(string[] args)
        {
            /*
            try
            {
                int a = 1;
                int b = ++a;
                Console.WriteLine(b);
            }
            catch (Exception)
            {
                Console.WriteLine("Somethings Went Wrong!!");
            } */
            var person = Person.Parse("adib");
            person.Introduce("Alex");
        }
    }
}