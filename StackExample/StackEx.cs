using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackExample
{
    class StackEx<T>: IEnumerable<T>
    {
        Node<T> top;
        IEnumerator IEnumerable.GetEnumerator()
        {
            return ((IEnumerable)this).GetEnumerator();
        }
        IEnumerator<T> IEnumerable<T>.GetEnumerator()
        {
            Node<T> current = top;
            while (current != null)
            {
                yield return current.Body;
                current = current.Next;
            }
        }
        public T Pop()
        {
            if (top!=null)
            {
                T result = top.Body;
                top = top.Next;
                return result;
            }
           
            throw new Exception("Stack is empty.");
        }

        public T Peek()
        {
            if (top==null)
            {
                throw new Exception("Stack is empty.");
            }
            return top.Body;
        }
        public void Push(T body)
        {
            if (top==null)
            {
                top = new Node<T>();
                top.Body = body;
                top.Next = null;
            }
            else
            {
                Node<T> tempNode = new Node<T>();
                tempNode.Body = body;
                tempNode.Next = top;
                top = tempNode;
            }
        }
    }

}
