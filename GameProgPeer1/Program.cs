using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProgPeer1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Pornchai();
            //Max();
            //Bastian();
            //Eric();
            ahmad();
            Console.ReadLine();
        }

        public static void Pornchai()
        {
            // welcome message
            Console.WriteLine("This application will calculate the distance between two points and the angle between those points \n");

            // get Point 1 X from the user
            Console.WriteLine("Point 1 X: ");
            float point1X = float.Parse(Console.ReadLine());

            // get Point 1 Y from the user
            Console.WriteLine("Point 2 Y: ");
            float point1Y = float.Parse(Console.ReadLine());

            // get Point 2 X from the user
            Console.WriteLine("Point 1 X: ");
            float point2X = float.Parse(Console.ReadLine());

            // get Point 1 Y from the user
            Console.WriteLine("Point 2 Y: ");
            float point2Y = float.Parse(Console.ReadLine());

            // pythagorean theorem distance = {\sqrt {deltaX^{2}+deltaY^{2}}}
            // calculate delta x and delta y between the two points
            double deltaX = point2X - point1X;
            double deltaY = point2Y - point1Y;

            //pythagras theorem for distance
            double distance = Math.Sqrt(Math.Pow(deltaX, 2) + Math.Pow(deltaY, 2));

            // atan2 for angle
            double radians = Math.Atan2(deltaY, deltaX);

            //radians into degrees
            double angle = radians * (180.0 / Math.PI);

            // output. It can be passed to an overload of the ToString method that has a format parameter.
            Console.WriteLine();
            Console.WriteLine("Distance between points: " + distance.ToString("N3") + "\n");
            Console.WriteLine("Angle between points: " + angle.ToString("N3") + " degrees \n");
        }

        #region Max
        public static void Max()
        {
            Console.WriteLine("Welcome!");
            Console.WriteLine("This program is used to:");
            Console.WriteLine("    - Calculate the distance between two points");
            Console.WriteLine("    - Calculate the distance between two points");
            Console.WriteLine("When entering coordinates for a point, separate the two numbers by a comma.");
            Console.WriteLine("Example: 0.0, 1.0");
            Console.WriteLine();
            Start();
        }
        /// <summary>
        /// Prompts the user for the coordinates of two points, then calculates delta x, delta y, distance between the points, and 
        ///  the angle from point 1 to point 2.
        /// </summary>
        public static void Start()
        {
            Console.Write("Enter the xy coordinates for point 1: ");
            Point p1 = MakePoint();
            Console.Write("Enter the xy coordinates for point 2: ");
            Point p2 = MakePoint();

            Console.WriteLine("Delta X:             " + p1.deltaX(p2).ToString("F3"));
            Console.WriteLine("Delta Y:             " + p1.deltaY(p2).ToString("F3"));
            Console.WriteLine("Distance:            " + p1.distance(p2).ToString("F3"));
            Console.WriteLine("Angle from P1 to P2: " + p1.Angle(p2).ToString("F3") + "°");
            Console.WriteLine();
            Console.WriteLine("Press <Enter> to start over, or any other key to quit.");

            if (Console.ReadKey().Key != ConsoleKey.Enter)
            {
                System.Environment.Exit(0);
            }
            else
            {
                Start();
            }
        }

        /// <summary>
        /// Reads and parses coordinates from user input to create a Point.
        /// </summary>
        /// <returns>A Point at the given coordinates.</returns>
        public static Point MakePoint()
        {
            Point p = new Point();
            string str = Console.ReadLine();
            string[] points = str.Split(',');
            // Characters to be removed from parsed strings
            char[] badChars = new char[] { ' ', '(', ')' };
            // Try to parse coordinates into doubles.
            try
            {
                double x = double.Parse(points[0].Trim(badChars));
                double y = double.Parse(points[1].Trim(badChars));
                p.SetX(x);
                p.SetY(y);
            }
            catch (Exception)
            {
                Console.WriteLine("You need to enter two numbers separated by a comma (ex: 3.23, 5). Please try again.");
                Console.Write("Enter xy coordinates for the point: ");
                p = MakePoint();
            }
            return p;
        }
        #endregion

        #region Bastian
        public static void Bastian()
        {
            // Welcome message (just for fun)
            Console.WriteLine("Howdie, Pythagoras and Hipparchus! Let's do some math!");
            Console.WriteLine();

            // Get user input for ORIGIN POINT coordinates
            Console.WriteLine("Enter the X value for the origin point: ");
            float point1X = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter the Y value for the origin point: ");
            float point1Y = float.Parse(Console.ReadLine());
            Console.WriteLine();

            // Welcome message Get user input for TARGET POINT coordinates
            Console.WriteLine("Now, what is our target point?");
            Console.WriteLine();
            Console.WriteLine("Enter the X value for the target point: ");
            float point2X = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter the Y value for the target point: ");
            float point2Y = float.Parse(Console.ReadLine());

            // calculte delta x and delta y
            float deltaX = point2X - point1X;
            float deltaY = point2Y - point1Y;

            // calculate distance
            double distance = Math.Sqrt((double)Math.Pow(deltaX, 2) + (double)Math.Pow(deltaY, 2));

            // calculate angle
            double radians = Math.Atan2(deltaY, deltaX);
            double angle = radians * (180 / Math.PI);

            // output of results
            Console.WriteLine();
            Console.WriteLine("_________________________");
            Console.WriteLine();
            Console.WriteLine("The distance between those two points is: ");
            Console.WriteLine(distance.ToString("N3"));
            Console.WriteLine();
            Console.WriteLine("The angle from origin point to target point is: ");
            Console.WriteLine(angle.ToString("N3"));
            Console.WriteLine();


        }
        #endregion Bastian

        #region Eric 
    
        public static void Eric()
        {
            Console.WriteLine("This application calculates distance and angle between two points.");

            Console.WriteLine("Please enter the x coordinate of first point: ");
            float pointX1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Please anter the y coordinate of the first point: ");
            float pointY1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Please enter the x coordinate of second point: ");
            float pointX2 = float.Parse(Console.ReadLine());

            Console.WriteLine("Please anter the y coordinate of the second point: ");
            float pointY2 = float.Parse(Console.ReadLine());

            // Calculate the distances decomposed on x and y axis

            float deltaX = pointX2 - pointX1;
            float deltaY = pointY2 - pointY1;

            //Calculate the real distance between two points
            double squareSum = (deltaX * deltaX) + (deltaY * deltaY);
            double distance = Math.Sqrt(squareSum);
            Console.WriteLine("The distance between the two points are " + distance.ToString("G7", CultureInfo.InvariantCulture) + ".");

            //Calculate the angle

            double angle = ((Math.Atan2(deltaX, deltaY)) * 180) / (Math.PI);
            Console.WriteLine("The angle between the two points are " + angle.ToString("G5", CultureInfo.InvariantCulture) + " degree" + ".");
            Console.ReadKey();




        }
    
        #endregion Eric

        #region ahmad

        public static void ahmad()
        {
            //start of program welcome sign
            Console.WriteLine("             WELCOME TO SIMPLE ANGLE CALCULATING THINGY         ");

            //declaration of variables ( points )
            float pointX1, pointX2, pointY1, pointY2;

            //prompt and get of first point x and y
            Console.WriteLine("\nPlease enter first point of X : ");
            pointX1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Please enter first point of Y : ");
            pointY1 = float.Parse(Console.ReadLine());

            //prompt and get of second point x and y
            Console.WriteLine("\nPlease enter second point of X : ");
            pointX2 = float.Parse(Console.ReadLine());
            Console.WriteLine("Please enter second point of Y : ");
            pointY2 = float.Parse(Console.ReadLine());

            //calculation for the delta of X and Y
            float deltaX = pointX2 - pointX1;
            float deltaY = pointY2 - pointY1;
            Console.WriteLine("\nDelta X is = {0}", deltaX);
            Console.WriteLine("Delta Y is = {0}", deltaY);

            //calculation for distance and angle
            float distance = (float)Math.Sqrt(Math.Pow(deltaX, 2) + Math.Pow(deltaY, 2));
            Console.WriteLine("\nDistance between two points is = {0:F3}", distance);
            float angle = (float)(Math.Atan2(deltaY, deltaX) * (180 / Math.PI));
            Console.WriteLine("Angle is = {0:F3} ", angle);

            Console.ReadLine();
        }
        #endregion ahmad

    }
    #region Max
    /// <summary>
    /// This class represents a point with x and y coordinates.
    /// </summary>
    class Point
    {
        private double x;
        private double y;

        /// <summary>
        /// Default constructor for a Point at (0,0).
        /// </summary>
        public Point()
        {
            x = 0.0;
            y = 0.0;
        }

        /// <summary>
        /// Constructs a point at the given x and y coordinates. 
        /// </summary>
        /// <param name="x">The x-coordinate of this Point.</param>
        /// <param name="y">The y-coordinate of this Point.</param>
        public Point(double x, double y)
        {
            this.x = x;
            this.y = y;
        }

        /// <summary>
        /// Gets the x-coordinate of this Point.
        /// </summary>
        /// <returns>The x-coordinate of this Point.</returns>
        public double GetX()
        {
            return x;
        }

        /// <summary>
        /// Sets the x-coordinate of this Point.
        /// </summary>
        /// <param name="x">The desired x-coordinate.</param>
        public void SetX(double x)
        {
            this.x = x;
        }

        /// <summary>
        /// Gets the y-coordinate of this Point.
        /// </summary>
        /// <returns>The y-coordinate of the Point.</returns>
        public double GetY()
        {
            return y;
        }

        /// <summary>
        /// Sets the y-coordinate of this Point.
        /// </summary>
        /// <param name="y">The desired y-coordinate.</param>
        public void SetY(double y)
        {
            this.y = y;
        }

        /// <summary>
        /// Calculates the distance between this Point and a given Point along the x-plane.
        /// </summary>
        /// <param name="otherPoint">The Point from which to find delta x.</param>
        /// <returns>Delta x.</returns>
        public double deltaX(Point otherPoint)
        {
            double distance = Math.Abs(x - otherPoint.GetX());
            return distance;
        }

        /// <summary>
        /// Calculates the distance between this Point and a given Point along the y-plane.
        /// </summary>
        /// <param name="otherPoint">The Point from which to find delta y.</param>
        /// <returns>Delta y.</returns>
        public double deltaY(Point otherPoint)
        {
            double distance = Math.Abs(y - otherPoint.GetY());
            return distance;
        }

        /// <summary>
        /// Calculates the distance between this Point and a given Point.
        /// </summary>
        /// <param name="otherPoint">A Point.</param>
        /// <returns>The distance from this Point to otherPoint.</returns>
        public double distance(Point otherPoint)
        {
            double a = deltaX(otherPoint);
            double b = deltaY(otherPoint);
            double distance = Math.Sqrt(Math.Pow(a, 2) + Math.Pow(b, 2));
            return distance;
        }

        /// <summary>
        /// Calcuates the angle from this Point to a given Point.
        /// </summary>
        /// <param name="otherPoint">A Point.</param>
        /// <returns>The angle between the points in degrees.</returns>
        public double Angle(Point otherPoint)
        {
            double otherX = otherPoint.GetX();
            double otherY = otherPoint.GetY();
            double xPolarCoordinate;
            double yPolarCoordinate;

            // Determine the x-direction
            if (x < otherX)
            {
                xPolarCoordinate = deltaX(otherPoint);
            }
            else if (x > otherX)
            {
                xPolarCoordinate = -deltaX(otherPoint);
            }
            else
            {
                xPolarCoordinate = 0;
            }

            // Determine the y-direction
            if (y > otherY)
            {
                yPolarCoordinate = -deltaY(otherPoint);
            }
            else if (y < otherY)
            {
                yPolarCoordinate = deltaY(otherPoint);
            }
            else
            {
                yPolarCoordinate = 0;
            }

            // Calculate the angle
            double theta = Math.Atan2(yPolarCoordinate, xPolarCoordinate);

            // Convert radians to degrees
            theta = theta * (180 / Math.PI);
            return theta;
        }

    } 
    #endregion
}
