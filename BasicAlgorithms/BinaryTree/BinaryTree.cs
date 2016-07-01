using System;

namespace BinaryTree
{
    public class TreeNode
    {
        public string name;
        public double value;
        public TreeNode left, right;
        public TreeNode(string name, double value)
        {
            this.name = name;
            this.value = value;
            left = null;
            right = null;
        }
    }

    public class BinaryTreeMain
    {
        private TreeNode root;
        private int count = 0;

        public BinaryTreeMain()
        {
            root = null;
            count = 0;
        }

        private void DeleteTree(ref TreeNode t)
        {
            if (t != null)
            {
                DeleteTree(ref t.right);
                DeleteTree(ref t.left);
                t = null;
            }
        }

        public void Clear()
        {
            DeleteTree(ref root);
            count = 0;
        }

        public int Count()
        {
            return count;
        }

        public TreeNode FindName(string name)
        {
            TreeNode rt = root;
            int compare;
            while (rt != null)
            {
                compare = String.Compare(name, rt.name);
                if (compare == 0)
                {
                    return rt;
                }
                if (compare < 0)
                {
                    rt = rt.left;
                }
                else
                {
                    rt = rt.right;
                }
            }
            return null;
        }

        private void add(TreeNode node, ref TreeNode tree)
        {
            if (tree == null)
            {
                tree = node;
            }
            else
            {
                int compare = String.Compare(node.name, tree.name);
                if (compare == 0)
                {
                    throw new Exception();
                }
                if (compare < 0)
                {
                    add(node, ref tree.left);
                }
                else
                {
                    add(node, ref tree.right);
                }
            }
        }

        public TreeNode Insert(string name, double d)
        {
            TreeNode node = new TreeNode(name, d);
            try
            {
                if (root == null)
                {
                    root = node;
                }
                else
                {
                    add(node, ref root);
                }
                count++;
                return node;
            }
            catch (Exception)
            {
                return null;
            }
        }

        public TreeNode findSuccessor(TreeNode startNode, ref TreeNode parent)
        {
            parent = startNode;

            startNode = startNode.right;
            while (startNode.left != null)
            {
                parent = startNode;
                startNode = startNode.left;
            }
            return startNode;
        }

        private TreeNode findParent(string name, ref TreeNode parent)
        {
            TreeNode rt = root;
            parent = null;
            int compare;
            while (rt != null)
            {
                compare = String.Compare(name, rt.name);
                if (compare == 0)
                {
                    return rt;
                }
                if (compare < 0)
                {
                    parent = rt;
                    rt = rt.left;
                }
                else
                {
                    parent = rt;
                    rt = rt.right;
                }
            }
            return null;
        }

        public void Delete(string key)
        {
            TreeNode parent = null;

            TreeNode nodeToDelete = findParent(key, ref parent);
            if (nodeToDelete == null)
            {
                throw new Exception("Unable to delete node: " + key.ToString());
            }
            if ((nodeToDelete.left == null) && (nodeToDelete.right == null))
            {
                if (parent == null)
                {
                    root = null;
                    return;
                }

                if (parent.left == nodeToDelete)
                    parent.left = null;
                else
                    parent.right = null;
                count--;
                return;
            }
            if (nodeToDelete.left == null)
            {
                if (parent == null)
                {
                    root = nodeToDelete.right;
                    return;
                }

                if (parent.left == nodeToDelete)
                    parent.right = nodeToDelete.right;
                else
                    parent.left = nodeToDelete.right;
                nodeToDelete = null;
                count--;
                return;
            }

            if (nodeToDelete.right == null)
            {

                if (parent == null)
                {
                    root = nodeToDelete.left;
                    return;
                }

                if (parent.left == nodeToDelete)
                    parent.left = nodeToDelete.left;
                else
                    parent.right = nodeToDelete.left;
                nodeToDelete = null;
                count--;
                return;
            }
            TreeNode successor = findSuccessor(nodeToDelete, ref parent);

            TreeNode tmp = new TreeNode(successor.name, successor.value);

            if (parent.left == successor)
                parent.left = null;
            else
                parent.right = null;

            nodeToDelete.name = tmp.name;
            nodeToDelete.value = tmp.value;
            count--;
        }
        private string drawNode(TreeNode node)
        {
            if (node == null)
                return "empty";

            if ((node.left == null) && (node.right == null))
                return node.name;
            if ((node.left != null) && (node.right == null))
                return node.name + "(" + drawNode(node.left) + ", _)";

            if ((node.right != null) && (node.left == null))
                return node.name + "(_, " + drawNode(node.right) + ")";

            return node.name + "(" + drawNode(node.left) + ", " + drawNode(node.right) + ")";
        }
        public string drawTree()
        {
            return drawNode(root);
        }
    }
}

