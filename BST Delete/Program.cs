using System.IO;
namespace BST_Delete
{
    class Program
    {
        static Node tree = new Node(8, new Node(3, new Node(1, null, null), new Node(6, new Node(4, null, null), new Node(7, null, null))), new Node(10, null, new Node(14, new Node(13, null, null), null)));
        
        static void Main(string[] args)
        {
            Delete(SearchNode(6, tree), tree);
        }

        private static bool Delete(Node toDelete, Node root)
        {
            Node current = root;
            Node parent = root;
            bool isLeftChild = true;
            while (current.Key != toDelete.Key)
            {
                parent = current;
                if (toDelete.Key < current.Key)
                {
                    isLeftChild = true;
                    current = current.Left;
                }
                else
                {
                    isLeftChild = false;
                    current = current.Right;
                }
                if (current == null)
                {
                    return false;
                }
            }
            //No childs
            if (current.Left == null && current.Right == null)
            {
                if (current == root)
                {
                    root = null;
                }
                else if (isLeftChild)
                {
                    parent.Left = null;
                }
                else
                {
                    parent.Right = null;
                }
            }//Left child
            else if (current.Right == null)
            {
                if (current == root)
                {
                    root = current.Left;
                }
                else if (isLeftChild)
                {
                    parent.Left = current.Left;
                }
                else
                {
                    parent.Right = current.Right;
                }
            }//Right child
            else if (current.Left == null)
            {
                if (current == root)
                {
                    root = current.Right;
                }
                else if (isLeftChild)
                {
                    parent.Left = parent.Right;
                }
                else
                {
                    parent.Right = current.Right;
                }
            }
            else
            {   //Two childs
                Node successor = GetSuccessor(current);
                if (current == root)
                {
                    root = successor;
                }
                else if (isLeftChild)
                {
                    parent.Left = successor;
                }
                else
                {
                    parent.Right = successor;
                }
                successor.Left = current.Left;
            }
            return true;
        }

        static Node GetSuccessor(Node delNode)
        {
            Node successorParent = delNode;
            Node successor = delNode;
            Node current = delNode.Right;

            while (current != null)
            {
                successorParent = current;
                successor = current;
                current = current.Left;
            }
            if (successor != delNode.Right)
            {
                successorParent.Left = successor.Right;
                successor.Right = delNode.Right;
            }
            return successor;
        }

        static Node SearchNode(int key, Node node)
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
