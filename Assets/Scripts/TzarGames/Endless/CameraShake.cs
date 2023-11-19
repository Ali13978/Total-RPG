using UnityEngine;

namespace TzarGames.Endless
{
    public class CameraShake : MonoBehaviour
    {
        // Fields
        [UnityEngine.SerializeField]
        private bool shakeOnStart;
        [UnityEngine.SerializeField]
        private float duration;
        [UnityEngine.SerializeField]
        private float speed;
        [UnityEngine.SerializeField]
        private float magnitude;
        [UnityEngine.SerializeField]
        private bool ignoreByDistance;
        [UnityEngine.SerializeField]
        private float maxDistanceToCamera;
        
        // Methods
        public CameraShake()
        {
            this.shakeOnStart = true;
            this.duration = 0.75f;
            this.speed = 5f;
            this.magnitude = 0.5f;
            this.maxDistanceToCamera = 25f;
        }
        private void Start()
        {
            if(this.shakeOnStart == false)
            {
                    return;
            }
            
            this.Shake();
        }
        public void Shake()
        {
            var val_10;
            TzarGames.Endless.PlayerCharacter val_1 = TzarGames.Endless.EndlessGameManager.LocalPlayerCharacter;
            val_10 = 1152921504721543168;
            if(0 == val_1)
            {
                    return;
            }
            
            TzarGames.Endless.ThirdPersonCamera val_3 = val_1.PlayerCamera;
            if(0 == val_3)
            {
                    return;
            }
            
            if(this.ignoreByDistance != false)
            {
                    UnityEngine.Vector3 val_6 = this.transform.position;
                val_10 = val_3.transform;
                UnityEngine.Vector3 val_8 = val_10.position;
                if((UnityEngine.Vector3.Distance(a:  new UnityEngine.Vector3() {x = val_6.x, y = val_6.y, z = val_6.z}, b:  new UnityEngine.Vector3() {x = val_8.x, y = val_8.y, z = val_8.z})) > this.maxDistanceToCamera)
            {
                    return;
            }
            
            }
            
            val_3.Shake(duration:  this.duration, speed:  this.speed, magnitude:  this.magnitude);
        }
    
    }

}
