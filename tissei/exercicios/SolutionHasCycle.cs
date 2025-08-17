using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicios
{
    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int val = 0, ListNode next = null)
        {
            this.val = val;
            this.next = next;
        }
    }

    public class SolutionHasCycle
    {
        public bool HasCycle(ListNode head)
        {
            var slowPointer = head;
            var fastPointer = slowPointer.next;
            while (fastPointer != null)
            {
                if (slowPointer == fastPointer) return true;

                slowPointer = slowPointer.next;
                fastPointer = fastPointer.next?.next;
            }

            return false;
        }
    }
}
