using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace LinearDataStructure.LinkedList
{
    public class Node<T>
    {
        public T? Value { get; set; }
        public Node<T>? Next { get; set; }
    }
}
