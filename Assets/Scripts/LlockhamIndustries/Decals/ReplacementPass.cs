using UnityEngine;

namespace LlockhamIndustries.Decals
{
    [Serializable]
    public class ReplacementPass
    {
        // Fields
        public UnityEngine.Vector4 vector;
        public UnityEngine.LayerMask layers;
        
        // Methods
        public ReplacementPass(UnityEngine.LayerMask Mask, UnityEngine.Vector4 LayerVector)
        {
            this.vector = LayerVector;
            mem[1152921511772308404] = LayerVector.y;
            mem[1152921511772308408] = LayerVector.z;
            mem[1152921511772308412] = LayerVector.w;
            this.layers = Mask;
        }
        public ReplacementPass(int LayerIndex, UnityEngine.Vector4 LayerVector)
        {
            int val_2 = 1 << (LayerIndex & 31);
            this.vector = LayerVector;
            mem[1152921511772420404] = LayerVector.y;
            mem[1152921511772420408] = LayerVector.z;
            mem[1152921511772420412] = LayerVector.w;
            UnityEngine.LayerMask val_3 = UnityEngine.LayerMask.op_Implicit(intVal:  0);
            this.layers = val_3;
        }
    
    }

}
