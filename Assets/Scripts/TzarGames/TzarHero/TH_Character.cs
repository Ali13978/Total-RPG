using UnityEngine;

namespace TzarGames.TzarHero
{
    public class TH_Character : TH_InteractiveObject, ICharacterDamageReceiver, IItemReceiver, IDamageReceiver
    {
        // Fields
        [UnityEngine.SerializeField]
        protected TzarGames.TzarHero.TH_CharacterTemplate characterTemplate;
        [UnityEngine.SerializeField]
        private TzarGames.TzarHero.TH_CharacterTemplate characterTemplateInstance;
        [UnityEngine.SerializeField]
        [UnityEngine.HideInInspector]
        private bool InstantiatedInPlayMode;
        [UnityEngine.SerializeField]
        private TzarGames.TzarHero.SimpleMeleeCombatSystem meleeCombatSystem;
        [UnityEngine.SerializeField]
        private TzarGames.TzarHero.SimpleRangeCombatSystem rangeCombatSystem;
        [UnityEngine.SerializeField]
        protected bool useAnimBasedCombatSystem;
        [UnityEngine.SerializeField]
        private TzarGames.TzarHero.AnimationBasedCombatSystem animBasedCombatSystem;
        [UnityEngine.SerializeField]
        private string surfaceType;
        [UnityEngine.SerializeField]
        private float _rotationRate;
        [UnityEngine.SerializeField]
        private UnityEngine.Transform rotationBody;
        [UnityEngine.SerializeField]
        private float _destroyDelayAfterDeath;
        [UnityEngine.SerializeField]
        private float _minDistanceToWaypoint;
        [UnityEngine.SerializeField]
        private float radiusScale;
        [UnityEngine.SerializeField]
        private float DefaultRadius;
        private bool _characterIsDead;
        private bool _fallen;
        private UnityEngine.Quaternion desiredRotation;
        private UnityEngine.CharacterController characterController;
        private TzarGames.GameFramework.ICharacterMovement movement;
        private TzarGames.GameFramework.IPathMovementHandler pathMovement;
        private System.Collections.Generic.List<TzarGames.GameFramework.ModificatorGroup> applyPendingGroups;
        [UnityEngine.SerializeField]
        private TzarGames.TzarHero.CharacterAnimationBase characterAnimation;
        [UnityEngine.SerializeField]
        private UnityEngine.AudioSource audioSource;
        private TzarGames.TzarHero.TH_InteractiveObject targetObject;
        private TzarGames.TzarHero.TH_InteractiveObject nextObjectToAttack;
        private bool pendingChangeStateAfterAttack;
        private System.Type pendingStateToChangeAfterAttack;
        private System.Collections.Generic.List<System.Action> callbacksToExecuteAfterAttack;
        [UnityEngine.SerializeField]
        private CodeStage.AntiCheat.ObscuredTypes.ObscuredBool ignoreDamage;
        private TzarGames.GameFramework.BooleanCharacteristic ignoreDamage_runtime;
        [UnityEngine.SerializeField]
        private CodeStage.AntiCheat.ObscuredTypes.ObscuredBool canBeAttacked;
        private CodeStage.AntiCheat.ObscuredTypes.ObscuredBool canBeAttacked_runtime;
        public bool enableBodyRotation;
        private bool bGoingToInterObject;
        private int currentWaypoint;
        [UnityEngine.SerializeField]
        private TzarGames.GameFramework.PathfinderBase pathfinder;
        private TzarGames.GameFramework.IPathResult pathResult;
        private UnityEngine.Vector3 lastPathPosition;
        private bool subscribedToTemplateEvents;
        private bool bIsStucked;
        [UnityEngine.SerializeField]
        private float stuckCheckTime;
        [UnityEngine.SerializeField]
        protected bool allowLocalControl;
        private bool pendingAttackFromClient;
        [UnityEngine.SerializeField]
        private bool enableAllRigidBodiesOnDeath;
        [UnityEngine.SerializeField]
        protected UnityEngine.Transform ragdollRoot;
        [UnityEngine.SerializeField]
        private bool disableCharacterControllerOnDeath;
        [UnityEngine.SerializeField]
        private bool changeLayerOnDeath;
        public string DeathLayerName;
        [System.Diagnostics.DebuggerBrowsableAttribute]
        private System.Action<TzarGames.TzarHero.Interfaces.IInfluence> OnInfluenceAdded;
        [System.Diagnostics.DebuggerBrowsableAttribute]
        private System.Action<TzarGames.TzarHero.Interfaces.IInfluence> OnInfluenceRemoved;
        private System.Collections.Generic.List<TzarGames.TzarHero.Interfaces.IInfluence> influences;
        private bool bAttackContinuosly;
        private bool bFollowingToAttack;
        private UnityEngine.Vector3 attackDirection;
        private System.Collections.Generic.Dictionary<int, TzarGames.GameFramework.ItemInstance> activeWeaponInstances;
        private TzarGames.GameFramework.ItemInstance tempWeaponInstance;
        private bool useTempWeapon;
        [System.Diagnostics.DebuggerBrowsableAttribute]
        private TzarGames.Common.TG_VoidDelegate OnStartAttack;
        [System.Diagnostics.DebuggerBrowsableAttribute]
        private TzarGames.TzarHero.TH_Character.dlgDeadEvent OnCharacterDead;
        [System.Diagnostics.DebuggerBrowsableAttribute]
        private TzarGames.TzarHero.TH_Character.dlgHitEvent OnCharacterTakeHit;
        [System.Diagnostics.DebuggerBrowsableAttribute]
        private TzarGames.TzarHero.TH_Character.dlgHitEvent OnHitOtherCharacter;
        [System.Diagnostics.DebuggerBrowsableAttribute]
        private TzarGames.TzarHero.TH_Character.dlgCharacterEvent OnSpawn;
        [System.Diagnostics.DebuggerBrowsableAttribute]
        private TzarGames.TzarHero.TH_Character.dlgCharacterEvent OnStun;
        [System.Diagnostics.DebuggerBrowsableAttribute]
        private TzarGames.TzarHero.TH_Character.dlgCharacterEvent OnExitFromStun;
        [System.Diagnostics.DebuggerBrowsableAttribute]
        private TzarGames.TzarHero.TH_Character.dlgCharacterEvent OnCharacterAlive;
        [System.Diagnostics.DebuggerBrowsableAttribute]
        private TzarGames.TzarHero.TH_Character.dlgCharacterEvent OnCharacterLevelUp;
        [System.Diagnostics.DebuggerBrowsableAttribute]
        private TzarGames.TzarHero.TH_Character.ItemTakeDelegate OnItemAddedToInventory;
        [System.Diagnostics.DebuggerBrowsableAttribute]
        private TzarGames.TzarHero.TH_Character.ItemTakeDelegate OnItemTaken;
        private System.Action<TzarGames.TzarHero.TH_Character, bool> reachPositionResultHandler;
        private static System.Collections.Generic.List<TzarGames.TzarHero.TH_Character> allCharacters;
        private static bool allCharsListInitialized;
        private bool xpCollectEnabled;
        private bool bAccelerated;
        private bool bMoving;
        private static System.Collections.Generic.List<TzarGames.TzarHero.TH_Character> tempCharacterList;
        private float lastHealthSyncTickTime;
        private float lastHealthAmount;
        [UnityEngine.SerializeField]
        private float checkFollowingRate1;
        [UnityEngine.SerializeField]
        private float checkFollowingRate2;
        
        // Properties
        public TzarGames.TzarHero.AnimationBasedCombatSystem AnimBasedCombatSystem { get; }
        public TzarGames.GameFramework.BooleanCharacteristic IgnoreDamage { get; }
        public bool CanBeAttacked { get; set; }
        public float MinDistanceToWaypoint { get; }
        public int InfluenceCount { get; }
        public TzarGames.TzarHero.TH_CharacterTemplate TemplateInstance { get; }
        public TzarGames.GameFramework.CharacterTemplate Template { get; }
        public UnityEngine.Vector3 AttackDirection { get; }
        public bool IsFollowingToAttack { get; }
        public TzarGames.GameFramework.PathfinderBase Pathfinder { get; }
        public static System.Collections.Generic.List<TzarGames.TzarHero.TH_Character> AllCharacters { get; }
        public bool AllowLocalControl { get; }
        public TzarGames.TzarHero.TH_InteractiveObject Target { get; set; }
        public TzarGames.GameFramework.ICharacterMovement Movement { get; }
        public TzarGames.TzarHero.CharacterAnimationBase Animation { get; set; }
        public bool IsMovingOnPath { get; }
        public float ActualHealth { get; }
        public float BaseHealth { get; }
        public uint XP { get; }
        public bool XpCollectEanbled { get; set; }
        public bool isDead { get; }
        public bool IsAttacking { get; }
        public UnityEngine.Vector3 Velocity { get; }
        public TzarGames.TzarHero.SimpleMeleeCombatSystem MeleeCombatSystem { get; set; }
        public TzarGames.TzarHero.SimpleRangeCombatSystem RangeCombatSystem { get; set; }
        public TzarGames.GameFramework.Weapon ActiveWeaponTemplate { get; }
        public UnityEngine.CharacterController CharController { get; }
        public bool Fallen { get; }
        public float MaxMoveSpeed { get; }
        public uint Level { get; set; }
        public float AttackPerSecond { get; }
        public bool IsStucked { get; }
        public bool IsMoving { get; }
        public bool IsFollowing { get; }
        
