using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    public class Program
    {
        public static void Main(string[] args)

        {
            BinaryTree binaryTree = new BinaryTree();
            binaryTree.AddToTree(10);
            binaryTree.AddToTree(50);
            binaryTree.AddToTree(2);
            binaryTree.AddToTree(1);
            binaryTree.AddToTree(51);

            Console.WriteLine();
            Console.ReadLine();
        }
    }
}
