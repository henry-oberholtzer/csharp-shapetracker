using ShapeTracker.Models;
using ShapeTracker.UserInterfaceModels;

namespace ShapeTracker
{
    class Program
    {
        static void Main()
        {
            if (Triangle.GetAll().Count == 0)
            {
                Console.WriteLine(WelcomeBanner.Welcome);
                Console.WriteLine(WelcomeBanner.ShapeWizard);
            }
            Console.WriteLine("Please enter three sides for me to evaluate:");
            Console.WriteLine("Enter the first side length:");
            string stringNumber1 = Console.ReadLine();
            Console.WriteLine("Enter the second side:");
            string stringNumber2 = Console.ReadLine();
            Console.WriteLine("Enter the final side:");
            string stringNumber3 = Console.ReadLine();
            int length1 = int.Parse(stringNumber1);
            int length2 = int.Parse(stringNumber2);
            int length3 = int.Parse(stringNumber3);
            Triangle tri = new Triangle(length1, length2, length3);
            ConfirmOrEditTriangle(tri);
        }

        static void ConfirmOrEditTriangle(Triangle tri)
        {
            Console.WriteLine("Your chosen triangle is of lengths as follows...");
            Console.WriteLine($"Side 1 is of length {tri.Side1}");
            Console.WriteLine($"Side 2 is of length {tri.Side2}");
            Console.WriteLine($"Side 3 is of length {tri.Side3}");
            Console.WriteLine("If all is correct enter 'y' otherwise, enter 'n' to start again");
            string userInput = Console.ReadLine();
            if (userInput == "y")
            {
                CheckTriangleType(tri);
            }
            else
            {
                Console.WriteLine("Please re-enter three sides for me to evaluate:");
                Console.WriteLine("Enter the first side length:");
                string stringNumber1 = Console.ReadLine();
                Console.WriteLine("Enter the second side:");
                string stringNumber2 = Console.ReadLine();
                Console.WriteLine("Enter the final side:");
                string stringNumber3 = Console.ReadLine();
                tri.Side1 = int.Parse(stringNumber1);
                tri.Side2 = int.Parse(stringNumber2);
                tri.Side3 = int.Parse(stringNumber3);
                ConfirmOrEditTriangle(tri);
            }
        }

        static void CheckTriangleType(Triangle tri)
        {
            string result = tri.CheckType();
            Console.WriteLine("//--//--//--//--//--//--//--//");
            Console.WriteLine($"This is {result}.");
            Console.WriteLine("//--//--//--//--//--//--//--//");
            Console.WriteLine("Care to play again?");
            Console.WriteLine(
                "Enter 'y' to begin another experiment with triangles, otherwise hit any key to banish me to the void"
            );
            string userInput = Console.ReadLine();
            if (userInput == "y" || userInput == "Y")
            {
                Main();
            }
            else
            {
                Console.WriteLine("Adieu!");
            }
        }
    }
}
