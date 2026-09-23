using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace Lib.Data.Structures
{
    public class CBinaryTreeNode<T>: CTreeNode<T>
    {
        // ................................................................
        protected override void setParent(CTreeNode<T> p_oParentNode)
        {
            CBinaryTreeNode<T>? oCurrentParent = this.parent as CBinaryTreeNode<T>;
            // Removes this node from the children of its current parent.
            if (oCurrentParent != null)
            {
                if (oCurrentParent.Left == this)
                    oCurrentParent.Left = null;
                else if (oCurrentParent.Right == this)
                    oCurrentParent.Right = null;
            }
                

            // Parent node of this node object is set/replaced.
            this.parent = p_oParentNode;
            oCurrentParent = this.parent as CBinaryTreeNode<T>;

            // Adds this node to the children of the new parent, if not already added
            if (oCurrentParent != null)
            {
                if (oCurrentParent.Left == null)
                    oCurrentParent.Left = this;
                else if (oCurrentParent.Right == null)
                    oCurrentParent.Right = this;
            }
        }
        // ................................................................


        // ................................................................
        public CBinaryTreeNode<T>? OtherSibling
        {
            get
            {
                CBinaryTreeNode<T>? oParent = this.Parent as CBinaryTreeNode<T>;
                if (oParent == null)
                    return null;
                else
                {
                    if (oParent.Left == this)
                        return oParent.Right;
                    else
                        return oParent.Left;    
                }
            }
        }

        // ................................................................
        public CBinaryTreeNode<T>? Left
        {
            get 
            { 
                return this.children.Items[0] as CBinaryTreeNode<T>; 
            } 
            set 
            { 
                if (this.children.ItemCount < 1)
                    this.children.AppendNode(null);

                this.children.Items[0] = value;

                if (value != null)
                    value.parent = this;
            }
        }
        // ................................................................
        public CBinaryTreeNode<T>? Right
        {
            get
            {
                return this.children.Items[1] as CBinaryTreeNode<T>;
            }
            set 
            {
                if (this.children.ItemCount < 1)
                    this.children.AppendNode(null);
                if (this.children.ItemCount < 2)
                    this.children.AppendNode(null);

                this.children.Items[1] = value; 
                if (value != null)
                    value.parent = this;
            }
        }
        // ................................................................
        public new bool IsLeaf { get { return (Left == null) && (Right == null); } }
        // ...............................................................
        public bool IsFull { get { return (Left != null) && (Right != null); } }
        // ................................................................



        //--------------------------------------------------------------------------
        public CBinaryTreeNode(): base()
        {
            this.children.MaxBranchingFactor = 2;
        }
        //--------------------------------------------------------------------------
        public void SwapLeftRight()
        {
            CBinaryTreeNode<T>? oLeft = this.Left;
            this.Left = this.Right;
            this.Right = oLeft;
        }
        //--------------------------------------------------------------------------
        public void SwapWithChild(CBinaryTreeNode<T> p_oChild)
        {
            CBinaryTreeNode<T>? oLeft = this.Left;
            CBinaryTreeNode<T>? oRight = this.Right;
            CBinaryTreeNode<T>? oParent = this.Parent as CBinaryTreeNode<T>;

            CBinaryTreeNode<T>? oChildLeft = p_oChild.Left;
            CBinaryTreeNode<T>? oChildRight = p_oChild.Right;

            this.Parent = null;
            p_oChild.Parent = null;

            if (oLeft == p_oChild)
            {
                p_oChild.Left = this;
                p_oChild.Right = oRight;
            }
            else if (oRight == p_oChild)
            {
                p_oChild.Left = oLeft;
                p_oChild.Right = this;
            }
            else
              throw new Exception("This cannot be happening!");

            this.Left = oChildLeft;
            this.Right = oChildRight;

            this.Parent = p_oChild;
            p_oChild.Parent = oParent;
        }
        //--------------------------------------------------------------------------
        public override string ToString()
        {
            if (this.Value != null)
                return this.Value.ToString();
            else
                return string.Empty;
        }
        //--------------------------------------------------------------------------

    }
}
