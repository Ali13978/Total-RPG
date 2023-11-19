using UnityEngine;

namespace TzarGames.Endless.Skills
{
    public class RootSkill : AnimationBasedSkill
    {
        // Fields
        [UnityEngine.SerializeField]
        private UnityEngine.GameObject rootEffect;
        [UnityEngine.SerializeField]
        private float baseDamage;
        [UnityEngine.SerializeField]
        private float freezeTime;
        [UnityEngine.SerializeField]
        private UnityEngine.GameObject effect;
        private TzarGames.GameFramework.IWeaponObject weaponObject;
        
        // Methods
        public RootSkill()
        {
            this.baseDamage = 10f;
            this.freezeTime = 5f;
        }
        public override bool Validate()
        {
            if(this.checkCharacterValid() == false)
            {
                    return false;
            }
            
            return this.Validate();
        }
        private bool checkCharacterValid()
        {
            if(0 == this.Character)
            {
                    return false;
            }
            
            this = this.Character.Target;
            bool val_7 = UnityEngine.Object.op_Equality(x:  0, y:  this);
            return false;
        }
        protected override void OnCharacterAssigned()
        {
            this.OnCharacterAssigned();
            this.weaponObject = this.Character.GetComponentInChildren<TzarGames.GameFramework.IWeaponObject>();
        }
        protected override void OnCharacterRemoved(TzarGames.TzarHero.TH_Character character)
        {
            this.OnCharacterRemoved(character:  character);
            if(this.weaponObject == null)
            {
                    return;
            }
            
            this.weaponObject = 0;
        }
        protected override void OnStarted()
        {
            var val_3;
            this.OnStarted();
            if(this.weaponObject == null)
            {
                    return;
            }
            
            var val_3 = 0;
            val_3 = val_3 + 1;
            val_3 = this.weaponObject;
            UnityEngine.GameObject val_2 = UnityEngine.Object.Instantiate<UnityEngine.GameObject>(original:  0, parent:  this.effect, worldPositionStays:  this.weaponObject);
        }
        protected override void action(TzarGames.Common.StringID animationEvent)
        {
            if(this.checkCharacterValid() == false)
            {
                    return;
            }
            
            float val_12 = this.baseDamage;
            val_12 = val_12 * (UnityEngine.Mathf.Max(a:  (float)(double)this.Character.Level, b:  1f));
            TzarGames.TzarHero.TH_InteractiveObject val_8 = this.Character.Target;
            UnityEngine.Vector3 val_9 = 0.GroundPivotPosition;
            UnityEngine.Quaternion val_10 = UnityEngine.Quaternion.identity;
            typeof(RootSkill.RootInfluence).__il2cppRuntimeField_40 = UnityEngine.Object.Instantiate<TzarGames.GameFramework.TzarBehaviour>(original:  0, position:  new UnityEngine.Vector3() {x = val_9.x, y = val_9.y, z = val_9.z}, rotation:  new UnityEngine.Quaternion() {x = val_10.x, y = val_10.y, z = val_10.z, w = val_10.w});
            0.AddInfluence(influence:  new RootSkill.RootInfluence(damagePerSecond:  val_12, damageInterval:  0.5f, instigator:  this.Character, effectTime:  this.freezeTime));
        }
    
    }

}
