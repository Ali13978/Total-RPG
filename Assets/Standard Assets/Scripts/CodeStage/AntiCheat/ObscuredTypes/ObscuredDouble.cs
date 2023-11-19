using UnityEngine;

namespace CodeStage.AntiCheat.ObscuredTypes
{
    [Serializable]
    public struct ObscuredDouble : IEquatable<CodeStage.AntiCheat.ObscuredTypes.ObscuredDouble>, IFormattable
    {
        // Fields
        private static long cryptoKey;
        [UnityEngine.SerializeField]
        private long currentCryptoKey;
        [UnityEngine.SerializeField]
        private CodeStage.AntiCheat.Common.ACTkByte8 hiddenValue;
        [UnityEngine.SerializeField]
        [UnityEngine.Serialization.FormerlySerializedAsAttribute]
        private byte[] hiddenValueOld;
        [UnityEngine.SerializeField]
        private bool inited;
        [UnityEngine.SerializeField]
        private double fakeValue;
        [UnityEngine.SerializeField]
        private bool fakeValueActive;
        
        // Methods
        private ObscuredDouble(double value)
        {
        
        }
        public static void SetNewCryptoKey(long newKey)
        {
            null = null;
            CodeStage.AntiCheat.ObscuredTypes.ObscuredDouble.cryptoKey = X1;
        }
        public static long Encrypt(double value)
        {
            null = null;
            return (long)CodeStage.AntiCheat.ObscuredTypes.ObscuredDouble.cryptoKey ^ value;
        }
        public static long Encrypt(double value, long key)
        {
            return (long)value ^ X1;
        }
        private static CodeStage.AntiCheat.Common.ACTkByte8 InternalEncrypt(double value)
        {
            return CodeStage.AntiCheat.ObscuredTypes.ObscuredDouble.InternalEncrypt(value:  value, key:  null);
        }
        private static CodeStage.AntiCheat.Common.ACTkByte8 InternalEncrypt(double value, long key)
        {
            long val_2;
            var val_3;
            val_2 = X1;
            if(val_2 != 0)
            {
                    return new CodeStage.AntiCheat.Common.ACTkByte8() {b1 = val_2 ^ value, b2 = val_2 ^ value, b3 = val_2 ^ value, b4 = val_2 ^ value, b5 = val_2 ^ value, b6 = val_2 ^ value, b7 = val_2 ^ value, b8 = val_2 ^ value};
            }
            
            val_3 = null;
            val_3 = null;
            val_2 = CodeStage.AntiCheat.ObscuredTypes.ObscuredDouble.cryptoKey;
            return new CodeStage.AntiCheat.Common.ACTkByte8() {b1 = val_2 ^ value, b2 = val_2 ^ value, b3 = val_2 ^ value, b4 = val_2 ^ value, b5 = val_2 ^ value, b6 = val_2 ^ value, b7 = val_2 ^ value, b8 = val_2 ^ value};
        }
        public static double Decrypt(long value)
        {
            null = null;
            long val_1 = CodeStage.AntiCheat.ObscuredTypes.ObscuredDouble.cryptoKey;
            val_1 = val_1 ^ X1;
            return (double)val_1;
        }
        public static double Decrypt(long value, long key)
        {
            return (double)X2 ^ key;
        }
        public void ApplyNewCryptoKey()
        {
            do
            {
                int val_1 = UnityEngine.Random.Range(min:  0, max:  -2147483648);
                mem2[0] = (long)val_1;
            }
            while(val_1 == 0);
            
            CodeStage.AntiCheat.Common.ACTkByte8 val_2 = CodeStage.AntiCheat.ObscuredTypes.ObscuredDouble.InternalEncrypt(value:  V0.16B, key:  null);
            mem2[0] = val_2.b1;
            mem[1] = val_2.b2;
            mem[2] = val_2.b3;
            mem[3] = val_2.b4;
            mem[4] = val_2.b5;
            mem[5] = val_2.b6;
            mem[6] = val_2.b7;
            mem[7] = val_2.b8;
        }
        public void RandomizeCryptoKey()
        {
        
        }
        public long GetEncrypted()
        {
            return (long)this.inited;
        }
        public void SetEncrypted(long encrypted)
        {
        
        }
        public double GetDecrypted()
        {
        
        }
        private double InternalDecrypt()
        {
        
        }
        public static CodeStage.AntiCheat.ObscuredTypes.ObscuredDouble op_Implicit(double value)
        {
            val_0.fakeValue = 0;
            val_0.fakeValueActive = false;
            mem[1152921510062748985] = 0;
            val_0.hiddenValueOld = 0;
            val_0.inited = false;
            mem[1152921510062748969] = 0;
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
        public static double op_Implicit(CodeStage.AntiCheat.ObscuredTypes.ObscuredDouble value)
        {
        
        }
        public static CodeStage.AntiCheat.ObscuredTypes.ObscuredDouble op_Increment(CodeStage.AntiCheat.ObscuredTypes.ObscuredDouble input)
        {
            var val_4;
            CodeStage.AntiCheat.ObscuredTypes.ObscuredDouble val_0;
            double val_1 = D0 + 1;
            CodeStage.AntiCheat.Common.ACTkByte8 val_2 = CodeStage.AntiCheat.ObscuredTypes.ObscuredDouble.InternalEncrypt(value:  val_1, key:  null);
            mem2[0] = val_2.b1;
            mem[1] = val_2.b2;
            mem[2] = val_2.b3;
            mem[3] = val_2.b4;
            mem[4] = val_2.b5;
            mem[5] = val_2.b6;
            mem[6] = val_2.b7;
            mem[7] = val_2.b8;
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
            val_0.fakeValue = X1 + 32;
            val_0.hiddenValueOld = X1 + 16;
            val_0.currentCryptoKey = X1;
            return val_0;
        }
        public static CodeStage.AntiCheat.ObscuredTypes.ObscuredDouble op_Decrement(CodeStage.AntiCheat.ObscuredTypes.ObscuredDouble input)
        {
            var val_4;
            CodeStage.AntiCheat.ObscuredTypes.ObscuredDouble val_0;
            double val_1 = D0 + (-1);
            CodeStage.AntiCheat.Common.ACTkByte8 val_2 = CodeStage.AntiCheat.ObscuredTypes.ObscuredDouble.InternalEncrypt(value:  val_1, key:  null);
            mem2[0] = val_2.b1;
            mem[1] = val_2.b2;
            mem[2] = val_2.b3;
            mem[3] = val_2.b4;
            mem[4] = val_2.b5;
            mem[5] = val_2.b6;
            mem[6] = val_2.b7;
            mem[7] = val_2.b8;
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
            val_0.fakeValue = X1 + 32;
            val_0.hiddenValueOld = X1 + 16;
            val_0.currentCryptoKey = X1;
            return val_0;
        }
        public override string ToString()
        {
            return 1161788824;
        }
        public string ToString(string format)
        {
            return (string)???.ToString(format:  format);
        }
        public string ToString(System.IFormatProvider provider)
        {
            return 1162033288;
        }
        public string ToString(string format, System.IFormatProvider provider)
        {
            return 1162157576;
        }
        public override bool Equals(object obj)
        {
        
        }
        public bool Equals(CodeStage.AntiCheat.ObscuredTypes.ObscuredDouble obj)
        {
            System.Byte[] val_1 = this.hiddenValueOld;
            val_1 = val_1 & 1;
            return (bool)val_1;
        }
        public override int GetHashCode()
        {
            return (int)???.GetHashCode();
        }
        private static ObscuredDouble()
        {
            CodeStage.AntiCheat.ObscuredTypes.ObscuredDouble.cryptoKey = 210987;
        }
    
    }

}
