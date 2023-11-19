using UnityEngine;

namespace TzarGames.TzarHero.Influences
{
    public class TimeInfluence : IInfluence, IModifiableDuration
    {
        // Fields
        private double elapsedTime;
        private TzarGames.GameFramework.Characteristic duration;
        private TzarGames.TzarHero.TH_Character target;
        [System.Diagnostics.DebuggerBrowsableAttribute]
        private TzarGames.TzarHero.TH_Character <Instigator>k__BackingField;
        
        // Properties
        public TzarGames.TzarHero.TH_Character Target { get; }
        public double ElapsedTime { get; }
        public TzarGames.TzarHero.TH_Character Instigator { get; set; }
        public TzarGames.GameFramework.Characteristic DurationCharacteristic { get; }
        
        // Methods
        public TimeInfluence(TzarGames.TzarHero.TH_Character instigator, float effectTime)
        {
            this.<Instigator>k__BackingField = instigator;
            this.duration = new TzarGames.GameFramework.Characteristic(baseValue:  effectTime);
            Init();
            this.duration.clampMinimum = true;
            this.duration.applyModificatorsWhenBaseIsLessOrEqualZero = false;
            this.duration.minValue = 0f;
            this.target = 0;
            this.elapsedTime = 0;
        }
        public TzarGames.TzarHero.TH_Character get_Target()
        {
            return (TzarGames.TzarHero.TH_Character)this.target;
        }
        public double get_ElapsedTime()
        {
            return (double)this.elapsedTime;
        }
        public void ResetTimer()
        {
            this.elapsedTime = 0;
        }
        public TzarGames.TzarHero.TH_Character get_Instigator()
        {
            return (TzarGames.TzarHero.TH_Character)this.<Instigator>k__BackingField;
        }
        public void set_Instigator(TzarGames.TzarHero.TH_Character value)
        {
            this.<Instigator>k__BackingField = value;
        }
        public TzarGames.GameFramework.Characteristic get_DurationCharacteristic()
        {
            return (TzarGames.GameFramework.Characteristic)this.duration;
        }
        public virtual void OnAddedToCharacter(TzarGames.TzarHero.TH_Character character)
        {
            if(0 != this.target)
            {
                    UnityEngine.Debug.LogError(message:  0);
                return;
            }
            
            this.elapsedTime = 0;
            this.target = character;
        }
        public virtual void OnRemovedFromCharacter(TzarGames.TzarHero.TH_Character character)
        {
            this.target = 0;
        }
        public virtual void Update(float timeDelta)
        {
            if(0 == this.target)
            {
                    return;
            }
            
            this.duration.Update();
            double val_4 = this.elapsedTime;
            val_4 = (double)timeDelta + val_4;
            this.elapsedTime = val_4;
            if(val_4 < (double)this.duration.Value)
            {
                    return;
            }
            
            this.target.RemoveInfluence(influence:  this);
        }
    
    }

}
