using UnityEngine;

namespace I2.Loc
{
    public abstract class LocalizeTarget<T> : ILocalizeTarget
    {
        // Fields
        public T mTarget;
        
        // Methods
        protected LocalizeTarget<T>()
        {
            if(this != null)
            {
                    return;
            }
        
        }
        public override bool IsValid(I2.Loc.Localize cmp)
        {
            I2.Loc.Localize val_8;
            bool val_1 = UnityEngine.Object.op_Inequality(x:  0, y:  34816000);
            if((val_1 != false) && (0 != val_1))
            {
                    UnityEngine.GameObject val_3 = val_1.gameObject;
                UnityEngine.GameObject val_4 = cmp.gameObject;
                if(0 != val_3)
            {
                    mem[1152921512296160600] = 0;
            }
            
            }
            
            if(0 == val_3)
            {
                    val_8 = cmp;
                mem[1152921512296160600] = val_8;
                return UnityEngine.Object.op_Inequality(x:  0, y:  cmp);
            }
            
            return UnityEngine.Object.op_Inequality(x:  0, y:  cmp);
        }
    
    }

}
