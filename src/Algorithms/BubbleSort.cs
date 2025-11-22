public class BubbleSort : ISortAlgorithm
{
    public string Name => "Bubble Sort";
    
    public void Sort(int[] array, Action<int[]> onStep)
    {
        for (int i = 0; i < array.Length - 1; i++)
        {
            for (int j = 0; j < array.Length - i - 1; j++)
            {
                if (array[j] > array[j + 1])
                {
                    // Swap
                    int temp = array[j];
                    array[j] = array[j + 1];
                    array[j + 1] = temp;
                    
                    // Notify UI of the change
                    onStep?.Invoke(array);
                }
            }
        }
    }
}