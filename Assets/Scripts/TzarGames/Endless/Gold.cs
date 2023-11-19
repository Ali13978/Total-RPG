using UnityEngine;

namespace TzarGames.Endless
{
    public class Gold : TH_Item, IUsableByCharacter
    {
        // Fields
        [UnityEngine.SerializeField]
        private int levelMultiplierMin;
        [UnityEngine.SerializeField]
        private int levelMultiplierMax;
        [UnityEngine.SerializeField]
        private float hitPointMultiplierMin;
        [UnityEngine.SerializeField]
        private float hitPointMultiplierMax;
        private int goldToAdd;
        
        // Methods
        public Gold()
        {
            this.levelMultiplierMin = 8;
            this.levelMultiplierMax = 10;
            this.hitPointMultiplierMax = 1f;
        }
        public bool ApplyToCharacter(TzarGames.TzarHero.TH_Character character)
        {
            return false;
        }
        public bool MustBeDestroyedAfterUse()
        {
            return true;
        }
        public override void NotifyDroppedBy(TzarGames.GameFramework.IDropperInfo dropperInfo)
        {
            var val_5;
            this.NotifyDroppedBy(dropperInfo:  dropperInfo);
            var val_5 = 0;
            val_5 = val_5 + 1;
            val_5 = dropperInfo;
            bool val_3 = UnityEngine.Object.op_Inequality(x:  0, y:  TzarGames.TzarHero.TH_InteractiveObject.GetObjectById(id:  0));
            this.goldToAdd = 1;
        }
        public override string GetLocalizedName()
        {
        
        }
        private int calculateGold(TzarGames.TzarHero.TH_Character character)
        {
            static_value_02131006 = true;
            int val_1 = this.levelMultiplierMax + 1;
            float val_7 = character.TemplateInstance.HitPoints;
            val_7 = (UnityEngine.Random.Range(min:  this.hitPointMultiplierMin, max:  this.hitPointMultiplierMax)) * val_7;
            return UnityEngine.Mathf.Max(a:  0, b:  (int)val_7 + (character.Level * (UnityEngine.Random.Range(min:  0, max:  this.levelMultiplierMin))));
        }
        public override bool CanBeStoredInInventory()
        {
            return false;
        }
    
    }

}
