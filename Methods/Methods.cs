using System;

//Signature of Methods
//Name
//Number and Type of parameters

//public class point
//{
//    //The signature of this Move Method are: "Move" "int" and "int"
//    public void Move(int x, int y) {}
//}

//Method Overloading= Having a Method with the same name but different signatures

public class Point
{
    public void Move (int x, int y) {}

    public void Move (Point newLocation) {}

    public void Move (Point newLocation, int speed) {}
}

//Params Modifier

//Ref Modifier

//Out Modifier

namespace CProject2.Methods
{
    public class Methods
    {
        public Methods()
        {
        }
    }
}
