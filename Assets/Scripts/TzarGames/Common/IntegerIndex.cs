using UnityEngine;

namespace TzarGames.Common
{
    public class IntegerIndex
    {
        // Fields
        private ulong _index;
        private System.Collections.Generic.List<ulong> _free;
        
        // Properties
        public ulong CurrentIndex { get; }
        public bool MaximumReached { get; }
        
        // Methods
        public IntegerIndex()
        {
            this._free = new System.Collections.Generic.List<System.UInt64>();
        }
        public IntegerIndex(ulong startValue)
        {
            this._free = new System.Collections.Generic.List<System.UInt64>();
            this._index = startValue;
        }
        public ulong Get()
        {
            System.Collections.Generic.List<System.UInt64> val_5;
            ulong val_6;
            val_5 = this;
            if(this._free.Count >= 1)
            {
                    val_5 = this._free;
                val_6 = this._free.Item[0];
                val_5.RemoveAt(index:  0);
                return val_6;
            }
            
            val_6 = this._index;
            if(val_6 != 1)
            {
                    this._index = val_6 + 1;
                return val_6;
            }
            
            System.IndexOutOfRangeException val_4 = new System.IndexOutOfRangeException();
        }
        public ulong get_CurrentIndex()
        {
            return (ulong)this._index;
        }
        public bool get_MaximumReached()
        {
            return (bool)(this._index == 1) ? 1 : 0;
        }
        public void Free(ulong index)
        {
            this._free.Add(item:  index);
        }
        public bool IsIndexFree(ulong index)
        {
            var val_4;
            if((this._free.Contains(item:  index)) == false)
            {
                    return (bool)(this._index <= index) ? 1 : 0;
            }
            
            val_4 = 1;
            return (bool)(this._index <= index) ? 1 : 0;
        }
    
    }

}
