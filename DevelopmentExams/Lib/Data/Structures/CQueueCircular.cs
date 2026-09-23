using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lib.Data.Structures
{
    public class CQueueCircular<T>
    {
        protected T[] items;

        private int firstIndex = 0;
        private int lastIndex = -1;
        // ................................................................
        private int capacity = 20;
        public int Capacity { get { return capacity; } }
        // ................................................................
        protected int itemCount = 0;
        public int ItemCount { get { return this.itemCount; } }
        // ................................................................
        public bool IsFull { get { return (this.itemCount >= this.capacity); } }
        // ................................................................
        public bool IsEmpty { get { return this.ItemCount == 0; } }
        // ................................................................



        //--------------------------------------------------------------------------
        public CQueueCircular()
        {
            this.items = new T[this.capacity];
        }
        //--------------------------------------------------------------------------
        public CQueueCircular(int p_nCapacity)
        {
            this.capacity = p_nCapacity;
            this.items = new T[this.capacity];
            Debug.WriteLine($"Created queue with capacity to hold {this.capacity} items");
        }
        //--------------------------------------------------------------------------
        public bool Enqueue(T p_oItem)
        {
            bool bResult = !this.IsFull;
            if (bResult)
            {
                // Moving the last index: We get the remainder of the division
                // with the queue capacity. This ensures the wrap-around.
                this.lastIndex = (this.lastIndex + 1) % this.capacity;
                this.items[this.lastIndex] = p_oItem;
                this.itemCount++;
            }
            return bResult;
        }
        //--------------------------------------------------------------------------
        public T? Dequeue()
        {
            T? oItem = this.Peek();
            if (!this.IsEmpty)
            {
                this.items[this.firstIndex] = default(T);
                
                // Moving the first index: We get the remainder of the division
                // with the queue capacity. This ensures the wrap-around.       
                this.firstIndex = (this.firstIndex + 1) % this.capacity;
                this.itemCount--;
            }

            return oItem;
        }
        //--------------------------------------------------------------------------
        public T? Peek()
        {
            T? oFirstItem = default(T);
            if (this.itemCount > 0)
                oFirstItem = this.items[this.firstIndex];
            return oFirstItem;
        }
        //--------------------------------------------------------------------------
        public override string ToString()
        {
            String sResult = "";
            for (int i = 0; i < this.capacity; i++)
            {
                if (i > 0)
                {
                    sResult += "\r\n";
                }
                sResult += $"{i:d2} : {this.items[i]} ";
                if (i == this.firstIndex)
                    sResult += "<- first ";
                if (i == this.lastIndex)
                    sResult += "<- last ";
            }
            return sResult;
        }
        //--------------------------------------------------------------------------   
    }
}
