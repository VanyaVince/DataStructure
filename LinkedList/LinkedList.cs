using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace LinearDataStructure.LinkedList
{
    public class LinkedList<T>
    {
        private Node<T> first;
        private Node<T> last;

        public void AddLast(T value)
        {
            var node = new Node<T>(value);

            if (IsEmpty())
                first = last = node;
            else
            {
                last.Next = node;
                last = node;
            }
        }

        public void AddFirst(T value)
        {
            var node = new Node<T>(value);

            if(IsEmpty())
                first = last = node;
            else
            {
                node.Next = first;
                first = node;
            }
        }

        public int IndexOf(T value)
        {
            var current = first;
            var counter = 0;

            while (current != null)
            {
                if (current.Value.Equals(value))
                    return counter;

                current = current.Next;
                counter++;
            }

            return -1;
        }

        public bool Contains(T value) => IndexOf(value) != -1;

        private bool IsEmpty()
        {
            return first == null;
        }

        private class Node<T>
        {
            public T Value { get; }
            public Node<T> Next { get; set; }

            public Node(T value)
            {
                Value = value;
            }
        }
    }
}
