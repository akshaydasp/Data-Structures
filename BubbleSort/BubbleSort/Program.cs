/*internal class Program
{
    private static void Main(string[] args)
    {
        int[] array = { 21, 30, 18, 19, 25, 8 };
        int temp;
       // bool flag = false;

        for(int i=0; i<array.Length-1; i++)
        {
           // flag= true;
            for(int j=0; j<array.Length-i-1; j++)
            {
                if (array[j] > array[j + 1])
                {
                    temp = array[j];
                    array[j]= array[j + 1];
                    array[j+1]= temp;
                    //flag = false;
                    
                }
                
            }
            
        }
        foreach(int i in array)
        {
            Console.WriteLine(i);
        }
    }
}*/

/*using System;
using System.Collections.Generic;

class QuickSort
{
    static void Main()
    {
        int[] arr = { 7, 5, 9, 2, 4 };

        Console.WriteLine("Array before sorting:");
        PrintArray(arr);

        int[] sortedArray = QuickSortAlgorithm(arr);

        Console.WriteLine("Array after sorting:");
        PrintArray(sortedArray);
    }

    static int[] QuickSortAlgorithm(int[] arr)
    {
        if (arr.Length < 2)
        {
            return arr;
        }

        List<int> left = new List<int>();
        List<int> right = new List<int>();
        int pivot = arr[arr.Length - 1];

        for (int i = 0; i < arr.Length - 1; i++)
        {
            if (arr[i] < pivot)
            {
                left.Add(arr[i]);
            }
            else
            {
                right.Add(arr[i]);
            }
        }

        List<int> sortedArray = new List<int>();
        sortedArray.AddRange(QuickSortAlgorithm(left.ToArray()));
        sortedArray.Add(pivot);
        sortedArray.AddRange(QuickSortAlgorithm(right.ToArray()));

        return sortedArray.ToArray();
    }

    static void PrintArray(int[] arr)
    {
        foreach (int element in arr)
        {
            Console.Write(element + " ");
        }
        Console.WriteLine();
    }
}*/

using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Stack<int> stack = new Stack<int>();

        // Push elements into the stack
        stack.Push(10);
        stack.Push(20);
        stack.Push(30);
        stack.Push(40);
        stack.Push(50);

        Console.WriteLine("Original Stack:");
        PrintStack(stack);

        int indexToRemove = 2; // Index of the element to remove

        RemoveElementAt(stack, indexToRemove);

        Console.WriteLine("Stack after removing element at index " + indexToRemove + ":");
        PrintStack(stack);
    }

    static void RemoveElementAt(Stack<int> stack, int index)
    {
        if (index < 0 || index >= stack.Count)
        {
            throw new IndexOutOfRangeException("Invalid index");
        }

        Stack<int> tempStack = new Stack<int>();

        // Pop elements from the original stack and push into the temporary stack until the desired index
        for (int i = 0; i < index; i++)
        {
            tempStack.Push(stack.Pop());
        }
        stack.Pop();

        // Skip the element at the desired index by not pushing it into the temporary stack

        // Pop the remaining elements from the temporary stack and push back into the original stack
        while (tempStack.Count > 0)
        {
            stack.Push(tempStack.Pop());
        }
    }

    static void PrintStack(Stack<int> stack)
    {
        foreach (int element in stack)
        {
            Console.WriteLine(element);
        }
    }
}

