using UnityEngine;

namespace I2.Loc
{
    public class LocalizeTargetDesc_Child : LocalizeTargetDesc<I2.Loc.LocalizeTarget_UnityStandard_Child>
    {
        // Methods
        public LocalizeTargetDesc_Child()
        {
        
        }
        public override bool CanLocalize(I2.Loc.Localize cmp)
        {
            return (bool)(cmp.transform.childCount > 1) ? 1 : 0;
        }
    
    }

}
