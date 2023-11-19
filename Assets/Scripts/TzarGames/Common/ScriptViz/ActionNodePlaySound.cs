using UnityEngine;

namespace TzarGames.Common.ScriptViz
{
    [TzarGames.Common.ScriptViz.LabelAttribute]
    public class ActionNodePlaySound : ActionNode
    {
        // Fields
        [UnityEngine.SerializeField]
        private UnityEngine.AudioSource audioSource;
        [UnityEngine.SerializeField]
        private bool useCustomClip;
        [UnityEngine.SerializeField]
        private UnityEngine.AudioClip customClip;
        [UnityEngine.SerializeField]
        private bool overrideVolume;
        [UnityEngine.SerializeField]
        private float volume;
        [UnityEngine.SerializeField]
        private bool overridePitch;
        [UnityEngine.SerializeField]
        private float pitch;
        [UnityEngine.SerializeField]
        private float fadeInTime;
        [UnityEngine.SerializeField]
        private float fadeOutTime;
        [UnityEngine.SerializeField]
        [UnityEngine.HideInInspector]
        private TzarGames.Common.ScriptViz.SvNodeSlot finishedSlot;
        [UnityEngine.SerializeField]
        [UnityEngine.HideInInspector]
        private TzarGames.Common.ScriptViz.SvNodeSlot stopSlot;
        [UnityEngine.SerializeField]
        [UnityEngine.HideInInspector]
        private TzarGames.Common.ScriptViz.SvNodeSlot pauseSlot;
        [UnityEngine.SerializeField]
        [UnityEngine.HideInInspector]
        private TzarGames.Common.ScriptViz.SvNodeSlot unpauseSlot;
        [UnityEngine.SerializeField]
        [UnityEngine.HideInInspector]
        private TzarGames.Common.ScriptViz.SvNodeSlot fadeInSlot;
        [UnityEngine.SerializeField]
        [UnityEngine.HideInInspector]
        private TzarGames.Common.ScriptViz.SvNodeSlot fadeOutSlot;
        [UnityEngine.SerializeField]
        [UnityEngine.HideInInspector]
        private TzarGames.Common.ScriptViz.SvNodeSlot audioSourceSlot;
        [UnityEngine.SerializeField]
        [UnityEngine.HideInInspector]
        private TzarGames.Common.ScriptViz.SvNodeSlot clipSlot;
        [UnityEngine.SerializeField]
        [UnityEngine.HideInInspector]
        private TzarGames.Common.ScriptViz.SvNodeSlot volumeSlot;
        [UnityEngine.SerializeField]
        [UnityEngine.HideInInspector]
        private TzarGames.Common.ScriptViz.SvNodeSlot pitchSlot;
        private bool pendingPlayFinish;
        private bool paused;
        
