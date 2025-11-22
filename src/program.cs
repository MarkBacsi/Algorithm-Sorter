using system;

namespace AlgorithmSorter
{
    //creates the class
    class Program
    {
        //doesnt call upon anything the Main method
        static void Main(string[] args)
        {
            //the numbers to be sorted
            int[] numbers = { 21, 4, 5, 67, 2, 48, 19, 73, 12 };

            //prints and shows the array numbers before sortment
            Console.WriteLine("Before Sorting:");
            PrintArray(numbers);
        }
    }
}