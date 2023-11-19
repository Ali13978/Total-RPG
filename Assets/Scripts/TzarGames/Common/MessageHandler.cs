using UnityEngine;

namespace TzarGames.Common
{
    public class MessageHandler : MonoBehaviour
    {
        // Fields
        [UnityEngine.SerializeField]
        private UnityEngine.AudioSource audioSource;
        [UnityEngine.SerializeField]
        private TzarGames.Common.SoundGroup[] groups;
        [UnityEngine.SerializeField]
        private float volume;
        
        // Methods
        public MessageHandler()
        {
            this.volume = 1f;
        }
        private void PlaySoundClip(TzarGames.Common.SoundGroup group, int clipNumber)
        {
            if(group.clips.Length <= clipNumber)
            {
                    return;
            }
            
            if(0 != this.audioSource)
            {
                    this.audioSource.PlayOneShot(clip:  group.clips[(long)clipNumber], volumeScale:  this.volume);
                return;
            }
            
            UnityEngine.AudioClip val_5 = group.clips[(long)clipNumber];
            UnityEngine.Vector3 val_3 = this.transform.position;
            UnityEngine.AudioSource.PlayClipAtPoint(clip:  0, position:  new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z}, volume:  this.volume);
        }
        public void PlaySound()
        {
            if(0 == this.audioSource)
            {
                    return;
            }
            
            this.audioSource.Play();
        }
        public void StopSound()
        {
            if(0 == this.audioSource)
            {
                    return;
            }
            
            this.audioSource.Stop();
        }
        public void PlayRandomSoundClip(string groupName)
        {
            TzarGames.Common.SoundGroup val_3;
            goto label_1;
            label_14:
            0 = 1;
            label_1:
            if(0 >= this.groups.Length)
            {
                    return;
            }
            
            val_3 = this.groups[1];
            if((System.String.op_Equality(a:  0, b:  this.groups[0x1][0].name)) == false)
            {
                goto label_14;
            }
            
            if(this.groups[0x1][0].clips.Length == 0)
            {
                    return;
            }
            
            this.PlaySoundClip(group:  val_3, clipNumber:  UnityEngine.Random.Range(min:  0, max:  0));
            goto label_14;
        }
        [UnityEngine.ContextMenu]
        private void openDocumentation()
        {
            UnityEngine.Application.OpenURL(url:  0);
        }
    
    }

}
