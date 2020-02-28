using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    class BinaryTree
    {
        // Set the parent node to the current node(root node)
        // If the data value in the new node is less than the data value in the current node 
        // set the current node to be the left child of the current
        // If greater than set the current node here and exit the loop

        //Member Variables
        Node root;
        int newNode;

        //Constructor
        public BinaryTree()
        {
            root = null;

        }
        //Methods

        public void AddToTree(int value)
        {
            
            if (root == null)
            {
                
                root = new Node(value);

            }
            else if (value >= newNode)
            {

            }

        }

        public void Search()
        {


        }
    }
}
