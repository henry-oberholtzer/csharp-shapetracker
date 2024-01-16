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

        static void ViewOrClearAllTriangles()
        {
            Console.WriteLine(
                @"
(\ 
\'\ 
 \'\     __________  
 / '|   ()_________)
 \ '/    \ triangle \
   \       \ ~tome~   \
   ==).      \__________\
  (__)       ()__________)"
            );
            Console.WriteLine(
                "The tome of ancient triangles appears before you.  Open it? Type 'open' to read of triangles long past..."
            );
            Console.WriteLine(
                "If you wish to cast the tome into the cleansing fire, enter 'burn' to ne'r hear of it again..."
            );
            string userInput = Console.ReadLine().ToLower();
            if (userInput == "open")
            {
                Console.WriteLine("The scroll unfurls before you...\n");
                int count = 1;
                List<Triangle> triangles = Triangle.GetAll();
                foreach (Triangle tri in triangles)
                {
                    Console.WriteLine($"Triangle No. {count}");
                    Console.WriteLine(
                        $"Of sides with length {tri.Side1}, {tri.Side2}, and {tri.Side3}"
                    );
                    Console.WriteLine("------------------------------------");
                    count++;
                }
                Console.WriteLine("Thus ends the tale of the triangles...");
                Console.WriteLine(
                    "If you wish to burn these triangles, enter 'burn', otherwise, enter any key to return whence ye' came."
                );
                string userInput3 = Console.ReadLine().ToLower();
                if (userInput3 == "burn")
                {
                    ClearTriangles();
                }
                else
                {
                    ProgramLoopBack();
                }
            }
            else if (userInput == "burn")
            {
                ClearTriangles();
            }
        }

        static void ClearTriangles()
        {
            int numberOfTriangles = Triangle.GetAll().Count;
            Console.WriteLine($"You are about to burn the tales of {numberOfTriangles} triangles!");
            Console.WriteLine(
                "Do you wish to continue (enter y or press any key to douse the fire)"
            );
            string userInput2 = Console.ReadLine().ToLower();
            if (userInput2 == "y")
            {
                Triangle.ClearAll();
                Console.WriteLine("It is done...");
                ProgramLoopBack();
            }
            else
            {
                ProgramLoopBack();
            }
        }

        static void ProgramLoopBack()
        {
            Console.WriteLine("Want to dictate another triangle to me?");
            Console.WriteLine("Enter 'new' to begin another triangular analyses.\n");
            Console.WriteLine(
                "I can also consult the tome and tell you of your previous triangles..."
            );
            Console.WriteLine("Enter 'tome' to see previous triangles.");
            Console.WriteLine("...Otherwise...\n");
            Console.WriteLine("Hit any key to banish me to the void.\n");
            string userInput = Console.ReadLine().ToLower();
            if (userInput == "new")
            {
                Main();
            }
            else if (userInput == "tome")
            {
                ViewOrClearAllTriangles();
            }
            else
            {
                Console.WriteLine("Adieu!");
                Console.WriteLine("*poof!*");
            }
        }

        static void CheckTriangleType(Triangle tri)
        {
            string result = tri.CheckType();
            Console.WriteLine("//--//--//--//--//--//--//--//");
            Console.WriteLine($"This is {result}.");
            Console.WriteLine("//--//--//--//--//--//--//--//");
            ProgramLoopBack();
        }
    }
}