        // Methods
        public TH_Character()
        {
            this.InstantiatedInPlayMode = true;
            this._rotationRate = 5f;
            this.surfaceType = "Flesh";
            mem2[0] = ;
            UnityEngine.Quaternion val_1 = UnityEngine.Quaternion.identity;
            mem[1152921511520849064] = val_1.w;
            this.desiredRotation = val_1;
            mem[1152921511520849056] = val_1.y;
            mem[1152921511520849060] = val_1.z;
            this.applyPendingGroups = new System.Collections.Generic.List<TzarGames.GameFramework.ModificatorGroup>();
            this.callbacksToExecuteAfterAttack = new System.Collections.Generic.List<System.Action>();
            CodeStage.AntiCheat.ObscuredTypes.ObscuredBool val_4 = CodeStage.AntiCheat.ObscuredTypes.ObscuredBool.op_Implicit(value:  false);
            this.ignoreDamage = val_4;
            mem[1152921511520849168] = val_4.inited;
            mem[1152921511520849169] = val_4.fakeValue;
            mem[1152921511520849170] = val_4.fakeValueActive;
            CodeStage.AntiCheat.ObscuredTypes.ObscuredBool val_5 = CodeStage.AntiCheat.ObscuredTypes.ObscuredBool.op_Implicit(value:  false);
            this.canBeAttacked = val_5;
            mem[1152921511520849192] = val_5.inited;
            mem[1152921511520849193] = val_5.fakeValue;
            mem[1152921511520849194] = val_5.fakeValueActive;
            this.currentWaypoint = 1;
            this.enableBodyRotation = 1;
            UnityEngine.Vector3 val_6 = UnityEngine.Vector3.zero;
            this.changeLayerOnDeath = 1;
            this.lastPathPosition = val_6;
            mem[1152921511520849236] = val_6.y;
            mem[1152921511520849240] = val_6.z;
            this.stuckCheckTime = 1f;
            this.DeathLayerName = "Ragdoll";
            this.influences = new System.Collections.Generic.List<TzarGames.TzarHero.Interfaces.IInfluence>();
            UnityEngine.Vector3 val_8 = UnityEngine.Vector3.one;
            mem[1152921511520849316] = val_8.z;
            this.attackDirection = val_8;
            mem[1152921511520849312] = val_8.y;
            this.activeWeaponInstances = new System.Collections.Generic.Dictionary<System.Int32, TzarGames.GameFramework.ItemInstance>();
            this.xpCollectEnabled = 1;
            mem2[0] = 4539628425446424576;
        }
        public TzarGames.TzarHero.AnimationBasedCombatSystem get_AnimBasedCombatSystem()
        {
            return (TzarGames.TzarHero.AnimationBasedCombatSystem)this.animBasedCombatSystem;
        }
        public TzarGames.GameFramework.BooleanCharacteristic get_IgnoreDamage()
        {
            return (TzarGames.GameFramework.BooleanCharacteristic)this.ignoreDamage_runtime;
        }
        public bool get_CanBeAttacked()
        {
            return CodeStage.AntiCheat.ObscuredTypes.ObscuredBool.op_Implicit(value:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredBool() {inited = this.canBeAttacked_runtime.currentCryptoKey, fakeValue = this.canBeAttacked_runtime.currentCryptoKey, fakeValueActive = this.canBeAttacked_runtime.currentCryptoKey});
        }
        public void set_CanBeAttacked(bool value)
        {
            value = value;
            CodeStage.AntiCheat.ObscuredTypes.ObscuredBool val_1 = CodeStage.AntiCheat.ObscuredTypes.ObscuredBool.op_Implicit(value:  false);
            mem2[0] = val_1.currentCryptoKey;
            mem[1152921511521313588] = val_1.inited;
            mem[1152921511521313589] = val_1.fakeValue;
            mem[1152921511521313590] = val_1.fakeValueActive;
        }
        public float get_MinDistanceToWaypoint()
        {
            return (float)this._minDistanceToWaypoint;
        }
        public void add_OnInfluenceAdded(System.Action<TzarGames.TzarHero.Interfaces.IInfluence> value)
        {
            var val_3;
            do
            {
                System.Delegate val_1 = System.Delegate.Combine(a:  0, b:  this.OnInfluenceAdded);
                val_3 = 0;
                if(val_1 != null)
            {
                    val_3 = val_1;
                if(null != null)
            {
                    val_3 = 0;
            }
            
            }
            
            }
            while(this.OnInfluenceAdded != this.OnInfluenceAdded);
        
        }
        public void remove_OnInfluenceAdded(System.Action<TzarGames.TzarHero.Interfaces.IInfluence> value)
        {
            var val_3;
            do
            {
                System.Delegate val_1 = System.Delegate.Remove(source:  0, value:  this.OnInfluenceAdded);
                val_3 = 0;
                if(val_1 != null)
            {
                    val_3 = val_1;
                if(null != null)
            {
                    val_3 = 0;
            }
            
            }
            
            }
            while(this.OnInfluenceAdded != this.OnInfluenceAdded);
        
        }
        public void add_OnInfluenceRemoved(System.Action<TzarGames.TzarHero.Interfaces.IInfluence> value)
        {
            var val_3;
            do
            {
                System.Delegate val_1 = System.Delegate.Combine(a:  0, b:  this.OnInfluenceRemoved);
                val_3 = 0;
                if(val_1 != null)
            {
                    val_3 = val_1;
                if(null != null)
            {
                    val_3 = 0;
            }
            
            }
            
            }
            while(this.OnInfluenceRemoved != this.OnInfluenceRemoved);
        
        }
        public void remove_OnInfluenceRemoved(System.Action<TzarGames.TzarHero.Interfaces.IInfluence> value)
        {
            var val_3;
            do
            {
                System.Delegate val_1 = System.Delegate.Remove(source:  0, value:  this.OnInfluenceRemoved);
                val_3 = 0;
                if(val_1 != null)
            {
                    val_3 = val_1;
                if(null != null)
            {
                    val_3 = 0;
            }
            
            }
            
            }
            while(this.OnInfluenceRemoved != this.OnInfluenceRemoved);
        
        }
        public System.Collections.Generic.IEnumerable<TzarGames.TzarHero.Interfaces.IInfluence> GetAllInfluences()
        {
            return (System.Collections.Generic.IEnumerable<TzarGames.TzarHero.Interfaces.IInfluence>)this.influences;
        }
        public int get_InfluenceCount()
        {
            if(this.influences != null)
            {
                    return this.influences.Count;
            }
            
            return this.influences.Count;
        }
        public TzarGames.TzarHero.Interfaces.IInfluence GetInfluenceAtIndex(int index)
        {
            if(this.influences.Count <= index)
            {
                    return 0;
            }
            
            if(this.influences != null)
            {
                    return this.influences.Item[index];
            }
            
            return this.influences.Item[index];
        }
        public bool HasInfluenceOfType<T>()
        {
            var val_3;
            int val_1 = this.influences.Count;
            if(val_1 < 1)
            {
                goto label_2;
            }
            
            var val_3 = 0;
            label_5:
            if(this.influences.Item[0] != null)
            {
                goto label_4;
            }
            
            val_3 = val_3 + 1;
            if(val_3 < val_1)
            {
                goto label_5;
            }
            
            label_2:
            val_3 = 0;
            return (bool)val_3;
            label_4:
            val_3 = 1;
            return (bool)val_3;
        }
        public TzarGames.TzarHero.Interfaces.IInfluence TryGetFirstInfluenceOfType<T>()
        {
            var val_3;
            int val_1 = this.influences.Count;
            if(val_1 >= 1)
            {
                    var val_3 = 0;
                do
            {
                val_3 = this.influences.Item[0];
                if(val_3 != null)
            {
                    return (TzarGames.TzarHero.Interfaces.IInfluence)val_3;
            }
            
                val_3 = val_3 + 1;
            }
            while(val_3 < val_1);
            
            }
            
            val_3 = 0;
            return (TzarGames.TzarHero.Interfaces.IInfluence)val_3;
        }
        public void AddInfluence(TzarGames.TzarHero.Interfaces.IInfluence influence)
        {
            System.Collections.Generic.List<TzarGames.TzarHero.Interfaces.IInfluence> val_4;
            var val_5;
            var val_6;
            if(influence == null)
            {
                    return;
            }
            
            val_4 = this.influences;
            if((val_4.Contains(item:  influence)) == true)
            {
                    return;
            }
            
            val_4 = this.influences;
            val_5 = public System.Void System.Collections.Generic.List<TzarGames.TzarHero.Interfaces.IInfluence>::Add(TzarGames.TzarHero.Interfaces.IInfluence item);
            val_4.Add(item:  influence);
            var val_4 = 0;
            val_4 = val_4 + 1;
            val_5 = 1;
            val_6 = influence;
            if(this.OnInfluenceAdded == null)
            {
                    return;
            }
            
            this.OnInfluenceAdded.Invoke(obj:  influence);
        }
        public void RemoveInfluence(TzarGames.TzarHero.Interfaces.IInfluence influence)
        {
            System.Collections.Generic.List<TzarGames.TzarHero.Interfaces.IInfluence> val_3;
            var val_4;
            var val_5;
            if(influence == null)
            {
                    return;
            }
            
            val_3 = this.influences;
            val_4 = public System.Boolean System.Collections.Generic.List<TzarGames.TzarHero.Interfaces.IInfluence>::Remove(TzarGames.TzarHero.Interfaces.IInfluence item);
            bool val_1 = val_3.Remove(item:  influence);
            var val_3 = 0;
            val_3 = val_3 + 1;
            val_4 = 2;
            val_5 = influence;
            if(this.OnInfluenceRemoved == null)
            {
                    return;
            }
            
            this.OnInfluenceRemoved.Invoke(obj:  influence);
        }
        public void add_OnStartAttack(TzarGames.Common.TG_VoidDelegate value)
        {
            var val_3;
            do
            {
                System.Delegate val_1 = System.Delegate.Combine(a:  0, b:  this.OnStartAttack);
                val_3 = 0;
                if(val_1 != null)
            {
                    val_3 = val_1;
                if(null != null)
            {
                    val_3 = 0;
            }
            
            }
            
            }
            while(this.OnStartAttack != this.OnStartAttack);
        
        }
        public void remove_OnStartAttack(TzarGames.Common.TG_VoidDelegate value)
        {
            var val_3;
            do
            {
                System.Delegate val_1 = System.Delegate.Remove(source:  0, value:  this.OnStartAttack);
                val_3 = 0;
                if(val_1 != null)
            {
                    val_3 = val_1;
                if(null != null)
            {
                    val_3 = 0;
            }
            
            }
            
            }
            while(this.OnStartAttack != this.OnStartAttack);
        
        }
        public void add_OnCharacterDead(TzarGames.TzarHero.TH_Character.dlgDeadEvent value)
        {
            var val_3;
            do
            {
                System.Delegate val_1 = System.Delegate.Combine(a:  0, b:  this.OnCharacterDead);
                val_3 = 0;
                if(val_1 != null)
            {
                    val_3 = val_1;
                if(null != null)
            {
                    val_3 = 0;
            }
            
            }
            
            }
            while(this.OnCharacterDead != this.OnCharacterDead);
        
        }
        public void remove_OnCharacterDead(TzarGames.TzarHero.TH_Character.dlgDeadEvent value)
        {
            var val_3;
            do
            {
                System.Delegate val_1 = System.Delegate.Remove(source:  0, value:  this.OnCharacterDead);
                val_3 = 0;
                if(val_1 != null)
            {
                    val_3 = val_1;
                if(null != null)
            {
                    val_3 = 0;
            }
            
            }
            
            }
            while(this.OnCharacterDead != this.OnCharacterDead);
        
        }
        public void add_OnCharacterTakeHit(TzarGames.TzarHero.TH_Character.dlgHitEvent value)
        {
            var val_3;
            do
            {
                System.Delegate val_1 = System.Delegate.Combine(a:  0, b:  this.OnCharacterTakeHit);
                val_3 = 0;
                if(val_1 != null)
            {
                    val_3 = val_1;
                if(null != null)
            {
                    val_3 = 0;
            }
            
            }
            
            }
            while(this.OnCharacterTakeHit != this.OnCharacterTakeHit);
        
        }
        public void remove_OnCharacterTakeHit(TzarGames.TzarHero.TH_Character.dlgHitEvent value)
        {
            var val_3;
            do
            {
                System.Delegate val_1 = System.Delegate.Remove(source:  0, value:  this.OnCharacterTakeHit);
                val_3 = 0;
                if(val_1 != null)
            {
                    val_3 = val_1;
                if(null != null)
            {
                    val_3 = 0;
            }
            
            }
            
            }
            while(this.OnCharacterTakeHit != this.OnCharacterTakeHit);
        
        }
        public void add_OnHitOtherCharacter(TzarGames.TzarHero.TH_Character.dlgHitEvent value)
        {
            var val_3;
            do
            {
                System.Delegate val_1 = System.Delegate.Combine(a:  0, b:  this.OnHitOtherCharacter);
                val_3 = 0;
                if(val_1 != null)
            {
                    val_3 = val_1;
                if(null != null)
            {
                    val_3 = 0;
            }
            
            }
            
            }
            while(this.OnHitOtherCharacter != this.OnHitOtherCharacter);
        
        }
        public void remove_OnHitOtherCharacter(TzarGames.TzarHero.TH_Character.dlgHitEvent value)
        {
            var val_3;
            do
            {
                System.Delegate val_1 = System.Delegate.Remove(source:  0, value:  this.OnHitOtherCharacter);
                val_3 = 0;
                if(val_1 != null)
            {
                    val_3 = val_1;
                if(null != null)
            {
                    val_3 = 0;
            }
            
            }
            
            }
            while(this.OnHitOtherCharacter != this.OnHitOtherCharacter);
        
        }
        public void add_OnSpawn(TzarGames.TzarHero.TH_Character.dlgCharacterEvent value)
        {
            var val_3;
            do
            {
                System.Delegate val_1 = System.Delegate.Combine(a:  0, b:  this.OnSpawn);
                val_3 = 0;
                if(val_1 != null)
            {
                    val_3 = val_1;
                if(null != null)
            {
                    val_3 = 0;
            }
            
            }
            
            }
            while(this.OnSpawn != this.OnSpawn);
        
        }
        public void remove_OnSpawn(TzarGames.TzarHero.TH_Character.dlgCharacterEvent value)
        {
            var val_3;
            do
            {
                System.Delegate val_1 = System.Delegate.Remove(source:  0, value:  this.OnSpawn);
                val_3 = 0;
                if(val_1 != null)
            {
                    val_3 = val_1;
                if(null != null)
            {
                    val_3 = 0;
            }
            
            }
            
            }
            while(this.OnSpawn != this.OnSpawn);
        
        }
        public void add_OnStun(TzarGames.TzarHero.TH_Character.dlgCharacterEvent value)
        {
            var val_3;
            do
            {
                System.Delegate val_1 = System.Delegate.Combine(a:  0, b:  this.OnStun);
                val_3 = 0;
                if(val_1 != null)
            {
                    val_3 = val_1;
                if(null != null)
            {
                    val_3 = 0;
            }
            
            }
            
            }
            while(this.OnStun != this.OnStun);
        
        }
        public void remove_OnStun(TzarGames.TzarHero.TH_Character.dlgCharacterEvent value)
        {
            var val_3;
            do
            {
                System.Delegate val_1 = System.Delegate.Remove(source:  0, value:  this.OnStun);
                val_3 = 0;
                if(val_1 != null)
            {
                    val_3 = val_1;
                if(null != null)
            {
                    val_3 = 0;
            }
            
            }
            
            }
            while(this.OnStun != this.OnStun);
        
        }
        public void add_OnExitFromStun(TzarGames.TzarHero.TH_Character.dlgCharacterEvent value)
        {
            var val_3;
            do
            {
                System.Delegate val_1 = System.Delegate.Combine(a:  0, b:  this.OnExitFromStun);
                val_3 = 0;
                if(val_1 != null)
            {
                    val_3 = val_1;
                if(null != null)
            {
                    val_3 = 0;
            }
            
            }
            
            }
            while(this.OnExitFromStun != this.OnExitFromStun);
        
        }
        public void remove_OnExitFromStun(TzarGames.TzarHero.TH_Character.dlgCharacterEvent value)
        {
            var val_3;
            do
            {
                System.Delegate val_1 = System.Delegate.Remove(source:  0, value:  this.OnExitFromStun);
                val_3 = 0;
                if(val_1 != null)
            {
                    val_3 = val_1;
                if(null != null)
            {
                    val_3 = 0;
            }
            
            }
            
            }
            while(this.OnExitFromStun != this.OnExitFromStun);
        
        }
        public void add_OnCharacterAlive(TzarGames.TzarHero.TH_Character.dlgCharacterEvent value)
        {
            var val_3;
            do
            {
                System.Delegate val_1 = System.Delegate.Combine(a:  0, b:  this.OnCharacterAlive);
                val_3 = 0;
                if(val_1 != null)
            {
                    val_3 = val_1;
                if(null != null)
            {
                    val_3 = 0;
            }
            
            }
            
            }
            while(this.OnCharacterAlive != this.OnCharacterAlive);
        
        }
        public void remove_OnCharacterAlive(TzarGames.TzarHero.TH_Character.dlgCharacterEvent value)
        {
            var val_3;
            do
            {
                System.Delegate val_1 = System.Delegate.Remove(source:  0, value:  this.OnCharacterAlive);
                val_3 = 0;
                if(val_1 != null)
            {
                    val_3 = val_1;
                if(null != null)
            {
                    val_3 = 0;
            }
            
            }
            
            }
            while(this.OnCharacterAlive != this.OnCharacterAlive);
        
        }
        public void add_OnCharacterLevelUp(TzarGames.TzarHero.TH_Character.dlgCharacterEvent value)
        {
            var val_3;
            do
            {
                System.Delegate val_1 = System.Delegate.Combine(a:  0, b:  this.OnCharacterLevelUp);
                val_3 = 0;
                if(val_1 != null)
            {
                    val_3 = val_1;
                if(null != null)
            {
                    val_3 = 0;
            }
            
            }
            
            }
            while(this.OnCharacterLevelUp != this.OnCharacterLevelUp);
        
        }
        public void remove_OnCharacterLevelUp(TzarGames.TzarHero.TH_Character.dlgCharacterEvent value)
        {
            var val_3;
            do
            {
                System.Delegate val_1 = System.Delegate.Remove(source:  0, value:  this.OnCharacterLevelUp);
                val_3 = 0;
                if(val_1 != null)
            {
                    val_3 = val_1;
                if(null != null)
            {
                    val_3 = 0;
            }
            
            }
            
            }
            while(this.OnCharacterLevelUp != this.OnCharacterLevelUp);
        
        }
        public void add_OnItemAddedToInventory(TzarGames.TzarHero.TH_Character.ItemTakeDelegate value)
        {
            var val_3;
            do
            {
                System.Delegate val_1 = System.Delegate.Combine(a:  0, b:  this.OnItemAddedToInventory);
                val_3 = 0;
                if(val_1 != null)
            {
                    val_3 = val_1;
                if(null != null)
            {
                    val_3 = 0;
            }
            
            }
            
            }
            while(this.OnItemAddedToInventory != this.OnItemAddedToInventory);
        
        }
        public void remove_OnItemAddedToInventory(TzarGames.TzarHero.TH_Character.ItemTakeDelegate value)
        {
            var val_3;
            do
            {
                System.Delegate val_1 = System.Delegate.Remove(source:  0, value:  this.OnItemAddedToInventory);
                val_3 = 0;
                if(val_1 != null)
            {
                    val_3 = val_1;
                if(null != null)
            {
                    val_3 = 0;
            }
            
            }
            
            }
            while(this.OnItemAddedToInventory != this.OnItemAddedToInventory);
        
        }
        public void add_OnItemTaken(TzarGames.TzarHero.TH_Character.ItemTakeDelegate value)
        {
            var val_3;
            do
            {
                System.Delegate val_1 = System.Delegate.Combine(a:  0, b:  this.OnItemTaken);
                val_3 = 0;
                if(val_1 != null)
            {
                    val_3 = val_1;
                if(null != null)
            {
                    val_3 = 0;
            }
            
            }
            
            }
            while(this.OnItemTaken != this.OnItemTaken);
        
        }
        public void remove_OnItemTaken(TzarGames.TzarHero.TH_Character.ItemTakeDelegate value)
        {
            var val_3;
            do
            {
                System.Delegate val_1 = System.Delegate.Remove(source:  0, value:  this.OnItemTaken);
                val_3 = 0;
                if(val_1 != null)
            {
                    val_3 = val_1;
                if(null != null)
            {
                    val_3 = 0;
            }
            
            }
            
            }
            while(this.OnItemTaken != this.OnItemTaken);
        
        }
        public TzarGames.TzarHero.TH_CharacterTemplate get_TemplateInstance()
        {
            return (TzarGames.TzarHero.TH_CharacterTemplate)this.characterTemplateInstance;
        }
        public TzarGames.GameFramework.CharacterTemplate get_Template()
        {
            return (TzarGames.GameFramework.CharacterTemplate)this.characterTemplate;
        }
        public UnityEngine.Vector3 get_AttackDirection()
        {
            return new UnityEngine.Vector3() {x = this.attackDirection};
        }
        public bool get_IsFollowingToAttack()
        {
            return (bool)this.bFollowingToAttack;
        }
        public TzarGames.GameFramework.PathfinderBase get_Pathfinder()
        {
            return (TzarGames.GameFramework.PathfinderBase)this.pathfinder;
        }
        public void SetCharacterTemplate(TzarGames.TzarHero.TH_CharacterTemplate template)
        {
            if(0 == this.characterTemplate)
            {
                    return;
            }
            
            this.characterTemplate = template;
            this.CreateCharacterTemplateInstance();
        }
        public void CreateCharacterTemplateInstance()
        {
            TzarGames.TzarHero.TH_Character val_13;
            var val_14;
            val_13 = this;
            val_14 = 1152921504721543168;
            if(0 == this.characterTemplate)
            {
                    return;
            }
            
            if((UnityEngine.Object.op_Implicit(exists:  0)) == false)
            {
                    return;
            }
            
            if(0 != this.characterTemplateInstance)
            {
                    UnityEngine.Object.Destroy(obj:  0);
            }
            
            this.characterTemplateInstance = UnityEngine.Object.Instantiate<Unitycoding.UIWidgets.RadialMenuItem>(original:  0);
            mem2[0] = val_13;
            this.characterTemplateInstance.OnItemActivated.AddListener(call:  new UnityEngine.Events.UnityAction<TzarGames.GameFramework.ItemInstance, TzarGames.TzarHero.ItemActivationInfo>(object:  this, method:  typeof(TzarGames.TzarHero.TH_Character).__il2cppRuntimeField_2F8));
            val_13 = ???;
            val_14 = ???;
            goto typeof(TzarGames.TzarHero.TH_Character).__il2cppRuntimeField_2D0;
        }
        protected virtual void OnTemplateInstanceCreated()
        {
        
        }
        public bool UseSkill(TzarGames.TzarHero.Skills.CharacterSkill skill)
        {
            TzarGames.TzarHero.TH_CharacterTemplate val_4;
            State val_1 = this.CurrentState;
            val_4 = this.characterTemplateInstance;
            TzarGames.TzarHero.Skills.CharacterSkill val_2 = val_4.GetSkillInstance(skill:  skill);
            if(0 == val_2)
            {
                    return false;
            }
            
            return this.tryUseSkill(skillInstance:  val_2);
        }
        private bool tryUseSkill(TzarGames.TzarHero.Skills.CharacterSkill skillInstance)
        {
            System.Delegate val_17;
            System.Object[] val_18;
            TzarGames.GameFramework.TzarRPCModes val_19;
            var val_20;
            if(((skillInstance & 1) & 1) == 0)
            {
                goto label_2;
            }
            
            if((this.GotoState<Skill>(stateData:  skillInstance)) == false)
            {
                goto label_3;
            }
            
            if((this.OnClient == false) || (this.PlayerOwner == null))
            {
                goto label_7;
            }
            
            val_17 = this.PlayerOwner;
            if(val_17.itsMe == false)
            {
                goto label_7;
            }
            
            TzarGames.GameFramework.RPCall<System.Int32> val_7 = null;
            val_17 = val_7;
            val_7 = new TzarGames.GameFramework.RPCall<System.Int32>(object:  this, method:  System.Void TzarGames.TzarHero.TH_Character::server_useSkill(int skillId));
            val_18 = null;
            typeof(System.Object[]).__il2cppRuntimeField_20 = skillInstance.Id;
            typeof(System.Object[]).__il2cppRuntimeField_24 = 268435457;
            val_19 = 5;
            goto label_24;
            label_2:
            skillInstance.OnValidationFailed();
            label_3:
            val_20 = 0;
            return (bool)val_20;
            label_7:
            if(this.OnServer == false)
            {
                goto label_15;
            }
            
            if((this.PlayerOwner != null) && (this.PlayerOwner.itsMe != false))
            {
                    TzarGames.GameFramework.RPCall<System.Int32> val_13 = null;
                val_17 = val_13;
                val_13 = new TzarGames.GameFramework.RPCall<System.Int32>(object:  this, method:  System.Void TzarGames.TzarHero.TH_Character::client_useSkill(int skillId));
                val_18 = null;
                typeof(System.Object[]).__il2cppRuntimeField_20 = skillInstance.Id;
                typeof(System.Object[]).__il2cppRuntimeField_24 = 268435457;
                val_19 = 2;
            }
            else
            {
                    TzarGames.GameFramework.RPCall<System.Int32> val_15 = null;
                val_17 = val_15;
                val_15 = new TzarGames.GameFramework.RPCall<System.Int32>(object:  this, method:  System.Void TzarGames.TzarHero.TH_Character::client_useSkill(int skillId));
                val_18 = null;
                typeof(System.Object[]).__il2cppRuntimeField_20 = skillInstance.Id;
                typeof(System.Object[]).__il2cppRuntimeField_24 = 268435457;
                val_19 = 4;
            }
            
            label_24:
            this.RPC(methodDelegate:  val_17, rpcMode:  val_19, parameters:  val_18);
            label_15:
            val_20 = 1;
            return (bool)val_20;
        }
        [TzarRPC]
        protected void server_useSkill(int skillId)
        {
            if(this.checkClientAuthority() == false)
            {
                    return;
            }
            
            bool val_3 = this.tryUseSkill(skillInstance:  this.characterTemplateInstance.GetSkillInstanceById(id:  skillId));
        }
        [TzarRPC]
        protected void client_useSkill(int skillId)
        {
            if(this.checkClientAuthority() == false)
            {
                    return;
            }
            
            bool val_3 = this.tryUseSkill(skillInstance:  this.characterTemplateInstance.GetSkillInstanceById(id:  skillId));
        }
        public void SendSkillNetMessage(int skillId, byte messageCode, TzarGames.GameFramework.TzarRPCModes mode, object[] parameters)
        {
            System.Object[] val_3;
            int val_4;
            System.Object[] val_5;
            System.Delegate val_6;
            TzarGames.GameFramework.TzarRPCModes val_7;
            System.Object[] val_8;
            val_3 = parameters;
            val_4 = skillId;
            if((val_3 != null) && (parameters.Length != 0))
            {
                    TzarGames.GameFramework.RPCall<System.Int32, System.Byte, System.Object[]> val_1 = null;
                val_5 = val_1;
                val_1 = new TzarGames.GameFramework.RPCall<System.Int32, System.Byte, System.Object[]>(object:  this, method:  System.Void TzarGames.TzarHero.TH_Character::skill_net_message(int skillId, byte messageCode, object[] parameters));
                val_4 = val_4;
                typeof(System.Object[]).__il2cppRuntimeField_20 = val_4;
                typeof(System.Object[]).__il2cppRuntimeField_24 = 268435457;
                typeof(System.Object[]).__il2cppRuntimeField_28 = messageCode;
                typeof(System.Object[]).__il2cppRuntimeField_29 = 27034784;
                typeof(System.Object[]).__il2cppRuntimeField_30 = val_3;
                val_6 = val_5;
                val_7 = mode;
                val_8 = null;
            }
            else
            {
                    TzarGames.GameFramework.RPCall<System.Int32, System.Byte> val_2 = null;
                val_3 = val_2;
                val_2 = new TzarGames.GameFramework.RPCall<System.Int32, System.Byte>(object:  this, method:  System.Void TzarGames.TzarHero.TH_Character::skill_net_message_parameterless(int skillId, byte messageCode));
                val_5 = null;
                typeof(System.Object[]).__il2cppRuntimeField_20 = val_4;
                typeof(System.Object[]).__il2cppRuntimeField_24 = 268435457;
                typeof(System.Object[]).__il2cppRuntimeField_28 = messageCode;
                typeof(System.Object[]).__il2cppRuntimeField_29 = 27034816;
                val_6 = val_3;
                val_7 = mode;
                val_8 = val_5;
            }
            
            this.RPC(methodDelegate:  val_6, rpcMode:  val_7, parameters:  val_8);
        }
        [TzarRPC]
        protected void skill_net_message_parameterless(int skillId, byte messageCode)
        {
            this.skill_net_message(skillId:  skillId, messageCode:  messageCode, parameters:  0);
        }
        [TzarRPC]
        protected void skill_net_message(int skillId, byte messageCode, object[] parameters)
        {
            TzarGames.TzarHero.Skills.CharacterSkill val_1 = this.characterTemplateInstance.GetSkillInstanceById(id:  skillId);
            if(0 == val_1)
            {
                    string val_3 = 0 + "Skill not found, id: "("Skill not found, id: ");
                UnityEngine.Debug.Log(message:  0);
                return;
            }
            
            if(val_1 == null)
            {
                
            }
        
        }
        public static System.Collections.Generic.List<TzarGames.TzarHero.TH_Character> get_AllCharacters()
        {
            System.Collections.Generic.List<TzarGames.TzarHero.TH_Character> val_5;
            var val_6;
            var val_7;
            var val_8;
            var val_9;
            val_6 = null;
            val_6 = null;
            if(TzarGames.TzarHero.TH_Character.allCharsListInitialized != true)
            {
                    System.Type val_1 = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle());
                val_5 = null;
                val_5 = new System.Collections.Generic.List<TzarGames.TzarHero.TH_Character>(collection:  UnityEngine.Object.FindObjectsOfType(type:  0));
                val_7 = null;
                val_7 = null;
                TzarGames.TzarHero.TH_Character.allCharacters = val_5;
                val_8 = null;
                if(null == 0)
            {
                    System.Collections.Generic.List<TzarGames.TzarHero.TH_Character> val_4 = null;
                val_5 = val_4;
                val_4 = new System.Collections.Generic.List<TzarGames.TzarHero.TH_Character>();
                val_9 = null;
                val_9 = null;
                TzarGames.TzarHero.TH_Character.allCharacters = val_5;
                val_8 = null;
            }
            
                val_8 = null;
                TzarGames.TzarHero.TH_Character.allCharsListInitialized = true;
                val_6 = null;
            }
            
