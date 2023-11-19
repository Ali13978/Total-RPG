using UnityEngine;

namespace Unitycoding.UIWidgets
{
    public static class UIUtility
    {
        // Fields
        private static System.Collections.Generic.Dictionary<string, Unitycoding.UIWidgets.UIWidget> widgetCache;
        private static UnityEngine.AudioSource audioSource;
        
        // Methods
        public static T Find<T>(string name)
        {
            var val_9;
            var val_19;
            T[] val_20;
            var val_21;
            var val_22;
            var val_23;
            var val_24;
            var val_25;
            Unitycoding.UIWidgets.UIWidget val_1 = 0;
            val_19 = null;
            val_19 = null;
            if(((Unitycoding.UIWidgets.UIUtility.widgetCache.TryGetValue(key:  __RuntimeMethodHiddenParam, value: out  val_1)) == false) || (0 == val_1))
            {
                goto label_7;
            }
            
            System.Type val_6 = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle());
            if((val_1.GetType() & 1) == 0)
            {
                goto label_17;
            }
            
            label_7:
            val_20 = UnityEngine.Object.FindObjectsOfType<UnityEngine.Component>();
            var val_8 = X2 + 48;
            val_21 = 0;
            goto label_15;
            label_22:
            val_20 = val_20;
            val_21 = val_9 + 1;
            label_15:
            if(val_21 >= (val_7 + 24))
            {
                goto label_17;
            }
            
            T[] val_10 = val_20 + (((long)(int)((val_9 + 1))) << 3);
            val_9 = val_21;
            val_22 = 0;
            goto label_20;
            label_37:
            val_22 = 1;
            label_20:
            if(val_22 >= ((val_7 + ((long)(int)((val_9 + 1))) << 3) + 32 + 24))
            {
                goto label_22;
            }
            
            var val_11 = ((val_7 + ((long)(int)((val_9 + 1))) << 3) + 32) + 8;
            bool val_13 = System.String.op_Equality(a:  0, b:  ((val_7 + ((long)(int)((val_9 + 1))) << 3) + 32 + 8) + 32.Name);
            val_23 = null;
            val_23 = null;
            if((Unitycoding.UIWidgets.UIUtility.widgetCache.ContainsKey(key:  ((val_7 + ((long)(int)((val_9 + 1))) << 3) + 32 + 8) + 32.Name)) == true)
            {
                goto label_37;
            }
            
            val_24 = null;
            val_24 = null;
            Unitycoding.UIWidgets.UIUtility.widgetCache.Add(key:  ((val_7 + ((long)(int)((val_9 + 1))) << 3) + 32 + 8) + 32.Name, value:  ((val_7 + ((long)(int)((val_9 + 1))) << 3) + 32 + 8) + 32);
            goto label_37;
            label_17:
            if((((val_7 + ((long)(int)((val_9 + 1))) << 3) + 32 + 8) + 32) != 0)
            {
                    val_25 = ((val_7 + ((long)(int)((val_9 + 1))) << 3) + 32 + 8) + 32;
                if(val_25 != 0)
            {
                    return (object)val_25;
            }
            
            }
            
            val_25 = 0;
            return (object)val_25;
        }
        public static T[] Find<T>(string[] names)
        {
            var val_4;
            var val_11;
            var val_12;
            var val_13;
            var val_14;
            var val_15;
            val_11 = __RuntimeMethodHiddenParam;
            if((__RuntimeMethodHiddenParam + 24) < 1)
            {
                goto label_2;
            }
            
            val_12 = 0;
            goto label_3;
            label_13:
            val_12 = 1;
            label_3:
            if(val_12 >= (__RuntimeMethodHiddenParam + 24))
            {
                goto label_33;
            }
            
            var val_1 = val_11 + 8;
            if((0 == 0) || ((X2 + 48) != 0))
            {
                goto label_13;
            }
            
            goto label_13;
            label_2:
            val_13 = null;
            val_13 = null;
            Dictionary.Enumerator<TKey, TValue> val_3 = Unitycoding.UIWidgets.UIUtility.widgetCache.GetEnumerator();
            do
            {
                label_26:
                if((0 & 1) == 0)
            {
                goto label_35;
            }
            
                UnityEngine.Playables.PlayableHandle val_6 = val_4.GetHandle();
                System.Type val_8 = val_6.m_Handle.GetType();
            }
            while(((System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle())) & 1) == 0);
            
