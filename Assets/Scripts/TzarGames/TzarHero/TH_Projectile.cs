using UnityEngine;

namespace TzarGames.TzarHero
{
    public class TH_Projectile : TzarBehaviour
    {
        // Fields
        [UnityEngine.SerializeField]
        protected TzarGames.GameFramework.Weapon projectileTemplate;
        [UnityEngine.SerializeField]
        private float lifeTime;
        [UnityEngine.SerializeField]
        private bool setLifeTimerAtStart;
        private bool lifeTimeChecked;
        private TzarGames.TzarHero.TH_InteractiveObject target;
        private TzarGames.TzarHero.TH_Character instigator;
        [UnityEngine.SerializeField]
        protected float touchRadius;
        [UnityEngine.SerializeField]
        private UnityEngine.Events.UnityEvent OnLaunched;
        public bool EnableMovement;
        private UnityEngine.Coroutine destroyDelayCoroutine;
        [System.Diagnostics.DebuggerBrowsableAttribute]
        private float <Damage>k__BackingField;
        [System.Diagnostics.DebuggerBrowsableAttribute]
        private UnityEngine.Transform <CachedTransform>k__BackingField;
        
        // Properties
        public TzarGames.GameFramework.Weapon WeaponTemplate { get; }
        public float Damage { get; set; }
        public UnityEngine.Transform CachedTransform { get; set; }
        public TzarGames.TzarHero.TH_Character Instigator { get; set; }
        public TzarGames.TzarHero.TH_InteractiveObject Target { get; set; }
        
