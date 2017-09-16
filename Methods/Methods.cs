using System;

////Signature of Methods
//1) Name
//2) Number and Type of parameters

//public class point
//{
//    //The signature of this Move Method are: "Move" "int" and "int"
//    public void Move(int x, int y) {}
//}

////Method Overloading= Having a Method with the same name but different signatures

//public class Point
//{
//    public void Move (int x, int y) {}

//    public void Move (Point newLocation) {}

//    public void Move (Point newLocation, int speed) {}
//}

////Params Modifier = A method with varying number of parameters
//You can call the method in 2 ways with params

public class Calculator
{
    public int Add(params int[] numbers){}
}

//1) You can call it by passing an int Array if needed
var result = calculator.Add(new int[] { 1, 2, 3, 4 });
//2) Or you can simply pass a varying number of argruments
var result = calculator.Add(1, 2, 3, 4);



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
