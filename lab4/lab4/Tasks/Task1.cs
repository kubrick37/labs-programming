namespace lab4.Tasks
{
    public class Task1
    {
        public static void Main(String[] args)
        {
            int сounter = 0;
            int[] array = { 1, -2, 3, -4, 5, -6, 7, -8, 9, -10 };

            foreach (int num in array) {
                if (num < 0) сounter++;  
            }

            Console.WriteLine("Count negative items in array: " + сounter);
        }
    }
}