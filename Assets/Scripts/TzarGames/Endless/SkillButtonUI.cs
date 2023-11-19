using UnityEngine;

namespace TzarGames.Endless
{
    public class SkillButtonUI : MonoBehaviour
    {
        // Fields
        [UnityEngine.SerializeField]
        private TzarGames.TzarHero.Skills.CharacterSkill skill;
        [UnityEngine.SerializeField]
        private UnityEngine.UI.Image skillIconImage;
        [UnityEngine.SerializeField]
        private UnityEngine.UI.Image cooldownImage;
        private TzarGames.TzarHero.TH_Character character;
        private TzarGames.TzarHero.Skills.CharacterSkill skillInstance;
        
        // Methods
        public SkillButtonUI()
        {
        
        }
        public void SetSkill(TzarGames.TzarHero.Skills.CharacterSkill newSkill)
        {
            UnityEngine.UI.Image val_4 = this.skillIconImage;
            this.skill = newSkill;
            val_4.sprite = newSkill.Icon;
            if(0 != this.cooldownImage)
            {
                    val_4 = this.skill.DisabledIcon;
                this.cooldownImage.sprite = val_4;
            }
            
            this.character = 0;
        }
        private void Update()
        {
            UnityEngine.UI.Image val_14;
            var val_15;
            var val_16;
            UnityEngine.UI.Image val_17;
            var val_18;
            if(0 == this.character)
            {
                    if(0 != this.skill)
            {
                    TzarGames.Endless.PlayerCharacter val_3 = TzarGames.Endless.EndlessGameManager.LocalPlayerCharacter;
                this.character = val_3;
                if(0 == val_3)
            {
                    return;
            }
            
                val_14 = this.character.TemplateInstance;
                this.skillInstance = val_14.GetSkillInstance(skill:  this.skill);
            }
            
            }
            
            if(0 == this.skillInstance)
            {
                    return;
            }
            
            if(this.skillInstance == null)
            {
                goto label_15;
            }
            
            var val_14 = 0;
            val_14 = val_14 + 1;
            val_15 = this.skillInstance;
            val_14 = this.skillIconImage;
            if((this.skillInstance & 1) == 0)
            {
                goto label_20;
            }
            
            var val_15 = 0;
            val_15 = val_15 + 1;
            val_16 = this.skillInstance;
            goto label_24;
            label_20:
            val_14.sprite = this.skillInstance.Icon;
            val_17 = this.cooldownImage;
            val_18 = 1;
            goto label_28;
            label_24:
            val_14.sprite = this.skillInstance;
            val_17 = this.cooldownImage;
            val_18 = 0;
            label_28:
            val_17.enabled = false;
            label_15:
            this.cooldownImage.fillAmount = this.skillInstance.CooldownTimeNormalized;
        }
    
    }

}
