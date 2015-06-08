using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Height_of_a_tree
{
    class Program
    {
        static Node tree = new Node(8, new Node(3, new Node(1, null, null), new Node(6, new Node(4, null, null), new Node(7, null, null))), new Node(10, null, new Node(14, new Node(13, null, null), null)));
        
        static void Main(string[] args)
        {
            Console.WriteLine(GetHeight(tree));
            Console.ReadKey();
        }

        static int GetHeight(Node tree)
        {
            if (tree == null) return 0;

            return Math.Max(GetHeight(tree.Left), GetHeight(tree.Right)) + 1;
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
