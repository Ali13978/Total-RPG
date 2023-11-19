using UnityEngine;

namespace TzarGames.Endless
{
    public class PlayerFadeBehaviour : MonoBehaviour, IPoolable
    {
        // Fields
        [UnityEngine.SerializeField]
        private TzarGames.Endless.PlayerCharacter playerCharacter;
        [UnityEngine.SerializeField]
        private UnityEngine.LayerMask traceLayers;
        private System.Collections.Generic.List<TzarGames.Endless.MaterialFader> allFaders;
        private UnityEngine.Collider[] cachedColliders;
        private bool fading;
        private UnityEngine.Coroutine initCoroutine;
        
        // Properties
        public bool IsFading { get; }
        
        // Methods
        public PlayerFadeBehaviour()
        {
            this.allFaders = new System.Collections.Generic.List<TzarGames.Endless.MaterialFader>();
            this.cachedColliders = null;
        }
        public bool get_IsFading()
        {
            return (bool)this.fading;
        }
        private void init()
        {
            if(this.playerCharacter.PlayerOwner != null)
            {
                    if(this.playerCharacter.PlayerOwner.itsMe == false)
            {
                goto label_4;
            }
            
            }
            
            this.gameObject.SetActive(value:  false);
            return;
            label_4:
            this.onEquipmentCreated(obj:  this.playerCharacter.gameObject);
        }
        private void Start()
        {
            this.playerCharacter.add_OnEquipmentPrefabInstanceCreated(value:  new System.Action<UnityEngine.GameObject>(object:  this, method:  System.Void TzarGames.Endless.PlayerFadeBehaviour::onEquipmentCreated(UnityEngine.GameObject obj)));
            this.init();
        }
        private void onEquipmentCreated(UnityEngine.GameObject obj)
        {
            T val_5;
            if(0 == obj)
            {
                    UnityEngine.Debug.Log(message:  0);
                return;
            }
            
            T[] val_2 = obj.GetComponentsInChildren<TzarGames.Endless.MaterialFader>();
            if(val_2 == null)
            {
                    return;
            }
            
            if(val_2.Length < 1)
            {
                    return;
            }
            
            if(val_2.Length < 1)
            {
                    return;
            }
            
            do
            {
                val_5 = val_2[0];
                val_2[0] = this.allFaders.Contains(item:  val_5);
                if(val_2[0] != true)
            {
                    val_5.add_OnComponentDestroy(value:  new System.Action<TzarGames.Endless.MaterialFader>(object:  this, method:  System.Void TzarGames.Endless.PlayerFadeBehaviour::onFaderDestroy(TzarGames.Endless.MaterialFader obj)));
                this.allFaders.Add(item:  val_5);
            }
            
            }
            while((0 + 1) < val_2.Length);
        
        }
        private void onFaderDestroy(TzarGames.Endless.MaterialFader obj)
        {
            bool val_1 = this.allFaders.Remove(item:  obj);
        }
        private void OnDestroy()
        {
            var val_8;
            if(0 != this.playerCharacter)
            {
                    this.playerCharacter.remove_OnEquipmentPrefabInstanceCreated(value:  new System.Action<UnityEngine.GameObject>(object:  this, method:  System.Void TzarGames.Endless.PlayerFadeBehaviour::onEquipmentCreated(UnityEngine.GameObject obj)));
            }
            
            val_8 = 0;
            goto label_5;
            label_13:
            val_8 = 1;
            label_5:
            if(val_8 >= this.allFaders.Count)
            {
                    return;
            }
            
            TzarGames.Endless.MaterialFader val_5 = this.allFaders.Item[1];
            if(0 == val_5)
            {
                goto label_13;
            }
            
            val_5.remove_OnComponentDestroy(value:  new System.Action<TzarGames.Endless.MaterialFader>(object:  this, method:  System.Void TzarGames.Endless.PlayerFadeBehaviour::onFaderDestroy(TzarGames.Endless.MaterialFader obj)));
            goto label_13;
        }
        private void Update()
        {
            float val_25;
            UnityEngine.Collider[] val_26;
            if(this.initCoroutine != null)
            {
                    return;
            }
            
            UnityEngine.CharacterController val_1 = this.playerCharacter.CharController;
            UnityEngine.Vector3 val_2 = val_1.center;
            UnityEngine.Vector3 val_4 = val_1.transform.position;
            UnityEngine.Vector3 val_5 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z}, b:  new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z});
            if(val_1 != null)
            {
                    val_25 = val_1.height;
            }
            else
            {
                    val_25 = 0.height;
            }
            
            float val_8 = val_25 * 0.5f;
            float val_9 = val_1.radius;
            UnityEngine.Vector3 val_10 = UnityEngine.Vector3.down;
            val_8 = val_8 - val_9;
            UnityEngine.Vector3 val_11 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_10.x, y = val_10.y, z = val_10.z}, d:  val_8);
            UnityEngine.Vector3 val_12 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z}, b:  new UnityEngine.Vector3() {x = val_11.x, y = val_11.y, z = val_11.z});
            UnityEngine.Vector3 val_13 = UnityEngine.Vector3.up;
            UnityEngine.Vector3 val_14 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_13.x, y = val_13.y, z = val_13.z}, d:  val_8);
            UnityEngine.Vector3 val_15 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z}, b:  new UnityEngine.Vector3() {x = val_14.x, y = val_14.y, z = val_14.z});
            val_26 = this.cachedColliders;
            int val_16 = UnityEngine.LayerMask.op_Implicit(mask:  new UnityEngine.LayerMask());
            int val_17 = UnityEngine.Physics.OverlapCapsuleNonAlloc(point0:  new UnityEngine.Vector3() {x = val_12.x, y = val_12.y, z = val_12.z}, point1:  new UnityEngine.Vector3() {x = val_15.x, y = val_15.y, z = val_15.z}, radius:  val_9, results:  0, layerMask:  val_26);
            if(val_17 < 2)
            {
                goto label_10;
            }
            
            var val_25 = 0;
            label_25:
            val_26 = this.cachedColliders[val_25];
            if(0 == val_26)
            {
                goto label_21;
            }
            
            val_26 = val_26.GetComponent<TzarGames.Endless.PlayerCharacter>();
            if((0 == val_26) || (val_26.PlayerOwner == null))
            {
                goto label_21;
            }
            
            val_26 = val_26.PlayerOwner;
            if(val_26.itsMe == true)
            {
                goto label_24;
            }
            
            label_21:
            val_25 = val_25 + 1;
            if(val_25 < (long)val_17)
            {
                goto label_25;
            }
            
            label_10:
            this.fadeOut();
            return;
            label_24:
            this.fadeIn();
        }
        private void fadeIn()
        {
            var val_3;
            if(this.fading == true)
            {
                    return;
            }
            
            this.fading = true;
            val_3 = 0;
            goto label_2;
            label_7:
            X21.FadeIn();
            val_3 = 1;
            label_2:
            if(val_3 >= this.allFaders.Count)
            {
                    return;
            }
            
            if(this.allFaders.Item[1] != null)
            {
                goto label_7;
            }
            
            goto label_7;
        }
        private void fadeOut()
        {
            var val_3;
            if(this.fading == false)
            {
                    return;
            }
            
            this.fading = false;
            val_3 = 0;
            goto label_2;
            label_7:
            X21.FadeOut();
            val_3 = 1;
            label_2:
            if(val_3 >= this.allFaders.Count)
            {
                    return;
            }
            
            if(this.allFaders.Item[1] != null)
            {
                goto label_7;
            }
            
            goto label_7;
        }
        public void OnPushedToPool()
        {
            var val_2;
            this.enabled = false;
            this.allFaders.Clear();
            val_2 = 0;
            goto label_2;
            label_7:
            var val_1 = X21 + ((X22) << 3);
            val_2 = 1;
            mem2[0] = 0;
            label_2:
            if(val_2 >= this.cachedColliders.Length)
            {
                goto label_4;
            }
            
            if(val_2 < this.cachedColliders.Length)
            {
                goto label_7;
            }
            
            goto label_7;
            label_4:
            this.fading = false;
            if(this.initCoroutine == null)
            {
                    return;
            }
            
            this.StopCoroutine(routine:  this.initCoroutine);
            this.initCoroutine = 0;
        }
        public void OnPulledFromPool()
        {
            this.enabled = true;
            this.initCoroutine = this.StartCoroutine(routine:  this.initRoutine());
        }
        [System.Diagnostics.DebuggerHiddenAttribute]
        private System.Collections.IEnumerator initRoutine()
        {
            typeof(PlayerFadeBehaviour.<initRoutine>c__Iterator0).__il2cppRuntimeField_10 = this;
            return (System.Collections.IEnumerator)new System.Object();
        }
    
    }

}
