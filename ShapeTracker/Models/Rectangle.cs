namespace ShapeTracker.Models
{
    public class Rectangle
    {
        private int _width;
        public int Width
        {
            get { return _width; }
            set { _width = value; }
        }

        private int _height;
        public int Height
        {
            get { return _height; }
            set { _height = value; }
        }
        private static List<Rectangle> _instances = [];

        public static List<Rectangle> GetAll()
        {
            return _instances;
        }

        public static void ClearAll()
        {
            _instances.Clear();
        }

        public int ComputeArea()
        {
            return _width * _height;
        }

        public Rectangle(int width, int height)
        {
            _width = width;
            _height = height;
            _instances.Add(this);
        }
    }
}
