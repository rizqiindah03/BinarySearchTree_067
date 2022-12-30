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
            node tmp, parent = null, currentnode = null;
            Search(element, ref parent, ref currentnode);
            if (currentnode != null) /*check if the node to be inserted already inserted or not*/
            {
                Console.WriteLine("Duplicate words not allowed");
                return;
            }
            else /* if the spesified node is nnot present */
            {
                tmp = new node(element, null, null); /* creates a node */
                if (parent == null) /* if the three is empty*/
                {
                    ROOT = tmp;
                }
                else if (string.Compare(element, parent.info) < 0)
                {
                    parent.leftchild = tmp; 
                }
                else
                {
                    parent.rightchild = tmp;
                }
            }
        }

    }
}
