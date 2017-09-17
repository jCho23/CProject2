using System;
namespace CProject2.AccessModifiers
{
    public class Person
    {
        //Notice that this is a private field illustrated by "_birthdate"
        private DateTime _birthdate;

        //Here, we are creating Methods that will allow other members to access "_birthdate"
        public void SetBirthdate(DateTime birthdate)
        {
            //We can set logic of Birthdate if needed here

            //Here, we are just setting the _birthdate to the value passed to this data (birthdate)
            _birthdate = birthdate;
        }

        //This method simply returns a birthday field
        public DateTime GetBirthdate()
        {
            return _birthdate;
        }
    }

    public class AccessModifiersEx
    {
        static void Main(string[] args)
        {
            //Creating a Person Object
            var person = new Person();

            //Since we created the two public methods of, we can access some of the private fields of "birthdate"
            person.SetBirthdate(new DateTime(1990, 1, 1));
            Console.WriteLine(person.GetBirthdate());
        }
    }
}
