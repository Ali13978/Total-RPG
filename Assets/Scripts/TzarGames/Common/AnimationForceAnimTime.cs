using UnityEngine;

namespace TzarGames.Common
{
    public class AnimationForceAnimTime : MonoBehaviour
    {
        // Methods
        public AnimationForceAnimTime()
        {
        
        }
        private void Update()
        {
            this.GetComponent<UnityEngine.Animation>().Item[this.GetComponent<UnityEngine.Animation>().clip.name].time = UnityEngine.Time.realtimeSinceStartup;
        }
    
    }

}
