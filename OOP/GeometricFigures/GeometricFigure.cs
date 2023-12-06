
namespace OOP.GeometricFigures
{
    abstract class GeometricFigure
    {
        protected string GeometricFigureType { get; set; }
        public abstract float GetArea();
        public virtual void PrintInfo()
        {
            Console.WriteLine($"Фигура: {GeometricFigureType}");
        }
    }
}
