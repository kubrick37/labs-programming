namespace lab3.Tasks
{
    public class Task1
    {
        public static void Main(string[] args)
        {
            Output(1, 1, 1);
            Output(10, 2, 2);
            Output(20, 3, 3);
            Output(30, 4, 4);
        }

        static double SeriesTerm(double a, int i, double b)
        {
            return Math.Sqrt(a * i) * Math.Sqrt(b / i);
        }

        static double SeriesSum(int k, double a, double b)
        {
            if (k <= 0 || k > 30)
            {
                throw new ArgumentOutOfRangeException(nameof(k), k, "k must be in the range 1 to 30 inclusive.");
            }
            if (a < 0 || b < 0)
            {
                throw new ArgumentOutOfRangeException("a and b must be non-negative.");
            }

            double sum = 0.0;
            for (int i = 1; i <= k; i++)
            {
                sum += SeriesTerm(a, i, b);
            }
            return sum;
        }

        public static void Output(int k, double a, double b)
        {
            Console.Write($"\nk: {k}\ta: {a}\tb: {b}\tresult: ");
            try
            {
                Console.WriteLine(SeriesSum(k, a, b));
            }
            catch (ArgumentOutOfRangeException e)
            {
                Console.WriteLine("EXCEPTION! {0}", e.Message);
            }
        }
    }
}
