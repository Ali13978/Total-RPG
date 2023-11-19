using UnityEngine;

namespace LlockhamIndustries.Decals
{
    [Serializable]
    public class Unlit : Forward
    {
        // Properties
        public override UnityEngine.Material MobileForward { get; }
        public override UnityEngine.Material StandardForward { get; }
        public override UnityEngine.Material PackedForward { get; }
        
        // Methods
        public Unlit()
        {
        
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
