using UnityEngine;

namespace LlockhamIndustries.Decals
{
    public class SceneLayers : MonoBehaviour
    {
        // Fields
        public LlockhamIndustries.Decals.ProjectionLayer[] layers;
        private LlockhamIndustries.Decals.ProjectionLayer[] original;
        
        // Methods
        public SceneLayers()
        {
        
        }
        private void OnEnable()
        {
            LlockhamIndustries.Decals.DynamicDecalSettings val_2 = LlockhamIndustries.Decals.DynamicDecals.System.Settings;
            this.original = val_2.layers;
            if(val_4.layers == this.layers)
            {
                    return;
            }
            
            val_4.layers = this.layers;
            LlockhamIndustries.Decals.DynamicDecals.System.Settings.CalculatePasses();
        }
        private void OnDisable()
        {
            if(val_2.layers == this.original)
            {
                    return;
            }
            
            val_2.layers = this.original;
            LlockhamIndustries.Decals.DynamicDecals.System.Settings.CalculatePasses();
        }
    
    }

}
