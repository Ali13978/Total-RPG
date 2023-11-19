using UnityEngine;

namespace ScottGarland
{
    internal class DigitsArray
    {
        // Fields
        private uint[] m_data;
        internal static readonly uint AllBits;
        internal static readonly uint HiBitSet;
        private int m_dataUsed;
        
        // Properties
        internal static int DataSizeOf { get; }
        internal static int DataSizeBits { get; }
        internal uint Item { get; set; }
        internal int DataUsed { get; set; }
        internal int Count { get; }
        internal bool IsZero { get; }
        internal bool IsNegative { get; }
        
        // Methods
        internal DigitsArray(int size)
        {
            this.Allocate(size:  size, used:  0);
        }
        internal DigitsArray(int size, int used)
        {
            this.Allocate(size:  size, used:  used);
        }
        internal DigitsArray(uint[] copyFrom)
        {
            this.Allocate(size:  copyFrom.Length, used:  0);
            System.Array.Copy(sourceArray:  0, sourceIndex:  copyFrom, destinationArray:  0, destinationIndex:  this.m_data, length:  0);
            this.ResetDataUsed();
        }
        internal DigitsArray(ScottGarland.DigitsArray copyFrom)
        {
            this.Allocate(size:  copyFrom.m_data.Length, used:  copyFrom.m_dataUsed);
            System.Array.Copy(sourceArray:  0, sourceIndex:  copyFrom.m_data, destinationArray:  0, destinationIndex:  this.m_data, length:  0);
        }
        private static DigitsArray()
        {
            ScottGarland.DigitsArray.AllBits = 0;
            ScottGarland.DigitsArray.HiBitSet = -2147483648;
        }
        internal static int get_DataSizeOf()
        {
            return 4;
        }
        internal static int get_DataSizeBits()
        {
            return 32;
        }
        public void Allocate(int size)
        {
            this.Allocate(size:  size, used:  0);
        }
        public void Allocate(int size, int used)
        {
            int val_1 = size;
            val_1 = val_1 + 1;
            this.m_dataUsed = used;
            this.m_data = null;
        }
        internal void CopyFrom(uint[] source, int sourceOffset, int offset, int length)
        {
            System.Array.Copy(sourceArray:  0, sourceIndex:  source, destinationArray:  sourceOffset, destinationIndex:  this.m_data, length:  0);
        }
        internal void CopyTo(uint[] array, int offset, int length)
        {
            System.Array.Copy(sourceArray:  0, sourceIndex:  this.m_data, destinationArray:  0, destinationIndex:  array, length:  offset);
        }
        internal uint get_Item(int index)
        {
            var val_2;
            var val_3;
            uint val_4;
            var val_5;
            val_3 = index;
            if(this.m_dataUsed > val_3)
            {
                    val_2 = (long)val_3;
                val_4 = this.m_data[val_2];
                return (uint)val_4;
            }
            
            if(this.IsNegative != false)
            {
                    val_3 = 1152921504982032384;
                val_5 = null;
                val_5 = null;
                val_4 = ScottGarland.DigitsArray.AllBits;
                return (uint)val_4;
            }
            
            val_4 = 0;
            return (uint)val_4;
        }
        internal void set_Item(int index, uint value)
        {
            this.m_data[(long)index] = value;
        }
        internal int get_DataUsed()
        {
            return (int)this.m_dataUsed;
        }
        internal void set_DataUsed(int value)
        {
            this.m_dataUsed = value;
        }
        internal int get_Count()
        {
            if(this.m_data != null)
            {
                    return (int)this.m_data.Length;
            }
            
            return (int)this.m_data.Length;
        }
        internal bool get_IsZero()
        {
            if(this.m_dataUsed == 0)
            {
                    return true;
            }
            
            if(this.m_dataUsed != 1)
            {
                    return false;
            }
            
            return (bool)(this.m_data[0] == 0) ? 1 : 0;
        }
        internal bool get_IsNegative()
        {
            var val_3;
            var val_3 = -4294967296;
            val_3 = val_3 + ((this.m_data.Length) << 32);
            val_3 = null;
            val_3 = null;
            val_3 = ScottGarland.DigitsArray.HiBitSet & (this.m_data[val_3 >> 32]);
            return (bool)(val_3 == ScottGarland.DigitsArray.HiBitSet) ? 1 : 0;
        }
        internal void ResetDataUsed()
        {
            int val_6;
            System.UInt32[] val_7;
            var val_8;
            int val_9;
            int val_10;
            this.m_dataUsed = this.m_data.Length;
            val_6 = this.m_dataUsed;
            if(this.IsNegative == false)
            {
                goto label_2;
            }
            
            if(val_6 <= 1)
            {
                goto label_8;
            }
            
            val_7 = 1152921504982032384;
            label_9:
            val_8 = null;
            val_8 = null;
            val_6 = this.m_dataUsed;
            if((this.m_data[(long)val_6 - 1]) != ScottGarland.DigitsArray.AllBits)
            {
                goto label_8;
            }
            
            val_6 = val_6 - 1;
            this.m_dataUsed = val_6;
            if(val_6 >= 2)
            {
                goto label_9;
            }
            
            label_8:
            val_9 = val_6 + 1;
            goto label_10;
            label_2:
            if(val_6 <= 1)
            {
                goto label_14;
            }
            
            label_15:
            val_7 = this.m_data;
            val_10 = this.m_dataUsed;
            if((val_7[(long)val_6 - 1]) != 0)
            {
                goto label_14;
            }
            
            val_10 = val_10 - 1;
            this.m_dataUsed = val_10;
            if(val_10 >= 2)
            {
                goto label_15;
            }
            
            label_14:
            if(val_10 != 0)
            {
                    return;
            }
            
            val_9 = 1;
            label_10:
            this.m_dataUsed = val_9;
        }
        internal int ShiftRight(int shiftCount)
        {
            return ScottGarland.DigitsArray.ShiftRight(buffer:  null, shiftCount:  this.m_data);
        }
        internal static int ShiftRight(uint[] buffer, int shiftCount)
        {
            var val_14;
            var val_15;
            var val_16;
            var val_17;
            var val_18;
            var val_16 = W2;
            var val_12 = shiftCount + 24;
            val_14 = -4294967296;
            var val_13 = (long)val_12;
            val_12 = val_13 - 1;
            label_6:
            val_15 = val_12 << 32;
            if(val_13 < 2)
            {
                goto label_4;
            }
            
            int val_2 = shiftCount + (((long)(int)(((long)(int)(shiftCount + 24) - 1))) << 2);
            val_13 = val_13 - 1;
            val_12 = val_12 - 1;
            var val_3 = val_15 + val_14;
            if(((shiftCount + ((long)(int)(((long)(int)(shiftCount + 24) - 1))) << 2) + 32) == 0)
            {
                goto label_6;
            }
            
            label_4:
            if(val_16 >= 1)
            {
                    val_16 = 32;
                do
            {
                if(val_16 < val_16)
            {
                    var val_14 = 32;
                val_14 = val_14 - val_16;
                val_16 = val_16;
            }
            
                if((val_12 & 2147483648) == 0)
            {
                    var val_15 = (long)val_12;
                do
            {
                val_17 = mem[shiftCount + 24];
                val_17 = shiftCount + 24;
                if(val_15 >= val_17)
            {
                    val_17 = mem[shiftCount + 24];
                val_17 = shiftCount + 24;
            }
            
                int val_6 = shiftCount + (((long)(int)(((long)(int)(shiftCount + 24) - 1))) << 2);
                val_18 = mem[(shiftCount + ((long)(int)(((long)(int)(shiftCount + 24) - 1))) << 2) + 32];
                val_18 = (shiftCount + ((long)(int)(((long)(int)(shiftCount + 24) - 1))) << 2) + 32;
                val_14 = (val_18 >> (val_16 & 63)) | 0;
                if(val_15 >= val_17)
            {
                    val_18 = mem[(shiftCount + ((long)(int)(((long)(int)(shiftCount + 24) - 1))) << 2) + 32];
                val_18 = (shiftCount + ((long)(int)(((long)(int)(shiftCount + 24) - 1))) << 2) + 32;
                val_17 = mem[shiftCount + 24];
                val_17 = shiftCount + 24;
            }
            
                val_15 = val_18 << (val_14 & 63);
                val_15 = val_15 - 1;
                mem2[0] = val_14;
            }
            while((val_15 & 2147483648) == 0);
            
            }
            
                val_16 = val_16 - val_16;
            }
            while(val_16 > 0);
            
            }
            
            var val_8 = val_15 >> 32;
            do
            {
                if(val_8 < 2)
            {
                    return (int)val_12 + 1;
            }
            
                int val_9 = shiftCount + (((long)(int)(((long)(int)(shiftCount + 24) - 1))) << 2);
                val_8 = val_8 - 1;
                var val_10 = val_12 - 1;
            }
            while(((shiftCount + ((long)(int)(((long)(int)(shiftCount + 24) - 1))) << 2) + 32) == 0);
            
            return (int)val_12 + 1;
        }
        internal int ShiftLeft(int shiftCount)
        {
            return ScottGarland.DigitsArray.ShiftLeft(buffer:  null, shiftCount:  this.m_data);
        }
        internal static int ShiftLeft(uint[] buffer, int shiftCount)
        {
            var val_12;
            var val_13;
            var val_14;
            var val_15;
            val_12 = W2;
            var val_9 = shiftCount + 24;
            var val_10 = (long)val_9;
            val_9 = val_10 - 1;
            label_6:
            val_13 = val_9;
            if(val_10 < 2)
            {
                goto label_4;
            }
            
            int val_1 = shiftCount + (((long)(int)(((long)(int)(shiftCount + 24) - 1))) << 2);
            val_10 = val_10 - 1;
            var val_2 = val_13 - 1;
            if(((shiftCount + ((long)(int)(((long)(int)(shiftCount + 24) - 1))) << 2) + 32) == 0)
            {
                goto label_6;
            }
            
            label_4:
            val_14 = val_13 + 1;
            if(val_12 < 1)
            {
                    return (int)val_14;
            }
            
            val_13 = shiftCount + 32;
            label_19:
            var val_3 = (val_12 < 32) ? (val_12) : 32;
            if(val_14 <= 0)
            {
                goto label_15;
            }
            
            var val_12 = 0;
            int val_11 = 0;
            do
            {
                val_15 = null;
                var val_5 = ((shiftCount + 32) + 0) << (val_3 & 63);
                val_11 = val_5 | val_11;
                val_15 = null;
                val_11 = ScottGarland.DigitsArray.AllBits & val_11;
                m_value = val_11;
                var val_6 = val_5 >> 32;
                val_12 = val_12 + 1;
            }
            while(val_14 != val_12);
            
            if(val_6 == 0)
            {
                goto label_15;
            }
            
            val_14 = val_14 + 1;
            if(val_14 > (shiftCount + 24))
            {
                goto label_16;
            }
            
            int val_7 = shiftCount + (((long)(int)((((long)(int)(shiftCount + 24) - 1) + 1))) << 2);
            mem2[0] = val_6;
            goto label_18;
            label_15:
            val_14 = val_14;
            label_18:
            val_12 = val_12 - val_3;
            if(val_12 > 0)
            {
                goto label_19;
            }
            
            return (int)val_14;
            label_16:
            System.OverflowException val_8 = new System.OverflowException();
        }
        internal int ShiftLeftWithoutOverflow(int shiftCount)
        {
            var val_13;
            uint val_14;
            var val_15;
            System.Collections.Generic.List<System.UInt32> val_1 = new System.Collections.Generic.List<System.UInt32>(collection:  this.m_data);
            if(shiftCount < 1)
            {
                goto label_3;
            }
            
            label_15:
            val_13 = 0;
            val_14 = 0;
            var val_2 = (shiftCount < 32) ? shiftCount : 32;
            goto label_4;
            label_11:
            set_Item(index:  0, value:  shiftCount & val_14);
            val_14 = X25 >> 32;
            val_13 = 1;
            label_4:
            if(val_13 >= Count)
            {
                goto label_6;
            }
            
            val_15 = null;
            val_14 = (Item[1] << (val_2 & 63)) | val_14;
            val_15 = null;
            if(null != 0)
            {
                goto label_11;
            }
            
            goto label_11;
            label_6:
            int val_12 = shiftCount;
            if(val_14 != 0)
            {
                    if(null != 0)
            {
                    Add(item:  0);
                val_13 = Count;
            }
            else
            {
                    Add(item:  0);
                val_13 = Count;
            }
            
                set_Item(index:  val_13 - 1, value:  val_14);
            }
            
            val_12 = val_12 - val_2;
            if(val_12 > 0)
            {
                goto label_15;
            }
            
            label_3:
            int val_11 = Count;
            this.m_data = null;
            CopyTo(array:  null);
            if(null != null)
            {
                    return (int)System.UInt32[].__il2cppRuntimeField_namespaze;
            }
            
            return (int)System.UInt32[].__il2cppRuntimeField_namespaze;
        }
    
    }

}
