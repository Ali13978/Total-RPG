using UnityEngine;

namespace Unitycoding.UIWidgets
{
    public static class EasingEquations
    {
        // Methods
        public static float GetValue(Unitycoding.UIWidgets.EasingEquations.EaseType easeType, float start, float end, float value)
        {
            var val_2 = (W1 < 32) ? (W1 + 3) : 0;
            val_2 = val_2 - 3;
            if(val_2 > 31)
            {
                    return Unitycoding.UIWidgets.EasingEquations.Linear(start:  start, end:  end, value:  value);
            }
            
            var val_73 = 25805520 + ((W1 < 0x20 ? (W1 + 3) : 0 - 3)) << 2;
            val_73 = val_73 + 25805520;
            goto (25805520 + ((W1 < 0x20 ? (W1 + 3) : 0 - 3)) << 2 + 25805520);
        }
        public static float Linear(float start, float end, float value)
        {
            return UnityEngine.Mathf.Lerp(a:  start, b:  end, t:  value);
        }
        public static float CLerp(float start, float end, float value)
        {
            float val_1 = end - start;
            if(val_1 < 0)
            {
                    float val_1 = 360f;
                val_1 = val_1 - start;
                val_1 = val_1 + end;
            }
            else
            {
                    if(val_1 > 180f)
            {
                    float val_2 = 360f;
                val_2 = val_2 - end;
                val_2 = val_2 + start;
                val_2 = val_2 * value;
                val_2 = start - val_2;
                return (float)val_1;
            }
            
            }
            
            val_1 = val_1 * value;
            val_1 = val_1 + start;
            return (float)val_1;
        }
        public static float Spring(float start, float end, float value)
        {
            float val_1 = UnityEngine.Mathf.Clamp01(value:  value);
            float val_4 = 2.5f;
            float val_5 = 3.141593f;
            val_4 = val_1 * val_4;
            val_4 = val_1 * val_4;
            val_4 = val_1 * val_4;
            val_5 = val_1 * val_5;
            val_4 = val_4 + 0.2f;
            val_4 = val_5 * val_4;
            float val_2 = 1f - val_1;
            float val_6 = val_2;
            float val_7 = 1.2f;
            val_6 = val_4 * val_6;
            val_6 = val_1 + val_6;
            val_7 = val_2 * val_7;
            val_7 = val_7 + 1f;
            val_6 = val_7 * val_6;
            val_6 = (end - start) * val_6;
            val_6 = val_6 + start;
            return (float)val_6;
        }
        public static float EaseInQuad(float start, float end, float value)
        {
            end = end - start;
            end = end * value;
            end = end * value;
            start = end + start;
            return (float)start;
        }
        public static float EaseOutQuad(float start, float end, float value)
        {
            end = end - start;
            end = end * value;
            value = value + (-2f);
            end = end * value;
            start = start - end;
            return (float)start;
        }
        public static float EaseInOutQuad(float start, float end, float value)
        {
            float val_1;
            value = value + value;
            end = end - start;
            if(value < 0)
            {
                    end = end * 0.5f;
                end = end * value;
                val_1 = value * end;
            }
            else
            {
                    value = value + (-1f);
                end = end * (-0.5f);
                float val_1 = -2f;
                val_1 = value + val_1;
                value = value * val_1;
                value = value + (-1f);
                val_1 = end * value;
            }
            
            start = val_1 + start;
            return (float)start;
        }
        public static float EaseInCubic(float start, float end, float value)
        {
            end = end - start;
            end = end * value;
            end = end * value;
            end = end * value;
            start = end + start;
            return (float)start;
        }
        public static float EaseOutCubic(float start, float end, float value)
        {
            float val_1 = -1f;
            value = value + val_1;
            val_1 = value * value;
            value = value * val_1;
            end = end - start;
            value = value + 1f;
            end = end * value;
            start = end + start;
            return (float)start;
        }
        public static float EaseInOutCubic(float start, float end, float value)
        {
            float val_1;
            value = value + value;
            end = end - start;
            if(value < 0)
            {
                    end = end * 0.5f;
                end = end * value;
                end = value * end;
                val_1 = value * end;
            }
            else
            {
                    float val_1 = -2f;
                value = value + val_1;
                val_1 = value * value;
                value = value * val_1;
                end = end * 0.5f;
                value = value + 2f;
                val_1 = end * value;
            }
            
            start = val_1 + start;
            return (float)start;
        }
        public static float EaseInQuart(float start, float end, float value)
        {
            end = end - start;
            end = end * value;
            end = end * value;
            end = end * value;
            end = end * value;
            start = end + start;
            return (float)start;
        }
        public static float EaseOutQuart(float start, float end, float value)
        {
            value = value + (-1f);
            float val_1 = value * value;
            val_1 = value * val_1;
            value = value * val_1;
            end = end - start;
            value = value + (-1f);
            end = end * value;
            start = start - end;
            return (float)start;
        }
        public static float EaseInOutQuart(float start, float end, float value)
        {
            float val_2;
            value = value + value;
            end = end - start;
            if(value < 0)
            {
                    end = end * 0.5f;
                end = end * value;
                end = value * end;
                end = value * end;
                val_2 = value * end;
            }
            else
            {
                    value = value + (-2f);
                end = end * (-0.5f);
                float val_1 = value * value;
                val_1 = value * val_1;
                value = value * val_1;
                value = value + (-2f);
                val_2 = end * value;
            }
            
            start = val_2 + start;
            return (float)start;
        }
        public static float EaseInQuint(float start, float end, float value)
        {
            end = end - start;
            end = end * value;
            end = end * value;
            end = end * value;
            end = end * value;
            end = end * value;
            start = end + start;
            return (float)start;
        }
        public static float EaseOutQuint(float start, float end, float value)
        {
            float val_1 = -1f;
            value = value + val_1;
            val_1 = value * value;
            val_1 = value * val_1;
            val_1 = value * val_1;
            value = value * val_1;
            end = end - start;
            value = value + 1f;
            end = end * value;
            start = end + start;
            return (float)start;
        }
        public static float EaseInOutQuint(float start, float end, float value)
        {
            float val_1;
            value = value + value;
            end = end - start;
            if(value < 0)
            {
                    end = end * 0.5f;
                end = end * value;
                end = value * end;
                end = value * end;
                end = value * end;
                val_1 = value * end;
            }
            else
            {
                    float val_1 = -2f;
                value = value + val_1;
                val_1 = value * value;
                val_1 = value * val_1;
                val_1 = value * val_1;
                value = value * val_1;
                end = end * 0.5f;
                value = value + 2f;
                val_1 = end * value;
            }
            
            start = val_1 + start;
            return (float)start;
        }
        public static float EaseInSine(float start, float end, float value)
        {
            float val_1 = end;
            val_1 = val_1 - start;
            float val_2 = 1.570796f;
            val_2 = value * val_2;
            val_2 = val_1 * val_2;
            val_2 = val_1 - val_2;
            val_2 = val_2 + start;
            return (float)val_2;
        }
        public static float EaseOutSine(float start, float end, float value)
        {
            float val_1 = end;
            val_1 = val_1 - start;
            float val_2 = 1.570796f;
            val_2 = value * val_2;
            val_2 = val_1 * val_2;
            val_2 = val_2 + start;
            return (float)val_2;
        }
        public static float EaseInOutSine(float start, float end, float value)
        {
            float val_1 = end;
            val_1 = val_1 - start;
            float val_2 = 3.141593f;
            val_2 = value * val_2;
            float val_3 = -0.5f;
            val_3 = val_1 * val_3;
            val_2 = val_2 + (-1f);
            val_2 = val_3 * val_2;
            val_2 = val_2 + start;
            return (float)val_2;
        }
        public static float EaseInExpo(float start, float end, float value)
        {
            float val_1 = end;
            val_1 = val_1 - start;
            float val_2 = -1f;
            val_2 = value + val_2;
            val_2 = val_2 * 10f;
            val_2 = val_1 * val_2;
            val_2 = val_2 + start;
            return (float)val_2;
        }
        public static float EaseOutExpo(float start, float end, float value)
        {
            float val_1 = end;
            val_1 = val_1 - start;
            float val_2 = -10f;
            val_2 = value * val_2;
            val_2 = 1f - val_2;
            val_2 = val_1 * val_2;
            val_2 = val_2 + start;
            return (float)val_2;
        }
        public static float EaseInOutExpo(float start, float end, float value)
        {
            float val_1;
            float val_2;
            float val_3;
            float val_1 = end;
            val_1 = value + value;
            val_1 = val_1 - start;
            if(val_1 < 0)
            {
                    float val_2 = -1f;
                val_2 = val_1 + val_2;
                val_2 = val_2 * 10f;
                val_3 = val_1 * 0.5f;
            }
            else
            {
                    val_1 = val_1 + (-1f);
                float val_3 = -10f;
                val_3 = val_1 * val_3;
                val_3 = val_1 * 0.5f;
                val_2 = 2f - val_3;
            }
            
            val_2 = val_3 * val_2;
            val_2 = val_2 + start;
            return (float)val_2;
        }
        public static float EaseInCirc(float start, float end, float value)
        {
            float val_2;
            float val_3 = end;
            float val_1 = value * value;
            float val_2 = 1f;
            val_2 = val_2 - val_1;
            val_3 = val_3 - start;
            if(val_1 >= _TYPE_MAX_)
            {
                    val_2 = val_2;
            }
            
            val_2 = val_2 + (-1f);
            val_2 = val_3 * val_2;
            val_2 = start - val_2;
            return (float)val_2;
        }
        public static float EaseOutCirc(float start, float end, float value)
        {
            float val_1;
            float val_1 = value;
            float val_4 = end;
            float val_2 = -1f;
            val_1 = val_1 + val_2;
            val_2 = val_1 * val_1;
            float val_3 = 1f;
            val_3 = val_3 - val_2;
            val_4 = val_4 - start;
            if(val_2 >= _TYPE_MAX_)
            {
                    val_1 = val_3;
            }
            
            val_1 = val_4 * val_1;
            val_1 = val_1 + start;
            return (float)val_1;
        }
        public static float EaseInOutCirc(float start, float end, float value)
        {
            float val_5;
            float val_6;
            float val_7;
            float val_8;
            float val_5 = end;
            float val_1 = value + value;
            val_5 = val_5 - start;
            if(val_1 < 0)
            {
                    float val_2 = val_1 * val_1;
                if(val_2 >= _TYPE_MAX_)
            {
                    val_5 = 1f - val_2;
            }
            
                val_6 = val_5 * (-0.5f);
                val_7 = val_5 + (-1f);
            }
            else
            {
                    float val_6 = -2f;
                val_1 = val_1 + val_6;
                val_6 = val_1 * val_1;
                if(val_6 >= _TYPE_MAX_)
            {
                    val_8 = 1f - val_6;
            }
            
                val_6 = val_5 * 0.5f;
                val_7 = val_8 + 1f;
            }
            
            val_7 = val_6 * val_7;
            val_7 = val_7 + start;
            return (float)val_7;
        }
        public static float EaseInBounce(float start, float end, float value)
        {
            float val_1 = end - start;
            value = 1f - value;
            float val_2 = Unitycoding.UIWidgets.EasingEquations.EaseOutBounce(start:  0f, end:  val_1, value:  value);
            val_2 = val_1 - val_2;
            val_2 = val_2 + start;
            return (float)val_2;
        }
        public static float EaseOutBounce(float start, float end, float value)
        {
            float val_1;
            end = end - start;
            if(value < 0)
            {
                    float val_1 = 7.5625f;
                val_1 = value * val_1;
                val_1 = val_1 * value;
            }
            else
            {
                    if(value < 0)
            {
                    float val_2 = -0.5454546f;
                value = value + val_2;
                val_2 = value * 7.5625f;
                value = value * val_2;
                val_1 = value + 0.75f;
            }
            else
            {
                    if((double)value < 0)
            {
                    float val_3 = -0.8181818f;
                value = value + val_3;
                val_3 = value * 7.5625f;
                value = value * val_3;
                val_1 = value + 0.9375f;
            }
            else
            {
                    float val_4 = -0.9545454f;
                value = value + val_4;
                val_4 = value * 7.5625f;
                value = value * val_4;
                val_1 = value + 0.984375f;
            }
            
            }
            
            }
            
            end = end * val_1;
            start = end + start;
            return (float)start;
        }
        public static float EaseInOutBounce(float start, float end, float value)
        {
            float val_7;
            float val_1 = end - start;
            float val_2 = value + value;
            if(value < 0)
            {
                    value = 1f - val_2;
                float val_3 = Unitycoding.UIWidgets.EasingEquations.EaseOutBounce(start:  0f, end:  val_1, value:  value);
                val_3 = val_1 - val_3;
                val_3 = val_3 + 0f;
                val_7 = val_3 * 0.5f;
            }
            else
            {
                    value = val_2 + (-1f);
                float val_4 = Unitycoding.UIWidgets.EasingEquations.EaseOutBounce(start:  0f, end:  val_1, value:  value);
                val_4 = val_4 * 0.5f;
                val_7 = (val_1 * 0.5f) + val_4;
            }
            
            val_7 = val_7 + start;
            return (float)val_7;
        }
        public static float EaseInBack(float start, float end, float value)
        {
            end = end - start;
            end = end * value;
            end = end * value;
            value = value * 2.70158f;
            value = value + (-1.70158f);
            end = end * value;
            start = end + start;
            return (float)start;
        }
        public static float EaseOutBack(float start, float end, float value)
        {
            float val_1 = 2.70158f;
            value = value + (-1f);
            float val_2 = 1.70158f;
            val_1 = value * val_1;
            value = value * value;
            end = end - start;
            val_2 = val_1 + val_2;
            value = value * val_2;
            value = value + 1f;
            end = end * value;
            start = end + start;
            return (float)start;
        }
        public static float EaseInOutBack(float start, float end, float value)
        {
            float val_3;
            float val_4;
            end = end - start;
            value = value + value;
            if(value < 0)
            {
                    val_3 = end * 0.5f;
                value = value * 3.594909f;
                value = value + (-2.594909f);
                val_4 = (value * value) * value;
            }
            else
            {
                    value = value + (-2f);
                float val_3 = 2.594909f;
                val_3 = end * 0.5f;
                value = value * value;
                val_3 = (value * 3.594909f) + val_3;
                value = value * val_3;
                val_4 = value + 2f;
            }
            
            val_3 = val_3 * val_4;
            start = val_3 + start;
            return (float)start;
        }
        public static float Punch(float amplitude, float value)
        {
            if(value == 0f)
            {
                    return (float)val_1;
            }
            
            if(value == 1f)
            {
                    return (float)val_1;
            }
            
            float val_3 = -10f;
            val_3 = value * val_3;
            float val_1 = value * 6.283185f;
            val_1 = val_1 / 0.3f;
            val_1 = (val_3 * amplitude) * val_1;
            return (float)val_1;
        }
        public static float EaseInElastic(float start, float end, float value)
        {
            float val_4;
            float val_5;
            val_4 = end;
            val_5 = start;
            if(value == 0f)
            {
                    return (float)val_5;
            }
            
            val_4 = val_4 - val_5;
            if(value == 1f)
            {
                    val_5 = val_4 + val_5;
                return (float)val_5;
            }
            
            float val_1 = value + (-1f);
            float val_4 = 10f;
            val_4 = val_1 * val_4;
            float val_2 = val_1 + (-0.075f);
            val_2 = val_2 * 6.283185f;
            val_2 = val_2 / 0.3f;
            val_2 = (val_4 * val_4) * val_2;
            val_5 = val_5 - val_2;
            return (float)val_5;
        }
        public static float EaseOutElastic(float start, float end, float value)
        {
            float val_4;
            float val_5;
            val_4 = end;
            val_5 = start;
            if(value == 0f)
            {
                    return (float)val_5;
            }
            
            float val_1 = val_4 - val_5;
            if(value == 1f)
            {
                    val_5 = val_1 + val_5;
                return (float)val_5;
            }
            
            float val_4 = -10f;
            val_4 = value * val_4;
            val_4 = val_4;
            float val_2 = value + (-0.075f);
            val_2 = val_2 * 6.283185f;
            val_2 = val_2 / 0.3f;
            val_2 = (val_1 * val_4) * val_2;
            val_2 = val_1 + val_2;
            val_5 = val_2 + val_5;
            return (float)val_5;
        }
        public static float EaseInOutElastic(float start, float end, float value)
        {
            float val_9;
            float val_10;
            val_9 = end;
            val_10 = start;
            if(value == 0f)
            {
                    return (float)val_10;
            }
            
            val_9 = val_9 - val_10;
            float val_1 = value + value;
            if(val_1 == 2f)
            {
                    val_10 = val_9 + val_10;
                return (float)val_10;
            }
            
            float val_2 = val_1 + (-1f);
            if(val_1 < 0)
            {
                    float val_9 = 10f;
                val_9 = val_2 * val_9;
                float val_5 = val_2 + (-0.075f);
                val_5 = val_5 * 6.283185f;
                val_5 = val_5 / 0.3f;
                val_5 = (val_9 * val_9) * val_5;
                val_5 = val_5 * (-0.5f);
                val_10 = val_10 + val_5;
                return (float)val_10;
            }
            
            float val_10 = -10f;
            val_10 = val_2 * val_10;
            float val_7 = val_2 + (-0.075f);
            val_7 = val_7 * 6.283185f;
            val_7 = val_7 / 0.3f;
            val_7 = (val_9 * val_10) * val_7;
            val_7 = val_7 * 0.5f;
            val_7 = val_9 + val_7;
            val_10 = val_7 + val_10;
            return (float)val_10;
        }
    
    }

}
