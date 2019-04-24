using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackExample
{
    class StackEx
    {
        Node top;
        public Object pop()
        {
            if (top!=null)
            {
                Object result = top.Body;
                top = top.Next;
                return result;
            }
           
            throw new Exception("Stack is empty.");
        }

        public void push(Object body)
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
