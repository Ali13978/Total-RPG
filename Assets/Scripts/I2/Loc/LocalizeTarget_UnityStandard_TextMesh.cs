using UnityEngine;

namespace I2.Loc
{
    public class LocalizeTarget_UnityStandard_TextMesh : LocalizeTarget<UnityEngine.TextMesh>
    {
        // Fields
        private UnityEngine.TextAlignment mAlignment_RTL;
        private UnityEngine.TextAlignment mAlignment_LTR;
        private bool mAlignmentWasRTL;
        private bool mInitializeAlignment;
        
        // Methods
        private static LocalizeTarget_UnityStandard_TextMesh()
        {
            I2.Loc.LocalizeTarget_UnityStandard_TextMesh.AutoRegister();
        }
        public LocalizeTarget_UnityStandard_TextMesh()
        {
            this.mInitializeAlignment = true;
            this.mAlignment_RTL = 2;
        }
        [UnityEngine.RuntimeInitializeOnLoadMethodAttribute]
        private static void AutoRegister()
        {
            I2.Loc.LocalizeTargetDesc_Type<UnityEngine.TextMesh, I2.Loc.LocalizeTarget_UnityStandard_TextMesh> val_1 = new I2.Loc.LocalizeTargetDesc_Type<UnityEngine.TextMesh, I2.Loc.LocalizeTarget_UnityStandard_TextMesh>();
            if(null != 0)
            {
                    typeof(I2.Loc.LocalizeTargetDesc_Type<T, G>).__il2cppRuntimeField_10 = "TextMesh";
            }
            else
            {
                    mem[16] = "TextMesh";
            }
            
            typeof(I2.Loc.LocalizeTargetDesc_Type<T, G>).__il2cppRuntimeField_18 = 100;
            I2.Loc.LocalizationManager.RegisterTarget(desc:  null);
        }
        public override I2.Loc.eTermType GetPrimaryTermType(I2.Loc.Localize cmp)
        {
            return 0;
        }
        public override I2.Loc.eTermType GetSecondaryTermType(I2.Loc.Localize cmp)
        {
            return 1;
        }
        public override bool CanUseSecondaryTerm()
        {
            return true;
        }
        public override bool AllowMainTermToBeRTL()
        {
            return true;
        }
        public override bool AllowSecondTermToBeRTL()
        {
            return false;
        }
        public override void GetFinalTerms(I2.Loc.Localize cmp, string Main, string Secondary, out string primaryTerm, out string secondaryTerm)
        {
            UnityEngine.Object val_8;
            var val_10;
            var val_11;
            val_8 = Secondary;
            val_10 = 0;
            primaryTerm = text;
            val_11 = 0;
            if((System.String.IsNullOrEmpty(value:  0)) != false)
            {
                    val_8 = val_8.font;
                val_11 = 0;
            }
            
            secondaryTerm = this.font.name;
        }
        public override void DoLocalize(I2.Loc.Localize cmp, string mainTranslation, string secondaryTranslation)
        {
            var val_13;
            UnityEngine.Object val_14;
            var val_15;
            var val_16;
            val_13 = this;
            string val_1 = mainTranslation;
            val_14 = cmp.GetSecondaryTranslatedObj<UnityEngine.Font>(mainTranslation: ref  val_1, secondaryTranslation: ref  secondaryTranslation);
            if(0 != val_14)
            {
                    UnityEngine.Font val_5 = X22.font;
                if(0 != val_5)
            {
                    val_5.font = val_14;
            }
            
            }
            
            if(this.mInitializeAlignment != false)
            {
                    this.mInitializeAlignment = false;
                UnityEngine.TextAlignment val_7 = val_14.alignment;
                this.mAlignment_RTL = val_7;
                this.mAlignment_LTR = val_7;
                val_14 = 1152921504966909952;
                val_15 = null;
                val_15 = null;
                if((I2.Loc.LocalizationManager.IsRight2Left != false) && (this.mAlignment_RTL == 2))
            {
                    this.mAlignment_LTR = 0;
                val_15 = null;
            }
            
                val_15 = null;
                if((I2.Loc.LocalizationManager.IsRight2Left != true) && (this.mAlignment_LTR == 0))
            {
                    this.mAlignment_RTL = 2;
            }
            
            }
            
            if(val_1 == 0)
            {
                    return;
            }
            
            val_14 = val_1;
            if((System.String.op_Inequality(a:  0, b:  text)) == false)
            {
                    return;
            }
            
            if(cmp.CorrectAlignmentForRTL != false)
            {
                    if(cmp.alignment != 1)
            {
                    val_16 = null;
                val_16 = null;
                cmp.alignment = (I2.Loc.LocalizationManager.IsRight2Left == false) ? this.mAlignment_LTR : this.mAlignment_RTL;
            }
            
            }
            
            val_14 = cmp.font;
            val_14.RequestCharactersInTexture(characters:  val_1);
            this.text = val_1;
        }
    
    }

}
