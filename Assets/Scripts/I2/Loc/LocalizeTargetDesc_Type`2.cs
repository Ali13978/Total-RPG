using UnityEngine;

namespace I2.Loc
{
    public class LocalizeTargetDesc_Type<T, G> : LocalizeTargetDesc<G>
    {
        // Methods
        public LocalizeTargetDesc_Type<T, G>()
        {
            if(this == null)
            {
                
            }
        
        }
        public override bool CanLocalize(I2.Loc.Localize cmp)
        {
            return UnityEngine.Object.op_Inequality(x:  0, y:  cmp);
        }
        public override I2.Loc.ILocalizeTarget CreateTarget(I2.Loc.Localize cmp)
        {
            if(0 == cmp)
            {
                    return (I2.Loc.ILocalizeTarget)0;
            }
            
            0 = 0;
            mem[24] = cmp;
            return (I2.Loc.ILocalizeTarget)0;
        }
    
    }

}
