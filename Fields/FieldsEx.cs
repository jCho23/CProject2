using System;
using System.Collections.Generic;

namespace CProject2.Fields
{
    //Customer Class
    public class Customer
    {
        //Here, we are declaring Fields
        public int Id;
        public string Name;

        //Since we have a list, we need to set an empty list
        //We have to make sure that this default constructor is ALWAYS called first...
        //so the Order fields will be intialized 
        public Customer()
        {
            Orders = new List<Order>();
        }

        //List of Orders for Customer
        //Notice that we are initializing the Orders Field here RATHER than...
        //using a constuctor like above
        //This way, no matter what constructor is called, the Orders Field will...
        //ALWAYS be intialized to an empty list
        //Both ways can be used, its up to your preference
        public List<Order> Orders = new List<Order>();

        //Declaring Constructors
        public Customer(int id)
        {
            this.Id = id;
        }

        //Second Constructor
        public Customer(int id, string name)
        //Notice that we are using ":this" to delegate "id" to the constructor above
            : this(id)
        {
            this.Name = name;
        }
    }

    //Order Class
    public class Order
    {

    }


    public class FieldsEx
    {
        static void Main(string[] args)
        {

        }
    }
}
