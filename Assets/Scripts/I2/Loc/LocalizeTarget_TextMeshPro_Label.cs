using UnityEngine;

namespace I2.Loc
{
    public class LocalizeTarget_TextMeshPro_Label : LocalizeTarget<TMPro.TextMeshPro>
    {
        // Fields
        private TMPro.TextAlignmentOptions mAlignment_RTL;
        private TMPro.TextAlignmentOptions mAlignment_LTR;
        private bool mAlignmentWasRTL;
        private bool mInitializeAlignment;
        
        // Methods
        private static LocalizeTarget_TextMeshPro_Label()
        {
            I2.Loc.LocalizeTarget_TextMeshPro_Label.AutoRegister();
        }
        public LocalizeTarget_TextMeshPro_Label()
        {
            this.mInitializeAlignment = true;
            this.mAlignment_RTL = 516;
            this.mAlignment_LTR = 513;
        }
        [UnityEngine.RuntimeInitializeOnLoadMethodAttribute]
        private static void AutoRegister()
        {
            I2.Loc.LocalizeTargetDesc_Type<TMPro.TextMeshPro, I2.Loc.LocalizeTarget_TextMeshPro_Label> val_1 = new I2.Loc.LocalizeTargetDesc_Type<TMPro.TextMeshPro, I2.Loc.LocalizeTarget_TextMeshPro_Label>();
            if(null != 0)
            {
                    typeof(I2.Loc.LocalizeTargetDesc_Type<T, G>).__il2cppRuntimeField_10 = "TextMeshPro Label";
            }
            else
            {
                    mem[16] = "TextMeshPro Label";
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
            var val_8;
            var val_9;
            string val_10;
            var val_11;
            val_8 = 1152921512298093088;
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
        internal static TMPro.TMP_FontAsset GetTMPFontFromMaterial(I2.Loc.Localize cmp, string matName)
        {
            UnityEngine.Object val_13;
            int val_14;
            val_13 = 0;
            val_14 = X2.Length - 1;
            if(val_14 < 1)
            {
                    return (TMPro.TMP_FontAsset)val_13;
            }
            
            label_19:
            if(((IndexOf(value:  X2.Chars[val_14])) & 2147483648) != 0)
            {
                goto label_5;
            }
            
            int val_4 = val_14 - 1;
            if(val_14 >= 2)
            {
                goto label_19;
            }
            
            goto label_14;
            label_5:
            if(val_14 < 1)
            {
                goto label_14;
            }
            
            val_13 = matName.GetObject<TMPro.TMP_FontAsset>(Translation:  X2.Substring(startIndex:  0, length:  val_14 + 1));
            if(0 != val_13)
            {
                    return (TMPro.TMP_FontAsset)val_13;
            }
            
            if(val_14 < 1)
            {
                goto label_14;
            }
            
            label_18:
            if(((IndexOf(value:  X2.Chars[val_14])) & 2147483648) == 0)
            {
                goto label_17;
            }
            
            val_14 = val_14 - 1;
            if(val_14 > 1)
            {
                goto label_18;
            }
            
            label_17:
            if(val_14 >= 1)
            {
                goto label_19;
            }
            
            label_14:
            val_13 = 0;
            return (TMPro.TMP_FontAsset)val_13;
        }
        internal static void InitAlignment_TMPro(bool isRTL, TMPro.TextAlignmentOptions alignment, out TMPro.TextAlignmentOptions alignLTR, out TMPro.TextAlignmentOptions alignRTL)
        {
            var val_1;
            mem2[0] = alignLTR;
            alignRTL = alignLTR;
            if((alignment & 1) == 0)
            {
                goto label_0;
            }
            
            if(1152921512298648911 > 3)
            {
                goto label_1;
            }
            
            if(mem[728247308] > 6)
            {
                    return;
            }
            
            var val_1 = 25810560 + (mem[728247308]) << 2;
            val_1 = val_1 + 25810560;
            goto (25810560 + (mem[728247308]) << 2 + 25810560);
            label_1:
            if(1152921512298648655 > 3)
            {
                goto label_5;
            }
            
            if(mem[728246300] > 8)
            {
                goto label_4;
            }
            
            if(mem[728246300] == 0)
            {
                goto label_5;
            }
            
            if(mem[728246300] != 8)
            {
                    return;
            }
            
            alignRTL = 516;
            return;
            label_0:
            if(1152921512298648911 > 3)
            {
                goto label_9;
            }
            
            if(mem[728247404] > 29)
            {
                goto label_8;
            }
            
            if(mem[728247404] == 0)
            {
                goto label_9;
            }
            
            if(mem[728247404] != 29)
            {
                    return;
            }
            
            val_1 = 260;
            goto label_73;
            label_8:
            if(mem[728247404] == 31)
            {
                goto label_12;
            }
            
            if(mem[728247404] != 30)
            {
                    return;
            }
            
            label_9:
            if(1152921512298648655 > 3)
            {
                goto label_16;
            }
            
            if(mem[728246396] > 33)
            {
                goto label_15;
            }
            
            if(mem[728246396] == 0)
            {
                goto label_16;
            }
            
            if(mem[728246396] != 33)
            {
                    return;
            }
            
            val_1 = 516;
            goto label_73;
            label_4:
            if(mem[728246300] == 10)
            {
                goto label_19;
            }
            
            if(mem[728246300] != 9)
            {
                    return;
            }
            
            label_5:
            if(1152921512298648143 > 3)
            {
                goto label_23;
            }
            
            if(mem[728244268] > 12)
            {
                goto label_22;
            }
            
            if(mem[728244268] == 0)
            {
                goto label_23;
            }
            
            if(mem[728244268] != 12)
            {
                    return;
            }
            
            alignRTL = 1028;
            return;
            label_15:
            if(mem[728246396] == 35)
            {
                goto label_25;
            }
            
            if(mem[728246396] != 34)
            {
                    return;
            }
            
            label_16:
            if(1152921512298648143 > 3)
            {
                goto label_29;
            }
            
            if(mem[728244364] > 37)
            {
                goto label_28;
            }
            
            if(mem[728244364] == 0)
            {
                goto label_29;
            }
            
            if(mem[728244364] != 37)
            {
                    return;
            }
            
            val_1 = 1028;
            goto label_73;
            label_22:
            if(mem[728244268] == 14)
            {
                goto label_32;
            }
            
            if(mem[728244268] != 13)
            {
                    return;
            }
            
            label_23:
            if(1152921512298647119 > 3)
            {
                goto label_36;
            }
            
            if(mem[728240188] > 16)
            {
                goto label_35;
            }
            
            if(mem[728240188] == 0)
            {
                goto label_36;
            }
            
            if(mem[728240188] != 16)
            {
                    return;
            }
            
            alignRTL = 2052;
            return;
            label_28:
            if(mem[728244364] == 39)
            {
                goto label_38;
            }
            
            if(mem[728244364] != 38)
            {
                    return;
            }
            
            label_29:
            if(1152921512298647119 > 3)
            {
                goto label_42;
            }
            
            if(mem[728240284] > 41)
            {
                goto label_41;
            }
            
            if(mem[728240284] == 0)
            {
                goto label_42;
            }
            
            if(mem[728240284] != 41)
            {
                    return;
            }
            
            val_1 = 2052;
            goto label_73;
            label_12:
            val_1 = 257;
            goto label_73;
            label_35:
            if(mem[728240188] == 18)
            {
                goto label_46;
            }
            
            if(mem[728240188] != 17)
            {
                    return;
            }
            
            label_36:
            if(1152921512298645071 > 3)
            {
                goto label_50;
            }
            
            if(mem[728232012] > 20)
            {
                goto label_49;
            }
            
            if(mem[728232012] == 0)
            {
                goto label_50;
            }
            
            if(mem[728232012] != 20)
            {
                    return;
            }
            
            alignRTL = 4100;
            return;
            label_41:
            if(mem[728240284] == 43)
            {
                goto label_52;
            }
            
            if(mem[728240284] != 42)
            {
                    return;
            }
            
            label_42:
            if(1152921512298645071 > 3)
            {
                goto label_56;
            }
            
            if(mem[728232108] > 45)
            {
                goto label_55;
            }
            
            if(mem[728232108] == 0)
            {
                goto label_56;
            }
            
            if(mem[728232108] != 45)
            {
                    return;
            }
            
            val_1 = 4100;
            goto label_73;
            label_19:
            alignRTL = 513;
            return;
            label_25:
            val_1 = 513;
            goto label_73;
            label_49:
            if(mem[728232012] == 22)
            {
                goto label_60;
            }
            
            if(mem[728232012] != 21)
            {
                    return;
            }
            
            label_50:
            if(1152921512298640975 > 3)
            {
                    return;
            }
            
            if(mem[728215644] == 24)
            {
                goto label_63;
            }
            
            if(mem[728215644] != 26)
            {
                    return;
            }
            
            alignRTL = 8193;
            return;
            label_55:
            if(mem[728232108] == 47)
            {
                goto label_65;
            }
            
            if(mem[728232108] != 46)
            {
                    return;
            }
            
            label_56:
            if(1152921512298640975 > 3)
            {
                    return;
            }
            
            if(mem[728215740] == 49)
            {
                goto label_68;
            }
            
            if(mem[728215740] != 50)
            {
                    return;
            }
            
            val_1 = 8193;
            goto label_73;
            label_32:
            alignRTL = 1025;
            return;
            label_38:
            val_1 = 1025;
            goto label_73;
            label_46:
            alignRTL = 2049;
            return;
            label_52:
            val_1 = 2049;
            goto label_73;
            label_63:
            alignRTL = 8196;
            return;
            label_68:
            val_1 = 8196;
            goto label_73;
            label_60:
            alignRTL = 4097;
            return;
            label_65:
            val_1 = 4097;
            label_73:
            mem2[0] = 4097;
        }
        internal static void SetFont(TMPro.TMP_Text label, TMPro.TMP_FontAsset newFont)
        {
            goto label_13;
            label_14:
            label_13:
            if(0 != newFont.font)
            {
                    newFont.font = X2;
            }
            
            if(0 == newFont.linkedTextComponent)
            {
                    return;
            }
            
            TMPro.TMP_Text val_5 = newFont.linkedTextComponent;
            goto label_14;
        }
        internal static void SetMaterial(TMPro.TMP_Text label, UnityEngine.Material newMat)
        {
            goto label_13;
            label_14:
            label_13:
            bool val_1 = UnityEngine.Object.op_Inequality(x:  0, y:  newMat);
            if(0 == newMat.linkedTextComponent)
            {
                    return;
            }
            
            TMPro.TMP_Text val_4 = newMat.linkedTextComponent;
            goto label_14;
        }
    
    }

}
