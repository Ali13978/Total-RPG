using UnityEngine;

namespace I2.Loc
{
    public abstract class ILocalizeTargetDescriptor
    {
        // Fields
        public string Name;
        public int Priority;
        
        // Methods
        protected ILocalizeTargetDescriptor()
        {
        
        }
        public abstract bool CanLocalize(I2.Loc.Localize cmp); // 0
        public abstract I2.Loc.ILocalizeTarget CreateTarget(I2.Loc.Localize cmp); // 0
        public abstract System.Type GetTargetType(); // 0
    
    }

}
