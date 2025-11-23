using System;

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

            //method for bubblesort
            BubbleSort(numbers);

            //shows results for the Array after sortment
            Console.WriteLine("\nResults:");
            PrintArray(numbers);

            //exit option for the code.
            Console.WriteLine("\n press any key to exit.");
            Console.ReadKey();

        }


        //part that prints the array 
        static void PrintArray(int[] array)
        {
            //Foreach loop to go through each number within the array
            foreach (int num in array)
            {
                //writes the number
                Console.Write(num + " ");

            }
            
            Console.WriteLine();


        }
        //method for bubble sort
        static void BubbleSort(int[] array)
        {
            //gets the length of the array
            int n = array.Length;
            //outer loop to do multiple passes through the array
            for (int i = 0; i < n - 1; i++)
            {
                //Inner loop to compare adjacent elements amongst eachother
                for (int j = 0; j < n - i - 1; j++)
                {
                    //If the current element is greater than the next element swap them
                    if (array[j] > array[j + 1])
                    {
                        //Swapment using temporary variable
                        //save the firsts value
                        int temp = array[j];
                        //put the 2nd value in the first spot
                        array[j] = array[j + 1];
                        // put the saved value into the second spot
                        array[j + 1] = temp;

                        //Prints out the array after each swap to see what happens
                        Console.WriteLine("Swapped {array[j + 1]} and {array[j]}:");
                        PrintArray(array);

                    }
                }
            }
        }
    }
}