using UnityEngine;

namespace TzarGames.Endless
{
    public abstract class CharacteristicBoostTimer : CharacterSerializableTimer
    {
        // Fields
        private TzarGames.GameFramework.CharacteristicModificator _modificator;
        private float currentRate;
        private string rate_key;
        
        // Methods
        public CharacteristicBoostTimer(TzarGames.TzarHero.TH_Character character, TzarGames.Common.SerializableData data)
        {
            this.currentRate = 1f;
            this.rate_key = 0 + this;
        }
        public void SetRate(float rate)
        {
            this.currentRate = rate;
        }
        protected override void ReadSerializedData(TzarGames.Common.IReadableData data)
        {
            string val_3;
            var val_4;
            var val_5;
            var val_6;
            val_3 = this.rate_key;
            var val_3 = 0;
            val_3 = val_3 + 1;
            val_4 = data;
            val_5 = 17664;
            if((data & 1) == 0)
            {
                    return;
            }
            
            val_3 = this.rate_key;
            var val_4 = 0;
            val_4 = val_4 + 1;
            val_5 = 1;
            val_6 = data;
            this.currentRate = ;
        }
        protected override void RemoveSerializedData(TzarGames.Common.SerializableData data)
        {
            data.DeleteFloat(id:  this.rate_key);
        }
        protected override void OnTimerExpired()
        {
            this.RemoveFromCharacter();
        }
        protected override void OnStart()
        {
            X20.SetFloat(id:  this.rate_key, val:  this.currentRate);
            this.applyModificator(character:  this.rate_key, rate:  this.currentRate);
        }
        protected virtual TzarGames.GameFramework.CharacteristicModificator CreateModificator()
        {
            return (TzarGames.GameFramework.CharacteristicModificator)new TzarGames.GameFramework.CharacteristicModificator();
        }
        protected abstract TzarGames.GameFramework.Characteristic getCharacteristic(TzarGames.GameFramework.CharacterTemplate template); // 0
        private void applyModificator(TzarGames.TzarHero.TH_Character character, float rate)
        {
            TzarGames.GameFramework.CharacteristicModificator val_2 = this._modificator;
            if(val_2 != null)
            {
                goto label_0;
            }
            
            this._modificator = this;
            mem[1152921510564079744] = 0;
            this._modificator.Operator = 2;
            this._modificator.StartTime = ;
            val_2 = this._modificator;
            if(val_2 == null)
            {
                goto label_4;
            }
            
            label_0:
            this._modificator.EffectTime = 0f;
            this._modificator.Value = rate;
            TzarGames.TzarHero.TH_CharacterTemplate val_1 = character.TemplateInstance;
            this.AddModificator(modificator:  this._modificator);
            return;
            label_4:
        }
        public void RemoveFromCharacter()
        {
            if(this._modificator == null)
            {
                    return;
            }
            
            TzarGames.TzarHero.TH_CharacterTemplate val_1 = X20.TemplateInstance;
            this.UnregisterModificator(modificator:  this._modificator);
        }
    
    }

}
