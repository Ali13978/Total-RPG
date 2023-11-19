using UnityEngine;

namespace TzarGames.Common
{
    [Serializable]
    public class SerializableData : IReadableData
    {
        // Fields
        [UnityEngine.SerializeField]
        private System.Collections.Generic.List<TzarGames.Common.SerializableData.StringInfo> strings;
        [UnityEngine.SerializeField]
        private System.Collections.Generic.List<TzarGames.Common.SerializableData.FloatInfo> floats;
        [UnityEngine.SerializeField]
        private System.Collections.Generic.List<TzarGames.Common.SerializableData.ObscuredFloatInfo> obscuredFloats;
        [UnityEngine.SerializeField]
        private System.Collections.Generic.List<TzarGames.Common.SerializableData.IntInfo> ints;
        
        // Methods
        public SerializableData()
        {
            this.strings = new System.Collections.Generic.List<StringInfo>();
            this.floats = new System.Collections.Generic.List<FloatInfo>();
            this.obscuredFloats = new System.Collections.Generic.List<ObscuredFloatInfo>();
            this.ints = new System.Collections.Generic.List<IntInfo>();
        }
        public TzarGames.Common.SerializableData MakeCopy()
        {
            AddRange(collection:  this.strings);
            AddRange(collection:  this.floats);
            TzarGames.Common.SerializableData.__il2cppRuntimeField_this_arg.AddRange(collection:  this.ints);
            TzarGames.Common.SerializableData.__il2cppRuntimeField_byval_arg.AddRange(collection:  this.obscuredFloats);
            return (TzarGames.Common.SerializableData)new TzarGames.Common.SerializableData();
        }
        public void Clear()
        {
            this.strings.Clear();
            this.floats.Clear();
            this.ints.Clear();
            this.obscuredFloats.Clear();
        }
        public void CopyFrom(TzarGames.Common.SerializableData data)
        {
            this.strings.AddRange(collection:  data.strings);
            this.floats.AddRange(collection:  data.floats);
            this.ints.AddRange(collection:  data.ints);
            this.obscuredFloats.AddRange(collection:  data.obscuredFloats);
        }
        private static void set<T, K>(string id, T valueToWrite, System.Collections.Generic.List<K> database)
        {
            var val_2 = 0;
            label_7:
            if(val_2 >= __RuntimeMethodHiddenParam)
            {
                goto label_2;
            }
            
            val_2 = val_2 + 1;
            if((System.String.op_Equality(a:  0, b:  __RuntimeMethodHiddenParam + 16)) == false)
            {
                goto label_7;
            }
            
            mem2[0] = database;
            return;
            label_2:
            if(0 != 0)
            {
                    mem[16] = valueToWrite;
            }
            else
            {
                    mem[16] = valueToWrite;
            }
            
            mem[24] = database;
            if(__RuntimeMethodHiddenParam == 0)
            {
                
            }
        
        }
        private static bool hasKey<T, K>(string id, System.Collections.Generic.List<K> database)
        {
            var val_3;
            var val_3 = 0;
            label_7:
            if(val_3 >= __RuntimeMethodHiddenParam)
            {
                goto label_2;
            }
            
            val_3 = val_3 + 1;
            if((System.String.op_Equality(a:  0, b:  __RuntimeMethodHiddenParam + 16)) == false)
            {
                goto label_7;
            }
            
            val_3 = 1;
            return (bool)val_3;
            label_2:
            val_3 = 0;
            return (bool)val_3;
        }
        private static T get<T, K>(string id, System.Collections.Generic.List<K> database)
        {
            var val_2;
            var val_2 = 0;
            label_7:
            if(val_2 >= __RuntimeMethodHiddenParam)
            {
                goto label_2;
            }
            
            val_2 = val_2 + 1;
            if((System.String.op_Equality(a:  0, b:  __RuntimeMethodHiddenParam + 16)) == false)
            {
                goto label_7;
            }
            
            val_2 = mem[__RuntimeMethodHiddenParam + 24];
            val_2 = __RuntimeMethodHiddenParam + 24;
            return (object)val_2;
            label_2:
            val_2 = 0;
            return (object)val_2;
        }
        private static void deleteKey<T, K>(string id, System.Collections.Generic.List<K> database)
        {
            var val_12;
            var val_13;
            var val_14;
            val_12 = __RuntimeMethodHiddenParam;
            val_13 = database;
            val_14 = 1152921504608284672;
            var val_12 = 0;
            do
            {
                if(val_12 >= val_12)
            {
                    return;
            }
            
                val_12 = val_12 + 1;
            }
            while((System.String.op_Equality(a:  0, b:  __RuntimeMethodHiddenParam + 16)) == false);
            
            val_12 = ???;
            val_13 = ???;
            val_14 = ???;
            goto X3 + 48 + 16;
        }
        public bool HasString(string id)
        {
            return TzarGames.Common.SerializableData.hasKey<System.String, StringInfo>(id:  0, database:  id);
        }
        public string GetString(string id)
        {
            return TzarGames.Common.SerializableData.get<System.String, StringInfo>(id:  0, database:  id);
        }
        public void SetString(string id, string stringValue)
        {
            TzarGames.Common.SerializableData.set<System.String, StringInfo>(id:  0, valueToWrite:  id, database:  stringValue);
        }
        public void DeleteString(string id)
        {
            TzarGames.Common.SerializableData.deleteKey<System.String, StringInfo>(id:  0, database:  id);
        }
        private void checkFloatKey(string id)
        {
            System.Collections.Generic.List<K> val_7;
            if((TzarGames.Common.SerializableData.hasKey<System.Single, System.Object>(id:  0, database:  id)) == false)
            {
                    return;
            }
            
            float val_2 = TzarGames.Common.SerializableData.get<System.Single, System.Object>(id:  0, database:  id);
            CodeStage.AntiCheat.ObscuredTypes.ObscuredFloat val_3 = CodeStage.AntiCheat.ObscuredTypes.ObscuredFloat.op_Implicit(value:  val_2);
            CodeStage.AntiCheat.ObscuredTypes.ObscuredFloat val_6 = CodeStage.AntiCheat.ObscuredTypes.ObscuredFloat.op_Implicit(value:  val_2);
            TzarGames.Common.SerializableData.set<CodeStage.AntiCheat.ObscuredTypes.ObscuredFloat, System.Object>(id:  0, valueToWrite:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredFloat() {currentCryptoKey = id, hiddenValue = new CodeStage.AntiCheat.Common.ACTkByte4() {b1 = id, b2 = id, b3 = id, b4 = id}, hiddenValueOld = id, inited = id, fakeValue = id, fakeValueActive = id}, database:  val_7);
            TzarGames.Common.SerializableData.deleteKey<System.Single, System.Object>(id:  0, database:  id);
        }
        public bool HasFloat(string id)
        {
            this.checkFloatKey(id:  id);
            return TzarGames.Common.SerializableData.hasKey<CodeStage.AntiCheat.ObscuredTypes.ObscuredFloat, System.Object>(id:  0, database:  id);
        }
        public float GetFloat(string id)
        {
            this.checkFloatKey(id:  id);
            CodeStage.AntiCheat.ObscuredTypes.ObscuredFloat val_1 = TzarGames.Common.SerializableData.get<CodeStage.AntiCheat.ObscuredTypes.ObscuredFloat, System.Object>(id:  0, database:  id);
            return (float)CodeStage.AntiCheat.ObscuredTypes.ObscuredFloat.op_Implicit(value:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredFloat() {hiddenValue = new CodeStage.AntiCheat.Common.ACTkByte4(), inited = false, fakeValueActive = false});
        }
        public void SetFloat(string id, float val)
        {
            System.Collections.Generic.List<K> val_2;
            this.checkFloatKey(id:  id);
            CodeStage.AntiCheat.ObscuredTypes.ObscuredFloat val_1 = CodeStage.AntiCheat.ObscuredTypes.ObscuredFloat.op_Implicit(value:  val);
            TzarGames.Common.SerializableData.set<CodeStage.AntiCheat.ObscuredTypes.ObscuredFloat, System.Object>(id:  0, valueToWrite:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredFloat() {currentCryptoKey = id, hiddenValue = new CodeStage.AntiCheat.Common.ACTkByte4() {b1 = id, b2 = id, b3 = id, b4 = id}, hiddenValueOld = id, inited = id, fakeValue = id, fakeValueActive = id}, database:  val_2);
        }
        public void DeleteFloat(string id)
        {
            this.checkFloatKey(id:  id);
            TzarGames.Common.SerializableData.deleteKey<CodeStage.AntiCheat.ObscuredTypes.ObscuredFloat, System.Object>(id:  0, database:  id);
        }
        public bool HasInt(string id)
        {
            return TzarGames.Common.SerializableData.hasKey<CodeStage.AntiCheat.ObscuredTypes.ObscuredInt, System.Object>(id:  0, database:  id);
        }
        public int GetInt(string id)
        {
            CodeStage.AntiCheat.ObscuredTypes.ObscuredInt val_1 = TzarGames.Common.SerializableData.get<CodeStage.AntiCheat.ObscuredTypes.ObscuredInt, System.Object>(id:  0, database:  id);
            return (int)CodeStage.AntiCheat.ObscuredTypes.ObscuredInt.op_Implicit(value:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {inited = true, fakeValue = 268435457, fakeValueActive = false});
        }
        public void SetInt(string id, int val)
        {
            CodeStage.AntiCheat.ObscuredTypes.ObscuredInt val_1 = CodeStage.AntiCheat.ObscuredTypes.ObscuredInt.op_Implicit(value:  0);
            TzarGames.Common.SerializableData.set<CodeStage.AntiCheat.ObscuredTypes.ObscuredInt, System.Object>(id:  0, valueToWrite:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {currentCryptoKey = id, hiddenValue = id, inited = false, fakeValue = 268435457, fakeValueActive = this.ints}, database:  static System.Void TzarGames.Common.SerializableData::set<CodeStage.AntiCheat.ObscuredTypes.ObscuredInt, IntInfo>(string id, CodeStage.AntiCheat.ObscuredTypes.ObscuredInt valueToWrite, System.Collections.Generic.List<K> database));
        }
        public void DeleteInt(string id)
        {
            TzarGames.Common.SerializableData.deleteKey<CodeStage.AntiCheat.ObscuredTypes.ObscuredInt, System.Object>(id:  0, database:  id);
        }
    
    }

}
