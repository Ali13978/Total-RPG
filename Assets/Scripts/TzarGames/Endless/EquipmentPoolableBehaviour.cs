using UnityEngine;

namespace TzarGames.Endless
{
    public class EquipmentPoolableBehaviour : MonoBehaviour, IPoolable
    {
        // Fields
        [UnityEngine.SerializeField]
        private UnityEngine.Renderer[] renderers;
        [UnityEngine.SerializeField]
        private UnityEngine.Cloth[] cloths;
        [UnityEngine.SerializeField]
        private UnityEngine.AudioSource[] audioSources;
        [UnityEngine.SerializeField]
        private UnityEngine.ParticleSystem[] particles;
        
        // Methods
        public EquipmentPoolableBehaviour()
        {
        
        }
        private void Reset()
        {
            this.renderers = this.GetComponentsInChildren<UnityEngine.Renderer>();
            this.cloths = this.GetComponentsInChildren<UnityEngine.Cloth>();
            this.audioSources = this.GetComponentsInChildren<UnityEngine.AudioSource>();
            this.particles = this.GetComponentsInChildren<UnityEngine.ParticleSystem>();
        }
        public void OnPulledFromPool()
        {
            this.setComponentState(enabled:  true);
        }
        public void OnPushedToPool()
        {
            this.setComponentState(enabled:  false);
        }
        private void setComponentState(bool enabled)
        {
            var val_5;
            var val_6;
            var val_7;
            var val_8;
            val_5 = 0;
            goto label_0;
            label_6:
            enabled = enabled;
            X21.enabled = enabled;
            val_5 = 1;
            label_0:
            if(val_5 >= this.renderers.Length)
            {
                goto label_2;
            }
            
            if(this.renderers[1] != null)
            {
                goto label_6;
            }
            
            goto label_6;
            label_2:
            val_6 = 0;
            goto label_7;
            label_13:
            this.renderers.enabled = enabled;
            val_6 = 1;
            label_7:
            if(val_6 >= this.cloths.Length)
            {
                goto label_9;
            }
            
            if(this.cloths[1] != null)
            {
                goto label_13;
            }
            
            goto label_13;
            label_9:
            val_7 = 0;
            goto label_14;
            label_20:
            this.cloths.enabled = enabled;
            val_7 = 1;
            label_14:
            if(val_7 >= this.audioSources.Length)
            {
                goto label_16;
            }
            
            if(this.audioSources[1] != null)
            {
                goto label_20;
            }
            
            goto label_20;
            label_16:
            val_8 = 0;
            goto label_21;
            label_28:
            this.audioSources.SetActive(value:  enabled);
            val_8 = 1;
            label_21:
            if(val_8 >= this.particles.Length)
            {
                    return;
            }
            
            if(this.particles[1].gameObject != null)
            {
                goto label_28;
            }
            
            goto label_28;
        }
    
    }

}
