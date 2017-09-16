using System;
namespace CProject2.Methods
{
    //Here, Point represents a point on the screen so you need 2 fields-- X and Y
    public class Point
    {
        //Points
        public int X;
        public int Y;

        //Constructor
        public Point(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }

        //Method to move Point
        public void Move(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }
}



    public class MethodsEx
    {
        static void Main(string[] args)
        {
            
        }
    }
}
