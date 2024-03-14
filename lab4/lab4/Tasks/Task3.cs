namespace lab4.Tasks
{
    public class Task3
    {
        public static void Main(String[] args)
        {
            int[] array = { 1, 2, 3, 4, 5 };
            int[] reversedArray = new int[array.Length];

            Console.WriteLine("Initialized array:");
            foreach (int item in array) {
                Console.Write(item + " ");
            }

            for (int i = 0; i < array.Length; i++) {
                reversedArray[i] = array[array.Length - 1 - i];
            }

            Console.WriteLine("\nReversed array:");
            foreach (int item in reversedArray) {
                Console.Write(item + " ");
            }
        }
    }
}