using ShapeAreas.Entities.Enums;

namespace ShapeAreas.Entities
{
    abstract class Shape
    {
        public Color Color { get; set; }

        public Shape()
        {

        }

        protected Shape(Color color)
        {
            Color = color;
        }

        abstract public double Area();
    }
}
