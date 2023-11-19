using UnityEngine;

namespace TzarGames.Common
{
    public class PlatformQualityAdjuster : MonoBehaviour
    {
        // Fields
        [UnityEngine.SerializeField]
        private TzarGames.Common.PlatformAdjustments[] Adjustments;
        
        // Methods
        public PlatformQualityAdjuster()
        {
        
        }
        private TzarGames.Common.Platforms getPlatform()
        {
            return 4;
        }
        private void Start()
        {
            TzarGames.Common.PlatformAdjustments[] val_8;
            string val_1 = 0 + "Current platform is ";
            UnityEngine.Debug.Log(message:  0);
            val_8 = this.Adjustments;
            var val_9 = 0;
            do
            {
                if(val_9 >= this.Adjustments.Length)
            {
                    return;
            }
            
                TzarGames.Common.PlatformAdjustments val_8 = val_8[0];
                val_9 = val_9 + 1;
            }
            while(this.Adjustments[0x0][0].Platform != 4);
            
            string val_2 = 0 + "Adjusting quality settings for ";
            UnityEngine.Debug.Log(message:  0);
            if(this.Adjustments[0x0][0].EnableBloom.change != true)
            {
                    if(this.Adjustments[0x0][0].EnableSSAO.change != false)
            {
                    TzarGames.Common.Utils.EnableSSAO(enable:  false);
            }
            
                if(this.Adjustments[0x0][0].EnableVignette.change != true)
            {
                    if(this.Adjustments[0x0][0].EnableFilmicTonemapping.change != false)
            {
                    TzarGames.Common.Utils.EnableFilmicTonemapping(enable:  false);
            }
            
                val_8 = this.Adjustments[0x0][0].EnableAntiAliasing;
                if(this.Adjustments[0x0][0].EnableAntiAliasing.change != true)
            {
                    if((this.Adjustments[0x0][0].ChangeQualityLevel & 255) != false)
            {
                    bool val_4 = this.Adjustments[0x0][0].ChangeQualityLevel >> 32;
                TzarGames.Common.Utils.SetQualityLevel(level:  0);
            }
            
                if((this.Adjustments[0x0][0].ChangeTargetFramerate & 255) == false)
            {
                    return;
            }
            
                bool val_6 = this.Adjustments[0x0][0].ChangeTargetFramerate >> 32;
                UnityEngine.Application.targetFrameRate = 0;
                return;
            }
            
            }
            
            }
            
            System.NotImplementedException val_7 = new System.NotImplementedException();
        }
    
    }

}
