using UnityEngine;

namespace FlurryAnalytics
{
    public class TestScript : MonoBehaviour
    {
        // Fields
        [UnityEngine.HeaderAttribute]
        [UnityEngine.SerializeField]
        private string _iosApiKey;
        [UnityEngine.SerializeField]
        private string _androidApiKey;
        
        // Methods
        public TestScript()
        {
            null = null;
            this._iosApiKey = System.String.Empty;
            this._androidApiKey = System.String.Empty;
        }
        private void Awake()
        {
            var val_4;
            var val_5;
            FlurryAnalytics.Flurry val_1 = FlurryAnalytics.MonoSingleton<FlurryAnalytics.Flurry>.Instance;
            var val_4 = 0;
            val_4 = val_4 + 1;
            val_4 = val_1;
            var val_5 = 0;
            val_5 = val_5 + 1;
            val_5 = val_1;
        }
        private void OnGUI()
        {
            var val_20;
            var val_21;
            var val_22;
            var val_23;
            var val_24;
            var val_25;
            var val_26;
            var val_27;
            var val_28;
            var val_29;
            var val_30;
            var val_31;
            var val_32;
            var val_33;
            FlurryAnalytics.Flurry val_1 = FlurryAnalytics.MonoSingleton<FlurryAnalytics.Flurry>.Instance;
            val_21 = 0;
            if((val_1.Button(label:  "Log User Name", index:  0)) != false)
            {
                    val_22 = "Github User";
                var val_20 = 0;
                val_20 = val_20 + 1;
                val_21 = 10;
                val_23 = val_1;
                val_20 = val_1;
            }
            
            val_24 = 1;
            if((val_20.Button(label:  "Log User Age", index:  1)) != false)
            {
                    var val_21 = 0;
                val_21 = val_21 + 1;
                val_24 = 11;
                val_25 = val_1;
                val_20 = val_1;
            }
            
            val_26 = 2;
            if((val_20.Button(label:  "Log User Gender", index:  2)) != false)
            {
                    var val_22 = 0;
                val_22 = val_22 + 1;
                val_26 = 12;
                val_27 = val_1;
                val_20 = val_1;
            }
            
            if((val_20.Button(label:  "Log User Location", index:  3).Button(label:  "Log Event", index:  4)) != false)
            {
                    System.Collections.Generic.Dictionary<System.String, System.String> val_10 = null;
                val_22 = val_10;
                val_10 = new System.Collections.Generic.Dictionary<System.String, System.String>();
                Add(key:  "UnityVersion", value:  UnityEngine.Application.unityVersion);
                var val_23 = 0;
                val_23 = val_23 + 1;
                val_28 = val_1;
                val_20 = val_1;
            }
            
            val_29 = 5;
            if((val_20.Button(label:  "Begin Timed Event", index:  5)) != false)
            {
                    val_22 = "timed-event";
                var val_24 = 0;
                val_24 = val_24 + 1;
                val_29 = 5;
                val_30 = val_1;
                val_20 = val_1;
            }
            
            val_31 = 6;
            if((val_20.Button(label:  "End Timed Event", index:  6)) != false)
            {
                    val_22 = "timed-event";
                var val_25 = 0;
                val_25 = val_25 + 1;
                val_31 = 7;
                val_32 = val_1;
                val_20 = val_1;
            }
            
            if((val_20.Button(label:  "Log Page View", index:  7).Button(label:  "Log Error", index:  8)) == false)
            {
                    return;
            }
            
            var val_26 = 0;
            val_26 = val_26 + 1;
            val_33 = val_1;
            goto val_18;
        }
        private bool Button(string label, int index)
        {
            float val_8 = (float)UnityEngine.Screen.width;
            float val_9 = 0.5f;
            val_8 = val_8 * val_9;
            val_9 = ((float)UnityEngine.Screen.width * 0.7f) * val_9;
            val_8 = val_8 - val_9;
            float val_10 = (float)index;
            val_10 = val_10 * ((float)UnityEngine.Screen.height * 0.1f);
            val_10 = val_10 * 1.1f;
            return (bool)UnityEngine.GUI.Button(position:  new UnityEngine.Rect() {m_XMin = 0f, m_YMin = 0f, m_Width = 0f, m_Height = 0f}, text:  0);
        }
        [System.Diagnostics.ConditionalAttribute]
        private void Assert(bool condition, string message, UnityEngine.Object context)
        {
            if(condition != false)
            {
                    return;
            }
            
            UnityEngine.Debug.LogError(message:  0, context:  message);
        }
        [System.Diagnostics.ConditionalAttribute]
        private void AssertNotNull(object target, string message, UnityEngine.Object context)
        {
        
        }
    
    }

}
