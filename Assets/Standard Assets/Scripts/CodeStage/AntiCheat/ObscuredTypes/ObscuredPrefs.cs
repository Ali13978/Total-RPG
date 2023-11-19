using UnityEngine;

namespace CodeStage.AntiCheat.ObscuredTypes
{
    public static class ObscuredPrefs
    {
        // Fields
        private const byte VERSION = 2;
        private const string RAW_NOT_FOUND = "{not_found}";
        private const string DATA_SEPARATOR = "|";
        private static bool foreignSavesReported;
        private static string cryptoKey;
        private static string deviceId;
        private static uint deviceIdHash;
        public static System.Action onAlterationDetected;
        public static bool preservePlayerPrefs;
        public static System.Action onPossibleForeignSavesDetected;
        public static CodeStage.AntiCheat.ObscuredTypes.ObscuredPrefs.DeviceLockLevel lockToDevice;
        public static bool readForeignSaves;
        public static bool emergencyMode;
        private const char DEPRECATED_RAW_SEPARATOR = '\x3a';
        private static string deprecatedDeviceId;
        
        // Properties
        public static string CryptoKey { get; set; }
        public static string DeviceId { get; set; }
        [System.ObsoleteAttribute]
        internal static string DeviceID { get; set; }
        private static uint DeviceIdHash { get; }
        private static string DeprecatedDeviceId { get; }
        
