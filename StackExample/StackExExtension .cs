using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackExample
{
     static class StackExExtension
    {
        static public StackEx<string> IntToString (this StackEx<int> ts)
        {
            StackEx<String> tempStack = new StackEx<String>();
            StackEx<String> resultStack = new StackEx<String>();

            foreach (var item in ts)
            {
                tempStack.Push(item.ToString());
            }

            foreach (var item in tempStack)
            {
                resultStack.Push(item);
            }
            return resultStack; 
        }
    }
}
