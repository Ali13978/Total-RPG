using UnityEngine;

namespace I2.Loc
{
    public class StringObfucator
    {
        // Fields
        public static char[] StringObfuscatorPassword;
        
        // Methods
        public StringObfucator()
        {
        
        }
        public static string Encode(string NormalString)
        {
            return (string)I2.Loc.StringObfucator.ToBase64(regularString:  I2.Loc.StringObfucator.XoREncode(NormalString:  null));
        }
        public static string Decode(string ObfucatedString)
        {
            return (string)I2.Loc.StringObfucator.XoREncode(NormalString:  I2.Loc.StringObfucator.FromBase64(base64string:  null));
        }
        private static string ToBase64(string regularString)
        {
            System.Text.Encoding val_1 = System.Text.Encoding.UTF8;
            return System.Convert.ToBase64String(inArray:  0);
        }
        private static string FromBase64(string base64string)
        {
            System.Byte[] val_1 = System.Convert.FromBase64String(s:  0);
            if(System.Text.Encoding.UTF8 == null)
            {
                
            }
        
        }
        private static string XoREncode(string NormalString)
        {
            var val_10;
            System.Char[] val_11;
            val_10 = null;
            val_10 = null;
            val_11 = X1.ToCharArray();
            if(val_1.Length >= 1)
            {
                    var val_10 = 0;
                do
            {
                int val_3 = val_10 - ((val_10 / I2.Loc.StringObfucator.StringObfuscatorPassword.Length) * I2.Loc.StringObfucator.StringObfuscatorPassword.Length);
                System.Char[] val_4 = I2.Loc.StringObfucator.StringObfuscatorPassword + (((long)(int)(0 - ((0 / I2.Loc.StringObfucator.StringObfuscatorPassword.Length) * I2.Loc.StringObfucator.StringObfuscatorPassword.Length))) << 1);
                System.Char[] val_7 = ((I2.Loc.StringObfucator.StringObfuscatorPassword + ((long)(int)(0 - ((0 / I2.Loc.StringObfucator.StringObfuscatorPassword.Length) * I2.Loc.StringObfucator.StringObfuscatorPassword.Length))) << 1) + 32) ^ 1152921505017588960;
                val_7 = val_7 & 65535;
                val_7 = val_7 ^ (((((val_10 & 1) != 0) ? 23 : 50) * val_10) & 255);
                mem2[0] = val_7;
                val_10 = val_10 + 1;
            }
            while(val_10 < (long)val_1.Length);
            
            }
            
            string val_9 = 0.CreateString(val:  val_11);
            return (string);
        }
        private static StringObfucator()
        {
            I2.Loc.StringObfucator.StringObfuscatorPassword = ToCharArray();
        }
    
    }

}
