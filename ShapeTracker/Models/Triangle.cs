namespace ShapeTracker.Models
{
    public class Triangle
    {
        private int _side1;
        public int Side1
        {
            get { return _side1; }
            set { _side1 = value; }
        }
        private int _side2;
        public int Side2
        {
            get { return _side2; }
            set { _side2 = value; }
        }
        private int _side3;
        public int Side3
        {
            get { return _side3; }
            set { _side3 = value; }
        }
        private static List<Triangle> _instances = new List<Triangle> { };

        public Triangle(int length1, int length2, int length3)
        {
            _side1 = length1;
            _side2 = length2;
            _side3 = length3;
            _instances.Add(this);
        }

        public static List<Triangle> GetAll()
        {
            return _instances;
        }

        public static void ClearAll()
        {
            _instances.Clear();
        }

        public string CheckType()
        {
            if (
                (_side1 > (_side2 + _side3))
                || (_side2 > (_side1 + _side3))
                || (_side3 > (_side1 + _side2))
            )
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
}
