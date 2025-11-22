public interface ISortAlgorithm
{
    string Name { get; }
    void Sort(int[] array, Action<int[]> onStep);
}