        // Methods
        public ActionNodePlaySound()
        {
            this.volume = 1f;
            this.pitch = 1f;
            this.fadeInTime = 2f;
            this.fadeOutTime = 2f;
        }
        protected override void Init()
        {
            this.Init();
            val_1.type = 2;
            this.finishedSlot = this.addSlotOnRight(slotName:  "Finished");
            val_2.type = 1;
            this.stopSlot = this.addSlotOnLeft(slotName:  "Stop");
            val_3.type = 1;
            this.pauseSlot = this.addSlotOnLeft(slotName:  "Pause");
            val_4.type = 1;
            this.unpauseSlot = this.addSlotOnLeft(slotName:  "Unpause");
            val_5.type = 1;
            this.fadeInSlot = this.addSlotOnLeft(slotName:  "Fade in");
            val_6.type = 1;
            this.fadeOutSlot = this.addSlotOnLeft(slotName:  "Fade out");
            val_7.type = 3;
            this.audioSourceSlot = this.addSlotOnLeft(slotName:  "Source");
            val_8.type = 3;
            this.clipSlot = this.addSlotOnLeft(slotName:  "Clip");
            val_9.type = 3;
            this.volumeSlot = this.addSlotOnLeft(slotName:  "Volume");
            val_10.type = 3;
            this.pitchSlot = this.addSlotOnLeft(slotName:  "Pitch");
        }
        public override void OnImpulse(TzarGames.Common.NodeSlot slot)
        {
            UnityEngine.AudioClip val_10;
            if(0 != slot)
            {
                goto label_3;
            }
            
            if(this.useCustomClip != false)
            {
                    val_10 = this.customClip;
                this.audioSource.clip = val_10;
            }
            
            this.updateSoundParams();
            this.audioSource.Play();
            this.pendingPlayFinish = true;
            this.paused = false;
            goto label_29;
            label_3:
            val_10 = this.stopSlot;
            if(0 != slot)
            {
                goto label_10;
            }
            
            this.audioSource.Stop();
            this.pendingPlayFinish = false;
            this.paused = false;
            goto label_29;
            label_10:
            val_10 = this.pauseSlot;
            if(0 != slot)
            {
                goto label_15;
            }
            
            this.audioSource.Pause();
            this.paused = true;
            goto label_29;
            label_15:
            val_10 = this.unpauseSlot;
            if(0 != slot)
            {
                goto label_20;
            }
            
            this.audioSource.UnPause();
            this.paused = false;
            goto label_29;
            label_20:
            val_10 = this.fadeInSlot;
            if(0 != slot)
            {
                goto label_25;
            }
            
            System.Collections.IEnumerator val_6 = this.fadeIn();
            goto label_26;
            label_25:
            val_10 = this.fadeOutSlot;
            if(0 != slot)
            {
                goto label_29;
            }
            
            label_26:
            UnityEngine.Coroutine val_9 = this.StartCoroutine(routine:  this.fadeOut());
            label_29:
            val_10.Impulse();
        }
        public override void OnVariableImpulse(object var, TzarGames.Common.ScriptViz.SvNodeSlot slot)
        {
            string val_11;
            var val_12;
            if(0 != slot)
            {
                goto label_3;
            }
            
            this.volume = System.Convert.ToSingle(value:  0);
            goto label_6;
            label_3:
            if(0 != slot)
            {
                goto label_9;
            }
            
            this.pitch = System.Convert.ToSingle(value:  0);
            if(0 == this.audioSource)
            {
                    return;
            }
            
            this.audioSource.pitch = this.pitch;
            label_6:
            this.updateSoundParams();
            return;
            label_9:
            if(0 != slot)
            {
                goto label_18;
            }
            
            if(var != null)
            {
                    if(null == null)
            {
                goto label_20;
            }
            
            }
            
            val_11 = "Object that come to Clip slot of ";
            val_12 = " is not AudioClip";
            goto label_23;
            label_18:
            if(0 != slot)
            {
                    return;
            }
            
            if(var == null)
            {
                goto label_27;
            }
            
            if(null == null)
            {
                goto label_28;
            }
            
            if(null == null)
            {
                goto label_29;
            }
            
            label_27:
            val_11 = "Object that come to Source slot of ";
            val_12 = " is not Audio source";
            label_23:
            string val_8 = 0 + val_11 + this;
            UnityEngine.Debug.LogError(message:  0);
            return;
            label_20:
            this.customClip = var;
            this.useCustomClip = true;
            return;
            label_28:
            this.audioSource = var;
            return;
            label_29:
            this.audioSource = var.GetComponent<UnityEngine.AudioSource>();
        }
        public override void Update()
        {
            if(this.pendingPlayFinish == false)
            {
                    return;
            }
            
            float val_3 = this.audioSource.clip.length;
            val_3 = val_3 + (-0.015f);
            if(this.audioSource.time < 0)
            {
                    return;
            }
            
            if(this.paused != false)
            {
                    return;
            }
            
            this.pendingPlayFinish = false;
            this.finishedSlot.Impulse();
        }
        [System.Diagnostics.DebuggerHiddenAttribute]
        private System.Collections.IEnumerator fadeIn()
        {
            typeof(ActionNodePlaySound.<fadeIn>c__Iterator0).__il2cppRuntimeField_18 = this;
            return (System.Collections.IEnumerator)new System.Object();
        }
        [System.Diagnostics.DebuggerHiddenAttribute]
        private System.Collections.IEnumerator fadeOut()
        {
            typeof(ActionNodePlaySound.<fadeOut>c__Iterator1).__il2cppRuntimeField_18 = this;
            return (System.Collections.IEnumerator)new System.Object();
        }
        private void updateSoundParams()
        {
            if(0 == this.audioSource)
            {
                    return;
            }
            
            if(this.overrideVolume != false)
            {
                    this.audioSource.volume = this.volume;
            }
            
            if(this.overridePitch == false)
            {
                    return;
            }
            
            this.audioSource.pitch = this.pitch;
        }
    
    }

}
