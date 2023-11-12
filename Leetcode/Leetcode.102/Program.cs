namespace Leetcode._102
{

 // Definition for a binary tree node.
  public class TreeNode {
      public int val;
      public TreeNode left;
      public TreeNode right;
      public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
          this.val = val;
          this.left = left;
          this.right = right;
      }
  }
 

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }

        public static class Solution
        {
            public static IList<IList<int>> LevelOrder(TreeNode root)
            {
                Queue<TreeNode> queue = new Queue<TreeNode>();
                if (root != null) queue.Enqueue(root);
                IList<IList<int>> list = new List<IList<int>>();
                while (queue.Count > 0)
                {
                    int size = queue.Count;
                    List<int> list2 = new List<int>();
                    for (int i = 0; i < size; i++)
                    {
                        TreeNode treeNode = queue.Dequeue();
                        list2.Add(treeNode.val);

                        if (treeNode.left != null)
                        {
                            queue.Enqueue(treeNode.left);
                        }
                        if (treeNode.right != null)
                        {
                            queue.Enqueue(treeNode.right);
                        }
                    }
                    list.Add(list2);
                }
                return list;
            }
        }
    }
}