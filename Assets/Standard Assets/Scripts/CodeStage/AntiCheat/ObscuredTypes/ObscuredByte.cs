using UnityEngine;

namespace CodeStage.AntiCheat.ObscuredTypes
{
    [Serializable]
    public struct ObscuredByte : IEquatable<CodeStage.AntiCheat.ObscuredTypes.ObscuredByte>, IFormattable
    {
        // Fields
        private static byte cryptoKey;
        private byte currentCryptoKey;
        private byte hiddenValue;
        private bool inited;
        private byte fakeValue;
        private bool fakeValueActive;
        
        // Methods
        private ObscuredByte(byte value)
        {
        
        }
        public static void SetNewCryptoKey(byte newKey)
        {
            null = null;
            CodeStage.AntiCheat.ObscuredTypes.ObscuredByte.cryptoKey = W1;
        }
        public static byte EncryptDecrypt(byte value)
        {
            return CodeStage.AntiCheat.ObscuredTypes.ObscuredByte.EncryptDecrypt(value:  0, key:  W1);
        }
        public static byte EncryptDecrypt(byte value, byte key)
        {
            byte val_3;
            var val_4;
            val_3 = W2;
            if((val_3 & 255) != 0)
            {
                    return (byte)val_3 ^ key;
            }
            
            val_4 = null;
            val_4 = null;
            val_3 = CodeStage.AntiCheat.ObscuredTypes.ObscuredByte.cryptoKey;
            return (byte)val_3 ^ key;
        }
        public void ApplyNewCryptoKey()
        {
            mem[1152921510053565984] = UnityEngine.Random.Range(min:  0, max:  1);
            .hiddenValue = CodeStage.AntiCheat.ObscuredTypes.ObscuredByte.EncryptDecrypt(value:  0, key:  32);
        }
        public void RandomizeCryptoKey()
        {
        
        }
        public byte GetEncrypted()
        {
            return (byte)1152921510053789984;
        }
        public void SetEncrypted(byte encrypted)
        {
        
        }
        public byte GetDecrypted()
        {
        
        }
        private byte InternalDecrypt()
        {
        
        }
        public static CodeStage.AntiCheat.ObscuredTypes.ObscuredByte op_Implicit(byte value)
        {
            return new CodeStage.AntiCheat.ObscuredTypes.ObscuredByte() {inited = false, fakeValueActive = false};
        }
        public static byte op_Implicit(CodeStage.AntiCheat.ObscuredTypes.ObscuredByte value)
        {
            var val_1 = X1 >> 32;
            return 1152523672;
        }
        public static CodeStage.AntiCheat.ObscuredTypes.ObscuredByte op_Increment(CodeStage.AntiCheat.ObscuredTypes.ObscuredByte input)
        {
            var val_4;
            var val_5;
            var val_1 = X1 >> 32;
            val_4 = null;
            byte val_2 = CodeStage.AntiCheat.ObscuredTypes.ObscuredByte.EncryptDecrypt(value:  0, key:  9);
            if(CodeStage.AntiCheat.Detectors.ObscuredCheatingDetector.IsRunning != false)
            {
                    val_5 = 1;
                return new CodeStage.AntiCheat.ObscuredTypes.ObscuredByte() {currentCryptoKey = ???, hiddenValue = ???, inited = ???, fakeValue = ???, fakeValueActive = false};
            }
            
            val_5 = 0;
            return new CodeStage.AntiCheat.ObscuredTypes.ObscuredByte() {currentCryptoKey = ???, hiddenValue = ???, inited = ???, fakeValue = ???, fakeValueActive = false};
        }
        public static CodeStage.AntiCheat.ObscuredTypes.ObscuredByte op_Decrement(CodeStage.AntiCheat.ObscuredTypes.ObscuredByte input)
        {
            var val_4;
            var val_5;
            var val_1 = X1 >> 32;
            val_4 = null;
            byte val_2 = CodeStage.AntiCheat.ObscuredTypes.ObscuredByte.EncryptDecrypt(value:  0, key:  135);
            if(CodeStage.AntiCheat.Detectors.ObscuredCheatingDetector.IsRunning != false)
            {
                    val_5 = 1;
                return new CodeStage.AntiCheat.ObscuredTypes.ObscuredByte() {currentCryptoKey = ???, hiddenValue = ???, inited = ???, fakeValue = ???, fakeValueActive = false};
            }
            
            val_5 = 0;
            return new CodeStage.AntiCheat.ObscuredTypes.ObscuredByte() {currentCryptoKey = ???, hiddenValue = ???, inited = ???, fakeValue = ???, fakeValueActive = false};
        }
        public override bool Equals(object obj)
        {
        
        }
        public bool Equals(CodeStage.AntiCheat.ObscuredTypes.ObscuredByte obj)
        {
            obj.currentCryptoKey = obj.currentCryptoKey & 1099511627775;
        }
        public override string ToString()
        {
            return 1153091871;
        }
        public string ToString(string format)
        {
            return 1153207951;
        }
        public override int GetHashCode()
        {
            return (int)1152921510055150368.EnableSavedGames;
        }
        public string ToString(System.IFormatProvider provider)
        {
            return 1153440143;
        }
        public string ToString(string format, System.IFormatProvider provider)
        {
            return 1153564431;
        }
        private static ObscuredByte()
        {
            CodeStage.AntiCheat.ObscuredTypes.ObscuredByte.cryptoKey = 244;
        }
    
    }

}
