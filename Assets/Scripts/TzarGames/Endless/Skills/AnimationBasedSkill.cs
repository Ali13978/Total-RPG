using UnityEngine;

namespace TzarGames.Endless.Skills
{
    public abstract class AnimationBasedSkill : EndlessCharacterSkill
    {
        // Fields
        [UnityEngine.SerializeField]
        private TzarGames.Common.StringID[] events;
        [UnityEngine.SerializeField]
        private string playerAnimationName;
        private TzarGames.TzarHero.CharacterAnimationBase currentCharacterAnimation;
        private bool isPlaying;
        
        // Methods
        protected AnimationBasedSkill()
        {
            val_1 = new TzarGames.TzarHero.Skills.CharacterSkill();
        }
        protected override void OnCharacterAssigned()
        {
            this.OnCharacterAssigned();
            if(0 == this.Character.Animation)
            {
                    return;
            }
            
            this.initCharacterAnim();
        }
        private void initCharacterAnim()
        {
            TzarGames.TzarHero.CharacterAnimationBase val_2 = this.Character.Animation;
            this.currentCharacterAnimation = val_2;
            val_2.add_OnAnimationEvent(value:  new System.Action<UnityEngine.AnimationEvent>(object:  this, method:  System.Void TzarGames.Endless.Skills.AnimationBasedSkill::onAnimEvent(UnityEngine.AnimationEvent animEvent)));
            this.currentCharacterAnimation.add_OnComponentDestroy(value:  new TzarGames.GameFramework.dlgTzarDestroy(object:  this, method:  System.Void TzarGames.Endless.Skills.AnimationBasedSkill::onAnimDestroy(TzarGames.GameFramework.TzarBehaviour behaviour)));
        }
        private void onAnimDestroy(TzarGames.GameFramework.TzarBehaviour behaviour)
        {
            TzarGames.TzarHero.CharacterAnimationBase val_4;
            if(behaviour == null)
            {
                    return;
            }
            
            behaviour.remove_OnAnimationEvent(value:  new System.Action<UnityEngine.AnimationEvent>(object:  this, method:  System.Void TzarGames.Endless.Skills.AnimationBasedSkill::onAnimEvent(UnityEngine.AnimationEvent animEvent)));
            behaviour.remove_OnComponentDestroy(value:  new TzarGames.GameFramework.dlgTzarDestroy(object:  this, method:  System.Void TzarGames.Endless.Skills.AnimationBasedSkill::onAnimDestroy(TzarGames.GameFramework.TzarBehaviour behaviour)));
            val_4 = this.currentCharacterAnimation;
            if(0 != val_4)
            {
                    return;
            }
            
            this.currentCharacterAnimation = 0;
        }
        protected abstract void action(TzarGames.Common.StringID animationEvent); // 0
        protected override void OnCharacterRemoved(TzarGames.TzarHero.TH_Character character)
        {
            this.OnCharacterRemoved(character:  character);
            if(0 == this.Character.Animation)
            {
                    return;
            }
            
            this.Character.Animation.remove_OnAnimationEvent(value:  new System.Action<UnityEngine.AnimationEvent>(object:  this, method:  System.Void TzarGames.Endless.Skills.AnimationBasedSkill::onAnimEvent(UnityEngine.AnimationEvent animEvent)));
        }
        protected override void OnStarted()
        {
            this.OnStarted();
            if(0 != this.Character.Animation)
            {
                    this.initCharacterAnim();
            }
            
            this.isPlaying = true;
            System.Action val_6 = new System.Action(object:  this, method:  System.Void TzarGames.Endless.Skills.AnimationBasedSkill::AnimationFinished());
            if(this.Character.Animation == null)
            {
                
            }
        
        }
        private void AnimationFinished()
        {
            this.isPlaying = false;
            this.Finish();
        }
        protected override void OnStopped()
        {
            var val_15;
            double val_16;
            double val_17;
            var val_18;
            val_15 = this;
            this.OnStopped();
            UnityEngine.Vector3 val_3 = UnityEngine.Vector3.zero;
            val_16 = val_3.x;
            val_17 = val_3.z;
            var val_15 = 0;
            val_15 = val_15 + 1;
            val_18 = this.Character.Movement;
            if(this.isPlaying == false)
            {
                    return;
            }
            
            this.isPlaying = false;
            TzarGames.TzarHero.CharacterAnimationBase val_6 = this.Character.Animation;
            val_15 = ???;
            val_16 = ???;
            val_17 = ???;
            goto typeof(TzarGames.TzarHero.CharacterAnimationBase).__il2cppRuntimeField_240;
        }
        private void onAnimEvent(UnityEngine.AnimationEvent animEvent)
        {
            TzarGames.Common.StringID[] val_15;
            var val_16;
            var val_17;
            var val_18;
            val_16 = this;
            if(this.IsPerforming == false)
            {
                    return;
            }
            
            UnityEngine.Object val_2 = animEvent.objectReferenceParameter;
            val_17 = 0;
            if(val_2 != null)
            {
                    UnityEngine.Object val_3 = (null == null) ? (val_2) : 0;
            }
            
            if(0 == val_3)
            {
                    return;
            }
            
            val_18 = 0;
            do
            {
                val_15 = this.events;
                if(val_18 >= this.events.Length)
            {
                    return;
            }
            
                TzarGames.Common.StringID val_15 = this.events[0];
                val_18 = val_18 + 1;
            }
            while(0 != val_3);
            
            val_16 = ???;
            val_15 = ???;
            val_18 = ???;
            goto typeof(TzarGames.Endless.Skills.AnimationBasedSkill).__il2cppRuntimeField_230;
        }
    
    }

}
