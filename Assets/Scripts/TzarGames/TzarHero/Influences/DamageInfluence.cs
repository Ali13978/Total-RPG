using UnityEngine;

namespace TzarGames.TzarHero.Influences
{
    public class DamageInfluence : IInfluence
    {
        // Fields
        private float damagePerSecond;
        private float damageInterval;
        private float damageTimer;
        public bool IgnoreDefence;
        private TzarGames.TzarHero.CharacterDamageInfo damageInfo;
        [System.Diagnostics.DebuggerBrowsableAttribute]
        private TzarGames.TzarHero.TH_Character <Instigator>k__BackingField;
        
        // Properties
        public TzarGames.TzarHero.TH_Character Instigator { get; set; }
        
        // Methods
        public DamageInfluence(float damagePerSecond, float damageInterval, TzarGames.TzarHero.TH_Character instigator)
        {
            this.damagePerSecond = damagePerSecond;
            this.damageInterval = damageInterval;
            this.damageTimer = 0f;
        }
        public TzarGames.TzarHero.TH_Character get_Instigator()
        {
            return (TzarGames.TzarHero.TH_Character)this.<Instigator>k__BackingField;
        }
        private void set_Instigator(TzarGames.TzarHero.TH_Character value)
        {
            this.<Instigator>k__BackingField = value;
        }
        public void OnAddedToCharacter(TzarGames.TzarHero.TH_Character character)
        {
            this.damageInfo = this.createDamageInfo(victim:  character, instigator:  this.<Instigator>k__BackingField);
            val_1.<IgnoreDefence>k__BackingField = this.IgnoreDefence;
        }
        public void OnRemovedFromCharacter(TzarGames.TzarHero.TH_Character character)
        {
            this.damageInfo = 0;
        }
        public void Update(float timeDelta)
        {
            float val_4;
            TzarGames.TzarHero.CharacterDamageInfo val_5;
            val_4 = timeDelta;
            if(this.damageInfo == null)
            {
                    return;
            }
            
            if(0 == (this.damageInfo.<Victim>k__BackingField))
            {
                    return;
            }
            
            val_4 = this.damageTimer + val_4;
            this.damageTimer = val_4;
            if(val_4 < this.damageInterval)
            {
                    return;
            }
            
            this.damageInfo.Damage = val_4 * this.damagePerSecond;
            this.damageTimer = 0f;
            val_5 = this.damageInfo;
            if(this.damageInfo == null)
            {
                    val_5 = this.damageInfo;
            }
            
            this.damageInfo.<Victim>k__BackingField.TakeDamage(damageInfo:  val_5);
        }
        private TzarGames.TzarHero.CharacterDamageInfo createDamageInfo(TzarGames.TzarHero.TH_Character victim, TzarGames.TzarHero.TH_Character instigator)
        {
            UnityEngine.Vector3 val_1 = victim.Position;
            UnityEngine.Vector3 val_2 = UnityEngine.Vector3.up;
            UnityEngine.Vector3 val_5 = UnityEngine.Vector3.up;
            TzarGames.TzarHero.TH_DamageType_Default val_7 = new TzarGames.TzarHero.TH_DamageType_Default(surfaceType:  TzarGames.GameFramework.SurfaceTypeBase.Default);
            var val_10 = ~val_7.OnClient;
            val_10 = val_10 & 1;
            typeof(TzarGames.TzarHero.CharacterDamageInfo).__il2cppRuntimeField_38 = instigator;
            typeof(TzarGames.TzarHero.CharacterDamageInfo).__il2cppRuntimeField_40 = victim;
            typeof(TzarGames.TzarHero.CharacterDamageInfo).__il2cppRuntimeField_36 = val_10;
            typeof(TzarGames.TzarHero.CharacterDamageInfo).__il2cppRuntimeField_34 = 0;
            return (TzarGames.TzarHero.CharacterDamageInfo)new TzarGames.GameFramework.DamageInfoBase(damage:  0f, force:  new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z}, damageType:  val_7, hitInfo:  new TzarGames.GameFramework.Hit(point:  new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = val_1.z}, normal:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z}, collider:  0, rigidbody:  0, surfaceType:  TzarGames.GameFramework.SurfaceTypeBase.Default));
        }
    
    }

}
