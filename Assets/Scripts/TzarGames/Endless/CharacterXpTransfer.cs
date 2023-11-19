using UnityEngine;

namespace TzarGames.Endless
{
    public class CharacterXpTransfer : MonoBehaviour
    {
        // Fields
        [System.Diagnostics.DebuggerBrowsableAttribute]
        private TzarGames.TzarHero.TH_Character <TargetCharacter>k__BackingField;
        
        // Properties
        public TzarGames.TzarHero.TH_Character TargetCharacter { get; set; }
        
        // Methods
        public CharacterXpTransfer()
        {
        
        }
        public TzarGames.TzarHero.TH_Character get_TargetCharacter()
        {
            return (TzarGames.TzarHero.TH_Character)this.<TargetCharacter>k__BackingField;
        }
        public void set_TargetCharacter(TzarGames.TzarHero.TH_Character value)
        {
            this.<TargetCharacter>k__BackingField = value;
        }
        private void Start()
        {
            TzarGames.TzarHero.TH_Character val_1 = this.GetComponent<TzarGames.TzarHero.TH_Character>();
            val_1.TemplateInstance.add_OnXpChanged(value:  new System.Action<TzarGames.GameFramework.CharacterTemplate, System.Int32>(object:  this, method:  System.Void TzarGames.Endless.CharacterXpTransfer::TemplateInstance_OnXpChanged(TzarGames.GameFramework.CharacterTemplate template, int xpDifference)));
            val_1.add_OnComponentDestroy(value:  new TzarGames.GameFramework.dlgTzarDestroy(object:  this, method:  System.Void TzarGames.Endless.CharacterXpTransfer::Character_OnComponentDestroy(TzarGames.GameFramework.TzarBehaviour behaviour)));
        }
        private void Character_OnComponentDestroy(TzarGames.GameFramework.TzarBehaviour behaviour)
        {
            if(0 != 0.TemplateInstance)
            {
                    0.TemplateInstance.remove_OnXpChanged(value:  new System.Action<TzarGames.GameFramework.CharacterTemplate, System.Int32>(object:  this, method:  System.Void TzarGames.Endless.CharacterXpTransfer::TemplateInstance_OnXpChanged(TzarGames.GameFramework.CharacterTemplate template, int xpDifference)));
            }
            
            0.remove_OnComponentDestroy(value:  new TzarGames.GameFramework.dlgTzarDestroy(object:  this, method:  System.Void TzarGames.Endless.CharacterXpTransfer::Character_OnComponentDestroy(TzarGames.GameFramework.TzarBehaviour behaviour)));
        }
        private void TemplateInstance_OnXpChanged(TzarGames.GameFramework.CharacterTemplate template, int xpDifference)
        {
            if(xpDifference < 1)
            {
                    return;
            }
            
            if((this.<TargetCharacter>k__BackingField.isDead) != false)
            {
                    return;
            }
            
            this.<TargetCharacter>k__BackingField.ChangeXPBy(amount:  xpDifference);
        }
    
    }

}
