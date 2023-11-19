using UnityEngine;

namespace TzarGames.Common
{
    public static class Utils
    {
        // Methods
        public static void LogObjectPath(UnityEngine.Transform textTransform, System.Text.StringBuilder sb)
        {
            if(0 != sb.parent)
            {
                    UnityEngine.Transform val_3 = sb.parent;
                System.Text.StringBuilder val_4 = X2.Append(value:  ".");
            }
            
            System.Text.StringBuilder val_6 = X2.Append(value:  sb.name);
        }
        [TzarGames.Common.ConsoleCommand]
        public static void SendMail(string address, string body)
        {
            string val_1 = System.String.Format(format:  0, arg0:  "mailto:{0}?subject=Email&body={1}", arg1:  body);
            UnityEngine.Application.OpenURL(url:  0);
        }
        public static byte[] GetBytesFromString(string str)
        {
            if((System.String.IsNullOrEmpty(value:  0)) != false)
            {
                    return 0;
            }
            
            if(System.Text.Encoding.UTF8 == null)
            {
                
            }
        
        }
        public static string GetStringFromBytes(byte[] bytes)
        {
            var val_6 = X1;
            if(val_6 == 0)
            {
                    return 0;
            }
            
            System.Text.Encoding val_1 = System.Text.Encoding.UTF8;
            val_6 = ???;
            goto typeof(System.Text.Encoding).__il2cppRuntimeField_270;
        }
        public static void DestroyAllChilds(UnityEngine.Transform transform)
        {
            goto label_1;
            label_9:
            UnityEngine.Object.Destroy(obj:  0);
            0 = 1;
            label_1:
            if(0 >= X1.childCount)
            {
                    return;
            }
            
            UnityEngine.GameObject val_4 = X1.transform.GetChild(index:  1).gameObject;
            goto label_9;
        }
        [System.Diagnostics.DebuggerHiddenAttribute]
        public static System.Collections.IEnumerator WaitForTime(float timeSeconds)
        {
            typeof(Utils.<WaitForTime>c__Iterator0).__il2cppRuntimeField_10 = timeSeconds;
            return (System.Collections.IEnumerator)new System.Object();
        }
        [System.Diagnostics.DebuggerHiddenAttribute]
        public static System.Collections.IEnumerator WaitForFixedUpdate()
        {
            return (System.Collections.IEnumerator)new System.Object();
        }
        [System.Diagnostics.DebuggerHiddenAttribute]
        public static System.Collections.IEnumerator EnableBehaviour(System.Collections.IEnumerator ienumerator, UnityEngine.Behaviour behaviour, bool enabled)
        {
            if(null != 0)
            {
                    typeof(Utils.<EnableBehaviour>c__Iterator2).__il2cppRuntimeField_10 = behaviour;
                typeof(Utils.<EnableBehaviour>c__Iterator2).__il2cppRuntimeField_18 = W3 & 1;
            }
            else
            {
                    mem[16] = behaviour;
                mem[24] = W3 & 1;
            }
            
            typeof(Utils.<EnableBehaviour>c__Iterator2).__il2cppRuntimeField_20 = enabled;
            return (System.Collections.IEnumerator)new System.Object();
        }
        public static void SetLayerRecursively(UnityEngine.GameObject go, int layerNumber)
        {
            goto label_2;
            label_8:
            layer = W2;
            0 = 1;
            label_2:
            if(0 >= val_1.Length)
            {
                    return;
            }
            
            if((layerNumber.GetComponentsInChildren<UnityEngine.Transform>(includeInactive:  true)[1].gameObject) != null)
            {
                goto label_8;
            }
            
            goto label_8;
        }
        public static void TurnCollisions(UnityEngine.GameObject obj, bool on)
        {
            var val_2;
            bool val_2 = W2;
            val_2 = 0;
            val_2 = val_2 & 1;
            goto label_2;
            label_7:
            enabled = val_2;
            val_2 = 1;
            label_2:
            if(val_2 >= val_1.Length)
            {
                    return;
            }
            
            if((on.GetComponentsInChildren<UnityEngine.Collider>()[1]) != 0)
            {
                goto label_7;
            }
            
            goto label_7;
        }
        public static void AddCircleToObject(UnityEngine.GameObject go, float radius = 1, float theta_scale = 0.1)
        {
            float val_11 = 6.283185f;
            val_11 = val_11 / theta_scale;
            UnityEngine.LineRenderer val_1 = X1.AddComponent<UnityEngine.LineRenderer>();
            val_1.material = new UnityEngine.Material(shader:  UnityEngine.Shader.Find(name:  0));
            UnityEngine.Color val_4 = UnityEngine.Color.red;
            val_1.startColor = new UnityEngine.Color() {r = val_4.r, g = val_4.g, b = val_4.b, a = val_4.a};
            UnityEngine.Color val_5 = UnityEngine.Color.red;
            if(val_1 != null)
            {
                    val_1.endColor = new UnityEngine.Color() {r = val_5.r, g = val_5.g, b = val_5.b, a = val_5.a};
                val_1.startWidth = 0.2f;
                val_1.endWidth = 0.2f;
            }
            else
            {
                    val_1.endColor = new UnityEngine.Color() {r = val_5.r, g = val_5.g, b = val_5.b, a = val_5.a};
                val_1.startWidth = 0.2f;
                val_1.endWidth = 0.2f;
            }
            
            val_1.positionCount = (int)val_11;
            var val_12 = 0;
            float val_13 = 0f;
            do
            {
                float val_6 = val_13 * radius;
                float val_7 = val_13 * radius;
                UnityEngine.Vector3 val_9 = X1.transform.position;
                UnityEngine.Vector3 val_10 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, b:  new UnityEngine.Vector3() {x = val_9.x, y = val_9.y, z = val_9.z});
                val_1.SetPosition(index:  0, position:  new UnityEngine.Vector3() {x = val_10.x, y = val_10.y, z = val_10.z});
                val_12 = val_12 + 1;
                val_13 = val_13 + 0.1f;
            }
            while(val_12 != 63);
        
        }
        public static void GetComponentsInSceneAll<T>(System.Collections.Generic.List<T> result)
        {
            var val_3;
            var val_4;
            var val_9;
            var val_10;
            var val_11;
            UnityEngine.SceneManagement.Scene val_1 = UnityEngine.SceneManagement.SceneManager.GetActiveScene();
            val_9 = 0;
            val_10 = 0;
            goto label_1;
            label_20:
            val_10 = 1;
            label_1:
            if(val_10 >= (???))
            {
                    return;
            }
            
            UnityEngine.Transform val_2 = ???.transform;
            label_11:
            if((0 & 1) == 0)
            {
                goto label_7;
            }
            
            System.Action<GooglePlayGames.BasicApi.Nearby.InitializationStatus> val_5 = val_4.InitializationCallback;
            if((((__RuntimeMethodHiddenParam & 1) & 1) != 0) || (__RuntimeMethodHiddenParam != 0))
            {
                goto label_11;
            }
            
            goto label_11;
            label_7:
            val_4 = X2 + 48 + 64;
            val_3 = val_4;
            if((X2 + 48 + 64 + 258) == 0)
            {
                goto label_16;
            }
            
            var val_8 = X2 + 48 + 64 + 152;
            var val_9 = 0;
            val_8 = val_8 + 8;
            label_15:
            if(((X2 + 48 + 64 + 152 + 8) + -8) == null)
            {
                goto label_14;
            }
            
            val_9 = val_9 + 1;
            val_8 = val_8 + 16;
            if(val_9 < (X2 + 48 + 64 + 258))
            {
                goto label_15;
            }
            
            goto label_16;
            label_14:
            val_11 = ((X2 + 48 + 64) + (((X2 + 48 + 64 + 152 + 8)) << 4)) + 272;
            label_16:
            if(124 != 124)
            {
                goto label_17;
            }
            
            goto label_20;
            label_17:
            if(val_9 == 0)
            {
                goto label_20;
            }
            
            goto label_20;
        }
        public static void GetComponentsInChildrenAll<T>(UnityEngine.Transform target, System.Collections.Generic.List<T> result)
        {
            var val_5;
            var val_6;
            val_5 = 0;
            goto label_2;
            label_10:
            val_5 = 1;
            label_2:
            if(val_5 >= val_1.Length)
            {
                goto label_4;
            }
            
            T val_5 = result.GetComponents<UnityEngine.Component>()[1];
            if(((val_5 == 0) || (val_5 == 0)) || (val_5 != 0))
            {
                goto label_10;
            }
            
            goto label_10;
            label_4:
            val_6 = 0;
            goto label_11;
            label_15:
            UnityEngine.Transform val_3 = result.GetChild(index:  0);
            val_6 = 1;
            label_11:
            if(val_6 >= result.childCount)
            {
                    return;
            }
            
            if(result != null)
            {
                goto label_15;
            }
            
            goto label_15;
        }
        public static UnityEngine.Object FindComponentOfType<T>()
        {
            var val_2;
            T val_3;
            val_2 = 0;
            label_6:
            if(val_2 >= val_1.Length)
            {
                goto label_4;
            }
            
            val_3 = UnityEngine.Object.FindObjectsOfType<UnityEngine.Component>()[0];
            val_2 = val_2 + 1;
            if(val_3 == 0)
            {
                goto label_6;
            }
            
            return (UnityEngine.Object)val_3;
            label_4:
            val_3 = 0;
            return (UnityEngine.Object)val_3;
        }
        public static T GetComponentInChildrenAll<T>(UnityEngine.Transform target)
        {
            var val_9;
            UnityEngine.Object val_10 = __RuntimeMethodHiddenParam;
            if(0 != val_10)
            {
                    return (object)val_10;
            }
            
            val_9 = 0;
            label_14:
            if(val_9 >= __RuntimeMethodHiddenParam.childCount)
            {
                goto label_6;
            }
            
            val_10 = __RuntimeMethodHiddenParam.GetChild(index:  0);
            if(0 != val_10)
            {
                    return (object)val_10;
            }
            
            val_10 = 0;
            val_9 = val_9 + 1;
            if(0 == val_10)
            {
                goto label_14;
            }
            
            return (object)val_10;
            label_6:
            val_10 = 0;
            return (object)val_10;
        }
        public static UnityEngine.Transform GetTopParent(UnityEngine.Transform child)
        {
            var val_4 = X1;
            goto label_0;
            label_7:
            val_4 = val_4.parent;
            label_0:
            if(0 == val_4.parent)
            {
                    return (UnityEngine.Transform)val_4;
            }
            
            if(val_4 != null)
            {
                goto label_7;
            }
            
            goto label_7;
        }
        public static UnityEngine.GUIStyle GetStyleWithFontSize(int size)
        {
            if(null != 0)
            {
                    fontSize = W1;
            }
            else
            {
                    fontSize = W1;
            }
            
            UnityEngine.Color val_3 = UnityEngine.Color.white;
            normal.textColor = new UnityEngine.Color() {r = val_3.r, g = val_3.g, b = val_3.b, a = val_3.a};
            return (UnityEngine.GUIStyle)new UnityEngine.GUIStyle();
        }
        [TzarGames.Common.ConsoleCommand]
        public static void SetLightShadowType(UnityEngine.LightShadows shadowsType)
        {
            goto label_3;
            label_8:
            X21.shadows = W1;
            0 = 1;
            label_3:
            if(0 >= val_1.Length)
            {
                    return;
            }
            
            if((UnityEngine.Object.FindObjectsOfType<UnityEngine.Component>()[1]) != 0)
            {
                goto label_8;
            }
            
            goto label_8;
        }
        [TzarGames.Common.ConsoleCommand]
        public static void SetLightRenderMode(UnityEngine.LightRenderMode lightRenderMode)
        {
            goto label_3;
            label_8:
            X21.renderMode = W1;
            0 = 1;
            label_3:
            if(0 >= val_1.Length)
            {
                    return;
            }
            
            if((UnityEngine.Object.FindObjectsOfType<UnityEngine.Component>()[1]) != 0)
            {
                goto label_8;
            }
            
            goto label_8;
        }
        [TzarGames.Common.ConsoleCommand]
        public static void SetQualityLevel(int level)
        {
            UnityEngine.QualitySettings.SetQualityLevel(index:  0, applyExpensiveChanges:  false);
        }
        [TzarGames.Common.ConsoleCommand]
        public static void SetLightmappingMode(UnityEngine.LightmapsMode mode)
        {
            UnityEngine.LightmapSettings.lightmapsMode = 0;
        }
        [TzarGames.Common.ConsoleCommand]
        public static void EnableSSAO(bool enable)
        {
            UnityEngine.Debug.LogError(message:  0);
        }
        [TzarGames.Common.ConsoleCommand]
        public static void EnableFilmicTonemapping(bool enable)
        {
            var val_2;
            bool val_2 = W1;
            val_2 = 0;
            val_2 = val_2 & 1;
            goto label_3;
            label_8:
            X21.enabled = val_2;
            val_2 = 1;
            label_3:
            if(val_2 >= val_1.Length)
            {
                    return;
            }
            
            if((UnityEngine.Object.FindObjectsOfType<UnityEngine.Component>()[1]) != 0)
            {
                goto label_8;
            }
            
            goto label_8;
        }
        [TzarGames.Common.ConsoleCommand]
        public static void EnablePostEffects(bool enable)
        {
            TzarGames.Common.Utils.EnableSSAO(enable:  enable);
            var val_1 = W1 & 1;
            TzarGames.Common.Utils.EnableFilmicTonemapping(enable:  enable);
        }
        [TzarGames.Common.ConsoleCommand]
        public static void SetRenderpath(UnityEngine.RenderingPath renderPath)
        {
            goto label_3;
            label_8:
            X21.renderingPath = W1;
            0 = 1;
            label_3:
            if(0 >= val_1.Length)
            {
                    return;
            }
            
            if((UnityEngine.Object.FindObjectsOfType<UnityEngine.Component>()[1]) != 0)
            {
                goto label_8;
            }
            
            goto label_8;
        }
        public static string GeneratePassword(int length)
        {
            var val_9;
            string val_10;
            var val_11;
            val_9 = null;
            val_9 = null;
            val_10 = System.String.Empty;
            if(W1 < 1)
            {
                    return (string);
            }
            
            val_11 = 0;
            int val_1 = UnityEngine.Random.Range(min:  0, max:  0);
            if(((val_1 < 3) ? (val_1 + 7) : 0) > 9)
            {
                    return (string);
            }
            
            var val_9 = 25486760 + (val_1 < 3 ? (val_1 + 7) : 0) << 2;
            val_9 = val_9 + 25486760;
            goto (25486760 + (val_1 < 3 ? (val_1 + 7) : 0) << 2 + 25486760);
        }
    
    }

}
