using UnityEngine;

namespace TzarGames.Common.ScriptViz
{
    [TzarGames.Common.ScriptViz.LabelAttribute]
    public class ActionNodePlayAnimation : ActionNode
    {
        // Fields
        [UnityEngine.SerializeField]
        public UnityEngine.Animation animation;
        [UnityEngine.SerializeField]
        public string AnimationName;
        [UnityEngine.SerializeField]
        [UnityEngine.HideInInspector]
        private TzarGames.Common.ScriptViz.SvNodeSlot outFinishSlot;
        private bool playing;
        
        // Methods
        public ActionNodePlayAnimation()
        {
        
        }
        protected override void Init()
        {
            this.Init();
            val_1.type = 2;
            this.outFinishSlot = this.addSlotOnRight(slotName:  "On Finish");
        }
        public override void OnImpulse(TzarGames.Common.NodeSlot slot)
        {
            if(this.playing != true)
            {
                    if(0 != this.animation)
            {
                    bool val_2 = this.animation.Play(animation:  this.AnimationName);
                this.playing = true;
            }
            
            }
            
            this.Impulse();
        }
        public override void Update()
        {
            if(this.playing == false)
            {
                    return;
            }
            
            if(0 == this.animation)
            {
                    return;
            }
            
            if((this.animation.IsPlaying(name:  this.AnimationName)) != false)
            {
                    return;
            }
            
            this.playing = false;
            this.outFinishSlot.Impulse();
        }
    
    }

}
