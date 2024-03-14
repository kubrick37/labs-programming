namespace lab3.Tasks
{
    public class Task2
    {
        public static void Main(string[] args)
        {
            Output(0.5, 1);
            Output(0.5, 2);
            Output(0.5, 3);
            Output(0.5, 10);
        }

        private static double FunctionX(double t, int i)
        {
            if (i < 1)
            {
                throw new ArgumentOutOfRangeException(nameof(i), i, "i must be greater than or equal to 1.");
            }

            if (i == 1 || i == 2)
            {
                if (t <= 0)
                {
                    throw new ArgumentOutOfRangeException(nameof(t), t, "t must be greater than 0 when i is 1 or 2.");
                }
                return Math.Log(t);
            }
            else
            {
                double sum = 0.0;
                for (int k = 1; k <= i; k++)
                {
                    sum += Math.Sin(t) / k;
                }
                return sum;
            }
        }

        static void Output(double t, int i)
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            Console.Write($"t: {t}\ti: {i}\tresult: ");
            try
            {
                Console.WriteLine(FunctionX(t, i));
            }
            catch (ArgumentOutOfRangeException e)
            {
                Console.WriteLine("EXCEPTION! {0}", e.Message);
            }
        }
    }
}
