using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Lib.Data.Structures
{
    // [C#] This
    public class CTreeNodeList<T>: CArray<CTreeNode<T>>, IEnumerable<CTreeNode<T>>
    {
        #region // IEnumerable \\
        //--------------------------------------------------------------------------
        public IEnumerator<CTreeNode<T>> GetEnumerator()
        {
            for(int i = 0; i< this.ItemCount; i++)
                yield return this.items[i];
        }
        //--------------------------------------------------------------------------
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
        //--------------------------------------------------------------------------
        #endregion
        
        // ................................................................
        private int _maxBranchingFactor = int.MaxValue;
        public int MaxBranchingFactor
        {
            get { return _maxBranchingFactor; }
            set { 
                    _maxBranchingFactor = value;
                    if (_maxBranchingFactor < this.Capacity)    
                        this.items = new CTreeNode<T>[_maxBranchingFactor];
                }
        }
        // ................................................................



        //--------------------------------------------------------------------------
        public bool Contains(CTreeNode<T> p_oNode)
        {
            bool bResult = false;
            for(int i = 0 ; i < this.itemCount; i++)
            {
                if (p_oNode == this.items[i])
                {
                    bResult = true;
                    break;
                }
            }
            return bResult;
        }
        //--------------------------------------------------------------------------
        public new void Append(CTreeNode<T> p_oNode)
        {
            this.AppendNode(p_oNode);
        }
        //--------------------------------------------------------------------------
        public void AppendNode(CTreeNode<T> p_oNode)
        {
            if (this.itemCount < this.MaxBranchingFactor)
                if (!this.Contains(p_oNode))
                    this.appendItem(p_oNode);
        }
        //--------------------------------------------------------------------------
        public void RemoveNode(CTreeNode<T> p_oNode)
        {
            if (this.Contains(p_oNode))
            if (p_oNode != null)
                this.remove(p_oNode);
        }
        //--------------------------------------------------------------------------
        public override String ToString()
        {
            String sResult = String.Empty;
            foreach(CTreeNode<T> oNode in this)
            {
                if (sResult != String.Empty)
                    sResult += "\r\n";

                sResult += $"[{oNode.Value}]".PadRight(16) + $" {oNode.Path}";
            }
            return sResult;
        }
        //--------------------------------------------------------------------------
    }
}
