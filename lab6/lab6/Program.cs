class Program
{
    static void Main(string[] args)
    {
        float[] array = { 3.0234F, 3.4235F, 1.234F, 4.2340F, 143.324F, 23.5534F, 46.0435F, 234.4532F };
        ShowArray(array);

        Console.WriteLine("\nBubble sort: ");
        BubbleSort(array);

        float[] array2 = { 3.0234F, 3.4235F, 1.234F, 4.2340F, 143.324F, 23.5534F, 46.0435F, 234.4532F };
        Console.WriteLine("\nSelection sort: ");
        SeletionSort(array2);
    }

    static void BubbleSort(float[] array)
    {
        for (var i = array.Length - 1; i > 0; i--)
        {
            for (var j = 0; j < i; j++)
            {
                if (array[j] > array[j + 1])
                {
                    float temp = array[j];
                    array[j] = array[j + 1];
                    array[j + 1] = temp;
                }
            }
        }
        ShowArray(array);
    }


    static void SeletionSort(float[] array)
    {
        for (int i = 0; i < array.Length - 1; i++)
        {
            int minIndex = i;
            for (int j = i + 1; j < array.Length; j++)
            {
                if (array[j] < array[minIndex]) minIndex = j;
            }

            float temp = array[minIndex];
            array[minIndex] = array[i];
            array[i] = temp;
        }
        ShowArray(array);
    }

    static void ShowArray(float[] array)
    {
        Console.WriteLine("Current array: ");
        foreach (float item in array)
        {
            Console.Write("{0} ", item);
        }
        Console.WriteLine();
    }
}