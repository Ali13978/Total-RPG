using UnityEngine;

namespace TzarGames.GameFramework
{
    public interface IWeaponObject
    {
        // Properties
        public abstract UnityEngine.Transform[] FireSources { get; }
        
        // Methods
        public abstract UnityEngine.Transform[] get_FireSources(); // 0
    
    }

}