        // Methods
        public static void set_CryptoKey(string value)
        {
            null = null;
            CodeStage.AntiCheat.ObscuredTypes.ObscuredPrefs.cryptoKey = X1;
        }
        public static string get_CryptoKey()
        {
            null = null;
            return (string)CodeStage.AntiCheat.ObscuredTypes.ObscuredPrefs.cryptoKey;
        }
        public static string get_DeviceId()
        {
            var val_3;
            var val_4;
            val_3 = null;
            val_3 = null;
            if((System.String.IsNullOrEmpty(value:  0)) != false)
            {
                    CodeStage.AntiCheat.ObscuredTypes.ObscuredPrefs.deviceId = CodeStage.AntiCheat.ObscuredTypes.ObscuredPrefs.GetDeviceId();
            }
            
            val_4 = null;
            val_4 = null;
            return (string)CodeStage.AntiCheat.ObscuredTypes.ObscuredPrefs.deviceId;
        }
        public static void set_DeviceId(string value)
        {
            null = null;
            CodeStage.AntiCheat.ObscuredTypes.ObscuredPrefs.deviceId = X1;
        }
        internal static string get_DeviceID()
        {
            return CodeStage.AntiCheat.ObscuredTypes.ObscuredPrefs.DeviceId;
        }
        internal static void set_DeviceID(string value)
        {
            CodeStage.AntiCheat.ObscuredTypes.ObscuredPrefs.DeviceId = null;
        }
        private static uint get_DeviceIdHash()
        {
            var val_3 = null;
            if(CodeStage.AntiCheat.ObscuredTypes.ObscuredPrefs.deviceIdHash == 0)
            {
                    CodeStage.AntiCheat.ObscuredTypes.ObscuredPrefs.deviceIdHash = CodeStage.AntiCheat.ObscuredTypes.ObscuredPrefs.CalculateChecksum(input:  CodeStage.AntiCheat.ObscuredTypes.ObscuredPrefs.DeviceId);
                val_3 = null;
            }
            
            val_3 = null;
            return (uint)CodeStage.AntiCheat.ObscuredTypes.ObscuredPrefs.deviceIdHash;
        }
        public static void ForceLockToDeviceInit()
        {
            null = null;
            if((System.String.IsNullOrEmpty(value:  0)) != false)
            {
                    string val_2 = CodeStage.AntiCheat.ObscuredTypes.ObscuredPrefs.GetDeviceId();
                CodeStage.AntiCheat.ObscuredTypes.ObscuredPrefs.deviceId = val_2;
                CodeStage.AntiCheat.ObscuredTypes.ObscuredPrefs.deviceIdHash = CodeStage.AntiCheat.ObscuredTypes.ObscuredPrefs.CalculateChecksum(input:  val_2);
                return;
            }
            
            UnityEngine.Debug.LogWarning(message:  0);
        }
        [System.ObsoleteAttribute]
        internal static void SetNewCryptoKey(string newKey)
        {
            CodeStage.AntiCheat.ObscuredTypes.ObscuredPrefs.CryptoKey = null;
        }
        public static void SetInt(string key, int value)
        {
            string val_1 = CodeStage.AntiCheat.ObscuredTypes.ObscuredPrefs.EncryptKey(key:  null);
            string val_2 = CodeStage.AntiCheat.ObscuredTypes.ObscuredPrefs.EncryptIntValue(key:  val_1, value:  value);
            UnityEngine.PlayerPrefs.SetString(key:  0, value:  val_1);
        }
        public static int GetInt(string key)
        {
            return CodeStage.AntiCheat.ObscuredTypes.ObscuredPrefs.GetInt(key:  null, defaultValue:  X1);
        }
        public static int GetInt(string key, int defaultValue)
        {
            var val_9;
            string val_10;
            string val_11;
            string val_12;
            val_9 = W2;
            val_10 = CodeStage.AntiCheat.ObscuredTypes.ObscuredPrefs.EncryptKey(key:  null);
            if((UnityEngine.PlayerPrefs.HasKey(key:  0)) != true)
            {
                    if((UnityEngine.PlayerPrefs.HasKey(key:  0)) != false)
            {
                    val_11 = 0;
                val_12 = null;
                val_9 = UnityEngine.PlayerPrefs.GetInt(key:  val_11, defaultValue:  defaultValue);
                val_11 = val_12;
                val_12 = null;
                if(CodeStage.AntiCheat.ObscuredTypes.ObscuredPrefs.preservePlayerPrefs == true)
            {
                    return (int)val_9;
            }
            
                val_11 = val_12;
                CodeStage.AntiCheat.ObscuredTypes.ObscuredPrefs.SetInt(key:  val_11, value:  defaultValue);
                UnityEngine.PlayerPrefs.DeleteKey(key:  0);
                return (int)val_9;
            }
            
            }
            
            val_10 = CodeStage.AntiCheat.ObscuredTypes.ObscuredPrefs.GetEncryptedPrefsString(key:  null, encryptedKey:  defaultValue);
            if((System.String.op_Equality(a:  0, b:  val_10)) == false)
            {
                    return CodeStage.AntiCheat.ObscuredTypes.ObscuredPrefs.DecryptIntValue(key:  null, encryptedInput:  defaultValue, defaultValue:  val_10);
            }
            
            return (int)val_9;
        }
        internal static string EncryptIntValue(string key, int value)
        {
            return CodeStage.AntiCheat.ObscuredTypes.ObscuredPrefs.EncryptData(key:  null = null, cleanBytes:  value, type:  System.BitConverter.GetBytes(value:  0));
        }
        internal static int DecryptIntValue(string key, string encryptedInput, int defaultValue)
        {
            var val_11;
            string val_12;
            int val_13;
            var val_14;
            string val_15;
            var val_16;
            string val_17;
            val_11 = W3;
            val_12 = defaultValue;
            val_13 = encryptedInput;
            val_14 = val_12;
            if(((val_14.IndexOf(value:  ':')) & 2147483648) == 0)
            {
                    val_15 = null;
                val_12 = CodeStage.AntiCheat.ObscuredTypes.ObscuredPrefs.DeprecatedDecryptValue(value:  val_15);
                val_16 = null;
                val_16 = null;
                if((System.String.op_Equality(a:  0, b:  val_12)) == true)
            {
                    return (int)val_11;
            }
            
                bool val_8 = System.Int32.TryParse(s:  0, result: out  val_12);
                CodeStage.AntiCheat.ObscuredTypes.ObscuredPrefs.SetInt(key:  null, value:  val_13);
                val_11 = 0;
                return (int)val_11;
            }
            
            val_17 = null;
            val_13 = CodeStage.AntiCheat.ObscuredTypes.ObscuredPrefs.DecryptData(key:  val_17, encryptedInput:  val_13);
            if(val_13 == null)
            {
                    return (int)val_11;
            }
            
            val_11 = System.BitConverter.ToInt32(value:  0, startIndex:  val_13);
            return (int)val_11;
        }
        public static void SetUInt(string key, uint value)
        {
            string val_1 = CodeStage.AntiCheat.ObscuredTypes.ObscuredPrefs.EncryptKey(key:  null);
            string val_2 = CodeStage.AntiCheat.ObscuredTypes.ObscuredPrefs.EncryptUIntValue(key:  val_1, value:  value);
            UnityEngine.PlayerPrefs.SetString(key:  0, value:  val_1);
        }
        public static uint GetUInt(string key)
        {
            return CodeStage.AntiCheat.ObscuredTypes.ObscuredPrefs.GetUInt(key:  null, defaultValue:  X1);
        }
        public static uint GetUInt(string key, uint defaultValue)
        {
            string val_2 = CodeStage.AntiCheat.ObscuredTypes.ObscuredPrefs.GetEncryptedPrefsString(key:  CodeStage.AntiCheat.ObscuredTypes.ObscuredPrefs.EncryptKey(key:  null), encryptedKey:  defaultValue);
            if((System.String.op_Equality(a:  0, b:  val_2)) == false)
            {
                    return CodeStage.AntiCheat.ObscuredTypes.ObscuredPrefs.DecryptUIntValue(key:  null, encryptedInput:  defaultValue, defaultValue:  val_2);
            }
            
            return (uint)W2;
        }
        private static string EncryptUIntValue(string key, uint value)
        {
            return CodeStage.AntiCheat.ObscuredTypes.ObscuredPrefs.EncryptData(key:  null = null, cleanBytes:  value, type:  System.BitConverter.GetBytes(value:  0));
        }
        private static uint DecryptUIntValue(string key, string encryptedInput, uint defaultValue)
        {
            var val_11;
            string val_12;
            uint val_13;
            var val_14;
            string val_15;
            var val_16;
            string val_17;
            val_11 = W3;
            val_12 = defaultValue;
            val_13 = encryptedInput;
            val_14 = val_12;
            if(((val_14.IndexOf(value:  ':')) & 2147483648) == 0)
            {
                    val_15 = null;
                val_12 = CodeStage.AntiCheat.ObscuredTypes.ObscuredPrefs.DeprecatedDecryptValue(value:  val_15);
                val_16 = null;
                val_16 = null;
                if((System.String.op_Equality(a:  0, b:  val_12)) == true)
            {
                    return (uint)val_11;
            }
            
                bool val_8 = System.UInt32.TryParse(s:  0, result: out  val_12);
                CodeStage.AntiCheat.ObscuredTypes.ObscuredPrefs.SetUInt(key:  null, value:  val_13);
                val_11 = 0;
                return (uint)val_11;
            }
            
            val_17 = null;
            val_13 = CodeStage.AntiCheat.ObscuredTypes.ObscuredPrefs.DecryptData(key:  val_17, encryptedInput:  val_13);
            if(val_13 == null)
            {
                    return (uint)val_11;
            }
            
            val_11 = System.BitConverter.ToUInt32(value:  0, startIndex:  val_13);
            return (uint)val_11;
        }
        public static void SetString(string key, string value)
        {
            string val_1 = CodeStage.AntiCheat.ObscuredTypes.ObscuredPrefs.EncryptKey(key:  null);
            string val_2 = CodeStage.AntiCheat.ObscuredTypes.ObscuredPrefs.EncryptStringValue(key:  val_1, value:  value);
            UnityEngine.PlayerPrefs.SetString(key:  0, value:  val_1);
        }
        public static string GetString(string key)
        {
            null = null;
            return CodeStage.AntiCheat.ObscuredTypes.ObscuredPrefs.GetString(key:  null, defaultValue:  X1);
        }
        public static string GetString(string key, string defaultValue)
        {
            var val_9;
            string val_10;
            string val_11;
            string val_12;
            val_9 = X2;
            val_10 = CodeStage.AntiCheat.ObscuredTypes.ObscuredPrefs.EncryptKey(key:  null);
            if((UnityEngine.PlayerPrefs.HasKey(key:  0)) != true)
            {
                    if((UnityEngine.PlayerPrefs.HasKey(key:  0)) != false)
            {
                    val_12 = null;
                val_9 = UnityEngine.PlayerPrefs.GetString(key:  0, defaultValue:  defaultValue);
                val_11 = val_12;
                val_12 = null;
                if(CodeStage.AntiCheat.ObscuredTypes.ObscuredPrefs.preservePlayerPrefs == true)
            {
                    return (string)val_9;
            }
            
                val_11 = val_12;
                CodeStage.AntiCheat.ObscuredTypes.ObscuredPrefs.SetString(key:  val_11, value:  defaultValue);
                UnityEngine.PlayerPrefs.DeleteKey(key:  0);
                return (string)val_9;
            }
            
            }
            
            val_10 = CodeStage.AntiCheat.ObscuredTypes.ObscuredPrefs.GetEncryptedPrefsString(key:  null, encryptedKey:  defaultValue);
            if((System.String.op_Equality(a:  0, b:  val_10)) == false)
            {
                    return CodeStage.AntiCheat.ObscuredTypes.ObscuredPrefs.DecryptStringValue(key:  null, encryptedInput:  defaultValue, defaultValue:  val_10);
            }
            
            return (string)val_9;
        }
        internal static string EncryptStringValue(string key, string value)
        {
            string val_2 = System.Text.Encoding.UTF8;
            val_2 = null;
            return CodeStage.AntiCheat.ObscuredTypes.ObscuredPrefs.EncryptData(key:  val_2, cleanBytes:  value, type:  val_2 = System.Text.Encoding.UTF8);
        }
        internal static string DecryptStringValue(string key, string encryptedInput, string defaultValue)
        {
            var val_17;
            string val_18;
            string val_19;
            var val_20;
            string val_21;
            var val_22;
            var val_23;
            string val_24;
            val_17 = X3;
            val_18 = defaultValue;
            val_19 = encryptedInput;
            val_20 = val_18;
            if(((val_20.IndexOf(value:  ':')) & 2147483648) == 0)
            {
                    val_21 = null;
                val_22 = 1152921504608284672;
                val_18 = CodeStage.AntiCheat.ObscuredTypes.ObscuredPrefs.DeprecatedDecryptValue(value:  val_21);
                val_23 = null;
                val_23 = null;
                if((System.String.op_Equality(a:  0, b:  val_18)) == true)
            {
                    return (string)val_17;
            }
            
                CodeStage.AntiCheat.ObscuredTypes.ObscuredPrefs.SetString(key:  null, value:  val_19);
                val_17 = val_18;
                return (string)val_17;
            }
            
            val_24 = null;
            val_19 = CodeStage.AntiCheat.ObscuredTypes.ObscuredPrefs.DecryptData(key:  val_24, encryptedInput:  val_19);
            if(val_19 == null)
            {
                    return (string)val_17;
            }
            
            System.Text.Encoding val_8 = System.Text.Encoding.UTF8;
            val_17 = ???;
            val_19 = ???;
            val_18 = ???;
            val_22 = ???;
            goto typeof(System.Text.Encoding).__il2cppRuntimeField_260;
        }
        public static void SetFloat(string key, float value)
        {
            string val_1 = CodeStage.AntiCheat.ObscuredTypes.ObscuredPrefs.EncryptKey(key:  null);
            string val_2 = CodeStage.AntiCheat.ObscuredTypes.ObscuredPrefs.EncryptFloatValue(key:  val_1, value:  value);
            UnityEngine.PlayerPrefs.SetString(key:  0, value:  val_1);
        }
        public static float GetFloat(string key)
        {
            return CodeStage.AntiCheat.ObscuredTypes.ObscuredPrefs.GetFloat(key:  null, defaultValue:  0f);
        }
        public static float GetFloat(string key, float defaultValue)
        {
            float val_9;
            string val_10;
            val_9 = defaultValue;
            string val_1 = CodeStage.AntiCheat.ObscuredTypes.ObscuredPrefs.EncryptKey(key:  null);
            if((UnityEngine.PlayerPrefs.HasKey(key:  0)) != true)
            {
                    if((UnityEngine.PlayerPrefs.HasKey(key:  0)) != false)
            {
                    val_10 = null;
                val_9 = UnityEngine.PlayerPrefs.GetFloat(key:  0, defaultValue:  val_9);
                val_10 = null;
                if(CodeStage.AntiCheat.ObscuredTypes.ObscuredPrefs.preservePlayerPrefs == true)
            {
                    return val_9;
            }
            
                CodeStage.AntiCheat.ObscuredTypes.ObscuredPrefs.SetFloat(key:  val_10, value:  val_9);
                UnityEngine.PlayerPrefs.DeleteKey(key:  0);
                return val_9;
            }
            
            }
            
            if((System.String.op_Equality(a:  0, b:  CodeStage.AntiCheat.ObscuredTypes.ObscuredPrefs.GetEncryptedPrefsString(key:  null, encryptedKey:  X1))) == false)
            {
                    return CodeStage.AntiCheat.ObscuredTypes.ObscuredPrefs.DecryptFloatValue(key:  null, encryptedInput:  X1, defaultValue:  val_9);
            }
            
            return val_9;
        }
        internal static string EncryptFloatValue(string key, float value)
        {
            return CodeStage.AntiCheat.ObscuredTypes.ObscuredPrefs.EncryptData(key:  null = null, cleanBytes:  X1, type:  System.BitConverter.GetBytes(value:  value));
        }
        internal static float DecryptFloatValue(string key, string encryptedInput, float defaultValue)
        {
            float val_11;
            string val_12;
            var val_13;
            string val_14;
            var val_15;
            string val_16;
            val_11 = defaultValue;
            val_12 = encryptedInput;
            val_13 = X2;
            if(((val_13.IndexOf(value:  ':')) & 2147483648) == 0)
            {
                    val_14 = null;
                string val_4 = CodeStage.AntiCheat.ObscuredTypes.ObscuredPrefs.DeprecatedDecryptValue(value:  val_14);
                val_15 = null;
                val_15 = null;
                if((System.String.op_Equality(a:  0, b:  val_4)) == true)
            {
                    return (float)val_11;
            }
            
                bool val_8 = System.Single.TryParse(s:  0, result: out  val_4);
                CodeStage.AntiCheat.ObscuredTypes.ObscuredPrefs.SetFloat(key:  null, value:  0f);
                val_11 = 0f;
                return (float)val_11;
            }
            
            val_16 = null;
            val_12 = CodeStage.AntiCheat.ObscuredTypes.ObscuredPrefs.DecryptData(key:  val_16, encryptedInput:  val_12);
            if(val_12 == null)
            {
                    return (float)val_11;
            }
            
            val_11 = System.BitConverter.ToSingle(value:  0, startIndex:  val_12);
            return (float)val_11;
        }
        public static void SetDouble(string key, double value)
        {
            string val_1 = CodeStage.AntiCheat.ObscuredTypes.ObscuredPrefs.EncryptKey(key:  null);
            string val_2 = CodeStage.AntiCheat.ObscuredTypes.ObscuredPrefs.EncryptDoubleValue(key:  val_1, value:  value);
            UnityEngine.PlayerPrefs.SetString(key:  0, value:  val_1);
        }
        public static double GetDouble(string key)
        {
            return CodeStage.AntiCheat.ObscuredTypes.ObscuredPrefs.GetDouble(key:  null, defaultValue:  0);
        }
        public static double GetDouble(string key, double defaultValue)
        {
            if((System.String.op_Equality(a:  0, b:  CodeStage.AntiCheat.ObscuredTypes.ObscuredPrefs.GetEncryptedPrefsString(key:  CodeStage.AntiCheat.ObscuredTypes.ObscuredPrefs.EncryptKey(key:  null), encryptedKey:  X1))) == false)
            {
                    return CodeStage.AntiCheat.ObscuredTypes.ObscuredPrefs.DecryptDoubleValue(key:  null, encryptedInput:  X1, defaultValue:  defaultValue);
            }
            
            return (double)defaultValue;
        }
        private static string EncryptDoubleValue(string key, double value)
        {
            return CodeStage.AntiCheat.ObscuredTypes.ObscuredPrefs.EncryptData(key:  null = null, cleanBytes:  X1, type:  System.BitConverter.GetBytes(value:  value));
        }
        private static double DecryptDoubleValue(string key, string encryptedInput, double defaultValue)
        {
            double val_11;
            string val_12;
            var val_13;
            string val_14;
            var val_15;
            string val_16;
            val_11 = defaultValue;
            val_12 = encryptedInput;
            val_13 = X2;
            if(((val_13.IndexOf(value:  ':')) & 2147483648) == 0)
            {
                    val_14 = null;
                string val_4 = CodeStage.AntiCheat.ObscuredTypes.ObscuredPrefs.DeprecatedDecryptValue(value:  val_14);
                val_15 = null;
                val_15 = null;
                if((System.String.op_Equality(a:  0, b:  val_4)) == true)
            {
                    return (double)val_11;
            }
            
                bool val_8 = System.Double.TryParse(s:  0, result: out  val_4);
                CodeStage.AntiCheat.ObscuredTypes.ObscuredPrefs.SetDouble(key:  null, value:  0);
                val_11 = 0;
                return (double)val_11;
            }
            
            val_16 = null;
            val_12 = CodeStage.AntiCheat.ObscuredTypes.ObscuredPrefs.DecryptData(key:  val_16, encryptedInput:  val_12);
            if(val_12 == null)
            {
                    return (double)val_11;
            }
            
            val_11 = System.BitConverter.ToDouble(value:  0, startIndex:  val_12);
            return (double)val_11;
        }
        public static void SetDecimal(string key, decimal value)
        {
            string val_1 = CodeStage.AntiCheat.ObscuredTypes.ObscuredPrefs.EncryptKey(key:  null);
            string val_2 = CodeStage.AntiCheat.ObscuredTypes.ObscuredPrefs.EncryptDecimalValue(key:  val_1, value:  new System.Decimal() {flags = value.flags, hi = value.hi, lo = value.lo, mid = value.mid});
            UnityEngine.PlayerPrefs.SetString(key:  0, value:  val_1);
        }
        public static decimal GetDecimal(string key)
        {
            decimal val_1 = CodeStage.AntiCheat.ObscuredTypes.ObscuredPrefs.GetDecimal(key:  null, defaultValue:  new System.Decimal() {flags = X1, hi = X1});
            return new System.Decimal() {flags = val_1.flags, hi = val_1.hi, lo = val_1.lo, mid = val_1.mid};
        }
        public static decimal GetDecimal(string key, decimal defaultValue)
        {
            uint val_6;
            uint val_7;
            val_6 = X3;
            val_7 = defaultValue.lo;
            string val_2 = CodeStage.AntiCheat.ObscuredTypes.ObscuredPrefs.GetEncryptedPrefsString(key:  CodeStage.AntiCheat.ObscuredTypes.ObscuredPrefs.EncryptKey(key:  null), encryptedKey:  defaultValue.flags);
            if((System.String.op_Equality(a:  0, b:  val_2)) == true)
            {
                    return new System.Decimal() {flags = val_7, hi = val_5.hi, lo = val_6, mid = val_5.mid};
            }
            
            decimal val_5 = CodeStage.AntiCheat.ObscuredTypes.ObscuredPrefs.DecryptDecimalValue(key:  null, encryptedInput:  defaultValue.flags, defaultValue:  new System.Decimal() {flags = val_2, hi = val_2, lo = val_7, mid = defaultValue.mid});
            val_7 = val_5.flags;
            val_6 = val_5.lo;
            return new System.Decimal() {flags = val_7, hi = val_5.hi, lo = val_6, mid = val_5.mid};
        }
        private static string EncryptDecimalValue(string key, decimal value)
        {
            return CodeStage.AntiCheat.ObscuredTypes.ObscuredPrefs.EncryptData(key:  null = null, cleanBytes:  value.flags, type:  CodeStage.AntiCheat.ObscuredTypes.BitconverterExt.GetBytes(dec:  new System.Decimal() {flags = 18015, lo = value.lo, mid = value.mid}));
        }
        private static decimal DecryptDecimalValue(string key, string encryptedInput, decimal defaultValue)
        {
            uint val_10;
            uint val_11;
            var val_12;
            string val_13;
            var val_14;
            string val_15;
            val_10 = X4;
            val_11 = defaultValue.lo;
            val_12 = defaultValue.flags;
            if(((val_12.IndexOf(value:  ':')) & 2147483648) == 0)
            {
                    val_13 = null;
                string val_4 = CodeStage.AntiCheat.ObscuredTypes.ObscuredPrefs.DeprecatedDecryptValue(value:  val_13);
                val_14 = null;
                val_14 = null;
                if((System.String.op_Equality(a:  0, b:  val_4)) == true)
            {
                    return new System.Decimal() {flags = val_11, hi = val_9.hi, lo = val_10, mid = val_9.mid};
            }
            
                bool val_7 = System.Decimal.TryParse(s:  0, result: out  new System.Decimal() {flags = val_4, hi = val_4, lo = val_4, mid = val_4});
                CodeStage.AntiCheat.ObscuredTypes.ObscuredPrefs.SetDecimal(key:  null, value:  new System.Decimal() {flags = encryptedInput, hi = encryptedInput});
                val_11 = 0;
                val_10 = 0;
                return new System.Decimal() {flags = val_11, hi = val_9.hi, lo = val_10, mid = val_9.mid};
            }
            
            val_15 = null;
            System.Byte[] val_8 = CodeStage.AntiCheat.ObscuredTypes.ObscuredPrefs.DecryptData(key:  val_15, encryptedInput:  encryptedInput);
            if(val_8 == null)
            {
                    return new System.Decimal() {flags = val_11, hi = val_9.hi, lo = val_10, mid = val_9.mid};
            }
            
            decimal val_9 = CodeStage.AntiCheat.ObscuredTypes.BitconverterExt.ToDecimal(bytes:  val_8);
            val_11 = val_9.flags;
            val_10 = val_9.lo;
            return new System.Decimal() {flags = val_11, hi = val_9.hi, lo = val_10, mid = val_9.mid};
        }
        public static void SetLong(string key, long value)
        {
            string val_1 = CodeStage.AntiCheat.ObscuredTypes.ObscuredPrefs.EncryptKey(key:  null);
            string val_2 = CodeStage.AntiCheat.ObscuredTypes.ObscuredPrefs.EncryptLongValue(key:  val_1, value:  value);
            UnityEngine.PlayerPrefs.SetString(key:  0, value:  val_1);
        }
        public static long GetLong(string key)
        {
            return CodeStage.AntiCheat.ObscuredTypes.ObscuredPrefs.GetLong(key:  null, defaultValue:  X1);
        }
        public static long GetLong(string key, long defaultValue)
        {
            string val_2 = CodeStage.AntiCheat.ObscuredTypes.ObscuredPrefs.GetEncryptedPrefsString(key:  CodeStage.AntiCheat.ObscuredTypes.ObscuredPrefs.EncryptKey(key:  null), encryptedKey:  defaultValue);
            if((System.String.op_Equality(a:  0, b:  val_2)) == false)
            {
                    return CodeStage.AntiCheat.ObscuredTypes.ObscuredPrefs.DecryptLongValue(key:  null, encryptedInput:  defaultValue, defaultValue:  val_2);
            }
            
            return (long)X2;
        }
        private static string EncryptLongValue(string key, long value)
        {
            return CodeStage.AntiCheat.ObscuredTypes.ObscuredPrefs.EncryptData(key:  null = null, cleanBytes:  value, type:  System.BitConverter.GetBytes(value:  0));
        }
        private static long DecryptLongValue(string key, string encryptedInput, long defaultValue)
        {
            var val_11;
            string val_12;
            long val_13;
            var val_14;
            string val_15;
            var val_16;
            string val_17;
            val_11 = X3;
            val_12 = defaultValue;
            val_13 = encryptedInput;
            val_14 = val_12;
            if(((val_14.IndexOf(value:  ':')) & 2147483648) == 0)
            {
                    val_15 = null;
                val_12 = CodeStage.AntiCheat.ObscuredTypes.ObscuredPrefs.DeprecatedDecryptValue(value:  val_15);
                val_16 = null;
                val_16 = null;
                if((System.String.op_Equality(a:  0, b:  val_12)) == true)
            {
                    return (long)val_11;
            }
            
                bool val_8 = System.Int64.TryParse(s:  0, result: out  val_12);
                CodeStage.AntiCheat.ObscuredTypes.ObscuredPrefs.SetLong(key:  null, value:  val_13);
                val_11 = 0;
                return (long)val_11;
            }
            
            val_17 = null;
            val_13 = CodeStage.AntiCheat.ObscuredTypes.ObscuredPrefs.DecryptData(key:  val_17, encryptedInput:  val_13);
            if(val_13 == null)
            {
                    return (long)val_11;
            }
            
            val_11 = System.BitConverter.ToInt64(value:  0, startIndex:  val_13);
            return (long)val_11;
        }
        public static void SetULong(string key, ulong value)
        {
            string val_1 = CodeStage.AntiCheat.ObscuredTypes.ObscuredPrefs.EncryptKey(key:  null);
            string val_2 = CodeStage.AntiCheat.ObscuredTypes.ObscuredPrefs.EncryptULongValue(key:  val_1, value:  value);
            UnityEngine.PlayerPrefs.SetString(key:  0, value:  val_1);
        }
        public static ulong GetULong(string key)
        {
            return CodeStage.AntiCheat.ObscuredTypes.ObscuredPrefs.GetULong(key:  null, defaultValue:  X1);
        }
        public static ulong GetULong(string key, ulong defaultValue)
        {
            string val_2 = CodeStage.AntiCheat.ObscuredTypes.ObscuredPrefs.GetEncryptedPrefsString(key:  CodeStage.AntiCheat.ObscuredTypes.ObscuredPrefs.EncryptKey(key:  null), encryptedKey:  defaultValue);
            if((System.String.op_Equality(a:  0, b:  val_2)) == false)
            {
                    return CodeStage.AntiCheat.ObscuredTypes.ObscuredPrefs.DecryptULongValue(key:  null, encryptedInput:  defaultValue, defaultValue:  val_2);
            }
            
            return (ulong)X2;
        }
        private static string EncryptULongValue(string key, ulong value)
        {
            return CodeStage.AntiCheat.ObscuredTypes.ObscuredPrefs.EncryptData(key:  null = null, cleanBytes:  value, type:  System.BitConverter.GetBytes(value:  0));
        }
        private static ulong DecryptULongValue(string key, string encryptedInput, ulong defaultValue)
        {
            var val_11;
            string val_12;
            ulong val_13;
            var val_14;
            string val_15;
            var val_16;
            string val_17;
            val_11 = X3;
            val_12 = defaultValue;
            val_13 = encryptedInput;
            val_14 = val_12;
            if(((val_14.IndexOf(value:  ':')) & 2147483648) == 0)
            {
                    val_15 = null;
                val_12 = CodeStage.AntiCheat.ObscuredTypes.ObscuredPrefs.DeprecatedDecryptValue(value:  val_15);
                val_16 = null;
                val_16 = null;
                if((System.String.op_Equality(a:  0, b:  val_12)) == true)
            {
                    return (ulong)val_11;
            }
            
                bool val_8 = System.UInt64.TryParse(s:  0, result: out  val_12);
                CodeStage.AntiCheat.ObscuredTypes.ObscuredPrefs.SetULong(key:  null, value:  val_13);
                val_11 = 0;
                return (ulong)val_11;
            }
            
            val_17 = null;
            val_13 = CodeStage.AntiCheat.ObscuredTypes.ObscuredPrefs.DecryptData(key:  val_17, encryptedInput:  val_13);
            if(val_13 == null)
            {
                    return (ulong)val_11;
            }
            
            val_11 = System.BitConverter.ToUInt64(value:  0, startIndex:  val_13);
            return (ulong)val_11;
        }
        public static void SetBool(string key, bool value)
        {
            string val_1 = CodeStage.AntiCheat.ObscuredTypes.ObscuredPrefs.EncryptKey(key:  null);
            var val_2 = W2 & 1;
            string val_3 = CodeStage.AntiCheat.ObscuredTypes.ObscuredPrefs.EncryptBoolValue(key:  val_1, value:  value);
            UnityEngine.PlayerPrefs.SetString(key:  0, value:  val_1);
        }
        public static bool GetBool(string key)
        {
            return CodeStage.AntiCheat.ObscuredTypes.ObscuredPrefs.GetBool(key:  null, defaultValue:  X1);
        }
        public static bool GetBool(string key, bool defaultValue)
        {
            string val_2 = CodeStage.AntiCheat.ObscuredTypes.ObscuredPrefs.GetEncryptedPrefsString(key:  CodeStage.AntiCheat.ObscuredTypes.ObscuredPrefs.EncryptKey(key:  null), encryptedKey:  defaultValue);
            if((System.String.op_Equality(a:  0, b:  val_2)) != false)
            {
                    return (bool)W2 & 1;
            }
            
            var val_6 = W2 & 1;
            return CodeStage.AntiCheat.ObscuredTypes.ObscuredPrefs.DecryptBoolValue(key:  null, encryptedInput:  defaultValue, defaultValue:  val_2);
        }
        private static string EncryptBoolValue(string key, bool value)
        {
            string val_3;
            var val_1 = W2 & 1;
            val_3 = null;
            return CodeStage.AntiCheat.ObscuredTypes.ObscuredPrefs.EncryptData(key:  val_3, cleanBytes:  value, type:  System.BitConverter.GetBytes(value:  false));
        }
        private static bool DecryptBoolValue(string key, string encryptedInput, bool defaultValue)
        {
            var val_13;
            string val_14;
            bool val_15;
            var val_16;
            string val_17;
            var val_18;
            string val_19;
            val_13 = W3;
            val_14 = defaultValue;
            val_15 = encryptedInput;
            val_16 = val_14;
            if(((val_16.IndexOf(value:  ':')) & 2147483648) != 0)
            {
                goto label_2;
            }
            
            val_17 = null;
            val_14 = CodeStage.AntiCheat.ObscuredTypes.ObscuredPrefs.DeprecatedDecryptValue(value:  val_17);
            val_18 = null;
            val_18 = null;
            if((System.String.op_Equality(a:  0, b:  val_14)) == true)
            {
                goto label_13;
            }
            
            bool val_8 = System.Int32.TryParse(s:  0, result: out  val_14);
            var val_9 = (0 == 1) ? 1 : 0;
            CodeStage.AntiCheat.ObscuredTypes.ObscuredPrefs.SetBool(key:  null, value:  val_15);
            var val_10 = (0 == 1) ? 1 : 0;
            goto label_13;
            label_2:
            val_19 = null;
            val_15 = CodeStage.AntiCheat.ObscuredTypes.ObscuredPrefs.DecryptData(key:  val_19, encryptedInput:  val_15);
            if(val_15 != null)
            {
                    bool val_12 = System.BitConverter.ToBoolean(value:  0, startIndex:  val_15);
                val_13 = val_12;
            }
            
            label_13:
            val_12 = val_13;
            return (bool)val_12;
        }
        public static void SetByteArray(string key, byte[] value)
        {
            string val_1 = CodeStage.AntiCheat.ObscuredTypes.ObscuredPrefs.EncryptKey(key:  null);
            string val_2 = CodeStage.AntiCheat.ObscuredTypes.ObscuredPrefs.EncryptByteArrayValue(key:  val_1, value:  value);
            UnityEngine.PlayerPrefs.SetString(key:  0, value:  val_1);
        }
        public static byte[] GetByteArray(string key)
        {
            return CodeStage.AntiCheat.ObscuredTypes.ObscuredPrefs.GetByteArray(key:  null, defaultValue:  X1, defaultLength:  0);
        }
        public static byte[] GetByteArray(string key, byte defaultValue, int defaultLength)
        {
            string val_6;
            var val_7;
            string val_8;
            string val_2 = CodeStage.AntiCheat.ObscuredTypes.ObscuredPrefs.GetEncryptedPrefsString(key:  CodeStage.AntiCheat.ObscuredTypes.ObscuredPrefs.EncryptKey(key:  null), encryptedKey:  defaultValue);
            val_6 = 0;
            if((System.String.op_Equality(a:  val_6, b:  val_2)) != false)
            {
                    val_7 = null;
                return CodeStage.AntiCheat.ObscuredTypes.ObscuredPrefs.ConstructByteArray(value:  0, length:  defaultLength);
            }
            
            val_8 = null;
            return CodeStage.AntiCheat.ObscuredTypes.ObscuredPrefs.DecryptByteArrayValue(key:  val_8, encryptedInput:  defaultValue, defaultValue:  val_2, defaultLength:  defaultLength);
        }
        private static string EncryptByteArrayValue(string key, byte[] value)
        {
            return CodeStage.AntiCheat.ObscuredTypes.ObscuredPrefs.EncryptData(key:  null, cleanBytes:  value, type:  X2);
        }
        private static byte[] DecryptByteArrayValue(string key, string encryptedInput, byte defaultValue, int defaultLength)
        {
            var val_8;
            string val_9;
            var val_10;
            string val_11;
            var val_12;
            string val_13;
            val_8 = defaultValue;
            if(((val_8.IndexOf(value:  ':')) & 2147483648) == 0)
            {
                    val_9 = null;
                val_10 = null;
                val_10 = null;
                if((System.String.op_Equality(a:  0, b:  CodeStage.AntiCheat.ObscuredTypes.ObscuredPrefs.DeprecatedDecryptValue(value:  val_9))) == true)
            {
                    return CodeStage.AntiCheat.ObscuredTypes.ObscuredPrefs.ConstructByteArray(value:  0, length:  defaultLength);
            }
            
                val_11 = System.Text.Encoding.UTF8;
                val_12 = val_11;
                val_11 = null;
                CodeStage.AntiCheat.ObscuredTypes.ObscuredPrefs.SetByteArray(key:  val_11, value:  encryptedInput);
                return (System.Byte[])val_12;
            }
            
            val_13 = null;
            val_12 = CodeStage.AntiCheat.ObscuredTypes.ObscuredPrefs.DecryptData(key:  val_13, encryptedInput:  encryptedInput);
            if(val_12 == null)
            {
                    return CodeStage.AntiCheat.ObscuredTypes.ObscuredPrefs.ConstructByteArray(value:  0, length:  defaultLength);
            }
            
            return (System.Byte[])val_12;
        }
        private static byte[] ConstructByteArray(byte value, int length)
        {
            var val_1 = W2;
            if(val_1 < 1)
            {
                    return (System.Byte[])null;
            }
            
            var val_1 = 0;
            val_1 = val_1;
            do
            {
                System.Byte[].__il2cppRuntimeField_byval_arg.__il2cppRuntimeField_0 = length;
                val_1 = val_1 + 1;
            }
            while(val_1 != val_1);
            
            return (System.Byte[])null;
        }
        public static void SetVector2(string key, UnityEngine.Vector2 value)
        {
            string val_1 = CodeStage.AntiCheat.ObscuredTypes.ObscuredPrefs.EncryptKey(key:  null);
            string val_2 = CodeStage.AntiCheat.ObscuredTypes.ObscuredPrefs.EncryptVector2Value(key:  val_1, value:  new UnityEngine.Vector2() {x = value.x, y = value.y});
            UnityEngine.PlayerPrefs.SetString(key:  0, value:  val_1);
        }
        public static UnityEngine.Vector2 GetVector2(string key)
        {
            UnityEngine.Vector2 val_1 = UnityEngine.Vector2.zero;
            return CodeStage.AntiCheat.ObscuredTypes.ObscuredPrefs.GetVector2(key:  null, defaultValue:  new UnityEngine.Vector2() {x = val_1.x, y = val_1.y});
        }
        public static UnityEngine.Vector2 GetVector2(string key, UnityEngine.Vector2 defaultValue)
        {
            float val_6;
            float val_7;
            val_6 = defaultValue.y;
            val_7 = defaultValue.x;
            if((System.String.op_Equality(a:  0, b:  CodeStage.AntiCheat.ObscuredTypes.ObscuredPrefs.GetEncryptedPrefsString(key:  CodeStage.AntiCheat.ObscuredTypes.ObscuredPrefs.EncryptKey(key:  null), encryptedKey:  X1))) == true)
            {
                    return new UnityEngine.Vector2() {x = val_7, y = val_6};
            }
            
            UnityEngine.Vector2 val_5 = CodeStage.AntiCheat.ObscuredTypes.ObscuredPrefs.DecryptVector2Value(key:  null, encryptedInput:  X1, defaultValue:  new UnityEngine.Vector2() {x = val_7, y = val_6});
            val_7 = val_5.x;
            val_6 = val_5.y;
            return new UnityEngine.Vector2() {x = val_7, y = val_6};
        }
        private static string EncryptVector2Value(string key, UnityEngine.Vector2 value)
        {
            System.Buffer.BlockCopy(src:  0, srcOffset:  System.BitConverter.GetBytes(value:  value.x), dst:  0, dstOffset:  460851360, count:  0);
            System.Buffer.BlockCopy(src:  0, srcOffset:  System.BitConverter.GetBytes(value:  value.y), dst:  0, dstOffset:  460851360, count:  4);
            return CodeStage.AntiCheat.ObscuredTypes.ObscuredPrefs.EncryptData(key:  null, cleanBytes:  X1, type:  null);
        }
        private static UnityEngine.Vector2 DecryptVector2Value(string key, string encryptedInput, UnityEngine.Vector2 defaultValue)
        {
            System.Char[] val_17;
            float val_18;
            float val_19;
            string val_20;
            var val_21;
            string val_22;
            var val_23;
            var val_24;
            string val_25;
            val_18 = defaultValue.y;
            val_19 = defaultValue.x;
            val_20 = encryptedInput;
            val_21 = X2;
            if(((val_21.IndexOf(value:  ':')) & 2147483648) == 0)
            {
                    val_22 = null;
                string val_4 = CodeStage.AntiCheat.ObscuredTypes.ObscuredPrefs.DeprecatedDecryptValue(value:  val_22);
                val_17 = 1152921504608284672;
                val_23 = null;
                val_23 = null;
                if((System.String.op_Equality(a:  0, b:  val_4)) == true)
            {
                    return new UnityEngine.Vector2() {x = val_19, y = val_18};
            }
            
                val_17 = null;
                val_24 = "|";
                if(("|") == null)
            {
                    val_24 = "|";
            }
            
                typeof(System.Char[]).__il2cppRuntimeField_20 = Chars[0];
                System.String[] val_8 = val_4.Split(separator:  val_17);
                bool val_10 = System.Single.TryParse(s:  0, result: out  val_8[0]);
                bool val_12 = System.Single.TryParse(s:  0, result: out  val_8[1]);
                CinemachineFreeLook.Orbit val_13 = new CinemachineFreeLook.Orbit(h:  0f, r:  0f);
                CodeStage.AntiCheat.ObscuredTypes.ObscuredPrefs.SetVector2(key:  null, value:  new UnityEngine.Vector2() {x = val_13.m_Height, y = val_13.m_Radius});
                val_19 = val_13.m_Height;
                val_18 = val_13.m_Radius;
                return new UnityEngine.Vector2() {x = val_19, y = val_18};
            }
            
            val_25 = null;
            val_20 = CodeStage.AntiCheat.ObscuredTypes.ObscuredPrefs.DecryptData(key:  val_25, encryptedInput:  val_20);
            if(val_20 == null)
            {
                    return new UnityEngine.Vector2() {x = val_19, y = val_18};
            }
            
            val_19 = System.BitConverter.ToSingle(value:  0, startIndex:  val_20);
            val_18 = System.BitConverter.ToSingle(value:  0, startIndex:  val_20);
            return new UnityEngine.Vector2() {x = val_19, y = val_18};
        }
        public static void SetVector3(string key, UnityEngine.Vector3 value)
        {
            string val_1 = CodeStage.AntiCheat.ObscuredTypes.ObscuredPrefs.EncryptKey(key:  null);
            string val_2 = CodeStage.AntiCheat.ObscuredTypes.ObscuredPrefs.EncryptVector3Value(key:  val_1, value:  new UnityEngine.Vector3() {x = value.x, y = value.y, z = value.z});
            UnityEngine.PlayerPrefs.SetString(key:  0, value:  val_1);
        }
        public static UnityEngine.Vector3 GetVector3(string key)
        {
            UnityEngine.Vector3 val_1 = UnityEngine.Vector3.zero;
            return CodeStage.AntiCheat.ObscuredTypes.ObscuredPrefs.GetVector3(key:  null, defaultValue:  new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = val_1.z});
        }
        public static UnityEngine.Vector3 GetVector3(string key, UnityEngine.Vector3 defaultValue)
        {
            float val_6;
            float val_7;
            float val_8;
            val_6 = defaultValue.z;
            val_7 = defaultValue.y;
            val_8 = defaultValue.x;
            if((System.String.op_Equality(a:  0, b:  CodeStage.AntiCheat.ObscuredTypes.ObscuredPrefs.GetEncryptedPrefsString(key:  CodeStage.AntiCheat.ObscuredTypes.ObscuredPrefs.EncryptKey(key:  null), encryptedKey:  X1))) == true)
            {
                    return new UnityEngine.Vector3() {x = val_8, y = val_7, z = val_6};
            }
            
            UnityEngine.Vector3 val_5 = CodeStage.AntiCheat.ObscuredTypes.ObscuredPrefs.DecryptVector3Value(key:  null, encryptedInput:  X1, defaultValue:  new UnityEngine.Vector3() {x = val_8, y = val_7, z = val_6});
            val_8 = val_5.x;
            val_7 = val_5.y;
            val_6 = val_5.z;
            return new UnityEngine.Vector3() {x = val_8, y = val_7, z = val_6};
        }
        private static string EncryptVector3Value(string key, UnityEngine.Vector3 value)
        {
            System.Buffer.BlockCopy(src:  0, srcOffset:  System.BitConverter.GetBytes(value:  value.x), dst:  0, dstOffset:  460851360, count:  0);
            System.Buffer.BlockCopy(src:  0, srcOffset:  System.BitConverter.GetBytes(value:  value.y), dst:  0, dstOffset:  460851360, count:  4);
            System.Buffer.BlockCopy(src:  0, srcOffset:  System.BitConverter.GetBytes(value:  value.z), dst:  0, dstOffset:  460851360, count:  8);
            return CodeStage.AntiCheat.ObscuredTypes.ObscuredPrefs.EncryptData(key:  null, cleanBytes:  X1, type:  null);
        }
        private static UnityEngine.Vector3 DecryptVector3Value(string key, string encryptedInput, UnityEngine.Vector3 defaultValue)
        {
            System.Char[] val_19;
            float val_20;
            float val_21;
            float val_22;
            string val_23;
            var val_24;
            string val_25;
            var val_26;
            var val_27;
            string val_28;
            val_20 = defaultValue.z;
            val_21 = defaultValue.y;
            val_22 = defaultValue.x;
            val_23 = encryptedInput;
            val_24 = X2;
            if(((val_24.IndexOf(value:  ':')) & 2147483648) == 0)
            {
                    val_25 = null;
                string val_4 = CodeStage.AntiCheat.ObscuredTypes.ObscuredPrefs.DeprecatedDecryptValue(value:  val_25);
                val_19 = 1152921504608284672;
                val_26 = null;
                val_26 = null;
                if((System.String.op_Equality(a:  0, b:  val_4)) == true)
            {
                    return new UnityEngine.Vector3() {x = val_22, y = val_21, z = val_20};
            }
            
                val_19 = null;
                val_27 = "|";
                if(("|") == null)
            {
                    val_27 = "|";
            }
            
                typeof(System.Char[]).__il2cppRuntimeField_20 = Chars[0];
                System.String[] val_8 = val_4.Split(separator:  val_19);
                bool val_10 = System.Single.TryParse(s:  0, result: out  val_8[0]);
                bool val_12 = System.Single.TryParse(s:  0, result: out  val_8[1]);
                bool val_14 = System.Single.TryParse(s:  0, result: out  val_8[2]);
                CodeStage.AntiCheat.ObscuredTypes.ObscuredPrefs.SetVector3(key:  null, value:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f});
                val_22 = 0f;
                val_21 = 0f;
                val_20 = 0f;
                return new UnityEngine.Vector3() {x = val_22, y = val_21, z = val_20};
            }
            
