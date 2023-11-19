using UnityEngine;

namespace TzarGames.TzarHero
{
    [Serializable]
    public class DeadEventData
    {
        // Fields
        public TzarGames.GameFramework.IDamageType DamageType;
        public TzarGames.TzarHero.TH_Character Victim;
        public TzarGames.TzarHero.TH_Character Killer;
        public UnityEngine.Vector3 Force;
        public bool IsCritical;
        
        // Methods
        public DeadEventData(TzarGames.TzarHero.TH_Character killer, TzarGames.TzarHero.TH_Character victim, UnityEngine.Vector3 force, TzarGames.GameFramework.IDamageType damageType)
        {
            this.Victim = victim;
            this.Killer = killer;
            this.Force = force;
            mem[1152921511486354796] = force.y;
            this.DamageType = damageType;
            mem[1152921511486354800] = force.z;
        }
    
    }

}
