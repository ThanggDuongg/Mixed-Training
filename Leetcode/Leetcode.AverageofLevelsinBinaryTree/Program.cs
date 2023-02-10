public class TreeNode
{
    public int val;
    public TreeNode left;
    public TreeNode right;
    public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
    {
        this.val = val;
        this.left = left;
        this.right = right;
    }
}


public class Solution
{
    public IList<double> AverageOfLevels(TreeNode root)
    {
        List<double> results = new List<double>();
        Queue<TreeNode> queue = new Queue<TreeNode>();
        queue.Enqueue(root);
        while (queue.Count() > 0)
        {
            double sum = 0.0;
            int size = queue.Count();
            for (int i = 0; i < size; i++)
            {
                TreeNode temp = queue.Dequeue();
                sum += temp.val;
                if (temp.left != null)
                {
                    queue.Enqueue(temp.left);
                }

                if (temp.right != null)
                {
                    queue.Enqueue(temp.right);
                }
            }
            results.Add(sum/size);
        }
        return results;
    }
}

//3 => 9 + 20 / 2
//9 20
//0 + 0 + 15 + 7 / 4