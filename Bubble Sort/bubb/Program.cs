using System;

public class BubbleSort
{

    public static void Main(string[] args)
    {

        // Create an array to sort
        int[] array = { 5, 1, 3, 2, 4 };

        // Bubble sort the array
        bubbleSort(array);

        // Print the sorted array
        foreach (int value in array)
        {
            Console.WriteLine(value);
        }
    }

    public static void bubbleSort(int[] array)
    {

        // Loop through the array, comparing each pair of adjacent elements
        for (int i = 0; i < array.Length - 1; i++)
        {

            // If the current element is greater than the next element, swap them
            if (array[i] > array[i + 1])
            {
                int temp = array[i];
                array[i] = array[i + 1];
                array[i + 1] = temp;
            }
        }
    }
}