using UnityEngine;

namespace TzarGames.TzarHero.Interfaces
{
    public interface IModifiableDuration
    {
        // Properties
        public abstract TzarGames.GameFramework.Characteristic DurationCharacteristic { get; }
        
        // Methods
        public abstract TzarGames.GameFramework.Characteristic get_DurationCharacteristic(); // 0
    
    }

}
