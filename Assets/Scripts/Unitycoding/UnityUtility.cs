using UnityEngine;

namespace Unitycoding
{
    [System.Runtime.CompilerServices.ExtensionAttribute]
    public static class UnityUtility
    {
        // Fields
        private static UnityEngine.AudioSource audioSource;
        
        // Methods
        public static void PlaySound(UnityEngine.AudioClip clip, float volume)
        {
            if(0 == X1)
            {
                    return;
            }
            
            if(0 == Unitycoding.UnityUtility.audioSource)
            {
                    UnityEngine.UI.Extensions.BoundTooltipItem val_4 = UnityEngine.Object.FindObjectOfType<UnityEngine.UI.Extensions.BoundTooltipItem>();
                if(0 != val_4)
            {
                    Unitycoding.UnityUtility.audioSource = val_4.GetComponent<UnityEngine.AudioSource>();
                if(0 == Unitycoding.UnityUtility.audioSource)
            {
                    Unitycoding.UnityUtility.audioSource = val_4.gameObject.AddComponent<UnityEngine.AudioSource>();
            }
            
            }
            
            }
            
            if(0 == Unitycoding.UnityUtility.audioSource)
            {
                    return;
            }
            
            Unitycoding.UnityUtility.audioSource.PlayOneShot(clip:  X1, volumeScale:  volume);
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
            byte val_2 = val_1.r & 4294967295;
            typeof(System.String[]).__il2cppRuntimeField_28 = Unitycoding.UnityUtility.ColorToHex(color:  new UnityEngine.Color32() {r = val_1.r, g = val_1.g, b = val_1.b, a = val_1.a});
            typeof(System.String[]).__il2cppRuntimeField_30 = ">";
            typeof(System.String[]).__il2cppRuntimeField_38 = X1;
            typeof(System.String[]).__il2cppRuntimeField_40 = "</color>";
            return +0;
        }
        public static string Replace(string source, string oldString, string newString)
        {
            int val_1 = oldString.IndexOf(value:  newString, comparisonType:  1);
            if((val_1 & 2147483648) != 0)
            {
                    return (string)oldString;
            }
            
            string val_3 = oldString.Remove(startIndex:  val_1, count:  newString.Length);
            if(val_3 != null)
            {
                    return val_3.Insert(startIndex:  val_1, value:  X3);
            }
            
            return val_3.Insert(startIndex:  val_1, value:  X3);
        }
        public static bool IsNumeric(object expression)
        {
            System.IFormatProvider val_6;
            string val_7;
            val_6 = X1;
            if(val_6 != 0)
            {
                    System.Globalization.CultureInfo val_1 = System.Globalization.CultureInfo.InvariantCulture;
                val_6 = System.Convert.ToString(value:  0, provider:  val_6);
                val_7 = 0;
                bool val_5 = System.Double.TryParse(s:  val_7, style:  val_6, provider:  511, result: out  System.Globalization.NumberFormatInfo.InvariantInfo);
            }
            else
            {
                    val_7 = 0;
            }
            
            val_7 = val_7 & 1;
            return (bool)val_7;
        }
        [System.Runtime.CompilerServices.ExtensionAttribute]
        public static UnityEngine.GameObject FindChild(UnityEngine.GameObject target, string name, bool includeInactive)
        {
            UnityEngine.Object val_20;
            var val_21;
            val_20 = 0;
            if(0 == name)
            {
                    return (UnityEngine.GameObject)val_20;
            }
            
            if((System.String.op_Equality(a:  0, b:  name.name)) != false)
            {
                    if(((W3 & 1) & 1) != 0)
            {
                goto label_8;
            }
            
            }
            
            val_21 = 0;
            if((((W3 & 1) & 1) == 0) && (((System.String.op_Equality(a:  0, b:  name.name)) ^ 1) != true))
            {
                    if(name.activeInHierarchy != false)
            {
                    label_8:
                val_20 = name;
                return (UnityEngine.GameObject)val_20;
            }
            
                val_21 = 0;
                do
            {
                val_20 = 0;
                if(val_21 >= name.transform.childCount)
            {
                    return (UnityEngine.GameObject)val_20;
            }
            
                var val_17 = W3 & 1;
                val_20 = name.transform.GetChild(index:  0).gameObject;
                val_21 = val_21 + 1;
            }
            while(0 == val_20);
            
                return (UnityEngine.GameObject)val_20;
            }
        
        }
        [System.Runtime.CompilerServices.ExtensionAttribute]
        public static void Stretch(UnityEngine.RectTransform rectTransform, UnityEngine.RectOffset offset)
        {
            var val_23;
            var val_24;
            var val_25;
            float val_26;
            float val_27;
            UnityEngine.Vector2 val_1 = UnityEngine.Vector2.zero;
            offset.anchorMin = new UnityEngine.Vector2() {x = val_1.x, y = val_1.y};
            UnityEngine.Vector2 val_2 = UnityEngine.Vector2.one;
            offset.anchorMax = new UnityEngine.Vector2() {x = val_2.x, y = val_2.y};
            if(X2 != 0)
            {
                    val_23 = X2.right;
                val_24 = X2.left;
                val_25 = X2.bottom;
            }
            else
            {
                    val_23 = 0.right;
                val_24 = 0.left;
                val_25 = 0.bottom;
            }
            
            CinemachineFreeLook.Orbit val_12 = new CinemachineFreeLook.Orbit(h:  (float)-(val_23 + val_24), r:  (float)-(val_25 + X2.top));
            offset.sizeDelta = new UnityEngine.Vector2() {x = val_12.m_Height, y = val_12.m_Radius};
            if(offset != null)
            {
                    UnityEngine.Vector2 val_14 = offset.sizeDelta;
                val_26 = val_14.x;
            }
            else
            {
                    UnityEngine.Vector2 val_15 = 0.sizeDelta;
                val_26 = val_15.x;
            }
            
            UnityEngine.Vector2 val_16 = offset.pivot;
            if(offset != null)
            {
                    UnityEngine.Vector2 val_18 = offset.sizeDelta;
                val_27 = val_18.y;
            }
            else
            {
                    UnityEngine.Vector2 val_19 = 0.sizeDelta;
                val_27 = val_19.y;
            }
            
            UnityEngine.Vector2 val_20 = offset.pivot;
            float val_23 = (float)X2.left;
            val_20.y = 1f - val_20.y;
            val_23 = val_23 + (val_26 * val_16.x);
            val_20.y = val_27 * val_20.y;
            val_20.y = ((float)-X2.top) - val_20.y;
            CinemachineFreeLook.Orbit val_22 = new CinemachineFreeLook.Orbit(h:  val_23, r:  val_20.y);
            offset.anchoredPosition = new UnityEngine.Vector2() {x = val_22.m_Height, y = val_22.m_Radius};
        }
        [System.Runtime.CompilerServices.ExtensionAttribute]
        public static void Stretch(UnityEngine.RectTransform rectTransform)
        {
            UnityEngine.Vector2 val_1 = UnityEngine.Vector2.zero;
            X1.anchorMin = new UnityEngine.Vector2() {x = val_1.x, y = val_1.y};
            UnityEngine.Vector2 val_2 = UnityEngine.Vector2.one;
            X1.anchorMax = new UnityEngine.Vector2() {x = val_2.x, y = val_2.y};
            UnityEngine.Vector2 val_3 = UnityEngine.Vector2.zero;
            X1.sizeDelta = new UnityEngine.Vector2() {x = val_3.x, y = val_3.y};
            UnityEngine.Vector2 val_4 = UnityEngine.Vector2.zero;
            X1.anchoredPosition = new UnityEngine.Vector2() {x = val_4.x, y = val_4.y};
        }
        public static void SetActiveObjectsOfType<T>(bool state)
        {
            var val_2;
            bool val_3 = __RuntimeMethodHiddenParam;
            val_2 = 0;
            val_3 = val_3 & 1;
            goto label_3;
            label_10:
            SetActive(value:  val_3);
            val_2 = 1;
            label_3:
            if(val_2 >= 7254272)
            {
                    return;
            }
            
            var val_1 = 0 + 8;
            if(((0 + 8) + 32.gameObject) != null)
            {
                goto label_10;
            }
            
            goto label_10;
        }
    
    }

}
