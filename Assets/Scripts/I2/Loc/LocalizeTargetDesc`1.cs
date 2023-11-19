using UnityEngine;

namespace I2.Loc
{
    public abstract class LocalizeTargetDesc<T> : ILocalizeTargetDescriptor
    {
        // Methods
        protected LocalizeTargetDesc<T>()
        {
            if(this != null)
            {
                    return;
            }
        
        }
        public override I2.Loc.ILocalizeTarget CreateTarget(I2.Loc.Localize cmp)
        {
            goto __RuntimeMethodHiddenParam + 24 + 168;
        }
        public override System.Type GetTargetType()
        {
            return System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle());
        }
    
    }

}
