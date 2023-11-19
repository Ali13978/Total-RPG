using UnityEngine;

namespace TzarGames.GameFramework
{
    [TzarGames.GameFramework.LocalizedClassNameAttribute]
    public class Weapon : Item
    {
        // Fields
        [UnityEngine.HeaderAttribute]
        [UnityEngine.SerializeField]
        private float _attackRange;
        [UnityEngine.SerializeField]
        private TzarGames.GameFramework.CharacteristicModificator damageModificator;
        [UnityEngine.SerializeField]
        private TzarGames.GameFramework.CharacteristicModificator attackSpeedModificator;
        [UnityEngine.SerializeField]
        private TzarGames.GameFramework.WeaponTypes type;
        [UnityEngine.HeaderAttribute]
        [UnityEngine.SerializeField]
        private string surfaceTypeName;
        [UnityEngine.SerializeField]
        private UnityEngine.GameObject projectilePrefab;
        [UnityEngine.SerializeField]
        private float damageForceMultiplier;
        public TzarGames.GameFramework.ModificatorGroup HitModificators;
        [UnityEngine.SerializeField]
        private float rangeAttackThrowTime;
        [UnityEngine.SerializeField]
        private bool hideProjectileBeforeLaunch;
        [UnityEngine.SerializeField]
        private bool useUniqueNetworkIDForProjectiles;
        
        // Properties
        public float AttackRange { get; }
        public float Damage { get; }
        public TzarGames.GameFramework.WeaponTypes Type { get; }
        public UnityEngine.GameObject ProjectilePrefab { get; }
        public TzarGames.GameFramework.CharacteristicModificator DamageModificator { get; }
        public TzarGames.GameFramework.CharacteristicModificator AttackSpeedModificator { get; }
        public string SurfaceTypeName { get; }
        public float DamageForceMultiplier { get; }
        public bool UseUniqueNetworkIDForProjectiles { get; }
        public float RangeAttackThrowTime { get; }
        public bool HideProjectileBeforeLaunch { get; }
        
        // Methods
        public Weapon()
        {
            this._attackRange = 1f;
            this.attackSpeedModificator = new TzarGames.GameFramework.CharacteristicModificator(value:  1f);
            this.damageForceMultiplier = 1f;
            this.hideProjectileBeforeLaunch = true;
            this.surfaceTypeName = "Metal";
            this.damageModificator = new TzarGames.GameFramework.CharacteristicModificator();
            typeof(TzarGames.GameFramework.CharacteristicModificator).__il2cppRuntimeField_18 = true;
            this.attackSpeedModificator.Operator = 1;
        }
        public float get_AttackRange()
        {
            return (float)this._attackRange;
        }
        public float get_Damage()
        {
            if(this.damageModificator != null)
            {
                    return this.damageModificator.Value;
            }
            
            return this.damageModificator.Value;
        }
        public TzarGames.GameFramework.WeaponTypes get_Type()
        {
            return (TzarGames.GameFramework.WeaponTypes)this.type;
        }
        public UnityEngine.GameObject get_ProjectilePrefab()
        {
            return (UnityEngine.GameObject)this.projectilePrefab;
        }
        public TzarGames.GameFramework.CharacteristicModificator get_DamageModificator()
        {
            return (TzarGames.GameFramework.CharacteristicModificator)this.damageModificator;
        }
        public TzarGames.GameFramework.CharacteristicModificator get_AttackSpeedModificator()
        {
            return (TzarGames.GameFramework.CharacteristicModificator)this.attackSpeedModificator;
        }
        public string get_SurfaceTypeName()
        {
            return (string)this.surfaceTypeName;
        }
        public float get_DamageForceMultiplier()
        {
            return (float)this.damageForceMultiplier;
        }
        public bool get_UseUniqueNetworkIDForProjectiles()
        {
            return (bool)this.useUniqueNetworkIDForProjectiles;
        }
        public float get_RangeAttackThrowTime()
        {
            return (float)this.rangeAttackThrowTime;
        }
        public bool get_HideProjectileBeforeLaunch()
        {
            return (bool)this.hideProjectileBeforeLaunch;
        }
    
    }

}
