using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lib.Data.Structures
{
    public class CBinaryTree<T> : CTree<T>
    {
        // ................................................................
        public int NodeCount { get; set; } = 0;
        // ................................................................
        public CBinaryTreeNode<T>? TopNode { get { return this.Root as CBinaryTreeNode<T>; } }
        // ................................................................
        public CBinaryTreeNode<T> BottomNode { get; set; } = null;
        // ................................................................


        

        //--------------------------------------------------------------------------
        public CBinaryTree()
        {
            
        }
        //--------------------------------------------------------------------------
        private bool NextNode(out CBinaryTreeNode<T> rp_oParent)
        {
            int nIndex = this.NodeCount + 1;
            Stack<bool> oPath = new Stack<bool>();
            while (nIndex > 1)
            {
                oPath.Push(nIndex % 2 == 1); // Push true for insert position right, false for left
                nIndex /= 2;
            }

            // Find the parent of the new node for the tree, maintaining a complete tree
            rp_oParent = (CBinaryTreeNode<T>)this.Root;
            while (oPath.Count > 1)
            {
                bool bIsRightDirection = oPath.Pop();
                rp_oParent = bIsRightDirection ? rp_oParent.Right : rp_oParent.Left;
            }

            bool bIsRight = false;
            if (oPath.Count > 0)
                 bIsRight = oPath.Pop();
            return bIsRight;
        }
        //--------------------------------------------------------------------------
        public CBinaryTreeNode<T> NewChildComplete(T p_oValue)
        {
            CBinaryTreeNode<T> oNewNode = new CBinaryTreeNode<T>()
            {
                Name = p_oValue.ToString(),
                Value = p_oValue
            };

            if (this.NodeCount == 0)
                this.Root = oNewNode; 
            else
            {
                CBinaryTreeNode<T>? oParent;
                bool bIsRight = NextNode(out oParent) ;
                if (bIsRight)
                    oParent.Right = oNewNode;
                else
                    oParent.Left = oNewNode;
            }
            this.NodeCount++;
            return oNewNode;
        }
        //--------------------------------------------------------------------------
        public void DetermineBottomNode()
        {
            CBinaryTreeNode<T>? oNewBottomNodeParent;
            NextNode(out oNewBottomNodeParent);
            if (oNewBottomNodeParent == null)
            {
                this.BottomNode = null;
                this.Root = null;
            }
            else
            {
                this.BottomNode = oNewBottomNodeParent.Right;
                if (this.BottomNode == null)
                    this.BottomNode = oNewBottomNodeParent.Left;

                if (this.BottomNode == null)
                {
                    if (oNewBottomNodeParent.OtherSibling == null)
                        this.BottomNode = oNewBottomNodeParent;
                    else if (oNewBottomNodeParent.OtherSibling.IsLeaf)
                        this.BottomNode = oNewBottomNodeParent.OtherSibling;
                    else
                    {
                        this.BottomNode = oNewBottomNodeParent.OtherSibling.Right;
                        if (this.BottomNode == null)
                            this.BottomNode = oNewBottomNodeParent.OtherSibling.Left;
                    }
                }
            }
            Debug.Print($"--> New Bottom node {this.BottomNode}");
        }
        //--------------------------------------------------------------------------
        // Preorder DFS traversal that adds the node representation to a string
        protected override string recurseNodeDescription(CTreeNode<T> p_oCurrentNode, int p_nDepth)
        {
            string sResult = "";
            
            CBinaryTreeNode<T>? oCurrentNode = p_oCurrentNode as CBinaryTreeNode<T>;
            if (oCurrentNode != null)
            {
                if (oCurrentNode.Parent == null)
                    sResult += $"> {p_oCurrentNode.Name}\r\n";
                
                if (oCurrentNode.Left != null)
                {
                    sResult += getIndentation(p_nDepth + 1) + "L__ ";
                    sResult += oCurrentNode.Left.Name + "\r\n";
                    sResult += recurseNodeDescription(oCurrentNode.Left, p_nDepth + 1);
                }
                
                if (oCurrentNode.Right != null)
                {
                    sResult += getIndentation(p_nDepth + 1) + "R__ ";
                    sResult += oCurrentNode.Right.Name + "\r\n";
                    sResult += recurseNodeDescription(oCurrentNode.Right, p_nDepth + 1);
                }
            }
            return sResult;
        }
        //--------------------------------------------------------------------------


    }
}
