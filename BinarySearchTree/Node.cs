using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    public class Node
    {
        //member variables
        public int value;
        public Node leftChild;
        public Node rigthChild;


        public Node(int value)
        {
            this.value = value;
        }
    }
}
