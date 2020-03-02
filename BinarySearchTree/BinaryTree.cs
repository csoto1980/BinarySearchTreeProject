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
        public int currentNode;
         
        //Constructor
        public BinaryTree()
        {
            root = null;
        }
        //Methods
        public void AddToTree(int value)
        {
            Node newNode = new Node(value);
            
            if (root == null)
            {
                root = newNode;
                return
            }
            Node currentNode = root;
            while (true)
            {
                if (newNode.value < currentNode.value)
                {
                    if (currentNode.leftChild == null)
                    {
                        currentNode.leftChild = newNode;
                        return;
                    }
                    else
                    {
                        currentNode = currentNode.leftChild;
                        return;
                    }
                }
                if (newNode.value > currentNode.value)
                {
                    if(currentNode.rightChild == null)
                    {
                        currentNode.rightChild = newNode;
                        return;
                    }
                    else
                    {
                        currentNode = currentNode.rightChild;
                        return;
                    }  
                }
            }
        }
        public void SearchTree(int value)
        {


        }
    }
}
