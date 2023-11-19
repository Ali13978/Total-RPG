using UnityEngine;

namespace TzarGames.GameFramework
{
    public class BooleanCharacteristic
    {
        // Fields
        [UnityEngine.SerializeField]
        private CodeStage.AntiCheat.ObscuredTypes.ObscuredBool baseValue;
        private System.Collections.Generic.List<TzarGames.GameFramework.BooleanCharacteristic.BooleanModificator> modificators;
        
        // Properties
        public bool ModifiedValue { get; }
        public bool BaseValue { get; set; }
        
        // Methods
        public BooleanCharacteristic()
        {
            CodeStage.AntiCheat.ObscuredTypes.ObscuredBool val_1 = CodeStage.AntiCheat.ObscuredTypes.ObscuredBool.op_Implicit(value:  false);
            this.baseValue = val_1;
            mem[1152921511266731752] = val_1.inited;
            mem[1152921511266731753] = val_1.fakeValue;
            mem[1152921511266731754] = val_1.fakeValueActive;
            this.modificators = new System.Collections.Generic.List<BooleanModificator>();
        }
        public bool get_ModifiedValue()
        {
            var val_3;
            var val_5;
            bool val_8;
            var val_9;
            var val_21;
            var val_22;
            var val_23;
            var val_24;
            val_21 = CodeStage.AntiCheat.ObscuredTypes.ObscuredBool.op_Implicit(value:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredBool() {inited = this.baseValue, fakeValue = this.baseValue, fakeValueActive = this.baseValue});
            List.Enumerator<T> val_2 = this.modificators.GetEnumerator();
            goto label_5;
            label_23:
            var val_6 = (val_3 != 0) ? 1 : 0;
            goto label_5;
            label_12:
            GooglePlayGames.BasicApi.Nearby.EndpointDetails val_7 = val_5.RemoteEndpoint;
            var val_21 = val_9;
            var val_10 = val_21 >> 32;
            if(val_10 == 0)
            {
                goto label_6;
            }
            
            if(val_10 == 1)
            {
                goto label_7;
            }
            
            string val_11 = 0 + "Unknown operator ";
            UnityEngine.Debug.LogError(message:  0);
            label_5:
            if((0 & 1) != 0)
            {
                goto label_12;
            }
            
            goto label_13;
            label_6:
            if((val_6 & 1) == 0)
            {
                goto label_23;
            }
            
            val_21 = (val_21 & 4294967295) | (val_3 & (-4294967296));
            val_22 = 0;
            bool val_14 = CodeStage.AntiCheat.ObscuredTypes.ObscuredBool.op_Implicit(value:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredBool() {inited = val_8, fakeValue = val_8, fakeValueActive = val_8});
            goto label_17;
            label_7:
            if(((val_6 & 1) & 1) == 0)
            {
                goto label_18;
            }
            
            goto label_23;
            label_18:
            val_21 = (val_21 & 4294967295) | (val_3 & (-4294967296));
            val_22 = 0;
            label_17:
            bool val_19 = CodeStage.AntiCheat.ObscuredTypes.ObscuredBool.op_Implicit(value:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredBool() {inited = val_8, fakeValue = val_8, fakeValueActive = val_8});
            goto label_23;
            label_13:
            val_23 = 0;
            val_24 = 1;
            val_5.Dispose();
            return (bool)val_6 & 1;
        }
        public bool get_BaseValue()
        {
            return CodeStage.AntiCheat.ObscuredTypes.ObscuredBool.op_Implicit(value:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredBool() {inited = this.baseValue, fakeValue = this.baseValue, fakeValueActive = this.baseValue});
        }
        public void set_BaseValue(bool value)
        {
            value = value;
            CodeStage.AntiCheat.ObscuredTypes.ObscuredBool val_1 = CodeStage.AntiCheat.ObscuredTypes.ObscuredBool.op_Implicit(value:  false);
            this.baseValue = val_1;
            mem[1152921511267129176] = val_1.inited;
            mem[1152921511267129177] = val_1.fakeValue;
            mem[1152921511267129178] = val_1.fakeValueActive;
        }
        public void AddModificator(object owner, bool value, TzarGames.GameFramework.BooleanCharacteristic.BooleanOperator booleanOperator)
        {
            var val_3;
            System.Collections.Generic.List<BooleanModificator> val_6;
            int val_7;
            val_6 = owner;
            val_7 = this.modificators.Count - 1;
            if((val_7 & 2147483648) != 0)
            {
                goto label_2;
            }
            
            label_10:
            BooleanModificator val_2 = this.modificators.Item[val_7];
            if(val_3 == 0)
            {
                goto label_4;
            }
            
            if(val_3 != val_6)
            {
                goto label_5;
            }
            
            goto label_6;
            label_4:
            UnityEngine.Debug.LogError(message:  0);
            this.modificators.RemoveAt(index:  val_7);
            label_5:
            val_7 = val_7 - 1;
            if((val_7 & 2147483648) == 0)
            {
                goto label_10;
            }
            
            label_2:
            bool val_4 = value;
            val_6 = this.modificators;
            val_3 = 0;
            val_6.Add(item:  new BooleanModificator() {Value = new CodeStage.AntiCheat.ObscuredTypes.ObscuredBool() {inited = false, fakeValue = false, fakeValueActive = false}});
            return;
            label_6:
            typeof(System.Object[]).__il2cppRuntimeField_20 = val_6;
            UnityEngine.Debug.LogErrorFormat(format:  0, args:  "Already contains modificator for owner {0}");
        }
        public void RemoveModificator(object owner)
        {
            var val_3;
            System.Collections.Generic.List<BooleanModificator> val_4;
            int val_5;
            val_4 = owner;
            val_5 = this.modificators.Count - 1;
            if((val_5 & 2147483648) != 0)
            {
                    return;
            }
            
            label_10:
            BooleanModificator val_2 = this.modificators.Item[val_5];
            if(val_3 == 0)
            {
                goto label_4;
            }
            
            if(val_3 != val_4)
            {
                goto label_5;
            }
            
            goto label_6;
            label_4:
            UnityEngine.Debug.LogError(message:  0);
            this.modificators.RemoveAt(index:  val_5);
            label_5:
            val_5 = val_5 - 1;
            if((val_5 & 2147483648) == 0)
            {
                goto label_10;
            }
            
            return;
            label_6:
            val_4 = this.modificators;
            val_4.RemoveAt(index:  val_5);
        }
        public void ClearModificators()
        {
            this.modificators.Clear();
        }
    
    }

}
