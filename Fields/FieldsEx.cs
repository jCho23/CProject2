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

        //List of Orders for Customer
        public List<Order> Orders;

        //Declaring Constructors
        public Customer(int id)
        {
            this.Id = id;
        }

        //Second Constructor

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
