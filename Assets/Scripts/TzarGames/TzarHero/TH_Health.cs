using UnityEngine;

namespace TzarGames.TzarHero
{
    [TzarGames.GameFramework.LocalizedClassNameAttribute]
    public class TH_Health : TH_Item, IUsableByCharacter
    {
        // Fields
        [UnityEngine.HeaderAttribute]
        [UnityEngine.SerializeField]
        private bool canBeStoredInInventory;
        [UnityEngine.SerializeField]
        private bool usePercentAddition;
        [UnityEngine.SerializeField]
        private float HitPointsPrecent;
        [UnityEngine.SerializeField]
        private float hitPointAddition;
        [UnityEngine.SerializeField]
        private TzarGames.Common.LocalizedStringAsset percentModeDescription;
        [UnityEngine.SerializeField]
        private TzarGames.Common.LocalizedStringAsset additionModeDescription;
        private float lastAppliedBoost;
        
        // Properties
        public bool UsePercentAddition { get; }
        
        // Methods
        public TH_Health()
        {
            this.usePercentAddition = true;
            this.HitPointsPrecent = 5f;
            this.hitPointAddition = 100f;
            val_1 = new TzarGames.GameFramework.Item();
        }
        public bool get_UsePercentAddition()
        {
            return (bool)this.usePercentAddition;
        }
        public override string GetDescription()
        {
            object val_4;
            var val_6;
            if(this.usePercentAddition != false)
            {
                    val_4 = TzarGames.Common.LocalizedStringAsset.op_Implicit(text:  0);
                val_6 = null;
                return (string)System.String.Format(format:  0, arg0:  val_4 = TzarGames.Common.LocalizedStringAsset.op_Implicit(text:  0));
            }
            
            val_6 = null;
            return (string)System.String.Format(format:  0, arg0:  val_4);
        }
        public bool ApplyToCharacter(TzarGames.TzarHero.TH_Character character)
        {
            float val_1 = this.getBoost(character:  character);
            this.lastAppliedBoost = val_1;
            character.IncreaseHealth(amount:  val_1);
            return true;
        }
        private float getBoost(TzarGames.TzarHero.TH_Character character)
        {
            if(this.usePercentAddition == false)
            {
                    return (float)this.hitPointAddition;
            }
            
            float val_1 = character.characterTemplateInstance.HitPoints;
            val_1 = val_1 / 100f;
            val_1 = val_1 * this.HitPointsPrecent;
            return (float)this.hitPointAddition;
        }
        public bool MustBeDestroyedAfterUse()
        {
            return true;
        }
        public override bool CanBeStoredInInventory()
        {
            return (bool)this.canBeStoredInInventory;
        }
        public override string GetLocalizedName()
        {
            if(0 != 34807808)
            {
                    return TzarGames.Common.LocalizedStringAsset.op_Implicit(text:  0);
            }
            
            return (string)System.String.Format(format:  0, arg0:  "+ {0:0} HP");
        }
    
    }

}
