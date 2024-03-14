namespace lab3.Tasks
{
    public class Task3
    {
        public static void Main(String[] args)
        {
            Output(1);
            Output(0.1);
            Output(7E-7);
            Output(9E-12);
        }

        public static double Ex3(double epsilon)
        {
            if (epsilon <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(epsilon), epsilon, "Invalid value: epsilon must be greater than 0.");
            }

            double result = 0;
            double term;
            int i = 1;

            do
            {
                term = Math.Pow(-1, i + 1) / (i * (i + 1) * (i + 2));
                result += term;
                i++;
            } while (Math.Abs(term) >= epsilon);

            return result;
        }

        private static void Output(double epsilon)
        {
            Console.Write($"epsilon: {epsilon}\tresult: ");
            try
            {
                Console.WriteLine(Ex3(epsilon));
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine("EXCEPTION! {0}", ex.Message);
            }
        }
    }
}
