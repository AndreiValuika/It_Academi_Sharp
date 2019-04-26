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
        public Node<T> Top { get; private set; }
        IEnumerator IEnumerable.GetEnumerator()
        {
            return ((IEnumerable)this).GetEnumerator();
        }
        IEnumerator<T> IEnumerable<T>.GetEnumerator()
        {
            Node<T> current = Top;
            while (current != null)
            {
                yield return current.Body;
                current = current.Next;
            }
        }
        public T Pop()
        {
            if (Top!=null)
            {
                T result = Top.Body;
                Top = Top.Next;
                return result;
            }
            throw new Exception("Stack is empty.");
        }
        public T Peek()
        {
            if (Top==null)
            {
                throw new Exception("Stack is empty.");
            }
            return Top.Body;
        }
        public void Push(T body)
        {
            if (Top==null)
            {
                Top = new Node<T>();
                Top.Body = body;
                Top.Next = null;
            }
            else
            {
                Node<T> tempNode = new Node<T>();
                tempNode.Body = body;
                tempNode.Next = Top;
                Top = tempNode;
            }
        }
    }

}
