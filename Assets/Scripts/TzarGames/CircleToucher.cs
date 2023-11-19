using UnityEngine;

namespace TzarGames
{
    public class CircleToucher : MonoBehaviour
    {
        // Fields
        private const float dpiFactor = 1.35;
        public UnityEngine.Texture2D DebugCircleImage;
        [System.Diagnostics.DebuggerBrowsableAttribute]
        private float <CircleRadius>k__BackingField;
        public UnityEngine.Camera TargetCamera;
        [UnityEngine.SerializeField]
        private float circleRatioFactor;
        [UnityEngine.SerializeField]
        private float radiusScale;
        private CircleTouchable lastTouched;
        private System.Collections.Generic.Dictionary<CircleTouchable, UnityEngine.Vector3> touchObjectMap;
        public bool debugMode;
        private UnityEngine.Vector2 lastScreenSize;
        private UnityEngine.Vector2 tempVect;
        
        // Properties
        public float CircleRadius { get; set; }
        
        // Methods
        public CircleToucher()
        {
            this.circleRatioFactor = 0f;
            this.radiusScale = 1f;
            this.touchObjectMap = new System.Collections.Generic.Dictionary<CircleTouchable, UnityEngine.Vector3>();
            UnityEngine.Vector2 val_2 = UnityEngine.Vector2.zero;
            this.tempVect = val_2;
            mem[1152921511059752408] = val_2.y;
        }
        public float get_CircleRadius()
        {
            return (float)this.<CircleRadius>k__BackingField;
        }
        private void set_CircleRadius(float value)
        {
            this.<CircleRadius>k__BackingField = value;
        }
        private UnityEngine.Texture2D createCircleTexture(int width, int height)
        {
            if(height >= 1)
            {
                    var val_8 = 0;
                float val_2 = (float)width * 0.5f;
                do
            {
                if(width >= 1)
            {
                    var val_7 = 0;
                var val_6 = 0;
                do
            {
                float val_4 = ((UnityEngine.Vector2.Distance(a:  new UnityEngine.Vector2() {x = 0f, y = 0f}, b:  new UnityEngine.Vector2() {x = val_2, y = val_2})) > val_2) ? 0f : 1f;
                val_6 = val_6 + 1;
                val_7 = val_7 + 1;
                typeof(UnityEngine.Color[]).__il2cppRuntimeField_20 = val_4;
                typeof(UnityEngine.Color[]).__il2cppRuntimeField_24 = val_4;
                typeof(UnityEngine.Color[]).__il2cppRuntimeField_28 = val_4;
                typeof(UnityEngine.Color[]).__il2cppRuntimeField_2C = val_4 * 0.5f;
            }
            while(width != val_7);
            
            }
            
                val_8 = val_8 + 1;
                height * width = 0 + width;
            }
            while(val_8 != height);
            
            }
            
            if(null != 0)
            {
                    SetPixels(colors:  null);
            }
            else
            {
                    SetPixels(colors:  null);
            }
            
            Apply(updateMipmaps:  false);
            return (UnityEngine.Texture2D)new UnityEngine.Texture2D(width:  width, height:  height, format:  5, mipmap:  false);
        }
        private void Start()
        {
            this.updateCircleRadius();
        }
        private void updateCircleRadius()
        {
            float val_12;
            if(UnityEngine.Screen.dpi == 0f)
            {
                    val_12 = (float)UnityEngine.Screen.width / this.circleRatioFactor;
            }
            else
            {
                    val_12 = UnityEngine.Screen.dpi;
            }
            
            this.<CircleRadius>k__BackingField = val_12;
            typeof(System.Object[]).__il2cppRuntimeField_20 = "Screen DPI is ";
            typeof(System.Object[]).__il2cppRuntimeField_28 = UnityEngine.Screen.dpi;
            typeof(System.Object[]).__il2cppRuntimeField_2C = 268435457;
            typeof(System.Object[]).__il2cppRuntimeField_30 = ", touch circle radius has been set to ";
            typeof(System.Object[]).__il2cppRuntimeField_38 = this.<CircleRadius>k__BackingField;
            typeof(System.Object[]).__il2cppRuntimeField_3C = 268435457;
            string val_5 = +0;
            UnityEngine.Debug.Log(message:  0);
            if(this.debugMode != false)
            {
                    bool val_6 = UnityEngine.Object.op_Equality(x:  0, y:  this.DebugCircleImage);
                if(val_6 != false)
            {
                    this.DebugCircleImage = val_6.createCircleTexture(width:  256, height:  256);
            }
            
            }
            
            CinemachineFreeLook.Orbit val_10 = new CinemachineFreeLook.Orbit(h:  (float)UnityEngine.Screen.width, r:  (float)UnityEngine.Screen.height);
            this.lastScreenSize = val_10.m_Height;
            mem[1152921511060333120] = val_10.m_Height >> 32;
        }
        public CircleTouchable CheckPoint(float x, float y)
        {
            var val_16;
            this.lastTouched = 0;
            this.tempVect = x;
            mem[1152921511060500424] = y;
            val_16 = 0;
            goto label_1;
            label_22:
            val_16 = 1;
            label_1:
            if(val_16 >= CircleTouchable.touchables.Count)
            {
                    return (CircleTouchable)this.lastTouched;
            }
            
            CircleTouchable val_4 = CircleTouchable.touchables.Item[1];
            if((val_4.enabled == false) || (val_4.gameObject.activeSelf == false))
            {
                goto label_22;
            }
            
            UnityEngine.Vector3 val_10 = val_4.gameObject.transform.position;
            UnityEngine.Vector3 val_11 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_10.x, y = val_10.y, z = val_10.z}, b:  new UnityEngine.Vector3() {x = val_4.CirclePivotDisplacement, y = V12.16B, z = V11.16B});
            UnityEngine.Vector3 val_12 = this.TargetCamera.WorldToScreenPoint(position:  new UnityEngine.Vector3() {x = val_11.x, y = val_11.y, z = val_11.z});
            UnityEngine.Vector2 val_13 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = val_12.x, y = val_12.y, z = val_12.z});
            float val_14 = UnityEngine.Vector2.Distance(a:  new UnityEngine.Vector2() {x = val_13.x, y = val_13.y}, b:  new UnityEngine.Vector2() {x = this.tempVect, y = val_4.CirclePivotDisplacement});
            if(val_14 > (3.402823E+38f))
            {
                goto label_22;
            }
            
            float val_16 = val_4.TouchCircleScaleFactor;
            val_16 = (this.radiusScale * (this.<CircleRadius>k__BackingField)) * val_16;
            if(val_14 > val_16)
            {
                goto label_22;
            }
            
            this.lastTouched = val_4;
            goto label_22;
        }
        private void updateCircles()
        {
            var val_4;
            var val_7;
            var val_27;
            Dictionary.Enumerator<TKey, TValue> val_1 = this.touchObjectMap.GetEnumerator();
            do
            {
                label_6:
                if((0 & 1) == 0)
            {
                goto label_24;
            }
            
                GooglePlayGames.BasicApi.Nearby.EndpointDetails val_5 = val_4.RemoteEndpoint;
            }
            while((CircleTouchable.touchables.Contains(item:  val_7.InitializationCallback)) == true);
            
            bool val_13 = this.touchObjectMap.Remove(key:  val_7.InitializationCallback);
            goto label_6;
            label_24:
            val_4.Dispose();
            val_27 = 0;
            goto label_9;
            label_23:
            0.set_Item(key:  1152921511060626224, value:  new UnityEngine.Vector3() {x = V8.16B, y = V9.16B, z = V10.16B});
            val_27 = 1;
            label_9:
            if(val_27 >= CircleTouchable.touchables.Count)
            {
                    return;
            }
            
            UnityEngine.Vector3 val_20 = CircleTouchable.touchables.Item[1].gameObject.transform.position;
            CircleTouchable val_22 = CircleTouchable.touchables.Item[1];
            UnityEngine.Vector3 val_23 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_20.x, y = val_20.y, z = val_20.z}, b:  new UnityEngine.Vector3() {x = val_22.CirclePivotDisplacement, y = V12.16B, z = V11.16B});
            UnityEngine.Vector3 val_24 = this.TargetCamera.WorldToScreenPoint(position:  new UnityEngine.Vector3() {x = val_23.x, y = val_23.y, z = val_23.z});
            CircleTouchable val_26 = CircleTouchable.touchables.Item[1];
            if(this.touchObjectMap != null)
            {
                goto label_23;
            }
            
            goto label_23;
        }
        private void OnGUI()
        {
            var val_6;
            var val_9;
            var val_23;
            UnityEngine.Vector2 val_24;
            float val_25;
            float val_30;
            float val_31;
            val_23 = this;
            val_24 = this.lastScreenSize;
            val_25 = (float)UnityEngine.Screen.width;
            if(val_24 != val_25)
            {
                goto label_1;
            }
            
            val_25 = (float)UnityEngine.Screen.height;
            if(val_24 == val_25)
            {
                goto label_2;
            }
            
            label_1:
            this.updateCircleRadius();
            label_2:
            if(this.debugMode == false)
            {
                    return;
            }
            
            this.updateCircles();
            Dictionary.Enumerator<TKey, TValue> val_3 = this.touchObjectMap.GetEnumerator();
            label_20:
            if((0 & 1) == 0)
            {
                goto label_23;
            }
            
            GooglePlayGames.BasicApi.Nearby.EndpointDetails val_7 = val_6.RemoteEndpoint;
            if(0 == val_9.InitializationCallback)
            {
                    UnityEngine.Color val_12 = UnityEngine.Color.green;
                val_30 = val_12.r;
                val_31 = val_12.g;
                UnityEngine.GUI.color = new UnityEngine.Color() {r = val_30, g = val_31, b = val_12.b, a = val_12.a};
            }
            else
            {
                    UnityEngine.Color val_13 = UnityEngine.Color.red;
                val_30 = val_13.r;
                val_31 = val_13.g;
                UnityEngine.GUI.color = new UnityEngine.Color() {r = val_30, g = val_31, b = val_13.b, a = val_13.a};
            }
            
            System.Action<GooglePlayGames.BasicApi.Nearby.InitializationStatus> val_14 = val_9.InitializationCallback;
            System.Action<GooglePlayGames.BasicApi.Nearby.InitializationStatus> val_16 = val_9.InitializationCallback;
            System.Action<GooglePlayGames.BasicApi.Nearby.InitializationStatus> val_17 = val_9.InitializationCallback;
            System.Action<GooglePlayGames.BasicApi.Nearby.InitializationStatus> val_18 = val_9.InitializationCallback;
            float val_19 = (this.<CircleRadius>k__BackingField) * this.radiusScale;
            float val_20 = S14 + S14;
            float val_21 = val_19 * S13;
            float val_23 = (float)UnityEngine.Screen.height;
            float val_22 = val_19 * S12;
            val_21 = val_31 + val_21;
            val_20 = val_19 * val_20;
            val_19 = val_19 * S4;
            val_22 = val_30 - val_22;
            val_23 = val_23 - val_21;
            val_19 = val_19 + val_19;
            UnityEngine.GUI.DrawTexture(position:  new UnityEngine.Rect() {m_XMin = 0f, m_YMin = 0f, m_Width = 0f, m_Height = 0f}, image:  0, scaleMode:  this.DebugCircleImage, alphaBlend:  false);
            goto label_20;
            label_23:
            val_6.Dispose();
            if((0 & 1) != 0)
            {
                    return;
            }
            
            if( == 0)
            {
                    return;
            }
        
        }
        [TzarGames.Common.ConsoleCommand]
        private void CircleToucher_SetRadius(float circleRadius)
        {
            this.<CircleRadius>k__BackingField = circleRadius;
        }
        [TzarGames.Common.ConsoleCommand]
        private void CircleToucher_SetRadiusScale(float scale)
        {
            this.radiusScale = scale;
        }
        [TzarGames.Common.ConsoleCommand]
        private void CircleToucher_SetDebugMode(bool on)
        {
            this.debugMode = on;
        }
    
    }

}
