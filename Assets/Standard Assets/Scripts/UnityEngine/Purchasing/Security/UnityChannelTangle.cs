using UnityEngine;

namespace UnityEngine.Purchasing.Security
{
    public class UnityChannelTangle
    {
        // Fields
        private static byte[] data;
        private static int[] order;
        private static int key;
        public static readonly bool IsPopulated;
        
        // Methods
        public UnityChannelTangle()
        {
        
        }
        public static byte[] Data()
        {
            var val_1 = null;
            if(UnityEngine.Purchasing.Security.UnityChannelTangle.IsPopulated == false)
            {
                    return 0;
            }
            
            return UnityEngine.Purchasing.Security.Obfuscator.DeObfuscate(data:  0, order:  UnityEngine.Purchasing.Security.UnityChannelTangle.__il2cppRuntimeField_static_fields, key:  UnityEngine.Purchasing.Security.UnityChannelTangle.order);
        }
        private static UnityChannelTangle()
        {
            null = null;
            UnityEngine.Purchasing.Security.UnityChannelTangle.data = System.Convert.FromBase64String(s:  0);
            UnityEngine.Purchasing.Security.UnityChannelTangle.order = null;
            UnityEngine.Purchasing.Security.UnityChannelTangle.key = 0;
            UnityEngine.Purchasing.Security.UnityChannelTangle.IsPopulated = false;
        }
    
    }

}
