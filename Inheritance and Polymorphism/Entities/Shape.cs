using Inheritance_and_Polymorphism.Entities.Enums;

namespace Inheritance_and_Polymorphism.Entities
{
    abstract internal class Shape
    {


        public Color Color { get; set; }

        public Shape() { }
        public Shape(Color color)
        {
            Color = color;
        }

        public abstract double Area();
    }
}
