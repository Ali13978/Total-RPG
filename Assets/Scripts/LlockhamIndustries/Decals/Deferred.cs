using UnityEngine;

namespace LlockhamIndustries.Decals
{
    [Serializable]
    public abstract class Deferred : Projection
    {
        // Properties
        public override LlockhamIndustries.Decals.RenderingPaths SupportedRendering { get; }
        
        // Methods
        protected Deferred()
        {
        
        }
        public override LlockhamIndustries.Decals.RenderingPaths get_SupportedRendering()
        {
            return 2;
        }
    
    }

}
