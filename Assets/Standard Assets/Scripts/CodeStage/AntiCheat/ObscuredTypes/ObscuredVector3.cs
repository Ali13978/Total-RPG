using UnityEngine;

namespace CodeStage.AntiCheat.ObscuredTypes
{
    [Serializable]
    public struct ObscuredVector3
    {
        // Fields
        private static int cryptoKey;
        private static readonly UnityEngine.Vector3 zero;
        [UnityEngine.SerializeField]
        private int currentCryptoKey;
        [UnityEngine.SerializeField]
        private CodeStage.AntiCheat.ObscuredTypes.ObscuredVector3.RawEncryptedVector3 hiddenValue;
        [UnityEngine.SerializeField]
        private bool inited;
        [UnityEngine.SerializeField]
        private UnityEngine.Vector3 fakeValue;
        [UnityEngine.SerializeField]
        private bool fakeValueActive;
        
        // Properties
        public float x { get; set; }
        public float y { get; set; }
        public float z { get; set; }
        public float Item { get; set; }
        
        // Methods
        private ObscuredVector3(UnityEngine.Vector3 value)
        {
            var val_3;
            var val_4;
            val_3 = null;
            val_3 = null;
            mem2[0] = CodeStage.AntiCheat.ObscuredTypes.ObscuredVector3.cryptoKey;
            RawEncryptedVector3 val_1 = CodeStage.AntiCheat.ObscuredTypes.ObscuredVector3.Encrypt(x:  value.x, y:  value.y, z:  value.z, key:  230830080);
            mem2[0] = val_1.x;
            mem[4] = val_1.y;
            mem2[0] = val_1.z;
            if(CodeStage.AntiCheat.Detectors.ObscuredCheatingDetector.IsRunning != false)
            {
                    mem2[0] = value.x;
                mem2[0] = value.y;
                mem2[0] = value.z;
                mem2[0] = 1;
            }
            else
            {
                    val_4 = null;
                val_4 = null;
                mem2[0] = 0;
                mem2[0] = CodeStage.AntiCheat.ObscuredTypes.ObscuredVector3.zero;
                mem2[0] = CodeStage.AntiCheat.ObscuredTypes.ObscuredVector3.cryptoKey.__il2cppRuntimeField_8;
                mem2[0] = CodeStage.AntiCheat.ObscuredTypes.ObscuredVector3.cryptoKey.__il2cppRuntimeField_C;
            }
            
            mem2[0] = 1;
        }
        public ObscuredVector3(float x, float y, float z)
        {
            bool val_5 = this.inited;
            if(CodeStage.AntiCheat.Detectors.ObscuredCheatingDetector.IsRunning == false)
            {
                    return;
            }
            
            if((this.inited + 32) == 0)
            {
                    return;
            }
            
            float val_5 = this.inited + 20;
            val_5 = x - val_5;
            val_5 = CodeStage.AntiCheat.Detectors.ObscuredCheatingDetector.Instance;
            if(System.Math.Abs(val_5) <= val_2.vector3Epsilon)
            {
                    return;
            }
            
            val_5 = CodeStage.AntiCheat.Detectors.ObscuredCheatingDetector.Instance;
            val_5.OnCheatingDetected();
        }
        public float get_x()
        {
            var val_2;
            mem2[0] = this.inited;
            if(CodeStage.AntiCheat.Detectors.ObscuredCheatingDetector.IsRunning != false)
            {
                    mem2[0] = V0.16B;
                mem2[0] = ???;
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
            bool val_4 = this.inited;
            if(CodeStage.AntiCheat.Detectors.ObscuredCheatingDetector.IsRunning == false)
            {
                    return;
            }
            
            if((this.inited + 32) == 0)
            {
                    return;
            }
            
            float val_4 = this.inited + 24;
            val_4 = value - val_4;
            val_4 = CodeStage.AntiCheat.Detectors.ObscuredCheatingDetector.Instance;
            if(System.Math.Abs(val_4) <= val_2.vector3Epsilon)
            {
                    return;
            }
            
            val_4 = CodeStage.AntiCheat.Detectors.ObscuredCheatingDetector.Instance;
            val_4.OnCheatingDetected();
        }
        public float get_y()
        {
            var val_2;
            mem2[0] = this.inited;
            if(CodeStage.AntiCheat.Detectors.ObscuredCheatingDetector.IsRunning != false)
            {
                    mem2[0] = ???;
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
        public void set_y(float value)
        {
            bool val_4 = this.inited;
            if(CodeStage.AntiCheat.Detectors.ObscuredCheatingDetector.IsRunning == false)
            {
                    return;
            }
            
            if((this.inited + 32) == 0)
            {
                    return;
            }
            
            float val_4 = this.inited + 28;
            val_4 = value - val_4;
            val_4 = CodeStage.AntiCheat.Detectors.ObscuredCheatingDetector.Instance;
            if(System.Math.Abs(val_4) <= val_2.vector3Epsilon)
            {
                    return;
            }
            
            val_4 = CodeStage.AntiCheat.Detectors.ObscuredCheatingDetector.Instance;
            val_4.OnCheatingDetected();
        }
        public float get_z()
        {
            var val_2;
            mem2[0] = this.inited;
            if(CodeStage.AntiCheat.Detectors.ObscuredCheatingDetector.IsRunning != false)
            {
                    mem2[0] = ???;
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
        public void set_z(float value)
        {
            var val_6;
            var val_8;
            var val_17;
            var val_18;
            var val_19;
            var val_20;
            var val_21;
            val_17 = this.inited;
            var val_2 = (W1 < 3) ? (W1 + 3) : 0;
            if(val_2 == 5)
            {
                goto label_1;
            }
            
            if(val_2 == 4)
            {
                goto label_2;
            }
            
            if(val_2 != 3)
            {
                goto label_3;
            }
            
            val_18 = ???;
            val_19 = ???;
            label_1:
            val_20 = val_6;
            val_21 = val_8;
            label_2:
            label_3:
            System.IndexOutOfRangeException val_15 = new System.IndexOutOfRangeException(message:  "Invalid ObscuredVector3 index!");
        }
        public float get_Item(int index)
        {
            var val_6;
            var val_8;
            var val_10;
            var val_21;
            var val_22;
            var val_23;
            var val_24;
            double val_25;
            var val_26;
            var val_27;
            var val_28;
            val_21 = V0.16B;
            val_22 = this.inited;
            var val_2 = (index < 3) ? (index + 3) : 0;
            if(val_2 == 5)
            {
                goto label_1;
            }
            
            if(val_2 == 4)
            {
                goto label_2;
            }
            
            if(val_2 != 3)
            {
                goto label_3;
            }
            
            val_23 = ???;
            val_24 = ???;
            val_25 = ???;
            label_1:
            val_26 = val_6;
            val_27 = val_8;
            val_28 = val_10;
            label_2:
            label_3:
            System.IndexOutOfRangeException val_19 = new System.IndexOutOfRangeException(message:  "Invalid ObscuredVector3 index!");
        }
        public void set_Item(int index, float value)
        {
        
        }
        public static void SetNewCryptoKey(int newKey)
        {
            null = null;
            CodeStage.AntiCheat.ObscuredTypes.ObscuredVector3.cryptoKey = W1;
        }
        public static CodeStage.AntiCheat.ObscuredTypes.ObscuredVector3.RawEncryptedVector3 Encrypt(UnityEngine.Vector3 value)
        {
            RawEncryptedVector3 val_1 = CodeStage.AntiCheat.ObscuredTypes.ObscuredVector3.Encrypt(value:  new UnityEngine.Vector3() {x = value.x, y = value.y, z = value.z}, key:  230830080);
            val_1.z = val_1.z & 4294967295;
            return new RawEncryptedVector3() {x = val_1.x, y = val_1.y, z = val_1.z};
        }
        public static CodeStage.AntiCheat.ObscuredTypes.ObscuredVector3.RawEncryptedVector3 Encrypt(UnityEngine.Vector3 value, int key)
        {
            RawEncryptedVector3 val_1 = CodeStage.AntiCheat.ObscuredTypes.ObscuredVector3.Encrypt(x:  value.x, y:  value.y, z:  value.z, key:  230830080);
            val_1.z = val_1.z & 4294967295;
            return new RawEncryptedVector3() {x = val_1.x, y = val_1.y, z = val_1.z};
        }
        public static CodeStage.AntiCheat.ObscuredTypes.ObscuredVector3.RawEncryptedVector3 Encrypt(float x, float y, float z, int key)
        {
            int val_4;
            var val_5;
            val_4 = W1;
            if(val_4 != 0)
            {
                    return new RawEncryptedVector3() {x = CodeStage.AntiCheat.ObscuredTypes.ObscuredFloat.Encrypt(value:  x, key:  0), y = CodeStage.AntiCheat.ObscuredTypes.ObscuredFloat.Encrypt(value:  y, key:  0), z = CodeStage.AntiCheat.ObscuredTypes.ObscuredFloat.Encrypt(value:  z, key:  0)};
            }
            
            val_5 = null;
            val_5 = null;
            val_4 = CodeStage.AntiCheat.ObscuredTypes.ObscuredVector3.cryptoKey;
            return new RawEncryptedVector3() {x = CodeStage.AntiCheat.ObscuredTypes.ObscuredFloat.Encrypt(value:  x, key:  0), y = CodeStage.AntiCheat.ObscuredTypes.ObscuredFloat.Encrypt(value:  y, key:  0), z = CodeStage.AntiCheat.ObscuredTypes.ObscuredFloat.Encrypt(value:  z, key:  0)};
        }
        public static UnityEngine.Vector3 Decrypt(CodeStage.AntiCheat.ObscuredTypes.ObscuredVector3.RawEncryptedVector3 value)
        {
            return CodeStage.AntiCheat.ObscuredTypes.ObscuredVector3.Decrypt(value:  new RawEncryptedVector3() {x = 230830080, y = 268435456, z = value.z}, key:  X2 & 4294967295);
        }
        public static UnityEngine.Vector3 Decrypt(CodeStage.AntiCheat.ObscuredTypes.ObscuredVector3.RawEncryptedVector3 value, int key)
        {
            int val_5;
            var val_6;
            val_5 = W3;
            if(val_5 != 0)
            {
                    return new UnityEngine.Vector3() {x = CodeStage.AntiCheat.ObscuredTypes.ObscuredFloat.Decrypt(value:  0, key:  value.z), y = CodeStage.AntiCheat.ObscuredTypes.ObscuredFloat.Decrypt(value:  0, key:  value.z >> 32), z = CodeStage.AntiCheat.ObscuredTypes.ObscuredFloat.Decrypt(value:  0, key:  key)};
            }
            
            val_6 = null;
            val_6 = null;
            val_5 = CodeStage.AntiCheat.ObscuredTypes.ObscuredVector3.cryptoKey;
            return new UnityEngine.Vector3() {x = CodeStage.AntiCheat.ObscuredTypes.ObscuredFloat.Decrypt(value:  0, key:  value.z), y = CodeStage.AntiCheat.ObscuredTypes.ObscuredFloat.Decrypt(value:  0, key:  value.z >> 32), z = CodeStage.AntiCheat.ObscuredTypes.ObscuredFloat.Decrypt(value:  0, key:  key)};
        }
        public void ApplyNewCryptoKey()
        {
            do
            {
                int val_1 = UnityEngine.Random.Range(min:  0, max:  -2147483648);
                mem2[0] = val_1;
            }
            while(val_1 == 0);
            
            RawEncryptedVector3 val_2 = CodeStage.AntiCheat.ObscuredTypes.ObscuredVector3.Encrypt(value:  new UnityEngine.Vector3() {x = V0.16B, y = V1.16B, z = V2.16B}, key:  230830080);
            mem2[0] = val_2.x;
            mem[4] = val_2.y;
            mem2[0] = val_2.z;
        }
        public void RandomizeCryptoKey()
        {
        
        }
        public CodeStage.AntiCheat.ObscuredTypes.ObscuredVector3.RawEncryptedVector3 GetEncrypted()
        {
            return new RawEncryptedVector3() {x = this.fakeValue, y = this.fakeValue};
        }
        public void SetEncrypted(CodeStage.AntiCheat.ObscuredTypes.ObscuredVector3.RawEncryptedVector3 encrypted)
        {
            encrypted.z = encrypted.z & 4294967295;
        }
        public UnityEngine.Vector3 GetDecrypted()
        {
            CodeStage.AntiCheat.Detectors.ObscuredCheatingDetector val_1 = CodeStage.AntiCheat.Detectors.ObscuredCheatingDetector.Instance;
            float val_6 = System.Math.Abs(V0.16B - V3.16B);
            if(val_6 >= 0)
            {
                    return new UnityEngine.Vector3() {x = val_1.vector3Epsilon, y = val_6};
            }
            
            if((System.Math.Abs(V1.16B - V4.16B)) >= 0)
            {
                    return new UnityEngine.Vector3() {x = val_1.vector3Epsilon, y = val_6};
            }
            
            var val_5 = ((System.Math.Abs(V2.16B - V5.16B)) < 0) ? 1 : 0;
            return new UnityEngine.Vector3() {x = val_1.vector3Epsilon, y = val_6};
        }
        private UnityEngine.Vector3 InternalDecrypt()
        {
        
        }
        private bool CompareVectorsWithTolerance(UnityEngine.Vector3 vector1, UnityEngine.Vector3 vector2)
        {
        
        }
        private float InternalDecryptField(int encrypted)
        {
        
        }
        private int InternalEncryptField(float encrypted)
        {
        
        }
        public static CodeStage.AntiCheat.ObscuredTypes.ObscuredVector3 op_Implicit(UnityEngine.Vector3 value)
        {
            val_0.fakeValueActive = false;
            mem[1152921510118406209] = 0;
            val_0.inited = false;
            mem[1152921510118406193] = 0;
            val_0.fakeValue.y = 0f;
            val_0.fakeValue.z = 0f;
            val_0.currentCryptoKey = 0;
            val_0.hiddenValue.x = 0;
            val_0.hiddenValue.y = 0;
            val_0.hiddenValue.z = 0;
        }
        public static UnityEngine.Vector3 op_Implicit(CodeStage.AntiCheat.ObscuredTypes.ObscuredVector3 value)
        {
        
        }
        public static CodeStage.AntiCheat.ObscuredTypes.ObscuredVector3 op_Addition(CodeStage.AntiCheat.ObscuredTypes.ObscuredVector3 a, CodeStage.AntiCheat.ObscuredTypes.ObscuredVector3 b)
        {
            UnityEngine.Vector3 val_1 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = V0.16B, y = V1.16B, z = V2.16B}, b:  new UnityEngine.Vector3() {x = V0.16B, y = V1.16B, z = V2.16B});
            val_0.fakeValueActive = false;
            mem[1152921510118663009] = 0;
            val_0.inited = false;
            mem[1152921510118662993] = 0;
            val_0.fakeValue.y = 0f;
            val_0.fakeValue.z = 0f;
            val_0.currentCryptoKey = 0;
            val_0.hiddenValue.x = 0;
            val_0.hiddenValue.y = 0;
            val_0.hiddenValue.z = 0;
        }
        public static CodeStage.AntiCheat.ObscuredTypes.ObscuredVector3 op_Addition(UnityEngine.Vector3 a, CodeStage.AntiCheat.ObscuredTypes.ObscuredVector3 b)
        {
            UnityEngine.Vector3 val_1 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = a.x, y = a.y, z = a.z}, b:  new UnityEngine.Vector3() {x = a.x, y = a.y, z = a.z});
            val_0.fakeValueActive = false;
            mem[1152921510118791233] = 0;
            val_0.inited = false;
            mem[1152921510118791217] = 0;
            val_0.fakeValue.y = 0f;
            val_0.fakeValue.z = 0f;
            val_0.currentCryptoKey = 0;
            val_0.hiddenValue.x = 0;
            val_0.hiddenValue.y = 0;
            val_0.hiddenValue.z = 0;
        }
        public static CodeStage.AntiCheat.ObscuredTypes.ObscuredVector3 op_Addition(CodeStage.AntiCheat.ObscuredTypes.ObscuredVector3 a, UnityEngine.Vector3 b)
        {
            UnityEngine.Vector3 val_1 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = b.x, y = b.y, z = b.z}, b:  new UnityEngine.Vector3() {x = b.x, y = b.y, z = b.z});
            val_0.fakeValueActive = false;
            mem[1152921510118919457] = 0;
            val_0.inited = false;
            mem[1152921510118919441] = 0;
            val_0.fakeValue.y = 0f;
            val_0.fakeValue.z = 0f;
            val_0.currentCryptoKey = 0;
            val_0.hiddenValue.x = 0;
            val_0.hiddenValue.y = 0;
            val_0.hiddenValue.z = 0;
        }
        public static CodeStage.AntiCheat.ObscuredTypes.ObscuredVector3 op_Subtraction(CodeStage.AntiCheat.ObscuredTypes.ObscuredVector3 a, CodeStage.AntiCheat.ObscuredTypes.ObscuredVector3 b)
        {
            UnityEngine.Vector3 val_1 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = V0.16B, y = V1.16B, z = V2.16B}, b:  new UnityEngine.Vector3() {x = V0.16B, y = V1.16B, z = V2.16B});
            val_0.fakeValueActive = false;
            mem[1152921510119056097] = 0;
            val_0.inited = false;
            mem[1152921510119056081] = 0;
            val_0.fakeValue.y = 0f;
            val_0.fakeValue.z = 0f;
            val_0.currentCryptoKey = 0;
            val_0.hiddenValue.x = 0;
            val_0.hiddenValue.y = 0;
            val_0.hiddenValue.z = 0;
        }
        public static CodeStage.AntiCheat.ObscuredTypes.ObscuredVector3 op_Subtraction(UnityEngine.Vector3 a, CodeStage.AntiCheat.ObscuredTypes.ObscuredVector3 b)
        {
            UnityEngine.Vector3 val_1 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = a.x, y = a.y, z = a.z}, b:  new UnityEngine.Vector3() {x = a.x, y = a.y, z = a.z});
            val_0.fakeValueActive = false;
            mem[1152921510119184321] = 0;
            val_0.inited = false;
            mem[1152921510119184305] = 0;
            val_0.fakeValue.y = 0f;
            val_0.fakeValue.z = 0f;
            val_0.currentCryptoKey = 0;
            val_0.hiddenValue.x = 0;
            val_0.hiddenValue.y = 0;
            val_0.hiddenValue.z = 0;
        }
        public static CodeStage.AntiCheat.ObscuredTypes.ObscuredVector3 op_Subtraction(CodeStage.AntiCheat.ObscuredTypes.ObscuredVector3 a, UnityEngine.Vector3 b)
        {
            UnityEngine.Vector3 val_1 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = b.x, y = b.y, z = b.z}, b:  new UnityEngine.Vector3() {x = b.x, y = b.y, z = b.z});
            val_0.fakeValueActive = false;
            mem[1152921510119312545] = 0;
            val_0.inited = false;
            mem[1152921510119312529] = 0;
            val_0.fakeValue.y = 0f;
            val_0.fakeValue.z = 0f;
            val_0.currentCryptoKey = 0;
            val_0.hiddenValue.x = 0;
            val_0.hiddenValue.y = 0;
            val_0.hiddenValue.z = 0;
        }
        public static CodeStage.AntiCheat.ObscuredTypes.ObscuredVector3 op_UnaryNegation(CodeStage.AntiCheat.ObscuredTypes.ObscuredVector3 a)
        {
            UnityEngine.Vector3 val_1 = UnityEngine.Vector3.op_UnaryNegation(a:  new UnityEngine.Vector3() {x = V0.16B, y = V1.16B, z = V2.16B});
            val_0.fakeValueActive = false;
            mem[1152921510119440705] = 0;
            val_0.inited = false;
            mem[1152921510119440689] = 0;
            val_0.fakeValue.y = 0f;
            val_0.fakeValue.z = 0f;
            val_0.currentCryptoKey = 0;
            val_0.hiddenValue.x = 0;
            val_0.hiddenValue.y = 0;
            val_0.hiddenValue.z = 0;
        }
        public static CodeStage.AntiCheat.ObscuredTypes.ObscuredVector3 op_Multiply(CodeStage.AntiCheat.ObscuredTypes.ObscuredVector3 a, float d)
        {
            UnityEngine.Vector3 val_1 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = d, y = V1.16B, z = V2.16B}, d:  d);
            val_0.fakeValueActive = false;
            mem[1152921510119568897] = 0;
            val_0.inited = false;
            mem[1152921510119568881] = 0;
            val_0.fakeValue.y = 0f;
            val_0.fakeValue.z = 0f;
            val_0.currentCryptoKey = 0;
            val_0.hiddenValue.x = 0;
            val_0.hiddenValue.y = 0;
            val_0.hiddenValue.z = 0;
        }
        public static CodeStage.AntiCheat.ObscuredTypes.ObscuredVector3 op_Multiply(float d, CodeStage.AntiCheat.ObscuredTypes.ObscuredVector3 a)
        {
            UnityEngine.Vector3 val_1 = UnityEngine.Vector3.op_Multiply(d:  d, a:  new UnityEngine.Vector3() {x = d, y = V1.16B, z = V2.16B});
            val_0.fakeValueActive = false;
            mem[1152921510119697089] = 0;
            val_0.inited = false;
            mem[1152921510119697073] = 0;
            val_0.fakeValue.y = 0f;
            val_0.fakeValue.z = 0f;
            val_0.currentCryptoKey = 0;
            val_0.hiddenValue.x = 0;
            val_0.hiddenValue.y = 0;
            val_0.hiddenValue.z = 0;
        }
        public static CodeStage.AntiCheat.ObscuredTypes.ObscuredVector3 op_Division(CodeStage.AntiCheat.ObscuredTypes.ObscuredVector3 a, float d)
        {
            UnityEngine.Vector3 val_1 = UnityEngine.Vector3.op_Division(a:  new UnityEngine.Vector3() {x = d, y = V1.16B, z = V2.16B}, d:  d);
            val_0.fakeValueActive = false;
            mem[1152921510119825281] = 0;
            val_0.inited = false;
            mem[1152921510119825265] = 0;
            val_0.fakeValue.y = 0f;
            val_0.fakeValue.z = 0f;
            val_0.currentCryptoKey = 0;
            val_0.hiddenValue.x = 0;
            val_0.hiddenValue.y = 0;
            val_0.hiddenValue.z = 0;
        }
        public static bool op_Equality(CodeStage.AntiCheat.ObscuredTypes.ObscuredVector3 lhs, CodeStage.AntiCheat.ObscuredTypes.ObscuredVector3 rhs)
        {
            return UnityEngine.Vector3.op_Equality(lhs:  new UnityEngine.Vector3() {x = V0.16B, y = V1.16B, z = V2.16B}, rhs:  new UnityEngine.Vector3() {x = V0.16B, y = V1.16B, z = V2.16B});
        }
        public static bool op_Equality(UnityEngine.Vector3 lhs, CodeStage.AntiCheat.ObscuredTypes.ObscuredVector3 rhs)
        {
            return UnityEngine.Vector3.op_Equality(lhs:  new UnityEngine.Vector3() {x = lhs.x, y = lhs.y, z = lhs.z}, rhs:  new UnityEngine.Vector3() {x = lhs.x, y = lhs.y, z = lhs.z});
        }
        public static bool op_Equality(CodeStage.AntiCheat.ObscuredTypes.ObscuredVector3 lhs, UnityEngine.Vector3 rhs)
        {
            return UnityEngine.Vector3.op_Equality(lhs:  new UnityEngine.Vector3() {x = rhs.x, y = rhs.y, z = rhs.z}, rhs:  new UnityEngine.Vector3() {x = rhs.x, y = rhs.y, z = rhs.z});
        }
        public static bool op_Inequality(CodeStage.AntiCheat.ObscuredTypes.ObscuredVector3 lhs, CodeStage.AntiCheat.ObscuredTypes.ObscuredVector3 rhs)
        {
            return UnityEngine.Vector3.op_Inequality(lhs:  new UnityEngine.Vector3() {x = V0.16B, y = V1.16B, z = V2.16B}, rhs:  new UnityEngine.Vector3() {x = V0.16B, y = V1.16B, z = V2.16B});
        }
        public static bool op_Inequality(UnityEngine.Vector3 lhs, CodeStage.AntiCheat.ObscuredTypes.ObscuredVector3 rhs)
        {
            return UnityEngine.Vector3.op_Inequality(lhs:  new UnityEngine.Vector3() {x = lhs.x, y = lhs.y, z = lhs.z}, rhs:  new UnityEngine.Vector3() {x = lhs.x, y = lhs.y, z = lhs.z});
        }
        public static bool op_Inequality(CodeStage.AntiCheat.ObscuredTypes.ObscuredVector3 lhs, UnityEngine.Vector3 rhs)
        {
            return UnityEngine.Vector3.op_Inequality(lhs:  new UnityEngine.Vector3() {x = rhs.x, y = rhs.y, z = rhs.z}, rhs:  new UnityEngine.Vector3() {x = rhs.x, y = rhs.y, z = rhs.z});
        }
        public override bool Equals(object other)
        {
            return false;
        }
        public override int GetHashCode()
        {
            return (int);
        }
        public override string ToString()
        {
            return (string);
        }
        public string ToString(string format)
        {
            return (string);
        }
        private static ObscuredVector3()
        {
            CodeStage.AntiCheat.ObscuredTypes.ObscuredVector3.cryptoKey = 120207;
            UnityEngine.Vector3 val_1 = UnityEngine.Vector3.zero;
            CodeStage.AntiCheat.ObscuredTypes.ObscuredVector3.zero = val_1.x;
            CodeStage.AntiCheat.ObscuredTypes.ObscuredVector3.cryptoKey.__il2cppRuntimeField_8 = val_1.y;
            CodeStage.AntiCheat.ObscuredTypes.ObscuredVector3.cryptoKey.__il2cppRuntimeField_C = val_1.z;
        }
    
    }

}
