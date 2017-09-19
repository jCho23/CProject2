using System;

namespace CProject2.PropertiesInClasses
{
    public class Person
    {
        //Here we are creating an Auto-Implemented property without any fields
        //Note, that the compiler will create internally create a private field 
        //And implements the "get" and "set" Accessor Methods
        public DateTime Birthdate { get; set; }
    }

    public class PropertiesEx
    {
        static void Main(string[] args)
        {
            
        }
    }
}
