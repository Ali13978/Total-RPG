using UnityEngine;

namespace I2.Loc
{
    public class LocalizeTarget_UnityUI_RawImage : LocalizeTarget<UnityEngine.UI.RawImage>
    {
        // Methods
        private static LocalizeTarget_UnityUI_RawImage()
        {
            I2.Loc.LocalizeTarget_UnityUI_RawImage.AutoRegister();
        }
        public LocalizeTarget_UnityUI_RawImage()
        {
        
        }
        [UnityEngine.RuntimeInitializeOnLoadMethodAttribute]
        private static void AutoRegister()
        {
            I2.Loc.LocalizeTargetDesc_Type<UnityEngine.UI.RawImage, I2.Loc.LocalizeTarget_UnityUI_RawImage> val_1 = new I2.Loc.LocalizeTargetDesc_Type<UnityEngine.UI.RawImage, I2.Loc.LocalizeTarget_UnityUI_RawImage>();
            if(null != 0)
            {
                    typeof(I2.Loc.LocalizeTargetDesc_Type<T, G>).__il2cppRuntimeField_10 = "RawImage";
            }
            else
            {
                    mem[16] = "RawImage";
            }
            
            typeof(I2.Loc.LocalizeTargetDesc_Type<T, G>).__il2cppRuntimeField_18 = 100;
            I2.Loc.LocalizationManager.RegisterTarget(desc:  null);
        }
        public override I2.Loc.eTermType GetPrimaryTermType(I2.Loc.Localize cmp)
        {
            return 2;
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
            var val_4;
            var val_5;
            string val_6;
            var val_7;
            val_4 = 1152921512312443904;
            val_5 = this;
            bool val_1 = UnityEngine.Object.op_Implicit(exists:  0);
            if(val_1 != false)
            {
                    val_5 = val_5;
                string val_3 = this.name;
            }
            else
            {
                    val_7 = null;
                val_7 = null;
                val_4 = (val_1 != true) ? 0 : (val_4);
                val_6 = System.String.Empty;
            }
            
            mem2[0] = val_6;
            secondaryTerm = 0;
        }
        public override void DoLocalize(I2.Loc.Localize cmp, string mainTranslation, string secondaryTranslation)
        {
            UnityEngine.Texture val_1 = texture;
            if(0 != val_1)
            {
                    if((System.String.op_Inequality(a:  0, b:  val_1.name)) == false)
            {
                    return;
            }
            
            }
            
            this.texture = cmp.FindTranslatedObject<UnityEngine.Texture>(value:  mainTranslation);
        }
    
    }

}
