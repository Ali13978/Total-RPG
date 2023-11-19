using UnityEngine;

namespace TzarGames.GameFramework
{
    public class ParticleDecalPool : MonoBehaviour
    {
        // Fields
        [UnityEngine.SerializeField]
        private TzarGames.GameFramework.ParticlePoolType poolType;
        [UnityEngine.SerializeField]
        private int maxDecals;
        [UnityEngine.SerializeField]
        private float minSize;
        [UnityEngine.SerializeField]
        private float maxSize;
        [UnityEngine.SerializeField]
        private UnityEngine.ParticleSystem decalParticleSystem;
        private int particleDecalDataIndex;
        private TzarGames.GameFramework.ParticleDecalData[] particleData;
        private UnityEngine.ParticleSystem.Particle[] particles;
        private bool needUpdate;
        private static System.Collections.Generic.Dictionary<TzarGames.GameFramework.ParticlePoolType, TzarGames.GameFramework.ParticleDecalPool> pools;
        
        // Methods
        public ParticleDecalPool()
        {
            this.maxDecals = 100;
            this.minSize = 1.5f;
            this.maxSize = 1.5f;
        }
        public static TzarGames.GameFramework.ParticleDecalPool GetInstanceByPoolType(TzarGames.GameFramework.ParticlePoolType targetPoolType)
        {
            var val_4;
            TzarGames.GameFramework.ParticleDecalPool val_1 = 0;
            val_4 = null;
            val_4 = null;
            return (TzarGames.GameFramework.ParticleDecalPool)((TzarGames.GameFramework.ParticleDecalPool.pools.TryGetValue(key:  X1, value: out  val_1)) != true) ? (val_1) : 0;
        }
        private void Reset()
        {
            this.decalParticleSystem = this.GetComponent<UnityEngine.ParticleSystem>();
        }
        private void Awake()
        {
            var val_5;
            if(0 == this.poolType)
            {
                    UnityEngine.Debug.LogError(message:  0);
                return;
            }
            
            if(0 != (TzarGames.GameFramework.ParticleDecalPool.GetInstanceByPoolType(targetPoolType:  null)))
            {
                    UnityEngine.Debug.LogError(message:  0);
                UnityEngine.GameObject val_4 = this.gameObject;
                UnityEngine.Object.Destroy(obj:  0);
                return;
            }
            
            val_5 = null;
            val_5 = null;
            TzarGames.GameFramework.ParticleDecalPool.pools.Add(key:  this.poolType, value:  this);
        }
        private void OnDestroy()
        {
            var val_7;
            var val_8;
            UnityEngine.Events.UnityAction<UnityEngine.SceneManagement.Scene, UnityEngine.SceneManagement.LoadSceneMode> val_1 = null;
            val_7 = val_1;
            val_1 = new UnityEngine.Events.UnityAction<UnityEngine.SceneManagement.Scene, UnityEngine.SceneManagement.LoadSceneMode>(object:  this, method:  System.Void TzarGames.GameFramework.ParticleDecalPool::SceneManager_sceneLoaded(UnityEngine.SceneManagement.Scene arg0, UnityEngine.SceneManagement.LoadSceneMode arg1));
            UnityEngine.SceneManagement.SceneManager.remove_sceneLoaded(value:  0);
            if(0 == this.poolType)
            {
                    return;
            }
            
            val_7 = 1152921504914354176;
            if(0 != (TzarGames.GameFramework.ParticleDecalPool.GetInstanceByPoolType(targetPoolType:  null)))
            {
                    return;
            }
            
            val_8 = null;
            val_8 = null;
            bool val_6 = TzarGames.GameFramework.ParticleDecalPool.pools.Remove(key:  this.poolType);
        }
        private void SceneManager_sceneLoaded(UnityEngine.SceneManagement.Scene arg0, UnityEngine.SceneManagement.LoadSceneMode arg1)
        {
            this.decalParticleSystem.Clear();
            this.particles = 0;
            this.particleDecalDataIndex = 0;
            this.particles = null;
        }
        private void Start()
        {
            int val_2;
            int val_3;
            TzarGames.GameFramework.ParticleDecalData[] val_4;
            UnityEngine.Events.UnityAction<UnityEngine.SceneManagement.Scene, UnityEngine.SceneManagement.LoadSceneMode> val_1 = new UnityEngine.Events.UnityAction<UnityEngine.SceneManagement.Scene, UnityEngine.SceneManagement.LoadSceneMode>(object:  this, method:  System.Void TzarGames.GameFramework.ParticleDecalPool::SceneManager_sceneLoaded(UnityEngine.SceneManagement.Scene arg0, UnityEngine.SceneManagement.LoadSceneMode arg1));
            UnityEngine.SceneManagement.SceneManager.add_sceneLoaded(value:  0);
            val_2 = this.maxDecals;
            val_3 = this.maxDecals;
            val_4 = null;
            this.particleData = val_4;
            if(val_3 < 1)
            {
                goto label_1;
            }
            
            goto label_2;
            label_5:
            val_4 = this.particleData;
            label_2:
            var val_2 = val_4 + (0 * 44);
            val_2 = 0 + 1;
            mem2[0] = 0;
            mem2[0] = 0;
            mem2[0] = 0;
            val_3 = this.maxDecals;
            if(val_2 < val_3)
            {
                goto label_5;
            }
            
            label_1:
            this.particles = null;
        }
        public void ParticleHit(System.Collections.Generic.List<UnityEngine.ParticleCollisionEvent> collisionEvents, ref UnityEngine.Color color)
        {
            float val_3;
            float val_4;
            float val_5;
            var val_7;
            int val_1 = collisionEvents.Count;
            if(val_1 < 1)
            {
                    return;
            }
            
            var val_11 = 0;
            label_12:
            UnityEngine.ParticleCollisionEvent val_2 = collisionEvents.Item[0];
            if(this.particleData.Length < 1)
            {
                goto label_5;
            }
            
            val_7 = 0;
            var val_10 = 0;
            label_11:
            UnityEngine.Vector3 val_6 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = this.particleData[val_7], y = this.particleData[val_7], z = this.particleData[val_7]}, b:  new UnityEngine.Vector3() {x = val_4, y = val_5, z = V2.16B});
            if(val_6.x <= 0.01f)
            {
                goto label_10;
            }
            
