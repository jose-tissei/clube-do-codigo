using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicios
{
    public class MinStack
    {

        private Stack<int> stack;
        private Stack<int> minStack;

        public MinStack()
        {
            stack = new Stack<int>();
            minStack = new Stack<int>();
        }

        public void Push(int val)
        {
            stack.Push(val);
            minStack.Push(Math.Min(minStack.Peek(), val));
        }

        public void Pop()
        {
            stack.Pop();
            minStack.Pop();
        }

        public int Top()
        {
            minStack.Pop();
            return stack.Pop();
        }

        public int GetMin()
        {
            return minStack.Peek();
        }

    }
}
