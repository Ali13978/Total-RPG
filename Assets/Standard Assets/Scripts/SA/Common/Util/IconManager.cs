using UnityEngine;

namespace SA.Common.Util
{
    public static class IconManager
    {
        // Fields
        private static System.Collections.Generic.Dictionary<string, UnityEngine.Texture2D> s_icons;
        private static System.Collections.Generic.Dictionary<float, UnityEngine.Texture2D> s_colorIcons;
        
        // Methods
        public static UnityEngine.Texture2D GetIconFromHtmlColorString(string htmlString)
        {
            UnityEngine.Color val_1 = UnityEngine.Color.black;
            return SA.Common.Util.IconManager.GetIconFromHtmlColorString(htmlString:  null, fallback:  new UnityEngine.Color() {r = val_1.r, g = val_1.g, b = val_1.b, a = val_1.a});
        }
        public static UnityEngine.Texture2D GetIconFromHtmlColorString(string htmlString, UnityEngine.Color fallback)
        {
            bool val_1 = UnityEngine.ColorUtility.TryParseHtmlString(htmlString:  0, color: out  new UnityEngine.Color() {r = X1, g = X1, b = X1, a = X1});
            return (UnityEngine.Texture2D)SA.Common.Util.IconManager.GetIcon(color:  new UnityEngine.Color() {r = fallback.r, g = fallback.g, b = fallback.b, a = fallback.a}, width:  246484992, height:  1);
        }
        public static UnityEngine.Texture2D GetIcon(UnityEngine.Color color, int width = 1, int height = 1)
        {
            var val_7;
            var val_8;
            var val_9;
            var val_10;
            float val_8 = 100000f;
            float val_9 = 10000f;
            float val_7 = (float)height;
            val_7 = val_7 * 10f;
            float val_10 = 100f;
            val_8 = color.r * val_8;
            val_9 = color.g * val_9;
            val_8 = val_8 + val_9;
            val_8 = (color.b * 1000f) + val_8;
            val_10 = color.a * val_10;
            val_10 = val_10 + val_8;
            val_7 = val_7 + val_10;
            float val_2 = (float)W2 + val_7;
            goto label_0;
            label_21:
            X23.set_Item(key:  val_2, value:  X22);
            label_0:
            val_7 = null;
            val_7 = null;
            if((SA.Common.Util.IconManager.s_colorIcons.ContainsKey(key:  val_2)) == false)
            {
                goto label_5;
            }
            
            val_8 = null;
            val_8 = null;
            if(0 != SA.Common.Util.IconManager.s_colorIcons.Item[val_2])
            {
                goto label_11;
            }
            
            label_5:
            UnityEngine.Texture2D val_6 = new UnityEngine.Texture2D(width:  height, height:  W2);
            if(height >= 1)
            {
                    var val_12 = 0;
                do
            {
                if(W2 > 0)
            {
                    var val_11 = 0;
                do
            {
                SetPixel(x:  0, y:  0, color:  new UnityEngine.Color() {r = color.r, g = color.g, b = color.b, a = color.a});
                val_11 = val_11 + 1;
            }
            while(W2 != val_11);
            
            }
            
                val_12 = val_12 + 1;
            }
            while(val_12 != height);
            
            }
            
            Apply();
            val_9 = null;
            val_9 = null;
            if(SA.Common.Util.IconManager.s_colorIcons != null)
            {
                goto label_21;
            }
            
            goto label_21;
            label_11:
            val_10 = null;
            val_10 = null;
            if(SA.Common.Util.IconManager.s_colorIcons != null)
            {
                    return SA.Common.Util.IconManager.s_colorIcons.Item[val_2];
            }
            
            return SA.Common.Util.IconManager.s_colorIcons.Item[val_2];
        }
        public static UnityEngine.Texture2D GetIconAtPath(string path)
        {
            var val_6;
            var val_7;
            var val_8;
            var val_9;
            goto label_0;
            label_13:
            X22.Add(key:  X1, value:  X21);
            label_0:
            val_6 = null;
            val_6 = null;
            if((SA.Common.Util.IconManager.s_icons.ContainsKey(key:  X1)) == true)
            {
                goto label_5;
            }
            
            val_7 = 0;
            if(0 == ((null == null) ? UnityEngine.Resources.Load(path:  0) : 0))
            {
                    UnityEngine.Texture2D val_5 = new UnityEngine.Texture2D(width:  1, height:  1);
            }
            
            val_8 = null;
            val_8 = null;
            if(SA.Common.Util.IconManager.s_icons != null)
            {
                goto label_13;
            }
            
            goto label_13;
            label_5:
            val_9 = null;
            val_9 = null;
            if(SA.Common.Util.IconManager.s_icons != null)
            {
                    return SA.Common.Util.IconManager.s_icons.Item[X1];
            }
            
            return SA.Common.Util.IconManager.s_icons.Item[X1];
        }
        public static UnityEngine.Texture2D Rotate(UnityEngine.Texture2D tex, float angle)
        {
            float val_10;
            float val_11;
            float val_14;
            float val_15;
            float val_16;
            var val_17;
            int val_18;
            var val_19;
            float val_2 = ((float)-X1) * 0.5f;
            float val_3 = ((float)-X1) * 0.5f;
            float val_13 = (float)X1;
            val_13 = val_13 * 0.5f;
            val_14 = val_13 + (SA.Common.Util.IconManager.rot_x(angle:  angle, x:  val_2, y:  val_3));
            float val_14 = (float)X1;
            val_14 = val_14 * 0.5f;
            val_15 = val_14 + (SA.Common.Util.IconManager.rot_y(angle:  angle, x:  val_2, y:  val_3));
            val_16 = 1f;
            val_17 = 0;
            goto label_7;
            label_12:
            val_17 = 1;
            val_14 = (SA.Common.Util.IconManager.rot_x(angle:  angle, x:  0f, y:  1f)) + val_11;
            val_15 = (SA.Common.Util.IconManager.rot_y(angle:  angle, x:  0f, y:  val_16)) + val_10;
            label_7:
            val_18 = mem[X1 + 336 + 8];
            val_18 = X1 + 336 + 8;
            if(val_17 >= X1)
            {
                goto label_9;
            }
            
            val_19 = 0;
            val_10 = val_15;
            val_11 = val_14;
            float val_15 = val_15;
            goto label_10;
            label_18:
            val_18 = (int)val_3;
            val_16 = 1f;
            SetPixel(x:  val_18, y:  (int)val_15, color:  new UnityEngine.Color() {r = V14.16B, g = V15.16B, b = val_16, a = angle});
            val_19 = 1;
            label_10:
            if(val_19 >= X1)
            {
                goto label_12;
            }
            
            val_14 = (SA.Common.Util.IconManager.rot_x(angle:  angle, x:  1f, y:  0f)) + val_14;
            val_15 = (SA.Common.Util.IconManager.rot_y(angle:  angle, x:  1f, y:  0f)) + val_15;
            UnityEngine.Color val_12 = SA.Common.Util.IconManager.getPixel(tex:  null, x:  val_14, y:  val_15);
            if(null != 0)
            {
                goto label_18;
            }
            
            goto label_18;
            label_9:
            Apply();
            return (UnityEngine.Texture2D)new UnityEngine.Texture2D(width:  X1, height:  X1);
        }
        private static UnityEngine.Color getPixel(UnityEngine.Texture2D tex, float x, float y)
        {
            if((34807808 & 2147483648) != 0)
            {
                    return UnityEngine.Color.clear;
            }
            
            if(34807808 > X1)
            {
                    return UnityEngine.Color.clear;
            }
            
            if((W21 & 2147483648) != 0)
            {
                    return UnityEngine.Color.clear;
            }
            
            if(W21 > X1)
            {
                    return UnityEngine.Color.clear;
            }
            
            return X1.GetPixel(x:  34807808, y:  W21);
        }
        private static float rot_x(float angle, float x, float y)
        {
            float val_2 = angle;
            float val_1 = 180f;
            float val_3 = 3.141593f;
            val_1 = val_2 / val_1;
            val_2 = val_1 * val_3;
            float val_4 = val_2;
            val_3 = val_2 * x;
            val_4 = val_4 * y;
            val_4 = val_3 - val_4;
            return (float)val_4;
        }
        private static float rot_y(float angle, float x, float y)
        {
            float val_2 = angle;
            float val_1 = 180f;
            float val_4 = 3.141593f;
            val_1 = val_2 / val_1;
            val_2 = val_1 * val_4;
            float val_3 = val_2;
            val_3 = val_3 * x;
            val_4 = val_2 * y;
            val_3 = val_4 + val_3;
            return (float)val_3;
        }
        private static IconManager()
        {
            SA.Common.Util.IconManager.s_icons = new System.Collections.Generic.Dictionary<System.String, UnityEngine.Texture2D>();
            SA.Common.Util.IconManager.s_colorIcons = new System.Collections.Generic.Dictionary<System.Single, UnityEngine.Texture2D>();
        }
    
    }

}
