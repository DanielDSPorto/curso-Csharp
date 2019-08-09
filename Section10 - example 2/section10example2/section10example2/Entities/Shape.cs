using section10example2.Entities.Enum;

namespace section10example2.Entities
{
    abstract class Shape
    {
        public Color Color { get; set; }

        public abstract double Area();
    }
}
