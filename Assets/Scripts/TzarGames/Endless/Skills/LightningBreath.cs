using UnityEngine;

namespace TzarGames.Endless.Skills
{
    public class LightningBreath : AnimationBasedSkill
    {
        // Fields
        [UnityEngine.SerializeField]
        private TzarGames.Common.StringID stopAnimEvent;
        [UnityEngine.SerializeField]
        private TzarGames.TzarHero.DamageInfluenceBehaviour damageZonePrefab;
        [UnityEngine.SerializeField]
        private float zoneDestroyTime;
        private TzarGames.TzarHero.DamageInfluenceBehaviour zone;
        private UnityEngine.Transform attachPoint;
        
        // Methods
        public LightningBreath()
        {
            this.zoneDestroyTime = 1f;
        }
        protected override void action(TzarGames.Common.StringID animationEvent)
        {
            if(0 == animationEvent)
            {
                    this.destroyZone();
                return;
            }
            
            UnityEngine.Vector3 val_2 = this.attachPoint.position;
            UnityEngine.Quaternion val_3 = this.attachPoint.rotation;
            this.zone = UnityEngine.Object.Instantiate<TzarGames.TzarHero.DamageInfluenceBehaviour>(original:  0, position:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z}, rotation:  new UnityEngine.Quaternion() {x = val_3.x, y = val_3.y, z = val_3.z, w = val_3.w}, parent:  this.damageZonePrefab);
        }
        private void destroyZone()
        {
            var val_4;
            if(0 == this.zone)
            {
                    return;
            }
            
            val_4 = 0;
            goto label_5;
            label_10:
            X21.Stop(withChildren:  true, stopBehavior:  1);
            val_4 = 1;
            label_5:
            if(val_4 >= val_2.Length)
            {
                goto label_7;
            }
            
            if((this.zone.GetComponentsInChildren<UnityEngine.ParticleSystem>()[1]) != 0)
            {
                goto label_10;
            }
            
            goto label_10;
            label_7:
            this.zone.RemoveAllInfluences();
            this.zone.enabled = false;
            UnityEngine.GameObject val_3 = this.zone.gameObject;
            UnityEngine.Object.Destroy(obj:  0, t:  this.zoneDestroyTime);
            this.zone = 0;
        }
        protected override void OnCharacterAssigned()
        {
            var val_4;
            this.OnCharacterAssigned();
            val_4 = 0;
            do
            {
                if(val_4 >= val_2.Length)
            {
                    return;
            }
            
                val_4 = val_4 + 1;
            }
            while((this.Character.GetComponentsInChildren<TzarGames.GameFramework.Skills.SkillAttachPoints>()[0].Skill) != this);
            
            this.attachPoint = val_2[0x0][0] + 32 + 32;
        }
        protected override void OnStopped()
        {
            this.OnStopped();
            this.destroyZone();
        }
    
    }

}
