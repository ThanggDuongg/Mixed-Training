namespace Leetcode
{
    public class Program
    {
        private static void Main(string[] args)
        {
            var solution = new Solution();
            var list = new ListNode(1, new ListNode(2, new ListNode(1, new ListNode(2, new ListNode(1, new ListNode(2))))));
            solution.ModifiedList(new int[] { 1 }, list);
        }

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

        public class Solution
        {
            public ListNode ModifiedList(int[] nums, ListNode head)
            {
                HashSet<int> numSet = nums.ToHashSet();
                ListNode result = new ListNode(-1);
                ListNode current = result;
                while (head != null)
                {
                    if (!numSet.Contains(head.val))
                    {
                        current.next = new ListNode(head.val);
                        current = current.next;
                    }
                    head = head.next;
                }
                return result.next;
            }
        }
    }
}