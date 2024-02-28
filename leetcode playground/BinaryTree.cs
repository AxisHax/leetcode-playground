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

        /// <summary>
        /// Insert a value into the tree.
        /// </summary>
        /// <param name="root"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        public Node Insert(Node root, int value)
        {
            if (root is null)
                return new Node(value);

            if (value > root.value)
                root.rightChild = Insert(root.rightChild, value);
            else if (value < root.value)
                root.leftChild = Insert(root.leftChild, value);

            return root;
        }

        /// <summary>
        /// Return the node with the smallest value.
        /// </summary>
        /// <param name="root"></param>
        /// <returns></returns>
        public Node FindMin(Node root)
        {
            Node cur = root;

            while(cur != null && cur.leftChild != null)
                cur = cur.leftChild;
            return cur;
        }

        /// <summary>
        /// Find the node with the largest value.
        /// </summary>
        /// <param name="root"></param>
        /// <returns></returns>
        public Node FindMax(Node root)
        {
            Node cur = root;

            while (cur != null && cur.rightChild != null)
                cur = cur.rightChild;
            return cur;
        }

        public Node Remove(Node root, int value)
        {
            if (root is null)
                return null;

            if (value > root.value)
                root.rightChild = Remove(root.rightChild, value);
            else if (value < root.value)
                root.leftChild = Remove(root.leftChild, value);
            else
            {
                if (root.leftChild is null)
                    return root.rightChild;
                else if (root.rightChild is null)
                    return root.leftChild;
                else
                {
                    Node minNode = FindMin(root.rightChild);
                    root.value = minNode.value;
                    root.rightChild = Remove(root.rightChild, minNode.value);
                }
            }
            return root;
        }

        public void InorderTraversal(Node root)
        {
            if (root is null)
                return;

            InorderTraversal(root.leftChild);
            Console.WriteLine($"{root.value} ");
            InorderTraversal(root.rightChild);
        }
    }
}
