using UnityEngine;

namespace SA.Common.Models
{
    public class ScreenshotMaker : MonoBehaviour
    {
        // Fields
        public System.Action<UnityEngine.Texture2D> OnScreenshotReady;
        private static System.Action<UnityEngine.Texture2D> <>f__am$cache0;
        
        // Methods
        public ScreenshotMaker()
        {
            if((SA.Common.Models.ScreenshotMaker.<>f__am$cache0) == null)
            {
                    SA.Common.Models.ScreenshotMaker.<>f__am$cache0 = new System.Action<UnityEngine.Texture2D>(object:  0, method:  static System.Void SA.Common.Models.ScreenshotMaker::<OnScreenshotReady>m__0(UnityEngine.Texture2D ));
                null = null;
            }
            
            this.OnScreenshotReady = SA.Common.Models.ScreenshotMaker.<>f__am$cache0;
        }
        public static SA.Common.Models.ScreenshotMaker Create()
        {
            UnityEngine.GameObject val_1 = new UnityEngine.GameObject(name:  "ScreenshotMaker");
            if(null != 0)
            {
                    return AddComponent<SA.Common.Models.ScreenshotMaker>();
            }
            
            return AddComponent<SA.Common.Models.ScreenshotMaker>();
        }
        private void Awake()
        {
            UnityEngine.GameObject val_1 = this.gameObject;
            UnityEngine.Object.DontDestroyOnLoad(target:  0);
        }
        public void GetScreenshot()
        {
            UnityEngine.Coroutine val_2 = this.StartCoroutine(routine:  this.SaveScreenshot());
        }
        [System.Diagnostics.DebuggerHiddenAttribute]
        private System.Collections.IEnumerator SaveScreenshot()
        {
            typeof(ScreenshotMaker.<SaveScreenshot>c__Iterator0).__il2cppRuntimeField_20 = this;
            return (System.Collections.IEnumerator)new System.Object();
        }
        private static void <OnScreenshotReady>m__0(UnityEngine.Texture2D )
        {
        
        }
    
    }

}
