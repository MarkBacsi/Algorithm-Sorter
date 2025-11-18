namespace AlgorithmSorter.Algorithms
{
    public interface ISortingAlgorithm
    {
        string Name { get; }
        void Sort(int[] array, Action<int[], int, int>? visualizationCallback = null);
    }
}