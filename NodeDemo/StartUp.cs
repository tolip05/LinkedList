using System;

namespace NodeDemo
{
    class StartUp
    {
        static void Main(string[] args)
        {
            Node<int> firstNode = new Node<int>(5);
            Node<int> secondNode = new Node<int>(10);
            Node<int> third = new Node<int>(15);
            firstNode.Next = secondNode;
            secondNode.Next = third;
            Node<int> current = firstNode;
            while (current != null)
            {
                Console.WriteLine(current.Value);
                current = current.Next;
            }

        }
    }
}
