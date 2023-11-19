using UnityEngine;

namespace TzarGames.TzarHero
{
    public class AnimationHitInfo : CommonAsset
    {
        // Fields
        [UnityEngine.SerializeField]
        private UnityEngine.Vector3 relativeVelocity;
        [UnityEngine.SerializeField]
        private UnityEngine.Vector3 relativeAngularVelocity;
        
        // Properties
        public UnityEngine.Vector3 RelativeVelocity { get; }
        public UnityEngine.Vector3 RelativeAngularVelocity { get; }
        
        // Methods
        public AnimationHitInfo()
        {
        
        }
        public UnityEngine.Vector3 get_RelativeVelocity()
        {
            return new UnityEngine.Vector3() {x = this.relativeVelocity};
        }
        public UnityEngine.Vector3 get_RelativeAngularVelocity()
        {
            return new UnityEngine.Vector3() {x = this.relativeAngularVelocity};
        }
    
    }

}
