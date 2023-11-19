using UnityEngine;

namespace CodeStage.AntiCheat.ObscuredTypes
{
    [Serializable]
    public struct ObscuredUInt : IEquatable<CodeStage.AntiCheat.ObscuredTypes.ObscuredUInt>, IFormattable
    {
        // Fields
        private static uint cryptoKey;
        [UnityEngine.SerializeField]
        private uint currentCryptoKey;
        [UnityEngine.SerializeField]
        private uint hiddenValue;
        [UnityEngine.SerializeField]
        private bool inited;
        [UnityEngine.SerializeField]
        private uint fakeValue;
        [UnityEngine.SerializeField]
        private bool fakeValueActive;
        
        // Methods
        private ObscuredUInt(uint value)
        {
        
        }
        public static void SetNewCryptoKey(uint newKey)
        {
            null = null;
            CodeStage.AntiCheat.ObscuredTypes.ObscuredUInt.cryptoKey = W1;
        }
        public static uint Encrypt(uint value)
        {
            return CodeStage.AntiCheat.ObscuredTypes.ObscuredUInt.Encrypt(value:  230563840, key:  W1);
        }
        public static uint Decrypt(uint value)
        {
            return CodeStage.AntiCheat.ObscuredTypes.ObscuredUInt.Decrypt(value:  230563840, key:  W1);
        }
        public static uint Encrypt(uint value, uint key)
        {
            uint val_2;
            var val_3;
            val_2 = W2;
            if(val_2 != 0)
            {
                    return (uint)val_2 ^ key;
            }
            
            val_3 = null;
            val_3 = null;
            val_2 = CodeStage.AntiCheat.ObscuredTypes.ObscuredUInt.cryptoKey;
            return (uint)val_2 ^ key;
        }
        public static uint Decrypt(uint value, uint key)
        {
            uint val_2;
            var val_3;
            val_2 = W2;
            if(val_2 != 0)
            {
                    return (uint)val_2 ^ key;
            }
            
            val_3 = null;
            val_3 = null;
            val_2 = CodeStage.AntiCheat.ObscuredTypes.ObscuredUInt.cryptoKey;
            return (uint)val_2 ^ key;
        }
        public void ApplyNewCryptoKey()
        {
            mem2[0] = UnityEngine.Random.Range(min:  0, max:  1);
            mem2[0] = CodeStage.AntiCheat.ObscuredTypes.ObscuredUInt.Encrypt(value:  230563840, key:  this.fakeValueActive);
        }
        public void RandomizeCryptoKey()
        {
        
        }
        public uint GetEncrypted()
        {
            return (uint)this.fakeValueActive;
        }
        public void SetEncrypted(uint encrypted)
        {
        
        }
        public uint GetDecrypted()
        {
        
        }
        private uint InternalDecrypt()
        {
        
        }
        public static CodeStage.AntiCheat.ObscuredTypes.ObscuredUInt op_Implicit(uint value)
        {
            mem2[0] = 0;
            mem2[0] = 0;
            mem2[0] = 0;
        }
        public static uint op_Implicit(CodeStage.AntiCheat.ObscuredTypes.ObscuredUInt value)
        {
        
        }
        public static CodeStage.AntiCheat.ObscuredTypes.ObscuredInt op_Explicit(CodeStage.AntiCheat.ObscuredTypes.ObscuredUInt value)
        {
            mem2[0] = 0;
            mem2[0] = 0;
            mem2[0] = 0;
        }
        public static CodeStage.AntiCheat.ObscuredTypes.ObscuredUInt op_Increment(CodeStage.AntiCheat.ObscuredTypes.ObscuredUInt input)
        {
            var val_4;
            var val_5;
            val_4 = input.inited;
            bool val_1 = val_4 + 1;
            val_4 = null;
            mem2[0] = CodeStage.AntiCheat.ObscuredTypes.ObscuredUInt.Encrypt(value:  230563840, key:  val_1);
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
            return new CodeStage.AntiCheat.ObscuredTypes.ObscuredUInt() {currentCryptoKey = val_3, hiddenValue = val_3, inited = val_1, fakeValue = val_1, fakeValueActive = input.inited};
        }
        public static CodeStage.AntiCheat.ObscuredTypes.ObscuredUInt op_Decrement(CodeStage.AntiCheat.ObscuredTypes.ObscuredUInt input)
        {
            var val_4;
            var val_5;
            val_4 = input.inited;
            bool val_1 = val_4 - 1;
            val_4 = null;
            mem2[0] = CodeStage.AntiCheat.ObscuredTypes.ObscuredUInt.Encrypt(value:  230563840, key:  val_1);
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
            return new CodeStage.AntiCheat.ObscuredTypes.ObscuredUInt() {currentCryptoKey = val_3, hiddenValue = val_3, inited = val_1, fakeValue = val_1, fakeValueActive = input.inited};
        }
        public override bool Equals(object obj)
        {
        
        }
        public bool Equals(CodeStage.AntiCheat.ObscuredTypes.ObscuredUInt obj)
        {
            return (bool)this.fakeValueActive;
        }
        public override string ToString()
        {
            return 1204220940;
        }
        public string ToString(string format)
        {
            return (string)this.fakeValueActive.ToString(format:  format);
        }
        public override int GetHashCode()
        {
            return (int)this.fakeValueActive.Status;
        }
        public string ToString(System.IFormatProvider provider)
        {
            return 1204585596;
        }
        public string ToString(string format, System.IFormatProvider provider)
        {
            return 1204709884;
        }
        private static ObscuredUInt()
        {
            CodeStage.AntiCheat.ObscuredTypes.ObscuredUInt.cryptoKey = 240513;
        }
    
    }

}
