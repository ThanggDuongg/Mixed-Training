namespace Leetcode._21
{
  public class ListNode {
      public int val;
      public ListNode next;
      public ListNode(int val=0, ListNode next=null) {
          this.val = val;
          this.next = next;
      }
  }

    internal class Program
    {
        static void Main(string[] args)
        {
            ListNode list1 = new ListNode(1, new ListNode(2, new ListNode(4, null)));
            ListNode list2 = new ListNode(1, new ListNode(3, new ListNode(4, null)));
            Solution.MergeTwoLists(list1, list2);
        }

        public static class Solution
        {
            public static ListNode MergeTwoLists(ListNode list1, ListNode list2)
            {
                if (list1 == null)
                    return list2;
                if (list2 == null)
                    return list1;

                ListNode head = null;

                ListNode result = null;

                if (list1.val <= list2.val) {
                    result = list1;
                    list1 = list1.next; 
                } else
                {
                    result = list2;
                    list2 = list2.next;
                }
                head = result;

                while (list1 != null && list2 != null)
                {
                    if (list1.val <= list2.val)
                    {
                        result.next = list1;
                        list1 = list1.next;
                    }
                    else
                    {
                        result.next = list2;
                        list2 = list2.next;
                    }
                    result = result.next;
                }


                if (list1 != null)
                {
                    result.next = list1;
                } 

                if (list2 != null) 
                {
                    result.next = list2;
                }

                return head;
            }
        }
    }
}