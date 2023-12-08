
namespace OOP.GeometricFigures
{
    internal abstract class GeometricFigure
    {
        protected string GeometricFigureType { get; set; } = "Не определен";
        public abstract float GetArea();
        public virtual void PrintInfo()
        {
            Console.WriteLine($"Фигура: {GeometricFigureType}");
        }
    }
}
