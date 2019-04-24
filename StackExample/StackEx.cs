using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackExample
{
    class StackEx: IEnumerable
    {
        Node top;

       

        IEnumerator IEnumerable.GetEnumerator()
        {
            Node current = top;
            while (current != null)
            {
                yield return current.Body;
                current = current.Next;
            }
        }

        public Object Pop()
        {
            if (top!=null)
            {
                Object result = top.Body;
                top = top.Next;
                return result;
            }
           
            throw new Exception("Stack is empty.");
        }

        public Object Peek()
        {
            if (top==null)
            {
                throw new Exception("Stack is empty.");
            }
            return top.Body;
        }
        public void Push(Object body)
        {
            if (top==null)
            {
                top = new Node();
                top.Body = body;
                top.Next = null;
            }
            else
            {
                Node tempNode = new Node();
                tempNode.Body = body;
                tempNode.Next = top;
                top = tempNode;
            }
        }
    }

}
