using UnityEngine;

namespace TzarGames.Endless.UI
{
    public class SkillPanelUI : GameUIBase
    {
        // Fields
        [UnityEngine.SerializeField]
        private TzarGames.Endless.UI.SkillPanelUI.SkillInfoUI[] skillButtons;
        
        // Methods
        public SkillPanelUI()
        {
        
        }
        protected override void OnPlayerOwnerSet(TzarGames.GameFramework.Player owner)
        {
            var val_6;
            var val_7;
            this.OnPlayerOwnerSet(owner:  owner);
            val_6 = 0;
            val_7 = 0;
            goto label_5;
            label_23:
            val_7 = 1;
            label_5:
            if(val_7 >= this.skillButtons.Length)
            {
                    return;
            }
            
            SkillInfoUI val_6 = this.skillButtons[1];
            TzarGames.TzarHero.Skills.CharacterSkill val_3 = PlayerTemplateInstance.GetSkillAtIndex(index:  1);
            if(0 != val_3)
            {
                goto label_14;
            }
            
            string val_5 = 0 + "No skill instance at index ";
            UnityEngine.Debug.LogError(message:  0);
            goto label_23;
            label_14:
            this.skillButtons[0x1][0].SkillButton.SetSkill(newSkill:  val_3);
            this.skillButtons[0x1][0].UseSkill.defaultSkill = val_3;
            goto label_23;
        }
    
    }

}
