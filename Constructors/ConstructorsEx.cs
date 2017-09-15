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
	}

    public class ConstructorsEx
    {
       static void Main(string[] args)
        {
            //Here, we are Creating a New Instance of Customers
            var customers = new Customers();
            Console.WriteLine(customers.Id);
            Console.WriteLine(customers.Name);

            //Declaring 
        }
    }
}
