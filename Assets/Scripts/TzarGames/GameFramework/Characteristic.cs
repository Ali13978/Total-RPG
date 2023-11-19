using UnityEngine;

namespace TzarGames.GameFramework
{
    [Serializable]
    public class Characteristic
    {
        // Fields
        [UnityEngine.SerializeField]
        private float baseValue;
        private CodeStage.AntiCheat.ObscuredTypes.ObscuredFloat oBaseValue;
        private CodeStage.AntiCheat.ObscuredTypes.ObscuredFloat modifiedBase;
        public bool AllowTimeModificators;
        public bool clampMinimum;
        public bool clampMaximum;
        public float minValue;
        public float maxValue;
        public bool applyModificatorsWhenBaseIsLessOrEqualZero;
        public bool resetWhenModifiedToZero;
        public float resetValue;
        private System.Collections.Generic.List<TzarGames.GameFramework.CharacteristicModificator> modificators;
        private System.Collections.Generic.List<TzarGames.GameFramework.CharacteristicModificator> timeModificators;
        private System.Collections.Generic.List<TzarGames.GameFramework.CharacteristicModificator> modificatorsToRemove;
        [System.Diagnostics.DebuggerBrowsableAttribute]
        private TzarGames.GameFramework.Characteristic.ModificatorDelegate OnModificatorTimeExpired;
        [System.Diagnostics.DebuggerBrowsableAttribute]
        private TzarGames.GameFramework.Characteristic.ModificatorDelegate OnModificatorAdded;
        [System.Diagnostics.DebuggerBrowsableAttribute]
        private TzarGames.GameFramework.Characteristic.ModificatorDelegate OnModificatorRemoved;
        [System.Diagnostics.DebuggerBrowsableAttribute]
        private TzarGames.Common.TG_VoidDelegate OnChanged;
        
        // Properties
        public System.Collections.Generic.IEnumerable<TzarGames.GameFramework.CharacteristicModificator> Modificators { get; }
        public System.Collections.Generic.IEnumerable<TzarGames.GameFramework.CharacteristicModificator> TimeModificators { get; }
        public float BaseValue { get; }
        public float Value { get; set; }
        
