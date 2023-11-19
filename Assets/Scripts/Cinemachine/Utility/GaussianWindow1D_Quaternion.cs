using UnityEngine;

namespace Cinemachine.Utility
{
    internal class GaussianWindow1D_Quaternion : GaussianWindow1d<UnityEngine.Quaternion>
    {
        // Methods
        public GaussianWindow1D_Quaternion(float sigma, int maxKernelRadius = 10)
        {
        
        }
        protected override UnityEngine.Quaternion Compute(int windowPos)
        {
            var val_17;
            float val_18;
            float val_19;
            float val_20;
            float val_21;
            val_17 = windowPos;
            var val_1 = 34803712 + ((X22) << 4);
            val_18 = mem[(34803712 + (X22) << 4) + 32 + 4];
            val_18 = (34803712 + (X22) << 4) + 32 + 4;
            val_19 = mem[(34803712 + (X22) << 4) + 40 + 4];
            val_19 = (34803712 + (X22) << 4) + 40 + 4;
            val_20 = val_18;
            val_21 = val_19;
            UnityEngine.Quaternion val_2 = UnityEngine.Quaternion.Inverse(rotation:  new UnityEngine.Quaternion() {x = (34803712 + (X22) << 4) + 32, y = val_20, z = (34803712 + (X22) << 4) + 40, w = val_21});
            if(this.KernelSize > 0)
            {
                    var val_21 = 0;
                do
            {
                var val_4 = X24 + 0;
                var val_5 = X24 + (((long)(int)(windowPos)) << 4);
                val_21 = val_2.w;
                UnityEngine.Quaternion val_6 = UnityEngine.Quaternion.op_Multiply(lhs:  new UnityEngine.Quaternion() {x = val_2.x, y = val_2.y, z = val_2.z, w = val_21}, rhs:  new UnityEngine.Quaternion() {x = (X24 + ((long)(int)(windowPos)) << 4) + 32, y = (X24 + ((long)(int)(windowPos)) << 4) + 32 + 4, z = (X24 + ((long)(int)(windowPos)) << 4) + 40, w = (X24 + ((long)(int)(windowPos)) << 4) + 40 + 4});
                val_19 = val_6.x;
                val_18 = val_6.z;
                UnityEngine.Quaternion val_7 = UnityEngine.Quaternion.identity;
                float val_17 = 0f;
                float val_9 = ((UnityEngine.Quaternion.Dot(a:  new UnityEngine.Quaternion() {x = val_7.x, y = val_7.y, z = val_7.z, w = val_7.w}, b:  new UnityEngine.Quaternion() {x = val_19, y = val_6.y, z = val_18, w = val_6.w})) < 0) ? (-((X24 + 0) + 32)) : ((X24 + 0) + 32);
                val_7.z = val_19 * val_9;
                val_17 = val_17 + val_7.z;
                float val_18 = 0f;
                val_18 = val_18 + (val_6.y * val_9);
                float val_19 = 0f;
                val_20 = val_6.w * val_9;
                val_19 = (val_18 * val_9) + val_19;
                float val_20 = 0f;
                val_20 = val_20 + val_20;
                var val_14 = ((val_17 + 1) == this.KernelSize) ? 0 : (val_17 + 1);
                val_21 = val_21 + 1;
            }
            while(val_21 < this.KernelSize);
            
            }
            
            UnityEngine.Quaternion val_16 = UnityEngine.Quaternion.op_Multiply(lhs:  new UnityEngine.Quaternion() {x = (34803712 + (X22) << 4) + 32, y = val_18, z = (34803712 + (X22) << 4) + 40, w = val_19}, rhs:  new UnityEngine.Quaternion() {x = val_17, y = val_18, z = val_19, w = val_20});
            return new UnityEngine.Quaternion() {x = val_16.x, y = val_16.y, z = val_16.z, w = val_16.w};
        }
    
    }

}
