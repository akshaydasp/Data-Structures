internal class Program
{
    private static void Main(string[] args)
    {
       namespace Singly_LinkedList
{
    public class linkedList
    {
        public class Node
        {
            public int data;
            public Node? next;

            public Node(int data)
            {
                this.data = data;
            }
        }
        public Node? head = null;
        public Node? tail = null;

        public void addNodeLast(int data)
        {
            Node newNode = new Node(data);

            if (head == null)
            {
                head = newNode;
            }
            else
            {
                tail.next = newNode;
            }
            tail = newNode;
        }
        public void insertAfter(int nextTo, int data)
        {
            Node? newNode = new Node(data);
            Node? temp = head;

            while (temp != null && temp.data != nextTo)
            {
                temp = temp.next;
            }
            if (temp == tail)
            {
                tail.next = newNode;
                tail = newNode;
                return;
            }
            newNode.next = temp.next;
            temp.next = newNode;
        }
        public void display()
        {
            if (head == null)
            {
                Console.WriteLine("empty");
            }
            Node? temp = head;
            while (temp != null)
            {
                Console.WriteLine(temp.data);
                temp = temp.next;
            }
        }
        public void deleteValue(int data)
        {
            Node? temp = head;
            Node? prev = null;

            if (temp != null && temp.data == data)
            {
                head = temp.next;
                return;
            }
            while (temp != null && temp.data != data)
            {
                prev = temp;
                temp = temp.next;
            }
            if (temp == null)
            {
                return;
            }
            prev.next = temp.next;
        }
        public void selectionSort()
        {
            if (head == null)
            {
                Console.WriteLine("NODE IS EMPTY");
            }
            else
            {
                Node? temp = head;
                while (temp != null)
                {
                    Node? trav = temp.next;
                    while (trav != null)
                    {
                        if (temp.data > trav.data)
                        {
                            int swap = temp.data;
                            temp.data = trav.data;
                            trav.data = swap;
                        }
                        trav = trav.next;
                    }
                    temp = temp.next;
                }
            }
        }

        public void bubbleSort()
        {
            if (head == null)
            {
                Console.WriteLine("List is Empty");
            }
            else
            {
                Node? temp = head;
                while (temp != null)
                {
                    Node? trav = head;
                    while (trav.next != null)
                    {
                        if (trav.data > trav.next.data)
                        {
                            int swap = trav.data;
                            trav.data = trav.next.data;
                            trav.next.data = swap;
                        }
                        trav = trav.next;
                    }
                    temp = temp.next;
                }
            }
        }






    }
}
    }
}