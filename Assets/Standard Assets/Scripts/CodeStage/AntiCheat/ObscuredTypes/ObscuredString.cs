using UnityEngine;

namespace CodeStage.AntiCheat.ObscuredTypes
{
    [Serializable]
    public sealed class ObscuredString
    {
        // Fields
        private static string cryptoKey;
        [UnityEngine.SerializeField]
        private string currentCryptoKey;
        [UnityEngine.SerializeField]
        private byte[] hiddenValue;
        [UnityEngine.SerializeField]
        private bool inited;
        [UnityEngine.SerializeField]
        private string fakeValue;
        [UnityEngine.SerializeField]
        private bool fakeValueActive;
        
        // Properties
        public int Length { get; }
        
        // Methods
        private ObscuredString()
        {
        
        }
        private ObscuredString(string value)
        {
            null = null;
            this.currentCryptoKey = CodeStage.AntiCheat.ObscuredTypes.ObscuredString.cryptoKey;
            this.hiddenValue = CodeStage.AntiCheat.ObscuredTypes.ObscuredString.InternalEncrypt(value:  null);
            bool val_2 = CodeStage.AntiCheat.Detectors.ObscuredCheatingDetector.IsRunning;
            this.inited = true;
            this.fakeValue = (val_2 != true) ? value : 0;
            this.fakeValueActive = val_2;
        }
        public static void SetNewCryptoKey(string newKey)
        {
            null = null;
            CodeStage.AntiCheat.ObscuredTypes.ObscuredString.cryptoKey = X1;
        }
        public static string EncryptDecrypt(string value)
        {
            null = null;
            return CodeStage.AntiCheat.ObscuredTypes.ObscuredString.EncryptDecrypt(value:  null, key:  X1);
        }
        public static string EncryptDecrypt(string value, string key)
        {
            string val_11;
            var val_12;
            var val_13;
            val_11 = X2;
            val_12 = null;
            if((System.String.IsNullOrEmpty(value:  0)) != false)
            {
                    val_12 = null;
                return (string)System.String.Empty;
            }
            
            if((System.String.IsNullOrEmpty(value:  0)) != false)
            {
                    val_13 = null;
                val_13 = null;
                val_11 = CodeStage.AntiCheat.ObscuredTypes.ObscuredString.cryptoKey;
            }
            
            int val_5 = val_11.Length;
            int val_6 = key.Length;
            if(val_6 < 1)
            {
                    return 0.CreateString(val:  null);
            }
            
            var val_12 = 0;
            do
            {
                char val_11 = key.Chars[0];
                val_11 = (val_11.Chars[val_12 - ((val_12 / val_5) * val_5)]) ^ val_11;
                System.Char[].__il2cppRuntimeField_byval_arg.__il2cppRuntimeField_0 = val_11;
                val_12 = val_12 + 1;
            }
            while(val_6 != val_12);
            
            return 0.CreateString(val:  null);
        }
        public void ApplyNewCryptoKey()
        {
            var val_4;
            string val_5;
            val_4 = null;
            val_4 = null;
            if((System.String.op_Inequality(a:  0, b:  this.currentCryptoKey)) == false)
            {
                    return;
            }
            
            string val_2 = this.InternalDecrypt();
            val_5 = null;
            this.hiddenValue = CodeStage.AntiCheat.ObscuredTypes.ObscuredString.InternalEncrypt(value:  val_5);
            this.currentCryptoKey = CodeStage.AntiCheat.ObscuredTypes.ObscuredString.cryptoKey;
        }
        public void RandomizeCryptoKey()
        {
            int val_2 = UnityEngine.Random.Range(min:  0, max:  -2147483648);
            this.currentCryptoKey = ;
            this.hiddenValue = CodeStage.AntiCheat.ObscuredTypes.ObscuredString.InternalEncrypt(value:  null, key:  this.InternalDecrypt());
        }
        public string GetEncrypted()
        {
            this.ApplyNewCryptoKey();
            return CodeStage.AntiCheat.ObscuredTypes.ObscuredString.GetString(bytes:  null);
        }
        public void SetEncrypted(string encrypted)
        {
            string val_5;
            bool val_6;
            this.inited = true;
            this.hiddenValue = CodeStage.AntiCheat.ObscuredTypes.ObscuredString.GetBytes(str:  null);
            val_5 = 0;
            if((System.String.IsNullOrEmpty(value:  val_5)) != false)
            {
                    val_5 = null;
                val_5 = null;
                this.currentCryptoKey = CodeStage.AntiCheat.ObscuredTypes.ObscuredString.cryptoKey;
            }
            
            if(CodeStage.AntiCheat.Detectors.ObscuredCheatingDetector.IsRunning != false)
            {
                    val_6 = 1;
                this.fakeValue = this.InternalDecrypt();
            }
            else
            {
                    val_6 = false;
            }
            
            this.fakeValueActive = val_6;
        }
        public string GetDecrypted()
        {
            return this.InternalDecrypt();
        }
        private static byte[] InternalEncrypt(string value)
        {
            null = null;
            return CodeStage.AntiCheat.ObscuredTypes.ObscuredString.InternalEncrypt(value:  null, key:  X1);
        }
        private static byte[] InternalEncrypt(string value, string key)
        {
            return CodeStage.AntiCheat.ObscuredTypes.ObscuredString.GetBytes(str:  CodeStage.AntiCheat.ObscuredTypes.ObscuredString.EncryptDecrypt(value:  null, key:  key));
        }
        private string InternalDecrypt()
        {
            string val_7;
            string val_8;
            string val_9;
            System.Byte[] val_10;
            string val_11;
            var val_12;
            string val_13;
            val_7 = this;
            if(this.inited != false)
            {
                    val_8 = this.currentCryptoKey;
                val_9 = 0;
                val_10 = null;
                if((System.String.IsNullOrEmpty(value:  val_9)) != false)
            {
                    val_9 = val_10;
                val_10 = null;
                val_8 = CodeStage.AntiCheat.ObscuredTypes.ObscuredString.cryptoKey;
            }
            
                val_9 = val_10;
                string val_2 = CodeStage.AntiCheat.ObscuredTypes.ObscuredString.GetString(bytes:  val_9);
                val_11 = CodeStage.AntiCheat.ObscuredTypes.ObscuredString.EncryptDecrypt(value:  val_2, key:  val_2);
                if(CodeStage.AntiCheat.Detectors.ObscuredCheatingDetector.IsRunning == false)
            {
                    return val_11;
            }
            
                if(this.fakeValueActive == false)
            {
                    return val_11;
            }
            
                val_7 = this.fakeValue;
                if((System.String.op_Inequality(a:  0, b:  val_11)) == false)
            {
                    return val_11;
            }
            
                val_7 = CodeStage.AntiCheat.Detectors.ObscuredCheatingDetector.<Instance>k__BackingField;
                val_7.OnCheatingDetected();
                return val_11;
            }
            
            val_12 = null;
            val_12 = null;
            this.currentCryptoKey = CodeStage.AntiCheat.ObscuredTypes.ObscuredString.cryptoKey;
            val_13 = null;
            val_13 = null;
            this.hiddenValue = CodeStage.AntiCheat.ObscuredTypes.ObscuredString.InternalEncrypt(value:  val_13);
            this.fakeValueActive = false;
            this.inited = true;
            this.fakeValue = System.String.Empty;
            val_11 = System.String.Empty;
            return val_11;
        }
        public int get_Length()
        {
            return (int)((this.hiddenValue.Length < 0) ? (this.hiddenValue.Length + 1) : this.hiddenValue.Length) >> 1;
        }
        public static CodeStage.AntiCheat.ObscuredTypes.ObscuredString op_Implicit(string value)
        {
            var val_2;
            if(X1 != 0)
            {
                    CodeStage.AntiCheat.ObscuredTypes.ObscuredString val_1 = null;
                val_2 = val_1;
                val_1 = new CodeStage.AntiCheat.ObscuredTypes.ObscuredString(value:  X1);
                return (CodeStage.AntiCheat.ObscuredTypes.ObscuredString)val_2;
            }
            
            val_2 = 0;
            return (CodeStage.AntiCheat.ObscuredTypes.ObscuredString)val_2;
        }
        public static string op_Implicit(CodeStage.AntiCheat.ObscuredTypes.ObscuredString value)
        {
            if((CodeStage.AntiCheat.ObscuredTypes.ObscuredString.op_Equality(a:  null, b:  X1)) != false)
            {
                    return 0;
            }
            
            if(X1 != 0)
            {
                    return X1.InternalDecrypt();
            }
            
            return X1.InternalDecrypt();
        }
        public override string ToString()
        {
            return this.InternalDecrypt();
        }
        public static bool op_Equality(CodeStage.AntiCheat.ObscuredTypes.ObscuredString a, CodeStage.AntiCheat.ObscuredTypes.ObscuredString b)
        {
            var val_6;
            if((System.Object.ReferenceEquals(objA:  0, objB:  b)) != false)
            {
                    val_6 = 1;
                return (bool)val_6;
            }
            
            val_6 = 0;
            if(b == null)
            {
                    return (bool)val_6;
            }
            
            if(X2 == 0)
            {
                    return (bool)val_6;
            }
            
            if((System.String.op_Equality(a:  0, b:  b.currentCryptoKey)) != false)
            {
                    return CodeStage.AntiCheat.ObscuredTypes.ObscuredString.ArraysEquals(a1:  null, a2:  b.hiddenValue);
            }
            
            string val_5 = X2.InternalDecrypt();
            return System.String.Equals(a:  0, b:  b.InternalDecrypt());
        }
        public static bool op_Inequality(CodeStage.AntiCheat.ObscuredTypes.ObscuredString a, CodeStage.AntiCheat.ObscuredTypes.ObscuredString b)
        {
            bool val_1 = CodeStage.AntiCheat.ObscuredTypes.ObscuredString.op_Equality(a:  null, b:  b);
            val_1 = (~val_1) & 1;
            return (bool)val_1;
        }
        public override bool Equals(object obj)
        {
            var val_3;
            if(obj != null)
            {
                    if(null == null)
            {
                goto label_2;
            }
            
            }
            
            val_3 = 0;
            return (bool)this.Equals(value:  obj);
            label_2:
            val_3 = this;
            return (bool)this.Equals(value:  obj);
        }
        public bool Equals(CodeStage.AntiCheat.ObscuredTypes.ObscuredString value)
        {
            if((CodeStage.AntiCheat.ObscuredTypes.ObscuredString.op_Equality(a:  null, b:  value)) != false)
            {
                    return false;
            }
            
            if((System.String.op_Equality(a:  0, b:  this.currentCryptoKey)) != false)
            {
                    return CodeStage.AntiCheat.ObscuredTypes.ObscuredString.ArraysEquals(a1:  null, a2:  this.hiddenValue);
            }
            
            string val_5 = value.InternalDecrypt();
            return System.String.Equals(a:  0, b:  this.InternalDecrypt());
        }
        public bool Equals(CodeStage.AntiCheat.ObscuredTypes.ObscuredString value, System.StringComparison comparisonType)
        {
            if((CodeStage.AntiCheat.ObscuredTypes.ObscuredString.op_Equality(a:  null, b:  value)) == false)
            {
                    return System.String.Equals(a:  0, b:  this.InternalDecrypt(), comparisonType:  value.InternalDecrypt());
            }
            
            return false;
        }
        public override int GetHashCode()
        {
            if(this.InternalDecrypt() == null)
            {
                
            }
        
        }
        private static byte[] GetBytes(string str)
        {
            int val_2 = X1.Length << 1;
            System.Buffer.BlockCopy(src:  0, srcOffset:  X1.ToCharArray(), dst:  0, dstOffset:  460851360, count:  0);
            return (System.Byte[])null;
        }
        private static string GetString(byte[] bytes)
        {
            var val_2 = (((X1 + 24) < 0) ? ((X1 + 24) + 1) : (X1 + 24)) >> 1;
            System.Buffer.BlockCopy(src:  0, srcOffset:  X1, dst:  0, dstOffset:  410741984, count:  0);
            return 0.CreateString(val:  null);
        }
        private static bool ArraysEquals(byte[] a1, byte[] a2)
        {
            var val_2;
            var val_3;
            if(a2 == X2)
            {
                goto label_4;
            }
            
            val_2 = 0;
            if(a2 == null)
            {
                    return (bool)val_2;
            }
            
            if(X2 == 0)
            {
                    return (bool)val_2;
            }
            
            val_2 = 0;
            if(a2.Length != (X2 + 24))
            {
                    return (bool)val_2;
            }
            
            val_3 = 0;
            label_7:
            if(val_3 >= a2.Length)
            {
                goto label_4;
            }
            
            var val_1 = X2 + 0;
            val_3 = val_3 + 1;
            if(a2[0] == ((X2 + 0) + 32))
            {
                goto label_7;
            }
            
            val_2 = 0;
            return (bool)val_2;
            label_4:
            val_2 = 1;
            return (bool)val_2;
        }
        private static ObscuredString()
        {
            CodeStage.AntiCheat.ObscuredTypes.ObscuredString.cryptoKey = "4441";
        }
    
    }

}
