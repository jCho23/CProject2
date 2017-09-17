//using System;
//using System.Collections.Generic;

//namespace CProject2.Fields
//{
//    //Customer Class
//    public class Customer
//    {
//        //Here, we are declaring Fields
//        public int Id;
//        public string Name;

//        //Since we have a list, we need to set an empty list
//        //We have to make sure that this default constructor is ALWAYS called first...
//        //so the Order fields will be intialized 
//        public Customer()
//        {
//            Orders = new List<Order>();
//        }

//        //List of Orders for Customer
//        //Notice that we are initializing the Orders Field here RATHER than...
//        //using a constuctor like above
//        //This way, no matter what constructor is called, the Orders Field will...
//        //ALWAYS be intialized to an empty list
//        //Both ways can be used, its up to your preference

//        //Notice that this READONLY is protecting where this list can be called
//        //That's why the list won't work in the Promote Method
//        public readonly List<Order> Orders = new List<Order>();

//        //Declaring Constructors
//        public Customer(int id)
//        {
//            this.Id = id;
//        }

//        //Second Constructor
//        public Customer(int id, string name)
//        //Notice that we are using ":this" to delegate "id" to the constructor above
//            : this(id)
//        {
//            this.Name = name;
//        }

//        //Read-Only Example
//        public void Promote()
//        {
//            //Notice that we are calling another list of Order here
//            //This will clear the list and its not what we want
//            //Thus, we will use READ-ONLY when we initialize the List<Order> field
//            Orders = new List<Order>();
//        }

//    }

//    //Order Class
//    public class Order
//    {

//    }


//    public class FieldsEx
//    {
//        static void Main(string[] args)
//        {
//            //Here we are creating a Customer Object
//            var customer = new Customer(1);

//            //Now we are adding 2 Orders of this Customer
//            //We should have 2 Orders on the Console after this line executes
//            customer.Orders.Add(new Order());
//            customer.Orders.Add(new Order());


//            customer.Promote();

//            Console.WriteLine(customer.Orders.Count);
//        }
//    }
//}
