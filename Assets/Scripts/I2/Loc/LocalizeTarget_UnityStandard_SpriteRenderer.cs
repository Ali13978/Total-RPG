using UnityEngine;

namespace I2.Loc
{
    public class LocalizeTarget_UnityStandard_SpriteRenderer : LocalizeTarget<UnityEngine.SpriteRenderer>
    {
        // Methods
        private static LocalizeTarget_UnityStandard_SpriteRenderer()
        {
            I2.Loc.LocalizeTarget_UnityStandard_SpriteRenderer.AutoRegister();
        }
        public LocalizeTarget_UnityStandard_SpriteRenderer()
        {
        
        }
        [UnityEngine.RuntimeInitializeOnLoadMethodAttribute]
        private static void AutoRegister()
        {
            I2.Loc.LocalizeTargetDesc_Type<UnityEngine.SpriteRenderer, I2.Loc.LocalizeTarget_UnityStandard_SpriteRenderer> val_1 = new I2.Loc.LocalizeTargetDesc_Type<UnityEngine.SpriteRenderer, I2.Loc.LocalizeTarget_UnityStandard_SpriteRenderer>();
            if(null != 0)
            {
                    typeof(I2.Loc.LocalizeTargetDesc_Type<T, G>).__il2cppRuntimeField_10 = "SpriteRenderer";
            }
            else
            {
                    mem[16] = "SpriteRenderer";
            }
            
            typeof(I2.Loc.LocalizeTargetDesc_Type<T, G>).__il2cppRuntimeField_18 = 100;
            I2.Loc.LocalizationManager.RegisterTarget(desc:  null);
        }
        public override I2.Loc.eTermType GetPrimaryTermType(I2.Loc.Localize cmp)
        {
            return 5;
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
            val_6 = 1152921512308601984;
            val_7 = this;
            bool val_2 = UnityEngine.Object.op_Inequality(x:  0, y:  sprite);
            if(val_2 != false)
            {
                    val_7 = this.sprite;
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
