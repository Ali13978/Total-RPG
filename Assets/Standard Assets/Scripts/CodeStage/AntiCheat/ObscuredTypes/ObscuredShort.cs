using UnityEngine;

namespace CodeStage.AntiCheat.ObscuredTypes
{
    [Serializable]
    public struct ObscuredShort : IEquatable<CodeStage.AntiCheat.ObscuredTypes.ObscuredShort>, IFormattable
    {
        // Fields
        private static short cryptoKey;
        [UnityEngine.SerializeField]
        private short currentCryptoKey;
        [UnityEngine.SerializeField]
        private short hiddenValue;
        [UnityEngine.SerializeField]
        private bool inited;
        [UnityEngine.SerializeField]
        private short fakeValue;
        [UnityEngine.SerializeField]
        private bool fakeValueActive;
        
        // Methods
        private ObscuredShort(short value)
        {
        
        }
        public static void SetNewCryptoKey(short newKey)
        {
            null = null;
            CodeStage.AntiCheat.ObscuredTypes.ObscuredShort.cryptoKey = W1;
        }
        public static short EncryptDecrypt(short value)
        {
            return CodeStage.AntiCheat.ObscuredTypes.ObscuredShort.EncryptDecrypt(value:  32768, key:  W1);
        }
        public static short EncryptDecrypt(short value, short key)
        {
            short val_3;
            var val_4;
            val_3 = W2;
            if((val_3 & 65535) != 0)
            {
                    return (short)val_3 ^ key;
            }
            
            val_4 = null;
            val_4 = null;
            val_3 = CodeStage.AntiCheat.ObscuredTypes.ObscuredShort.cryptoKey;
            return (short)val_3 ^ key;
        }
        public void ApplyNewCryptoKey()
        {
            do
            {
                int val_1 = UnityEngine.Random.Range(min:  0, max:  -32768);
                mem[1152921510097388224] = val_1;
            }
            while((val_1 & 65535) == 0);
            
            .hiddenValue = CodeStage.AntiCheat.ObscuredTypes.ObscuredShort.EncryptDecrypt(value:  32768, key:  704);
        }
        public void RandomizeCryptoKey()
        {
        
        }
        public short GetEncrypted()
        {
            return (short)1152921510097612224;
        }
        public void SetEncrypted(short encrypted)
        {
        
        }
        public short GetDecrypted()
        {
        
        }
        private short InternalDecrypt()
        {
        
        }
        public static CodeStage.AntiCheat.ObscuredTypes.ObscuredShort op_Implicit(short value)
        {
            return new CodeStage.AntiCheat.ObscuredTypes.ObscuredShort() {inited = false, fakeValueActive = false};
        }
        public static short op_Implicit(CodeStage.AntiCheat.ObscuredTypes.ObscuredShort value)
        {
            return (short);
        }
        public static CodeStage.AntiCheat.ObscuredTypes.ObscuredShort op_Increment(CodeStage.AntiCheat.ObscuredTypes.ObscuredShort input)
        {
            var val_3;
            var val_4;
            val_3;
            val_3 = null;
            short val_1 = CodeStage.AntiCheat.ObscuredTypes.ObscuredShort.EncryptDecrypt(value:  32768);
            if(CodeStage.AntiCheat.Detectors.ObscuredCheatingDetector.IsRunning != false)
            {
                    val_4 = 1;
                return new CodeStage.AntiCheat.ObscuredTypes.ObscuredShort() {currentCryptoKey = input.fakeValueActive, hiddenValue = input.fakeValueActive, inited = input.fakeValueActive, fakeValue = input.fakeValueActive, fakeValueActive = false};
            }
            
            val_4 = 0;
            return new CodeStage.AntiCheat.ObscuredTypes.ObscuredShort() {currentCryptoKey = input.fakeValueActive, hiddenValue = input.fakeValueActive, inited = input.fakeValueActive, fakeValue = input.fakeValueActive, fakeValueActive = false};
        }
        public static CodeStage.AntiCheat.ObscuredTypes.ObscuredShort op_Decrement(CodeStage.AntiCheat.ObscuredTypes.ObscuredShort input)
        {
            var val_3;
            var val_4;
            val_3;
            var val_1 = 65535 + val_3;
            val_3 = null;
            short val_2 = CodeStage.AntiCheat.ObscuredTypes.ObscuredShort.EncryptDecrypt(value:  32768);
            if(CodeStage.AntiCheat.Detectors.ObscuredCheatingDetector.IsRunning != false)
            {
                    val_4 = 1;
                return new CodeStage.AntiCheat.ObscuredTypes.ObscuredShort() {currentCryptoKey = input.fakeValueActive, hiddenValue = input.fakeValueActive, inited = input.fakeValueActive, fakeValue = input.fakeValueActive, fakeValueActive = false};
            }
            
            val_4 = 0;
            return new CodeStage.AntiCheat.ObscuredTypes.ObscuredShort() {currentCryptoKey = input.fakeValueActive, hiddenValue = input.fakeValueActive, inited = input.fakeValueActive, fakeValue = input.fakeValueActive, fakeValueActive = false};
        }
        public override bool Equals(object obj)
        {
        
        }
        public bool Equals(CodeStage.AntiCheat.ObscuredTypes.ObscuredShort obj)
        {
            obj.fakeValueActive = obj.fakeValueActive & 65535;
        }
        public override string ToString()
        {
            return 1196914110;
        }
        public string ToString(string format)
        {
            return (string)1152921510098860608.ToString(format:  format);
        }
        public override int GetHashCode()
        {
            return (int)1152921510098980800.GetHashCode();
        }
        public string ToString(System.IFormatProvider provider)
        {
            return 1197270574;
        }
        public string ToString(string format, System.IFormatProvider provider)
        {
            return 1197394862;
        }
        private static ObscuredShort()
        {
            CodeStage.AntiCheat.ObscuredTypes.ObscuredShort.cryptoKey = 214;
        }
    
    }

}
