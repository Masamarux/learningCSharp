using ShapeAreas.Entities.Enums;

namespace ShapeAreas.Entities
{
    class Reactangle : Shape
    {
        public double Width { get; set; }
        public double Height { get; set; }

        public Reactangle(Color color, double width, double height) : base(color)
        {
            Width = width;
            Height = height;
        }

        public override double Area()
        {
            return Width * Height;
        }
    }
}
