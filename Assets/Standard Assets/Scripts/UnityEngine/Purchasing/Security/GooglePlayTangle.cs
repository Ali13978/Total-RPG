using UnityEngine;

namespace UnityEngine.Purchasing.Security
{
    public class GooglePlayTangle
    {
        // Fields
        private static byte[] data;
        private static int[] order;
        private static int key;
        public static readonly bool IsPopulated;
        
        // Methods
        public GooglePlayTangle()
        {
        
        }
        public static byte[] Data()
        {
            var val_1 = null;
            if(UnityEngine.Purchasing.Security.GooglePlayTangle.IsPopulated == false)
            {
                    return 0;
            }
            
            return UnityEngine.Purchasing.Security.Obfuscator.DeObfuscate(data:  0, order:  UnityEngine.Purchasing.Security.GooglePlayTangle.__il2cppRuntimeField_static_fields, key:  UnityEngine.Purchasing.Security.GooglePlayTangle.order);
        }
        private static GooglePlayTangle()
        {
            UnityEngine.Purchasing.Security.GooglePlayTangle.data = System.Convert.FromBase64String(s:  0);
            UnityEngine.Purchasing.Security.GooglePlayTangle.order = null;
            UnityEngine.Purchasing.Security.GooglePlayTangle.key = 227;
            UnityEngine.Purchasing.Security.GooglePlayTangle.IsPopulated = true;
        }
    
    }

}
