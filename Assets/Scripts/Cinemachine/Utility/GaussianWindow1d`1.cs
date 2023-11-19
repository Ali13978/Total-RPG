using UnityEngine;

namespace Cinemachine.Utility
{
    internal abstract class GaussianWindow1d<T>
    {
        // Fields
        protected T[] mData;
        protected float[] mKernel;
        protected float mKernelSum;
        protected int mCurrentPos;
        [System.Diagnostics.DebuggerBrowsableAttribute]
        private float <Sigma>k__BackingField;
        
        // Properties
        public float Sigma { get; set; }
        public int KernelSize { get; }
        
        // Methods
        public GaussianWindow1d<T>(float sigma, int maxKernelRadius = 10)
        {
            if(this != null)
            {
                
            }
            
            mem[1152921511745706500] = 0;
        }
        public float get_Sigma()
        {
            return (float)S0;
        }
        private void set_Sigma(float value)
        {
            mem[1152921511745930504] = value;
        }
        public int get_KernelSize()
        {
            if(X19 != 0)
            {
                    return (int)X19 + 24;
            }
            
            return (int)X19 + 24;
        }
        private void GenerateKernel(float sigma, int maxKernelRadius)
        {
            var val_8;
            var val_9;
            var val_10;
            float val_11;
            float val_8 = System.Math.Abs(sigma);
            val_8 = val_8 * 2.5f;
            int val_1 = UnityEngine.Mathf.FloorToInt(f:  val_8);
            int val_2 = System.Math.Min(val1:  0, val2:  maxKernelRadius);
            val_9 = null;
            mem[1152921511746154488] = val_9;
            mem[1152921511746154496] = 0;
            if(val_2 == 0)
            {
                goto label_3;
            }
            
            if(val_2 < (-val_2))
            {
                goto __RuntimeMethodHiddenParam + 24 + 168 + 8;
            }
            
            val_10 = val_2;
            goto label_5;
            label_11:
            val_10 = val_10 - 1;
            label_5:
            int val_6 = (-val_2) + 0;
            val_6 = val_6 * val_10;
            float val_9 = (float)val_6;
            val_9 = val_9 / ((sigma + sigma) * sigma);
            val_11 = V13.16B;
            if(D13 >= _TYPE_MAX_)
            {
                    float val_10 = (double)sigma * 6.28318530717959;
                val_11 = val_10;
            }
            
            val_10 = (double)val_9 / val_11;
            typeof(System.Single[]).__il2cppRuntimeField_20 = (float)val_10;
            float val_11 = typeof(System.Single[]).__il2cppRuntimeField_20;
            val_8 = 0 + 1;
            val_11 = (float)val_10 + val_11;
            mem[1152921511746154496] = val_11;
            if(((-val_2) + val_8) <= val_2)
            {
                goto label_11;
            }
            
            goto __RuntimeMethodHiddenParam + 24 + 168 + 8;
            label_3:
            typeof(System.Single[]).__il2cppRuntimeField_20 = 1065353216;
            mem[1152921511746154496] = 1065353216;
            goto __RuntimeMethodHiddenParam + 24 + 168 + 8;
        }
        protected abstract T Compute(int windowPos); // 0
        public void Reset()
        {
            mem[1152921511746266480] = 0;
        }
        public bool IsEmpty()
        {
            return (bool)(X8 == 0) ? 1 : 0;
        }
        public void AddValue(T v)
        {
            var val_4;
            var val_5;
            int val_6;
            if(X24 != 0)
            {
                    val_5 = this;
            }
            else
            {
                    mem[1152921511746494576] = __RuntimeMethodHiddenParam + 24 + 168 + 24;
                if(this >= 1)
            {
                    var val_4 = 0;
                do
            {
                typeof(Cinemachine.Utility.GaussianWindow1d<T>).__il2cppRuntimeField_20 = v;
                val_4 = val_4 + 1;
            }
            while(val_4 < this);
            
            }
            
                val_6 = UnityEngine.Mathf.Min(a:  0, b:  1);
                val_5 = this;
                mem[1152921511746494596] = val_6;
                val_4 = mem[1152921511746494576];
                if(val_4 == 0)
            {
                    val_4 = 0;
            }
            
            }
            
            var val_2 = val_4 + (((long)(int)(val_1)) << 3);
            mem2[0] = v;
            int val_3 = mem[1152921511746494596] + 1;
            mem[1152921511746494596] = val_3;
            if(val_3 != this)
            {
                    return;
            }
            
            mem[1152921511746494596] = 0;
        }
        public T Filter(T v)
        {
            if(this < 3)
            {
                    return (object)v;
            }
            
            if(this != null)
            {
                
            }
        
        }
        public T Value()
        {
            if(this == null)
            {
                
            }
        
        }
    
    }

}
