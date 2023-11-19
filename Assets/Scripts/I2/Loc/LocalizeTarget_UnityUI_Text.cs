using UnityEngine;

namespace I2.Loc
{
    public class LocalizeTarget_UnityUI_Text : LocalizeTarget<UnityEngine.UI.Text>
    {
        // Fields
        private UnityEngine.TextAnchor mAlignment_RTL;
        private UnityEngine.TextAnchor mAlignment_LTR;
        private bool mAlignmentWasRTL;
        private bool mInitializeAlignment;
        
        // Methods
        private static LocalizeTarget_UnityUI_Text()
        {
            I2.Loc.LocalizeTarget_UnityUI_Text.AutoRegister();
        }
        public LocalizeTarget_UnityUI_Text()
        {
            this.mInitializeAlignment = true;
            this.mAlignment_RTL = 2;
        }
        [UnityEngine.RuntimeInitializeOnLoadMethodAttribute]
        private static void AutoRegister()
        {
            I2.Loc.LocalizeTargetDesc_Type<UnityEngine.UI.Text, I2.Loc.LocalizeTarget_UnityUI_Text> val_1 = new I2.Loc.LocalizeTargetDesc_Type<UnityEngine.UI.Text, I2.Loc.LocalizeTarget_UnityUI_Text>();
            if(null != 0)
            {
                    typeof(I2.Loc.LocalizeTargetDesc_Type<T, G>).__il2cppRuntimeField_10 = "Text";
            }
            else
            {
                    mem[16] = "Text";
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
            var val_7;
            string val_8;
            string val_9;
            var val_10;
            val_7 = 1152921512313692688;
            val_8 = 0;
            if((UnityEngine.Object.op_Implicit(exists:  0)) != false)
            {
                    val_8 = 34807808;
            }
            
            primaryTerm = val_8;
            bool val_3 = UnityEngine.Object.op_Inequality(x:  0, y:  primaryTerm.font);
            if(val_3 != false)
            {
                    string val_6 = this.font.name;
            }
            else
            {
                    val_10 = null;
                val_10 = null;
                val_7 = (val_3 != true) ? 0 : (val_7);
                val_9 = System.String.Empty;
            }
            
            mem2[0] = val_9;
        }
        public override void DoLocalize(I2.Loc.Localize cmp, string mainTranslation, string secondaryTranslation)
        {
            var val_17;
            var val_18;
            string val_19;
            UnityEngine.TextAnchor val_20;
            var val_21;
            UnityEngine.TextAnchor val_22;
            UnityEngine.TextAnchor val_23;
            var val_24;
            var val_25;
            val_17 = this;
            string val_1 = mainTranslation;
            UnityEngine.TextAnchor val_13 = 0;
            UnityEngine.TextAnchor val_14 = 0;
            UnityEngine.Font val_3 = cmp.GetSecondaryTranslatedObj<UnityEngine.Font>(mainTranslation: ref  val_1, secondaryTranslation: ref  secondaryTranslation);
            if(0 != val_3)
            {
                    if(0 != val_3)
            {
                    X22.font.font = val_3;
            }
            
            }
            
            if(this.mInitializeAlignment == false)
            {
                goto label_10;
            }
            
            this.mInitializeAlignment = false;
            val_18 = null;
            val_18 = null;
            this.mAlignmentWasRTL = I2.Loc.LocalizationManager.IsRight2Left;
            UnityEngine.TextAnchor val_8 = alignment;
            val_8.InitAlignment(isRTL:  (I2.Loc.LocalizationManager.IsRight2Left == true) ? 1 : 0, alignment:  val_8, alignLTR: out  this.mAlignment_LTR, alignRTL: out  this.mAlignment_RTL);
            goto label_14;
            label_10:
            UnityEngine.TextAnchor val_12 = val_3.alignment;
            val_12.InitAlignment(isRTL:  (this.mAlignmentWasRTL == true) ? 1 : 0, alignment:  val_12, alignLTR: out  val_13, alignRTL: out  val_14);
            if(this.mAlignmentWasRTL == false)
            {
                goto label_16;
            }
            
            val_20 = val_17;
            val_21 = val_14;
            if(this.mAlignment_RTL == val_21)
            {
                goto label_19;
            }
            
            val_22 = val_13;
            val_23 = this.mAlignment_LTR;
            goto label_18;
            label_16:
            val_23 = val_17;
            val_22 = val_13;
            if(this.mAlignment_LTR == val_22)
            {
                goto label_19;
            }
            
            val_21 = val_14;
            val_20 = this.mAlignment_RTL;
            label_18:
            this.mAlignment_LTR = val_22;
            mem2[0] = val_21;
            label_19:
            val_19 = 1152921504966909952;
            val_24 = null;
            val_24 = null;
            this.mAlignmentWasRTL = I2.Loc.LocalizationManager.IsRight2Left;
            label_14:
            if(val_1 == 0)
            {
                    return;
            }
            
            val_19 = val_1;
            if((System.String.op_Inequality(a:  0, b:  val_19)) == false)
            {
                    return;
            }
            
            if(cmp.CorrectAlignmentForRTL != false)
            {
                    val_25 = null;
                val_25 = null;
                cmp.alignment = (I2.Loc.LocalizationManager.IsRight2Left == false) ? this.mAlignment_LTR : this.mAlignment_RTL;
            }
            
            val_19 = val_1;
        }
        private void InitAlignment(bool isRTL, UnityEngine.TextAnchor alignment, out UnityEngine.TextAnchor alignLTR, out UnityEngine.TextAnchor alignRTL)
        {
            alignRTL = alignment;
            alignLTR = alignment;
            if(isRTL != false)
            {
                    if(alignment > 8)
            {
                    return;
            }
            
                var val_1 = 25810832 + (alignment) << 2;
                val_1 = val_1 - 4;
                if(val_1 > 6)
            {
                    return;
            }
            
                var val_2 = 25810612 + ((25810832 + (alignment) << 2 - 4)) << 2;
                val_2 = val_2 + 25810612;
            }
            else
            {
                    if(alignment > 8)
            {
                    return;
            }
            
                var val_3 = 25810880 + (alignment) << 2;
                val_3 = val_3 - 13;
                if(val_3 > 5)
            {
                    return;
            }
            
                var val_4 = 25810588 + ((25810880 + (alignment) << 2 - 13)) << 2;
                val_4 = val_4 + 25810588;
            }
        
        }
    
    }

}
