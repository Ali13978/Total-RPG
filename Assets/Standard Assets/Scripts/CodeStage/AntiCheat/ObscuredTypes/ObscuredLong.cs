using UnityEngine;

namespace CodeStage.AntiCheat.ObscuredTypes
{
    [Serializable]
    public struct ObscuredLong : IEquatable<CodeStage.AntiCheat.ObscuredTypes.ObscuredLong>, IFormattable
    {
        // Fields
        private static long cryptoKey;
        [UnityEngine.SerializeField]
        private long currentCryptoKey;
        [UnityEngine.SerializeField]
        private long hiddenValue;
        [UnityEngine.SerializeField]
        private bool inited;
        [UnityEngine.SerializeField]
        private long fakeValue;
        [UnityEngine.SerializeField]
        private bool fakeValueActive;
        
        // Methods
        private ObscuredLong(long value)
        {
        
        }
        public static void SetNewCryptoKey(long newKey)
        {
            null = null;
            CodeStage.AntiCheat.ObscuredTypes.ObscuredLong.cryptoKey = X1;
        }
        public static long Encrypt(long value)
        {
            return CodeStage.AntiCheat.ObscuredTypes.ObscuredLong.Encrypt(value:  null, key:  X1);
        }
        public static long Decrypt(long value)
        {
            return CodeStage.AntiCheat.ObscuredTypes.ObscuredLong.Decrypt(value:  null, key:  X1);
        }
        public static long Encrypt(long value, long key)
        {
            long val_2;
            var val_3;
            val_2 = X2;
            if(val_2 != 0)
            {
                    return (long)val_2 ^ key;
            }
            
            val_3 = null;
            val_3 = null;
            val_2 = CodeStage.AntiCheat.ObscuredTypes.ObscuredLong.cryptoKey;
            return (long)val_2 ^ key;
        }
        public static long Decrypt(long value, long key)
        {
            long val_2;
            var val_3;
            val_2 = X2;
            if(val_2 != 0)
            {
                    return (long)val_2 ^ key;
            }
            
            val_3 = null;
            val_3 = null;
            val_2 = CodeStage.AntiCheat.ObscuredTypes.ObscuredLong.cryptoKey;
            return (long)val_2 ^ key;
        }
        public void ApplyNewCryptoKey()
        {
            do
            {
                int val_1 = UnityEngine.Random.Range(min:  0, max:  -2147483648);
                mem2[0] = (long)val_1;
            }
            while(val_1 == 0);
            
            mem2[0] = CodeStage.AntiCheat.ObscuredTypes.ObscuredLong.Encrypt(value:  null, key:  this.inited);
        }
        public void RandomizeCryptoKey()
        {
        
        }
        public long GetEncrypted()
        {
            return (long)this.fakeValue;
        }
        public void SetEncrypted(long encrypted)
        {
        
        }
        public long GetDecrypted()
        {
        
        }
        private long InternalDecrypt()
        {
        
        }
        public static CodeStage.AntiCheat.ObscuredTypes.ObscuredLong op_Implicit(long value)
        {
            val_0.fakeValue = 0;
            val_0.fakeValueActive = false;
            mem[1152921510072809137] = 0;
            val_0.hiddenValue = 0;
            val_0.inited = false;
            mem[1152921510072809121] = 0;
            val_0.currentCryptoKey = 0;
        }
        public static long op_Implicit(CodeStage.AntiCheat.ObscuredTypes.ObscuredLong value)
        {
        
        }
        public static CodeStage.AntiCheat.ObscuredTypes.ObscuredLong op_Increment(CodeStage.AntiCheat.ObscuredTypes.ObscuredLong input)
        {
            long val_4;
            var val_5;
            CodeStage.AntiCheat.ObscuredTypes.ObscuredLong val_0;
            val_4 = X1;
            long val_1 = val_4 + 1;
            val_4 = null;
            mem2[0] = CodeStage.AntiCheat.ObscuredTypes.ObscuredLong.Encrypt(value:  val_4, key:  val_1);
            if(CodeStage.AntiCheat.Detectors.ObscuredCheatingDetector.IsRunning != false)
            {
                    val_5 = 1;
                mem2[0] = val_1;
            }
            else
            {
                    val_5 = 0;
            }
            
            mem2[0] = val_5;
            val_0.fakeValueActive = X1 + 32;
            val_0.inited = X1 + 16;
            val_0.currentCryptoKey = X1;
            return val_0;
        }
        public static CodeStage.AntiCheat.ObscuredTypes.ObscuredLong op_Decrement(CodeStage.AntiCheat.ObscuredTypes.ObscuredLong input)
        {
            long val_4;
            var val_5;
            CodeStage.AntiCheat.ObscuredTypes.ObscuredLong val_0;
            val_4 = X1;
            long val_1 = val_4 - 1;
            val_4 = null;
            mem2[0] = CodeStage.AntiCheat.ObscuredTypes.ObscuredLong.Encrypt(value:  val_4, key:  val_1);
            if(CodeStage.AntiCheat.Detectors.ObscuredCheatingDetector.IsRunning != false)
            {
                    val_5 = 1;
                mem2[0] = val_1;
            }
            else
            {
                    val_5 = 0;
            }
            
            mem2[0] = val_5;
            val_0.fakeValueActive = X1 + 32;
            val_0.inited = X1 + 16;
            val_0.currentCryptoKey = X1;
            return val_0;
        }
        public override bool Equals(object obj)
        {
        
        }
        public bool Equals(CodeStage.AntiCheat.ObscuredTypes.ObscuredLong obj)
        {
            return (bool)this.inited;
        }
        public override int GetHashCode()
        {
            return 1171683384;
        }
        public override string ToString()
        {
            return 1171795384;
        }
        public string ToString(string format)
        {
            return (string)this.inited.ToString(format:  format);
        }
        public string ToString(System.IFormatProvider provider)
        {
            return 1172039848;
        }
        public string ToString(string format, System.IFormatProvider provider)
        {
            return 1172164136;
        }
        private static ObscuredLong()
        {
            CodeStage.AntiCheat.ObscuredTypes.ObscuredLong.cryptoKey = 444442;
        }
    
    }

}
