using UnityEngine;

namespace TzarGames.GameFramework
{
    public class DamageInfoBase : IDamageInfo
    {
        // Fields
        [System.Diagnostics.DebuggerBrowsableAttribute]
        private float <Damage>k__BackingField;
        [System.Diagnostics.DebuggerBrowsableAttribute]
        private UnityEngine.Vector3 <Force>k__BackingField;
        [System.Diagnostics.DebuggerBrowsableAttribute]
        private TzarGames.GameFramework.IDamageType <DamageType>k__BackingField;
        [System.Diagnostics.DebuggerBrowsableAttribute]
        private TzarGames.GameFramework.IHit <Hit>k__BackingField;
        
        // Properties
        public float Damage { get; set; }
        public UnityEngine.Vector3 Force { get; set; }
        public TzarGames.GameFramework.IDamageType DamageType { get; set; }
        public TzarGames.GameFramework.IHit Hit { get; set; }
        
        // Methods
        public DamageInfoBase(float damage, UnityEngine.Vector3 force, TzarGames.GameFramework.IDamageType damageType, TzarGames.GameFramework.IHit hitInfo)
        {
            this.<Damage>k__BackingField = damage;
            this.<Force>k__BackingField = force;
            mem[1152921511314128888] = force.y;
            mem[1152921511314128892] = force.z;
            this.<DamageType>k__BackingField = damageType;
            this.<Hit>k__BackingField = hitInfo;
        }
        public float get_Damage()
        {
            return (float)this.<Damage>k__BackingField;
        }
        public void set_Damage(float value)
        {
            this.<Damage>k__BackingField = value;
        }
        public UnityEngine.Vector3 get_Force()
        {
            return new UnityEngine.Vector3() {x = this.<Force>k__BackingField};
        }
        public void set_Force(UnityEngine.Vector3 value)
        {
            this.<Force>k__BackingField = value;
            mem[1152921511314585080] = value.y;
            mem[1152921511314585084] = value.z;
        }
        public TzarGames.GameFramework.IDamageType get_DamageType()
        {
            return (TzarGames.GameFramework.IDamageType)this.<DamageType>k__BackingField;
        }
        public void set_DamageType(TzarGames.GameFramework.IDamageType value)
        {
            this.<DamageType>k__BackingField = value;
        }
        public TzarGames.GameFramework.IHit get_Hit()
        {
            return (TzarGames.GameFramework.IHit)this.<Hit>k__BackingField;
        }
        public void set_Hit(TzarGames.GameFramework.IHit value)
        {
            this.<Hit>k__BackingField = value;
        }
    
    }

}
