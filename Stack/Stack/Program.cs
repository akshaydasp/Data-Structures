internal class Program
{
   /* public class Node
    {
        public int value;
        public Node next;
    }

    public class Stack
    {
        public Node Head;
        public int count;

        public void Push(int value)
        {
            Node node = new Node() { value=value};
            
            if(count == null)
            {
                Head = node;
                count++;
            }
            else
            {
                node.next = Head;
                Head = node;
                count++;
            }
        }
        public void Pop()
        {
            Head = Head.next;
        }
        public void Print()
        {
            Node current = Head;

            while(current != null)
            {
                Console.WriteLine(current.value);
                current = current.next;
            }
        }

       
    }

    public static void RemoveMIddle(Stack<int> stack)
    {
        Stack<int> newstack = new Stack<int>();
        int MiddleIndex = stack.Count / 2;
        int StartIndex = 0;

        while(StartIndex < MiddleIndex)
        {
            newstack.Push(stack.Pop());
            StartIndex++;
        }
        stack.Pop();

        while(newstack.Count > 0)
        {
            stack.Push(newstack.Pop());
        }
    }*/

    public static string ReverseString(string s)
    {
        Stack<char> stack = new Stack<char>();

        foreach(char c in s)
        {
            stack.Push(c);
        }

        string Reversestring = "";

        while(stack.Count > 0)
        {
            Reversestring += stack.Pop();
        }
        return Reversestring;
    }   

     private static void Main(string[] args)
     {
        /* Stack<int> stack = new Stack<int>();

        stack.Push(1);
        stack.Push(2);
        stack.Push(3);
        stack.Push(4);
        stack.Push(5);

        RemoveMIddle(stack);
        
        while(stack.Count > 0)
        {
            Console.WriteLine(stack.Pop());
        }*/

        String s = "Hello";

        string Reverse=ReverseString(s);

        Console.WriteLine(Reverse);
        
     }

   
 
}





