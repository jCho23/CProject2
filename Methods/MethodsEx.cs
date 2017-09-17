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

        //Overloading Methods
        //Notice that this Move Method has a different signature than above
        public void Move(Point newLocation)
        {
            this.X = newLocation.X;
            this.Y = newLocation.Y;
        }
    }

    public class MethodsEx
    {
        static void Main(string[] args)
        {
            //Here we are creating a new point object
            var point = new Point(10, 20);

            //Here we are calling the Move Method
            //Notice that it takes 2 Overloads since we created 2 
            //These 2 overloads makes it easier for the user

            //This is the first Overload
            point.Move(new Point(40, 60));
            Console.WriteLine("Point is at ({0}, {1})", point.X, point.Y);

            //Second Overload
            point.Move(100, 200);
            Console.WriteLine("Point is at ({0}, {1})", point.X, point.Y);
        }
    }
}