            val_10 = val_10 + 1;
            val_7 = val_7 + 44;
            if(val_10 < (long)this.particleData.Length)
            {
                goto label_11;
            }
            
            label_5:
            this.needUpdate = true;
            this.SetParticleData(particleCollisionEvent:  new UnityEngine.ParticleCollisionEvent() {m_Intersection = new UnityEngine.Vector3() {x = val_5, y = val_5, z = val_5}, m_Normal = new UnityEngine.Vector3() {x = val_5, y = val_4, z = val_4}, m_Velocity = new UnityEngine.Vector3() {x = val_4, y = val_4, z = val_3}, m_ColliderInstanceID = val_3}, color: ref  new UnityEngine.Color() {r = color.r, g = color.g, b = color.b, a = color.a});
            label_10:
            val_11 = val_11 + 1;
            if(val_11 != val_1)
            {
                goto label_12;
            }
        
        }
        private void LateUpdate()
        {
            if(this.needUpdate == false)
            {
                    return;
            }
            
            this.needUpdate = false;
            this.DisplayParticles();
        }
        public void SetParticleData(UnityEngine.ParticleCollisionEvent particleCollisionEvent, ref UnityEngine.Color color)
        {
            int val_3;
            float val_4;
            int val_5;
            val_3 = this.particleDecalDataIndex;
            val_4 = this.minSize;
            if(val_3 >= this.maxDecals)
            {
                    val_3 = 0;
                this.particleDecalDataIndex = 0;
            }
            
            if(this.particleData == null)
            {
                    val_4 = this.minSize;
            }
            
            UnityEngine.ParticleCollisionEvent val_2 = (this.particleData + (0 * 44)) + 32;
            TzarGames.GameFramework.ParticleDecalPool.setupParticleData(data: ref  new TzarGames.GameFramework.ParticleDecalData() {Position = new UnityEngine.Vector3(), Rotation = new UnityEngine.Vector3(), Color = new UnityEngine.Color()}, particleCollisionEvent:  new UnityEngine.ParticleCollisionEvent() {m_Intersection = new UnityEngine.Vector3() {x = val_2, y = val_2, z = val_2}, m_Normal = new UnityEngine.Vector3() {x = val_2, y = val_2, z = val_2}, m_Velocity = new UnityEngine.Vector3() {x = val_2, y = val_2, z = val_2}, m_ColliderInstanceID = val_2}, minSize:  val_4, maxSize:  this.maxSize, color: ref  new UnityEngine.Color() {r = particleCollisionEvent.m_Intersection.x});
            Particle[] val_6 = this.particles;
            val_5 = this.particleDecalDataIndex;
            if(val_6 == null)
            {
                    val_5 = this.particleDecalDataIndex;
            }
            
            var val_5 = 120;
            val_5 = val_6 + ((long)this.particleDecalDataIndex * val_5);
            val_6 = val_5 + 32;
            var val_4 = (this.particleData + ((long)val_5 * 44)) + 32;
            TzarGames.GameFramework.ParticleDecalPool.setupParticle(particle: ref  new ParticleSystem.Particle() {m_Position = new UnityEngine.Vector3(), m_Velocity = new UnityEngine.Vector3(), m_AnimatedVelocity = new UnityEngine.Vector3(), m_InitialVelocity = new UnityEngine.Vector3(), m_AxisOfRotation = new UnityEngine.Vector3(), m_Rotation = new UnityEngine.Vector3(), m_AngularVelocity = new UnityEngine.Vector3(), m_StartSize = new UnityEngine.Vector3(), m_StartColor = new UnityEngine.Color32()}, data: ref  new TzarGames.GameFramework.ParticleDecalData() {Position = new UnityEngine.Vector3() {x = val_6, y = val_6, z = val_6}, Size = val_6, Rotation = new UnityEngine.Vector3() {x = val_6, y = val_6, z = val_6}, Color = new UnityEngine.Color() {r = val_6, g = val_6, b = val_6, a = val_6}});
            int val_7 = this.particleDecalDataIndex;
            val_7 = val_7 + 1;
            this.particleDecalDataIndex = val_7;
        }
        private static void setupParticleData(ref TzarGames.GameFramework.ParticleDecalData data, UnityEngine.ParticleCollisionEvent particleCollisionEvent, float minSize, float maxSize, ref UnityEngine.Color color)
        {
            particleCollisionEvent.m_Intersection.x = minSize;
            float val_1 = maxSize + 0.02f;
            particleCollisionEvent.m_Intersection.y = val_1;
            particleCollisionEvent.m_Intersection.z = ;
            UnityEngine.Quaternion val_2 = UnityEngine.Quaternion.LookRotation(forward:  new UnityEngine.Vector3() {x = val_1, y = maxSize, z = V2.16B});
            particleCollisionEvent.m_Normal.y = val_2.x;
            particleCollisionEvent.m_Normal.z = val_2.y;
            particleCollisionEvent.m_Velocity.x = (float)UnityEngine.Random.Range(min:  0, max:  0);
            particleCollisionEvent.m_Normal.x = UnityEngine.Random.Range(min:  minSize, max:  maxSize);
            particleCollisionEvent.m_Velocity.y = X3;
        }
        private void DisplayParticles()
        {
            this.decalParticleSystem.SetParticles(particles:  this.particles, size:  this.particleData.Length);
        }
        private static void setupParticle(ref UnityEngine.ParticleSystem.Particle particle, ref TzarGames.GameFramework.ParticleDecalData data)
        {
            UnityEngine.Color32 val_1 = UnityEngine.Color32.op_Implicit(c:  new UnityEngine.Color() {r = X2 + 28, g = X2 + 28 + 4, b = X2 + 36, a = X2 + 36 + 4});
            byte val_2 = val_1.r & 4294967295;
        }
        private static ParticleDecalPool()
        {
            TzarGames.GameFramework.ParticleDecalPool.pools = new System.Collections.Generic.Dictionary<TzarGames.GameFramework.ParticlePoolType, TzarGames.GameFramework.ParticleDecalPool>();
        }
    
    }

}
