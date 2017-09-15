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

        public Person Parse(string str)
        {
            var person = new Person();
            person.Name = str;

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
