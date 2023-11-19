using UnityEngine;

namespace TzarGames.TzarHero
{
    public abstract class TimeEffectBoostItem : TH_Item, IUsableByCharacter
    {
        // Fields
        [UnityEngine.SerializeField]
        private float effectTime;
        
        // Properties
        public abstract TzarGames.GameFramework.CharacteristicModificator Modificator { get; }
        public float EffectTime { get; }
        
        // Methods
        protected TimeEffectBoostItem()
        {
            this.effectTime = 15f;
        }
        public abstract TzarGames.GameFramework.Characteristic GetModifiableCharacteristic(TzarGames.GameFramework.CharacterTemplate template); // 0
        public abstract TzarGames.GameFramework.CharacteristicModificator get_Modificator(); // 0
        public float get_EffectTime()
        {
            return (float)this.effectTime;
        }
        public virtual bool ApplyToCharacter(TzarGames.TzarHero.TH_Character character)
        {
            return false;
        }
        public bool MustBeDestroyedAfterUse()
        {
            return true;
        }
    
    }

}
