using UnityEngine;

namespace TzarGames.Common
{
    public class LightmapSwitcher : MonoBehaviour
    {
        // Fields
        public UnityEngine.LightmapsMode MobileLightmapMode;
        
        // Methods
        public LightmapSwitcher()
        {
        
        }
        private void Start()
        {
            UnityEngine.LightmapSettings.lightmapsMode = 0;
        }
    
    }

}
