using UnityEngine;

namespace TzarGames.Endless
{
    public class XpBoostTimer : CharacteristicBoostTimer
    {
        // Fields
        private const string prefix_key = "XP_BOOST";
        private const string mode_key = "XPBOOST_GOLD_MODE";
        private bool goldMode;
        
        // Properties
        public bool IsGoldMode { get; }
        
        // Methods
        public XpBoostTimer(TzarGames.TzarHero.TH_Character character, TzarGames.Common.SerializableData data)
        {
        
        }
        public void SetGoldMode(bool on)
        {
            this.goldMode = on;
        }
        public bool get_IsGoldMode()
        {
            return (bool)this.goldMode;
        }
        protected override string GetPrefixSerializationKey()
        {
            return "XP_BOOST";
        }
        protected override void ReadSerializedData(TzarGames.Common.IReadableData data)
        {
            bool val_6;
            var val_7;
            var val_8;
            var val_9;
            var val_10;
            var val_11;
            val_6 = this;
            val_7 = 0;
            this.ReadSerializedData(data:  data);
            val_8 = "XPBOOST_GOLD_MODE";
            var val_6 = 0;
            val_6 = val_6 + 1;
            val_7 = 2;
            val_9 = data;
            if((data & 1) == 0)
            {
                    return;
            }
            
            val_8 = "XPBOOST_GOLD_MODE";
            var val_7 = 0;
            val_7 = val_7 + 1;
            val_10 = 0;
            val_11 = data;
            val_6 = this.goldMode;
            if((System.Boolean.TryParse(value:  0, result: out  data)) == true)
            {
                    return;
            }
            
            UnityEngine.Debug.LogError(message:  0);
            mem2[0] = 0;
        }
        protected override void RemoveSerializedData(TzarGames.Common.SerializableData data)
        {
            this.RemoveSerializedData(data:  data);
            data.DeleteString(id:  "XPBOOST_GOLD_MODE");
        }
        protected override void OnStart()
        {
            this.OnStart();
            this.Data.SetString(id:  "XPBOOST_GOLD_MODE", stringValue:  this.goldMode);
        }
        protected override TzarGames.GameFramework.Characteristic getCharacteristic(TzarGames.GameFramework.CharacterTemplate template)
        {
            if(template != null)
            {
                    return template.XpRateCharacteristic;
            }
            
            return template.XpRateCharacteristic;
        }
    
    }

}
