using UnityEngine;

namespace CodeStage.AntiCheat.ObscuredTypes
{
    [Serializable]
    public struct ObscuredQuaternion
    {
        // Fields
        private static int cryptoKey;
        private static readonly UnityEngine.Quaternion identity;
        [UnityEngine.SerializeField]
        private int currentCryptoKey;
        [UnityEngine.SerializeField]
        private CodeStage.AntiCheat.ObscuredTypes.ObscuredQuaternion.RawEncryptedQuaternion hiddenValue;
        [UnityEngine.SerializeField]
        private bool inited;
        [UnityEngine.SerializeField]
        private UnityEngine.Quaternion fakeValue;
        [UnityEngine.SerializeField]
        private bool fakeValueActive;
        
        // Methods
        private ObscuredQuaternion(UnityEngine.Quaternion value)
        {
            var val_3;
            var val_4;
            val_3 = null;
            val_3 = null;
            mem[1152921510092050688] = CodeStage.AntiCheat.ObscuredTypes.ObscuredQuaternion.cryptoKey;
            RawEncryptedQuaternion val_1 = CodeStage.AntiCheat.ObscuredTypes.ObscuredQuaternion.Encrypt(x:  value.x, y:  value.y, z:  value.z, w:  value.w, key:  230297600);
            .hiddenValue = val_1;
            mem[1152921510092050700] = val_1.z;
            mem[1152921510092050704] = val_1.w;
            if(CodeStage.AntiCheat.Detectors.ObscuredCheatingDetector.IsRunning != false)
            {
                    .fakeValue = value;
                mem[1152921510092050716] = value.y;
                mem[1152921510092050720] = value.z;
                mem[1152921510092050724] = value.w;
                .fakeValueActive = true;
            }
            else
            {
                    val_4 = null;
                val_4 = null;
                .fakeValueActive = false;
                .fakeValue = CodeStage.AntiCheat.ObscuredTypes.ObscuredQuaternion.identity;
            }
            
            .inited = true;
        }
        public ObscuredQuaternion(float x, float y, float z, float w)
        {
        
        }
        public static void SetNewCryptoKey(int newKey)
        {
            null = null;
            CodeStage.AntiCheat.ObscuredTypes.ObscuredQuaternion.cryptoKey = W1;
        }
        public static CodeStage.AntiCheat.ObscuredTypes.ObscuredQuaternion.RawEncryptedQuaternion Encrypt(UnityEngine.Quaternion value)
        {
            return CodeStage.AntiCheat.ObscuredTypes.ObscuredQuaternion.Encrypt(value:  new UnityEngine.Quaternion() {x = value.x, y = value.y, z = value.z, w = value.w}, key:  230297600);
        }
        public static CodeStage.AntiCheat.ObscuredTypes.ObscuredQuaternion.RawEncryptedQuaternion Encrypt(UnityEngine.Quaternion value, int key)
        {
            return CodeStage.AntiCheat.ObscuredTypes.ObscuredQuaternion.Encrypt(x:  value.x, y:  value.y, z:  value.z, w:  value.w, key:  230297600);
        }
        public static CodeStage.AntiCheat.ObscuredTypes.ObscuredQuaternion.RawEncryptedQuaternion Encrypt(float x, float y, float z, float w, int key)
        {
            int val_3;
            var val_4;
            val_3 = W1;
            if(val_3 == 0)
            {
                    val_4 = null;
                val_4 = null;
                val_3 = CodeStage.AntiCheat.ObscuredTypes.ObscuredQuaternion.cryptoKey;
            }
            
            float val_3 = y;
            float val_4 = w;
            val_3 = val_3 ^ val_3;
            val_4 = val_3 ^ val_4;
            return new RawEncryptedQuaternion() {x = val_3 ^ x, y = val_3, z = val_3 ^ z, w = val_4};
        }
        public static UnityEngine.Quaternion Decrypt(CodeStage.AntiCheat.ObscuredTypes.ObscuredQuaternion.RawEncryptedQuaternion value)
        {
            return CodeStage.AntiCheat.ObscuredTypes.ObscuredQuaternion.Decrypt(value:  new RawEncryptedQuaternion() {x = 230297600, y = 268435456, z = value.z, w = value.w}, key:  X2);
        }
        public static UnityEngine.Quaternion Decrypt(CodeStage.AntiCheat.ObscuredTypes.ObscuredQuaternion.RawEncryptedQuaternion value, int key)
        {
            int val_5;
            var val_6;
            val_5 = W3;
            if(val_5 == 0)
            {
                    val_6 = null;
                val_6 = null;
                val_5 = CodeStage.AntiCheat.ObscuredTypes.ObscuredQuaternion.cryptoKey;
            }
            
            int val_2 = value.z >> 32;
            int val_4 = key >> 32;
            val_2 = val_5 ^ val_2;
            val_4 = val_5 ^ val_4;
            return new UnityEngine.Quaternion() {x = val_5 ^ value.z, y = val_2, z = val_5 ^ key, w = val_4};
        }
        public void ApplyNewCryptoKey()
        {
            do
            {
                int val_1 = UnityEngine.Random.Range(min:  0, max:  -2147483648);
                mem[1152921510092946688] = val_1;
            }
            while(val_1 == 0);
            
            RawEncryptedQuaternion val_2 = CodeStage.AntiCheat.ObscuredTypes.ObscuredQuaternion.Encrypt(value:  new UnityEngine.Quaternion() {x = V0.16B, y = V1.16B, z = V2.16B, w = V3.16B}, key:  230297600);
            mem[1152921510092946700] = val_2.z;
            mem[1152921510092946704] = val_2.w;
            .hiddenValue = val_2;
        }
        public void RandomizeCryptoKey()
        {
        
        }
        public CodeStage.AntiCheat.ObscuredTypes.ObscuredQuaternion.RawEncryptedQuaternion GetEncrypted()
        {
            return new RawEncryptedQuaternion() {x = this.inited, y = this.inited};
        }
        public void SetEncrypted(CodeStage.AntiCheat.ObscuredTypes.ObscuredQuaternion.RawEncryptedQuaternion encrypted)
        {
        
        }
        public UnityEngine.Quaternion GetDecrypted()
        {
            float val_6 = System.Math.Abs(V0.16B - V4.16B);
            if(val_6 >= 0)
            {
                    return new UnityEngine.Quaternion() {x = CodeStage.AntiCheat.Detectors.ObscuredCheatingDetector.<Instance>k__BackingField.quaternionEpsilon, y = val_6};
            }
            
            if((System.Math.Abs(V1.16B - V5.16B)) >= 0)
            {
                    return new UnityEngine.Quaternion() {x = CodeStage.AntiCheat.Detectors.ObscuredCheatingDetector.<Instance>k__BackingField.quaternionEpsilon, y = val_6};
            }
            
            if((System.Math.Abs(V2.16B - V6.16B)) >= 0)
            {
                    return new UnityEngine.Quaternion() {x = CodeStage.AntiCheat.Detectors.ObscuredCheatingDetector.<Instance>k__BackingField.quaternionEpsilon, y = val_6};
            }
            
            var val_5 = ((System.Math.Abs(V3.16B - V7.16B)) < 0) ? 1 : 0;
            return new UnityEngine.Quaternion() {x = CodeStage.AntiCheat.Detectors.ObscuredCheatingDetector.<Instance>k__BackingField.quaternionEpsilon, y = val_6};
        }
        private UnityEngine.Quaternion InternalDecrypt()
        {
        
        }
        private bool CompareQuaternionsWithTolerance(UnityEngine.Quaternion q1, UnityEngine.Quaternion q2)
        {
        
        }
        public static CodeStage.AntiCheat.ObscuredTypes.ObscuredQuaternion op_Implicit(UnityEngine.Quaternion value)
        {
            val_0.fakeValueActive = false;
            mem[1152921510093766713] = 0;
            val_0.fakeValue.x = 0f;
            val_0.fakeValue.y = 0f;
            val_0.fakeValue.z = 0f;
            val_0.fakeValue.w = 0f;
            val_0.hiddenValue.y = 0;
            val_0.hiddenValue.z = 0;
            val_0.hiddenValue.w = 0;
            val_0.inited = false;
            mem[1152921510093766693] = 0;
            val_0.currentCryptoKey = 0;
            val_0.hiddenValue.x = 0;
        }
        public static UnityEngine.Quaternion op_Implicit(CodeStage.AntiCheat.ObscuredTypes.ObscuredQuaternion value)
        {
            return new UnityEngine.Quaternion();
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
        
        }
        private static ObscuredQuaternion()
        {
            CodeStage.AntiCheat.ObscuredTypes.ObscuredQuaternion.cryptoKey = 120205;
            UnityEngine.Quaternion val_1 = UnityEngine.Quaternion.identity;
            CodeStage.AntiCheat.ObscuredTypes.ObscuredQuaternion.identity = val_1.x;
            CodeStage.AntiCheat.ObscuredTypes.ObscuredQuaternion.cryptoKey.__il2cppRuntimeField_8 = val_1.y;
            CodeStage.AntiCheat.ObscuredTypes.ObscuredQuaternion.cryptoKey.__il2cppRuntimeField_C = val_1.z;
            CodeStage.AntiCheat.ObscuredTypes.ObscuredQuaternion.cryptoKey.__il2cppRuntimeField_10 = val_1.w;
        }
    
    }

}
