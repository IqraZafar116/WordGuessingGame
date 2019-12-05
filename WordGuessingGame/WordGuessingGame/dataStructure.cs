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
        public int child { get; set; }

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
        public Node root;
        //test 
        int getElements(Node root)
        {
            if (root==null)
                return 0;
            return getElements(root.Left) +
                  getElements(root.Right) + 1;
        }
        public void insertChildrenCount(Node root)
        {
            if (root == null)
                return;
            root.child = getElements(root) - 1;
            insertChildrenCount(root.Left);
            insertChildrenCount(root.Right);
        }

        int children(Node root)
        {
            if (root == null)
                return 0;
            return root.child + 1;
        }
        string randomNodeUtil(Node root, int count)
        {
            if (root==null)
                return "";

            if (count == children(root.Left))
                return root.Data;

            if (count < children(root.Left))
                return randomNodeUtil(root.Left, count);

            return randomNodeUtil(root.Right,
                      count - children(root.Left) - 1);
        }
        // Returns Random node 
        public string randomNode(Node root)
        {
            //srand(time(0));
            Random rand = new Random();
            int count = rand.Next() % (root.child + 1);
            return randomNodeUtil(root, count);
        }
        //^^^^^^^^^^^^^^^^^^^^^test
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
        public void InsertRec(Node root, Node newNode)
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
        public string getTreeword(int index)
        {
            string word="";
            Node tp = this.root;
            while(tp !=null&&index>=0)
            {
                if (tp.Right == null|| tp.Left == null)
                {
                    break;
                }
                else
                {
                    if (tp.Data.Length % 2 == 0)
                    {
                        tp = tp.Right;
                    }
                    else if (tp.Data.Length % 2 == 1)
                    {
                        tp = tp.Left;
                    }
                    index--;
                    word = tp.Data;
                }
            }

            return word;

        }
    }
}