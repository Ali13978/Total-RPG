using UnityEngine;

namespace CodeStage.AntiCheat.ObscuredTypes
{
    [Serializable]
    public struct ObscuredInt : IEquatable<CodeStage.AntiCheat.ObscuredTypes.ObscuredInt>, IFormattable
    {
        // Fields
        private static int cryptoKey;
        [UnityEngine.SerializeField]
        private int currentCryptoKey;
        [UnityEngine.SerializeField]
        private int hiddenValue;
        [UnityEngine.SerializeField]
        private bool inited;
        [UnityEngine.SerializeField]
        private int fakeValue;
        [UnityEngine.SerializeField]
        private bool fakeValueActive;
        
        // Methods
        private ObscuredInt(int value)
        {
        
        }
        public static void SetNewCryptoKey(int newKey)
        {
            null = null;
            CodeStage.AntiCheat.ObscuredTypes.ObscuredInt.cryptoKey = W1;
        }
        public static int Encrypt(int value)
        {
            return CodeStage.AntiCheat.ObscuredTypes.ObscuredInt.Encrypt(value:  229978112, key:  W1);
        }
        public static int Encrypt(int value, int key)
        {
            int val_2;
            var val_3;
            val_2 = W2;
            if(val_2 != 0)
            {
                    return (int)val_2 ^ key;
            }
            
            val_3 = null;
            val_3 = null;
            val_2 = CodeStage.AntiCheat.ObscuredTypes.ObscuredInt.cryptoKey;
            return (int)val_2 ^ key;
        }
        public static int Decrypt(int value)
        {
            return CodeStage.AntiCheat.ObscuredTypes.ObscuredInt.Decrypt(value:  229978112, key:  W1);
        }
        public static int Decrypt(int value, int key)
        {
            int val_2;
            var val_3;
            val_2 = W2;
            if(val_2 != 0)
            {
                    return (int)val_2 ^ key;
            }
            
            val_3 = null;
            val_3 = null;
            val_2 = CodeStage.AntiCheat.ObscuredTypes.ObscuredInt.cryptoKey;
            return (int)val_2 ^ key;
        }
        public void ApplyNewCryptoKey()
        {
            mem2[0] = this.fakeValueActive;
            do
            {
                int val_1 = UnityEngine.Random.Range(min:  0, max:  -2147483648);
                mem2[0] = val_1;
            }
            while(val_1 == 0);
            
            mem2[0] = CodeStage.AntiCheat.ObscuredTypes.ObscuredInt.Encrypt(value:  229978112, key:  this.fakeValueActive + 4);
        }
        public void RandomizeCryptoKey()
        {
        
        }
        public int GetEncrypted()
        {
            return (int)this.fakeValueActive;
        }
        public void SetEncrypted(int encrypted)
        {
        
        }
        public int GetDecrypted()
        {
        
        }
        private int InternalDecrypt()
        {
        
        }
        public static CodeStage.AntiCheat.ObscuredTypes.ObscuredInt op_Implicit(int value)
        {
            mem2[0] = 0;
            mem2[0] = 0;
            mem2[0] = 0;
        }
        public static int op_Implicit(CodeStage.AntiCheat.ObscuredTypes.ObscuredInt value)
        {
        
        }
        public static CodeStage.AntiCheat.ObscuredTypes.ObscuredFloat op_Implicit(CodeStage.AntiCheat.ObscuredTypes.ObscuredInt value)
        {
            val_0.inited = false;
            mem[1152921510069825185] = 0;
            val_0.fakeValueActive = false;
            mem[1152921510069825193] = 0;
            val_0.currentCryptoKey = 0;
            val_0.hiddenValue.b1 = 0;
            val_0.hiddenValue.b2 = 0;
            val_0.hiddenValue.b3 = 0;
            val_0.hiddenValue.b4 = 0;
            val_0.hiddenValueOld = 0;
        }
        public static CodeStage.AntiCheat.ObscuredTypes.ObscuredDouble op_Implicit(CodeStage.AntiCheat.ObscuredTypes.ObscuredInt value)
        {
            val_0.fakeValue = 0;
            val_0.fakeValueActive = false;
            mem[1152921510070018937] = 0;
            val_0.hiddenValueOld = 0;
            val_0.inited = false;
            mem[1152921510070018921] = 0;
            val_0.currentCryptoKey = 0;
            val_0.hiddenValue.b1 = 0;
            val_0.hiddenValue.b2 = 0;
            val_0.hiddenValue.b3 = 0;
            val_0.hiddenValue.b4 = 0;
            val_0.hiddenValue.b5 = 0;
            val_0.hiddenValue.b6 = 0;
            val_0.hiddenValue.b7 = 0;
            val_0.hiddenValue.b8 = 0;
        }
        public static CodeStage.AntiCheat.ObscuredTypes.ObscuredUInt op_Explicit(CodeStage.AntiCheat.ObscuredTypes.ObscuredInt value)
        {
            mem2[0] = 0;
            mem2[0] = 0;
            mem2[0] = 0;
        }
        public static CodeStage.AntiCheat.ObscuredTypes.ObscuredInt op_Increment(CodeStage.AntiCheat.ObscuredTypes.ObscuredInt input)
        {
            var val_4;
            var val_5;
            val_4 = input.inited;
            bool val_1 = val_4 + 1;
            val_4 = null;
            mem2[0] = CodeStage.AntiCheat.ObscuredTypes.ObscuredInt.Encrypt(value:  229978112, key:  val_1);
            bool val_3 = CodeStage.AntiCheat.Detectors.ObscuredCheatingDetector.IsRunning;
            if(val_3 != false)
            {
                    val_5 = 1;
                mem2[0] = val_1;
            }
            else
            {
                    val_5 = 0;
            }
            
            mem2[0] = val_5;
            mem2[0] = input.inited + 16;
            mem2[0] = input.inited;
            return new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {currentCryptoKey = val_3, hiddenValue = val_3, inited = val_1, fakeValue = val_1, fakeValueActive = input.inited};
        }
        public static CodeStage.AntiCheat.ObscuredTypes.ObscuredInt op_Decrement(CodeStage.AntiCheat.ObscuredTypes.ObscuredInt input)
        {
            var val_4;
            var val_5;
            val_4 = input.inited;
            bool val_1 = val_4 - 1;
            val_4 = null;
            mem2[0] = CodeStage.AntiCheat.ObscuredTypes.ObscuredInt.Encrypt(value:  229978112, key:  val_1);
            bool val_3 = CodeStage.AntiCheat.Detectors.ObscuredCheatingDetector.IsRunning;
            if(val_3 != false)
            {
                    val_5 = 1;
                mem2[0] = val_1;
            }
            else
            {
                    val_5 = 0;
            }
            
            mem2[0] = val_5;
            mem2[0] = input.inited + 16;
            mem2[0] = input.inited;
            return new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {currentCryptoKey = val_3, hiddenValue = val_3, inited = val_1, fakeValue = val_1, fakeValueActive = input.inited};
        }
        public override bool Equals(object obj)
        {
        
        }
        public bool Equals(CodeStage.AntiCheat.ObscuredTypes.ObscuredInt obj)
        {
            return (bool)this.fakeValueActive;
        }
        public override int GetHashCode()
        {
            return (int)this.fakeValueActive.Status;
        }
        public override string ToString()
        {
            return 1169001852;
        }
        public string ToString(string format)
        {
            return (string)this.fakeValueActive.ToString(format:  format);
        }
        public string ToString(System.IFormatProvider provider)
        {
            return 1169246316;
        }
        public string ToString(string format, System.IFormatProvider provider)
        {
            return 1169370604;
        }
        private static ObscuredInt()
        {
            CodeStage.AntiCheat.ObscuredTypes.ObscuredInt.cryptoKey = 444444;
        }
    
    }

}
