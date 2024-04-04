interface IStrategy
{
    float[] sort(float[] array);
}

class StrategyBubbleSort : IStrategy
{
    public float[] sort(float[] array)
    {
        for (var i = array.Length - 1; i > 0; i--)
        {
            for (var j = 0; j < i; j++)
            {
                if (array[j] > array[j + 1])
                {
                    (array[j], array[j + 1]) = (array[j + 1], array[j]);
                }
            }
        }

        return array;
    }
}

class StrategySelectionSort : IStrategy
{
    public float[] sort(float[] array)
    {
        for (var i = 0; i < array.Length - 1; i++)
        {
            var minIndex = i;
            for (var j = i + 1; j < array.Length; j++)
            {
                if (array[j] < array[minIndex]) minIndex = j;
            }

            (array[minIndex], array[i]) = (array[i], array[minIndex]);
        }

        return array;
    }
}

class Context
{
    private IStrategy _strategy;

    public Context(IStrategy strategy)
    {
        _strategy = strategy;
    }

    public float[] sort(float[] array) => _strategy.sort(array);
}

class Program
{
    static void Main(string[] args)
    {
        Context context;

        Console.WriteLine("\nBubble sort: ");
        float[] array = { 3.0234F, 3.4235F, 1.234F, 4.2340F, 143.324F, 23.5534F, 46.0435F, 234.4532F };
        context = new Context(new StrategyBubbleSort());
        foreach (float item in context.sort(array)) Console.Write("{0} ", item);

        Console.WriteLine("\nSelection sort: ");
        float[] array2 = { 3.0234F, 3.4235F, 1.234F, 4.2340F, 143.324F, 23.5534F, 46.0435F, 234.4532F };
        context = new Context(new StrategySelectionSort());
        foreach (float item in context.sort(array2)) Console.Write("{0} ", item);
    }
}