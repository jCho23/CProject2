//using System;

////Class= Building blocks of an app

////Anatomy of a Class
////Data = Represented by fields
////Behvior= Represented by methods / functions

////Object = Instance of a Class that resides in Memory

//namespace CProject2
//{
//	//Declaring Classes

//	//Public= Access Modifer

//	//Naming Conventions
//	//Pascal Case= Used when naming Classes
//	//camel Case= Used when naming parameter in Methods

//	public class Person
//	{
//		//Put members of the class here

//		//Declaring a Field
//		//Here, Name is the identifier of the field
//		public string Name;

//		//Declaring a Method
//		public void Introduce()
//		{
//			Console.WriteLine("Hi, my name is " + Name);
//		}

//		//Creating Objects
//		//Type of the class= Person
//		//Identifier= person
//		Person person = new Person();

//		//This is the shorter way to do the same as above
//		var person = new Person();

//		//Now that we have an object, we can access members of that object
//		person.Name = "June";
//        person.Introduce();



//        //Class Members

//        //Instance= Accessible from an object
//        //i.e.=
//        //var person = new Person()
//        //person.Introduce();

//        //Static= Accessible from the class
//        //i.e.
//        //Console.Writeline()
//        //Why use static members? = To represent concepts that are singleton
//        //Meaning, we should only have ONE INSTANCE of that object in memory
//        //You can use Static with any members of the class
//        //DateTime.Now
//        //Console.Writeline()
//    }
//}
