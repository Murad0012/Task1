namespace Task1
{
    public static class GeometryHelper
    {
        public static void AreaOfFourAngles(double l, double w)
        {
            var area = l * w;
            Console.WriteLine("Area of four angles " + area);
        }
        public static void AreaOfThreeAngles(double b, double h)
        {
            var area = 1 / 2.0 * b * h;
            Console.WriteLine("Area of three angles is " + area);
        }
        public static void AreaOfCircle(double r)
        {
            var area = Math.PI * r * r;
            Console.WriteLine("Area of circle is " + area);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            GeometryHelper.AreaOfFourAngles(7, 4);
            GeometryHelper.AreaOfThreeAngles(20, 30);
            GeometryHelper.AreaOfCircle(25);
        }

    }
}