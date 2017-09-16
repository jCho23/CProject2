using System;

//ObjectInitializer= A syntax for quickly initialising an object without the need to call one of its constructors
//Why do we need? = To avoid creating multiple Constructors

namespace CProject2.ObjectInitializers
{
    public class Person
    {
        public int Id (int id) {};

        public string FirstName (int id, string firstName) {};

        public string LastName (int id, string firstName, string lastName) {};;

        public DateTime Birthdate (int id, DateTime birthdate) {};
        
    }

	//Instead of initializing the objects like above, note here that we using a ObjectInitializer
    //to initialize the person object
	var person = new Person
    {
        FirstName = "June",
        LastName = "Cho"

    };
}
