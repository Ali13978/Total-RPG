using UnityEngine;

namespace I2.Loc
{
    public class LocalizeTarget_TextMeshPro_UGUI : LocalizeTarget<TMPro.TextMeshProUGUI>
    {
        // Fields
        public TMPro.TextAlignmentOptions mAlignment_RTL;
        public TMPro.TextAlignmentOptions mAlignment_LTR;
        public bool mAlignmentWasRTL;
        public bool mInitializeAlignment;
        
        // Methods
        private static LocalizeTarget_TextMeshPro_UGUI()
        {
            I2.Loc.LocalizeTarget_TextMeshPro_UGUI.AutoRegister();
        }
        public LocalizeTarget_TextMeshPro_UGUI()
        {
            this.mInitializeAlignment = true;
            this.mAlignment_RTL = 516;
            this.mAlignment_LTR = 513;
        }
        [UnityEngine.RuntimeInitializeOnLoadMethodAttribute]
        private static void AutoRegister()
        {
            I2.Loc.LocalizeTargetDesc_Type<TMPro.TextMeshProUGUI, I2.Loc.LocalizeTarget_TextMeshPro_UGUI> val_1 = new I2.Loc.LocalizeTargetDesc_Type<TMPro.TextMeshProUGUI, I2.Loc.LocalizeTarget_TextMeshPro_UGUI>();
            if(null != 0)
            {
                    typeof(I2.Loc.LocalizeTargetDesc_Type<T, G>).__il2cppRuntimeField_10 = "TextMeshPro UGUI";
            }
            else
            {
                    mem[16] = "TextMeshPro UGUI";
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
            return 8;
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
            var val_8;
            var val_9;
            string val_10;
            var val_11;
            val_8 = 1152921512300034608;
            val_9 = 0;
            primaryTerm = text;
            bool val_4 = UnityEngine.Object.op_Inequality(x:  0, y:  primaryTerm.font);
            if(val_4 != false)
            {
                    string val_7 = this.font.name;
            }
            else
            {
                    val_11 = null;
                val_11 = null;
                val_8 = (val_4 != true) ? 0 : (val_8);
                val_10 = System.String.Empty;
            }
            
            mem2[0] = val_10;
        }
        public override void DoLocalize(I2.Loc.Localize cmp, string mainTranslation, string secondaryTranslation)
        {
            var val_33;
            string val_34;
            var val_35;
            var val_36;
            var val_37;
            TMPro.TextAlignmentOptions val_38;
            var val_39;
            TMPro.TextAlignmentOptions val_40;
            var val_41;
            TMPro.TextAlignmentOptions val_42;
            TMPro.TextAlignmentOptions val_43;
            var val_44;
            var val_45;
            var val_46;
            val_33 = this;
            string val_2 = secondaryTranslation;
            string val_1 = mainTranslation;
            TMPro.TextAlignmentOptions val_27 = 0;
            if(0 != (cmp.GetSecondaryTranslatedObj<TMPro.TMP_FontAsset>(mainTranslation: ref  val_1, secondaryTranslation: ref  val_2)))
            {
                    I2.Loc.LocalizeTarget_TextMeshPro_Label.SetFont(label:  null, newFont:  X22);
            }
            else
            {
                    UnityEngine.Material val_5 = cmp.GetSecondaryTranslatedObj<UnityEngine.Material>(mainTranslation: ref  val_1, secondaryTranslation: ref  val_2);
                if((0 != val_5) && (0 != X22.fontMaterial))
            {
                    val_34 = X23.font.name;
                if((val_5.name.StartsWith(value:  val_34, comparisonType:  4)) != true)
            {
                    bool val_15 = val_2.EndsWith(value:  val_5.name, comparisonType:  4);
                if(val_15 != false)
            {
                    val_34 = val_2;
                val_35 = cmp;
            }
            else
            {
                    val_34 = val_5.name;
            }
            
                TMPro.TMP_FontAsset val_18 = I2.Loc.LocalizeTarget_TextMeshPro_Label.GetTMPFontFromMaterial(cmp:  null, matName:  (val_15 != true) ? 0 : cmp);
                if(0 != val_18)
            {
                    I2.Loc.LocalizeTarget_TextMeshPro_Label.SetFont(label:  null, newFont:  val_34);
            }
            
            }
            
                I2.Loc.LocalizeTarget_TextMeshPro_Label.SetMaterial(label:  null, newMat:  val_18);
            }
            
            }
            
            if(this.mInitializeAlignment == false)
            {
                goto label_35;
            }
            
            this.mInitializeAlignment = false;
            val_36 = null;
            val_36 = null;
            this.mAlignmentWasRTL = I2.Loc.LocalizationManager.IsRight2Left;
            val_34 = alignment;
            val_38 = this.mAlignment_RTL;
            val_37 = null;
            I2.Loc.LocalizeTarget_TextMeshPro_Label.InitAlignment_TMPro(isRTL:  false, alignment:  (I2.Loc.LocalizationManager.IsRight2Left == true) ? 1 : 0, alignLTR: out  val_34, alignRTL: out  this.mAlignment_LTR);
            goto label_41;
            label_35:
            val_39 = null;
            I2.Loc.LocalizeTarget_TextMeshPro_Label.InitAlignment_TMPro(isRTL:  false, alignment:  (this.mAlignmentWasRTL == true) ? 1 : 0, alignLTR: out  val_5.alignment, alignRTL: out  val_27);
            if(this.mAlignmentWasRTL == false)
            {
                goto label_45;
            }
            
            val_40 = val_33;
            val_41 = 0;
            if(this.mAlignment_RTL == val_41)
            {
                goto label_48;
            }
            
            val_42 = val_27;
            val_43 = this.mAlignment_LTR;
            goto label_47;
            label_45:
            val_43 = val_33;
            val_42 = val_27;
            if(this.mAlignment_LTR == val_42)
            {
                goto label_48;
            }
            
            val_41 = 0;
            val_40 = this.mAlignment_RTL;
            label_47:
            this.mAlignment_LTR = val_42;
            mem2[0] = val_41;
            label_48:
            val_38 = 1152921504966909952;
            val_44 = null;
            val_44 = null;
            this.mAlignmentWasRTL = I2.Loc.LocalizationManager.IsRight2Left;
            label_41:
            if(val_1 == 0)
            {
                    return;
            }
            
            val_38 = val_1;
            if((System.String.op_Inequality(a:  0, b:  text)) == false)
            {
                    return;
            }
            
            if((val_1 != 0) && (cmp.CorrectAlignmentForRTL != false))
            {
                    val_45 = null;
                val_45 = null;
                cmp.alignment = (I2.Loc.LocalizationManager.IsRight2Left == false) ? this.mAlignment_LTR : this.mAlignment_RTL;
                val_46 = null;
                val_46 = null;
                val_38 = I2.Loc.LocalizationManager.IsRight2Left;
                cmp.isRightToLeftText = (val_38 == true) ? 1 : 0;
            }
            
            this.text = I2.Loc.I2Utils.ReverseText(source:  cmp);
        }
    
    }

}
