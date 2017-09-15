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
        public Person Parse(string str)
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
            var person = new Person();
            person.Name = "John";
            person.Introduce("June");

            //Creating a Person Object from a String
            //We are going to use a Parse Method


        }
    }
}
