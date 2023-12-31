using UnityEngine;

namespace CodeStage.AntiCheat.ObscuredTypes
{
    [Serializable]
    public struct ObscuredChar : IEquatable<CodeStage.AntiCheat.ObscuredTypes.ObscuredChar>
    {
        // Fields
        private static char cryptoKey;
        private char currentCryptoKey;
        private char hiddenValue;
        private bool inited;
        private char fakeValue;
        private bool fakeValueActive;
        
        // Methods
        private ObscuredChar(char value)
        {
        
        }
        public static void SetNewCryptoKey(char newKey)
        {
            null = null;
            CodeStage.AntiCheat.ObscuredTypes.ObscuredChar.cryptoKey = W1;
        }
        public static char EncryptDecrypt(char value)
        {
            return CodeStage.AntiCheat.ObscuredTypes.ObscuredChar.EncryptDecrypt(value:  '耀', key:  W1);
        }
        public static char EncryptDecrypt(char value, char key)
        {
            char val_3;
            var val_4;
            val_3 = W2;
            if((val_3 & 65535) != 0)
            {
                    return (char)val_3 ^ key;
            }
            
            val_4 = null;
            val_4 = null;
            val_3 = CodeStage.AntiCheat.ObscuredTypes.ObscuredChar.cryptoKey;
            return (char)val_3 ^ key;
        }
        public void ApplyNewCryptoKey()
        {
            mem[1152921510056070944] = UnityEngine.Random.Range(min:  0, max:  1);
            .hiddenValue = CodeStage.AntiCheat.ObscuredTypes.ObscuredChar.EncryptDecrypt(value:  '耀', key:  '輠');
        }
        public void RandomizeCryptoKey()
        {
        
        }
        public char GetEncrypted()
        {
            return (char)1152921510056294944;
        }
        public void SetEncrypted(char encrypted)
        {
        
        }
        public char GetDecrypted()
        {
        
        }
        private char InternalDecrypt()
        {
        
        }
        public static CodeStage.AntiCheat.ObscuredTypes.ObscuredChar op_Implicit(char value)
        {
            return new CodeStage.AntiCheat.ObscuredTypes.ObscuredChar() {currentCryptoKey = ' ', hiddenValue = ' ', inited = false, fakeValue = ' ', fakeValueActive = false};
        }
        public static char op_Implicit(CodeStage.AntiCheat.ObscuredTypes.ObscuredChar value)
        {
            return (char);
        }
        public static CodeStage.AntiCheat.ObscuredTypes.ObscuredChar op_Increment(CodeStage.AntiCheat.ObscuredTypes.ObscuredChar input)
        {
            var val_3;
            var val_4;
            val_3;
            val_3 = null;
            char val_1 = CodeStage.AntiCheat.ObscuredTypes.ObscuredChar.EncryptDecrypt(value:  '耀', key:  'ఁ');
            if(CodeStage.AntiCheat.Detectors.ObscuredCheatingDetector.IsRunning != false)
            {
                    val_4 = 1;
                return new CodeStage.AntiCheat.ObscuredTypes.ObscuredChar() {currentCryptoKey = input.fakeValueActive, hiddenValue = input.fakeValueActive, inited = input.fakeValueActive, fakeValue = input.fakeValueActive, fakeValueActive = false};
            }
            
            val_4 = 0;
            return new CodeStage.AntiCheat.ObscuredTypes.ObscuredChar() {currentCryptoKey = input.fakeValueActive, hiddenValue = input.fakeValueActive, inited = input.fakeValueActive, fakeValue = input.fakeValueActive, fakeValueActive = false};
        }
        public static CodeStage.AntiCheat.ObscuredTypes.ObscuredChar op_Decrement(CodeStage.AntiCheat.ObscuredTypes.ObscuredChar input)
        {
            var val_3;
            var val_4;
            val_3;
            val_3 = null;
            char val_2 = CodeStage.AntiCheat.ObscuredTypes.ObscuredChar.EncryptDecrypt(value:  '耀', key:  65535 + val_3);
            if(CodeStage.AntiCheat.Detectors.ObscuredCheatingDetector.IsRunning != false)
            {
                    val_4 = 1;
                return new CodeStage.AntiCheat.ObscuredTypes.ObscuredChar() {currentCryptoKey = input.fakeValueActive, hiddenValue = input.fakeValueActive, inited = input.fakeValueActive, fakeValue = input.fakeValueActive, fakeValueActive = false};
            }
            
            val_4 = 0;
            return new CodeStage.AntiCheat.ObscuredTypes.ObscuredChar() {currentCryptoKey = input.fakeValueActive, hiddenValue = input.fakeValueActive, inited = input.fakeValueActive, fakeValue = input.fakeValueActive, fakeValueActive = false};
        }
        public override bool Equals(object obj)
        {
        
        }
        public bool Equals(CodeStage.AntiCheat.ObscuredTypes.ObscuredChar obj)
        {
            obj.fakeValueActive = obj.fakeValueActive & 65535;
        }
        public override string ToString()
        {
            return (string)1152921510057427232.ToString(provider:  0);
        }
        public string ToString(System.IFormatProvider provider)
        {
            return (string)1152921510057551520.ToString(provider:  provider);
        }
        public override int GetHashCode()
        {
            return (int)1152921510057671712.GetHashCode();
        }
        private static ObscuredChar()
        {
            CodeStage.AntiCheat.ObscuredTypes.ObscuredChar.cryptoKey = '—';
        }
    
    }

}
