using Lib.Data.Structures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lib.Data.Algorithms
{
    public class CSearchLinkedList<T>: CAlgorithmForLinkedList<T>
    {
        //--------------------------------------------------------------------------
        public CLinkedListNode<T>? ExhaustiveSearch(CSinglyLinkedList<T> p_oLinkedList, T p_oSearchValue)
        {
            this.list = p_oLinkedList;
            return this.ExhaustiveSearch(p_oSearchValue);
        }
        //--------------------------------------------------------------------------
        public CLinkedListNode<T>? ExhaustiveSearch( T p_oSearchValue)
        {
            CLinkedListNode<T>? oFoundNode = null;
            this.IsFinished = false;

            CLinkedListNode<T>? oCurrentItem = this.list.First;
            while (oCurrentItem != null)
            {
                if (this.compare(this.list.ComparisonBy, oCurrentItem.Value, p_oSearchValue) == 0)
                {
                    oFoundNode = oCurrentItem;
                    break;
                }

                oCurrentItem = oCurrentItem.Next;
            }
            
            this.IsFinished = true;
            return oFoundNode;
        }
        //--------------------------------------------------------------------------
        public CDoublyLinkedListNode<T>? ExhaustiveSearchBackwards(T p_oSearchValue)
        {
            CDoublyLinkedListNode<T>? oFoundNode = null;
            this.IsFinished = false;

            CDoublyLinkedList<T>? oList = new CDoublyLinkedList<T>();
            if (this.list != null)
                // If a linked list is provided we expect it to be a doubly
                oList = (CDoublyLinkedList<T>)this.list;

            CDoublyLinkedListNode<T>? oCurrentItem = oList.Last;
            while (oCurrentItem != null)
            {
                if (this.compare(oList.ComparisonBy, oCurrentItem.Value, p_oSearchValue) == 0)
                {
                    oFoundNode = oCurrentItem;
                    break;
                }

                oCurrentItem = oCurrentItem.Previous;
            }

            this.IsFinished = true;
            return oFoundNode;
        }
        //--------------------------------------------------------------------------
    }
}
