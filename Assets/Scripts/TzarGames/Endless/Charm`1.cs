using UnityEngine;

namespace TzarGames.Endless
{
    public abstract class Charm<T> : TH_Item, IActivatedByCharacter
    {
        // Fields
        [UnityEngine.SerializeField]
        [UnityEngine.HeaderAttribute]
        private CodeStage.AntiCheat.ObscuredTypes.ObscuredFloat bonus;
        [UnityEngine.SerializeField]
        private TzarGames.GameFramework.ModificatorOperators modificatorOperator;
        private T modificator;
        
        // Methods
        protected Charm<T>()
        {
            var val_2;
            var val_3;
            CodeStage.AntiCheat.ObscuredTypes.ObscuredFloat val_1 = CodeStage.AntiCheat.ObscuredTypes.ObscuredFloat.op_Implicit(value:  0f);
            mem[1152921510702602536] = val_2;
            mem[1152921510702602520] = val_3;
            mem[1152921510702602560] = 0;
            if(this != null)
            {
                    return;
            }
        
        }
        protected override void OnEnable()
        {
            this.OnEnable();
            this.Charm = this;
        }
        protected abstract TzarGames.GameFramework.Characteristic getCharacteristic(TzarGames.TzarHero.TH_CharacterTemplate template); // 0
        private void updateModificator(TzarGames.TzarHero.TH_CharacterTemplate characterTemplate)
        {
            var val_11;
            var val_12;
            var val_19;
            var val_20;
            var val_21;
            var val_22;
            var val_24;
            var val_25;
            var val_26;
            System.Collections.Generic.IEnumerable<TzarGames.GameFramework.CharacteristicModificator> val_1 = this.Modificators;
            var val_18 = 0;
            val_18 = val_18 + 1;
            val_19 = val_1;
            do
            {
                label_29:
                var val_19 = 0;
                val_19 = val_19 + 1;
                val_20 = val_1;
                if(((val_1 & 1) & 1) == 0)
            {
                goto label_60;
            }
            
                var val_20 = 0;
                val_20 = val_20 + 1;
                val_21 = val_1;
            }
            while(val_1 == null);
            
            if(val_1 == null)
            {
                goto label_20;
            }
            
            val_22 = val_1;
            if(val_22 != null)
            {
                goto label_21;
            }
            
            label_20:
            val_22 = 0;
            label_21:
            object val_7 = val_22.Charm;
            if(((0 == val_7) || (val_7 != this)) || ((__RuntimeMethodHiddenParam + 24 + 168 + 24) != 0))
            {
                goto label_29;
            }
            
            goto label_29;
            label_60:
            if(val_1 != null)
            {
                    var val_21 = 0;
                val_21 = val_21 + 1;
                val_25 = val_1;
            }
            
            if(0 == 157)
            {
                
            }
            else
            {
                    val_24 = 0;
            }
            
            label_43:
            if((0 & 1) == 0)
            {
                goto label_40;
            }
            
            System.Action<GooglePlayGames.BasicApi.Nearby.InitializationStatus> val_13 = val_12.InitializationCallback;
            if(val_13 == null)
            {
                goto label_43;
            }
            
            val_13.Value = ( == 0) ? 0f : 1f;
            goto label_43;
            label_40:
            val_12 = __RuntimeMethodHiddenParam + 24 + 168 + 80;
            val_11 = val_12;
            if((__RuntimeMethodHiddenParam + 24 + 168 + 80 + 258) == 0)
            {
                goto label_49;
            }
            
            var val_22 = __RuntimeMethodHiddenParam + 24 + 168 + 80 + 152;
            var val_23 = 0;
            val_22 = val_22 + 8;
            label_48:
            if(((__RuntimeMethodHiddenParam + 24 + 168 + 80 + 152 + 8) + -8) == null)
            {
                goto label_47;
            }
            
            val_23 = val_23 + 1;
            val_22 = val_22 + 16;
            if(val_23 < (__RuntimeMethodHiddenParam + 24 + 168 + 80 + 258))
            {
                goto label_48;
            }
            
            goto label_49;
            label_47:
            val_26 = ((__RuntimeMethodHiddenParam + 24 + 168 + 80) + (((__RuntimeMethodHiddenParam + 24 + 168 + 80 + 152 + 8)) << 4)) + 272;
            label_49:
            val_11 = val_11;
            val_12 = val_11;
            1152921504867549184.Value = CodeStage.AntiCheat.ObscuredTypes.ObscuredFloat.op_Implicit(value:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredFloat() {hiddenValue = new CodeStage.AntiCheat.Common.ACTkByte4(), inited = false, fakeValueActive = false});
            if((this.IsModificatorApplied(modificator:  1152921504867549184)) == true)
            {
                    return;
            }
            
            typeof(TzarGames.Endless.Charm<T>).__il2cppRuntimeField_18 = this;
            typeof(TzarGames.Endless.Charm<T>).__il2cppRuntimeField_10 = 0;
            this.AddModificator(modificator:  1152921504867549184);
        }
        public override string GetDescription()
        {
            if(0 != 34820096)
            {
                    return (string)System.String.Format(format:  0, arg0:  TzarGames.Common.LocalizedStringAsset.op_Implicit(text:  0));
            }
            
            if(this != null)
            {
                    return this.GetDescription();
            }
            
            return this.GetDescription();
        }
        public void OnActivatedOnCharacter(TzarGames.TzarHero.TH_CharacterTemplate characterTemplate, TzarGames.GameFramework.ItemInstance itemInstance)
        {
            var val_9;
            var val_10;
            List.Enumerator<T> val_4 = characterTemplate.Inventory.GetBagOfItemInstance(itemInstance:  itemInstance).GetAllItemInstancesById(id:  1801366112).GetEnumerator();
            label_12:
            if((0 & 1) == 0)
            {
                goto label_6;
            }
            
            if((0 == 0.InitializationCallback.GetTemplateInstance()) || (characterTemplate != null))
            {
                goto label_12;
            }
            
            goto label_12;
            label_6:
            val_9 = 0;
            val_10 = 108;
            var val_8 = 0;
            val_8 = val_8 + 1;
            if(this != null)
            {
                    return;
            }
        
        }
        public void OnDeactivatedOnCharacter(TzarGames.TzarHero.TH_CharacterTemplate characterTemplate, TzarGames.GameFramework.ItemInstance itemInstance)
        {
            var val_10;
            var val_11;
            var val_12;
            var val_13;
            this.UnregisterModificator(modificator:  X23);
            System.Collections.Generic.IEnumerable<TzarGames.GameFramework.CharacteristicModificator> val_1 = this.Modificators;
            float val_2 = CodeStage.AntiCheat.ObscuredTypes.ObscuredFloat.op_Implicit(value:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredFloat() {hiddenValue = new CodeStage.AntiCheat.Common.ACTkByte4(), inited = false, fakeValueActive = false});
            var val_10 = 0;
            val_10 = val_10 + 1;
            val_10 = val_1;
            do
            {
                label_30:
                var val_11 = 0;
                val_11 = val_11 + 1;
                val_11 = val_1;
                if(((val_1 & 1) & 1) == 0)
            {
                goto label_38;
            }
            
                var val_12 = 0;
                val_12 = val_12 + 1;
                val_12 = val_1;
            }
            while(val_1 == null);
            
            object val_7 = val_1.Charm;
            if(((0 == val_7) || (val_7 != this)) || (val_7 != null))
            {
                goto label_30;
            }
            
            goto label_30;
            label_38:
            if(val_1 != null)
            {
                    var val_13 = 0;
                val_13 = val_13 + 1;
                val_13 = val_1;
            }
            
            if(0 == 173)
            {
                    return;
            }
            
            if(null == null)
            {
                    return;
            }
        
        }
        public bool CanBeActivatedOnCharacter(TzarGames.TzarHero.TH_CharacterTemplate characterTemplate, TzarGames.GameFramework.ItemInstance itemInstance)
        {
            return true;
        }
    
    }

}
