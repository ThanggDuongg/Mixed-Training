using System.Xml.Linq;

namespace leetcode._589
{
    public class Node
    {
        public int val;
        public IList<Node> children;

        public Node() { }

        public Node(int _val)
        {
            val = _val;
        }

        public Node(int _val, IList<Node> _children)
        {
            val = _val;
            children = _children;
        }
    }


    internal class program
    {
        static void main(string[] args)
        {
            Console.WriteLine("hello, world!");
        }

        public static class Solution
        {
            public static IList<int> Preorder(Node root)
            {
                if (root == null) return new List<int>();
                Stack<Node> nodes = new Stack<Node>();
                List<int> visited = new List<int>();
                nodes.Push(root);
                while (nodes.Count > 0)
                {
                    Node node = nodes.Pop();
                    visited.Add(node.val);

                    for (int i = node.children.Count - 1; i >= 0; i--)
                    {
                        nodes.Push(node.children[i]);
                    }
                }
                return visited;
            }
        }
    }
}