            if(val_6.m_Handle != 0)
            {
                    val_14 = ;
                if(val_6.m_Handle != 0)
            {
                goto label_26;
            }
            
            }
            
            val_14 = 0;
            goto label_26;
            label_35:
            var val_10 = 0;
            val_10 = val_10 + 1;
            val_15;
            label_33:
            if((X2 + 48) != 0)
            {
                    return (T[])X2 + 48;
            }
            
            return (T[])X2 + 48;
        }
        public static void PlaySound(UnityEngine.AudioClip clip, float volume)
        {
            var val_11;
            var val_12;
            var val_13;
            var val_14;
            var val_15;
            if(0 == X1)
            {
                    return;
            }
            
            val_11 = null;
            val_11 = null;
            if(0 == Unitycoding.UIWidgets.UIUtility.audioSource)
            {
                    UnityEngine.UI.Extensions.BoundTooltipItem val_4 = UnityEngine.Object.FindObjectOfType<UnityEngine.UI.Extensions.BoundTooltipItem>();
                if(0 != val_4)
            {
                    val_12 = null;
                val_12 = null;
                Unitycoding.UIWidgets.UIUtility.audioSource = val_4.GetComponent<UnityEngine.AudioSource>();
                if(0 == Unitycoding.UIWidgets.UIUtility.audioSource)
            {
                    val_13 = null;
                val_13 = null;
                Unitycoding.UIWidgets.UIUtility.audioSource = val_4.gameObject.AddComponent<UnityEngine.AudioSource>();
            }
            
            }
            
            }
            
            val_14 = null;
            val_14 = null;
            if(0 == Unitycoding.UIWidgets.UIUtility.audioSource)
            {
                    return;
            }
            
            val_15 = null;
            val_15 = null;
            Unitycoding.UIWidgets.UIUtility.audioSource.PlayOneShot(clip:  X1, volumeScale:  volume);
        }
        public static string ColorToHex(UnityEngine.Color32 color)
        {
            return (string)0 + ???(???) + ???(???);
        }
        public static UnityEngine.Color HexToColor(string hex)
        {
            null = null;
            string val_2 = X1.Replace(oldValue:  "0x", newValue:  System.String.Empty).Replace(oldValue:  "#", newValue:  System.String.Empty);
            byte val_4 = System.Byte.Parse(s:  0, style:  val_2.Substring(startIndex:  0, length:  2));
            byte val_6 = System.Byte.Parse(s:  0, style:  val_2.Substring(startIndex:  2, length:  2));
            byte val_8 = System.Byte.Parse(s:  0, style:  val_2.Substring(startIndex:  4, length:  2));
            if(val_2.Length == 8)
            {
                    byte val_11 = System.Byte.Parse(s:  0, style:  val_2.Substring(startIndex:  4, length:  2));
            }
            
            UnityEngine.Color val_12 = UnityEngine.Color32.op_Implicit(c:  new UnityEngine.Color32());
            return new UnityEngine.Color() {r = val_12.r, g = val_12.g, b = val_12.b, a = val_12.a};
        }
        public static string ColorString(string value, UnityEngine.Color color)
        {
            typeof(System.String[]).__il2cppRuntimeField_20 = "<color=#";
            UnityEngine.Color32 val_1 = UnityEngine.Color32.op_Implicit(c:  new UnityEngine.Color() {r = color.r, g = color.g, b = color.b, a = color.a});
            0 = null;
            byte val_2 = val_1.r & 4294967295;
            typeof(System.String[]).__il2cppRuntimeField_28 = Unitycoding.UIWidgets.UIUtility.ColorToHex(color:  new UnityEngine.Color32() {g = 48, b = 178, a = 22});
            typeof(System.String[]).__il2cppRuntimeField_30 = ">";
            typeof(System.String[]).__il2cppRuntimeField_38 = X1;
            typeof(System.String[]).__il2cppRuntimeField_40 = "</color>";
            return +0;
        }
        private static UIUtility()
        {
            Unitycoding.UIWidgets.UIUtility.widgetCache = new System.Collections.Generic.Dictionary<System.String, Unitycoding.UIWidgets.UIWidget>();
        }
    
    }

}
