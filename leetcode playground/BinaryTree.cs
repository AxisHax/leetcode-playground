using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode_playground
{
    public class Node
    {
        public int value;
        public Node? leftChild;
        public Node? rightChild;

        public Node(int value)
        {
            this.value = value;
            leftChild = null;
            rightChild = null;
        }
    }
    public class BinaryTree
    {
        Node root;

        /// <summary>
        /// Create a Binary Tree using the parameter as the root node.
        /// </summary>
        /// <param name="root"></param>
        public BinaryTree(Node root)
        {
            this.root = root;
        }
    }

    public class BinarySearchTree
    {
        Node root;

        /// <summary>
        /// Create a BST using the passed in node as the root of the tree.
        /// </summary>
        /// <param name="root"></param>
        public BinarySearchTree(Node root)
        {
            this.root = root;
        }

        public bool Search(Node root, int target)
        {
            if(root is null)
                return false;

            if (target > root.value)
                return Search(root.rightChild, target);
            else if (target < root.value)
                return Search(root.leftChild, target);
            else
                return true;
        }

        /// <summary>
        /// Returns the subtree who's value equals the specified target
        /// </summary>
        /// <param name="root"></param>
        /// <param name="target"></param>
        /// <returns></returns>
        public Node SearchForSubtree(Node root, int target)
        {
            if (root is null)
                return null;
            if (root.value == target)
                return root;

            if (target < root.value)
                return SearchForSubtree(root.leftChild, target);
            else
                return SearchForSubtree(root.rightChild, target);
        }
    }
}
