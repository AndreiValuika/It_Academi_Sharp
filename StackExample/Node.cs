using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackExample
{
    class Node<T>
    {
        public T Body { get; set; }
        public Node<T> Next { get; set; }
    }
}