            val_6 = null;
            return (System.Collections.Generic.List<TzarGames.TzarHero.TH_Character>)TzarGames.TzarHero.TH_Character.allCharacters;
        }
        public bool get_AllowLocalControl()
        {
            return (bool)this.allowLocalControl;
        }
        public override void SetPlayerOwner(TzarGames.GameFramework.Player player)
        {
            TzarGames.GameFramework.Player val_9;
            var val_10;
            var val_11;
            TzarGames.GameFramework.ICharacterMovement val_12;
            var val_13;
            val_9 = player;
            val_10 = this;
            val_11 = 0;
            this.SetPlayerOwner(player:  val_9);
            val_12 = this.movement;
            if(val_12 == null)
            {
                    val_12 = this.GetComponent<TzarGames.GameFramework.ICharacterMovement>();
                this.movement = val_12;
                if(val_12 == null)
            {
                    return;
            }
            
            }
            
            var val_9 = 0;
            val_9 = val_9 + 1;
            val_11 = 18;
            val_13 = val_12;
            val_9 = ???;
            val_10 = ???;
        }
        public TzarGames.TzarHero.TH_InteractiveObject get_Target()
        {
            return (TzarGames.TzarHero.TH_InteractiveObject)this.targetObject;
        }
        public void set_Target(TzarGames.TzarHero.TH_InteractiveObject value)
        {
            this.targetObject = value;
        }
        public TzarGames.GameFramework.ICharacterMovement get_Movement()
        {
            return (TzarGames.GameFramework.ICharacterMovement)this.movement;
        }
        public TzarGames.TzarHero.CharacterAnimationBase get_Animation()
        {
            return (TzarGames.TzarHero.CharacterAnimationBase)this.characterAnimation;
        }
        public void set_Animation(TzarGames.TzarHero.CharacterAnimationBase value)
        {
            this.characterAnimation = value;
        }
        public bool get_IsMovingOnPath()
        {
            var val_2;
            if(this.pathResult == null)
            {
                    return false;
            }
            
            var val_2 = 0;
            val_2 = val_2 + 1;
            val_2 = this.pathResult;
        }
        public float get_ActualHealth()
        {
            if(this.characterTemplateInstance != null)
            {
                    return this.characterTemplateInstance.ActualHitPoints;
            }
            
            return this.characterTemplateInstance.ActualHitPoints;
        }
        public float get_BaseHealth()
        {
            if(this.characterTemplateInstance != null)
            {
                    return this.characterTemplateInstance.HitPoints;
            }
            
            return this.characterTemplateInstance.HitPoints;
        }
        public uint get_XP()
        {
            if(this.characterTemplateInstance != null)
            {
                    return this.characterTemplateInstance.XP;
            }
            
            return this.characterTemplateInstance.XP;
        }
        public bool get_XpCollectEanbled()
        {
            return (bool)this.xpCollectEnabled;
        }
        public void set_XpCollectEanbled(bool value)
        {
            this.xpCollectEnabled = value;
        }
        public bool get_isDead()
        {
            return (bool)this._characterIsDead;
        }
        public bool get_IsAttacking()
        {
            var val_3;
            State val_1 = this.CurrentState;
            val_3 = 0;
            return (bool);
        }
        public UnityEngine.Vector3 get_Velocity()
        {
            var val_2;
            var val_2 = 0;
            val_2 = val_2 + 1;
            val_2 = this.movement;
        }
        public TzarGames.TzarHero.SimpleMeleeCombatSystem get_MeleeCombatSystem()
        {
            return (TzarGames.TzarHero.SimpleMeleeCombatSystem)this.meleeCombatSystem;
        }
        private void set_MeleeCombatSystem(TzarGames.TzarHero.SimpleMeleeCombatSystem value)
        {
            this.meleeCombatSystem = value;
        }
        public TzarGames.TzarHero.SimpleRangeCombatSystem get_RangeCombatSystem()
        {
            return (TzarGames.TzarHero.SimpleRangeCombatSystem)this.rangeCombatSystem;
        }
        private void set_RangeCombatSystem(TzarGames.TzarHero.SimpleRangeCombatSystem value)
        {
            this.rangeCombatSystem = value;
        }
        public TzarGames.GameFramework.ItemInstance GetActiveWeaponInstance(int slot)
        {
            TzarGames.GameFramework.ItemInstance val_1 = 0;
            return (TzarGames.GameFramework.ItemInstance)((this.activeWeaponInstances.TryGetValue(key:  slot, value: out  val_1)) != true) ? (val_1) : 0;
        }
        public TzarGames.GameFramework.Weapon GetActiveWeaponTemplate(int slot)
        {
            var val_4;
            TzarGames.GameFramework.ItemInstance val_1 = this.GetActiveWeaponInstance(slot:  slot);
            if(val_1 != null)
            {
                    val_4 = 0;
                if(val_1.GetTemplateInstance() == null)
            {
                    return (TzarGames.GameFramework.Weapon);
            }
            
            }
            
            val_4 = 0;
            return (TzarGames.GameFramework.Weapon);
        }
        public TzarGames.GameFramework.Weapon get_ActiveWeaponTemplate()
        {
            return this.GetActiveWeaponTemplate(slot:  0);
        }
        public void SetActiveWeaponInstance(TzarGames.GameFramework.ItemInstance weaponInstance, int slot)
        {
            TzarGames.GameFramework.ItemInstance val_1 = 0;
            bool val_2 = this.activeWeaponInstances.TryGetValue(key:  slot, value: out  val_1);
            if(val_1 == weaponInstance)
            {
                    return;
            }
            
            TzarGames.GameFramework.Item val_3 = weaponInstance.GetTemplateInstance();
            this = 0 + "Trying to set active weapon instance, but target item is not weapon - "("Trying to set active weapon instance, but target item is not weapon - ");
            UnityEngine.Debug.LogError(message:  0);
        }
        public void DeactivateWeaponInstance(TzarGames.GameFramework.ItemInstance weaponInstance, int slot)
        {
            TzarGames.GameFramework.ItemInstance val_4 = weaponInstance;
            TzarGames.GameFramework.ItemInstance val_1 = 0;
            if((this.activeWeaponInstances.TryGetValue(key:  slot, value: out  val_1)) == false)
            {
                    return;
            }
            
            if((this.characterTemplateInstance.IsItemActivated(item:  val_4 = weaponInstance)) != false)
            {
                    if((this.characterTemplateInstance & 1) == 0)
            {
                    return;
            }
            
            }
            
            if(val_1 == 0)
            {
                    return;
            }
            
            if(val_1 != val_4)
            {
                    return;
            }
            
            val_4 = this.activeWeaponInstances;
            val_4.set_Item(key:  slot, value:  0);
        }
        protected virtual void OnActiveWeaponInstanceChanged(TzarGames.GameFramework.ItemInstance weaponInstance, bool activated, int slot)
        {
        
        }
        protected virtual void OnItemActivated(TzarGames.GameFramework.ItemInstance itemInstance, TzarGames.TzarHero.ItemActivationInfo info)
        {
            var val_16;
            var val_17;
            System.Delegate val_18;
            System.Object[] val_19;
            string val_20;
            var val_21;
            if(itemInstance.GetOriginalTemplate() != null)
            {
                    if(info != null)
            {
                    val_16 = info.IsActive;
                val_17 = info;
            }
            else
            {
                    val_16 = 0.IsActive;
                val_17 = 0;
            }
            
                int val_4 = val_17.Slot;
                if(val_16 != false)
            {
                    this.SetActiveWeaponInstance(weaponInstance:  itemInstance, slot:  val_4);
            }
            else
            {
                    this.DeactivateWeaponInstance(weaponInstance:  itemInstance, slot:  val_4);
            }
            
            }
            
            if(this.PlayerOwner == null)
            {
                    return;
            }
            
            if(this.PlayerOwner.itsMe == false)
            {
                    return;
            }
            
            string val_8 = UnityEngine.JsonUtility.ToJson(obj:  0);
            if(this.OnServer != false)
            {
                    TzarGames.GameFramework.RPCall<System.String, System.String> val_10 = null;
                val_18 = val_10;
                val_10 = new TzarGames.GameFramework.RPCall<System.String, System.String>(object:  this, method:  typeof(TzarGames.TzarHero.TH_Character).__il2cppRuntimeField_318);
                val_19 = null;
                val_20 = itemInstance.GetInstanceID();
                typeof(System.Object[]).__il2cppRuntimeField_20 = val_20;
                typeof(System.Object[]).__il2cppRuntimeField_28 = val_8;
                val_21 = 2;
            }
            else
            {
                    if(this.OnClient == false)
            {
                    return;
            }
            
                TzarGames.GameFramework.RPCall<System.String, System.String> val_13 = null;
                val_18 = val_13;
                val_13 = new TzarGames.GameFramework.RPCall<System.String, System.String>(object:  this, method:  typeof(TzarGames.TzarHero.TH_Character).__il2cppRuntimeField_308);
                val_19 = null;
                val_20 = itemInstance.GetInstanceID();
                typeof(System.Object[]).__il2cppRuntimeField_20 = val_20;
                typeof(System.Object[]).__il2cppRuntimeField_28 = val_8;
                val_21 = 5;
            }
            
            this.RPC(methodDelegate:  val_18, rpcMode:  5, parameters:  val_19);
        }
        private bool tryToActivateItem(string instanceId, TzarGames.TzarHero.ItemActivationInfo info)
        {
            var val_7;
            if((this.characterTemplateInstance.Inventory.GetItemInstanceByID(id:  instanceId)) == null)
            {
                    return false;
            }
            
            if(info != null)
            {
                    val_7 = info.IsActive;
            }
            else
            {
                    val_7 = 0.IsActive;
            }
            
            int val_5 = info.Slot;
            bool val_6 = val_7;
            goto typeof(TzarGames.TzarHero.TH_CharacterTemplate).__il2cppRuntimeField_1F0;
        }
        [TzarRPC]
        protected virtual void server_activateItem(string instanceId, string serializedInfo)
        {
            var val_6;
            string val_12;
            var val_13;
            val_12 = serializedInfo;
            EncodedData val_1 = UnityEngine.JsonUtility.FromJson<EncodedData>(json:  0);
            if(val_1 == null)
            {
                goto label_1;
            }
            
            if((this.tryToActivateItem(instanceId:  instanceId, info:  val_1)) == false)
            {
                    return;
            }
            
            TzarGames.GameFramework.Player val_3 = this.PlayerOwner;
            List.Enumerator<T> val_4 = val_3.NeighbourPlayers.GetEnumerator();
            do
            {
                label_17:
                if((0 & 1) == 0)
            {
                goto label_21;
            }
            
                System.Action<GooglePlayGames.BasicApi.Nearby.InitializationStatus> val_7 = val_6.InitializationCallback;
            }
            while(val_7.itsMe == true);
            
            TzarGames.GameFramework.RPCall<System.String, System.String> val_10 = new TzarGames.GameFramework.RPCall<System.String, System.String>(object:  this, method:  typeof(TzarGames.TzarHero.TH_Character).__il2cppRuntimeField_318);
            typeof(System.Object[]).__il2cppRuntimeField_20 = instanceId;
            typeof(System.Object[]).__il2cppRuntimeField_28 = val_12;
            this.RPC(methodDelegate:  null, target:  val_7, parameters:  null);
            goto label_17;
            label_21:
            val_6.Dispose();
            if((0 & 1) != 0)
            {
                    return;
            }
            
            if(null == null)
            {
                    return;
            }
            
            return;
            label_1:
            System.ArgumentNullException val_11 = new System.ArgumentNullException();
            val_13 = null;
            if((System.Void TzarGames.TzarHero.TH_Character::server_activateItem(string instanceId, string serializedInfo)) == 1)
            {
                    if((null & 1) != 0)
            {
                    return;
            }
            
                mem[8] = null;
                val_13 = 8;
            }
        
        }
        [TzarRPC]
        protected virtual void client_activateItem(string instanceId, string serializedInfo)
        {
            if(this.checkClientAuthority() == false)
            {
                    return;
            }
            
            bool val_3 = this.tryToActivateItem(instanceId:  instanceId, info:  UnityEngine.JsonUtility.FromJson<EncodedData>(json:  0));
        }
        public UnityEngine.CharacterController get_CharController()
        {
            return (UnityEngine.CharacterController)this.characterController;
        }
        public void SetFallen(bool fallen)
        {
            var val_1 = (this._fallen == true) ? 1 : 0;
            val_1 = val_1 ^ fallen;
            if(val_1 == false)
            {
                    return;
            }
            
            this._fallen = fallen;
        }
        public bool get_Fallen()
        {
            return (bool)this._fallen;
        }
        public float get_MaxMoveSpeed()
        {
            if(this.characterTemplateInstance != null)
            {
                    return this.characterTemplateInstance.WalkingSpeed;
            }
            
            return this.characterTemplateInstance.WalkingSpeed;
        }
        public uint get_Level()
        {
            if(this.characterTemplateInstance != null)
            {
                    return this.characterTemplateInstance.Level;
            }
            
            return this.characterTemplateInstance.Level;
        }
        public void set_Level(uint value)
        {
            this.setXP(amount:  TzarGames.GameFramework.CharacterTemplate.GetXpToLevel(level:  0), generateEvents:  false);
        }
        public void ChangeXPBy(int amount)
        {
            this.characterTemplateInstance.ChangeXpBy(amount:  amount);
            this.checkLevelAndXpEvents(prevLvl:  this.characterTemplateInstance.Level, prevXp:  this.characterTemplateInstance.XP);
        }
        protected void setXP(uint amount, bool generateEvents)
        {
            if(0 == this.characterTemplateInstance)
            {
                    UnityEngine.Debug.LogError(message:  0);
                return;
            }
            
            this.characterTemplateInstance.XP = amount;
            if(generateEvents == false)
            {
                    return;
            }
            
            this.checkLevelAndXpEvents(prevLvl:  this.characterTemplateInstance.Level, prevXp:  this.characterTemplateInstance.XP);
        }
        private void checkLevelAndXpEvents(uint prevLvl, uint prevXp)
        {
            var val_9;
            TzarGames.TzarHero.TH_CharacterTemplate val_10;
            val_9 = this;
            uint val_1 = this.characterTemplateInstance.XP;
            val_10 = this.characterTemplateInstance;
            if(val_10.Level <= prevLvl)
            {
                    return;
            }
            
            val_9 = ???;
            val_10 = ???;
            goto typeof(TzarGames.TzarHero.TH_Character).__il2cppRuntimeField_330;
        }
        protected override void OnSetPosition(UnityEngine.Vector3 position)
        {
            var val_2;
            var val_2 = 0;
            val_2 = val_2 + 1;
            val_2 = this.movement;
        }
        protected virtual void OnXpChanged()
        {
        
        }
        protected virtual void OnLevelUp()
        {
        
        }
        private void OnXpChangedEvent(TzarGames.GameFramework.CharacterTemplate template, int difference)
        {
            if(this.OnServer == false)
            {
                    return;
            }
            
            typeof(System.Object[]).__il2cppRuntimeField_20 = template.XP;
            typeof(System.Object[]).__il2cppRuntimeField_24 = 268435457;
            this.RPC(methodDelegate:  new TzarGames.GameFramework.RPCall<System.UInt32>(object:  this, method:  System.Void TzarGames.TzarHero.TH_Character::client_xpChanged(uint serverXP)), rpcMode:  2, parameters:  null);
        }
        private void OnLevelUpEvent(TzarGames.GameFramework.CharacterTemplate template)
        {
            if(this.OnCharacterLevelUp == null)
            {
                    return;
            }
            
            this.OnCharacterLevelUp.Invoke(character:  this);
        }
        [TzarRPC]
        protected void client_xpChanged(uint serverXP)
        {
            if(this.checkClientAuthority() == false)
            {
                    return;
            }
            
            this.characterTemplateInstance.XP = serverXP;
        }
        protected override void Awake()
        {
            this.Awake();
            mem2[0] = this.canBeAttacked;
            mem[1152921511534082548] = ???;
            this.ignoreDamage_runtime = new TzarGames.GameFramework.BooleanCharacteristic();
            CodeStage.AntiCheat.ObscuredTypes.ObscuredBool val_8 = this.ignoreDamage;
            val_8 = CodeStage.AntiCheat.ObscuredTypes.ObscuredBool.op_Implicit(value:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredBool() {inited = val_8, fakeValue = val_8, fakeValueActive = val_8});
            BaseValue = val_8;
            if(0 != this.characterTemplate)
            {
                    if(0 == this.characterTemplateInstance)
            {
                    this.CreateCharacterTemplateInstance();
            }
            
            }
            
            if(0 == this.characterTemplateInstance)
            {
                    return;
            }
            
            if(this.characterTemplateInstance.IsInitialized != false)
            {
                    return;
            }
            
            if(this.characterTemplateInstance == null)
            {
                
            }
        
        }
        protected override void Init()
        {
            TzarGames.GameFramework.ICharacterMovement val_37;
            IntPtr val_38;
            var val_39;
            float val_41;
            float val_42;
            var val_43;
            var val_44;
            TzarGames.TzarHero.SimpleMeleeCombatSystem val_45;
            TzarGames.TzarHero.SimpleRangeCombatSystem val_46;
            val_37 = this.movement;
            this.characterController = this.gameObject.GetComponent<UnityEngine.CharacterController>();
            if(val_37 != null)
            {
                goto label_2;
            }
            
            val_37 = this.GetComponent<TzarGames.GameFramework.ICharacterMovement>();
            this.movement = val_37;
            if(val_37 == null)
            {
                goto label_8;
            }
            
            label_2:
            val_38 = System.Void TzarGames.TzarHero.TH_Character::OnPreMovementUpdate();
            null = new TzarGames.Common.TG_VoidDelegate(object:  this, method:  val_38);
            var val_37 = 0;
            val_37 = val_37 + 1;
            val_38 = 0;
            val_39 = val_37;
            if(this.movement != null)
            {
                    this.pathMovement = this.movement;
            }
            
            label_8:
            if(this.characterTemplateInstance != null)
            {
                    val_41 = this.characterTemplateInstance.HitPoints;
            }
            else
            {
                    val_41 = this.characterTemplateInstance.HitPoints;
            }
            
            val_42 = val_41;
            this.characterTemplateInstance.ActualHitPoints = val_42;
            UnityEngine.Quaternion val_9 = this.transform.rotation;
            mem[1152921511534337896] = val_9.w;
            this.desiredRotation = val_9;
            mem[1152921511534337888] = val_9.y;
            mem[1152921511534337892] = val_9.z;
            if((0 != this.pathfinder) && (this.movement != null))
            {
                    var val_38 = 0;
                val_38 = val_38 + 1;
                val_43 = this.movement;
                val_41 = val_9.x;
                var val_39 = 0;
                val_39 = val_39 + 1;
                val_44 = this.movement;
                val_42 = val_41;
            }
            
            if(0 == this.meleeCombatSystem)
            {
                    val_45 = this.GetComponent<TzarGames.TzarHero.SimpleMeleeCombatSystem>();
                this.meleeCombatSystem = val_45;
            }
            else
            {
                    val_45 = this.meleeCombatSystem;
            }
            
            if(0 != val_45)
            {
                    this.meleeCombatSystem.Owner = this;
            }
            
            if(0 == this.rangeCombatSystem)
            {
                    val_46 = this.GetComponent<TzarGames.TzarHero.SimpleRangeCombatSystem>();
                this.rangeCombatSystem = val_46;
            }
            else
            {
                    val_46 = this.rangeCombatSystem;
            }
            
            if(0 != val_46)
            {
                    this.rangeCombatSystem.Owner = this;
            }
            
            if(this.characterTemplateInstance.ActualHitPoints <= 0f)
            {
                    string val_22 = this.name;
                string val_23 = 0 + "Dead during initialization ";
                UnityEngine.Debug.Log(message:  0);
                UnityEngine.Vector3 val_24 = UnityEngine.Vector3.zero;
                val_41 = val_24.x;
                typeof(TzarGames.TzarHero.TH_DamageType_Default).__il2cppRuntimeField_10 = TzarGames.GameFramework.SurfaceTypeBase.Default;
                bool val_28 = this.GotoState<Dead>(stateData:  new TzarGames.TzarHero.DeadEventData(killer:  0, victim:  this, force:  new UnityEngine.Vector3() {x = val_41, y = val_24.y, z = val_24.z}, damageType:  new System.Object()));
            }
            
            if(this.OnSpawn != null)
            {
                    this.OnSpawn.Invoke(character:  this);
            }
            
            if((TzarGames.TzarHero.TH_Character.AllCharacters.Contains(item:  this)) != true)
            {
                    TzarGames.TzarHero.TH_Character.AllCharacters.Add(item:  this);
            }
            
            this.SubscribeToTemplateEvents();
            if(TzarGames.GameFramework.ApplicationManager.IsBatchMode == true)
            {
                    return;
            }
            
            if(0 != this.audioSource)
            {
                    return;
            }
            
            this.audioSource = this.GetComponent<UnityEngine.AudioSource>();
        }
        public override float GetRadius()
        {
            if(0 == this.characterController)
            {
                    return (float)this.DefaultRadius;
            }
            
            float val_2 = this.characterController.radius;
            val_2 = val_2 * this.radiusScale;
            return (float)this.DefaultRadius;
        }
        public float GetAttackRadius()
        {
            if(0 != (this.GetActiveWeaponTemplate(slot:  0)))
            {
                    TzarGames.GameFramework.Weapon val_3 = this.GetActiveWeaponTemplate(slot:  0);
                if(val_3 != null)
            {
                    return val_3.AttackRange;
            }
            
                return val_3.AttackRange;
            }
        
        }
        private void OnDrawGizmos()
        {
        
        }
        public void SetDesiredRotationToPosition(UnityEngine.Vector3 position)
        {
            UnityEngine.Vector3 val_1 = position;
            UnityEngine.Vector3 val_2 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = position.x, y = position.y, z = position.z}, b:  new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = val_1.z});
            this.SetDesiredRotationDirection(dir:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z});
        }
        public void SetDesiredRotationDirection(UnityEngine.Vector3 dir)
        {
            UnityEngine.Vector3 val_1 = UnityEngine.Vector3.zero;
            if((UnityEngine.Vector3.op_Inequality(lhs:  new UnityEngine.Vector3() {x = dir.x, y = 0f, z = dir.z}, rhs:  new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = val_1.z})) == false)
            {
                    return;
            }
            
            UnityEngine.Quaternion val_3 = UnityEngine.Quaternion.LookRotation(forward:  new UnityEngine.Vector3() {x = dir.x, y = 0f, z = dir.z});
            this.desiredRotation = val_3;
            mem[1152921511535049440] = val_3.y;
            mem[1152921511535049444] = val_3.z;
            mem[1152921511535049448] = val_3.w;
        }
        public UnityEngine.Vector3 GetDesiredRotationDirection()
        {
            UnityEngine.Vector3 val_1 = UnityEngine.Vector3.forward;
            return UnityEngine.Quaternion.op_Multiply(rotation:  new UnityEngine.Quaternion() {x = this.desiredRotation, y = V11.16B, z = V10.16B, w = V9.16B}, point:  new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = val_1.z});
        }
        public float GetDesiredYaw()
        {
            return (float)V1.16B;
        }
        public void SetDesiredYaw(float yaw)
        {
            UnityEngine.Quaternion val_1 = UnityEngine.Quaternion.Euler(euler:  new UnityEngine.Vector3() {x = yaw, y = yaw, z = V2.16B});
            mem[1152921511535385448] = val_1.w;
            this.desiredRotation = val_1;
            mem[1152921511535385440] = val_1.y;
            mem[1152921511535385444] = val_1.z;
        }
        public void ForceRotateToDesiredRotation()
        {
            var val_3;
            UnityEngine.Quaternion val_4;
            val_3 = this;
            if(0 != this.rotationBody)
            {
                    val_4 = this.desiredRotation;
                if(this.rotationBody != null)
            {
                goto label_5;
            }
            
            }
            else
            {
                    val_4 = this.desiredRotation;
                val_3 = this.transform;
            }
            
            label_5:
            val_3.rotation = new UnityEngine.Quaternion() {x = val_4, y = V9.16B, z = V10.16B, w = V11.16B};
        }
        private void onPathCalculationComplete(TzarGames.GameFramework.IPathResult result)
        {
            var val_5;
            this.currentWaypoint = 0;
            this.pathResult = result;
            if(this.CurrentState == null)
            {
                    return;
            }
            
            val_5 = 1152921504922234880;
        }
        public bool GoToPosition(UnityEngine.Vector3 targetPosition, System.Action<TzarGames.TzarHero.TH_Character, bool> reachPositionHandler, float stoppingDistance = 0)
        {
            TzarGames.GameFramework.IPathMovementHandler val_8;
            IntPtr val_9;
            IntPtr val_10;
            var val_11;
            var val_12;
            State val_1 = this.CurrentState;
            State val_2 = this.CurrentState;
            bool val_3 = this.GotoState<Moving>(stateData:  0);
            val_8 = this.pathMovement;
            if(val_8 == null)
            {
                goto label_7;
            }
            
            val_9 = System.Void TzarGames.TzarHero.TH_Character::onPathCalculationComplete(TzarGames.GameFramework.IPathResult result);
            val_10 = val_9;
            null = new System.Action<TzarGames.GameFramework.IPathResult>(object:  this, method:  val_10);
            var val_8 = 0;
            val_8 = val_8 + 1;
            val_10 = 0;
            val_11 = val_8;
            goto label_11;
            label_7:
            val_8 = this.pathfinder;
            UnityEngine.Vector3 val_5 = this.GroundPivotPosition;
            val_9 = System.Void TzarGames.TzarHero.TH_Character::onPathCalculationComplete(TzarGames.GameFramework.IPathResult result);
            UnityEngine.Events.UnityAction<TzarGames.GameFramework.IPathResult> val_6 = new UnityEngine.Events.UnityAction<TzarGames.GameFramework.IPathResult>(object:  this, method:  val_9);
            if((val_8 & 1) != 0)
            {
                goto label_13;
            }
            
            val_12 = 0;
            return (bool)val_12;
            label_11:
            label_13:
            if(this.reachPositionResultHandler != null)
            {
                    this.reachPositionResultHandler.Invoke(arg1:  this, arg2:  false);
            }
            
            val_12 = 1;
            this.reachPositionResultHandler = reachPositionHandler;
            return (bool)val_12;
        }
        [TzarRPC]
        private void client_cancelMoveToPosition()
        {
            if(this.checkClientAuthority() == false)
            {
                    return;
            }
            
            this.StopMove();
        }
        [TzarRPC]
        protected void server_GoToPosition(UnityEngine.Vector3 pos, float stoppingDistance)
        {
            if((this.GoToPosition(targetPosition:  new UnityEngine.Vector3() {x = pos.x, y = pos.y, z = pos.z}, reachPositionHandler:  0, stoppingDistance:  stoppingDistance)) != false)
            {
                    return;
            }
            
            this.RPC(methodDelegate:  new TzarGames.GameFramework.RPCall_VOID(object:  this, method:  System.Void TzarGames.TzarHero.TH_Character::client_cancelMoveToPosition()), rpcMode:  2, parameters:  null);
        }
        private void goToPositionComplete()
        {
            if(((0 != TzarGames.GameFramework.GameManager.Instance.Net) && (TzarGames.GameFramework.GameManagerNetSyncBase.Connected != false)) && (TzarGames.GameFramework.GameManagerNetSyncBase.IsServer != false))
            {
                    if(0 != this.MyNetworkView)
            {
                    TzarGames.GameFramework.RPCall_VOID val_8 = null;
                1152921504721543168 = val_8;
                val_8 = new TzarGames.GameFramework.RPCall_VOID(object:  this, method:  System.Void TzarGames.TzarHero.TH_Character::client_moveToPositionComplete());
                this.RPC(methodDelegate:  1152921504721543168, rpcMode:  2, parameters:  null);
            }
            
            }
            
            if(this.CurrentState == null)
            {
                    return;
            }
        
        }
        [TzarRPC]
        protected void client_moveToPositionComplete()
        {
            if(this.checkClientAuthority() == false)
            {
                    return;
            }
            
            this = ???;
            goto typeof(TzarGames.TzarHero.TH_Character).__il2cppRuntimeField_340;
        }
        protected virtual void OnCompleteMovingToPosition()
        {
            if(this.reachPositionResultHandler == null)
            {
                    return;
            }
            
            this.reachPositionResultHandler = 0;
            this.reachPositionResultHandler.Invoke(arg1:  this, arg2:  true);
        }
        public bool IsUsingSkill()
        {
            var val_3;
            State val_1 = this.CurrentState;
            val_3 = 0;
            return (bool);
        }
        public void ExecuteAfterCurrentAttackEnd(System.Action callback)
        {
            if(this.IsAttacking == false)
            {
                    return;
            }
            
            this.callbacksToExecuteAfterAttack.Add(item:  callback);
        }
        protected virtual void StartAnimBasedAttack()
        {
            this.targetObject = 0;
            this.animBasedCombatSystem.StartAttackWithNextAnimation(weapon:  this.GetActiveWeaponTemplate(slot:  0), speedScale:  this.characterTemplateInstance.AttackSpeed, target:  this.targetObject);
        }
        public bool isCharacterValidForAttack(TzarGames.TzarHero.TH_Character character)
        {
            if(0 == character)
            {
                    return false;
            }
            
            if(character._characterIsDead == false)
            {
                    return CodeStage.AntiCheat.ObscuredTypes.ObscuredBool.op_Implicit(value:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredBool() {inited = character.canBeAttacked_runtime.currentCryptoKey, fakeValue = character.canBeAttacked_runtime.currentCryptoKey, fakeValueActive = character.canBeAttacked_runtime.currentCryptoKey});
            }
            
            return false;
        }
        public float get_AttackPerSecond()
        {
            float val_1 = this.characterTemplateInstance.AttackSpeed;
            val_1 = 1f / val_1;
            return (float)val_1;
        }
        protected void setAttackDirection(UnityEngine.Vector3 direction)
        {
            this.attackDirection = direction;
            mem[1152921511537181024] = direction.y;
            mem[1152921511537181028] = direction.z;
        }
        public bool UseWeaponOnce(TzarGames.GameFramework.ItemInstance weapon, UnityEngine.Vector3 newAttackDirection)
        {
            UnityEngine.Object val_7;
            State val_1 = this.CurrentState;
            val_7 = this.characterTemplateInstance.Inventory;
            if(((val_7.IsItemInstanceStoredInAnyBag(instance:  weapon)) == false) || ((this & 1) == 0))
            {
                    return false;
            }
            
            val_7 = weapon.GetTemplateInstance();
            bool val_6 = UnityEngine.Object.op_Equality(x:  0, y:  val_7);
            return false;
        }
        public bool UseWeaponOnce(TzarGames.GameFramework.ItemInstance weapon)
        {
            return this.UseWeaponOnce(weapon:  weapon, newAttackDirection:  new UnityEngine.Vector3() {x = this.attackDirection});
        }
        public TzarGames.TzarHero.TH_Character TryFindTargetForAttack()
        {
            float val_1 = this.GetAttackRadius();
            val_1 = val_1 + this._minDistanceToWaypoint;
            return this.TryFindTargetForAttack(radius:  val_1);
        }
        public TzarGames.TzarHero.TH_Character TryFindTargetForAttack(float radius)
        {
            var val_24;
            float val_25;
            UnityEngine.Object val_26;
            float val_27;
            TzarGames.GameFramework.CharacterGroup val_28;
            var val_29;
            val_25 = radius;
            val_26 = 0;
            if(this._characterIsDead == true)
            {
                    return (TzarGames.TzarHero.TH_Character)val_26;
            }
            
            val_24 = this.GetOtherCharactersInRadius(radius:  val_25);
            TzarGames.GameFramework.CharacterGroup val_2 = this.characterTemplateInstance.Group;
            val_26 = 0;
            if(val_24 == null)
            {
                    return (TzarGames.TzarHero.TH_Character)val_26;
            }
            
            if(val_24.Count >= 1)
            {
                    val_26 = 0;
                if(val_24.Count >= 1)
            {
                    val_27 = -1f;
                do
            {
                TzarGames.TzarHero.TH_Character val_5 = val_24.Item[0];
                if((val_5.isCharacterValidForAttack(character:  val_5)) != false)
            {
                    val_28 = val_5.characterTemplateInstance.Group;
                if((val_2.IsFriendly(group:  val_28)) != true)
            {
                    UnityEngine.Vector3 val_10 = val_28.position;
                UnityEngine.Vector3 val_11 = val_28.position;
                UnityEngine.Vector3 val_12 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_10.x, y = val_10.y, z = val_10.z}, b:  new UnityEngine.Vector3() {x = val_11.x, y = val_11.y, z = val_11.z});
                val_25 = val_12.x;
                val_28 = this.transform;
                UnityEngine.Vector3 val_14 = val_28.forward;
                float val_15 = UnityEngine.Vector3.Dot(lhs:  new UnityEngine.Vector3() {x = val_25, y = val_12.y, z = val_12.z}, rhs:  new UnityEngine.Vector3() {x = val_14.x, y = val_14.y, z = val_14.z});
                if(val_15 > val_27)
            {
                    val_26 = val_5;
                val_27 = val_15;
            }
            
            }
            
            }
            
                val_29 = 0 + 1;
            }
            while(val_29 < val_24.Count);
            
            }
            
                if(0 != val_26)
            {
                    return (TzarGames.TzarHero.TH_Character)val_26;
            }
            
                val_29 = val_18.characterTemplateInstance.Group;
                bool val_20 = val_29.IsFriendly(group:  val_2);
                if(val_20 == true)
            {
                    return (TzarGames.TzarHero.TH_Character)val_26;
            }
            
                if((val_20.isCharacterValidForAttack(character:  val_24.Item[0])) == false)
            {
                    return (TzarGames.TzarHero.TH_Character)val_26;
            }
            
                val_26 = val_24.Item[0];
                return (TzarGames.TzarHero.TH_Character)val_26;
            }
            
            val_26 = 0;
            return (TzarGames.TzarHero.TH_Character)val_26;
        }
        public void UseWeapon()
        {
            State val_1 = this.CurrentState;
            if(0 != this.targetObject)
            {
                    UnityEngine.Vector3 val_3 = this.targetObject.cachedTransform.position;
                UnityEngine.Vector3 val_4 = this.targetObject.cachedTransform.position;
                UnityEngine.Vector3 val_5 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z}, b:  new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z});
            }
            else
            {
                    UnityEngine.Vector3 val_6 = this.GetDesiredRotationDirection();
            }
            
            this.attackDirection = val_6;
            mem[1152921511537896672] = val_6.y;
            mem[1152921511537896676] = val_6.z;
            this.GotoAttackState();
        }
        public void AttackCharacterContinuously(TzarGames.TzarHero.TH_Character character)
        {
            this.bAttackContinuosly = true;
            this.AttackCharacter(character:  character, ignoreAttackRangeCheck:  false);
        }
        public void StopContinuousAttack()
        {
            this.bAttackContinuosly = false;
        }
        public void GotoStateAfterAttack<T>()
        {
            if(this.pendingChangeStateAfterAttack != false)
            {
                    this.CancelPendingState();
            }
            
            this.pendingChangeStateAfterAttack = true;
            this.pendingStateToChangeAfterAttack = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle());
            UnityEngine.Coroutine val_3 = this.StartCoroutine(routine:  this.waitForAttackEndAndChangeState());
        }
        public System.Type GetPendingStateName()
        {
            return (System.Type)this.pendingStateToChangeAfterAttack;
        }
        public void CancelPendingState()
        {
            if(this.pendingChangeStateAfterAttack == false)
            {
                    return;
            }
            
            this.pendingChangeStateAfterAttack = false;
            this.StopCoroutine(routine:  this.waitForAttackEndAndChangeState());
        }
        public bool IsPendingToChangeStateAfterAttack()
        {
            return (bool)this.pendingChangeStateAfterAttack;
        }
        [System.Diagnostics.DebuggerHiddenAttribute]
        private System.Collections.IEnumerator waitForAttackEndAndChangeState()
        {
            typeof(TH_Character.<waitForAttackEndAndChangeState>c__Iterator0).__il2cppRuntimeField_10 = this;
            return (System.Collections.IEnumerator)new System.Object();
        }
        private void checkTarget()
        {
            if(0 == this.targetObject)
            {
                goto label_8;
            }
            
            if(this.targetObject != null)
            {
                    if(((this.targetObject & 255) != null) || (this.targetObject >= 256))
            {
                goto label_8;
            }
            
            }
            
            if(this.bFollowingToAttack == false)
            {
                goto label_10;
            }
            
            float val_3 = this.GetAttackRadius();
            val_3 = val_3 + this._minDistanceToWaypoint;
            if((this.targetObject.IsObjectInRadius(obj:  this.targetObject, radius:  val_3)) == false)
            {
                goto label_10;
            }
            
            if(this.targetObject == null)
            {
                    return;
            }
            
            return;
            label_8:
            this.StopAttack();
            return;
            label_10:
            this.Invoke(methodName:  "checkTarget", time:  0.1f);
        }
        public void StopAttack()
        {
            this.bAttackContinuosly = false;
            bool val_1 = this.GotoState<Moving>(stateData:  0);
        }
        public void AttackCharacter(TzarGames.TzarHero.TH_Character character, bool ignoreAttackRangeCheck = False)
        {
            State val_1 = this.CurrentState;
            if(0 == character)
            {
                    return;
            }
            
            if((UnityEngine.Object.op_Implicit(exists:  0)) == false)
            {
                    return;
            }
            
            if(0 == character)
            {
                    return;
            }
            
            if(character._characterIsDead == true)
            {
                    return;
            }
            
            this.targetObject = character;
            if(ignoreAttackRangeCheck == true)
            {
                goto label_15;
            }
            
            float val_8 = this.GetAttackRadius();
            val_8 = val_8 + this._minDistanceToWaypoint;
            if((character.IsObjectInRadius(obj:  character, radius:  val_8)) == false)
            {
                goto label_16;
            }
            
            label_15:
            UnityEngine.Vector3 val_11 = character.position;
            UnityEngine.Vector3 val_12 = character.position;
            UnityEngine.Vector3 val_13 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_11.x, y = val_11.y, z = val_11.z}, b:  new UnityEngine.Vector3() {x = val_12.x, y = val_12.y, z = val_12.z});
            this.attackDirection = val_13;
            mem[1152921511539127360] = val_13.y;
            mem[1152921511539127364] = val_13.z;
            this.GotoAttackState();
            return;
            label_16:
            if(this.movement == null)
            {
                    return;
            }
            
            this.Follow(character:  character, attack:  true, distance:  0f);
        }
        private void GotoAttackState()
        {
            var val_6;
            object val_7;
            if(0 == (this.GetActiveWeaponTemplate(slot:  0)))
            {
                    UnityEngine.Debug.LogError(message:  0);
                return;
            }
            
            if(this.useAnimBasedCombatSystem != false)
            {
                    val_6 = 1152921511539231360;
                val_7 = 0;
            }
            else
            {
                    val_7 = 0;
                if((this.GetActiveWeaponTemplate(slot:  0).Type) != 0)
            {
                    val_6 = 1152921511539240576;
            }
            else
            {
                    val_6 = 1152921511539241600;
            }
            
            }
            
            bool val_5 = this.GotoState<MeleeAttack>(stateData:  val_7);
        }
        public virtual bool CanUseItemInstance(TzarGames.GameFramework.ItemInstance instance)
        {
            return true;
        }
        public virtual bool CanUseItem(TzarGames.GameFramework.Item item)
        {
            return true;
        }
        public virtual bool UseItem(TzarGames.GameFramework.Item item, TzarGames.GameFramework.ItemInstance instance)
        {
            var val_6;
            var val_7;
            var val_8;
            if((0 == item) || ((this & 1) == 0))
            {
                    return false;
            }
            
            if(instance != null)
            {
                    if((this & 1) == 0)
            {
                    return false;
            }
            
            }
            
            if(item == null)
            {
                    return false;
            }
            
            val_7 = item;
            if(instance != null)
            {
                    val_7 = instance.GetTemplateInstance();
            }
            
            var val_6 = 0;
            val_6 = val_6 + 1;
            val_6 = 0;
            val_8 = val_7;
            TzarGames.GameFramework.Item val_5 = val_7 & 1;
            return false;
        }
        [TzarRPC]
        protected void client_meleeAttack_object(uint id, UnityEngine.Vector3 attackDir)
        {
            UnityEngine.Object val_6;
            if(this.checkClientAuthority() == false)
            {
                    return;
            }
            
            val_6 = TzarGames.TzarHero.TH_InteractiveObject.GetObjectById(id:  317251584);
            if(0 != val_6)
            {
                    this.targetObject = val_6;
            }
            else
            {
                    string val_4 = 0 + "object with this id not found : "("object with this id not found : ");
                UnityEngine.Debug.LogWarning(message:  0);
            }
            
            this.ResetToDefaultState();
            this.attackDirection = attackDir;
            mem[1152921511539780864] = attackDir.y;
            mem[1152921511539780868] = attackDir.z;
            this.SetDesiredRotationDirection(dir:  new UnityEngine.Vector3() {x = attackDir.x, y = attackDir.y, z = attackDir.z});
            bool val_5 = this.GotoState<MeleeAttack>(stateData:  0);
        }
        [TzarRPC]
        protected void client_meleeAttack(UnityEngine.Vector3 attackDir)
        {
            if(this.checkClientAuthority() == false)
            {
                    return;
            }
            
            this.targetObject = 0;
            this.ResetToDefaultState();
            this.attackDirection = attackDir;
            mem[1152921511539905152] = attackDir.y;
            mem[1152921511539905156] = attackDir.z;
            this.SetDesiredRotationDirection(dir:  new UnityEngine.Vector3() {x = attackDir.x, y = attackDir.y, z = attackDir.z});
            bool val_2 = this.GotoState<MeleeAttack>(stateData:  0);
        }
        [TzarRPC]
        protected void client_rangeAttack_object(uint id, UnityEngine.Vector3 attackDir)
        {
            UnityEngine.Object val_6;
            if(this.checkClientAuthority() == false)
            {
                    return;
            }
            
            val_6 = TzarGames.TzarHero.TH_InteractiveObject.GetObjectById(id:  317251584);
            if(0 != val_6)
            {
                    this.targetObject = val_6;
            }
            else
            {
                    string val_4 = 0 + "object with this id not found : "("object with this id not found : ");
                UnityEngine.Debug.LogWarning(message:  0);
            }
            
            this.ResetToDefaultState();
            this.attackDirection = attackDir;
            mem[1152921511540029440] = attackDir.y;
            mem[1152921511540029444] = attackDir.z;
            this.SetDesiredRotationDirection(dir:  new UnityEngine.Vector3() {x = attackDir.x, y = attackDir.y, z = attackDir.z});
            bool val_5 = this.GotoState<MeleeAttack>(stateData:  0);
        }
        [TzarRPC]
        protected void client_rangeAttack(UnityEngine.Vector3 attackDir)
        {
            if(this.checkClientAuthority() == false)
            {
                    return;
            }
            
            this.targetObject = 0;
            this.ResetToDefaultState();
            this.attackDirection = attackDir;
            mem[1152921511540153728] = attackDir.y;
            mem[1152921511540153732] = attackDir.z;
            this.SetDesiredRotationDirection(dir:  new UnityEngine.Vector3() {x = attackDir.x, y = attackDir.y, z = attackDir.z});
            bool val_2 = this.GotoState<MeleeAttack>(stateData:  0);
        }
        [TzarRPC]
        protected void client_rangeAttack_viewid(TzarGames.GameFramework.NetworkViewID viewId, UnityEngine.Vector3 attackDir)
        {
            if(this.checkClientAuthority() == false)
            {
                    return;
            }
            
            if(this.PlayerOwner != null)
            {
                    if(this.PlayerOwner.itsMe != false)
            {
                    this.rangeCombatSystem.SetViewIdForLastProjectile(viewID:  viewId);
                return;
            }
            
            }
            
            this.rangeCombatSystem.useAttackNetViewID = true;
            this.rangeCombatSystem.AttackNetViewID = viewId;
            this.ResetToDefaultState();
            this.attackDirection = attackDir;
            mem[1152921511540290304] = attackDir.y;
            mem[1152921511540290308] = attackDir.z;
            this.SetDesiredRotationDirection(dir:  new UnityEngine.Vector3() {x = attackDir.x, y = attackDir.y, z = attackDir.z});
            bool val_5 = this.GotoState<RangeAttack>(stateData:  0);
        }
        [TzarRPC]
        protected void client_rangeAttack_viewid_object(TzarGames.GameFramework.NetworkViewID viewId, uint id, UnityEngine.Vector3 attackDir)
        {
            TzarGames.GameFramework.NetworkViewID val_6 = viewId;
            if(this.checkClientAuthority() == false)
            {
                    return;
            }
            
            this.rangeCombatSystem.useAttackNetViewID = true;
            this.rangeCombatSystem.AttackNetViewID = val_6;
            this.ResetToDefaultState();
            val_6 = TzarGames.TzarHero.TH_InteractiveObject.GetObjectById(id:  317251584);
            if(0 != val_6)
            {
                    this.targetObject = val_6;
            }
            else
            {
                    string val_4 = 0 + "Failed to find object with id: "("Failed to find object with id: ");
                UnityEngine.Debug.LogWarning(message:  0);
            }
            
            this.attackDirection = attackDir;
            mem[1152921511540451600] = attackDir.y;
            mem[1152921511540451604] = attackDir.z;
            this.SetDesiredRotationDirection(dir:  new UnityEngine.Vector3() {x = attackDir.x, y = attackDir.y, z = attackDir.z});
            bool val_5 = this.GotoState<RangeAttack>(stateData:  0);
        }
        [TzarRPC]
        protected void server_meleeAttack(UnityEngine.Vector3 attackDir)
        {
            if(this.PlayerOwner.itsMe == true)
            {
                    return;
            }
            
            this.targetObject = 0;
            this.attackDirection = attackDir;
            mem[1152921511540592272] = attackDir.y;
            mem[1152921511540592276] = attackDir.z;
            if(this.IsAttacking != false)
            {
                    this.pendingAttackFromClient = true;
                return;
            }
            
            bool val_5 = this.GotoState<MeleeAttack>(stateData:  0);
        }
        [TzarRPC]
        protected void server_meleeAttack_object(uint id, UnityEngine.Vector3 attackDir)
        {
            if(this.PlayerOwner.itsMe == true)
            {
                    return;
            }
            
            TzarGames.TzarHero.TH_InteractiveObject val_4 = TzarGames.TzarHero.TH_InteractiveObject.GetObjectById(id:  317251584);
            if(0 != val_4)
            {
                    this.targetObject = val_4;
            }
            
            this.attackDirection = attackDir;
            mem[1152921511540716560] = attackDir.y;
            mem[1152921511540716564] = attackDir.z;
            if(this.IsAttacking != false)
            {
                    this.pendingAttackFromClient = true;
                return;
            }
            
            bool val_7 = this.GotoState<MeleeAttack>(stateData:  0);
        }
        [TzarRPC]
        protected void server_rangeAttack(UnityEngine.Vector3 attackDir)
        {
            if(this.PlayerOwner.itsMe == true)
            {
                    return;
            }
            
            this.targetObject = 0;
            this.attackDirection = attackDir;
            mem[1152921511540840848] = attackDir.y;
            mem[1152921511540840852] = attackDir.z;
            if(this.IsAttacking != false)
            {
                    this.pendingAttackFromClient = true;
                return;
            }
            
            bool val_5 = this.GotoState<RangeAttack>(stateData:  0);
        }
        [TzarRPC]
        protected void server_rangeAttack_object(uint id, UnityEngine.Vector3 attackDir)
        {
            if(this.PlayerOwner.itsMe == true)
            {
                    return;
            }
            
            TzarGames.TzarHero.TH_InteractiveObject val_4 = TzarGames.TzarHero.TH_InteractiveObject.GetObjectById(id:  317251584);
            if(0 != val_4)
            {
                    this.targetObject = val_4;
            }
            
            this.attackDirection = attackDir;
            mem[1152921511540965136] = attackDir.y;
            mem[1152921511540965140] = attackDir.z;
            if(this.IsAttacking != false)
            {
                    this.pendingAttackFromClient = true;
                return;
            }
            
            bool val_7 = this.GotoState<RangeAttack>(stateData:  0);
        }
        protected void SubscribeToTemplateEvents()
        {
            if(this.subscribedToTemplateEvents != false)
            {
                    return;
            }
            
            this.subscribedToTemplateEvents = true;
            this.characterTemplateInstance.add_OnXpChanged(value:  new System.Action<TzarGames.GameFramework.CharacterTemplate, System.Int32>(object:  this, method:  System.Void TzarGames.TzarHero.TH_Character::OnXpChangedEvent(TzarGames.GameFramework.CharacterTemplate template, int difference)));
            this.characterTemplateInstance.add_OnLevelUp(value:  new CharacterTemplate.CharacterTemplateDelegate(object:  this, method:  System.Void TzarGames.TzarHero.TH_Character::OnLevelUpEvent(TzarGames.GameFramework.CharacterTemplate template)));
        }
        protected void UnsubscribeFromTemplateEvents()
        {
            if(this.subscribedToTemplateEvents == false)
            {
                    return;
            }
            
            this.subscribedToTemplateEvents = false;
            this.characterTemplateInstance.remove_OnXpChanged(value:  new System.Action<TzarGames.GameFramework.CharacterTemplate, System.Int32>(object:  this, method:  System.Void TzarGames.TzarHero.TH_Character::OnXpChangedEvent(TzarGames.GameFramework.CharacterTemplate template, int difference)));
            this.characterTemplateInstance.remove_OnLevelUp(value:  new CharacterTemplate.CharacterTemplateDelegate(object:  this, method:  System.Void TzarGames.TzarHero.TH_Character::OnLevelUpEvent(TzarGames.GameFramework.CharacterTemplate template)));
        }
        protected override void OnDestroy()
        {
            UnityEngine.Events.UnityAction<T0, T1> val_20;
            IntPtr val_21;
            var val_22;
            bool val_2 = TzarGames.TzarHero.TH_Character.AllCharacters.Remove(item:  this);
            this.OnDestroy();
            if(this.InstantiatedInPlayMode != false)
            {
                    val_20 = 1152921504721543168;
                if(0 != this.characterTemplateInstance)
            {
                    if((UnityEngine.Object.op_Implicit(exists:  0)) != false)
            {
                    this.UnsubscribeFromTemplateEvents();
                UnityEngine.Object.Destroy(obj:  0);
            }
            
            }
            
            }
            
            if(0 != this.characterTemplateInstance)
            {
                    UnityEngine.Events.UnityAction<TzarGames.GameFramework.ItemInstance, TzarGames.TzarHero.ItemActivationInfo> val_6 = null;
                val_20 = val_6;
                val_6 = new UnityEngine.Events.UnityAction<TzarGames.GameFramework.ItemInstance, TzarGames.TzarHero.ItemActivationInfo>(object:  this, method:  typeof(TzarGames.TzarHero.TH_Character).__il2cppRuntimeField_2F8);
                this.characterTemplateInstance.OnItemActivated.RemoveListener(call:  val_20);
            }
            
            if(this.movement != null)
            {
                    TzarGames.Common.TG_VoidDelegate val_7 = null;
                val_21 = System.Void TzarGames.TzarHero.TH_Character::OnPreMovementUpdate();
                val_20 = val_7;
                val_7 = new TzarGames.Common.TG_VoidDelegate(object:  this, method:  val_21);
                var val_20 = 0;
                val_20 = val_20 + 1;
                val_21 = 1;
                val_22 = this.movement;
            }
            
            if(this.Connected == false)
            {
                    return;
            }
            
            if(this.OnServer == false)
            {
                    return;
            }
            
            this.RemoveRPCs();
            if(this.IsNetworkInstantiated == true)
            {
                    return;
            }
            
            if(0 == this.MyNetworkView)
            {
                    return;
            }
            
            val_20 = 1152921504908869632;
            if(0 == TzarGames.GameFramework.GameManager.Instance)
            {
                    return;
            }
            
            TzarGames.GameFramework.GameManager.Instance.Net.DestroyRemoteNetworkView(targetNetworkView:  this.MyNetworkView);
        }
        [TzarRPC]
        protected void client_destroyCharacter()
        {
            var val_8;
            if(this.checkClientAuthority() == false)
            {
                    return;
            }
            
            if(0 != this.MyNetworkView)
            {
                    val_8 = this.MyNetworkView.ToString();
            }
            else
            {
                    val_8 = " unknown id";
            }
            
            string val_6 = 0 + "client_destroyCharacter";
            UnityEngine.Debug.Log(message:  0);
            UnityEngine.GameObject val_7 = this.gameObject;
            UnityEngine.Object.Destroy(obj:  0);
        }
        protected virtual void OnAttackStateEnd()
        {
        
        }
        protected virtual void PlayAttackEffects()
        {
            if(0 == this.characterAnimation)
            {
                    return;
            }
            
            float val_9 = 1f;
            this = ???;
            val_9 = val_9 / this.characterTemplateInstance.AttackSpeed;
            goto typeof(TzarGames.TzarHero.CharacterAnimationBase).__il2cppRuntimeField_1E0;
        }
        protected override void CollectObjectInfo(System.Collections.Generic.Dictionary<string, string> data)
        {
            this.CollectObjectInfo(data:  data);
            UnityEngine.Vector3 val_1 = this.GetDesiredRotationDirection();
            data.set_Item(key:  "RotationDirection", value:  UnityEngine.JsonUtility.ToJson(obj:  0));
            data.set_Item(key:  "HP", value:  this.characterTemplateInstance.ActualHitPoints);
        }
        protected override void ApplyObjectInfo(System.Collections.Generic.Dictionary<string, string> data)
        {
            this.ApplyObjectInfo(data:  data);
            string val_1 = data.Item["RotationDirection"];
            UnityEngine.Vector3 val_2 = UnityEngine.JsonUtility.FromJson<UnityEngine.Vector3>(json:  0);
            this.SetDesiredRotationDirection(dir:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z});
            string val_3 = data.Item["HP"];
            this.characterTemplateInstance.ActualHitPoints = System.Single.Parse(s:  0);
        }
        public bool IsObjectInAttackRange(TzarGames.TzarHero.TH_InteractiveObject obj)
        {
            float val_1 = this.GetAttackRadius();
            val_1 = val_1 + this._minDistanceToWaypoint;
            return obj.IsObjectInRadius(obj:  obj, radius:  val_1);
        }
        public bool IsObjectInAttackRange(TzarGames.TzarHero.TH_InteractiveObject obj, float attackRadius)
        {
            attackRadius = this._minDistanceToWaypoint + attackRadius;
            return obj.IsObjectInRadius(obj:  obj, radius:  attackRadius);
        }
        public bool IsObjectInAttackRange(TzarGames.TzarHero.TH_InteractiveObject obj, float attackRadius, float allowedCheckError)
        {
            attackRadius = attackRadius + allowedCheckError;
            return obj.IsObjectInRadius(obj:  obj, radius:  attackRadius);
        }
        public bool get_IsStucked()
        {
            return (bool)this.bIsStucked;
        }
        private void removeCurrentPath()
        {
            this.pathResult = 0;
            this.currentWaypoint = 0;
        }
        protected virtual void OnStuck()
        {
        
        }
        private void checkStuck()
        {
            var val_4;
            this.bIsStucked = true;
            if(this.CurrentState != null)
            {
                    State val_2 = this.CurrentState;
                if(val_2 != null)
            {
                    val_4 = null;
            }
            
                val_4 = null;
                val_2 = (((StateMachine.State.__il2cppRuntimeField_typeHierarchy + TH_Character.CharacterBaseState.__il2cppRuntimeField_typeHierarchyDepth) + -8) == val_4) ? (val_2) : 0;
            }
        
        }
        public void ApplyModifiersBeforeNextMovementUpdate(TzarGames.GameFramework.ModificatorGroup group)
        {
            if((this.applyPendingGroups.Contains(item:  group)) != false)
            {
                    return;
            }
            
            this.applyPendingGroups.Add(item:  group);
        }
        private void OnPreMovementUpdate()
        {
            var val_4;
            if(this.applyPendingGroups.Count < 1)
            {
                    return;
            }
            
            val_4 = 0;
            goto label_3;
            label_8:
            X22.ApplyToTemplate(template:  X21);
            val_4 = 1;
            label_3:
            if(val_4 >= this.applyPendingGroups.Count)
            {
                goto label_6;
            }
            
            if(this.applyPendingGroups.Item[1] != null)
            {
                goto label_8;
            }
            
            goto label_8;
            label_6:
            this.applyPendingGroups.Clear();
        }
        public bool get_IsMoving()
        {
            return (bool)this.bMoving;
        }
        private void updateMovement()
        {
            TzarGames.GameFramework.ICharacterMovement val_26;
            var val_27;
            var val_28;
            float val_29;
            float val_30;
            float val_31;
            var val_32;
            float val_33;
            float val_34;
            var val_35;
            var val_36;
            float val_37;
            float val_38;
            float val_39;
            float val_40;
            float val_44;
            int val_46;
            var val_47;
            var val_48;
            var val_49;
            var val_50;
            var val_51;
            float val_52;
            float val_53;
            var val_55;
            var val_56;
            val_26 = this;
            if(this.movement == null)
            {
                    return;
            }
            
            if(this.pathMovement != null)
            {
                    return;
            }
            
            if(this.pathResult == null)
            {
                goto label_8;
            }
            
            var val_25 = 0;
            val_25 = val_25 + 1;
            val_27 = 0;
            val_28 = this.pathResult;
            if(((this.pathResult & 1) & 1) == 0)
            {
                goto label_8;
            }
            
            UnityEngine.Vector3 val_3 = this.GroundPivotPosition;
            val_29 = val_3.x;
            val_30 = val_3.y;
            val_31 = val_3.z;
            var val_26 = 0;
            val_26 = val_26 + 1;
            val_27 = 2;
            val_32 = this.pathResult;
            goto label_13;
            label_8:
            if(this.bMoving == false)
            {
                    return;
            }
            
            this.bMoving = false;
            bool val_4 = this.isObjectGoalReached();
            val_26 = this.movement;
            UnityEngine.Vector3 val_5 = UnityEngine.Vector3.zero;
            val_33 = val_5.x;
            val_34 = val_5.z;
            var val_27 = 0;
            val_27 = val_27 + 1;
            val_35 = val_26;
            return;
            label_13:
            if(((this.pathfinder & 1) & 1) == 0)
            {
                    val_29 = 0f;
                val_30 = 0f;
                val_31 = 0f;
            }
            
            UnityEngine.Vector3 val_9 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z}, b:  new UnityEngine.Vector3() {x = val_29, y = val_30, z = val_31});
            val_37 = val_9.x;
            if(val_37 < 0.0001f)
            {
                    val_37 = 0f;
            }
            
            float val_10 = this._minDistanceToWaypoint * this._minDistanceToWaypoint;
            val_38 = V9.16B;
            val_39 = V8.16B;
            val_40 = this.lastPathPosition;
            UnityEngine.Vector3 val_11 = TzarGames.Common.Math3D.ProjectPointOnLineSegment(linePoint1:  new UnityEngine.Vector3() {x = val_40, y = val_38, z = val_39}, linePoint2:  new UnityEngine.Vector3() {x = val_29, y = val_30, z = val_31}, point:  new UnityEngine.Vector3() {x = val_3.x, y = val_3.z});
            val_44 = val_11.z;
            this.lastPathPosition = val_29;
            mem[1152921511543547204] = val_30;
            mem[1152921511543547208] = val_31;
            if(val_37 <= val_10)
            {
                goto label_32;
            }
            
            val_40 = val_11.x;
            val_38 = val_11.y;
            val_39 = val_44;
            UnityEngine.Vector3 val_12 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_40, y = val_38, z = val_39}, b:  new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z});
            if(val_12.x > val_10)
            {
                goto label_35;
            }
            
            label_32:
            val_46 = this.currentWaypoint + 1;
            this.currentWaypoint = val_46;
            val_47 = val_29;
            val_44 = val_30;
            val_48 = val_31;
            var val_28 = 0;
            val_28 = val_28 + 1;
            val_36 = 3;
            val_49 = this.pathResult;
            if(val_46 >= this.pathResult)
            {
                goto label_41;
            }
            
            if(this.bMoving != true)
            {
                    this.bMoving = true;
            }
            
            var val_29 = 0;
            val_29 = val_29 + 1;
            val_36 = 2;
            val_50 = this.pathResult;
            goto label_47;
            label_41:
            this.pathResult = 0;
            this.currentWaypoint = 0;
            if(this.bMoving == false)
            {
                goto label_78;
            }
            
            this.bMoving = false;
            UnityEngine.Vector3 val_14 = UnityEngine.Vector3.zero;
            val_33 = val_14.x;
            val_34 = val_14.z;
            var val_30 = 0;
            val_30 = val_30 + 1;
            val_51 = this.movement;
            goto label_55;
            label_47:
            val_30 = val_12.y;
            if(((this.pathfinder & 1) & 1) == 0)
            {
                    val_52 = 0f;
                val_44 = 0f;
                val_53 = 0f;
            }
            
            UnityEngine.Vector3 val_17 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_12.x, y = val_30, z = val_12.z}, b:  new UnityEngine.Vector3() {x = val_52, y = val_44, z = val_53});
            label_35:
            val_33 = val_17.x;
            val_34 = val_17.z;
            val_46 = 1152921504909455360;
            var val_31 = 0;
            val_31 = val_31 + 1;
            val_55 = this.movement;
            var val_32 = 0;
            val_32 = val_32 + 1;
            val_56 = this.movement;
            if(val_33 < 0)
            {
                    if(this.bAccelerated == false)
            {
                    return;
            }
            
                this.bAccelerated = false;
                if((this.IsInvoking(methodName:  "checkStuck")) == true)
            {
                    return;
            }
            
                this.Invoke(methodName:  "checkStuck", time:  this.stuckCheckTime);
                return;
            }
            
            if(this.bAccelerated != true)
            {
                    this.bAccelerated = true;
            }
            
            if((this.IsInvoking(methodName:  "checkStuck")) != false)
            {
                    this.CancelInvoke(methodName:  "checkStuck");
            }
            
            if(this.bIsStucked == false)
            {
                    return;
            }
            
            this.bIsStucked = false;
            return;
            label_55:
            bool val_24 = this.isObjectGoalReached();
            label_78:
            this.goToPositionComplete();
        }
        private bool isObjectGoalReached()
        {
            if(0 == this.targetObject)
            {
                    return false;
            }
            
            if(this.bGoingToInterObject == false)
            {
                    return false;
            }
            
            return TzarGames.TzarHero.TH_InteractiveObject.IsObjectsTouching(firstObject:  null, secondObject:  this, allowedDistanceError:  this._minDistanceToWaypoint);
        }
        private void checkGoalReach()
        {
            if(this.isObjectGoalReached() == false)
            {
                    return;
            }
            
            this = ???;
            goto typeof(TzarGames.TzarHero.TH_Character).__il2cppRuntimeField_3C0;
        }
        protected virtual void TargetObjectReached(TzarGames.TzarHero.TH_InteractiveObject obj)
        {
            this.bGoingToInterObject = false;
        }
        public void GoToObject(TzarGames.TzarHero.TH_InteractiveObject interObject, bool withinAttackRange = False)
        {
            float val_12;
            float val_13;
            this.targetObject = interObject;
            this.bGoingToInterObject = true;
            if(this.isObjectGoalReached() != false)
            {
                    return;
            }
            
            if(withinAttackRange == false)
            {
                goto label_4;
            }
            
            float val_4 = this.GetActiveWeaponTemplate(slot:  0).AttackRange;
            val_12 = val_4;
            if(val_12 <= val_4)
            {
                goto label_4;
            }
            
            float val_6 = this.GetActiveWeaponTemplate(slot:  0).AttackRange;
            val_12 = val_6;
            val_6 = val_12 - val_6;
            val_13 = 30f;
            if((this.targetObject.TryGetFreePositionNearObject(interObject:  this.targetObject, result: out  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, offset:  val_6, numberOfChecks:  1, angleStep:  val_13)) == false)
            {
                    return;
            }
            
            goto label_7;
            label_4:
            val_13 = 30f;
            if((this.targetObject.TryGetFreePositionNearObject(interObject:  this.targetObject, result: out  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, offset:  0f, numberOfChecks:  1, angleStep:  val_13)) == false)
            {
                    return;
            }
            
            label_7:
            bool val_10 = this.GoToPosition(targetPosition:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, reachPositionHandler:  0, stoppingDistance:  null);
        }
        public System.Collections.Generic.List<TzarGames.TzarHero.TH_Character> GetOtherCharactersInRadius(float radius)
        {
            UnityEngine.Vector3 val_1 = this.GroundPivotPosition;
            System.Collections.Generic.List<TzarGames.TzarHero.TH_Character> val_2 = TzarGames.TzarHero.TH_Character.GetAllCharactersInRadius(position:  new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = val_1.z}, radius:  radius);
            bool val_3 = val_2.Remove(item:  this);
            return val_2;
        }
        public static System.Collections.Generic.List<TzarGames.TzarHero.TH_Character> GetAllCharactersInRadius(UnityEngine.Vector3 position, float radius)
        {
            var val_11;
            var val_12;
            var val_13;
            val_11 = null;
            val_11 = null;
            TzarGames.TzarHero.TH_Character.tempCharacterList.Clear();
            System.Collections.Generic.List<TzarGames.TzarHero.TH_Character> val_1 = TzarGames.TzarHero.TH_Character.AllCharacters;
            int val_3 = val_1.Count - 1;
            if((val_3 & 2147483648) != 0)
            {
                goto label_5;
            }
            
            label_23:
            TzarGames.TzarHero.TH_Character val_4 = val_1.Item[val_3];
            if((0 == val_4) || ((UnityEngine.Object.op_Implicit(exists:  0)) == false))
            {
                goto label_12;
            }
            
            UnityEngine.Vector3 val_9 = val_4.GroundPivotPosition;
            UnityEngine.Vector3 val_10 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_9.x, y = val_9.y, z = val_9.z}, b:  new UnityEngine.Vector3() {x = position.x, y = position.y, z = position.z});
            val_10.x = val_10.x - val_10.x;
            if(val_10.x > radius)
            {
                goto label_21;
            }
            
            val_12 = null;
            val_12 = null;
            TzarGames.TzarHero.TH_Character.tempCharacterList.Add(item:  val_4);
            goto label_21;
            label_12:
            val_1.RemoveAt(index:  val_3);
            label_21:
            val_3 = val_3 - 1;
            if((val_3 & 2147483648) == 0)
            {
                goto label_23;
            }
            
            label_5:
            val_13 = null;
            val_13 = null;
            return (System.Collections.Generic.List<TzarGames.TzarHero.TH_Character>)TzarGames.TzarHero.TH_Character.tempCharacterList;
        }
        public TzarGames.TzarHero.TH_Character GetNearestCharacterInRadius(float radius, bool onlyAlive, bool onlyFriend)
        {
            float val_11;
            float val_12;
            var val_13;
            val_11 = radius;
            System.Collections.Generic.List<TzarGames.TzarHero.TH_Character> val_1 = this.GetOtherCharactersInRadius(radius:  val_11);
            int val_2 = val_1.Count;
            if(val_2 < 1)
            {
                    return 0;
            }
            
            val_12 = 3.402823E+38f;
            var val_11 = 0;
            label_19:
            TzarGames.TzarHero.TH_Character val_3 = val_1.Item[0];
            if(onlyAlive != false)
            {
                    if(val_3._characterIsDead == true)
            {
                goto label_18;
            }
            
            }
            
            if(onlyFriend == false)
            {
                goto label_7;
            }
            
            val_13 = this.characterTemplateInstance.Group;
            if((val_13.IsFriendly(group:  val_3.characterTemplateInstance.Group)) == true)
            {
                goto label_18;
            }
            
            label_7:
            UnityEngine.Vector3 val_8 = val_13.position;
            val_11 = val_8.x;
            UnityEngine.Vector3 val_9 = val_13.position;
            UnityEngine.Vector3 val_10 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_11, y = val_8.y, z = val_8.z}, b:  new UnityEngine.Vector3() {x = val_9.x, y = val_9.y, z = val_9.z});
            if(val_10.x < 0)
            {
                    val_12 = val_10.x;
            }
            
            label_18:
            val_11 = val_11 + 1;
            if(val_2 != val_11)
            {
                goto label_19;
            }
            
            return 0;
        }
        public System.Collections.Generic.List<TzarGames.TzarHero.TH_Character> GetAllCharactersInAttackRadius(float radiusScale = 1)
        {
            var val_14;
            var val_15;
            var val_16;
            var val_17;
            float val_14 = radiusScale;
            val_14 = null;
            val_14 = null;
            TzarGames.TzarHero.TH_Character.tempCharacterList.Clear();
            val_15 = 0;
            val_14 = this.GetAttackRadius() * val_14;
            goto label_4;
            label_22:
            val_15 = 1;
            label_4:
            val_16 = null;
            if(val_15 >= TzarGames.TzarHero.TH_Character.AllCharacters.Count)
            {
                goto label_8;
            }
            
            TzarGames.TzarHero.TH_Character val_7 = TzarGames.TzarHero.TH_Character.AllCharacters.Item[1];
            if((0 == val_7) || (0 == val_7))
            {
                goto label_22;
            }
            
            float val_15 = this._minDistanceToWaypoint;
            val_15 = val_14 + val_15;
            if((val_7.IsObjectInRadius(obj:  val_7, radius:  val_15)) == false)
            {
                goto label_22;
            }
            
            val_17 = null;
            val_17 = null;
            TzarGames.TzarHero.TH_Character.tempCharacterList.Add(item:  val_7);
            goto label_22;
            label_8:
            val_16 = null;
            return (System.Collections.Generic.List<TzarGames.TzarHero.TH_Character>)TzarGames.TzarHero.TH_Character.tempCharacterList;
        }
        public void StopMove()
        {
            var val_7;
            var val_8;
            if(this.bMoving != false)
            {
                    bool val_1 = this.isObjectGoalReached();
                this.currentWaypoint = 0;
                this.pathResult = 0;
                this.CancelInvoke(methodName:  "checkStuck");
            }
            
            this.currentWaypoint = 1;
            if(this.movement != null)
            {
                    UnityEngine.Vector3 val_2 = UnityEngine.Vector3.zero;
                var val_7 = 0;
                val_7 = val_7 + 1;
                val_7 = this.movement;
            }
            
            if(this.CurrentState != null)
            {
                    State val_5 = this.CurrentState;
                if(val_5 != null)
            {
                    val_8 = null;
            }
            
                val_8 = null;
                val_5 = (((StateMachine.State.__il2cppRuntimeField_typeHierarchy + TH_Character.CharacterBaseState.__il2cppRuntimeField_typeHierarchyDepth) + -8) == val_8) ? (val_5) : 0;
            }
            
            if(this.reachPositionResultHandler == null)
            {
                    return;
            }
            
            this.reachPositionResultHandler.Invoke(arg1:  this, arg2:  false);
            this.reachPositionResultHandler = 0;
        }
        protected virtual void OnStopMove()
        {
        
        }
        public void IncreaseHealth(float amount)
        {
            TzarGames.TzarHero.TH_CharacterTemplate val_11;
            float val_13;
            if(this.OnClient == true)
            {
                    return;
            }
            
            val_11 = this.characterTemplateInstance;
            if(val_11 != null)
            {
                    val_13 = val_11.ActualHitPoints;
            }
            else
            {
                    float val_4 = 0.ActualHitPoints;
                val_13 = val_4;
                val_11 = 0;
            }
            
            val_4 = val_13 + amount;
            val_11.ActualHitPoints = val_4;
            if(this.characterTemplateInstance.ActualHitPoints > 0f)
            {
                    return;
            }
            
            UnityEngine.Vector3 val_6 = UnityEngine.Vector3.zero;
            typeof(TzarGames.TzarHero.TH_DamageType_Default).__il2cppRuntimeField_10 = TzarGames.GameFramework.SurfaceTypeBase.Default;
            bool val_10 = this.GotoState<Dead>(stateData:  new TzarGames.TzarHero.DeadEventData(killer:  0, victim:  this, force:  new UnityEngine.Vector3() {x = val_6.x, y = val_6.y, z = val_6.z}, damageType:  new System.Object()));
        }
        protected virtual void OnHealthIncreased()
        {
        
        }
        public void TakeDamage(TzarGames.GameFramework.IDamageInfo damageInfo)
        {
            TzarGames.GameFramework.IDamageType val_8;
            TzarGames.TzarHero.CharacterDamageInfo val_9;
            TzarGames.TzarHero.CharacterDamageInfo val_10;
            var val_11;
            var val_12;
            var val_13;
            var val_14;
            val_9 = 1152921504918134784;
            if(damageInfo != null)
            {
                    val_10 = damageInfo;
            }
            else
            {
                    var val_8 = 0;
                val_8 = val_8 + 1;
                val_11 = damageInfo;
                var val_9 = 0;
                val_9 = val_9 + 1;
                val_12 = damageInfo;
                var val_10 = 0;
                val_10 = val_10 + 1;
                val_13 = damageInfo;
                val_8 = damageInfo;
                var val_11 = 0;
                val_11 = val_11 + 1;
                val_14 = damageInfo;
                TzarGames.TzarHero.CharacterDamageInfo val_7 = null;
                val_9 = val_7;
                val_7 = new TzarGames.TzarHero.CharacterDamageInfo(damage:  V0.16B, force:  new UnityEngine.Vector3() {x = V0.16B, y = V1.16B, z = V2.16B}, damageType:  val_8, instigator:  0, victim:  this, isAuthoritative:  (~this.OnClient) & 1, hitInfo:  damageInfo);
                val_10 = val_9;
            }
            
            this.TakeDamage(damageInfo:  val_10);
        }
        public virtual void ModifyDamageInfo(TzarGames.TzarHero.CharacterDamageInfo damageInfo)
        {
            var val_8;
            var val_9;
            float val_10;
            float val_12;
            var val_13;
            State val_1 = this.CurrentState;
            if(val_1 != null)
            {
                    val_8 = null;
                val_8 = null;
                val_1 = (((StateMachine.State.__il2cppRuntimeField_typeHierarchy + (TH_Character.CharacterBaseState.__il2cppRuntimeField_typeHierarchyDepth) << 3) + -8) == val_8) ? (val_1) : 0;
            }
            else
            {
                    val_9 = 0;
            }
            
            if((val_9 & 1) == 0)
            {
                goto label_6;
            }
            
            val_10 = 0f;
            if(damageInfo != null)
            {
                goto label_22;
            }
            
            goto label_8;
            label_6:
            if(damageInfo.IgnoreDefence != false)
            {
                    val_12 = damageInfo.Damage;
            }
            else
            {
                    float val_4 = this.characterTemplateInstance.Defence;
                if(val_4 >= _TYPE_MAX_)
            {
                    val_13 = val_4;
            }
            
                val_12 = damageInfo.Damage / ((System.Math.Abs(val_13) > 0.0001f) ? (val_13) : 0.0001f);
            }
            
            val_10 = UnityEngine.Mathf.Max(a:  val_12, b:  0f);
            if(damageInfo != null)
            {
                goto label_22;
            }
            
            label_8:
            label_22:
            damageInfo.Damage = val_10;
        }
        public void TakeDamage(TzarGames.TzarHero.CharacterDamageInfo damageInfo)
        {
            UnityEngine.Object val_26;
            float val_27;
            var val_28;
            float val_29;
            TzarGames.GameFramework.BooleanCharacteristic val_30;
            float val_31;
            float val_32;
            if(damageInfo != null)
            {
                    val_26 = damageInfo.Instigator;
                val_27 = damageInfo.Damage;
                val_28 = damageInfo;
            }
            else
            {
                    val_26 = 0.Instigator;
                val_27 = 0.Damage;
                val_28 = 0;
            }
            
            val_29 = damageInfo.CriticalDamage;
            if(this._characterIsDead == true)
            {
                    return;
            }
            
            val_30 = this.ignoreDamage_runtime;
            if(val_30.ModifiedValue != false)
            {
                    val_31 = 0f;
                val_28.Damage = val_31;
            }
            
            if(this.OnClient != true)
            {
                    val_30 = this.characterTemplateInstance;
                val_32 = val_30.ActualHitPoints;
                val_31 = val_32 - val_28.Damage;
                val_30.ActualHitPoints = val_31;
            }
            
            if(this.OnCharacterTakeHit != null)
            {
                    this.OnCharacterTakeHit.Invoke(hitData:  damageInfo);
            }
            
            if((this.Connected != false) && (this.OnServer != false))
            {
                    val_30 = 1152921504721543168;
                if(0 != val_26)
            {
                    if((UnityEngine.Object.op_Implicit(exists:  0)) != false)
            {
                    TzarGames.GameFramework.RPCall<System.UInt32, System.Single, System.Single, UnityEngine.Vector3, System.Boolean, System.Single> val_15 = null;
                val_30 = val_15;
                val_15 = new TzarGames.GameFramework.RPCall<System.UInt32, System.Single, System.Single, UnityEngine.Vector3, System.Boolean, System.Single>(object:  this, method:  System.Void TzarGames.TzarHero.TH_Character::client_takeDamage(uint charId, float damage, float criticalDamage, UnityEngine.Vector3 force, bool isCritical, float realHp));
                val_26.generateId();
                typeof(System.Object[]).__il2cppRuntimeField_20 = 1152921505024093152;
                typeof(System.Object[]).__il2cppRuntimeField_24 = 268435457;
                typeof(System.Object[]).__il2cppRuntimeField_28 = val_27;
                typeof(System.Object[]).__il2cppRuntimeField_2C = 268435457;
                typeof(System.Object[]).__il2cppRuntimeField_30 = val_29;
                typeof(System.Object[]).__il2cppRuntimeField_34 = 268435457;
                UnityEngine.Vector3 val_16 = val_28.Force;
                typeof(System.Object[]).__il2cppRuntimeField_38 = val_16;
                typeof(System.Object[]).__il2cppRuntimeField_40 = damageInfo.IsCritical;
                typeof(System.Object[]).__il2cppRuntimeField_41 = 27104914;
                typeof(System.Object[]).__il2cppRuntimeField_48 = this.characterTemplateInstance.ActualHitPoints;
                typeof(System.Object[]).__il2cppRuntimeField_4C = 268435457;
                this.RPC(methodDelegate:  val_30, rpcMode:  2, parameters:  null);
            }
            
            }
            
            }
            
            if(this.OnClient != true)
            {
                    val_30 = this.characterTemplateInstance;
                if(val_30.ActualHitPoints <= 0f)
            {
                    UnityEngine.Vector3 val_23 = val_28.Force;
                val_29 = val_23.x;
                val_32 = val_23.z;
                this.setDeadState(instigator:  val_26, forceOnDead:  new UnityEngine.Vector3() {x = val_29, y = val_23.y, z = val_32}, damageType:  val_28.DamageType);
            }
            
            }
            
            if(0 == val_26)
            {
                    return;
            }
            
            if(val_3.OnHitOtherCharacter == null)
            {
                    return;
            }
            
            val_3.OnHitOtherCharacter.Invoke(hitData:  damageInfo);
        }
        private void setDeadState(TzarGames.TzarHero.TH_Character instigator, UnityEngine.Vector3 forceOnDead, TzarGames.GameFramework.IDamageType damageType)
        {
            bool val_2 = this.GotoState<Dead>(stateData:  new TzarGames.TzarHero.DeadEventData(killer:  instigator, victim:  this, force:  new UnityEngine.Vector3() {x = forceOnDead.x, y = forceOnDead.y, z = forceOnDead.z}, damageType:  damageType));
        }
        [TzarRPC]
        protected void client_takeDamage(uint charId, float damage, float criticalDamage, UnityEngine.Vector3 force, bool isCritical, float realHp)
        {
            float val_17;
            float val_18;
            float val_19;
            TzarGames.GameFramework.ISurfaceType val_20;
            var val_21;
            val_17 = force.y;
            val_18 = criticalDamage;
            val_19 = damage;
            val_20 = this;
            TzarGames.TzarHero.TH_InteractiveObject val_1 = TzarGames.TzarHero.TH_InteractiveObject.GetObjectById(id:  317251584);
            val_21 = 0;
            if(0 == )
            {
                goto label_8;
            }
            
            this.characterTemplateInstance.ActualHitPoints = realHp;
            typeof(TzarGames.TzarHero.TH_DamageType_Default).__il2cppRuntimeField_10 = TzarGames.GameFramework.SurfaceTypeBase.Default;
            UnityEngine.Vector3 val_7 = this.transform.position;
            UnityEngine.Vector3 val_8 = (TzarGames.TzarHero.TH_InteractiveObject.__il2cppRuntimeField_typeHierarchy + (TzarGames.TzarHero.TH_Character.__il2cppRuntimeField_typeHierarchyDepth) << 3) + -8 == null ? val_1 : 0 + 152.position;
            UnityEngine.Vector3 val_9 = (TzarGames.TzarHero.TH_InteractiveObject.__il2cppRuntimeField_typeHierarchy + (TzarGames.TzarHero.TH_Character.__il2cppRuntimeField_typeHierarchyDepth) << 3) + -8 == null ? val_1 : 0 + 152.position;
            val_19 = val_9.y;
            UnityEngine.Vector3 val_10 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_8.x, y = val_8.y, z = val_8.z}, b:  new UnityEngine.Vector3() {x = val_9.x, y = val_19, z = val_9.z});
            val_18 = val_10.x;
            val_17 = val_10.z;
            if(null == 0)
            {
                goto label_18;
            }
            
            IsCritical = isCritical;
            goto label_19;
            label_8:
            val_20 = 0 + "Character not found by its id: "("Character not found by its id: ");
            UnityEngine.Debug.LogWarning(message:  0);
            return;
            label_18:
            IsCritical = isCritical;
            label_19:
            CriticalDamage = val_18;
            this.TakeDamage(damageInfo:  new TzarGames.TzarHero.CharacterDamageInfo(damage:  val_19, force:  new UnityEngine.Vector3() {x = force.x, y = val_17, z = force.z}, damageType:  new System.Object(), instigator:  null, victim:  this, isAuthoritative:  true, hitInfo:  new TzarGames.GameFramework.Hit(point:  new UnityEngine.Vector3() {x = val_7.x, y = val_7.y, z = val_7.z}, normal:  new UnityEngine.Vector3() {x = val_18, y = val_10.y, z = val_17}, collider:  0, rigidbody:  0, surfaceType:  this)));
            if(this.characterTemplateInstance.ActualHitPoints > 0f)
            {
                    return;
            }
            
            NotifyCharacterKill(killer:  null, victim:  this);
        }
        public virtual TzarGames.GameFramework.ISurfaceType GetSurfaceType()
        {
            return TzarGames.GameFramework.SurfaceTypeBase.GetOrCreate(surfaceName:  0);
        }
        protected virtual void onTakeDamage(TzarGames.TzarHero.CharacterDamageInfo damageInfo)
        {
        
        }
        protected void NotifyCharacterKill(TzarGames.TzarHero.TH_Character killer, TzarGames.TzarHero.TH_Character victim)
        {
            var val_11;
            UnityEngine.Object val_12;
            val_11 = victim;
            val_12 = killer;
            if(0 != val_12)
            {
                    return;
            }
            
            if(this.xpCollectEnabled == false)
            {
                    return;
            }
            
            if(this.OnClient != true)
            {
                    this.ChangeXPBy(amount:  TzarGames.TzarHero.TH_Character.CalculateXpForCharacterPair(receiver:  null, fromCharacter:  val_12));
            }
            
            val_11 = ???;
            val_12 = ???;
            goto typeof(TzarGames.TzarHero.TH_Character).__il2cppRuntimeField_420;
        }
        public static int CalculateXpForCharacterPair(TzarGames.TzarHero.TH_Character receiver, TzarGames.TzarHero.TH_Character fromCharacter)
        {
            float val_8;
            float val_9;
            val_8 = -3f;
            if(((float)(double)(X2 + 208.Level) - fromCharacter.characterTemplateInstance.Level) < 0)
            {
                    val_8 = System.Math.Abs((float)(double)(X2 + 208.Level) - fromCharacter.characterTemplateInstance.Level);
                val_9 = 1f / val_8;
            }
            else
            {
                    val_9 = 1f;
            }
            
            float val_7 = fromCharacter.characterTemplateInstance.XpRate;
            float val_5 = X2 + 208.HitPoints;
            val_5 = val_7 * val_5;
            val_7 = val_9 * val_5;
            return (int)(int)UnityEngine.Mathf.Max(a:  val_7, b:  1f);
        }
        protected virtual void OnKillCharacter(TzarGames.TzarHero.TH_Character victim)
        {
        
        }
        protected virtual void LateCharacterDead()
        {
            UnityEngine.Vector3 val_1 = UnityEngine.Vector3.zero;
            UnityEngine.Coroutine val_3 = this.StartCoroutine(routine:  this.clientDelayDeath(force:  new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = val_1.z}));
        }
        [TzarRPC]
        protected void client_characterDead(UnityEngine.Vector3 force)
        {
            UnityEngine.Coroutine val_2 = this.StartCoroutine(routine:  this.clientDelayDeath(force:  new UnityEngine.Vector3() {x = force.x, y = force.y, z = force.z}));
        }
        [System.Diagnostics.DebuggerHiddenAttribute]
        private System.Collections.IEnumerator clientDelayDeath(UnityEngine.Vector3 force)
        {
            if(null != 0)
            {
                    typeof(TH_Character.<clientDelayDeath>c__Iterator1).__il2cppRuntimeField_10 = force.x;
                typeof(TH_Character.<clientDelayDeath>c__Iterator1).__il2cppRuntimeField_14 = force.y;
                typeof(TH_Character.<clientDelayDeath>c__Iterator1).__il2cppRuntimeField_18 = force.z;
            }
            else
            {
                    mem[16] = force.x;
                typeof(TH_Character.<clientDelayDeath>c__Iterator1).__il2cppRuntimeField_14 = force.y;
                mem[24] = force.z;
            }
            
            typeof(TH_Character.<clientDelayDeath>c__Iterator1).__il2cppRuntimeField_20 = this;
            return (System.Collections.IEnumerator)new System.Object();
        }
        [TzarRPC]
        protected void client_characterDead_post()
        {
            goto typeof(TzarGames.TzarHero.TH_Character).__il2cppRuntimeField_430;
        }
        private void updateBodyRotation(float timeDelta)
        {
            UnityEngine.Transform val_12;
            float val_13;
            if(this.enableBodyRotation == false)
            {
                    return;
            }
            
            if(0 == this.rotationBody)
            {
                    val_12 = this.gameObject.transform;
            }
            else
            {
                    val_12 = this.rotationBody;
            }
            
            UnityEngine.Quaternion val_4 = val_12.rotation;
            if((UnityEngine.Quaternion.op_Inequality(lhs:  new UnityEngine.Quaternion() {x = this.desiredRotation, y = V10.16B, z = V11.16B, w = V12.16B}, rhs:  new UnityEngine.Quaternion() {x = val_4.x, y = val_4.y, z = val_4.z, w = val_4.w})) == false)
            {
                    return;
            }
            
            if(this.Connected != false)
            {
                    if(this.PlayerOwner == null)
            {
                    return;
            }
            
                if(this.PlayerOwner.itsMe == false)
            {
                    return;
            }
            
            }
            
            UnityEngine.Quaternion val_10 = val_12.rotation;
            val_13 = val_10.x;
            val_13 = val_13;
            float val_12 = timeDelta;
            val_12 = this._rotationRate * val_12;
            UnityEngine.Quaternion val_11 = UnityEngine.Quaternion.Lerp(a:  new UnityEngine.Quaternion() {x = val_13, y = val_10.y, z = val_10.z, w = val_10.w}, b:  new UnityEngine.Quaternion() {x = this.desiredRotation, y = val_4.x, z = val_4.w, w = val_4.y}, t:  val_12);
            val_12.rotation = new UnityEngine.Quaternion() {x = val_11.x, y = val_11.y, z = val_11.z, w = val_11.w};
        }
        protected virtual void CharacterDead(UnityEngine.Vector3 force)
        {
        
        }
        protected virtual void CharacterAlive()
        {
        
        }
        protected virtual void Update()
        {
            TzarGames.GameFramework.IDamageType val_17;
            var val_18;
            var val_19;
            var val_20;
            var val_21;
            State val_2 = this.CurrentState;
            if(this._characterIsDead != true)
            {
                    if(this.OnClient != true)
            {
                    if(this.characterTemplateInstance.ActualHitPoints <= 0f)
            {
                    UnityEngine.Vector3 val_6 = UnityEngine.Vector3.zero;
                object val_8 = null;
                val_17 = val_8;
                val_8 = new System.Object();
                typeof(TzarGames.TzarHero.TH_DamageType_Default).__il2cppRuntimeField_10 = TzarGames.GameFramework.SurfaceTypeBase.Default;
                this.setDeadState(instigator:  0, forceOnDead:  new UnityEngine.Vector3() {x = val_6.x, y = val_6.y, z = val_6.z}, damageType:  val_17);
            }
            
            }
            
                if(this._characterIsDead != true)
            {
                    val_18 = 0;
                if((0 != this.characterAnimation) && (this.movement != null))
            {
                    var val_16 = 0;
                val_16 = val_16 + 1;
                val_18 = 5;
                val_19 = this.movement;
                var val_17 = 0;
                val_17 = val_17 + 1;
                val_18 = 17;
                val_20 = this.movement;
                val_17 = this.movement;
                TzarGames.GameFramework.ICharacterMovement val_12 = val_17 & 1;
            }
            
                this.updateBodyRotation(timeDelta:  UnityEngine.Time.deltaTime);
                this.updateHealth();
            }
            
            }
            
            System.Collections.Generic.List<TzarGames.TzarHero.Interfaces.IInfluence> val_18 = this.influences;
            val_18 = val_18.Count - 1;
            if((val_18 & 2147483648) != 0)
            {
                    return;
            }
            
            do
            {
                val_17 = this.influences.Item[val_18];
                var val_19 = 0;
                val_19 = val_19 + 1;
                val_21 = val_17;
                val_18 = val_18 - 1;
            }
            while((val_18 & 2147483648) == 0);
        
        }
        private void updateHealth()
        {
            float val_1 = this.characterTemplateInstance.ActualHitPoints;
            val_1 = val_1 - this.lastHealthAmount;
            if(System.Math.Abs(val_1) <= 0.0001f)
            {
                    return;
            }
            
            this = ???;
            goto typeof(TzarGames.TzarHero.TH_Character).__il2cppRuntimeField_3E0;
        }
        [TzarRPC]
        protected void client_updateHealth(float health)
        {
            if(this.checkClientAuthority() == false)
            {
                    return;
            }
            
            this.characterTemplateInstance.ActualHitPoints = health;
        }
        public static void TurnAllChildColliders(UnityEngine.GameObject obj, bool on)
        {
            var val_2;
            bool val_2 = W2;
            val_2 = 0;
            val_2 = val_2 & 1;
            goto label_2;
            label_7:
            enabled = val_2;
            val_2 = 1;
            label_2:
            if(val_2 >= val_1.Length)
            {
                    return;
            }
            
            if((on.GetComponentsInChildren<UnityEngine.Collider>()[1]) != 0)
            {
                goto label_7;
            }
            
            goto label_7;
        }
        public bool TakeItem(TzarGames.GameFramework.ItemInstance itemInstance, TzarGames.GameFramework.IDropperInfo dropperInfo)
        {
            var val_13;
            TzarGames.GameFramework.Item val_1 = itemInstance.GetOriginalTemplate();
            if(((val_1 & 1) == 0) || (this.characterTemplateInstance.Inventory == null))
            {
                goto label_5;
            }
            
            TzarGames.GameFramework.Items.Attributes.InventoryBagAttribute val_4 = itemInstance.GetTemplateInstance().GetAttributeOfType<TzarGames.GameFramework.Items.Attributes.InventoryBagAttribute>();
            TzarGames.GameFramework.Inventory val_6 = this.characterTemplateInstance.Inventory;
            if(0 == val_4)
            {
                goto label_11;
            }
            
            val_13 = val_6.GetBagByName(bagName:  val_4.BagName);
            if(val_13 != null)
            {
                goto label_14;
            }
            
            string val_10 = 0 + "No bag " + val_4.BagName + " found for item ";
            UnityEngine.Debug.LogError(message:  0);
            goto label_28;
            label_5:
            label_28:
            label_32:
            TzarGames.GameFramework.Events.ItemTakeEventData val_11 = new TzarGames.GameFramework.Events.ItemTakeEventData();
            if(null != 0)
            {
                    Dropper = dropperInfo;
                ItemInstance = itemInstance;
            }
            else
            {
                    Dropper = dropperInfo;
                ItemInstance = itemInstance;
            }
            
            Receiver = this;
            if(this.OnItemTaken != null)
            {
                    this.OnItemTaken.Invoke(eventData:  val_11);
            }
            
            if(0 == 0)
            {
                    return false;
            }
            
            if(this.OnItemAddedToInventory == null)
            {
                    return false;
            }
            
            this.OnItemAddedToInventory.Invoke(eventData:  val_11);
            return false;
            label_11:
            val_13 = val_6.DefaultBag;
            if(val_13 == null)
            {
                goto label_28;
            }
            
            label_14:
            if(val_1.ConsumptionType != 1)
            {
                goto label_30;
            }
            
            val_13.AddNonconsumableItem(itemInstance:  itemInstance);
            goto label_32;
            label_30:
            val_13.AddConsumableItem(item:  val_1, count:  1);
            goto label_32;
        }
        protected virtual void HandleItemUsedEvent(TzarGames.GameFramework.Item item, TzarGames.GameFramework.ItemInstance instance)
        {
        
        }
        public bool get_IsFollowing()
        {
            var val_3;
            State val_1 = this.CurrentState;
            val_3 = 0;
            return (bool);
        }
        public void Follow(TzarGames.TzarHero.TH_Character character, bool attack, float distance)
        {
            if(0 == character)
            {
                    return;
            }
            
            State val_2 = this.CurrentState;
            this.bFollowingToAttack = attack;
            this.targetObject = character;
            bool val_4 = this.GotoState<Following>(stateData:  distance);
        }
        public void StopFollow()
        {
            bool val_1 = this.GotoState<Moving>(stateData:  0);
        }
        protected virtual float CalculateFinalStunTime(float originalStunTime)
        {
            return (float)originalStunTime;
        }
        [TzarRPC]
        protected void client_stun(float stunTime)
        {
            if(this.checkClientAuthority() == false)
            {
                    return;
            }
            
            this.Stun(stunTime:  stunTime);
        }
        public void Stun(float stunTime)
        {
            bool val_1 = this.GotoState<Stunned>(stateData:  stunTime);
        }
        public void Stun()
        {
            bool val_1 = this.GotoState<Stunned>(stateData:  0f);
        }
        public void UnStun()
        {
            if(this.CurrentState == null)
            {
                    return;
            }
        
        }
        public void PlayCinematic(TzarGames.TzarHero.CharacterCinematic cinematic, System.Action<TzarGames.TzarHero.TH_Character> finishedCallback)
        {
            if(null != 0)
            {
                    typeof(TH_Character.CinematicInfo).__il2cppRuntimeField_10 = cinematic;
            }
            else
            {
                    mem[16] = cinematic;
            }
            
            typeof(TH_Character.CinematicInfo).__il2cppRuntimeField_18 = finishedCallback;
            bool val_2 = this.GotoState<Cinematic>(stateData:  new System.Object());
        }
        public override void OnPushedToPool()
        {
            this.OnPushedToPool();
            this.enabled = false;
            bool val_2 = TzarGames.TzarHero.TH_Character.AllCharacters.Remove(item:  this);
            mem2[0] = this.canBeAttacked;
            mem[1152921511549756932] = ???;
            CodeStage.AntiCheat.ObscuredTypes.ObscuredBool val_5 = this.ignoreDamage;
            val_5 = CodeStage.AntiCheat.ObscuredTypes.ObscuredBool.op_Implicit(value:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredBool() {inited = val_5, fakeValue = val_5, fakeValueActive = val_5});
            this.ignoreDamage_runtime.BaseValue = val_5;
            this.ignoreDamage_runtime.ClearModificators();
            if(0 == this.audioSource)
            {
                    return;
            }
            
            this.audioSource.enabled = false;
        }
        public override void OnPulledFromPool()
        {
            this.OnPulledFromPool();
            this.generateId();
            this.enabled = true;
            bool val_1 = UnityEngine.Object.op_Inequality(x:  0, y:  this.characterTemplateInstance);
            if(0 != this.meleeCombatSystem)
            {
                    this.meleeCombatSystem.Owner = this;
            }
            
            if(0 != this.rangeCombatSystem)
            {
                    this.rangeCombatSystem.Owner = this;
            }
            
            if(0 != this.audioSource)
            {
                    this.audioSource.enabled = true;
            }
            
            this.ResetToDefaultState();
        }
        protected override void OnEnable()
        {
            if((TzarGames.TzarHero.TH_Character.AllCharacters.Contains(item:  this)) != false)
            {
                    return;
            }
            
            TzarGames.TzarHero.TH_Character.AllCharacters.Add(item:  this);
        }
        protected override void OnDisable()
        {
            bool val_2 = TzarGames.TzarHero.TH_Character.AllCharacters.Remove(item:  this);
        }
        [UnityEngine.ContextMenu]
        public void Kill()
        {
            typeof(TzarGames.TzarHero.TH_DamageType_Default).__il2cppRuntimeField_10 = TzarGames.GameFramework.SurfaceTypeBase.Default;
            UnityEngine.Vector3 val_3 = UnityEngine.Vector3.down;
            this.setDeadState(instigator:  0, forceOnDead:  new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z}, damageType:  new System.Object());
        }
        public void SetIgnoreDamage(bool ignore)
        {
            ignore = ignore;
            CodeStage.AntiCheat.ObscuredTypes.ObscuredBool val_1 = CodeStage.AntiCheat.ObscuredTypes.ObscuredBool.op_Implicit(value:  false);
            mem[1152921511550439776] = val_1.inited;
            mem[1152921511550439777] = val_1.fakeValue;
            mem[1152921511550439778] = val_1.fakeValueActive;
            bool val_2 = val_1.inited & 4294967295;
            byte val_4 = val_1.currentCryptoKey;
            this.ignoreDamage = val_1;
            val_4 = CodeStage.AntiCheat.ObscuredTypes.ObscuredBool.op_Implicit(value:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredBool() {inited = val_4, fakeValue = val_4, fakeValueActive = val_4});
            this.ignoreDamage_runtime.BaseValue = val_4;
        }
        private static TH_Character()
        {
            TzarGames.TzarHero.TH_Character.allCharsListInitialized = false;
            TzarGames.TzarHero.TH_Character.tempCharacterList = new System.Collections.Generic.List<TzarGames.TzarHero.TH_Character>();
        }
    
    }

}
