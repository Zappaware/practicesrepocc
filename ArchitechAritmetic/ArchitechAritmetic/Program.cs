namespace ArchitectArithmetic
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(Rect(2500, 1500));
            Console.WriteLine(Circle(375));
            Console.WriteLine(Triangle(750, 500));
            double total = Rect(2500, 1500) + Circle(375) + Triangle(750, 500);
            double result = Math.Round(total*180, 2);
            Console.WriteLine($"The total cost of the project is {result} pesos.");

        }

        static double Rect(double length, double width)
        {
            return length * width;
        }
        static double Circle(double radius)
        {
            return Math.PI * Math.Pow(radius, 2);
        }
        static double Triangle(double bottom, double height)
        {
            return 0.5 * bottom * height;
        }
    }
}
