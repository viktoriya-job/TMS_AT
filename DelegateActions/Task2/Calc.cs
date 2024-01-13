namespace Delegate
{
    internal class Calc
    {
        public double CalcCirclePerimeter(double radius)
        {
            if (radius < 0)
                return 0;
            return 2 * Math.PI * radius;
        }

        public double CalcCircleArea(double radius)
        {
            if (radius < 0)
                return 0;
            return Math.PI * radius * radius;
        }

        public double CalcBallVolume(double radius)
        {
            if (radius < 0)
                return 0;
            return 4 / 3 * Math.PI * radius * radius * radius;
        }
    }
}
