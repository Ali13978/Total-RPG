using UnityEngine;

namespace CodeStage.AntiCheat.ObscuredTypes
{
    [Serializable]
    public struct ObscuredVector2
    {
        // Fields
        private static int cryptoKey;
        private static readonly UnityEngine.Vector2 zero;
        [UnityEngine.SerializeField]
        private int currentCryptoKey;
        [UnityEngine.SerializeField]
        private CodeStage.AntiCheat.ObscuredTypes.ObscuredVector2.RawEncryptedVector2 hiddenValue;
        [UnityEngine.SerializeField]
        private bool inited;
        [UnityEngine.SerializeField]
        private UnityEngine.Vector2 fakeValue;
        [UnityEngine.SerializeField]
        private bool fakeValueActive;
        
        // Properties
        public float x { get; set; }
        public float y { get; set; }
        public float Item { get; set; }
        
        // Methods
        private ObscuredVector2(UnityEngine.Vector2 value)
        {
            var val_3;
            var val_4;
            val_3 = null;
            val_3 = null;
            mem2[0] = CodeStage.AntiCheat.ObscuredTypes.ObscuredVector2.cryptoKey;
            RawEncryptedVector2 val_1 = CodeStage.AntiCheat.ObscuredTypes.ObscuredVector2.Encrypt(x:  value.x, y:  value.y, key:  230723584);
            y = val_1.x;
            mem[4] = val_1.y;
            if(CodeStage.AntiCheat.Detectors.ObscuredCheatingDetector.IsRunning != false)
            {
                    mem2[0] = value.x;
                mem2[0] = value.y;
                mem2[0] = 1;
            }
            else
            {
                    val_4 = null;
                val_4 = null;
                mem2[0] = 0;
                mem2[0] = CodeStage.AntiCheat.ObscuredTypes.ObscuredVector2.zero;
                mem2[0] = CodeStage.AntiCheat.ObscuredTypes.ObscuredVector2.cryptoKey.__il2cppRuntimeField_8;
            }
            
            mem2[0] = 1;
        }
        public ObscuredVector2(float x, float y)
        {
            UnityEngine.Vector2 val_5 = this.fakeValue;
            if(CodeStage.AntiCheat.Detectors.ObscuredCheatingDetector.IsRunning == false)
            {
                    return;
            }
            
            if((mem[this.fakeValue + 24]) == 0)
            {
                    return;
            }
            
            float val_5 = mem[this.fakeValue + 16];
            val_5 = x - val_5;
            val_5 = CodeStage.AntiCheat.Detectors.ObscuredCheatingDetector.Instance;
            if(System.Math.Abs(val_5) <= val_2.vector2Epsilon)
            {
                    return;
            }
            
            val_5 = CodeStage.AntiCheat.Detectors.ObscuredCheatingDetector.Instance;
            val_5.OnCheatingDetected();
        }
        public float get_x()
        {
            var val_2;
            y = this.fakeValue;
            if(CodeStage.AntiCheat.Detectors.ObscuredCheatingDetector.IsRunning != false)
            {
                    mem2[0] = V0.16B;
                val_2 = 1;
                mem2[0] = ???;
            }
            else
            {
                    val_2 = 0;
            }
            
            mem2[0] = val_2;
            return (float)S0;
        }
        public void set_x(float value)
        {
            UnityEngine.Vector2 val_4 = this.fakeValue;
            if(CodeStage.AntiCheat.Detectors.ObscuredCheatingDetector.IsRunning == false)
            {
                    return;
            }
            
            if((mem[this.fakeValue + 24]) == 0)
            {
                    return;
            }
            
            float val_4 = mem[this.fakeValue + 20];
            val_4 = value - val_4;
            val_4 = CodeStage.AntiCheat.Detectors.ObscuredCheatingDetector.Instance;
            if(System.Math.Abs(val_4) <= val_2.vector2Epsilon)
            {
                    return;
            }
            
            val_4 = CodeStage.AntiCheat.Detectors.ObscuredCheatingDetector.Instance;
            val_4.OnCheatingDetected();
        }
        public float get_y()
        {
            var val_2;
            mem2[0] = this.fakeValue;
            if(CodeStage.AntiCheat.Detectors.ObscuredCheatingDetector.IsRunning != false)
            {
                    val_2 = 1;
                mem2[0] = ???;
                mem2[0] = V0.16B;
            }
            else
            {
                    val_2 = 0;
            }
            
            mem2[0] = val_2;
            return (float)S0;
        }
        public void set_y(float value)
        {
            var val_8;
            if(W1 == 1)
            {
                goto label_1;
            }
            
            if(W1 != 0)
            {
                goto label_2;
            }
            
            this.fakeValue = ???;
            val_8 = ???;
            label_1:
            label_2:
            System.IndexOutOfRangeException val_7 = new System.IndexOutOfRangeException(message:  "Invalid ObscuredVector2 index!");
        }
        public float get_Item(int index)
        {
            var val_10;
            double val_11;
            var val_12;
            val_11 = V0.16B;
            val_12 = this.fakeValue;
            if(index == 1)
            {
                goto label_1;
            }
            
            if(index != 0)
            {
                goto label_2;
            }
            
            val_12 = ???;
            val_10 = ???;
            val_11 = ???;
            label_1:
            label_2:
            System.IndexOutOfRangeException val_9 = new System.IndexOutOfRangeException(message:  "Invalid ObscuredVector2 index!");
        }
        public void set_Item(int index, float value)
        {
        
        }
        public static void SetNewCryptoKey(int newKey)
        {
            null = null;
            CodeStage.AntiCheat.ObscuredTypes.ObscuredVector2.cryptoKey = W1;
        }
        public static CodeStage.AntiCheat.ObscuredTypes.ObscuredVector2.RawEncryptedVector2 Encrypt(UnityEngine.Vector2 value)
        {
            return CodeStage.AntiCheat.ObscuredTypes.ObscuredVector2.Encrypt(value:  new UnityEngine.Vector2() {x = value.x, y = value.y}, key:  230723584);
        }
        public static CodeStage.AntiCheat.ObscuredTypes.ObscuredVector2.RawEncryptedVector2 Encrypt(UnityEngine.Vector2 value, int key)
        {
            return CodeStage.AntiCheat.ObscuredTypes.ObscuredVector2.Encrypt(x:  value.x, y:  value.y, key:  230723584);
        }
        public static CodeStage.AntiCheat.ObscuredTypes.ObscuredVector2.RawEncryptedVector2 Encrypt(float x, float y, int key)
        {
            int val_3;
            var val_4;
            val_3 = W1;
            if(val_3 != 0)
            {
                    return new RawEncryptedVector2() {x = CodeStage.AntiCheat.ObscuredTypes.ObscuredFloat.Encrypt(value:  x, key:  0), y = CodeStage.AntiCheat.ObscuredTypes.ObscuredFloat.Encrypt(value:  y, key:  0)};
            }
            
            val_4 = null;
            val_4 = null;
            val_3 = CodeStage.AntiCheat.ObscuredTypes.ObscuredVector2.cryptoKey;
            return new RawEncryptedVector2() {x = CodeStage.AntiCheat.ObscuredTypes.ObscuredFloat.Encrypt(value:  x, key:  0), y = CodeStage.AntiCheat.ObscuredTypes.ObscuredFloat.Encrypt(value:  y, key:  0)};
        }
        public static UnityEngine.Vector2 Decrypt(CodeStage.AntiCheat.ObscuredTypes.ObscuredVector2.RawEncryptedVector2 value)
        {
            return CodeStage.AntiCheat.ObscuredTypes.ObscuredVector2.Decrypt(value:  new RawEncryptedVector2() {x = 230723584, y = 268435456}, key:  X1);
        }
        public static UnityEngine.Vector2 Decrypt(CodeStage.AntiCheat.ObscuredTypes.ObscuredVector2.RawEncryptedVector2 value, int key)
        {
            int val_4;
            var val_5;
            val_4 = W2;
            if(val_4 != 0)
            {
                    return new UnityEngine.Vector2() {x = CodeStage.AntiCheat.ObscuredTypes.ObscuredFloat.Decrypt(value:  0, key:  key), y = CodeStage.AntiCheat.ObscuredTypes.ObscuredFloat.Decrypt(value:  0, key:  key >> 32)};
            }
            
            val_5 = null;
            val_5 = null;
            val_4 = CodeStage.AntiCheat.ObscuredTypes.ObscuredVector2.cryptoKey;
            return new UnityEngine.Vector2() {x = CodeStage.AntiCheat.ObscuredTypes.ObscuredFloat.Decrypt(value:  0, key:  key), y = CodeStage.AntiCheat.ObscuredTypes.ObscuredFloat.Decrypt(value:  0, key:  key >> 32)};
        }
        public void ApplyNewCryptoKey()
        {
            do
            {
                int val_1 = UnityEngine.Random.Range(min:  0, max:  -2147483648);
                mem2[0] = val_1;
            }
            while(val_1 == 0);
            
            RawEncryptedVector2 val_2 = CodeStage.AntiCheat.ObscuredTypes.ObscuredVector2.Encrypt(value:  new UnityEngine.Vector2() {x = V0.16B, y = V1.16B}, key:  230723584);
            y = val_2.x;
            mem[4] = val_2.y;
        }
        public void RandomizeCryptoKey()
        {
        
        }
        public CodeStage.AntiCheat.ObscuredTypes.ObscuredVector2.RawEncryptedVector2 GetEncrypted()
        {
            return new RawEncryptedVector2() {x = this.fakeValue, y = this.fakeValue};
        }
        public void SetEncrypted(CodeStage.AntiCheat.ObscuredTypes.ObscuredVector2.RawEncryptedVector2 encrypted)
        {
        
        }
        public UnityEngine.Vector2 GetDecrypted()
        {
            CodeStage.AntiCheat.Detectors.ObscuredCheatingDetector val_1 = CodeStage.AntiCheat.Detectors.ObscuredCheatingDetector.Instance;
            float val_5 = System.Math.Abs(V0.16B - V2.16B);
            if(val_5 >= 0)
            {
                    return new UnityEngine.Vector2() {x = val_1.vector2Epsilon, y = val_5};
            }
            
            var val_4 = ((System.Math.Abs(V1.16B - V3.16B)) < 0) ? 1 : 0;
            return new UnityEngine.Vector2() {x = val_1.vector2Epsilon, y = val_5};
        }
        private UnityEngine.Vector2 InternalDecrypt()
        {
        
        }
        private bool CompareVectorsWithTolerance(UnityEngine.Vector2 vector1, UnityEngine.Vector2 vector2)
        {
        
        }
        private float InternalDecryptField(int encrypted)
        {
        
        }
        private int InternalEncryptField(float encrypted)
        {
        
        }
        public static CodeStage.AntiCheat.ObscuredTypes.ObscuredVector2 op_Implicit(UnityEngine.Vector2 value)
        {
            val_0.fakeValueActive = false;
            mem[1152921510114730233] = 0;
            val_0.hiddenValue.y = 0;
            val_0.inited = false;
            mem[1152921510114730221] = 0;
            val_0.fakeValue.x = 0f;
            val_0.fakeValue.y = 0f;
            val_0.currentCryptoKey = 0;
            val_0.hiddenValue.x = 0;
        }
        public static UnityEngine.Vector2 op_Implicit(CodeStage.AntiCheat.ObscuredTypes.ObscuredVector2 value)
        {
        
        }
        public static UnityEngine.Vector3 op_Implicit(CodeStage.AntiCheat.ObscuredTypes.ObscuredVector2 value)
        {
            return new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
        }
        public override int GetHashCode()
        {
            return 1213228168;
        }
        public override string ToString()
        {
            return 1213340168;
        }
        public string ToString(string format)
        {
            return 1213456248;
        }
        private static ObscuredVector2()
        {
            CodeStage.AntiCheat.ObscuredTypes.ObscuredVector2.cryptoKey = 120206;
            UnityEngine.Vector2 val_1 = UnityEngine.Vector2.zero;
            CodeStage.AntiCheat.ObscuredTypes.ObscuredVector2.zero = val_1.x;
            CodeStage.AntiCheat.ObscuredTypes.ObscuredVector2.cryptoKey.__il2cppRuntimeField_8 = val_1.y;
        }
    
    }

}
