using UnityEngine;

namespace ZarnFramework.Common
{
    [Serializable]
    public class FogSettings
    {
        // Fields
        public bool Enabled;
        public float FogDensity;
        public UnityEngine.Color FogColor;
        public UnityEngine.Color SunColor;
        public float SunAmount;
        public float HeightFalloff;
        public float Height;
        public float WindSpeed;
        public float WindWaveLenght;
        public float WindWaveHeight;
        
        // Methods
        public FogSettings()
        {
            this.Enabled = true;
            this.FogDensity = 0.005f;
            this.FogColor = 0;
            UnityEngine.Color val_1 = UnityEngine.Color.yellow;
            this.SunColor = val_1;
            mem[1152921511098488396] = val_1.g;
            mem[1152921511098488400] = val_1.b;
            mem[1152921511098488404] = val_1.a;
            this.SunAmount = ;
            this.HeightFalloff = ;
            this.Height = 1f;
            this.WindSpeed = 1f;
            this.WindWaveLenght = 1f;
            this.WindWaveHeight = 1f;
        }
        public void SetOptimizedDefaults()
        {
            this.Enabled = true;
            this.FogDensity = 0.005f;
            this.FogColor = 0;
            UnityEngine.Color val_1 = UnityEngine.Color.yellow;
            this.SunColor = val_1;
            mem[1152921511098600396] = val_1.g;
            mem[1152921511098600400] = val_1.b;
            mem[1152921511098600404] = val_1.a;
            this.WindWaveLenght = 1f;
            this.WindWaveHeight = 1f;
            this.SunAmount = ;
            this.HeightFalloff = ;
            this.Height = 1f;
            this.WindSpeed = 1f;
        }
    
    }

}
