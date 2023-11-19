using UnityEngine;

namespace TzarGames.Endless
{
    public static class EndlessUtils
    {
        // Methods
        public static int FloatToPercent(float val)
        {
            val = val + (-1f);
            val = val * 100f;
            return TzarGames.Endless.EndlessUtils.GetIntPercent(floatPercent:  val);
        }
        public static int GetIntPercent(float floatPercent)
        {
            if((System.Math.Abs((float)(int)floatPercent - floatPercent)) <= 0.1f)
            {
                    return (int)(int)floatPercent;
            }
            
            if((float)(int)floatPercent <= floatPercent)
            {
                    return UnityEngine.Mathf.CeilToInt(f:  floatPercent);
            }
            
            return UnityEngine.Mathf.FloorToInt(f:  floatPercent);
        }
    
    }

}
