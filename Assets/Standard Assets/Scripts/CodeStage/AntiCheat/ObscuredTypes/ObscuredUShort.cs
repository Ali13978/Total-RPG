using UnityEngine;

namespace CodeStage.AntiCheat.ObscuredTypes
{
    [Serializable]
    public struct ObscuredUShort : IEquatable<CodeStage.AntiCheat.ObscuredTypes.ObscuredUShort>, IFormattable
    {
        // Fields
        private static ushort cryptoKey;
        private ushort currentCryptoKey;
        private ushort hiddenValue;
        private bool inited;
        private ushort fakeValue;
        private bool fakeValueActive;
        
        // Methods
        private ObscuredUShort(ushort value)
        {
        
        }
        public static void SetNewCryptoKey(ushort newKey)
        {
            null = null;
            CodeStage.AntiCheat.ObscuredTypes.ObscuredUShort.cryptoKey = W1;
        }
        public static ushort EncryptDecrypt(ushort value)
        {
            return CodeStage.AntiCheat.ObscuredTypes.ObscuredUShort.EncryptDecrypt(value:  49152, key:  W1);
        }
        public static ushort EncryptDecrypt(ushort value, ushort key)
        {
            ushort val_3;
            var val_4;
            val_3 = W2;
            if((val_3 & 65535) != 0)
            {
                    return (ushort)val_3 ^ key;
            }
            
            val_4 = null;
            val_4 = null;
            val_3 = CodeStage.AntiCheat.ObscuredTypes.ObscuredUShort.cryptoKey;
            return (ushort)val_3 ^ key;
        }
        public void ApplyNewCryptoKey()
        {
            mem[1152921510110009936] = UnityEngine.Random.Range(min:  0, max:  1);
            .hiddenValue = CodeStage.AntiCheat.ObscuredTypes.ObscuredUShort.EncryptDecrypt(value:  49152, key:  39504);
        }
        public void RandomizeCryptoKey()
        {
        
        }
        public ushort GetEncrypted()
        {
            return (ushort)1152921510110233936;
        }
        public void SetEncrypted(ushort encrypted)
        {
        
        }
        public ushort GetDecrypted()
        {
        
        }
        private ushort InternalDecrypt()
        {
        
        }
        public static CodeStage.AntiCheat.ObscuredTypes.ObscuredUShort op_Implicit(ushort value)
        {
            return new CodeStage.AntiCheat.ObscuredTypes.ObscuredUShort() {inited = false, fakeValueActive = false};
        }
        public static ushort op_Implicit(CodeStage.AntiCheat.ObscuredTypes.ObscuredUShort value)
        {
            return (ushort);
        }
        public static CodeStage.AntiCheat.ObscuredTypes.ObscuredUShort op_Increment(CodeStage.AntiCheat.ObscuredTypes.ObscuredUShort input)
        {
            var val_3;
            var val_4;
            val_3;
            val_3 = null;
            ushort val_1 = CodeStage.AntiCheat.ObscuredTypes.ObscuredUShort.EncryptDecrypt(value:  49152, key:  5937);
            if(CodeStage.AntiCheat.Detectors.ObscuredCheatingDetector.IsRunning != false)
            {
                    val_4 = 1;
                return new CodeStage.AntiCheat.ObscuredTypes.ObscuredUShort() {currentCryptoKey = input.fakeValueActive, hiddenValue = input.fakeValueActive, inited = input.fakeValueActive, fakeValue = input.fakeValueActive, fakeValueActive = false};
            }
            
            val_4 = 0;
            return new CodeStage.AntiCheat.ObscuredTypes.ObscuredUShort() {currentCryptoKey = input.fakeValueActive, hiddenValue = input.fakeValueActive, inited = input.fakeValueActive, fakeValue = input.fakeValueActive, fakeValueActive = false};
        }
        public static CodeStage.AntiCheat.ObscuredTypes.ObscuredUShort op_Decrement(CodeStage.AntiCheat.ObscuredTypes.ObscuredUShort input)
        {
            var val_3;
            var val_4;
            val_3;
            val_3 = null;
            ushort val_2 = CodeStage.AntiCheat.ObscuredTypes.ObscuredUShort.EncryptDecrypt(value:  49152, key:  65535 + val_3);
            if(CodeStage.AntiCheat.Detectors.ObscuredCheatingDetector.IsRunning != false)
            {
                    val_4 = 1;
                return new CodeStage.AntiCheat.ObscuredTypes.ObscuredUShort() {currentCryptoKey = input.fakeValueActive, hiddenValue = input.fakeValueActive, inited = input.fakeValueActive, fakeValue = input.fakeValueActive, fakeValueActive = false};
            }
            
            val_4 = 0;
            return new CodeStage.AntiCheat.ObscuredTypes.ObscuredUShort() {currentCryptoKey = input.fakeValueActive, hiddenValue = input.fakeValueActive, inited = input.fakeValueActive, fakeValue = input.fakeValueActive, fakeValueActive = false};
        }
        public override bool Equals(object obj)
        {
        
        }
        public bool Equals(CodeStage.AntiCheat.ObscuredTypes.ObscuredUShort obj)
        {
            obj.fakeValueActive = obj.fakeValueActive & 65535;
        }
        public override string ToString()
        {
            return 1209535822;
        }
        public string ToString(string format)
        {
            return (string)1152921510111482320.ToString(format:  format);
        }
        public override int GetHashCode()
        {
            return (int)1152921510111602512.GetHashCode();
        }
        public string ToString(System.IFormatProvider provider)
        {
            return 1209892286;
        }
        public string ToString(string format, System.IFormatProvider provider)
        {
            return 1210016574;
        }
        private static ObscuredUShort()
        {
            CodeStage.AntiCheat.ObscuredTypes.ObscuredUShort.cryptoKey = 224;
        }
    
    }

}