        // Methods
        public TH_Projectile()
        {
            this.lifeTime = 5f;
            this.setLifeTimerAtStart = true;
            this.touchRadius = 1f;
            this.EnableMovement = true;
        }
        public TzarGames.GameFramework.Weapon get_WeaponTemplate()
        {
            return (TzarGames.GameFramework.Weapon)this.projectileTemplate;
        }
        public float get_Damage()
        {
            return (float)this.<Damage>k__BackingField;
        }
        public void set_Damage(float value)
        {
            this.<Damage>k__BackingField = value;
        }
        public UnityEngine.Transform get_CachedTransform()
        {
            return (UnityEngine.Transform)this.<CachedTransform>k__BackingField;
        }
        protected void set_CachedTransform(UnityEngine.Transform value)
        {
            this.<CachedTransform>k__BackingField = value;
        }
        protected override void Awake()
        {
            this.Awake();
            this.<CachedTransform>k__BackingField = this.transform;
        }
        public virtual void SetPositionAndRotation(UnityEngine.Vector3 position, UnityEngine.Quaternion rotation)
        {
            this.<CachedTransform>k__BackingField.position = new UnityEngine.Vector3() {x = position.x, y = position.y, z = position.z};
            this.<CachedTransform>k__BackingField.rotation = new UnityEngine.Quaternion() {x = rotation.x, y = rotation.y, z = rotation.z, w = rotation.w};
        }
        protected virtual void Start()
        {
            if(this.setLifeTimerAtStart == false)
            {
                    return;
            }
            
            this.setLifeTimer();
        }
        private void initProjectile()
        {
            if(this.setLifeTimerAtStart == false)
            {
                    return;
            }
            
            this.setLifeTimer();
        }
        protected void setLifeTimer()
        {
            this.Invoke(methodName:  "lifeTimeCheck", time:  this.lifeTime);
        }
        public TzarGames.TzarHero.TH_Character get_Instigator()
        {
            return (TzarGames.TzarHero.TH_Character)this.instigator;
        }
        public void set_Instigator(TzarGames.TzarHero.TH_Character value)
        {
            this.instigator = value;
            goto typeof(TzarGames.TzarHero.TH_Projectile).__il2cppRuntimeField_1F0;
        }
        protected virtual void OnInstigatorChanged()
        {
            var val_7;
            UnityEngine.Object val_8;
            val_7 = this;
            if(0 == this.instigator)
            {
                    return;
            }
            
            val_8 = this.instigator.GetComponent<UnityEngine.Collider>();
            UnityEngine.Collider val_3 = this.GetComponent<UnityEngine.Collider>();
            if(0 == val_8)
            {
                    return;
            }
            
            if(0 == val_3)
            {
                    return;
            }
            
            UnityEngine.Physics.IgnoreCollision(collider1:  0, collider2:  val_8, ignore:  val_3);
            val_7 = this.instigator.GetComponentsInChildren<UnityEngine.Collider>();
            val_8 = 0;
            goto label_12;
            label_16:
            UnityEngine.Physics.IgnoreCollision(collider1:  0, collider2:  val_3, ignore:  val_7[1152921504721543168]);
            val_8 = 1;
            label_12:
            if(val_8 >= val_6.Length)
            {
                    return;
            }
            
            if(val_8 < val_6.Length)
            {
                goto label_16;
            }
            
            goto label_16;
        }
        public virtual void NotifyLaunched()
        {
            this.OnLaunched.Invoke();
        }
        private void lifeTimeCheck()
        {
            this.lifeTimeChecked = true;
            this.DestroyOnTime();
        }
        protected void DestroyOnTime()
        {
            var val_5;
            if(this.OnServer == false)
            {
                goto label_16;
            }
            
            this.RemoveRPCs();
            System.Collections.Generic.List<TzarGames.GameFramework.Player> val_2 = this.SessionPlayers;
            if(val_2 == null)
            {
                goto label_16;
            }
            
            List.Enumerator<T> val_3 = val_2.GetEnumerator();
            do
            {
                label_14:
                if((0 & 1) == 0)
            {
                goto label_19;
            }
            
                System.Action<GooglePlayGames.BasicApi.Nearby.InitializationStatus> val_6 = val_5.InitializationCallback;
            }
            while(val_6 == TzarGames.GameFramework.GameManager.Instance.LocalPlayer);
            
            if((TzarGames.GameFramework.GameManager.Instance.Net.IsObjectRelatedToPlayer(go:  this.gameObject, player:  val_6)) == false)
            {
                goto label_14;
            }
            
            TzarGames.GameFramework.RPCall_VOID val_13 = new TzarGames.GameFramework.RPCall_VOID(object:  this, method:  System.Void TzarGames.TzarHero.TH_Projectile::client_destroyProjectile());
            this.RPC(methodDelegate:  null, target:  val_6, parameters:  null);
            goto label_14;
            label_19:
            val_5.Dispose();
            label_16:
            if(this.OnClient != true)
            {
                    this.destroy();
            }
            
            if(this.OnClient == false)
            {
                    return;
            }
            
            this.destroyDelayCoroutine = this.StartCoroutine(routine:  this.delayDestroy(delay:  2f));
        }
        protected void destroy()
        {
            UnityEngine.GameObject val_1 = this.gameObject;
            UnityEngine.GameObject val_3 = this.gameObject;
            if((TzarGames.GameFramework.Instantiator.IsPoolableInstance(instanceObject:  0)) != false)
            {
                    TzarGames.GameFramework.Instantiator.PushToPool(instanceObject:  0);
                return;
            }
            
            UnityEngine.Object.Destroy(obj:  0);
        }
        [TzarRPC]
        protected void client_destroyProjectile()
        {
            this.destroy();
        }
        private void OnDisconnectedFromServer()
        {
            if(this.lifeTimeChecked == false)
            {
                    return;
            }
            
            this.destroy();
        }
        [System.Diagnostics.DebuggerHiddenAttribute]
        private System.Collections.IEnumerator delayDestroy(float delay)
        {
            if(null != 0)
            {
                    typeof(TH_Projectile.<delayDestroy>c__Iterator0).__il2cppRuntimeField_10 = delay;
            }
            else
            {
                    mem[16] = delay;
            }
            
            typeof(TH_Projectile.<delayDestroy>c__Iterator0).__il2cppRuntimeField_18 = this;
            return (System.Collections.IEnumerator)new System.Object();
        }
        protected override void OnDestroy()
        {
            this.OnDestroy();
            this.CancelInvoke(methodName:  "lifeTimeCheck");
        }
        public TzarGames.TzarHero.TH_InteractiveObject get_Target()
        {
            return (TzarGames.TzarHero.TH_InteractiveObject)this.target;
        }
        public void set_Target(TzarGames.TzarHero.TH_InteractiveObject value)
        {
            this.target = value;
        }
        public override void OnPushedToPool()
        {
            this.OnPushedToPool();
            this.lifeTimeChecked = false;
            this.target = 0;
            this.instigator = 0;
            this.target = 0;
            this.<Damage>k__BackingField = 0f;
            this.EnableMovement = true;
            this.CancelInvoke(methodName:  "lifeTimeCheck");
            if(this.destroyDelayCoroutine == null)
            {
                    return;
            }
            
            this.StopCoroutine(routine:  this.destroyDelayCoroutine);
            this.destroyDelayCoroutine = 0;
        }
        public override void OnPulledFromPool()
        {
            this.OnPulledFromPool();
            if(this.setLifeTimerAtStart == false)
            {
                    return;
            }
            
            this.setLifeTimer();
        }
    
    }

}