        // Methods
        public Characteristic()
        {
            var val_2;
            CodeStage.AntiCheat.ObscuredTypes.ObscuredFloat val_3;
            var val_5;
            CodeStage.AntiCheat.ObscuredTypes.ObscuredFloat val_6;
            this.baseValue = 1f;
            CodeStage.AntiCheat.ObscuredTypes.ObscuredFloat val_1 = CodeStage.AntiCheat.ObscuredTypes.ObscuredFloat.op_Implicit(value:  0f);
            mem[1152921511307999912] = val_2;
            this.oBaseValue = val_3;
            CodeStage.AntiCheat.ObscuredTypes.ObscuredFloat val_4 = CodeStage.AntiCheat.ObscuredTypes.ObscuredFloat.op_Implicit(value:  0f);
            mem[1152921511307999944] = val_5;
            this.minValue = -3.402823E+38f;
            this.maxValue = -1.175494E-38f;
            this.modifiedBase = val_6;
            this.applyModificatorsWhenBaseIsLessOrEqualZero = true;
            this.resetValue = 1f;
            this.modificators = new System.Collections.Generic.List<TzarGames.GameFramework.CharacteristicModificator>();
            this.timeModificators = new System.Collections.Generic.List<TzarGames.GameFramework.CharacteristicModificator>();
            this.modificatorsToRemove = new System.Collections.Generic.List<TzarGames.GameFramework.CharacteristicModificator>();
        }
        public Characteristic(float baseValue)
        {
            var val_2;
            CodeStage.AntiCheat.ObscuredTypes.ObscuredFloat val_3;
            var val_5;
            CodeStage.AntiCheat.ObscuredTypes.ObscuredFloat val_6;
            this.baseValue = 1f;
            CodeStage.AntiCheat.ObscuredTypes.ObscuredFloat val_1 = CodeStage.AntiCheat.ObscuredTypes.ObscuredFloat.op_Implicit(value:  0f);
            mem[1152921511308275688] = val_2;
            this.oBaseValue = val_3;
            CodeStage.AntiCheat.ObscuredTypes.ObscuredFloat val_4 = CodeStage.AntiCheat.ObscuredTypes.ObscuredFloat.op_Implicit(value:  0f);
            mem[1152921511308275720] = val_5;
            this.minValue = -3.402823E+38f;
            this.maxValue = -1.175494E-38f;
            this.modifiedBase = val_6;
            this.applyModificatorsWhenBaseIsLessOrEqualZero = true;
            this.resetValue = 1f;
            this.modificators = new System.Collections.Generic.List<TzarGames.GameFramework.CharacteristicModificator>();
            this.timeModificators = new System.Collections.Generic.List<TzarGames.GameFramework.CharacteristicModificator>();
            this.modificatorsToRemove = new System.Collections.Generic.List<TzarGames.GameFramework.CharacteristicModificator>();
            this.baseValue = baseValue;
        }
        public void add_OnModificatorTimeExpired(TzarGames.GameFramework.Characteristic.ModificatorDelegate value)
        {
            var val_3;
            do
            {
                System.Delegate val_1 = System.Delegate.Combine(a:  0, b:  this.OnModificatorTimeExpired);
                val_3 = 0;
                if(val_1 != null)
            {
                    val_3 = val_1;
                if(null != null)
            {
                    val_3 = 0;
            }
            
            }
            
            }
            while(1152921511308481960 != this.OnModificatorTimeExpired);
        
        }
        public void remove_OnModificatorTimeExpired(TzarGames.GameFramework.Characteristic.ModificatorDelegate value)
        {
            var val_3;
            do
            {
                System.Delegate val_1 = System.Delegate.Remove(source:  0, value:  this.OnModificatorTimeExpired);
                val_3 = 0;
                if(val_1 != null)
            {
                    val_3 = val_1;
                if(null != null)
            {
                    val_3 = 0;
            }
            
            }
            
            }
            while(1152921511308618536 != this.OnModificatorTimeExpired);
        
        }
        public void add_OnModificatorAdded(TzarGames.GameFramework.Characteristic.ModificatorDelegate value)
        {
            var val_3;
            do
            {
                System.Delegate val_1 = System.Delegate.Combine(a:  0, b:  this.OnModificatorAdded);
                val_3 = 0;
                if(val_1 != null)
            {
                    val_3 = val_1;
                if(null != null)
            {
                    val_3 = 0;
            }
            
            }
            
            }
            while(1152921511308755120 != this.OnModificatorAdded);
        
        }
        public void remove_OnModificatorAdded(TzarGames.GameFramework.Characteristic.ModificatorDelegate value)
        {
            var val_3;
            do
            {
                System.Delegate val_1 = System.Delegate.Remove(source:  0, value:  this.OnModificatorAdded);
                val_3 = 0;
                if(val_1 != null)
            {
                    val_3 = val_1;
                if(null != null)
            {
                    val_3 = 0;
            }
            
            }
            
            }
            while(1152921511308891696 != this.OnModificatorAdded);
        
        }
        public void add_OnModificatorRemoved(TzarGames.GameFramework.Characteristic.ModificatorDelegate value)
        {
            var val_3;
            do
            {
                System.Delegate val_1 = System.Delegate.Combine(a:  0, b:  this.OnModificatorRemoved);
                val_3 = 0;
                if(val_1 != null)
            {
                    val_3 = val_1;
                if(null != null)
            {
                    val_3 = 0;
            }
            
            }
            
            }
            while(1152921511309028280 != this.OnModificatorRemoved);
        
        }
        public void remove_OnModificatorRemoved(TzarGames.GameFramework.Characteristic.ModificatorDelegate value)
        {
            var val_3;
            do
            {
                System.Delegate val_1 = System.Delegate.Remove(source:  0, value:  this.OnModificatorRemoved);
                val_3 = 0;
                if(val_1 != null)
            {
                    val_3 = val_1;
                if(null != null)
            {
                    val_3 = 0;
            }
            
            }
            
            }
            while(1152921511309164856 != this.OnModificatorRemoved);
        
        }
        public void Init()
        {
            bool val_2;
            var val_3;
            var val_5;
            CodeStage.AntiCheat.ObscuredTypes.ObscuredFloat val_6;
            CodeStage.AntiCheat.ObscuredTypes.ObscuredFloat val_1 = CodeStage.AntiCheat.ObscuredTypes.ObscuredFloat.op_Implicit(value:  this.baseValue);
            inited = val_2;
            mem2[0] = val_3;
            CodeStage.AntiCheat.ObscuredTypes.ObscuredFloat val_4 = CodeStage.AntiCheat.ObscuredTypes.ObscuredFloat.op_Implicit(value:  this.baseValue);
            mem[1152921511309370952] = val_5;
            this.modifiedBase = val_6;
        }
        public void Update()
        {
            TzarGames.GameFramework.CharacteristicModificator val_15;
            float val_16;
            float val_17;
            var val_18;
            if(this.modificators.Count >= 1)
            {
                    System.Collections.Generic.List<TzarGames.GameFramework.CharacteristicModificator> val_15 = this.modificators;
                val_15 = val_15.Count - 1;
                if((val_15 & 2147483648) == 0)
            {
                    do
            {
                val_15 = this.modificators.Item[val_15];
                val_16 = val_3.EffectTime;
                if(val_16 > 0f)
            {
                    val_16 = UnityEngine.Time.time - val_3.StartTime;
                if(val_16 >= val_3.EffectTime)
            {
                    this.UnregisterModificator(modificator:  val_15);
                if(this.OnModificatorTimeExpired != null)
            {
                    this.OnModificatorTimeExpired.Invoke(characteristic:  this, modificator:  val_15);
            }
            
            }
            
            }
            
                val_15 = val_15 - 1;
            }
            while((val_15 & 2147483648) == 0);
            
            }
            
            }
            
            if(this.timeModificators.Count < 1)
            {
                    return;
            }
            
            val_17 = 0f;
            if(this.timeModificators.Count >= 1)
            {
                    int val_7 = this.timeModificators.Count;
                if(val_7 >= 1)
            {
                    var val_16 = 0;
                do
            {
                TzarGames.GameFramework.CharacteristicModificator val_8 = this.timeModificators.Item[0];
                val_16 = val_8.EffectTime;
                if(val_16 > 0f)
            {
                    val_16 = UnityEngine.Time.time - val_8.StartTime;
                if(val_16 >= val_8.EffectTime)
            {
                    this.UnregisterModificator(modificator:  val_8);
                if(this.OnModificatorTimeExpired != null)
            {
                    this.OnModificatorTimeExpired.Invoke(characteristic:  this, modificator:  val_8);
            }
            
            }
            
            }
            
                val_16 = val_16 + 1;
            }
            while(val_7 != val_16);
            
            }
            
            }
            
            val_18 = 0;
            goto label_23;
            label_28:
            val_16 = S8 * val_16.Value;
            val_17 = val_17 + val_16;
            val_18 = 1;
            label_23:
            val_15 = this.timeModificators;
            if(val_18 >= val_15.Count)
            {
                goto label_25;
            }
            
            float val_13 = UnityEngine.Time.deltaTime;
            if(this.timeModificators.Item[1] != null)
            {
                goto label_28;
            }
            
            goto label_28;
            label_25:
            if(System.Math.Abs(val_17) <= 0.0001f)
            {
                    return;
            }
            
            float val_14 = this.Value;
            val_14 = val_17 + val_14;
            this.Value = val_14;
            if(this.OnChanged == null)
            {
                    return;
            }
            
            this.OnChanged.Invoke();
        }
        public System.Collections.Generic.IEnumerable<TzarGames.GameFramework.CharacteristicModificator> get_Modificators()
        {
            return (System.Collections.Generic.IEnumerable<TzarGames.GameFramework.CharacteristicModificator>)this.modificators;
        }
        public System.Collections.Generic.IEnumerable<TzarGames.GameFramework.CharacteristicModificator> get_TimeModificators()
        {
            return (System.Collections.Generic.IEnumerable<TzarGames.GameFramework.CharacteristicModificator>)this.modificators;
        }
        public void add_OnChanged(TzarGames.Common.TG_VoidDelegate value)
        {
            var val_3;
            do
            {
                System.Delegate val_1 = System.Delegate.Combine(a:  0, b:  this.OnChanged);
                val_3 = 0;
                if(val_1 != null)
            {
                    val_3 = val_1;
                if(null != null)
            {
                    val_3 = 0;
            }
            
            }
            
            }
            while(1152921511310052480 != this.OnChanged);
        
        }
        public void remove_OnChanged(TzarGames.Common.TG_VoidDelegate value)
        {
            var val_3;
            do
            {
                System.Delegate val_1 = System.Delegate.Remove(source:  0, value:  this.OnChanged);
                val_3 = 0;
                if(val_1 != null)
            {
                    val_3 = val_1;
                if(null != null)
            {
                    val_3 = 0;
            }
            
            }
            
            }
            while(1152921511310189056 != this.OnChanged);
        
        }
        public void ClearAllModificators()
        {
            this.modificators.Clear();
        }
        public bool IsModificatorApplied(TzarGames.GameFramework.CharacteristicModificator modificator)
        {
            if((this.modificators.Contains(item:  modificator)) != false)
            {
                    return true;
            }
            
            if(this.timeModificators != null)
            {
                    return this.timeModificators.Contains(item:  modificator);
            }
            
            return this.timeModificators.Contains(item:  modificator);
        }
        public void AddModificator(TzarGames.GameFramework.CharacteristicModificator modificator)
        {
            float val_10;
            var val_11;
            System.Collections.Generic.List<TzarGames.GameFramework.CharacteristicModificator> val_12;
            if(this.AllowTimeModificators == false)
            {
                goto label_1;
            }
            
            val_10 = this.Value;
            if(modificator != null)
            {
                goto label_2;
            }
            
            val_11 = 1;
            goto label_3;
            label_1:
            if(modificator.ModificationMode == 1)
            {
                    UnityEngine.Debug.LogError(message:  0);
                return;
            }
            
            val_10 = this.Value;
            label_2:
            val_11 = 0;
            label_3:
            if(modificator.ModificationMode == 1)
            {
                goto label_8;
            }
            
            if(modificator.ModificationMode != 0)
            {
                goto label_9;
            }
            
            val_12 = this.modificators;
            if((val_12.Contains(item:  modificator)) != true)
            {
                    val_12 = this.modificators;
                val_12.Add(item:  modificator);
                if(this.OnModificatorAdded != null)
            {
                    this.OnModificatorAdded.Invoke(characteristic:  this, modificator:  modificator);
            }
            
            }
            
            modificator.StartTime = UnityEngine.Time.time;
            goto label_19;
            label_8:
            val_12 = this.timeModificators.Contains(item:  modificator);
            modificator.StartTime = UnityEngine.Time.time;
            if(val_12 != true)
            {
                    val_12 = this.timeModificators;
                val_12.Add(item:  modificator);
                if(this.OnModificatorAdded != null)
            {
                    this.OnModificatorAdded.Invoke(characteristic:  this, modificator:  modificator);
            }
            
            }
            
            label_19:
            if(this.Value == val_10)
            {
                    return;
            }
            
            if(this.OnChanged == null)
            {
                    return;
            }
            
            this.OnChanged.Invoke();
            return;
            label_9:
            System.ArgumentOutOfRangeException val_9 = new System.ArgumentOutOfRangeException();
        }
        public void UnregisterModificator(TzarGames.GameFramework.CharacteristicModificator modificator)
        {
            System.Collections.Generic.List<TzarGames.GameFramework.CharacteristicModificator> val_5;
            if(modificator == null)
            {
                goto label_1;
            }
            
            if(modificator.ModificationMode == 1)
            {
                goto label_2;
            }
            
            if(modificator.ModificationMode != 0)
            {
                goto label_3;
            }
            
            val_5 = this.modificators;
            if(val_5 != null)
            {
                goto label_8;
            }
            
            goto label_5;
            label_1:
            UnityEngine.Debug.LogError(message:  0);
            return;
            label_2:
            val_5 = this.timeModificators;
            if(val_5 != null)
            {
                goto label_8;
            }
            
            label_5:
            label_8:
            if(((val_5.Remove(item:  modificator)) != false) && (this.OnModificatorRemoved != null))
            {
                    this.OnModificatorRemoved.Invoke(characteristic:  this, modificator:  modificator);
            }
            
            float val_3 = this.Value;
            val_3 = val_3 - this.Value;
            if(System.Math.Abs(val_3) <= 0.0001f)
            {
                    return;
            }
            
            if(this.OnChanged == null)
            {
                    return;
            }
            
            this.OnChanged.Invoke();
            return;
            label_3:
            System.ArgumentOutOfRangeException val_4 = new System.ArgumentOutOfRangeException();
        }
        public float get_BaseValue()
        {
            return (float)CodeStage.AntiCheat.ObscuredTypes.ObscuredFloat.op_Implicit(value:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredFloat() {hiddenValue = new CodeStage.AntiCheat.Common.ACTkByte4(), inited = false, fakeValueActive = false});
        }
        public float get_Value()
        {
            float val_19;
            float val_20;
            var val_21;
            var val_22;
            float val_23;
            float val_24;
            float val_25;
            float val_26;
            var val_27;
            val_19 = CodeStage.AntiCheat.ObscuredTypes.ObscuredFloat.op_Implicit(value:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredFloat() {hiddenValue = new CodeStage.AntiCheat.Common.ACTkByte4(), inited = false, fakeValueActive = false});
            if(val_19 <= 0f)
            {
                    if(this.applyModificatorsWhenBaseIsLessOrEqualZero == true)
            {
                goto label_40;
            }
            
            }
            
            int val_2 = this.modificators.Count;
            if(val_2 >= 1)
            {
                    val_20 = 1f;
                val_21 = 0;
                val_22 = 0;
                var val_20 = 0;
                val_23 = val_20;
                val_24 = val_20;
                do
            {
                if((val_3.ModificationMode != 1) && (val_3.Operator == 1))
            {
                    float val_4 = this.modificators.Item[0].Value;
                float val_21 = val_4;
                if(val_21 < 0)
            {
                    val_20 = val_20 * System.Math.Abs(val_21);
                val_22 = 1;
            }
            else
            {
                    val_4 = val_21 + (-1f);
                if(System.Math.Abs(val_4) > 0.0001f)
            {
                    val_23 = val_23 + val_4;
            }
            else
            {
                    val_24 = val_24 * val_21;
            }
            
                val_21 = 1;
            }
            
            }
            
                val_20 = val_20 + 1;
            }
            while(val_2 != val_20);
            
                float val_7 = val_24 * val_23;
                var val_22 = 0;
                val_7 = val_19 * val_7;
                float val_8 = (val_21 != 1) ? (val_7) : (val_19);
                val_21 = (val_22 != 1) ? (-(val_20 * val_8)) : (val_8);
                val_26 = 1f;
                do
            {
                if((val_10.ModificationMode != 1) && (val_10.Operator == 0))
            {
                    val_25 = val_21 + this.modificators.Item[0].Value;
            }
            
                val_22 = val_22 + 1;
            }
            while(val_2 != val_22);
            
                val_27 = 0;
                var val_24 = 0;
                do
            {
                TzarGames.GameFramework.CharacteristicModificator val_12 = this.modificators.Item[0];
                if((val_12.ModificationMode != 1) && (val_12.Operator == 2))
            {
                    float val_13 = val_12.Value;
                if(val_13 < 0)
            {
                    val_26 = val_26 * System.Math.Abs(val_13);
                val_27 = 1;
            }
            else
            {
                    float val_14 = val_12.Value;
                val_25 = val_25 * val_14;
            }
            
            }
            
                val_24 = val_24 + 1;
            }
            while(val_2 != val_24);
            
                var val_25 = 0;
                val_14 = -(val_26 * val_25);
                do
            {
                if((val_16.ModificationMode != 1) && (val_16.Operator == 3))
            {
                    val_19 = ((val_27 != 1) ? (val_14) : (val_25)) + this.modificators.Item[0].Value;
            }
            
                val_25 = val_25 + 1;
            }
            while(val_2 != val_25);
            
                if((val_19 <= 0f) && (this.resetWhenModifiedToZero != false))
            {
                    val_19 = this.resetValue;
            }
            
            }
            
            label_40:
            if((this.clampMinimum != false) && (this.minValue > val_19))
            {
                    val_19 = this.minValue;
            }
            
            if(this.clampMaximum == false)
            {
                    return (float)val_19;
            }
            
            if(this.maxValue >= 0)
            {
                    return (float)val_19;
            }
            
            val_19 = this.maxValue;
            return (float)val_19;
        }
        public void set_Value(float value)
        {
            float val_1 = CodeStage.AntiCheat.ObscuredTypes.ObscuredFloat.op_Implicit(value:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredFloat() {hiddenValue = new CodeStage.AntiCheat.Common.ACTkByte4(), inited = false, fakeValueActive = false});
            val_1 = val_1 - value;
            if(System.Math.Abs(val_1) <= 0.0001f)
            {
                    return;
            }
            
            CodeStage.AntiCheat.ObscuredTypes.ObscuredFloat val_2 = CodeStage.AntiCheat.ObscuredTypes.ObscuredFloat.op_Implicit(value:  value);
            inited = value;
            mem2[0] = this.modifiedBase;
            if(this.OnChanged == null)
            {
                    return;
            }
            
            this.OnChanged.Invoke();
        }
        private void fireChangeEvent()
        {
            if(this.OnChanged == null)
            {
                    return;
            }
            
            this.OnChanged.Invoke();
        }
    
    }

}
