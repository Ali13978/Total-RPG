using UnityEngine;

namespace TzarGames.Endless
{
    public class BattleMusicMixer : MonoBehaviour
    {
        // Fields
        [UnityEngine.SerializeField]
        private UnityEngine.Audio.AudioMixerSnapshot defaultSnapshot;
        [UnityEngine.SerializeField]
        private UnityEngine.Audio.AudioMixerSnapshot battleSnapshot;
        [UnityEngine.SerializeField]
        private float transitionTime;
        [UnityEngine.SerializeField]
        private UnityEngine.AudioSource battleSource;
        [UnityEngine.SerializeField]
        private UnityEngine.AudioSource peaceSource;
        [UnityEngine.SerializeField]
        private UnityEngine.AudioClip[] battleClips;
        [UnityEngine.SerializeField]
        private UnityEngine.AudioClip[] peaceClips;
        [UnityEngine.SerializeField]
        private TzarGames.TzarHero.CharacterDetector detector;
        private float lastCheckTime;
        private bool inBattle;
        private TzarGames.Endless.BattleMusicMixer.Track battleTrack;
        private TzarGames.Endless.BattleMusicMixer.Track defaultTrack;
        
        // Methods
        public BattleMusicMixer()
        {
            this.transitionTime = 1f;
            this.battleTrack = new System.Object();
            this.defaultTrack = new System.Object();
        }
        private void Start()
        {
            this.startBattleAudio(start:  false);
            UnityEngine.Coroutine val_2 = this.StartCoroutine(routine:  this.playLoop(source:  this.battleSource, clips:  this.battleClips, index:  0, track:  this.battleTrack));
            UnityEngine.Coroutine val_4 = this.StartCoroutine(routine:  this.playLoop(source:  this.peaceSource, clips:  this.peaceClips, index:  0, track:  this.defaultTrack));
        }
        [System.Diagnostics.DebuggerHiddenAttribute]
        private System.Collections.IEnumerator stopSource(UnityEngine.AudioSource source, float time)
        {
            if(null != 0)
            {
                    typeof(BattleMusicMixer.<stopSource>c__Iterator0).__il2cppRuntimeField_10 = time;
            }
            else
            {
                    mem[16] = time;
            }
            
            typeof(BattleMusicMixer.<stopSource>c__Iterator0).__il2cppRuntimeField_18 = source;
            return (System.Collections.IEnumerator)new System.Object();
        }
        [System.Diagnostics.DebuggerHiddenAttribute]
        private System.Collections.IEnumerator playLoop(UnityEngine.AudioSource source, UnityEngine.AudioClip[] clips, int index, TzarGames.Endless.BattleMusicMixer.Track track)
        {
            if(null != 0)
            {
                    typeof(BattleMusicMixer.<playLoop>c__Iterator1).__il2cppRuntimeField_10 = index;
                typeof(BattleMusicMixer.<playLoop>c__Iterator1).__il2cppRuntimeField_18 = clips;
                typeof(BattleMusicMixer.<playLoop>c__Iterator1).__il2cppRuntimeField_20 = source;
                typeof(BattleMusicMixer.<playLoop>c__Iterator1).__il2cppRuntimeField_28 = track;
            }
            else
            {
                    mem[16] = index;
                mem[24] = clips;
                mem[32] = source;
                mem[40] = track;
            }
            
            typeof(BattleMusicMixer.<playLoop>c__Iterator1).__il2cppRuntimeField_30 = this;
            return (System.Collections.IEnumerator)new System.Object();
        }
        private void startBattleAudio(bool start)
        {
            float val_1;
            Track val_2;
            if(start == false)
            {
                goto label_0;
            }
            
            val_1 = this.transitionTime;
            this.battleSnapshot.TransitionTo(timeToReach:  val_1);
            this.battleTrack.Paused = false;
            val_2 = this.defaultTrack;
            if(val_2 != null)
            {
                goto label_7;
            }
            
            goto label_4;
            label_0:
            val_1 = this.transitionTime;
            this.defaultSnapshot.TransitionTo(timeToReach:  val_1);
            this.defaultTrack.Paused = false;
            val_2 = this.battleTrack;
            if(val_2 != null)
            {
                goto label_7;
            }
            
            label_4:
            label_7:
            this.battleTrack.Paused = true;
        }
        private void Update()
        {
            var val_15;
            if(0 != this.detector.MainCharacter)
            {
                    if(this.detector.MainCharacter.isDead == false)
            {
                goto label_7;
            }
            
            }
            
            if(this.battleSource.mute != true)
            {
                    this.battleSource.mute = true;
            }
            
            if(this.peaceSource.mute == true)
            {
                    return;
            }
            
            this.peaceSource.mute = true;
            return;
            label_7:
            if(this.battleSource.mute != false)
            {
                    this.battleSource.mute = false;
            }
            
            if(this.peaceSource.mute != false)
            {
                    this.peaceSource.mute = false;
            }
            
            float val_12 = UnityEngine.Time.time;
            val_12 = val_12 - this.lastCheckTime;
            if(val_12 < this.transitionTime)
            {
                    return;
            }
            
            this.lastCheckTime = UnityEngine.Time.time;
            if(this.detector.CharactersInRangeCount >= 1)
            {
                    if(this.inBattle == true)
            {
                    return;
            }
            
                val_15 = 1;
                this.inBattle = true;
            }
            else
            {
                    if(this.inBattle == false)
            {
                    return;
            }
            
                this.inBattle = false;
                val_15 = 0;
            }
            
            this.startBattleAudio(start:  false);
        }
    
    }

}
