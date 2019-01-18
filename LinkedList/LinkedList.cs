using System;
using System.Collections;
using System.Collections.Generic;

public class LinkedList<T> : IEnumerable<T>
{
    public int Count { get; private set; }

    private Node head;
    private Node tail;

    public void AddFirst(T item)
    {
        Node oldHead = this.head;
        this.head = new Node(item);
        this.head.Next = oldHead;
        if (this.Count == 0)
        {
            this.tail = this.head;
        }
        this.Count++;
    }

    public void AddLast(T item)
    {
        if (this.Count > 0)
        {
            Node oldTail = this.tail;
            this.tail = new Node(item);
            oldTail.Next = this.tail;
        }
        else
        {
            this.tail = new Node(item);
            this.head = this.tail;
        }
        this.Count++;
    }

    public T RemoveFirst()
    {
        if (this.Count == 0)
        {
            throw new InvalidOperationException();
        }
        Node first = this.head;
        this.head = this.head.Next;
        this.Count--;
        if (this.Count == 0)
        {
            this.tail = null;
        }
        return first.Value;

    }

    public T RemoveLast()
    {
        if (this.Count == 0)
        {
            throw new InvalidOperationException();
        }
        Node last = this.tail;
        if (this.Count == 1)
        {
            this.head = null;
            this.tail = null;
            this.Count--;
        }
        else
        {
            Node newTail = this.SecondToLastNode();
            this.tail = newTail;
            this.Count--;
        }

        return last.Value;
    }

    private Node SecondToLastNode()
    {
        
        Node current = this.head;
        while (current.Next != this.tail)
        {
            current = current.Next;
           
        }
        return current;
    }

    public IEnumerator<T> GetEnumerator()
    {
        Node curent = this.head;

        while (curent.Next != null)
        {
            yield return curent.Value;
            curent = curent.Next;
        }
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return this.GetEnumerator();
    }
    private class Node
    {
        public T Value { get; set; }

        public Node Next { get; set; }

        public Node(T value)
        {
            this.Value = value;
        }
    }
}
