using UnityEngine;

namespace TzarGames.TzarHero
{
    public class WaterVolume : MonoBehaviour
    {
        // Fields
        [UnityEngine.SerializeField]
        private UnityEngine.AudioClip waterEnterClip;
        [UnityEngine.SerializeField]
        private UnityEngine.AudioClip waterExitClip;
        
        // Methods
        public WaterVolume()
        {
        
        }
        public void OnCharacterEntered(TzarGames.TzarHero.TH_Character character)
        {
            if(0 == this.waterEnterClip)
            {
                    return;
            }
            
            UnityEngine.Vector3 val_2 = character.GroundPivotPosition;
            UnityEngine.AudioSource.PlayClipAtPoint(clip:  0, position:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z});
        }
        public void OnCharacterExit(TzarGames.TzarHero.TH_Character character)
        {
            if(0 == this.waterExitClip)
            {
                    return;
            }
            
            UnityEngine.Vector3 val_2 = character.GroundPivotPosition;
            UnityEngine.AudioSource.PlayClipAtPoint(clip:  0, position:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z});
        }
    
    }

}
