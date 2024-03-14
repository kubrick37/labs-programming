class Program
{
    static void Main()
    {
        Task1(); // 9 варіант
        Task2(); // 19 варіант
        Task3(); // 29 варіант

        void Task1()
        {
            const double a = -2.98, b = 5.55, c = 0.045, d = 0.129;
            Console.WriteLine($"y = {(Math.Sin(Math.Abs(a)) + Math.Cos(Math.Sqrt(b))) / (2 * Math.Tan(c)
            + Math.Pow(Math.E, d))}");
            Console.WriteLine();
        }

        void Task2()
        {
            const double a = 1.234, b = -3.12, c = 5.45, d = 2.0;
            Console.WriteLine($"y = {Math.Sqrt(Math.Pow(Math.Tan(a), c)) / (1 + Math.Sinh(b) /
            Math.Log(Math.Abs(d) + Math.Abs(c)))}");
            Console.WriteLine();
        }

        void Task3()
        {
            const double a = -2.86, b = 1.62, c = 10.874, d = 2.91;
            Console.WriteLine($"y = {Math.Pow(2 * Math.Cos(Math.Sqrt(a / b)) + 4 * Math.Asinh(d), c)}");
            Console.WriteLine();
        }
    }
}