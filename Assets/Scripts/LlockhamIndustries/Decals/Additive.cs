using UnityEngine;

namespace LlockhamIndustries.Decals
{
    [Serializable]
    public class Additive : Forward
    {
        // Properties
        public override UnityEngine.Material MobileForward { get; }
        public override UnityEngine.Material StandardForward { get; }
        public override UnityEngine.Material PackedForward { get; }
        
        // Methods
        public Additive()
        {
            val_1 = new LlockhamIndustries.Decals.Projection();
        }
        public override UnityEngine.Material get_MobileForward()
        {
            return this.MaterialFromShader(p_Shader:  UnityEngine.Shader.Find(name:  0));
        }
        public override UnityEngine.Material get_StandardForward()
        {
            return this.MaterialFromShader(p_Shader:  UnityEngine.Shader.Find(name:  0));
        }
        public override UnityEngine.Material get_PackedForward()
        {
            return this.MaterialFromShader(p_Shader:  UnityEngine.Shader.Find(name:  0));
        }
    
    }

}
