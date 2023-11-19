using UnityEngine;

namespace TzarGames.Endless.Skills
{
    public class StunAttack : AnimBasedAttackSkill
    {
        // Fields
        [UnityEngine.SerializeField]
        private float stunTime;
        [UnityEngine.SerializeField]
        private UnityEngine.GameObject effect;
        [UnityEngine.SerializeField]
        private UnityEngine.GameObject handEffect;
        private UnityEngine.Transform[] effectPositions;
        
        // Methods
        public StunAttack()
        {
            this.stunTime = 2f;
        }
        protected override void OnCharacterAssigned()
        {
            this.OnCharacterAssigned();
            if(0 == (this.Character.GetComponent<TzarGames.Endless.Skills.StunAttackBehaviour>()))
            {
                    return;
            }
            
            this.effectPositions = val_2.EffectPositions;
        }
        protected override void OnCharacterRemoved(TzarGames.TzarHero.TH_Character character)
        {
            this.OnCharacterRemoved(character:  character);
            this.effectPositions = 0;
        }
        protected override void OnStarted()
        {
            this.OnStarted();
            if(0 == this.handEffect)
            {
                    return;
            }
            
            if(this.effectPositions == null)
            {
                    return;
            }
            
            if(this.effectPositions.Length < 1)
            {
                    return;
            }
            
            do
            {
                UnityEngine.GameObject val_2 = UnityEngine.Object.Instantiate<UnityEngine.GameObject>(original:  0, parent:  this.handEffect, worldPositionStays:  this.effectPositions[0]);
            }
            while((0 + 1) < this.effectPositions.Length);
        
        }
        protected override void onHit(TzarGames.TzarHero.CharacterDamageInfo hit)
        {
            var val_9;
            this.onHit(hit:  hit);
            hit.Victim.Stun(stunTime:  this.stunTime);
            var val_9 = 0;
            val_9 = val_9 + 1;
            val_9 = hit.Hit;
            UnityEngine.Quaternion val_4 = UnityEngine.Quaternion.identity;
            UnityEngine.Object.Instantiate<TzarGames.GameFramework.TzarBehaviour>(original:  0, position:  new UnityEngine.Vector3() {x = this.stunTime, y = V1.16B, z = V2.16B}, rotation:  new UnityEngine.Quaternion() {x = val_4.x, y = val_4.y, z = val_4.z, w = val_4.w}).transform.SetParent(parent:  hit.Victim.transform);
        }
    
    }

}
