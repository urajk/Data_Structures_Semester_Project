using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Diagnostics;
using System.Diagnostics.Tracing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Lib.Data.Structures
{
    public class CMaxHeap<T>: CBinaryTree<T>
    {
         
        //--------------------------------------------------------------------------
        public void Add(T p_oValue)
        {
            this.Append(p_oValue);
        }
        //--------------------------------------------------------------------------
        public void Append(T p_oValue)
        {
            CBinaryTreeNode<T> oNewNode = this.NewChildComplete(p_oValue);
            this.BottomNode = oNewNode;
            HeapifyToTop(oNewNode, 0);
        }
        //--------------------------------------------------------------------------
        public bool MoveBottomNodeToTop()
        {
            bool bResult = false;
            CBinaryTreeNode<T>? oTopNode = this.TopNode;
            if (oTopNode != null)
            {
                CBinaryTreeNode<T>? oBottomNode = this.BottomNode;
                Debug.Print($"--> Old Bottom node {oBottomNode}");
                if (oTopNode != oBottomNode)
                {
                    bResult = true;

                    // Make the bottom node the new root
                    oBottomNode.Parent = null;
                    oBottomNode.Left = oTopNode.Left;
                    oBottomNode.Right = oTopNode.Right;
                    this.Root = oBottomNode;
                }
            }
            return bResult;
        }
        //--------------------------------------------------------------------------
        public CBinaryTreeNode<T>? ExtractTop()
        {
            CBinaryTreeNode<T>? oTopNode = this.TopNode;
            if (oTopNode != null)
            {
                if (MoveBottomNodeToTop())
                {
                    oTopNode.Parent = null;     // Removes the top node from the tree
                    oTopNode.Children.Clear();  // Removes any references to the children
                    
                    this.HeapifyToBottom((CBinaryTreeNode<T>)this.Root, 0);
                }
                else
                {
                    oTopNode.Parent = null;     // Removes the top node from the tree
                    oTopNode.Children.Clear();  // Removes any references to the children

                    this.Root = null;
                }
                this.NodeCount--;
                DetermineBottomNode();
            }
            return oTopNode;
        }
        //--------------------------------------------------------------------------
        protected void HeapifyToBottom(CBinaryTreeNode<T> p_oParent, int p_nDepth)
        {
            CBinaryTreeNode<T>? oLeftChild = p_oParent.Left;
            CBinaryTreeNode<T>? oRightChild = p_oParent.Right;
            CBinaryTreeNode<T>? oLargestChild = null;

            if ((oLeftChild != null) && (oRightChild != null))
            { 
                if (this.Compare(oLeftChild.Value, oRightChild.Value) > 0)
                    oLargestChild = oLeftChild;
                else
                    oLargestChild = oRightChild;
            }
            else
            {
                if (oRightChild == null)
                    oLargestChild = oLeftChild;
                else
                    oLargestChild = oRightChild;
            }

            if (oLargestChild != null)
            { 
                if (this.Compare(p_oParent.Value, oLargestChild.Value) < 0)
                {
                    p_oParent.SwapWithChild(oLargestChild);
                    if (this.Root == p_oParent)
                        this.Root = oLargestChild;
                    HeapifyToBottom(oLargestChild, p_nDepth + 1);
                }
            }
        }
        //--------------------------------------------------------------------------
        protected void HeapifyToTop(CBinaryTreeNode<T> p_oNode, int p_nDepth)
        {
            CBinaryTreeNode<T>? oParent = p_oNode.Parent as CBinaryTreeNode<T>;
            if (oParent != null)
            {
                if (this.Compare(oParent.Value, p_oNode.Value) < 0)
                {
                    oParent.SwapWithChild(p_oNode);
                    if (oParent == this.Root)
                        this.Root = p_oNode;
                    if (this.BottomNode == p_oNode)
                        this.BottomNode = oParent;
                    HeapifyToTop(p_oNode, p_nDepth + 1);
                }
            }
        }
        //--------------------------------------------------------------------------
        protected void deleteLastItem()
        {
            CBinaryTreeNode<T>? oBottomNode = this.BottomNode;
            if (this.Root == this.BottomNode)
            { 
                this.Root = null;
                this.BottomNode = null;
            }
            oBottomNode.Parent = null;
        }
        //--------------------------------------------------------------------------
    }
}

