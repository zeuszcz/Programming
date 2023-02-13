using System;

namespace Programming.Model
{
    public class Rectangle
    {
        private double _length;
        private double _width { get; set; }
        private string _color { get; set; }

        public double Length
        {
            get { return _length; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("");
                }

                _length = value;
            }
        }

        public Rectangle()
        {
        }

        public Rectangle(double length, double width, string color)
        {
            _length = length;
            _width = width;
            _color = color;
        }


}
}