using UnityEngine;

namespace CodeStage.AntiCheat.ObscuredTypes
{
    [Serializable]
    public struct ObscuredBool : IEquatable<CodeStage.AntiCheat.ObscuredTypes.ObscuredBool>
    {
        // Fields
        private static byte cryptoKey;
        [UnityEngine.SerializeField]
        private byte currentCryptoKey;
        [UnityEngine.SerializeField]
        private int hiddenValue;
        [UnityEngine.SerializeField]
        private bool inited;
        [UnityEngine.SerializeField]
        private bool fakeValue;
        [UnityEngine.SerializeField]
        [UnityEngine.Serialization.FormerlySerializedAsAttribute]
        private bool fakeValueActive;
        
        // Methods
        private ObscuredBool(bool value)
        {
            bool val_1 = value;
        }
        public static void SetNewCryptoKey(byte newKey)
        {
            null = null;
            CodeStage.AntiCheat.ObscuredTypes.ObscuredBool.cryptoKey = W1;
        }
        public static int Encrypt(bool value)
        {
            return CodeStage.AntiCheat.ObscuredTypes.ObscuredBool.Encrypt(value:  false, key:  W1 & 1);
        }
        public static int Encrypt(bool value, byte key)
        {
            byte val_5;
            var val_6;
            val_5 = W2;
            if((val_5 & 255) != 0)
            {
                    return (int)(val_5 & 255) ^ ((key != 1) ? 213 : 181);
            }
            
            val_6 = null;
            val_6 = null;
            val_5 = CodeStage.AntiCheat.ObscuredTypes.ObscuredBool.cryptoKey;
            return (int)(val_5 & 255) ^ ((key != 1) ? 213 : 181);
        }
        public static bool Decrypt(int value)
        {
            return CodeStage.AntiCheat.ObscuredTypes.ObscuredBool.Decrypt(value:  229498880, key:  W1);
        }
        public static bool Decrypt(int value, byte key)
        {
            byte val_4;
            var val_5;
            val_4 = W2;
            if((val_4 & 255) == 0)
            {
                    val_5 = null;
                val_5 = null;
                val_4 = CodeStage.AntiCheat.ObscuredTypes.ObscuredBool.cryptoKey;
            }
            
            byte val_2 = val_4 & 255;
            val_2 = val_2 ^ key;
            return (bool)(val_2 != 181) ? 1 : 0;
        }
        public void ApplyNewCryptoKey()
        {
            mem[1152921510051653792] = UnityEngine.Random.Range(min:  0, max:  1);
            .hiddenValue = CodeStage.AntiCheat.ObscuredTypes.ObscuredBool.Encrypt(value:  false, key:  0);
        }
        public void RandomizeCryptoKey()
        {
        
        }
        public int GetEncrypted()
        {
            return (int)1152921510051877792;
        }
        public void SetEncrypted(int encrypted)
        {
        
        }
        public bool GetDecrypted()
        {
        
        }
        private bool InternalDecrypt()
        {
        
        }
        public static CodeStage.AntiCheat.ObscuredTypes.ObscuredBool op_Implicit(bool value)
        {
            var val_1 = W1 & 1;
            return new CodeStage.AntiCheat.ObscuredTypes.ObscuredBool() {inited = false, fakeValue = false, fakeValueActive = false};
        }
        public static bool op_Implicit(CodeStage.AntiCheat.ObscuredTypes.ObscuredBool value)
        {
            return false;
        }
        public override bool Equals(object obj)
        {
        
        }
        public bool Equals(CodeStage.AntiCheat.ObscuredTypes.ObscuredBool obj)
        {
            obj.inited = obj.inited & 4294967295;
        }
        public override int GetHashCode()
        {
            return (int)0.GetHashCode();
        }
        public override string ToString()
        {
            return 1151067679;
        }
        private static ObscuredBool()
        {
            CodeStage.AntiCheat.ObscuredTypes.ObscuredBool.cryptoKey = 215;
        }
    
    }

}
