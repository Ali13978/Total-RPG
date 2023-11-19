using UnityEngine;

namespace CodeStage.AntiCheat.ObscuredTypes
{
    [Serializable]
    public struct ObscuredDecimal : IEquatable<CodeStage.AntiCheat.ObscuredTypes.ObscuredDecimal>, IFormattable
    {
        // Fields
        private static long cryptoKey;
        private long currentCryptoKey;
        private CodeStage.AntiCheat.Common.ACTkByte16 hiddenValue;
        private bool inited;
        private decimal fakeValue;
        private bool fakeValueActive;
        
        // Methods
        private ObscuredDecimal(decimal value)
        {
        
        }
        public static void SetNewCryptoKey(long newKey)
        {
            null = null;
            CodeStage.AntiCheat.ObscuredTypes.ObscuredDecimal.cryptoKey = X1;
        }
        public static decimal Encrypt(decimal value)
        {
            null = null;
            return new System.Decimal() {flags = CodeStage.AntiCheat.ObscuredTypes.ObscuredDecimal.cryptoKey ^ value.lo, hi = CodeStage.AntiCheat.ObscuredTypes.ObscuredDecimal.cryptoKey ^ value.lo, lo = CodeStage.AntiCheat.ObscuredTypes.ObscuredDecimal.cryptoKey ^ X2, mid = CodeStage.AntiCheat.ObscuredTypes.ObscuredDecimal.cryptoKey ^ X2};
        }
        public static decimal Encrypt(decimal value, long key)
        {
            return new System.Decimal() {flags = value.lo ^ X3, hi = value.lo ^ X3, lo = key ^ X3, mid = key ^ X3};
        }
        private static CodeStage.AntiCheat.Common.ACTkByte16 InternalEncrypt(decimal value)
        {
            return CodeStage.AntiCheat.ObscuredTypes.ObscuredDecimal.InternalEncrypt(value:  new System.Decimal() {flags = 229658624, hi = 268435456, lo = value.lo, mid = value.mid}, key:  X2);
        }
        private static CodeStage.AntiCheat.Common.ACTkByte16 InternalEncrypt(decimal value, long key)
        {
            long val_3;
            var val_4;
            val_3 = X3;
            if(val_3 != 0)
            {
                    return new CodeStage.AntiCheat.Common.ACTkByte16() {b1 = val_3 ^ value.lo, b2 = val_3 ^ value.lo, b3 = val_3 ^ value.lo, b4 = val_3 ^ value.lo, b5 = val_3 ^ value.lo, b6 = val_3 ^ value.lo, b7 = val_3 ^ value.lo, b8 = val_3 ^ value.lo, b9 = val_3 ^ key, b10 = val_3 ^ key, b11 = val_3 ^ key, b12 = val_3 ^ key, b13 = val_3 ^ key, b14 = val_3 ^ key, b15 = val_3 ^ key, b16 = val_3 ^ key};
            }
            
            val_4 = null;
            val_4 = null;
            val_3 = CodeStage.AntiCheat.ObscuredTypes.ObscuredDecimal.cryptoKey;
            return new CodeStage.AntiCheat.Common.ACTkByte16() {b1 = val_3 ^ value.lo, b2 = val_3 ^ value.lo, b3 = val_3 ^ value.lo, b4 = val_3 ^ value.lo, b5 = val_3 ^ value.lo, b6 = val_3 ^ value.lo, b7 = val_3 ^ value.lo, b8 = val_3 ^ value.lo, b9 = val_3 ^ key, b10 = val_3 ^ key, b11 = val_3 ^ key, b12 = val_3 ^ key, b13 = val_3 ^ key, b14 = val_3 ^ key, b15 = val_3 ^ key, b16 = val_3 ^ key};
        }
        public static decimal Decrypt(decimal value)
        {
            null = null;
            return new System.Decimal() {flags = CodeStage.AntiCheat.ObscuredTypes.ObscuredDecimal.cryptoKey ^ value.lo, hi = CodeStage.AntiCheat.ObscuredTypes.ObscuredDecimal.cryptoKey ^ value.lo, lo = CodeStage.AntiCheat.ObscuredTypes.ObscuredDecimal.cryptoKey ^ X2, mid = CodeStage.AntiCheat.ObscuredTypes.ObscuredDecimal.cryptoKey ^ X2};
        }
        public static decimal Decrypt(decimal value, long key)
        {
            return new System.Decimal() {flags = value.lo ^ X3, hi = value.lo ^ X3, lo = key ^ X3, mid = key ^ X3};
        }
        public void ApplyNewCryptoKey()
        {
            do
            {
                int val_1 = UnityEngine.Random.Range(min:  0, max:  -2147483648);
                mem[1152921510058791712] = (long)val_1;
            }
            while(val_1 == 0);
            
            CodeStage.AntiCheat.Common.ACTkByte16 val_2 = CodeStage.AntiCheat.ObscuredTypes.ObscuredDecimal.InternalEncrypt(value:  new System.Decimal() {flags = 229658624, hi = 268435456, lo = 1156977440, mid = 268435457}, key:  X1);
            .hiddenValue = val_2;
            mem[1152921510058791728] = val_2.b9;
            mem[1152921510058791729] = val_2.b10;
            mem[1152921510058791730] = val_2.b11;
            mem[1152921510058791731] = val_2.b12;
            mem[1152921510058791732] = val_2.b13;
            mem[1152921510058791733] = val_2.b14;
            mem[1152921510058791734] = val_2.b15;
            mem[1152921510058791735] = val_2.b16;
        }
        public void RandomizeCryptoKey()
        {
        
        }
        public decimal GetEncrypted()
        {
            return new System.Decimal() {flags = this.inited, hi = this.inited};
        }
        public void SetEncrypted(decimal encrypted)
        {
        
        }
        public decimal GetDecrypted()
        {
        
        }
        private decimal InternalDecrypt()
        {
        
        }
        public static CodeStage.AntiCheat.ObscuredTypes.ObscuredDecimal op_Implicit(decimal value)
        {
            val_0.fakeValue.hi = 0;
            val_0.fakeValue.lo = 0;
            val_0.fakeValue.mid = 0;
            val_0.fakeValueActive = false;
            mem[1152921510059499741] = 0;
            val_0.hiddenValue.b9 = 0;
            val_0.hiddenValue.b10 = 0;
            val_0.hiddenValue.b11 = 0;
            val_0.hiddenValue.b12 = 0;
            val_0.hiddenValue.b13 = 0;
            val_0.hiddenValue.b14 = 0;
            val_0.hiddenValue.b15 = 0;
            val_0.hiddenValue.b16 = 0;
            val_0.inited = false;
            mem[1152921510059499721] = 0;
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
        public static decimal op_Implicit(CodeStage.AntiCheat.ObscuredTypes.ObscuredDecimal value)
        {
        
        }
        public static CodeStage.AntiCheat.ObscuredTypes.ObscuredDecimal op_Explicit(CodeStage.AntiCheat.ObscuredTypes.ObscuredFloat f)
        {
            CodeStage.AntiCheat.ObscuredTypes.ObscuredDecimal val_0;
            decimal val_1 = System.Decimal.op_Explicit(value:  X1 + 16);
            val_0.fakeValue.hi = 0;
            val_0.fakeValue.lo = 0;
            val_0.fakeValue.mid = 0;
            val_0.fakeValueActive = false;
            mem[1152921510059822013] = 0;
            val_0.hiddenValue.b9 = 0;
            val_0.hiddenValue.b10 = 0;
            val_0.hiddenValue.b11 = 0;
            val_0.hiddenValue.b12 = 0;
            val_0.hiddenValue.b13 = 0;
            val_0.hiddenValue.b14 = 0;
            val_0.hiddenValue.b15 = 0;
            val_0.hiddenValue.b16 = 0;
            val_0.inited = false;
            mem[1152921510059821993] = 0;
            val_0.currentCryptoKey = 0;
            val_0.hiddenValue.b1 = 0;
            val_0.hiddenValue.b2 = 0;
            val_0.hiddenValue.b3 = 0;
            val_0.hiddenValue.b4 = 0;
            val_0.hiddenValue.b5 = 0;
            val_0.hiddenValue.b6 = 0;
            val_0.hiddenValue.b7 = 0;
            val_0.hiddenValue.b8 = 0;
            return val_0;
        }
        public static CodeStage.AntiCheat.ObscuredTypes.ObscuredDecimal op_Increment(CodeStage.AntiCheat.ObscuredTypes.ObscuredDecimal input)
        {
            var val_4;
            CodeStage.AntiCheat.ObscuredTypes.ObscuredDecimal val_0;
            decimal val_1 = System.Decimal.op_Addition(d1:  new System.Decimal() {lo = X1, mid = X1}, d2:  new System.Decimal() {flags = X1, hi = X1});
            CodeStage.AntiCheat.Common.ACTkByte16 val_2 = CodeStage.AntiCheat.ObscuredTypes.ObscuredDecimal.InternalEncrypt(value:  new System.Decimal() {flags = 229658624, hi = 268435456, lo = val_1.flags, mid = val_1.hi}, key:  val_1.lo);
            mem2[0] = val_2.b1;
            mem[1] = val_2.b2;
            mem[2] = val_2.b3;
            mem[3] = val_2.b4;
            mem[4] = val_2.b5;
            mem[5] = val_2.b6;
            mem[6] = val_2.b7;
            mem[7] = val_2.b8;
            mem2[0] = val_2.b9;
            mem[1] = val_2.b10;
            mem[2] = val_2.b11;
            mem[3] = val_2.b12;
            mem[4] = val_2.b13;
            mem[5] = val_2.b14;
            mem[6] = val_2.b15;
            mem[7] = val_2.b16;
            if(CodeStage.AntiCheat.Detectors.ObscuredCheatingDetector.IsRunning != false)
            {
                    val_4 = 1;
                mem2[0] = val_1.flags;
                mem[4] = val_1.hi;
                mem2[0] = val_1.lo;
                mem[4] = val_1.mid;
            }
            else
            {
                    val_4 = 0;
            }
            
            mem2[0] = val_4;
            val_0.fakeValue.hi = X1 + 32;
            val_0.hiddenValue.b9 = X1 + 16;
            val_0.currentCryptoKey = X1;
            return val_0;
        }
        public static CodeStage.AntiCheat.ObscuredTypes.ObscuredDecimal op_Decrement(CodeStage.AntiCheat.ObscuredTypes.ObscuredDecimal input)
        {
            var val_4;
            CodeStage.AntiCheat.ObscuredTypes.ObscuredDecimal val_0;
            decimal val_1 = System.Decimal.op_Subtraction(d1:  new System.Decimal() {lo = X1, mid = X1}, d2:  new System.Decimal() {flags = X1, hi = X1});
            CodeStage.AntiCheat.Common.ACTkByte16 val_2 = CodeStage.AntiCheat.ObscuredTypes.ObscuredDecimal.InternalEncrypt(value:  new System.Decimal() {flags = 229658624, hi = 268435456, lo = val_1.flags, mid = val_1.hi}, key:  val_1.lo);
            mem2[0] = val_2.b1;
            mem[1] = val_2.b2;
            mem[2] = val_2.b3;
            mem[3] = val_2.b4;
            mem[4] = val_2.b5;
            mem[5] = val_2.b6;
            mem[6] = val_2.b7;
            mem[7] = val_2.b8;
            mem2[0] = val_2.b9;
            mem[1] = val_2.b10;
            mem[2] = val_2.b11;
            mem[3] = val_2.b12;
            mem[4] = val_2.b13;
            mem[5] = val_2.b14;
            mem[6] = val_2.b15;
            mem[7] = val_2.b16;
            if(CodeStage.AntiCheat.Detectors.ObscuredCheatingDetector.IsRunning != false)
            {
                    val_4 = 1;
                mem2[0] = val_1.flags;
                mem[4] = val_1.hi;
                mem2[0] = val_1.lo;
                mem[4] = val_1.mid;
            }
            else
            {
                    val_4 = 0;
            }
            
            mem2[0] = val_4;
            val_0.fakeValue.hi = X1 + 32;
            val_0.hiddenValue.b9 = X1 + 16;
            val_0.currentCryptoKey = X1;
            return val_0;
        }
        public override string ToString()
        {
            return (string);
        }
        public string ToString(string format)
        {
            return (string);
        }
        public string ToString(System.IFormatProvider provider)
        {
            return (string);
        }
        public string ToString(string format, System.IFormatProvider provider)
        {
            return (string);
        }
        public override bool Equals(object obj)
        {
        
        }
        public bool Equals(CodeStage.AntiCheat.ObscuredTypes.ObscuredDecimal obj)
        {
            return false;
        }
        public override int GetHashCode()
        {
            return (int);
        }
        private static ObscuredDecimal()
        {
            CodeStage.AntiCheat.ObscuredTypes.ObscuredDecimal.cryptoKey = 209208;
        }
    
    }

}
