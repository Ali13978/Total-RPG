using UnityEngine;

namespace I2.Loc
{
    public class LocalizeTarget_UnityStandard_Child : LocalizeTarget<UnityEngine.GameObject>
    {
        // Methods
        private static LocalizeTarget_UnityStandard_Child()
        {
            I2.Loc.LocalizeTarget_UnityStandard_Child.AutoRegister();
        }
        public LocalizeTarget_UnityStandard_Child()
        {
        
        }
        [UnityEngine.RuntimeInitializeOnLoadMethodAttribute]
        private static void AutoRegister()
        {
            I2.Loc.LocalizeTargetDesc_Child val_1 = new I2.Loc.LocalizeTargetDesc_Child();
            if(null != 0)
            {
                    typeof(I2.Loc.LocalizeTargetDesc_Child).__il2cppRuntimeField_10 = "Child";
            }
            else
            {
                    mem[16] = "Child";
            }
            
            typeof(I2.Loc.LocalizeTargetDesc_Child).__il2cppRuntimeField_18 = 200;
            I2.Loc.LocalizationManager.RegisterTarget(desc:  null);
        }
        public override bool IsValid(I2.Loc.Localize cmp)
        {
            return (bool)(cmp.transform.childCount > 1) ? 1 : 0;
        }
        public override I2.Loc.eTermType GetPrimaryTermType(I2.Loc.Localize cmp)
        {
            return 4;
        }
        public override I2.Loc.eTermType GetSecondaryTermType(I2.Loc.Localize cmp)
        {
            return 0;
        }
        public override bool CanUseSecondaryTerm()
        {
            return false;
        }
        public override bool AllowMainTermToBeRTL()
        {
            return false;
        }
        public override bool AllowSecondTermToBeRTL()
        {
            return false;
        }
        public override void GetFinalTerms(I2.Loc.Localize cmp, string Main, string Secondary, out string primaryTerm, out string secondaryTerm)
        {
            primaryTerm = cmp.name;
            secondaryTerm = 0;
        }
        public override void DoLocalize(I2.Loc.Localize cmp, string mainTranslation, string secondaryTranslation)
        {
            var val_13;
            var val_14;
            var val_15;
            var val_16;
            val_14 = mainTranslation;
            if((System.String.IsNullOrEmpty(value:  0)) == true)
            {
                    return;
            }
            
            UnityEngine.Transform val_3 = cmp.transform;
            val_15 = null;
            val_15 = null;
            System.Char[] val_13 = I2.Loc.LanguageSource.CategorySeparators;
            int val_4 = val_14.LastIndexOfAny(anyOf:  val_13);
            if((val_4 & 2147483648) == 0)
            {
                    val_13 = val_4 + 1;
                val_14 = val_14.Substring(startIndex:  val_13);
            }
            
            val_13 = 0;
            goto label_10;
            label_19:
            X22.SetActive(value:  W23 & 1);
            val_13 = 1;
            label_10:
            if(val_13 >= val_3.childCount)
            {
                    return;
            }
            
            UnityEngine.Transform val_8 = val_3.GetChild(index:  1);
            if(val_8 != null)
            {
                    val_16 = val_8.gameObject;
            }
            else
            {
                    val_16 = 0.gameObject;
            }
            
            bool val_12 = System.String.op_Equality(a:  0, b:  val_8.name);
            if(val_16 != null)
            {
                goto label_19;
            }
            
            goto label_19;
        }
    
    }

}
