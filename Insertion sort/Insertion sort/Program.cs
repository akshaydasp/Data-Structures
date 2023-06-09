/*internal class Program
{
    private static void Main(string[] args)
    {
        int[] array = { 3, 5, 8, 2, 6, 10 };
        InsertionSort(array);
        Print(array);
    }

    public static void InsertionSort(int[] array)
    {
        int n =array.Length;

        for(int i = 1; i < n; i++)
        {
            int Key = array[i];
            int j = i - 1;

            while(j >= 0 && array[j] > Key)
            {
                array[j+1] = array[j];
                j--;
            }
             array[j+1] = Key;
        }
    }

    public static void Print(int[] array)
    {
        foreach(int i in array)
        {
            Console.WriteLine(i);
        }
    }
}*/
using System;
using System.Collections.Generic;

class Queue<T>
{
    private LinkedList<T> elements;

    public int Count
    {
        get { return elements.Count; }
    }

    public Queue()
    {
        elements = new LinkedList<T>();
    }

    public void Enqueue(T item)
    {
        elements.AddLast(item);
    }

    public T Dequeue()
    {
        if (elements.Count == 0)
        {
            throw new InvalidOperationException("The queue is empty.");
        }

        T item = elements.First.Value;
        elements.RemoveFirst();
        return item;
    }

    public T Peek()
    {
        if (elements.Count == 0)
        {
            throw new InvalidOperationException("The queue is empty.");
        }

        return elements.First.Value;
    }

    public void Clear()
    {
        elements.Clear();
    }
}

class Program
{
    static void Main()
    {
        Queue<int> queue = new Queue<int>();

        // Enqueue elements
        queue.Enqueue(1);
        queue.Enqueue(2);
        queue.Enqueue(3);
        queue.Enqueue(4);
        queue.Enqueue(5);

        // Dequeue and print elements
        while (queue.Count > 0)
        {
            int item = queue.Dequeue();
            Console.WriteLine(item);
        }
    }
}
