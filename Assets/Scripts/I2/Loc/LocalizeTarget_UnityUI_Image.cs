using UnityEngine;

namespace I2.Loc
{
    public class LocalizeTarget_UnityUI_Image : LocalizeTarget<UnityEngine.UI.Image>
    {
        // Methods
        private static LocalizeTarget_UnityUI_Image()
        {
            I2.Loc.LocalizeTarget_UnityUI_Image.AutoRegister();
        }
        public LocalizeTarget_UnityUI_Image()
        {
        
        }
        [UnityEngine.RuntimeInitializeOnLoadMethodAttribute]
        private static void AutoRegister()
        {
            I2.Loc.LocalizeTargetDesc_Type<UnityEngine.UI.Image, I2.Loc.LocalizeTarget_UnityUI_Image> val_1 = new I2.Loc.LocalizeTargetDesc_Type<UnityEngine.UI.Image, I2.Loc.LocalizeTarget_UnityUI_Image>();
            if(null != 0)
            {
                    typeof(I2.Loc.LocalizeTargetDesc_Type<T, G>).__il2cppRuntimeField_10 = "Image";
            }
            else
            {
                    mem[16] = "Image";
            }
            
            typeof(I2.Loc.LocalizeTargetDesc_Type<T, G>).__il2cppRuntimeField_18 = 100;
            I2.Loc.LocalizationManager.RegisterTarget(desc:  null);
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
        public override I2.Loc.eTermType GetPrimaryTermType(I2.Loc.Localize cmp)
        {
            return (I2.Loc.eTermType)(0 != this.sprite) ? 2 : 5;
        }
        public override I2.Loc.eTermType GetSecondaryTermType(I2.Loc.Localize cmp)
        {
            return 0;
        }
        public override void GetFinalTerms(I2.Loc.Localize cmp, string Main, string Secondary, out string primaryTerm, out string secondaryTerm)
        {
            var val_12;
            string val_13;
            var val_14;
            string val_15;
            var val_16;
            val_12 = this;
            val_13 = 1152921504721543168;
            bool val_1 = UnityEngine.Object.op_Implicit(exists:  0);
            var val_2 = (val_1 != true) ? 0 : 1152921512311182688;
            if(val_1 != false)
            {
                    string val_3 = val_2.name;
                val_14 = 1152921512311182688;
            }
            else
            {
                    val_16 = null;
                val_16 = null;
                val_15 = System.String.Empty;
            }
            
            mem2[0] = val_15;
            UnityEngine.Sprite val_4 = val_2.sprite;
            if(0 != val_4)
            {
                    val_13 = val_4.sprite.name;
                if((System.String.op_Inequality(a:  0, b:  val_13)) != false)
            {
                    val_12 = this.sprite.name;
                primaryTerm = 0 + primaryTerm + ".";
            }
            
            }
            
            secondaryTerm = 0;
        }
        public override void DoLocalize(I2.Loc.Localize cmp, string mainTranslation, string secondaryTranslation)
        {
            UnityEngine.Sprite val_1 = sprite;
            if(0 != val_1)
            {
                    if((System.String.op_Inequality(a:  0, b:  val_1.name)) == false)
            {
                    return;
            }
            
            }
            
            this.sprite = cmp.FindTranslatedObject<UnityEngine.Sprite>(value:  mainTranslation);
        }
    
    }

}
