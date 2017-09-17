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
            //This Conditional Statement covers if the New Location is null
            //This way, out Point object will always stay in a valid state
            //Defensive Programming == Stopping the program from an invalid state 
            if (newLocation == null)
                throw new ArgumentNullException("newLocation");
            
            //This replaces the code below
            //Reason= We want to minimze where we define the same variables
            Move(newLocation.X, newLocation.Y);

            //this.X = newLocation.X;
            //this.Y = newLocation.Y;
        }
    }

    public class Calculator
    {
        //This takes a varying number of arguments
        //Here, "numbers" is an Int Array
        public int Add(params int[] numbers)
        {
            var sum = 0;
            //Here we are using forEach to iterate through the numbers
            foreach(var number in numbers)
            {
                //We are adding every "number" to the sum
                sum += number;
            }

            return sum;
        }

    }

    public class MethodsEx
    {
        static void Main(string[] args)
        {
            //Using the Out Modifier

            //Here we have a string and we want to convert it to a number
            //We can use the Parse Method of the Int Class to do this
            //Notice that we have an invalid number
            var number = int.Parse("abc");

            //TryParse Method
            int number;
            var result= int.TryParse("abc", out number);

        }

        static void UseParams()
        {
			//Here we are calling an Instance of the calculator
			var calculator = new Calculator();
			
			//Notice that we can call a varying number of parameters because we are using "params"
			Console.WriteLine(calculator.Add(1, 2));
			Console.WriteLine(calculator.Add(1, 2, 3));
			
			//We can also call Calculator with an Array notation
			//As you can see, it is easier to use "params" to call the Calculator Method than this way
			Console.WriteLine(calculator.Add(new int[] {1,2,3,4,5}));
        }

        static void UsePoints()
        {
            //This Try / Catch Block enhances the user experience 
            //since it displays a String Error Message
            try
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
			
			catch (Exception ex)
			{
				Console.WriteLine("An unexpected error occurred");
			}
            
        }
    }
}
