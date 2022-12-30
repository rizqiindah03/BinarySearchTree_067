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
        static void Main(string[] args)
        {
        }
    }
}
