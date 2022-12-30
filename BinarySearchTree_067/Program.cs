using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree_067
{
    class node
    {
        public string info;
        public node leftchild;
        public node rightchild;

        //Constructor fot the node class

        public node(string i, node l, node r)
        {
            info = i;
            leftchild = l;
            rightchild = r;
        }
    }
    /* A node class consist os three things, the information, reference to the right child, and reference to the left child */

    class BinaryTree
    {
        public node ROOT;
        public BinaryTree()
        {
            ROOT = null; /* initializing ROOT to null */

        }
        public void insert (string element)/* insert a node in the binary search tree */
        {

        }
    }
}
