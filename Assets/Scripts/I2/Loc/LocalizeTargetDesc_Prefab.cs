using UnityEngine;

namespace I2.Loc
{
    public class LocalizeTargetDesc_Prefab : LocalizeTargetDesc<I2.Loc.LocalizeTarget_UnityStandard_Prefab>
    {
        // Methods
        public LocalizeTargetDesc_Prefab()
        {
        
        }
        public override bool CanLocalize(I2.Loc.Localize cmp)
        {
            return true;
        }
    
    }

}
