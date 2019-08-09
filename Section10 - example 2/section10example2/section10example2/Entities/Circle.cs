using section10example2.Entities.Enum;

namespace section10example2.Entities
{
    class Circle : Shape
    {
        private const double pi = 3.14;
        public double Radius { get; set; }

        public Circle()
        {

        }
        public Circle(double radius, Color color)
        {
            Radius = radius;
            Color = color;
        }
        public override double Area()
        {
            return pi * Radius * Radius;
        }
    }
}
