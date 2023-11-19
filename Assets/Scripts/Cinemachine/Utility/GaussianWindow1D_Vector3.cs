using UnityEngine;

namespace Cinemachine.Utility
{
    internal class GaussianWindow1D_Vector3 : GaussianWindow1d<UnityEngine.Vector3>
    {
        // Methods
        public GaussianWindow1D_Vector3(float sigma, int maxKernelRadius = 10)
        {
        
        }
        protected override UnityEngine.Vector3 Compute(int windowPos)
        {
            float val_14;
            float val_15;
            float val_16;
            UnityEngine.Vector3 val_1 = UnityEngine.Vector3.zero;
            val_14 = val_1.x;
            val_15 = val_1.y;
            val_16 = val_1.z;
            if(this.KernelSize < 1)
            {
                    return UnityEngine.Vector3.op_Division(a:  new UnityEngine.Vector3() {x = val_14, y = val_15, z = val_16}, d:  (X26 + 0) + 32);
            }
            
            var val_11 = 0;
            do
            {
                var val_3 = X26 + 0;
                var val_4 = X25 + ((long)windowPos * 12);
                UnityEngine.Vector3 val_5 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = ((long)(int)(windowPos) * 12) + X25 + 32, y = ((long)(int)(windowPos) * 12) + X25 + 32 + 4, z = ((long)(int)(windowPos) * 12) + X25 + 40}, d:  (X26 + 0) + 32);
                UnityEngine.Vector3 val_6 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_14, y = val_15, z = val_16}, b:  new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z});
                val_14 = val_6.x;
                val_15 = val_6.y;
                val_16 = val_6.z;
                var val_9 = ((windowPos + 1) == this.KernelSize) ? 0 : (windowPos + 1);
                val_11 = val_11 + 1;
            }
            while(val_11 < this.KernelSize);
            
            return UnityEngine.Vector3.op_Division(a:  new UnityEngine.Vector3() {x = val_14, y = val_15, z = val_16}, d:  (X26 + 0) + 32);
        }
    
    }

}
