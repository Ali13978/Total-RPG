using UnityEngine;

namespace UnityEngine.Purchasing.Security
{
    public class AppleTangle
    {
        // Fields
        private static byte[] data;
        private static int[] order;
        private static int key;
        public static readonly bool IsPopulated;
        
        // Methods
        public AppleTangle()
        {
        
        }
        public static byte[] Data()
        {
            var val_1 = null;
            if(UnityEngine.Purchasing.Security.AppleTangle.IsPopulated == false)
            {
                    return 0;
            }
            
            return UnityEngine.Purchasing.Security.Obfuscator.DeObfuscate(data:  0, order:  UnityEngine.Purchasing.Security.AppleTangle.__il2cppRuntimeField_static_fields, key:  UnityEngine.Purchasing.Security.AppleTangle.order);
        }
        private static AppleTangle()
        {
            UnityEngine.Purchasing.Security.AppleTangle.data = System.Convert.FromBase64String(s:  0);
            UnityEngine.Purchasing.Security.AppleTangle.order = null;
            UnityEngine.Purchasing.Security.AppleTangle.key = 15;
            UnityEngine.Purchasing.Security.AppleTangle.IsPopulated = true;
        }
    
    }

}
