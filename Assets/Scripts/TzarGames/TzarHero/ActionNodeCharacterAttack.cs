using UnityEngine;

namespace TzarGames.TzarHero
{
    [TzarGames.Common.ScriptViz.LabelAttribute]
    public class ActionNodeCharacterAttack : ActionNode
    {
        // Fields
        [UnityEngine.SerializeField]
        private TzarGames.TzarHero.TH_Character character;
        [UnityEngine.SerializeField]
        private TzarGames.TzarHero.TH_Character target;
        [UnityEngine.SerializeField]
        private bool continuously;
        [UnityEngine.SerializeField]
        [UnityEngine.HideInInspector]
        private TzarGames.Common.ScriptViz.SvNodeSlot characterSlot;
        [UnityEngine.SerializeField]
        [UnityEngine.HideInInspector]
        private TzarGames.Common.ScriptViz.SvNodeSlot targetSlot;
        
        // Methods
        public ActionNodeCharacterAttack()
        {
            this.continuously = true;
        }
        protected override void Init()
        {
            this.Init();
            this.characterSlot = this.AddVariableInputSlot(slotName:  "Character");
            this.targetSlot = this.AddVariableInputSlot(slotName:  "Target");
        }
        public override void OnImpulse(TzarGames.Common.NodeSlot slot)
        {
            TzarGames.TzarHero.TH_Character val_5;
            this.OnImpulse(slot:  slot);
            val_5 = this.character;
            if(0 == val_5)
            {
                goto label_3;
            }
            
            if(0 == this.target)
            {
                goto label_6;
            }
            
            val_5 = this.character;
            if(this.continuously == false)
            {
                goto label_8;
            }
            
            val_5.AttackCharacterContinuously(character:  this.target);
            goto label_17;
            label_3:
            string val_3 = slot.SlotName;
            string val_4 = 0 + "Character is null on slot ";
            UnityEngine.Debug.LogError(message:  0);
            goto label_17;
            label_6:
            this.character.UseWeapon();
            goto label_17;
            label_8:
            val_5.AttackCharacter(character:  this.target, ignoreAttackRangeCheck:  false);
            label_17:
            this.DefaultImpulse();
        }
        public override void OnVariableImpulse(object variable, TzarGames.Common.ScriptViz.SvNodeSlot slot)
        {
            this.OnVariableImpulse(var:  variable, slot:  slot);
            if(0 == slot)
            {
                    if(variable != null)
            {
                    if(null == null)
            {
                goto label_7;
            }
            
            }
            
                this.target = 0;
                return;
            }
            
            if(0 != slot)
            {
                    return;
            }
            
            if(variable != null)
            {
                    if(null == null)
            {
                goto label_15;
            }
            
            }
            
            this.character = 0;
            return;
            label_7:
            this.target = variable.GetComponent<TzarGames.TzarHero.TH_Character>();
            return;
            label_15:
            this.character = variable.GetComponent<TzarGames.TzarHero.TH_Character>();
        }
    
    }

}
