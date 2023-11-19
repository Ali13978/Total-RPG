using UnityEngine;

namespace TzarGames.Endless.Skills
{
    public class Healing : AnimationBasedSkill
    {
        // Fields
        [UnityEngine.SerializeField]
        private float healAmount;
        [UnityEngine.SerializeField]
        private bool usePercent;
        [UnityEngine.SerializeField]
        private UnityEngine.GameObject effect;
        
        // Methods
        public Healing()
        {
            this.healAmount = 10f;
            this.usePercent = true;
            val_1 = new TzarGames.TzarHero.Skills.CharacterSkill();
        }
        public override bool Validate()
        {
            if(this.Character.Target != null)
            {
                    0 = 0;
            }
            
            if(0 == )
            {
                    return false;
            }
            
            if(isDead == false)
            {
                    return this.Validate();
            }
            
            return false;
        }
        protected override void action(TzarGames.Common.StringID animationEvent)
        {
            var val_14;
            float val_15;
            float val_16;
            UnityEngine.GameObject val_17;
            if(0 == this.Character.Target)
            {
                    return;
            }
            
            val_14 = 0;
            if(this.Character.Target != null)
            {
                    val_14 = 0;
            }
            
            val_15 = this.healAmount;
            if(this.usePercent != false)
            {
                    float val_14 = 100f;
                val_14 = val_15 / val_14;
                val_15 = val_14 * BaseHealth;
            }
            
            val_16 = val_15;
            IncreaseHealth(amount:  val_16);
            val_17 = this.effect;
            UnityEngine.Vector3 val_9 = Position;
            UnityEngine.Quaternion val_10 = UnityEngine.Quaternion.identity;
            UnityEngine.Object.Instantiate<TzarGames.GameFramework.TzarBehaviour>(original:  0, position:  new UnityEngine.Vector3() {x = val_9.x, y = val_9.y, z = val_9.z}, rotation:  new UnityEngine.Quaternion() {x = val_10.x, y = val_10.y, z = val_10.z, w = val_10.w}).transform.SetParent(parent:  transform);
        }
    
    }

}
