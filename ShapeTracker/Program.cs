using ShapeTracker.Models;

namespace ShapeTracker
{
class Program
{
  static void Main()
  {
    Triangle testTriangle = new Triangle(50, 50, 50);
    Console.WriteLine($"Side one of the triangle: {testTriangle.Side1}");
    Console.WriteLine($"Side two of the triangle: {testTriangle.Side2}");
    Console.WriteLine($"Side three of the triangle: {testTriangle.Side3}");
    Console.WriteLine($"This is {testTriangle.CheckType()}.")
  }

}
}
