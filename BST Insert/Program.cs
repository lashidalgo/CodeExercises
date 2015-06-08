using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BST_Insert
{
    class Program
    {
        static void Main(string[] args)
        {
            var tree = new Node(8, new Node(3, new Node(1, null, null), new Node(6, new Node(4, null, null), new Node(7, null, null))), new Node(10, null, new Node(14, new Node(13, null, null), null)));
            Insert(9, tree);
        }

        static Node Insert(int key, Node root)
        {
            if (key > root.Key)
            {
                if (root.Right != null)
                {
                    Insert(key, root.Right);
                }
                else
                {
                    root.Right = new Node(key,null,null);
                }
            }
            else
            {
                if (root.Left != null)
                {
                    Insert(key, root.Left);
                }
                else
                {
                    root.Left = new Node(key, null, null);
                }
            }
            return root;
        }
    }



    public class Node
    {
        public Node(int Key, Node Left, Node Right)
        {
            this.Key = Key;
            this.Left = Left;
            this.Right = Right;
        }
        public int Key { get; set; }
        public Node Left { get; set; }
        public Node Right { get; set; }
    }
}
