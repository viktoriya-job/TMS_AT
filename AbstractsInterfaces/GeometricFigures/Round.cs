
namespace AbstractsInterfaces.GeometricFigures
{
    internal class Round : Rectangle
    {
        private float Radius { get; set; }
        public Round(float radius) => Radius = radius;

        public override float GetPerimeter() => 2 * (float)Math.PI * Radius;

        public override float GetArea() => (float)Math.PI * Radius * Radius;
    }
}
