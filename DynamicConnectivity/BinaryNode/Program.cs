using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryNode
{
    public class Node
    {
        public int Value { get; set; }

        public Node Left { get; set; }

        public Node Right { get; set; }

        public Node(int value, Node left, Node right)
        {
            Value = value;
            Left = left;
            Right = right;
        }
    }
    class Program
    {
        public static bool Contains(Node root, int value)
        {
            if (root.Value == value)
            {
                return true;
            }
            bool found = false;

            if (root.Left != null)
            {
                found = Contains(root.Left, value);
            }

            if (!found && root.Right != null)
            {
                found = Contains(root.Right, value);
            }

            return found;
        }

        public static void Main(string[] args)
        {
            Node n1 = new Node(1, null, null);
            Node n3 = new Node(3, null, null);
            Node n2 = new Node(2, n1, n3);

            Console.WriteLine(Contains(n2, 3));            
        }
    }
}
