
using System;


public class Workshop
{
    public class ListNode
    {
        public int Value;
        public ListNode Next;
        public ListNode(int value)
        {
            Value = value;
            Next = null;
        }
    }

    public class LinkedList
    {
        public ListNode Head;
        public int Length;
        public LinkedList()
        {
            Head = null;
            Length = 0;
        }
        public void Add(int value)
        {
            if (Head == null)
            {
                Head = new ListNode(value);
                Length++;
                return;
            }
            ListNode current = Head;
            while (current.Next != null)
            {
                current = current.Next;
            }
            current.Next = new ListNode(value);
            Length++;
        }
        public void Traverse()
        {
            if (Head == null)
            {
                Console.WriteLine("Linked list is empty");
                return;
            }
            ListNode current = Head;
            while (current != null)
            {
                Console.Write(current.Value + "--->");
                current = current.Next;
            }
            Console.WriteLine("null");
        }
    }

    public class TreeNode
    {
        public int Value;
        public TreeNode Left;
        public TreeNode Right;
        public TreeNode(int value)
        {
            Value = value;
            Left = null;
            Right = null;
        }
    }

    public class BinaryTree
    {
        public TreeNode Root;
        public BinaryTree()
        {
            Root = null;
        }
        public void Insert(int value)
        {
            if (Root == null)
            {
                Root = new TreeNode(value);
                return;
            }
            InsertRecursive(Root, value);
        }
        private void InsertRecursive(TreeNode node, int value)
        {
            if (value < node.Value)
            {
                if (node.Left == null)
                {
                    node.Left = new TreeNode(value);
                }
                else
                {
                    InsertRecursive(node.Left, value);
                }
            }
            else
            {
                if (node.Right == null)
                {
                    node.Right = new TreeNode(value);
                }
                else
                {
                    InsertRecursive(node.Right, value);
                }
            }
        }
        public void InOrderTraversal()
        {
            InOrderRecursive(Root);
        }
        private void InOrderRecursive(TreeNode node)
        {
            if (node != null)
            {
                InOrderRecursive(node.Left);
                Console.Write(node.Value + " ");
                InOrderRecursive(node.Right);
            }
        }
    }

    public static void Main(string[] args)
    {
        LinkedList list = new LinkedList();
        list.Add(10);
        list.Add(20);
        list.Add(30);
        Console.WriteLine("Linked list:");
        list.Traverse();

        BinaryTree tree = new BinaryTree();
        tree.Insert(10);
        tree.Insert(-4);
        tree.Insert(11);
        tree.Insert(24);
        tree.Insert(-6);
        Console.WriteLine("\nBinary tree in order:");
        tree.InOrderTraversal();
        Console.WriteLine();
    }
}