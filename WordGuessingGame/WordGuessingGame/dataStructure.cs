using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordGuessingGame
{
    public class Node
    {
        public string Data { get; set; }
        public Node Left { get; set; }
        public Node Right { get; set; }
        public Node()
        {

        }
        public Node(string data)
        {
            this.Data = data;

        }
    }


    public class BinaryTree
    {
        private Node root;
        public BinaryTree()
        {
            root = null;
        }
        public void Insert(string data)
        {
            if (root == null)
            {
                root = new Node(data);
                return;
            }
            InsertRec(root, new Node(data));
        }
        private void InsertRec(Node root, Node newNode)
        {
            if (root == null)
                root = newNode;

            if (string.Compare(newNode.Data, root.Data) < 0)
            {
                if (root.Left == null)
                    root.Left = newNode;
                else
                    InsertRec(root.Left, newNode);

            }
            else
            {
                if (root.Right == null)
                    root.Right = newNode;
                else
                    InsertRec(root.Right, newNode);
            }
        }
        private int getTreeValue(int index)
        {
            return 0;
        }
    }
}