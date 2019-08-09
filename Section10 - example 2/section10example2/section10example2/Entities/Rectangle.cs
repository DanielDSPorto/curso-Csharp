using section10example2.Entities.Enum;

namespace section10example2.Entities
{
    class Rectangle : Shape
    {
        public double Width { get; set; }
        public double Height { get; set; }

        public Rectangle()
        {

        }
        public Rectangle(double width, double height, Color color)
        {
            Width = width;
            Height = height;
            Color = color;
        }
        public override double Area()
        {
            return Width * Height;
        }
    }
}
