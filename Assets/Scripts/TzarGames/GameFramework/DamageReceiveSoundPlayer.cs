using UnityEngine;

namespace TzarGames.GameFramework
{
    public class DamageReceiveSoundPlayer : MonoBehaviour
    {
        // Fields
        [UnityEngine.SerializeField]
        private float minVolume;
        [UnityEngine.SerializeField]
        private float maxVolume;
        [UnityEngine.SerializeField]
        private float minPitch;
        [UnityEngine.SerializeField]
        private float maxPitch;
        [UnityEngine.SerializeField]
        private UnityEngine.AudioSource source;
        [UnityEngine.SerializeField]
        private UnityEngine.Audio.AudioMixerGroup mixerGroup;
        
        // Methods
        public DamageReceiveSoundPlayer()
        {
            this.minVolume = ;
            this.maxVolume = ;
            this.minPitch = 0.9f;
            this.maxPitch = 1.1f;
        }
        private void Reset()
        {
            this.source = this.GetComponent<UnityEngine.AudioSource>();
        }
        public void OnDamageHit(TzarGames.GameFramework.IDamageInfo hitInfo)
        {
            var val_19;
            var val_20;
            var val_21;
            var val_22;
            var val_23;
            var val_24;
            var val_25;
            var val_26;
            var val_27;
            var val_28;
            var val_29;
            var val_30;
            var val_31;
            var val_32;
            var val_33;
            if(hitInfo == null)
            {
                goto label_31;
            }
            
            var val_19 = 0;
            val_19 = val_19 + 1;
            val_20 = hitInfo;
            if(hitInfo == null)
            {
                goto label_31;
            }
            
            var val_20 = 0;
            val_20 = val_20 + 1;
            val_21 = hitInfo;
            val_19 = hitInfo;
            var val_21 = 0;
            val_21 = val_21 + 1;
            val_22 = val_19;
            if(val_19 == null)
            {
                goto label_31;
            }
            
            var val_22 = 0;
            val_22 = val_22 + 1;
            val_23 = hitInfo;
            if(hitInfo == null)
            {
                goto label_31;
            }
            
            var val_23 = 0;
            val_23 = val_23 + 1;
            val_24 = hitInfo;
            val_19 = hitInfo;
            var val_24 = 0;
            val_24 = val_24 + 1;
            val_25 = val_19;
            if(val_19 == null)
            {
                goto label_31;
            }
            
            float val_7 = UnityEngine.Random.Range(min:  this.minVolume, max:  this.maxVolume);
            float val_8 = UnityEngine.Random.Range(min:  this.minPitch, max:  this.maxPitch);
            var val_25 = 0;
            val_25 = val_25 + 1;
            val_26 = hitInfo;
            goto label_35;
            label_31:
            UnityEngine.Debug.LogError(message:  0);
            return;
            label_35:
            var val_26 = 0;
            val_26 = val_26 + 1;
            val_27 = hitInfo;
            var val_27 = 0;
            val_27 = val_27 + 1;
            val_28 = hitInfo;
            var val_28 = 0;
            val_28 = val_28 + 1;
            val_29 = hitInfo;
            var val_29 = 0;
            val_29 = val_29 + 1;
            val_30 = hitInfo;
            var val_30 = 0;
            val_30 = val_30 + 1;
            val_31 = hitInfo;
            UnityEngine.AudioClip val_15 = TzarGames.Common.SurfaceSoundProvider.GetCollisionClip(firstSurfaceName:  0, secondSurfaceName:  hitInfo);
            if(0 == this.source)
            {
                    var val_31 = 0;
                val_31 = val_31 + 1;
                val_32 = hitInfo;
            }
            else
            {
                    this.source.volume = val_7;
                this.source.pitch = val_8;
                this.source.PlayOneShot(clip:  val_15);
                return;
            }
            
            var val_32 = 0;
            val_32 = val_32 + 1;
            val_33 = hitInfo;
            PlayRandomSound.PlayAudioClip3D(clip:  0, position:  new UnityEngine.Vector3() {x = val_8, y = this.maxPitch, z = this.minPitch}, volume:  val_7, pitch:  val_8, group:  val_15);
        }
    
    }

}
