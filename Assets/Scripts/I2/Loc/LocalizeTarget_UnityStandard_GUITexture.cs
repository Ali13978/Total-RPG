using UnityEngine;

namespace I2.Loc
{
    public class LocalizeTarget_UnityStandard_GUITexture : LocalizeTarget<UnityEngine.GUITexture>
    {
        // Methods
        private static LocalizeTarget_UnityStandard_GUITexture()
        {
            I2.Loc.LocalizeTarget_UnityStandard_GUITexture.AutoRegister();
        }
        public LocalizeTarget_UnityStandard_GUITexture()
        {
        
        }
        [UnityEngine.RuntimeInitializeOnLoadMethodAttribute]
        private static void AutoRegister()
        {
            I2.Loc.LocalizeTargetDesc_Type<UnityEngine.GUITexture, I2.Loc.LocalizeTarget_UnityStandard_GUITexture> val_1 = new I2.Loc.LocalizeTargetDesc_Type<UnityEngine.GUITexture, I2.Loc.LocalizeTarget_UnityStandard_GUITexture>();
            if(null != 0)
            {
                    typeof(I2.Loc.LocalizeTargetDesc_Type<T, G>).__il2cppRuntimeField_10 = "GUITexture";
            }
            else
            {
                    mem[16] = "GUITexture";
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
            var val_6;
            var val_7;
            string val_8;
            var val_9;
            val_6 = 1152921512305565008;
            val_7 = this;
            UnityEngine.Texture val_1 = texture;
            bool val_2 = UnityEngine.Object.op_Implicit(exists:  0);
            if(val_2 != false)
            {
                    val_7 = this.texture;
                string val_5 = val_7.name;
            }
            else
            {
                    val_9 = null;
                val_9 = null;
                val_6 = (val_2 != true) ? 0 : (val_6);
                val_8 = System.String.Empty;
            }
            
            mem2[0] = val_8;
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
