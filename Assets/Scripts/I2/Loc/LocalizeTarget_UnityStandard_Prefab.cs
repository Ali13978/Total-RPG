using UnityEngine;

namespace I2.Loc
{
    public class LocalizeTarget_UnityStandard_Prefab : LocalizeTarget<UnityEngine.GameObject>
    {
        // Methods
        private static LocalizeTarget_UnityStandard_Prefab()
        {
            I2.Loc.LocalizeTarget_UnityStandard_Prefab.AutoRegister();
        }
        public LocalizeTarget_UnityStandard_Prefab()
        {
        
        }
        [UnityEngine.RuntimeInitializeOnLoadMethodAttribute]
        private static void AutoRegister()
        {
            I2.Loc.LocalizeTargetDesc_Prefab val_1 = new I2.Loc.LocalizeTargetDesc_Prefab();
            if(null != 0)
            {
                    typeof(I2.Loc.LocalizeTargetDesc_Prefab).__il2cppRuntimeField_10 = "Prefab";
            }
            else
            {
                    mem[16] = "Prefab";
            }
            
            typeof(I2.Loc.LocalizeTargetDesc_Prefab).__il2cppRuntimeField_18 = 250;
            I2.Loc.LocalizationManager.RegisterTarget(desc:  null);
        }
        public override bool IsValid(I2.Loc.Localize cmp)
        {
            return true;
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
            string val_18;
            I2.Loc.Localize val_19;
            string val_20;
            var val_21;
            val_19 = cmp;
            val_20 = 1152921504608284672;
            if((System.String.IsNullOrEmpty(value:  0)) == true)
            {
                    return;
            }
            
            if((UnityEngine.Object.op_Implicit(exists:  0)) != false)
            {
                    val_18 = name;
                if((System.String.op_Equality(a:  0, b:  val_18)) == true)
            {
                    return;
            }
            
            }
            
            val_18 = val_19.transform;
            val_21 = null;
            val_21 = null;
            System.Char[] val_18 = I2.Loc.LanguageSource.CategorySeparators;
            int val_8 = mainTranslation.LastIndexOfAny(anyOf:  val_18);
            val_20 = mainTranslation;
            if((val_8 & 2147483648) == 0)
            {
                    val_18 = val_8 + 1;
                val_20 = mainTranslation.Substring(startIndex:  val_18);
            }
            
            UnityEngine.Transform val_10 = this.InstantiateNewPrefab(cmp:  val_19, mainTranslation:  mainTranslation);
            if(0 == val_10)
            {
                    return;
            }
            
            val_10.name = val_20;
            val_19 = val_18.childCount - 1;
            if((val_19 & 2147483648) != 0)
            {
                    return;
            }
            
            do
            {
                UnityEngine.Transform val_14 = val_18.GetChild(index:  val_19);
                if(0 != val_14)
            {
                    UnityEngine.GameObject val_17 = val_14.gameObject;
                UnityEngine.Object.Destroy(obj:  0);
            }
            
                val_19 = val_19 - 1;
            }
            while((val_19 & 2147483648) == 0);
        
        }
        private UnityEngine.Transform InstantiateNewPrefab(I2.Loc.Localize cmp, string mainTranslation)
        {
            UnityEngine.Transform val_12;
            var val_13;
            val_12 = this;
            val_13 = 0;
            if(0 == (cmp.FindTranslatedObject<UnityEngine.GameObject>(value:  mainTranslation)))
            {
                    return (UnityEngine.Transform)val_13;
            }
            
            Unitycoding.UIWidgets.RadialMenuItem val_12 = UnityEngine.Object.Instantiate<Unitycoding.UIWidgets.RadialMenuItem>(original:  0);
            mem[1152921512307469848] = val_12;
            val_13 = 0;
            val_12 = UnityEngine.Object.op_Equality(x:  0, y:  val_12);
            if(val_12 == true)
            {
                    return (UnityEngine.Transform)val_13;
            }
            
            val_12 = cmp.transform;
            val_13 = val_13.transform;
            val_13.SetParent(parent:  val_12);
            if((UnityEngine.Object.op_Implicit(exists:  0)) != false)
            {
                    val_12 = transform;
            }
            
            UnityEngine.Quaternion val_10 = val_12.rotation;
            val_13.rotation = new UnityEngine.Quaternion() {x = val_10.x, y = val_10.y, z = val_10.z, w = val_10.w};
            UnityEngine.Vector3 val_11 = val_12.position;
            val_13.position = new UnityEngine.Vector3() {x = val_11.x, y = val_11.y, z = val_11.z};
            return (UnityEngine.Transform)val_13;
        }
    
    }

}
