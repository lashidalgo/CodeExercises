using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BST_Search
{
    class Program
    {
        static void Main(string[] args)
        {
            var tree = new Node(8, new Node(3, new Node(1, null, null), new Node(6, new Node(4, null, null), new Node(7, null, null))), new Node(10, null, new Node(14, new Node(13, null, null), null)));
            //Console.WriteLine("Found " + RecursiveSearch(13, tree).Key);
            Console.WriteLine("Found " + CiclicSearch(13, tree).Key);
            Console.ReadKey();
        }

        static Node RecursiveSearch(int key,Node node)
        {
            if (key.Equals(node.Key) || node == null)
                return node;

            return RecursiveSearch(key, key > node.Key ? node.Right : node.Left);
        }

        static Node CiclicSearch(int key, Node node)
        {
            while (node != null)
            {
                if (key.Equals(node.Key) || node == null)
                    return node;

                node = key > node.Key ? node.Right : node.Left;
            }

            return null;
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
