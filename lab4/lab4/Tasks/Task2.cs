namespace lab4.Tasks
{
    public class Task2
    {
        public static void Main(String[] args)
        {
            int[] array = { -5, 8, -12, 3, 15, -9, 7, -10, 4 };

            int maxIndex = -1;
            int maxAbsValue = int.MinValue;

            for (int i = 0; i < array.Length; i++)
            {
                if (i % 3 == 0)
                {
                    int absValue = Math.Abs(array[i]);

                    if (absValue > maxAbsValue)
                    {
                        maxAbsValue = absValue;
                        maxIndex = i;
                    }
                }
            }

            Console.WriteLine("The number of the largest array item by absolute value, whose index is a multiple of 3: " + maxIndex);
        }
    }
}
