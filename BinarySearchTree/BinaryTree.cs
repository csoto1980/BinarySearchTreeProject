using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    public class BinaryTree
    {

        //Member Variables
        public Node root;
        public int newNode;

        //Constructor
        public BinaryTree()
        {
            root = null;
        }
        //Methods
        public void AddToTree(int value)
        {
            Node newNode = new Node();
            newNode.value = value;
            if (root == null)
            {
                root = newNode;
                //root = new Node(value);
            }
            else
            {
                Node current = root;
                Node parent;
                while (true)
                {
                    parent = current;
                    if ( value < current.value)
                    {
                        current = current.leftChild;
                        if (current == null)
                        {
                            parent.leftChild = newNode;
                            break;
                        }
                        else
                        {
                            current = current.rightChild;
                            if (current == null)
                            {
                                parent.rightChild = newNode;
                                break;
                            }
                        }
                    }
                }
            }

        }
        public void Search()
        {


        }
    }
}
