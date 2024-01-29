namespace Delegate
{
    internal class Calc
    {
        public double CirclePerimeter(double radius)
        {
            if (radius < 0)
                return 0;
            return 2 * Math.PI * radius;
        }

        public double CircleArea(double radius)
        {
            if (radius < 0)
                return 0;
            return Math.PI * radius * radius;
        }

        public double BallVolume(double radius)
        {
            if (radius < 0)
                return 0;
            return 4.0 / 3.0 * Math.PI * Math.Pow(radius, 3);
        }
    }
}
