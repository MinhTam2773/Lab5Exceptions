namespace Lab5Exceptions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MakeCircle(25);
            MakeCircle(-20);
            MakeCircle(20);
            MakeCircle(10);
            MakeCircle(0);
        }

        public static void MakeCircle(double radius)
        {
            try
            {
                Circle circle = new Circle(radius);
                System.Console.WriteLine(circle);
            }
            catch (InvalidRadiusException e)
            {
                System.Console.WriteLine(e.Message + '\n');
            }
        }
    }
}
