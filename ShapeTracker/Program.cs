using ShapeTracker.Models;

namespace ShapeTracker
{
class Program
{
  static void Main()
  {
    Triangle testTriangle = new Triangle(50, 50, 50);
    Console.WriteLine($"Side one of the triangle: {testTriangle.GetSide(1)}");
    Console.WriteLine($"Side two of the triangle: {testTriangle.GetSide(2)}");
    Console.WriteLine($"Side three of the triangle: {testTriangle.GetSide(3)}");
    Console.WriteLine($"This is {testTriangle.CheckType()}.");
  }

}
}
