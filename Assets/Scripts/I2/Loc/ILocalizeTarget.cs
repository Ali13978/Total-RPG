using UnityEngine;

namespace I2.Loc
{
    public abstract class ILocalizeTarget : ScriptableObject
    {
        // Methods
        protected ILocalizeTarget()
        {
        
        }
        public abstract bool IsValid(I2.Loc.Localize cmp); // 0
        public abstract void GetFinalTerms(I2.Loc.Localize cmp, string Main, string Secondary, out string primaryTerm, out string secondaryTerm); // 0
        public abstract void DoLocalize(I2.Loc.Localize cmp, string mainTranslation, string secondaryTranslation); // 0
        public abstract bool CanUseSecondaryTerm(); // 0
        public abstract bool AllowMainTermToBeRTL(); // 0
        public abstract bool AllowSecondTermToBeRTL(); // 0
        public abstract I2.Loc.eTermType GetPrimaryTermType(I2.Loc.Localize cmp); // 0
        public abstract I2.Loc.eTermType GetSecondaryTermType(I2.Loc.Localize cmp); // 0
    
    }

}
