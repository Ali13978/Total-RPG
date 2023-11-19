using UnityEngine;

namespace TzarGames.Endless.UI
{
    public class ActivableSkillUI : GameUIBase
    {
        // Fields
        [UnityEngine.SerializeField]
        private TzarGames.Endless.Skills.EndlessCharacterSkill skill;
        [UnityEngine.SerializeField]
        private UnityEngine.GameObject[] activableObjects;
        private TzarGames.Endless.PlayerCharacter playerCharacter;
        private TzarGames.TzarHero.Skills.CharacterSkill skillInstance;
        
        // Methods
        public ActivableSkillUI()
        {
        
        }
        private void Start()
        {
            this.check();
        }
        private void Update()
        {
            this.check();
        }
        private void check()
        {
            var val_8;
            var val_9;
            var val_10;
            if(0 != this.skillInstance)
            {
                goto label_11;
            }
            
            if(0 == this.playerCharacter)
            {
                goto label_6;
            }
            
            TzarGames.TzarHero.Skills.CharacterSkill val_4 = this.playerCharacter.TemplateInstance.GetSkillInstance(skill:  this.skill);
            this.skillInstance = val_4;
            if(0 != val_4)
            {
                goto label_11;
            }
            
            label_6:
            val_8 = 0;
            goto label_18;
            label_11:
            TzarGames.TzarHero.Skills.CharacterSkill val_9 = this.skillInstance;
            if(val_9 == null)
            {
                goto label_13;
            }
            
            var val_8 = 0;
            val_8 = val_8 + 1;
            val_9 = val_9;
            goto label_17;
            label_13:
            val_8 = 1;
            goto label_18;
            label_17:
            val_8 = val_9;
            label_18:
            val_10 = 0;
            val_9 = val_8 & 1;
            goto label_19;
            label_25:
            SetActive(value:  val_9);
            val_10 = 1;
            label_19:
            if(val_10 >= this.activableObjects.Length)
            {
                    return;
            }
            
            if(this.activableObjects[1] != null)
            {
                goto label_25;
            }
            
            goto label_25;
        }
        protected override void OnPlayerOwnerSet(TzarGames.GameFramework.Player owner)
        {
            var val_2;
            this.OnPlayerOwnerSet(owner:  owner);
            val_2 = 0;
            this.playerCharacter = ;
            this.check();
        }
        public override void NotifyShown()
        {
            this.NotifyShown();
            this.check();
        }
    
    }

}
