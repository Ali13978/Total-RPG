using UnityEngine;

namespace TzarGames.GameFramework
{
    public class ParticleDecalLauncher : MonoBehaviour
    {
        // Fields
        [UnityEngine.SerializeField]
        private TzarGames.GameFramework.ParticlePoolType poolType;
        [UnityEngine.SerializeField]
        private UnityEngine.ParticleSystem LauncherParticles;
        [UnityEngine.SerializeField]
        private UnityEngine.Color Color;
        private System.Collections.Generic.List<UnityEngine.ParticleCollisionEvent> collisionEvents;
        private System.Collections.Generic.List<UnityEngine.ParticleCollisionEvent> allCollisionEvents;
        private TzarGames.GameFramework.ParticleDecalPool pool;
        
        // Methods
        public ParticleDecalLauncher()
        {
            UnityEngine.Color val_1 = UnityEngine.Color.white;
            this.Color = val_1;
            mem[1152921511422143052] = val_1.g;
            mem[1152921511422143056] = val_1.b;
            mem[1152921511422143060] = val_1.a;
        }
        private void Start()
        {
            this.collisionEvents = new System.Collections.Generic.List<UnityEngine.ParticleCollisionEvent>();
            this.allCollisionEvents = new System.Collections.Generic.List<UnityEngine.ParticleCollisionEvent>();
        }
        private void OnParticleCollision(UnityEngine.GameObject other)
        {
            float val_4;
            float val_5;
            float val_6;
            var val_7;
            int val_1 = UnityEngine.ParticlePhysicsExtensions.GetCollisionEvents(ps:  0, go:  this.LauncherParticles, collisionEvents:  other);
            int val_2 = this.collisionEvents.Count;
            if(val_2 < 1)
            {
                    return;
            }
            
            do
            {
                UnityEngine.ParticleCollisionEvent val_3 = this.collisionEvents.Item[0];
                this.allCollisionEvents.Add(item:  new UnityEngine.ParticleCollisionEvent() {m_Intersection = new UnityEngine.Vector3() {x = val_6, y = val_6, z = val_6}, m_Normal = new UnityEngine.Vector3() {x = val_6, y = val_5, z = val_5}, m_Velocity = new UnityEngine.Vector3() {x = val_5, y = val_5, z = val_4}, m_ColliderInstanceID = val_4});
                val_7 = 0 + 1;
            }
            while(val_2 != val_7);
        
        }
        private void Update()
        {
            if(this.allCollisionEvents.Count < 1)
            {
                    return;
            }
            
            if(0 == this.pool)
            {
                    TzarGames.GameFramework.ParticleDecalPool val_3 = TzarGames.GameFramework.ParticleDecalPool.GetInstanceByPoolType(targetPoolType:  null);
                this.pool = val_3;
                if(0 == val_3)
            {
                    this.allCollisionEvents.Clear();
                string val_5 = 0 + "Failed to find pool with type: "("Failed to find pool with type: ");
                UnityEngine.Debug.LogError(message:  0);
                return;
            }
            
            }
            
            this.pool.ParticleHit(collisionEvents:  this.allCollisionEvents, color: ref  new UnityEngine.Color() {r = this.Color, g = this.Color, b = this.Color, a = this.Color});
            this.allCollisionEvents.Clear();
        }
    
    }

}
