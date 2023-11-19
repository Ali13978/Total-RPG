using UnityEngine;

namespace TzarGames.Endless.Skills
{
    public class MassStunAttack : AnimationBasedSkill
    {
        // Fields
        [UnityEngine.SerializeField]
        private float radius;
        [UnityEngine.SerializeField]
        private float pushForce;
        [UnityEngine.SerializeField]
        private float stunTime;
        [UnityEngine.SerializeField]
        private UnityEngine.GameObject effect;
        
        // Methods
        public MassStunAttack()
        {
            this.radius = 10f;
            this.pushForce = 1200f;
            this.stunTime = 3f;
        }
        protected override void action(TzarGames.Common.StringID animationEvent)
        {
            var val_16;
            var val_17;
            UnityEngine.Vector3 val_2 = this.Character.Position;
            UnityEngine.Quaternion val_3 = UnityEngine.Quaternion.identity;
            TzarGames.GameFramework.TzarBehaviour val_4 = UnityEngine.Object.Instantiate<TzarGames.GameFramework.TzarBehaviour>(original:  0, position:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z}, rotation:  new UnityEngine.Quaternion() {x = val_3.x, y = val_3.y, z = val_3.z, w = val_3.w});
            TzarGames.GameFramework.Weapon val_8 = this.Character.GetActiveWeaponTemplate(slot:  0);
            List.Enumerator<T> val_9 = this.Character.GetOtherCharactersInRadius(radius:  this.radius).GetEnumerator();
            label_13:
            if((0 & 1) == 0)
            {
                goto label_9;
            }
            
            System.Action<GooglePlayGames.BasicApi.Nearby.InitializationStatus> val_10 = 0.InitializationCallback;
            if((this.Character.isCharacterValidForAttack(character:  val_10)) == false)
            {
                goto label_13;
            }
            
            TzarGames.TzarHero.CharacterDamageInfo val_15 = TzarGames.TzarHero.SimpleMeleeCombatSystem.AdjustMeleeDamageTo(instigator:  0, victim:  this.Character, weapon:  val_10, damageForceMultiplier:  this.pushForce);
            val_10.Stun(stunTime:  this.stunTime);
            goto label_13;
            label_9:
            val_16 = 0;
            val_17 = 1;
            0.Dispose();
            if((val_17 & 1) != 0)
            {
                    return;
            }
            
            if(val_16 == 0)
            {
                    return;
            }
        
        }
    
    }

}
