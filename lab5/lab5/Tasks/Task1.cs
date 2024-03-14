namespace lab5.Tasks
{
    public class Task1
    {
        public static void Main(String[] args)
        {
            int[,] matrix = new int[5, 5]
            {
                {1, 2, 3, 4, 5},
                {6, 7, 8, 9, 10},
                {11, 12, 13, 14, 15},
                {16, 17, 18, 19, 20},
                {21, 22, 23, 24, 25}
            };

            Console.WriteLine($"Min value in colums with biggest sum of modules: {MinElementInLargestColumn(matrix)}");
        }

        public static int MinElementInLargestColumn(int[,] matrix)
        {
            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);

            int[] columnSums = new int[cols];

            for (int j = 0; j < cols; j++)
            {
                for (int i = 0; i < rows; i++)
                {
                    columnSums[j] += Math.Abs(matrix[i, j]);
                }
            }

            int maxSumColumn = 0;
            for (int j = 1; j < cols; j++)
            {
                if (columnSums[j] > columnSums[maxSumColumn]) maxSumColumn = j;
            }

            int minValue = int.MaxValue;
            for (int i = 0; i < rows; i++)
            {
                int value = matrix[i, maxSumColumn];
                if (value < minValue) minValue = value;
            }
            return minValue;
        }
    }
}