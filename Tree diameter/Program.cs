using System;

namespace Tree_diameter
{
    public class Node
    {
        public int Data { get; set; }
        public Node Left { get; set; }
        public Node Right { get; set; }

        public Node(int data)
        {
            Data = data;
        }
    };

    //Given a Balanced binary tree calc the tree diameter
    //The tree diameter is the longest path between their branches (2 subtrees)
    class Program
    {
        static void Main(string[] args)
        {
            /* Constructed binary tree is 
                      1
                    /   \
                  2      3
                /  \
              4     5
            It is a balanced binary tree*/
            var root = new Node(1);
            root.Left = new Node(2);
            root.Right = new Node(3);
            root.Left.Left = new Node(4);
            root.Left.Right = new Node(5);
            Console.WriteLine(Diameter(root));
            Console.ReadKey();
        }

        public static int Diameter(Node tree)
        {
            if (tree == null) return 0;

            var lheight = Height(tree.Left);
            var rheight = Height(tree.Right);

            var ldiameter = Diameter(tree.Left);
            var rdiameter = Diameter(tree.Right);

            return Max(lheight + rheight + 1, Max(ldiameter, rdiameter));
        }

        //The following function returns the height of a tree (the number of nodes on the longest root-to-leaf path).
        // postcondition: returns height of tree with root tree
        public static int Height(Node tree)
        {
            if (tree == null)
            {
                return 0;
            }
            return 1 + Max(Height(tree.Left), Height(tree.Right));
        }

        public static int Max(int a, int b)
        {
            return (a > b) ? a : b;
        }
    }
}