using UnityEngine;

namespace TzarGames.GameFramework
{
    [Serializable]
    public class CharacteristicModificator
    {
        // Fields
        [UnityEngine.SerializeField]
        public TzarGames.GameFramework.ModificatorMode ModificationMode;
        [UnityEngine.SerializeField]
        private float valueToModify;
        [UnityEngine.SerializeField]
        public TzarGames.GameFramework.ModificatorOperators Operator;
        public float StartTime;
        [UnityEngine.SerializeField]
        public float EffectTime;
        private System.Collections.Generic.List<TzarGames.GameFramework.CharacteristicModificator> multiplyBaseModificators;
        private System.Collections.Generic.List<TzarGames.GameFramework.CharacteristicModificator> multiplyActualModificators;
        private System.Collections.Generic.List<TzarGames.GameFramework.CharacteristicModificator> addModificators;
        private System.Collections.Generic.List<TzarGames.GameFramework.CharacteristicModificator> addActualModificators;
        
        // Properties
        public float Value { get; set; }
        
        // Methods
        public CharacteristicModificator()
        {
        
        }
        public CharacteristicModificator(TzarGames.GameFramework.CharacteristicModificator baseModificator)
        {
            if(baseModificator != null)
            {
                    this.EffectTime = baseModificator.EffectTime;
                this.StartTime = baseModificator.StartTime;
                this.valueToModify = baseModificator.Value;
                this.ModificationMode = baseModificator.ModificationMode;
            }
            else
            {
                    this.EffectTime = 8.96831E-44f;
                this.StartTime = 0f;
                this.valueToModify = this.Value;
                this.ModificationMode = 11993091;
            }
            
            this.Operator = baseModificator.Operator;
        }
        public CharacteristicModificator(float value)
        {
            this.valueToModify = value;
        }
        public void AddModificator(TzarGames.GameFramework.CharacteristicModificator modificator)
        {
            TzarGames.GameFramework.ModificatorOperators val_14 = modificator.Operator;
            val_14 = (val_14 < 4) ? (val_14 + 3) : 0;
            val_14 = val_14 - 3;
            if(val_14 > 3)
            {
                    return;
            }
            
            var val_15 = 25486352 + ((modificator.Operator < 0x4 ? (modificator.Operator + 3) : 0 - 3)) << 2;
            val_15 = val_15 + 25486352;
            goto (25486352 + ((modificator.Operator < 0x4 ? (modificator.Operator + 3) : 0 - 3)) << 2 + 25486352);
        }
        public void RemoveModificator(TzarGames.GameFramework.CharacteristicModificator modificator)
        {
            TzarGames.GameFramework.ModificatorOperators val_9 = modificator.Operator;
            val_9 = (val_9 < 4) ? (val_9 + 3) : 0;
            val_9 = val_9 - 3;
            if(val_9 > 3)
            {
                    return;
            }
            
            var val_10 = 25486368 + ((modificator.Operator < 0x4 ? (modificator.Operator + 3) : 0 - 3)) << 2;
            val_10 = val_10 + 25486368;
            goto (25486368 + ((modificator.Operator < 0x4 ? (modificator.Operator + 3) : 0 - 3)) << 2 + 25486368);
        }
        public bool HasModificator(TzarGames.GameFramework.CharacteristicModificator modificator)
        {
            var val_9;
            if(this.addModificators != null)
            {
                    if((this.addModificators.Contains(item:  modificator)) == true)
            {
                goto label_6;
            }
            
            }
            
            if(this.multiplyBaseModificators != null)
            {
                    if((this.multiplyBaseModificators.Contains(item:  modificator)) == true)
            {
                goto label_6;
            }
            
            }
            
            if(this.multiplyActualModificators != null)
            {
                    if((this.multiplyActualModificators.Contains(item:  modificator)) == true)
            {
                goto label_6;
            }
            
            }
            
            if((this.addActualModificators != null) && ((this.addActualModificators.Contains(item:  modificator)) != false))
            {
                    label_6:
                val_9 = 1;
                return (bool)val_9;
            }
            
            val_9 = 0;
            return (bool)val_9;
        }
        public float get_Value()
        {
            float val_13;
            var val_14;
            var val_15;
            System.Collections.Generic.List<TzarGames.GameFramework.CharacteristicModificator> val_16;
            var val_17;
            var val_18;
            var val_19;
            val_13 = this.valueToModify;
            if((this.multiplyBaseModificators == null) || (this.multiplyBaseModificators.Count < 1))
            {
                goto label_6;
            }
            
            val_14 = 1152921510945706944;
            val_15 = 0;
            goto label_3;
            label_9:
            val_13 = val_13 * S0;
            val_15 = 1;
            label_3:
            val_16 = this.multiplyBaseModificators;
            if(val_15 >= val_16.Count)
            {
                goto label_6;
            }
            
            if(this.multiplyBaseModificators.Item[1] != null)
            {
                goto label_9;
            }
            
            goto label_9;
            label_6:
            if((this.addModificators == null) || (this.addModificators.Count < 1))
            {
                goto label_15;
            }
            
            val_14 = 1152921510945706944;
            val_17 = 0;
            goto label_12;
            label_18:
            val_13 = val_13 + S0;
            val_17 = 1;
            label_12:
            val_16 = this.addModificators;
            if(val_17 >= val_16.Count)
            {
                goto label_15;
            }
            
            if(this.addModificators.Item[1] != null)
            {
                goto label_18;
            }
            
            goto label_18;
            label_15:
            if((this.multiplyActualModificators == null) || (this.multiplyActualModificators.Count < 1))
            {
                goto label_24;
            }
            
            val_14 = 1152921510945706944;
            val_18 = 0;
            goto label_21;
            label_27:
            val_13 = val_13 * S0;
            val_18 = 1;
            label_21:
            val_16 = this.multiplyActualModificators;
            if(val_18 >= val_16.Count)
            {
                goto label_24;
            }
            
            if(this.multiplyActualModificators.Item[1] != null)
            {
                goto label_27;
            }
            
            goto label_27;
            label_24:
            if(this.addActualModificators == null)
            {
                    return val_13;
            }
            
            if(this.addActualModificators.Count <= 0)
            {
                    return val_13;
            }
            
            val_14 = 1152921510945706944;
            val_19 = 0;
            goto label_30;
            label_36:
            val_13 = val_13 + S0;
            val_19 = 1;
            label_30:
            val_16 = this.addActualModificators;
            if(val_19 >= val_16.Count)
            {
                    return val_13;
            }
            
            if(this.addActualModificators.Item[1] != null)
            {
                goto label_36;
            }
            
            goto label_36;
        }
        public void set_Value(float value)
        {
            this.valueToModify = value;
        }
        public void Clear()
        {
            if(this.multiplyBaseModificators != null)
            {
                    this.multiplyBaseModificators.Clear();
            }
            
            if(this.multiplyActualModificators != null)
            {
                    this.multiplyActualModificators.Clear();
            }
            
            if(this.addModificators != null)
            {
                    this.addModificators.Clear();
            }
            
            if(this.addActualModificators == null)
            {
                    return;
            }
            
            this.addActualModificators.Clear();
        }
    
    }

}
