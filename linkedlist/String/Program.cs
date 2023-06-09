internal class Program
{
    public class Node
    {
        public int value;
        public Node next;
    }

    public class LinkedList
    {
        public Node Head;
        public int Count = 0;

        public void Prepend(int value)
        {
            Node node = new Node() { value = value };
            if (Head == null)
            {
                Head = node;
                Count++;
            }
            else
            {
                node.next = Head;
                Head = node;
                Count++;
            }
        }
        public void Print()
        {
            Node current = Head;
            while (current != null)
            {
                Console.WriteLine(current.value);
                current = current.next;
            }
        }
        public void Append(int value)
        {
            Node node = new Node() { value = value };
            if (Head == null)
            {
                Head = node;
                Count++;
            }

            else
            {
                Node current = Head;
                while (current.next != null)
                {
                    current = current.next;
                }
                current.next = node;
                Count++;
            }
        }
        public void Remove(int value)
        {
            Node node =new Node() { value = value };

            if(Head == null)
            {
                Head = node;
                Count++;
            }else if (Head.value == value)
            {
                Head=Head.next;
                Count--;
            }
            else
            {
                Node current = Head;
                while (current.next != null && current.next.value != value)
                {
                    current = current.next;
                }
                current.next = current.next.next;
                Count--;
            }
        }
        public void Insert(int value,int index)
        {
            Node node =new Node() { value=value};

            if (index == 0)
            {
                node.next = Head;
                Head=node;
                Count++;
            }
            else
            {
                Node current = Head;
                for(int i = 0; i < index - 1; i++)
                {
                    current=current.next;
                }
                node.next = current.next;
                current.next = node;
                Count++;
            }
        }

        private static void Main(string[] args)
        {

            LinkedList linkedList = new LinkedList();

            linkedList.Append(1);
            linkedList.Append(2);
            linkedList.Append(3);
            linkedList.Append(4);
            linkedList.Remove(3);
            linkedList.Insert(3, 0);
            linkedList.Print();
            /*string input = "Hello,World,OpenAI";
            char delimiter = ',';
            string[] array = input.Split(delimiter);
            Console.WriteLine(array[0]);

            string input = "Hello, World!";
            char[] array = input.ToCharArray();
            Console.WriteLine(array[2]);

            int[] array = { 9,9,9 };
            //string delimiter = "";
            string output = string.Join("", array);
            int num = int.Parse(output);

            num += 1;
            Console.WriteLine(num);*/



        }
    }
}
