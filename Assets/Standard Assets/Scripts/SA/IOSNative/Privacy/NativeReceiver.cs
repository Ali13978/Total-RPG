using UnityEngine;

namespace SA.IOSNative.Privacy
{
    public class NativeReceiver : Singleton<SA.IOSNative.Privacy.NativeReceiver>
    {
        // Methods
        public NativeReceiver()
        {
        
        }
        private void Awake()
        {
            UnityEngine.GameObject val_1 = this.gameObject;
            UnityEngine.Object.DontDestroyOnLoad(target:  0);
        }
        public void Init()
        {
        
        }
        private void PermissionRequestResponseReceived(string permissionData)
        {
            SA.IOSNative.Privacy.PermissionsManager.PermissionRequestResponse(permissionData:  null);
        }
    
    }

}
