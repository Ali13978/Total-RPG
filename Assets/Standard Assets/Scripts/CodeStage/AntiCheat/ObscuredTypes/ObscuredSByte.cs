using UnityEngine;

namespace CodeStage.AntiCheat.ObscuredTypes
{
    [Serializable]
    public struct ObscuredSByte : IEquatable<CodeStage.AntiCheat.ObscuredTypes.ObscuredSByte>, IFormattable
    {
        // Fields
        private static sbyte cryptoKey;
        private sbyte currentCryptoKey;
        private sbyte hiddenValue;
        private bool inited;
        private sbyte fakeValue;
        private bool fakeValueActive;
        
        // Methods
        private ObscuredSByte(sbyte value)
        {
        
        }
        public static void SetNewCryptoKey(sbyte newKey)
        {
            null = null;
            CodeStage.AntiCheat.ObscuredTypes.ObscuredSByte.cryptoKey = W1;
        }
        public static sbyte EncryptDecrypt(sbyte value)
        {
            return CodeStage.AntiCheat.ObscuredTypes.ObscuredSByte.EncryptDecrypt(value:  0, key:  W1);
        }
        public static sbyte EncryptDecrypt(sbyte value, sbyte key)
        {
            sbyte val_3;
            var val_4;
            val_3 = W2;
            if((val_3 & 255) != 0)
            {
                    return (sbyte)val_3 ^ key;
            }
            
            val_4 = null;
            val_4 = null;
            val_3 = CodeStage.AntiCheat.ObscuredTypes.ObscuredSByte.cryptoKey;
            return (sbyte)val_3 ^ key;
        }
        public void ApplyNewCryptoKey()
        {
            do
            {
                int val_1 = UnityEngine.Random.Range(min:  0, max:  -128);
                mem[1152921510094875072] = val_1;
            }
            while((val_1 & 255) == 0);
            
            .hiddenValue = CodeStage.AntiCheat.ObscuredTypes.ObscuredSByte.EncryptDecrypt(value:  0, key:  192);
        }
        public void RandomizeCryptoKey()
        {
        
        }
        public sbyte GetEncrypted()
        {
            return (sbyte)1152921510095099072;
        }
        public void SetEncrypted(sbyte encrypted)
        {
        
        }
        public sbyte GetDecrypted()
        {
        
        }
        private sbyte InternalDecrypt()
        {
        
        }
        public static CodeStage.AntiCheat.ObscuredTypes.ObscuredSByte op_Implicit(sbyte value)
        {
            return new CodeStage.AntiCheat.ObscuredTypes.ObscuredSByte() {inited = false, fakeValueActive = false};
        }
        public static sbyte op_Implicit(CodeStage.AntiCheat.ObscuredTypes.ObscuredSByte value)
        {
            var val_1 = X1 >> 32;
            return 1193832760;
        }
        public static CodeStage.AntiCheat.ObscuredTypes.ObscuredSByte op_Increment(CodeStage.AntiCheat.ObscuredTypes.ObscuredSByte input)
        {
            var val_4;
            var val_5;
            var val_1 = X1 >> 32;
            val_4 = null;
            sbyte val_2 = CodeStage.AntiCheat.ObscuredTypes.ObscuredSByte.EncryptDecrypt(value:  0, key:  169);
            if(CodeStage.AntiCheat.Detectors.ObscuredCheatingDetector.IsRunning != false)
            {
                    val_5 = 1;
                return new CodeStage.AntiCheat.ObscuredTypes.ObscuredSByte() {currentCryptoKey = ???, hiddenValue = ???, inited = ???, fakeValue = ???, fakeValueActive = false};
            }
            
            val_5 = 0;
            return new CodeStage.AntiCheat.ObscuredTypes.ObscuredSByte() {currentCryptoKey = ???, hiddenValue = ???, inited = ???, fakeValue = ???, fakeValueActive = false};
        }
        public static CodeStage.AntiCheat.ObscuredTypes.ObscuredSByte op_Decrement(CodeStage.AntiCheat.ObscuredTypes.ObscuredSByte input)
        {
            var val_4;
            var val_5;
            var val_1 = X1 >> 32;
            val_4 = null;
            sbyte val_2 = CodeStage.AntiCheat.ObscuredTypes.ObscuredSByte.EncryptDecrypt(value:  0, key:  39);
            if(CodeStage.AntiCheat.Detectors.ObscuredCheatingDetector.IsRunning != false)
            {
                    val_5 = 1;
                return new CodeStage.AntiCheat.ObscuredTypes.ObscuredSByte() {currentCryptoKey = ???, hiddenValue = ???, inited = ???, fakeValue = ???, fakeValueActive = false};
            }
            
            val_5 = 0;
            return new CodeStage.AntiCheat.ObscuredTypes.ObscuredSByte() {currentCryptoKey = ???, hiddenValue = ???, inited = ???, fakeValue = ???, fakeValueActive = false};
        }
        public override bool Equals(object obj)
        {
        
        }
        public bool Equals(CodeStage.AntiCheat.ObscuredTypes.ObscuredSByte obj)
        {
            obj.currentCryptoKey = obj.currentCryptoKey & 1099511627775;
        }
        public override string ToString()
        {
            return 1194400959;
        }
        public string ToString(string format)
        {
            return (string)1152921510096347456.ToString(format:  format);
        }
        public override int GetHashCode()
        {
            return (int)1152921510096467648.GetHashCode();
        }
        public string ToString(System.IFormatProvider provider)
        {
            return 1194757423;
        }
        public string ToString(string format, System.IFormatProvider provider)
        {
            return 1194881711;
        }
        private static ObscuredSByte()
        {
            CodeStage.AntiCheat.ObscuredTypes.ObscuredSByte.cryptoKey = 112;
        }
    
    }

}
