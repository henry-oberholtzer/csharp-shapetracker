namespace ShapeTracker.Models
{
  public class Triangle
{
  private int _side1;
  private int _side2;
  private int _side3;

  public Triangle(int length1, int length2, int length3)
  {
    _side1 = length1;
    _side2 = length2;
    _side3 = length3;
  }
  public int GetSide1()
  {
    return _side1;
  }
  public int GetSide2()
  {
    return _side2;
  }
  public int GetSide3()
  {
    return _side3;
  }
  }
  public void SetSide1(int value)
  {
    _side1 = value;
  }
  public void SetSide2(int value)
  {
    _side2 = value;
    }
  public void SetSide3(int value)
  {
    _side3 = value;
  }
  public string CheckType()
  {
    if ((_side1 > (_side2 + _side3)) || (_side2 > (_side1 + _side3)) || (_side3 > (_side1 + _side2)))
    {
      return "not a triangle";
    }
    else if ((_side1 != _side2) && (_side1 != _side3) && (_side2 != _side3))
    {
      return "a scalene triangle";
    }
    else if ((_side1 == _side2) && (_side1 == _side3))
    {
      return "an equilateral triangle";
    }
    else
    {
      return "an isosceles triangle";
    }
  }
}
