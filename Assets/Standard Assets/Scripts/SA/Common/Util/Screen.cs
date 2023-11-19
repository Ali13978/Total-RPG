using UnityEngine;

namespace SA.Common.Util
{
    public static class Screen
    {
        // Methods
        public static void TakeScreenshot(System.Action<UnityEngine.Texture2D> callback)
        {
            System.Action<UnityEngine.Texture2D> val_6;
            SA.Common.Models.ScreenshotMaker val_1 = SA.Common.Models.ScreenshotMaker.Create();
            val_6 = System.Delegate.Combine(a:  0, b:  val_1.OnScreenshotReady);
            if(val_6 != null)
            {
                    if(null == null)
            {
                goto label_4;
            }
            
            }
            
            val_6 = 0;
            label_4:
            val_1.OnScreenshotReady = val_6;
            UnityEngine.Coroutine val_5 = val_1.StartCoroutine(routine:  val_1.SaveScreenshot());
        }
    
    }

}
