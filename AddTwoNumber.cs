using System;
using System.Collections;
using System.Linq;
using System.Text;

namespace Leet_Code
{
    class AddTwoNumber
    {
        /**
  * Definition for singly-linked list.
  * public class ListNode {
  *     public int val;
  *     public ListNode next;
  *     public ListNode(int x) { val = x; }
  * }
  */
        public class Solution
        {
            public ListNode AddTwoNumbers(ListNode l1, ListNode l2, bool carry = false)
            {
                int val = 0;
                if (l2 == null && carry && l1 != null)
                {
                    val = l1.val + 1;
                    carry = false;
                }
                else if (l1 == null && carry && l2 != null)
                {
                    val = l2.val + 1;
                    carry = false;
                }
                else if (l1 == null && !carry)
                {
                    return l2;
                }
                else if (l1 == null && carry)
                {
                    ListNode l4 = new ListNode(1);
                    return l4;
                }
                else if (l2 == null && !carry)
                {
                    return l1;
                }
                else if (l2 == null && carry)
                {
                    ListNode l4 = new ListNode(1);
                    return l4;
                }

                if (carry)
                {
                    val = l1.val + l2.val + 1;
                    carry = false;
                }
                else if (val == 0)
                {
                    val = l1.val + l2.val;
                }
                if (val >= 10)
                {
                    val = val - 10;
                    carry = true;
                }
                ListNode l3 = new ListNode(val);
                if (l2 == null)
                {
                    l3.next = this.AddTwoNumbers(l1.next, l2, carry);
                }
                else if (l1 == null)
                {
                    l3.next = this.AddTwoNumbers(l1, l2.next, carry);
                }
                else
                {
                    l3.next = this.AddTwoNumbers(l1.next, l2.next, carry);
                }
                return l3;
            }
        }
    }
}