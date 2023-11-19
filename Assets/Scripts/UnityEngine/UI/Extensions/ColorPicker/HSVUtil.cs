using UnityEngine;

namespace UnityEngine.UI.Extensions.ColorPicker
{
    public static class HSVUtil
    {
        // Methods
        public static UnityEngine.UI.Extensions.ColorPicker.HsvColor ConvertRgbToHsv(UnityEngine.Color color)
        {
            color.r = color.r * 255f;
            color.g = color.g * 255f;
            color.b = color.b * 255f;
            return UnityEngine.UI.Extensions.ColorPicker.HSVUtil.ConvertRgbToHsv(r:  (double)(int)color.r, b:  (double)(int)color.g, g:  (double)(int)color.b);
        }
        public static UnityEngine.UI.Extensions.ColorPicker.HsvColor ConvertRgbToHsv(double r, double b, double g)
        {
            float val_11;
            float val_12;
            float val_13;
            double val_14;
            UnityEngine.UI.Extensions.ColorPicker.HsvColor val_0;
            double val_10 = b;
            double val_4 = System.Math.Max(val1:  System.Math.Max(val1:  r, val2:  g), val2:  val_10);
            double val_5 = val_4 - (System.Math.Min(val1:  System.Math.Min(val1:  r, val2:  g), val2:  b));
            val_10 = val_5 / val_4;
            val_11 = 0;
            val_12 = 360;
            if(((val_4 == 0f) ? (val_11) : (val_10)) == 0f)
            {
                goto label_6;
            }
            
            if(val_4 != r)
            {
                goto label_1;
            }
            
            val_11 = (g - b) / val_5;
            goto label_5;
            label_1:
            if(val_4 != g)
            {
                goto label_3;
            }
            
            val_13 = (b - r) / val_5;
            val_14 = 2;
            goto label_4;
            label_3:
            if(val_4 != b)
            {
                goto label_5;
            }
            
            val_13 = (r - g) / val_5;
            val_14 = 4;
            label_4:
            val_11 = val_13 + val_14;
            label_5:
            val_12 = val_11 * 60;
            if(val_12 <= 0f)
            {
                    double val_11 = 360;
                val_12 = val_12 + val_11;
            }
            
            label_6:
            val_11 = 360 - val_12;
            double val_12 = 255;
            val_12 = val_4 / val_12;
            return val_0;
        }
        public static UnityEngine.Color ConvertHsvToRgb(double h, double s, double v, float alpha)
        {
            if(s == 0f)
            {
                    return new UnityEngine.Color() {r = 0f, g = 0f, b = 0f, a = 0f};
            }
            
            double val_8 = 60;
            double val_10 = 360;
            val_8 = h / val_8;
            float val_1 = (h == val_10) ? 0 : (val_8);
            if((((int)val_1 < 5) ? ((int)val_1 + 7) : 0) > 11)
            {
                    return new UnityEngine.Color() {r = 0f, g = 0f, b = 0f, a = 0f};
            }
            
            double val_9 = (double)(int)val_1;
            var val_11 = 25810960;
            val_9 = val_1 - val_9;
            val_10 = 1 - val_9;
            val_10 = val_10 * s;
            val_9 = val_9 * s;
            s = 1 - val_10;
            double val_5 = (1 - s) * v;
            val_9 = 1 - val_9;
            double val_6 = s * v;
            val_11 = (25810960 + ((int)val_1 < 0x5 ? (h == 360 ? 0 : (h / 60) + 7) : 0) << 2) + val_11;
            double val_7 = val_9 * v;
            goto (25810960 + ((int)val_1 < 0x5 ? (h == 360 ? 0 : (h / 60) + 7) : 0) << 2 + 25810960);
        }
    
    }

}
