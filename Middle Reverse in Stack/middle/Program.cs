using System;
using System.Collections.Generic;

class Program
{

   /* public static int RemoveMiddleElement(Stack<int> stack)
    {
       
        Stack<int> newStack = new Stack<int>();
        int MiddleIndex = stack.Count / 2;
        int StartIndex = 0;

        while(StartIndex < MiddleIndex)
        {
            newStack.Push(stack.Pop());
            StartIndex++;
        }
       int middlelement= stack.Peek();

        while(newStack.Count > 0)
        {
            stack.Push(newStack.Pop());
            
        }

        return middlelement;
    }*/

    public static int[] ReverseArray(int[] array)
    {
        Stack<int> stack = new Stack<int>();

        foreach (int array2 in array)
        {
            stack.Push(array2);
        }

        int[] ReverseArray=new int[array.Length];

        for(int i=0;i<array.Length;i++)
        {
            ReverseArray[i] = stack.Pop();
            
        }
        return ReverseArray;
    }
    static void Main(string[] args)
    {
        /*Stack<int> stack = new Stack<int>();
        
        stack.Push(1);
        stack.Push(2);
        stack.Push(3);
        stack.Push(4);
        stack.Push(5);
        stack.Push(6);
        stack.Push(7);

       int Middleelement= RemoveMiddleElement(stack);

        Console.WriteLine("MIddle element : " + Middleelement);

        while(stack.Count > 0)
        {
            Console.WriteLine(stack.Pop());
        }*/

        int[] array = { 1, 2, 3, 4, 5 };

        int[] Reverese=ReverseArray(array);

        foreach (int array2 in Reverese)
        { 
            Console.WriteLine(array2);

        }

       
    }
}
