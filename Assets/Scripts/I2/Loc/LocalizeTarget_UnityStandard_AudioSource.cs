using UnityEngine;

namespace I2.Loc
{
    public class LocalizeTarget_UnityStandard_AudioSource : LocalizeTarget<UnityEngine.AudioSource>
    {
        // Methods
        private static LocalizeTarget_UnityStandard_AudioSource()
        {
            I2.Loc.LocalizeTarget_UnityStandard_AudioSource.AutoRegister();
        }
        public LocalizeTarget_UnityStandard_AudioSource()
        {
        
        }
        [UnityEngine.RuntimeInitializeOnLoadMethodAttribute]
        private static void AutoRegister()
        {
            I2.Loc.LocalizeTargetDesc_Type<UnityEngine.AudioSource, I2.Loc.LocalizeTarget_UnityStandard_AudioSource> val_1 = new I2.Loc.LocalizeTargetDesc_Type<UnityEngine.AudioSource, I2.Loc.LocalizeTarget_UnityStandard_AudioSource>();
            if(null != 0)
            {
                    typeof(I2.Loc.LocalizeTargetDesc_Type<T, G>).__il2cppRuntimeField_10 = "AudioSource";
            }
            else
            {
                    mem[16] = "AudioSource";
            }
            
            typeof(I2.Loc.LocalizeTargetDesc_Type<T, G>).__il2cppRuntimeField_18 = 100;
            I2.Loc.LocalizationManager.RegisterTarget(desc:  null);
        }
        public override I2.Loc.eTermType GetPrimaryTermType(I2.Loc.Localize cmp)
        {
            return 3;
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
            val_6 = 1152921512301385984;
            val_7 = this;
            UnityEngine.AudioClip val_1 = clip;
            bool val_2 = UnityEngine.Object.op_Implicit(exists:  0);
            if(val_2 != false)
            {
                    val_7 = this.clip;
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
            var val_11;
            var val_12;
            val_11 = cmp;
            if(isPlaying != true)
            {
                    if(loop == false)
            {
                goto label_4;
            }
            
            }
            
            var val_5 = (UnityEngine.Application.isPlaying != true) ? 0 : 8;
            goto label_5;
            label_4:
            val_12 = 8;
            label_5:
            UnityEngine.AudioClip val_7 = val_11.FindTranslatedObject<UnityEngine.AudioClip>(value:  mainTranslation);
            if(0 != clip)
            {
                    val_11.clip = val_7;
            }
            
            if(val_12 != 0)
            {
                    return;
            }
            
            UnityEngine.AudioClip val_9 = val_7.clip;
            if((UnityEngine.Object.op_Implicit(exists:  0)) == false)
            {
                    return;
            }
            
            this.Play();
        }
    
    }

}
