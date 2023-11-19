using UnityEngine;

namespace Cinemachine.Utility
{
    internal class GaussianWindow1D_CameraRotation : GaussianWindow1d<UnityEngine.Vector2>
    {
        // Methods
        public GaussianWindow1D_CameraRotation(float sigma, int maxKernelRadius = 10)
        {
        
        }
        protected override UnityEngine.Vector2 Compute(int windowPos)
        {
            var val_18;
            float val_19;
            float val_20;
            UnityEngine.Vector2 val_1 = UnityEngine.Vector2.zero;
            val_19 = val_1.x;
            val_20 = val_1.y;
            var val_2 = X22 + ((X23) << 3);
            if(this.KernelSize >= 1)
            {
                    do
            {
                var val_4 = X24 + (((long)(int)(windowPos)) << 3);
                UnityEngine.Vector2 val_5 = UnityEngine.Vector2.op_Subtraction(a:  new UnityEngine.Vector2() {x = (X24 + ((long)(int)(windowPos)) << 3) + 32, y = (X24 + ((long)(int)(windowPos)) << 3) + 32 + 4}, b:  new UnityEngine.Vector2() {x = (X22 + (X23) << 3) + 32, y = (X22 + (X23) << 3) + 36});
                float val_16 = -360f;
                val_16 = val_5.y + val_16;
                float val_6 = (val_5.y > 180f) ? (val_16) : val_5.y;
                val_5.y = val_6 + 360f;
                var val_8 = X24 + 0;
                UnityEngine.Vector2 val_9 = UnityEngine.Vector2.op_Multiply(a:  new UnityEngine.Vector2() {x = val_5.x, y = (val_6 < 0) ? (val_5.y) : (val_6)}, d:  (X24 + 0) + 32);
                UnityEngine.Vector2 val_10 = UnityEngine.Vector2.op_Addition(a:  new UnityEngine.Vector2() {x = val_19, y = val_20}, b:  new UnityEngine.Vector2() {x = val_9.x, y = val_9.y});
                val_19 = val_10.x;
                val_20 = val_10.y;
                var val_13 = ((windowPos + 1) == this.KernelSize) ? 0 : (windowPos + 1);
                val_18 = 0 + 1;
            }
            while(val_18 < this.KernelSize);
            
            }
            
            UnityEngine.Vector2 val_15 = UnityEngine.Vector2.op_Division(a:  new UnityEngine.Vector2() {x = val_19, y = val_20}, d:  val_5.x);
            return UnityEngine.Vector2.op_Addition(a:  new UnityEngine.Vector2() {x = (X22 + (X23) << 3) + 32, y = (X22 + (X23) << 3) + 36}, b:  new UnityEngine.Vector2() {x = val_15.x, y = val_15.y});
        }
    
    }

}
