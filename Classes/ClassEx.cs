using System;
namespace CProject2.Classes
{
    public class Person
    {
        public string Name;

        public void Introduce(string to)
        {
            Console.WriteLine("Hi {0}, I am {1}", to, Name);
        }

        //Defining Parse Method here
        //This is an Instance Method
        //We Changed this to static so we don't have to declare it twice down below
        public static Person Parse(string str)
        {
            //Here we are creating a person object
            var person = new Person();
            //Creating a name field
            person.Name = str;

            //Returning that person object
            return person;
        }
    }

    class ClassEx
    {
        static void Main(string[] args)
        {
            //var person = new Person();
            var person = Person.Parse("John");
            //person.Name = "John";
            person.Introduce("June");

            //Creating a Person Object from a String
            //We are going to use a Parse Method


        }
    }
}
