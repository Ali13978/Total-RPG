using UnityEngine;

namespace CodeStage.AntiCheat.ObscuredTypes
{
    [Serializable]
    public struct ObscuredULong : IEquatable<CodeStage.AntiCheat.ObscuredTypes.ObscuredULong>, IFormattable
    {
        // Fields
        private static ulong cryptoKey;
        [UnityEngine.SerializeField]
        private ulong currentCryptoKey;
        [UnityEngine.SerializeField]
        private ulong hiddenValue;
        [UnityEngine.SerializeField]
        private bool inited;
        [UnityEngine.SerializeField]
        private ulong fakeValue;
        [UnityEngine.SerializeField]
        private bool fakeValueActive;
        
        // Methods
        private ObscuredULong(ulong value)
        {
        
        }
        public static void SetNewCryptoKey(ulong newKey)
        {
            null = null;
            CodeStage.AntiCheat.ObscuredTypes.ObscuredULong.cryptoKey = X1;
        }
        public static ulong Encrypt(ulong value)
        {
            return CodeStage.AntiCheat.ObscuredTypes.ObscuredULong.Encrypt(value:  null, key:  X1);
        }
        public static ulong Decrypt(ulong value)
        {
            return CodeStage.AntiCheat.ObscuredTypes.ObscuredULong.Decrypt(value:  null, key:  X1);
        }
        public static ulong Encrypt(ulong value, ulong key)
        {
            ulong val_2;
            var val_3;
            val_2 = X2;
            if(val_2 != 0)
            {
                    return (ulong)val_2 ^ key;
            }
            
            val_3 = null;
            val_3 = null;
            val_2 = CodeStage.AntiCheat.ObscuredTypes.ObscuredULong.cryptoKey;
            return (ulong)val_2 ^ key;
        }
        public static ulong Decrypt(ulong value, ulong key)
        {
            ulong val_2;
            var val_3;
            val_2 = X2;
            if(val_2 != 0)
            {
                    return (ulong)val_2 ^ key;
            }
            
            val_3 = null;
            val_3 = null;
            val_2 = CodeStage.AntiCheat.ObscuredTypes.ObscuredULong.cryptoKey;
            return (ulong)val_2 ^ key;
        }
        public void ApplyNewCryptoKey()
        {
            mem2[0] = (long)UnityEngine.Random.Range(min:  0, max:  1);
            mem2[0] = CodeStage.AntiCheat.ObscuredTypes.ObscuredULong.Encrypt(value:  null, key:  this.inited);
        }
        public void RandomizeCryptoKey()
        {
        
        }
        public ulong GetEncrypted()
        {
            return (ulong)this.fakeValue;
        }
        public void SetEncrypted(ulong encrypted)
        {
        
        }
        public ulong GetDecrypted()
        {
        
        }
        private ulong InternalDecrypt()
        {
        
        }
        public static CodeStage.AntiCheat.ObscuredTypes.ObscuredULong op_Implicit(ulong value)
        {
            val_0.fakeValue = 0;
            val_0.fakeValueActive = false;
            mem[1152921510108148417] = 0;
            val_0.hiddenValue = 0;
            val_0.inited = false;
            mem[1152921510108148401] = 0;
            val_0.currentCryptoKey = 0;
        }
        public static ulong op_Implicit(CodeStage.AntiCheat.ObscuredTypes.ObscuredULong value)
        {
        
        }
        public static CodeStage.AntiCheat.ObscuredTypes.ObscuredULong op_Increment(CodeStage.AntiCheat.ObscuredTypes.ObscuredULong input)
        {
            ulong val_4;
            var val_5;
            CodeStage.AntiCheat.ObscuredTypes.ObscuredULong val_0;
            val_4 = X1;
            ulong val_1 = val_4 + 1;
            val_4 = null;
            mem2[0] = CodeStage.AntiCheat.ObscuredTypes.ObscuredULong.Encrypt(value:  val_4, key:  val_1);
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
        public static CodeStage.AntiCheat.ObscuredTypes.ObscuredULong op_Decrement(CodeStage.AntiCheat.ObscuredTypes.ObscuredULong input)
        {
            ulong val_4;
            var val_5;
            CodeStage.AntiCheat.ObscuredTypes.ObscuredULong val_0;
            val_4 = X1;
            ulong val_1 = val_4 - 1;
            val_4 = null;
            mem2[0] = CodeStage.AntiCheat.ObscuredTypes.ObscuredULong.Encrypt(value:  val_4, key:  val_1);
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
        public bool Equals(CodeStage.AntiCheat.ObscuredTypes.ObscuredULong obj)
        {
            return (bool)this.inited;
        }
        public override int GetHashCode()
        {
            return 1207022664;
        }
        public override string ToString()
        {
            return 1207134664;
        }
        public string ToString(string format)
        {
            return (string)this.inited.ToString(format:  format);
        }
        public string ToString(System.IFormatProvider provider)
        {
            return 1207379128;
        }
        public string ToString(string format, System.IFormatProvider provider)
        {
            return 1207503416;
        }
        private static ObscuredULong()
        {
            CodeStage.AntiCheat.ObscuredTypes.ObscuredULong.cryptoKey = 444443;
        }
    
    }

}
