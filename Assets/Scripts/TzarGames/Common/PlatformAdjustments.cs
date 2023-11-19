using UnityEngine;

namespace TzarGames.Common
{
    [Serializable]
    internal class PlatformAdjustments
    {
        // Fields
        public TzarGames.Common.Platforms Platform;
        public TzarGames.Common.QualityAdjustment EnableBloom;
        public TzarGames.Common.QualityAdjustment EnableSSAO;
        public TzarGames.Common.QualityAdjustment EnableFilmicTonemapping;
        public TzarGames.Common.QualityAdjustment EnableVignette;
        public TzarGames.Common.QualityAdjustment EnableAntiAliasing;
        public bool ChangeQualityLevel;
        public int QualityLevel;
        public bool ChangeTargetFramerate;
        public int TargetFramerate;
        
        // Methods
        public PlatformAdjustments()
        {
            this.Platform = 1;
            this.TargetFramerate = 60;
        }
    
    }

}
