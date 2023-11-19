using UnityEngine;

namespace SA.IOSNative.Privacy
{
    public static class PermissionsManager
    {
        // Fields
        private static System.Collections.Generic.Dictionary<string, System.Action<SA.IOSNative.Privacy.PermissionStatus>> OnResponseDictionary;
        
        // Methods
        private static PermissionsManager()
        {
            SA.IOSNative.Privacy.PermissionsManager.OnResponseDictionary = new System.Collections.Generic.Dictionary<System.String, System.Action<SA.IOSNative.Privacy.PermissionStatus>>();
        }
        public static SA.IOSNative.Privacy.PermissionStatus CheckPermissions(SA.IOSNative.Privacy.Permission permission)
        {
            return 0;
        }
        public static void RequestPermission(SA.IOSNative.Privacy.Permission permission, System.Action<SA.IOSNative.Privacy.PermissionStatus> callback)
        {
            var val_6;
            if(0 == (SA.Common.Pattern.Singleton<SA_EditorAd>.Instance))
            {
                    SA_EditorAd val_3 = SA.Common.Pattern.Singleton<SA_EditorAd>.Instance;
            }
            
            val_6 = null;
            val_6 = null;
            UnityEngine.Vector2 val_5 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3());
            SA.IOSNative.Privacy.PermissionsManager.OnResponseDictionary.set_Item(key:  callback.ToString(), value:  X2);
        }
        internal static void PermissionRequestResponse(string permissionData)
        {
            System.Collections.Generic.Dictionary<System.String, System.Action<SA.IOSNative.Privacy.PermissionStatus>> val_6;
            var val_7;
            typeof(System.String[]).__il2cppRuntimeField_20 = "|%|";
            System.String[] val_1 = X1.Split(separator:  null, options:  0);
            val_6 = 0;
            label_11:
            if(val_6 >= val_1.Length)
            {
                goto label_7;
            }
            
            val_6 = val_6 + 1;
            if((System.String.op_Equality(a:  0, b:  val_1[0])) == false)
            {
                goto label_11;
            }
            
            label_7:
            if(val_1.Length < 1)
            {
                    return;
            }
            
            val_7 = null;
            val_7 = null;
            val_6 = SA.IOSNative.Privacy.PermissionsManager.OnResponseDictionary;
            System.Action<SA.IOSNative.Privacy.PermissionStatus> val_4 = val_6.Item[val_1[0]];
            if(val_4 == null)
            {
                    return;
            }
            
            if(val_1[1] == null)
            {
                    return;
            }
            
            val_4.Invoke(obj:  System.Int32.Parse(s:  0));
        }
    
    }

}
