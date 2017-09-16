using System;
using CProject2.Constructors;

namespace CProject2.Constructors
{
    //Creating a Customer Class
    public class Customers
    {
        //*NOTE= This is not the best way to declare fields (i.e. public)
        public int Id;
        public string Name;

        //Declaring a constructor to intialize this field upon instanciation of a customer 
        //Two ways to declare a Constructor
        //1) public Customer{}
        public Customers(int id)
        {
            this.Id = id;
        }

        //we are Overloading the Constructors here
        public Customers(int id, string name)
        {
            this.Id = id;
            this.Name = name;
        }

        //We are creating a parameter-less Constructor to make the code work below
        public Customers()
        {

        }
    }



    public class ConstructorsEx
    {
        static void Main(string[] args)
        {
            //Here, we are Creating a New Instance of Customers
            var customers = new Customers();
            Console.WriteLine(customers.Id);
            Console.WriteLine(customers.Name);

        }
    }
}
