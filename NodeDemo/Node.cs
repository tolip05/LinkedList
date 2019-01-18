using System;
using System.Collections.Generic;
using System.Text;

namespace NodeDemo
{
    public class Node<T>
    {
        private T value;
        private Node<T> next;

        public Node(T value)
        {
            this.Value = value;
        }
        public T Value { get; set; }
        public Node<T> Next { get; set; }
    }
}