            val_28 = null;
            val_23 = CodeStage.AntiCheat.ObscuredTypes.ObscuredPrefs.DecryptData(key:  val_28, encryptedInput:  val_23);
            if(val_23 == null)
            {
                    return new UnityEngine.Vector3() {x = val_22, y = val_21, z = val_20};
            }
            
            val_22 = System.BitConverter.ToSingle(value:  0, startIndex:  val_23);
            val_21 = System.BitConverter.ToSingle(value:  0, startIndex:  val_23);
            val_20 = System.BitConverter.ToSingle(value:  0, startIndex:  val_23);
            return new UnityEngine.Vector3() {x = val_22, y = val_21, z = val_20};
        }
        public static void SetQuaternion(string key, UnityEngine.Quaternion value)
        {
            string val_1 = CodeStage.AntiCheat.ObscuredTypes.ObscuredPrefs.EncryptKey(key:  null);
            string val_2 = CodeStage.AntiCheat.ObscuredTypes.ObscuredPrefs.EncryptQuaternionValue(key:  val_1, value:  new UnityEngine.Quaternion() {x = value.x, y = value.y, z = value.z, w = value.w});
            UnityEngine.PlayerPrefs.SetString(key:  0, value:  val_1);
        }
        public static UnityEngine.Quaternion GetQuaternion(string key)
        {
            UnityEngine.Quaternion val_1 = UnityEngine.Quaternion.identity;
            return CodeStage.AntiCheat.ObscuredTypes.ObscuredPrefs.GetQuaternion(key:  null, defaultValue:  new UnityEngine.Quaternion() {x = val_1.x, y = val_1.y, z = val_1.z, w = val_1.w});
        }
        public static UnityEngine.Quaternion GetQuaternion(string key, UnityEngine.Quaternion defaultValue)
        {
            float val_6;
            float val_7;
            float val_8;
            float val_9;
            val_6 = defaultValue.w;
            val_7 = defaultValue.z;
            val_8 = defaultValue.y;
            val_9 = defaultValue.x;
            if((System.String.op_Equality(a:  0, b:  CodeStage.AntiCheat.ObscuredTypes.ObscuredPrefs.GetEncryptedPrefsString(key:  CodeStage.AntiCheat.ObscuredTypes.ObscuredPrefs.EncryptKey(key:  null), encryptedKey:  X1))) == true)
            {
                    return new UnityEngine.Quaternion() {x = val_9, y = val_8, z = val_7, w = val_6};
            }
            
            UnityEngine.Quaternion val_5 = CodeStage.AntiCheat.ObscuredTypes.ObscuredPrefs.DecryptQuaternionValue(key:  null, encryptedInput:  X1, defaultValue:  new UnityEngine.Quaternion() {x = val_9, y = val_8, z = val_7, w = val_6});
            val_9 = val_5.x;
            val_8 = val_5.y;
            val_7 = val_5.z;
            val_6 = val_5.w;
            return new UnityEngine.Quaternion() {x = val_9, y = val_8, z = val_7, w = val_6};
        }
        private static string EncryptQuaternionValue(string key, UnityEngine.Quaternion value)
        {
            System.Buffer.BlockCopy(src:  0, srcOffset:  System.BitConverter.GetBytes(value:  value.x), dst:  0, dstOffset:  460851360, count:  0);
            System.Buffer.BlockCopy(src:  0, srcOffset:  System.BitConverter.GetBytes(value:  value.y), dst:  0, dstOffset:  460851360, count:  4);
            System.Buffer.BlockCopy(src:  0, srcOffset:  System.BitConverter.GetBytes(value:  value.z), dst:  0, dstOffset:  460851360, count:  8);
            System.Buffer.BlockCopy(src:  0, srcOffset:  System.BitConverter.GetBytes(value:  value.w), dst:  0, dstOffset:  460851360, count:  12);
            return CodeStage.AntiCheat.ObscuredTypes.ObscuredPrefs.EncryptData(key:  null, cleanBytes:  X1, type:  null);
        }
        private static UnityEngine.Quaternion DecryptQuaternionValue(string key, string encryptedInput, UnityEngine.Quaternion defaultValue)
        {
            System.Char[] val_22;
            float val_23;
            float val_24;
            float val_25;
            float val_26;
            string val_27;
            var val_28;
            string val_29;
            var val_30;
            var val_31;
            string val_32;
            val_23 = defaultValue.w;
            val_24 = defaultValue.z;
            val_25 = defaultValue.y;
            val_26 = defaultValue.x;
            val_27 = encryptedInput;
            val_28 = X2;
            if(((val_28.IndexOf(value:  ':')) & 2147483648) == 0)
            {
                    val_29 = null;
                string val_4 = CodeStage.AntiCheat.ObscuredTypes.ObscuredPrefs.DeprecatedDecryptValue(value:  val_29);
                val_22 = 1152921504608284672;
                val_30 = null;
                val_30 = null;
                if((System.String.op_Equality(a:  0, b:  val_4)) == true)
            {
                    return new UnityEngine.Quaternion() {x = val_26, y = val_25, z = val_24, w = val_23};
            }
            
                val_22 = null;
                val_31 = "|";
                if(("|") == null)
            {
                    val_31 = "|";
            }
            
                typeof(System.Char[]).__il2cppRuntimeField_20 = Chars[0];
                System.String[] val_8 = val_4.Split(separator:  val_22);
                bool val_10 = System.Single.TryParse(s:  0, result: out  val_8[0]);
                bool val_12 = System.Single.TryParse(s:  0, result: out  val_8[1]);
                bool val_14 = System.Single.TryParse(s:  0, result: out  val_8[2]);
                bool val_16 = System.Single.TryParse(s:  0, result: out  val_8[3]);
                CodeStage.AntiCheat.ObscuredTypes.ObscuredPrefs.SetQuaternion(key:  null, value:  new UnityEngine.Quaternion() {x = 0f, y = 0f, z = 0f, w = 0f});
                val_26 = 0f;
                val_25 = 0f;
                val_24 = 0f;
                val_23 = 0f;
                return new UnityEngine.Quaternion() {x = val_26, y = val_25, z = val_24, w = val_23};
            }
            
            val_32 = null;
            val_27 = CodeStage.AntiCheat.ObscuredTypes.ObscuredPrefs.DecryptData(key:  val_32, encryptedInput:  val_27);
            if(val_27 == null)
            {
                    return new UnityEngine.Quaternion() {x = val_26, y = val_25, z = val_24, w = val_23};
            }
            
            val_26 = System.BitConverter.ToSingle(value:  0, startIndex:  val_27);
            val_25 = System.BitConverter.ToSingle(value:  0, startIndex:  val_27);
            val_24 = System.BitConverter.ToSingle(value:  0, startIndex:  val_27);
            val_23 = System.BitConverter.ToSingle(value:  0, startIndex:  val_27);
            return new UnityEngine.Quaternion() {x = val_26, y = val_25, z = val_24, w = val_23};
        }
        public static void SetColor(string key, UnityEngine.Color32 value)
        {
            var val_1 = X2 & 4278255360;
            string val_2 = CodeStage.AntiCheat.ObscuredTypes.ObscuredPrefs.EncryptKey(key:  null);
            string val_3 = CodeStage.AntiCheat.ObscuredTypes.ObscuredPrefs.EncryptColorValue(key:  val_2, value:  value.r);
            UnityEngine.PlayerPrefs.SetString(key:  0, value:  val_2);
        }
        public static UnityEngine.Color32 GetColor(string key)
        {
            UnityEngine.Color32 val_1 = CodeStage.AntiCheat.ObscuredTypes.ObscuredPrefs.GetColor(key:  null, defaultValue:  new UnityEngine.Color32() {r = X1, g = X1, b = X1, a = X1});
            val_1.r = val_1.r & 4294967295;
            return new UnityEngine.Color32() {r = val_1.r, g = val_1.r, b = val_1.r, a = val_1.r};
        }
        public static UnityEngine.Color32 GetColor(string key, UnityEngine.Color32 defaultValue)
        {
            string val_2 = CodeStage.AntiCheat.ObscuredTypes.ObscuredPrefs.GetEncryptedPrefsString(key:  CodeStage.AntiCheat.ObscuredTypes.ObscuredPrefs.EncryptKey(key:  null), encryptedKey:  defaultValue.r);
            if((System.String.op_Equality(a:  0, b:  val_2)) != false)
            {
                    return new UnityEngine.Color32();
            }
            
            byte val_6 = defaultValue.r;
            uint val_7 = val_2;
            uint val_4 = CodeStage.AntiCheat.ObscuredTypes.ObscuredPrefs.DecryptUIntValue(key:  null, encryptedInput:  val_6, defaultValue:  val_7);
            uint val_5 = val_4 >> 24;
            val_6 = val_4 >> 16;
            val_7 = val_4 >> 8;
            X2 = 0;
            return new UnityEngine.Color32();
        }
        private static string EncryptColorValue(string key, uint value)
        {
            return CodeStage.AntiCheat.ObscuredTypes.ObscuredPrefs.EncryptData(key:  null = null, cleanBytes:  value, type:  System.BitConverter.GetBytes(value:  0));
        }
        public static void SetRect(string key, UnityEngine.Rect value)
        {
            string val_1 = CodeStage.AntiCheat.ObscuredTypes.ObscuredPrefs.EncryptKey(key:  null);
            string val_2 = CodeStage.AntiCheat.ObscuredTypes.ObscuredPrefs.EncryptRectValue(key:  val_1, value:  new UnityEngine.Rect() {m_XMin = value.m_XMin, m_YMin = value.m_YMin, m_Width = value.m_Width, m_Height = value.m_Height});
            UnityEngine.PlayerPrefs.SetString(key:  0, value:  val_1);
        }
        public static UnityEngine.Rect GetRect(string key)
        {
            UnityEngine.Rect val_1 = CodeStage.AntiCheat.ObscuredTypes.ObscuredPrefs.GetRect(key:  null, defaultValue:  new UnityEngine.Rect() {m_XMin = 0f, m_YMin = 0f, m_Width = 0f, m_Height = 0f});
            return new UnityEngine.Rect() {m_XMin = val_1.m_XMin, m_YMin = val_1.m_YMin, m_Width = val_1.m_Width, m_Height = val_1.m_Height};
        }
        public static UnityEngine.Rect GetRect(string key, UnityEngine.Rect defaultValue)
        {
            float val_6;
            float val_7;
            float val_8;
            float val_9;
            val_6 = defaultValue.m_Height;
            val_7 = defaultValue.m_Width;
            val_8 = defaultValue.m_YMin;
            val_9 = defaultValue.m_XMin;
            if((System.String.op_Equality(a:  0, b:  CodeStage.AntiCheat.ObscuredTypes.ObscuredPrefs.GetEncryptedPrefsString(key:  CodeStage.AntiCheat.ObscuredTypes.ObscuredPrefs.EncryptKey(key:  null), encryptedKey:  X1))) == true)
            {
                    return new UnityEngine.Rect() {m_XMin = val_9, m_YMin = val_8, m_Width = val_7, m_Height = val_6};
            }
            
            UnityEngine.Rect val_5 = CodeStage.AntiCheat.ObscuredTypes.ObscuredPrefs.DecryptRectValue(key:  null, encryptedInput:  X1, defaultValue:  new UnityEngine.Rect() {m_XMin = val_9, m_YMin = val_8, m_Width = val_7, m_Height = val_6});
            val_9 = val_5.m_XMin;
            val_8 = val_5.m_YMin;
            val_7 = val_5.m_Width;
            val_6 = val_5.m_Height;
            return new UnityEngine.Rect() {m_XMin = val_9, m_YMin = val_8, m_Width = val_7, m_Height = val_6};
        }
        private static string EncryptRectValue(string key, UnityEngine.Rect value)
        {
            System.Buffer.BlockCopy(src:  0, srcOffset:  System.BitConverter.GetBytes(value:  value.m_XMin), dst:  0, dstOffset:  460851360, count:  0);
            System.Buffer.BlockCopy(src:  0, srcOffset:  System.BitConverter.GetBytes(value:  value.m_XMin), dst:  0, dstOffset:  460851360, count:  4);
            System.Buffer.BlockCopy(src:  0, srcOffset:  System.BitConverter.GetBytes(value:  value.m_XMin), dst:  0, dstOffset:  460851360, count:  8);
            System.Buffer.BlockCopy(src:  0, srcOffset:  System.BitConverter.GetBytes(value:  value.m_XMin), dst:  0, dstOffset:  460851360, count:  12);
            return (string)CodeStage.AntiCheat.ObscuredTypes.ObscuredPrefs.EncryptData(key:  null, cleanBytes:  X1, type:  null);
        }
        private static UnityEngine.Rect DecryptRectValue(string key, string encryptedInput, UnityEngine.Rect defaultValue)
        {
            System.Char[] val_22;
            float val_23;
            float val_24;
            float val_25;
            float val_26;
            string val_27;
            var val_28;
            string val_29;
            var val_30;
            var val_31;
            string val_32;
            val_23 = defaultValue.m_Height;
            val_24 = defaultValue.m_Width;
            val_25 = defaultValue.m_YMin;
            val_26 = defaultValue.m_XMin;
            val_27 = encryptedInput;
            val_28 = X2;
            if(((val_28.IndexOf(value:  ':')) & 2147483648) == 0)
            {
                    val_29 = null;
                string val_4 = CodeStage.AntiCheat.ObscuredTypes.ObscuredPrefs.DeprecatedDecryptValue(value:  val_29);
                val_22 = 1152921504608284672;
                val_30 = null;
                val_30 = null;
                if((System.String.op_Equality(a:  0, b:  val_4)) == true)
            {
                    return new UnityEngine.Rect() {m_XMin = val_26, m_YMin = val_25, m_Width = val_24, m_Height = val_23};
            }
            
                val_22 = null;
                val_31 = "|";
                if(("|") == null)
            {
                    val_31 = "|";
            }
            
                typeof(System.Char[]).__il2cppRuntimeField_20 = Chars[0];
                System.String[] val_8 = val_4.Split(separator:  val_22);
                bool val_10 = System.Single.TryParse(s:  0, result: out  val_8[0]);
                bool val_12 = System.Single.TryParse(s:  0, result: out  val_8[1]);
                bool val_14 = System.Single.TryParse(s:  0, result: out  val_8[2]);
                bool val_16 = System.Single.TryParse(s:  0, result: out  val_8[3]);
                CodeStage.AntiCheat.ObscuredTypes.ObscuredPrefs.SetRect(key:  null, value:  new UnityEngine.Rect() {m_XMin = 0f, m_YMin = 0f, m_Width = 0f, m_Height = 0f});
                val_26 = 0f;
                val_25 = 0f;
                val_24 = 0f;
                val_23 = 0f;
                return new UnityEngine.Rect() {m_XMin = val_26, m_YMin = val_25, m_Width = val_24, m_Height = val_23};
            }
            
            val_32 = null;
            val_27 = CodeStage.AntiCheat.ObscuredTypes.ObscuredPrefs.DecryptData(key:  val_32, encryptedInput:  val_27);
            if(val_27 == null)
            {
                    return new UnityEngine.Rect() {m_XMin = val_26, m_YMin = val_25, m_Width = val_24, m_Height = val_23};
            }
            
            0.startFloat = System.BitConverter.ToSingle(value:  0, startIndex:  val_27);
            float val_19 = System.BitConverter.ToSingle(value:  0, startIndex:  val_27);
            float val_20 = System.BitConverter.ToSingle(value:  0, startIndex:  val_27);
            float val_21 = System.BitConverter.ToSingle(value:  0, startIndex:  val_27);
            val_26 = 0f;
            val_25 = 0f;
            val_24 = 0f;
            val_23 = 0f;
            return new UnityEngine.Rect() {m_XMin = val_26, m_YMin = val_25, m_Width = val_24, m_Height = val_23};
        }
        public static void SetRawValue(string key, string encryptedValue)
        {
            UnityEngine.PlayerPrefs.SetString(key:  0, value:  CodeStage.AntiCheat.ObscuredTypes.ObscuredPrefs.EncryptKey(key:  null));
        }
        public static string GetRawValue(string key)
        {
            string val_1 = CodeStage.AntiCheat.ObscuredTypes.ObscuredPrefs.EncryptKey(key:  null);
            return UnityEngine.PlayerPrefs.GetString(key:  0);
        }
        internal static CodeStage.AntiCheat.ObscuredTypes.ObscuredPrefs.DataType GetRawValueType(string value)
        {
            var val_6;
            int val_7;
            var val_8;
            System.Byte[] val_1 = System.Convert.FromBase64String(s:  0);
            val_6 = val_1;
            val_7 = val_1.Length;
            if(val_7 >= 7)
            {
                    int val_3 = val_7 << 32;
                var val_4 = ((-30064771072) + ((val_1.Length) << 32)) >> 32;
                if(val_4 >= val_7)
            {
                    val_7 = val_1.Length;
            }
            
                val_3 = (val_3 + (-25769803776)) >> 32;
                val_1 = (val_6[val_3] > 10) ? 0 : (val_6[val_4]);
                return (DataType)val_8;
            }
            
            val_8 = 0;
            return (DataType)val_8;
        }
        internal static string EncryptKey(string key)
        {
            null = null;
            string val_1 = CodeStage.AntiCheat.ObscuredTypes.ObscuredString.EncryptDecrypt(value:  null, key:  X1);
            System.Text.Encoding val_2 = System.Text.Encoding.UTF8;
            return System.Convert.ToBase64String(inArray:  0);
        }
        public static bool HasKey(string key)
        {
            if((UnityEngine.PlayerPrefs.HasKey(key:  0)) != false)
            {
                    return true;
            }
            
            string val_3 = CodeStage.AntiCheat.ObscuredTypes.ObscuredPrefs.EncryptKey(key:  null);
            return UnityEngine.PlayerPrefs.HasKey(key:  0);
        }
        public static void DeleteKey(string key)
        {
            string val_1 = CodeStage.AntiCheat.ObscuredTypes.ObscuredPrefs.EncryptKey(key:  null);
            UnityEngine.PlayerPrefs.DeleteKey(key:  0);
            if(CodeStage.AntiCheat.ObscuredTypes.ObscuredPrefs.preservePlayerPrefs != false)
            {
                    return;
            }
            
            UnityEngine.PlayerPrefs.DeleteKey(key:  0);
        }
        public static void DeleteAll()
        {
            UnityEngine.PlayerPrefs.DeleteAll();
        }
        public static void Save()
        {
            UnityEngine.PlayerPrefs.Save();
        }
        private static string GetEncryptedPrefsString(string key, string encryptedKey)
        {
            string val_1 = UnityEngine.PlayerPrefs.GetString(key:  0, defaultValue:  X2);
            if((System.String.op_Equality(a:  0, b:  val_1)) == false)
            {
                    return val_1;
            }
            
            if((UnityEngine.PlayerPrefs.HasKey(key:  0)) == false)
            {
                    return val_1;
            }
            
            string val_4 = 0 + "[ACTk] Are you trying to read regular PlayerPrefs data using ObscuredPrefs (key = "("[ACTk] Are you trying to read regular PlayerPrefs data using ObscuredPrefs (key = ") + encryptedKey;
            UnityEngine.Debug.LogWarning(message:  0);
            return val_1;
        }
        private static string EncryptData(string key, byte[] cleanBytes, CodeStage.AntiCheat.ObscuredTypes.ObscuredPrefs.DataType type)
        {
            var val_11;
            var val_13;
            var val_15;
            var val_16;
            val_11 = null;
            val_11 = null;
            uint val_3 = CodeStage.AntiCheat.Utils.xxHash.CalculateHash(buf:  0, len:  type, seed:  34816000);
            typeof(System.Byte[]).__il2cppRuntimeField_20 = val_3;
            typeof(System.Byte[]).__il2cppRuntimeField_21 = val_3 >> 8;
            typeof(System.Byte[]).__il2cppRuntimeField_22 = val_3 >> 16;
            typeof(System.Byte[]).__il2cppRuntimeField_23 = val_3 >> 24;
            if(CodeStage.AntiCheat.ObscuredTypes.ObscuredPrefs.lockToDevice != 0)
            {
                    uint val_7 = CodeStage.AntiCheat.ObscuredTypes.ObscuredPrefs.DeviceIdHash;
                val_13 = null;
                typeof(System.Byte[]).__il2cppRuntimeField_20 = val_7;
                typeof(System.Byte[]).__il2cppRuntimeField_21 = val_7 >> 8;
                val_15 = 34816011;
                typeof(System.Byte[]).__il2cppRuntimeField_22 = val_7 >> 16;
                typeof(System.Byte[]).__il2cppRuntimeField_23 = val_7 >> 24;
            }
            else
            {
                    val_13 = 0;
                val_15 = 34816007;
            }
            
            System.Buffer.BlockCopy(src:  0, srcOffset:  CodeStage.AntiCheat.ObscuredTypes.ObscuredPrefs.EncryptDecryptBytes(bytes:  0 + cleanBytes, dataLength:  type, key:  34816000), dst:  0, dstOffset:  460851360, count:  0);
            if(val_13 != 0)
            {
                    System.Buffer.BlockCopy(src:  0, srcOffset:  0, dst:  0, dstOffset:  460851360, count:  34816000);
            }
            
            mem[1152921505102514368] = W3;
            mem[1152921505102514369] = 2;
            val_16 = null;
            val_16 = null;
            mem[1152921505102514370] = CodeStage.AntiCheat.ObscuredTypes.ObscuredPrefs.lockToDevice;
            System.Buffer.BlockCopy(src:  0, srcOffset:  460851360, dst:  0, dstOffset:  460851360, count:  34816003);
            return System.Convert.ToBase64String(inArray:  0);
        }
        internal static byte[] DecryptData(string key, string encryptedInput)
        {
            System.Array val_16;
            var val_17;
            var val_19;
            var val_21;
            var val_22;
            int val_23;
            var val_24;
            var val_25;
            var val_28;
            System.Byte[] val_1 = System.Convert.FromBase64String(s:  0);
            if(val_1.Length <= 0)
            {
                goto label_6;
            }
            
            val_16 = ((-25769803776) + ((val_1.Length) << 32)) >> 32;
            if(val_1[val_16] != 2)
            {
                goto label_6;
            }
            
            int val_3 = val_1.Length << 32;
            val_3 = val_3 + (-21474836480);
            val_17 = 1152921505067698336;
            System.Buffer.BlockCopy(src:  0, srcOffset:  val_1, dst:  val_1.Length - 4, dstOffset:  460851360, count:  0);
            if((val_1[val_3 >> 32]) == 0)
            {
                goto label_13;
            }
            
            val_16 = val_1.Length - 11;
            val_19 = null;
            val_19 = null;
            if(CodeStage.AntiCheat.ObscuredTypes.ObscuredPrefs.lockToDevice == 0)
            {
                goto label_16;
            }
            
            System.Buffer.BlockCopy(src:  0, srcOffset:  val_1, dst:  val_16, dstOffset:  460851360, count:  0);
            val_17 = 1152921505067698336;
            goto label_23;
            label_13:
            val_21 = 0;
            val_16 = val_1.Length - 7;
            goto label_23;
            label_16:
            val_21 = 0;
            label_23:
            System.Buffer.BlockCopy(src:  0, srcOffset:  val_1, dst:  0, dstOffset:  460851360, count:  0);
            val_22 = null;
            val_22 = null;
            val_23 = CodeStage.AntiCheat.ObscuredTypes.ObscuredPrefs.EncryptDecryptBytes(bytes:  0 + encryptedInput, dataLength:  460851360, key:  val_16);
            uint val_8 = CodeStage.AntiCheat.Utils.xxHash.CalculateHash(buf:  0, len:  val_23, seed:  val_16);
            val_24 = null;
            val_25 = null;
            if((val_21 != 0) || (CodeStage.AntiCheat.ObscuredTypes.ObscuredPrefs.lockToDevice != 2))
            {
                goto label_35;
            }
            
            val_25 = null;
            if(CodeStage.AntiCheat.ObscuredTypes.ObscuredPrefs.emergencyMode == true)
            {
                goto label_35;
            }
            
            val_25 = null;
            if(CodeStage.AntiCheat.ObscuredTypes.ObscuredPrefs.readForeignSaves == false)
            {
                goto label_49;
            }
            
            label_35:
            if(val_21 == 0)
            {
                    return (System.Byte[])val_23;
            }
            
            val_25 = null;
            if(CodeStage.AntiCheat.ObscuredTypes.ObscuredPrefs.emergencyMode == true)
            {
                    return (System.Byte[])val_23;
            }
            
            if(val_21 == CodeStage.AntiCheat.ObscuredTypes.ObscuredPrefs.DeviceIdHash)
            {
                    return (System.Byte[])val_23;
            }
            
            CodeStage.AntiCheat.ObscuredTypes.ObscuredPrefs.PossibleForeignSavesDetected();
            if(CodeStage.AntiCheat.ObscuredTypes.ObscuredPrefs.readForeignSaves == true)
            {
                    return (System.Byte[])val_23;
            }
            
            goto label_49;
            label_6:
            val_28 = null;
            CodeStage.AntiCheat.ObscuredTypes.ObscuredPrefs.SavesTampered();
            label_49:
            val_23 = 0;
            return (System.Byte[])val_23;
        }
        private static uint CalculateChecksum(string input)
        {
            var val_3;
            System.Text.Encoding val_1 = System.Text.Encoding.UTF8;
            val_3 = null;
            val_3 = null;
            string val_2 = 0 + X1;
            if(val_1 != null)
            {
                    return CodeStage.AntiCheat.Utils.xxHash.CalculateHash(buf:  0, len:  val_1, seed:  val_1.is_readonly);
            }
            
            return CodeStage.AntiCheat.Utils.xxHash.CalculateHash(buf:  0, len:  val_1, seed:  val_1.is_readonly);
        }
        private static void SavesTampered()
        {
            var val_1;
            System.Action val_2;
            val_1 = null;
            val_1 = null;
            val_2 = CodeStage.AntiCheat.ObscuredTypes.ObscuredPrefs.onAlterationDetected;
            if(val_2 == null)
            {
                    return;
            }
            
            val_2 = CodeStage.AntiCheat.ObscuredTypes.ObscuredPrefs.onAlterationDetected;
            if(val_2 == null)
            {
                    val_2 = 0;
            }
            
            val_2.Invoke();
            CodeStage.AntiCheat.ObscuredTypes.ObscuredPrefs.onAlterationDetected = 0;
        }
        private static void PossibleForeignSavesDetected()
        {
            if(CodeStage.AntiCheat.ObscuredTypes.ObscuredPrefs.onPossibleForeignSavesDetected == null)
            {
                    return;
            }
            
            null = null;
            if(CodeStage.AntiCheat.ObscuredTypes.ObscuredPrefs.__il2cppRuntimeField_static_fields != 0)
            {
                    return;
            }
            
            CodeStage.AntiCheat.ObscuredTypes.ObscuredPrefs.DEPRECATED_RAW_SEPARATOR = 1;
            CodeStage.AntiCheat.ObscuredTypes.ObscuredPrefs.onPossibleForeignSavesDetected.Invoke();
        }
        private static string GetDeviceId()
        {
            null = null;
            if((System.String.IsNullOrEmpty(value:  0)) == false)
            {
                    return (string)System.String.Empty;
            }
            
            return UnityEngine.SystemInfo.deviceUniqueIdentifier;
        }
        private static byte[] EncryptDecryptBytes(byte[] bytes, int dataLength, string key)
        {
            string val_7 = key;
            int val_1 = X3.Length;
            if(val_7 < 1)
            {
                    return (System.Byte[])null;
            }
            
            var val_7 = 0;
            int val_2 = dataLength + 32;
            do
            {
                val_7 = ((X3.Chars[val_7 - ((val_7 / val_1) * val_1)]) & 65535) ^ ((dataLength + 32) + 0);
                System.Byte[].__il2cppRuntimeField_byval_arg.__il2cppRuntimeField_0 = val_7;
                val_7 = val_7 + 1;
            }
            while(val_7 != val_7);
            
            return (System.Byte[])null;
        }
        private static string DeprecatedDecryptValue(string value)
        {
            string val_19;
            string val_20;
            var val_21;
            string val_22;
            string val_23;
            string val_24;
            string val_25;
            string val_26;
            var val_27;
            string val_29;
            var val_32;
            var val_35;
            typeof(System.Char[]).__il2cppRuntimeField_20 = 58;
            System.String[] val_1 = X1.Split(separator:  null);
            if(val_1.Length <= 1)
            {
                goto label_5;
            }
            
            val_19 = val_1[0];
            val_20 = val_1[1];
            System.Byte[] val_2 = System.Convert.FromBase64String(s:  0);
            val_21 = null;
            val_21 = null;
            val_22 = CodeStage.AntiCheat.ObscuredTypes.ObscuredPrefs.cryptoKey;
            val_23 = CodeStage.AntiCheat.ObscuredTypes.ObscuredString.EncryptDecrypt(value:  null, key:  System.Text.Encoding.UTF8);
            if(val_1.Length != 3)
            {
                goto label_18;
            }
            
            val_22 = CodeStage.AntiCheat.ObscuredTypes.ObscuredPrefs.DeprecatedDeviceId;
            string val_7 = CodeStage.AntiCheat.ObscuredTypes.ObscuredPrefs.DeprecatedCalculateChecksum(input:  0 + val_19);
            val_24 = 0;
            val_25 = val_20;
            goto label_23;
            label_18:
            val_26 = null;
            if(val_1.Length != 2)
            {
                goto label_24;
            }
            
            val_22 = CodeStage.AntiCheat.ObscuredTypes.ObscuredPrefs.DeprecatedCalculateChecksum(input:  val_26);
            val_24 = 0;
            val_25 = val_20;
            label_23:
            if((System.String.op_Inequality(a:  val_24, b:  val_25)) == false)
            {
                goto label_29;
            }
            
            val_26 = null;
            goto label_33;
            label_24:
            label_33:
            CodeStage.AntiCheat.ObscuredTypes.ObscuredPrefs.SavesTampered();
            label_29:
            val_27 = null;
            val_27 = null;
            if(CodeStage.AntiCheat.ObscuredTypes.ObscuredPrefs.lockToDevice == 0)
            {
                    return val_23;
            }
            
            if(CodeStage.AntiCheat.ObscuredTypes.ObscuredPrefs.emergencyMode == true)
            {
                    return val_23;
            }
            
            if(val_1.Length >= 3)
            {
                goto label_41;
            }
            
            val_29 = null;
            val_29 = null;
            if(CodeStage.AntiCheat.ObscuredTypes.ObscuredPrefs.lockToDevice != 2)
            {
                goto label_44;
            }
            
            val_29 = null;
            if(CodeStage.AntiCheat.ObscuredTypes.ObscuredPrefs.readForeignSaves == true)
            {
                goto label_61;
            }
            
            val_32 = null;
            val_32 = null;
            goto label_50;
            label_41:
            val_20 = val_1[2];
            string val_15 = CodeStage.AntiCheat.ObscuredTypes.ObscuredPrefs.DeprecatedDeviceId;
            goto label_53;
            label_44:
            label_53:
            val_19 = CodeStage.AntiCheat.ObscuredTypes.ObscuredPrefs.DeprecatedCalculateChecksum(input:  val_29);
            if((System.String.op_Inequality(a:  0, b:  val_20)) == false)
            {
                    return val_23;
            }
            
            val_29 = null;
            val_29 = null;
            if(CodeStage.AntiCheat.ObscuredTypes.ObscuredPrefs.readForeignSaves == true)
            {
                goto label_61;
            }
            
            val_32 = null;
            val_32 = null;
            label_50:
            val_29 = null;
            val_23 = System.String.Empty;
            label_61:
            CodeStage.AntiCheat.ObscuredTypes.ObscuredPrefs.PossibleForeignSavesDetected();
            return val_23;
            label_5:
            CodeStage.AntiCheat.ObscuredTypes.ObscuredPrefs.SavesTampered();
            val_35 = null;
            val_35 = null;
            val_23 = System.String.Empty;
            return val_23;
        }
        private static string DeprecatedCalculateChecksum(string input)
        {
            var val_8;
            System.Text.Encoding val_1 = System.Text.Encoding.UTF8;
            val_8 = null;
            val_8 = null;
            string val_2 = 0 + X1;
            if(val_1.is_readonly < true)
            {
                    return (string)val_11.ToString(format:  "X2");
            }
            
            int val_11 = 0;
            var val_8 = 0;
            do
            {
                var val_10 = mem[val_1.decoder_fallback + 0];
                int val_5 = CodeStage.AntiCheat.ObscuredTypes.ObscuredPrefs.cryptoKey.Length ^ 64 + val_8;
                val_8 = val_8 + 1;
                val_5 = val_10 * val_5;
                var val_9 = (long)val_5;
                val_9 = val_9 * 1431655766;
                val_9 = val_9 >> 32;
                val_9 = val_9 + (val_9 >> 63);
                val_9 = val_9 + (val_9 << 1);
                val_10 = val_11 + val_10;
                val_5 = val_5 - val_9;
                val_11 = val_10 + val_5;
            }
            while(val_1.is_readonly != val_8);
            
            return (string)val_11.ToString(format:  "X2");
        }
        private static string get_DeprecatedDeviceId()
        {
            var val_4;
            var val_5;
            val_4 = null;
            val_4 = null;
            if((System.String.IsNullOrEmpty(value:  0)) != false)
            {
                    CodeStage.AntiCheat.ObscuredTypes.ObscuredPrefs.deprecatedDeviceId = CodeStage.AntiCheat.ObscuredTypes.ObscuredPrefs.DeprecatedCalculateChecksum(input:  CodeStage.AntiCheat.ObscuredTypes.ObscuredPrefs.DeviceId);
            }
            
            val_5 = null;
            val_5 = null;
            return (string)CodeStage.AntiCheat.ObscuredTypes.ObscuredPrefs.deprecatedDeviceId;
        }
        private static ObscuredPrefs()
        {
            CodeStage.AntiCheat.ObscuredTypes.ObscuredPrefs.cryptoKey = "e806f6";
        }
    
    }

}
