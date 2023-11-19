using UnityEngine;

namespace TzarGames.GameFramework
{
    public interface IDamageInfo
    {
        // Properties
        public abstract float Damage { get; }
        public abstract UnityEngine.Vector3 Force { get; }
        public abstract TzarGames.GameFramework.IDamageType DamageType { get; }
        public abstract TzarGames.GameFramework.IHit Hit { get; }
        
        // Methods
        public abstract float get_Damage(); // 0
        public abstract UnityEngine.Vector3 get_Force(); // 0
        public abstract TzarGames.GameFramework.IDamageType get_DamageType(); // 0
        public abstract TzarGames.GameFramework.IHit get_Hit(); // 0
    
    }

}
