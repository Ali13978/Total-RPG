using UnityEngine;

namespace CodeStage.AntiCheat.ObscuredTypes
{
    [Serializable]
    public struct ObscuredFloat : IEquatable<CodeStage.AntiCheat.ObscuredTypes.ObscuredFloat>, IFormattable
    {
        // Fields
        private static int cryptoKey;
        [UnityEngine.SerializeField]
        private int currentCryptoKey;
        [UnityEngine.SerializeField]
        private CodeStage.AntiCheat.Common.ACTkByte4 hiddenValue;
        [UnityEngine.SerializeField]
        [UnityEngine.Serialization.FormerlySerializedAsAttribute]
        private byte[] hiddenValueOld;
        [UnityEngine.SerializeField]
        private bool inited;
        [UnityEngine.SerializeField]
        private float fakeValue;
        [UnityEngine.SerializeField]
        private bool fakeValueActive;
        
        // Methods
        private ObscuredFloat(float value)
        {
        
        }
        public static void SetNewCryptoKey(int newKey)
        {
            null = null;
            CodeStage.AntiCheat.ObscuredTypes.ObscuredFloat.cryptoKey = W1;
        }
        public static int Encrypt(float value)
        {
            null = null;
            return (int)CodeStage.AntiCheat.ObscuredTypes.ObscuredFloat.cryptoKey ^ value;
        }
        public static int Encrypt(float value, int key)
        {
            return (int)value ^ W1;
        }
        private static CodeStage.AntiCheat.Common.ACTkByte4 InternalEncrypt(float value)
        {
            CodeStage.AntiCheat.Common.ACTkByte4 val_1 = CodeStage.AntiCheat.ObscuredTypes.ObscuredFloat.InternalEncrypt(value:  value, key:  229871616);
            val_1.b1 = val_1.b1 & 4294967295;
            return new CodeStage.AntiCheat.Common.ACTkByte4() {b1 = val_1.b1, b2 = val_1.b1, b3 = val_1.b1, b4 = val_1.b1};
        }
        private static CodeStage.AntiCheat.Common.ACTkByte4 InternalEncrypt(float value, int key)
        {
            int val_2;
            var val_3;
            val_2 = W1;
            if(val_2 != 0)
            {
                    return new CodeStage.AntiCheat.Common.ACTkByte4() {b1 = val_2 ^ value, b2 = val_2 ^ value, b3 = val_2 ^ value, b4 = val_2 ^ value};
            }
            
            val_3 = null;
            val_3 = null;
            val_2 = CodeStage.AntiCheat.ObscuredTypes.ObscuredFloat.cryptoKey;
            return new CodeStage.AntiCheat.Common.ACTkByte4() {b1 = val_2 ^ value, b2 = val_2 ^ value, b3 = val_2 ^ value, b4 = val_2 ^ value};
        }
        public static float Decrypt(int value)
        {
            null = null;
            int val_1 = CodeStage.AntiCheat.ObscuredTypes.ObscuredFloat.cryptoKey;
            val_1 = val_1 ^ W1;
            return (float)val_1;
        }
        public static float Decrypt(int value, int key)
        {
            return (float)W2 ^ key;
        }
        public void ApplyNewCryptoKey()
        {
            do
            {
                int val_1 = UnityEngine.Random.Range(min:  0, max:  -2147483648);
                mem2[0] = val_1;
            }
            while(val_1 == 0);
            
            CodeStage.AntiCheat.Common.ACTkByte4 val_2 = CodeStage.AntiCheat.ObscuredTypes.ObscuredFloat.InternalEncrypt(value:  V0.16B, key:  229871616);
            mem2[0] = val_2.b1;
            mem[1] = val_2.b2;
            mem[2] = val_2.b3;
            mem[3] = val_2.b4;
        }
        public void RandomizeCryptoKey()
        {
        
        }
        public int GetEncrypted()
        {
            return (int)this.fakeValue;
        }
        public void SetEncrypted(int encrypted)
        {
        
        }
        public float GetDecrypted()
        {
        
        }
        private float InternalDecrypt()
        {
        
        }
        public static CodeStage.AntiCheat.ObscuredTypes.ObscuredFloat op_Implicit(float value)
        {
            val_0.inited = false;
            mem[1152921510066283105] = 0;
            val_0.fakeValueActive = false;
            mem[1152921510066283113] = 0;
            val_0.currentCryptoKey = 0;
            val_0.hiddenValue.b1 = 0;
            val_0.hiddenValue.b2 = 0;
            val_0.hiddenValue.b3 = 0;
            val_0.hiddenValue.b4 = 0;
            val_0.hiddenValueOld = 0;
        }
        public static float op_Implicit(CodeStage.AntiCheat.ObscuredTypes.ObscuredFloat value)
        {
        
        }
        public static CodeStage.AntiCheat.ObscuredTypes.ObscuredFloat op_Increment(CodeStage.AntiCheat.ObscuredTypes.ObscuredFloat input)
        {
            var val_4;
            CodeStage.AntiCheat.ObscuredTypes.ObscuredFloat val_0;
            float val_1 = S0 + 1f;
            CodeStage.AntiCheat.Common.ACTkByte4 val_2 = CodeStage.AntiCheat.ObscuredTypes.ObscuredFloat.InternalEncrypt(value:  val_1, key:  229871616);
            mem2[0] = val_2.b1;
            mem[1] = val_2.b2;
            mem[2] = val_2.b3;
            mem[3] = val_2.b4;
            if(CodeStage.AntiCheat.Detectors.ObscuredCheatingDetector.IsRunning != false)
            {
                    val_4 = 1;
                mem2[0] = val_1;
            }
            else
            {
                    val_4 = 0;
            }
            
            mem2[0] = val_4;
            val_0.inited = X1 + 16;
            val_0.currentCryptoKey = X1;
            return val_0;
        }
        public static CodeStage.AntiCheat.ObscuredTypes.ObscuredFloat op_Decrement(CodeStage.AntiCheat.ObscuredTypes.ObscuredFloat input)
        {
            var val_4;
            CodeStage.AntiCheat.ObscuredTypes.ObscuredFloat val_0;
            float val_1 = S0 + (-1f);
            CodeStage.AntiCheat.Common.ACTkByte4 val_2 = CodeStage.AntiCheat.ObscuredTypes.ObscuredFloat.InternalEncrypt(value:  val_1, key:  229871616);
            mem2[0] = val_2.b1;
            mem[1] = val_2.b2;
            mem[2] = val_2.b3;
            mem[3] = val_2.b4;
            if(CodeStage.AntiCheat.Detectors.ObscuredCheatingDetector.IsRunning != false)
            {
                    val_4 = 1;
                mem2[0] = val_1;
            }
            else
            {
                    val_4 = 0;
            }
            
            mem2[0] = val_4;
            val_0.inited = X1 + 16;
            val_0.currentCryptoKey = X1;
            return val_0;
        }
        public override bool Equals(object obj)
        {
        
        }
        public bool Equals(CodeStage.AntiCheat.ObscuredTypes.ObscuredFloat obj)
        {
            return (bool)this.inited;
        }
        public override int GetHashCode()
        {
            return (int)???.Status;
        }
        public override string ToString()
        {
            return 1165757052;
        }
        public string ToString(string format)
        {
            return (string)???.ToString(format:  format);
        }
        public string ToString(System.IFormatProvider provider)
        {
            return 1166001516;
        }
        public string ToString(string format, System.IFormatProvider provider)
        {
            return 1166125804;
        }
        private static ObscuredFloat()
        {
            CodeStage.AntiCheat.ObscuredTypes.ObscuredFloat.cryptoKey = 230887;
        }
    
    }

}
