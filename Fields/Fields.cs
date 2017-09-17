using System;
using System.Collections.Generic;

////Initialization
//Here, we are only using the constructor when we need to initialize fields,
//based on the values passed from the outside
//public class Cutomer
//{
//    //Notice that we can directly Initialize the Orders Fields,
//    //without the need of a constructor
//    //Also, no matter how many constructors we have, the Orders Field
//    //will ALWAYS be initialized to an empty list
//    List<Order> Orders = new List<Order>();
//}

////Read-Only Fields
//Read-Only= This ensures that the Field is only Assisgned ONCE
//Field= Must be initialized directly like below...
//or Field= Or in of the constructors in the Class

//Why Read-Only? = This creates a saftey net in our application
//For example, the "readonly" below ensures that we will Only have ONE...
//list, for the List of Orders
public class Customer
{
    readonly List<Order> Orders = new List<Order>();
}


namespace CProject2.Fields
{
    public class Fields
    {
        public Fields()
        {
        }
    }
}
