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
        public void search(string element, ref node parent, ref node currentnode)
        {
            /* this function searches the currentnode of the specified node as
             *  null as the current node of its parent */
            currentnode = ROOT;
            parent = null;
            while ((currentnode != null) && (currentnode.info != element))
            {
                parent = currentnode;
                if (string.Compare(element, currentnode.info) < 0)
                    currentnode = currentnode.leftchild;
                else
                    currentnode = currentnode.rightchild;
            }
        }
        public void inorder(node ptr)
        {
            if (ROOT == null)
            {
                Console.WriteLine("Tree is empty");
                return;
            }
            if (ptr != null)
            {
                inorder(ptr.leftchild); 
                Console.Write(ptr.info + " ");
                inorder(ptr.rightchild);
            }
        }
        public void preorder(node ptr)
        {
            if (ROOT == null)
            {
                Console.WriteLine("Tree is empty");
                return;
            }
            if (ptr != null)
            {
                Console.Write(ptr.info + " ");
                preorder(ptr.leftchild);
                preorder(ptr.rightchild);
            }
        }
        public void postorder(node ptr) /* Perfores the postorder traversal of the tree */
        {
            if (ROOT == null)
            {
                Console.WriteLine("Tree is empty");
                return;
            }
            if (ptr != null)
            {
                postorder(ptr.leftchild);
                postorder(ptr.rightchild);
                Console.Write(ptr.info + " ");
            }
        }
        static void Main(string[] args)
        {
            BinaryTree x = new BinaryTree();
            while (true)
            {
                Console.WriteLine("\n Menu");
                Console.WriteLine("1. Implement insert operations");
                Console.WriteLine("2. Perform inorder tranversal");
                Console.WriteLine("3. Perform preorder traversal");
                Console.WriteLine("4. Perform postorder traversal");
                Console.WriteLine(" 5. Exit");
                Console.Write("\n Enter ypur choice  (1-5) :");
                char ch = Convert.ToChar(Console.ReadLine());
                Console.WriteLine();
                switch(ch)
                {
                    case '1':
                        {
                            Console.Write("Enter a word : ");
                            string word = Console.ReadLine();
                            x.insert(word);
                        }
                        break;
                    case '2':
                        {
                            x.inorder(x.ROOT);
                        }
                        break;
                    case '3':
                        {
                            x.postorder(x.ROOT);
                        }
                        break ;
                    case '5':
                        return;
                    default:
                        {
                            Console.WriteLine("Invalid option");
                            break;
                        }
                }
            }
        }
    }
}
