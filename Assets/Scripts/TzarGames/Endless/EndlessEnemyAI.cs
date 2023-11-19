using UnityEngine;

namespace TzarGames.Endless
{
    public class EndlessEnemyAI : MonoBehaviour, IPoolable
    {
        // Fields
        [UnityEngine.SerializeField]
        private TzarGames.TzarHero.TH_Character controlledCharacter;
        [UnityEngine.SerializeField]
        private float updateInterval;
        [UnityEngine.SerializeField]
        private TzarGames.Endless.EndlessAiBehaviourType aiType;
        [UnityEngine.SerializeField]
        private float radius;
        [UnityEngine.SerializeField]
        private bool checkObstaclesForAttack;
        [UnityEngine.SerializeField]
        private UnityEngine.LayerMask obstacleLayers;
        [UnityEngine.SerializeField]
        private float obstacleCheckMinDistance;
        [UnityEngine.SerializeField]
        private float attackRepeatingInterval;
        [UnityEngine.SerializeField]
        private UnityEngine.Transform defendPosition;
        private bool isGoingToDefendPosition;
        private TzarGames.TzarHero.TH_Character lastHitInstigator;
        private UnityEngine.Coroutine updateCoroutine;
        private TzarGames.TzarHero.TH_Character targetCharacter;
        
        // Properties
        public float Radius { get; set; }
        
        // Methods
        public EndlessEnemyAI()
        {
            this.updateInterval = 0.5f;
            this.radius = 10f;
            this.obstacleCheckMinDistance = Infinityf;
            this.attackRepeatingInterval = 2f;
        }
        public float get_Radius()
        {
            return (float)this.radius;
        }
        public void set_Radius(float value)
        {
            this.radius = value;
        }
        private void Reset()
        {
            this.controlledCharacter = this.GetComponent<TzarGames.TzarHero.TH_Character>();
        }
        public TzarGames.TzarHero.TH_Character GetControlledCharacter()
        {
            return (TzarGames.TzarHero.TH_Character)this.controlledCharacter;
        }
        public void SetControlledCharacter(TzarGames.TzarHero.TH_Character character)
        {
            TzarGames.TzarHero.TH_Character val_5 = this.controlledCharacter;
            if(0 != val_5)
            {
                    val_5 = this.controlledCharacter;
                val_5.remove_OnCharacterTakeHit(value:  new TH_Character.dlgHitEvent(object:  this, method:  System.Void TzarGames.Endless.EndlessEnemyAI::onTakeHit(TzarGames.TzarHero.ICharacterDamageInfo damageInfo)));
            }
            
            this.controlledCharacter = character;
            if(0 == character)
            {
                    return;
            }
            
            this.controlledCharacter.add_OnCharacterTakeHit(value:  new TH_Character.dlgHitEvent(object:  this, method:  System.Void TzarGames.Endless.EndlessEnemyAI::onTakeHit(TzarGames.TzarHero.ICharacterDamageInfo damageInfo)));
        }
        public void SetDefendPoint(UnityEngine.Transform point)
        {
            this.defendPosition = point;
        }
        private void OnEnable()
        {
            if(0 != this.controlledCharacter)
            {
                    this.controlledCharacter.add_OnCharacterTakeHit(value:  new TH_Character.dlgHitEvent(object:  this, method:  System.Void TzarGames.Endless.EndlessEnemyAI::onTakeHit(TzarGames.TzarHero.ICharacterDamageInfo damageInfo)));
            }
            
            if(this.updateCoroutine != null)
            {
                    this.StopCoroutine(routine:  this.updateCoroutine);
            }
            
            this.updateCoroutine = this.StartCoroutine(routine:  this.targetUpdateRoutine());
        }
        private void OnDisable()
        {
            this.lastHitInstigator = 0;
            if(0 != this.controlledCharacter)
            {
                    this.controlledCharacter.remove_OnCharacterTakeHit(value:  new TH_Character.dlgHitEvent(object:  this, method:  System.Void TzarGames.Endless.EndlessEnemyAI::onTakeHit(TzarGames.TzarHero.ICharacterDamageInfo damageInfo)));
            }
            
            if(this.updateCoroutine == null)
            {
                    return;
            }
            
            this.StopCoroutine(routine:  this.updateCoroutine);
            this.updateCoroutine = 0;
        }
        public void Attack(TzarGames.TzarHero.TH_Character character)
        {
            if(0 == character)
            {
                    return;
            }
            
            this.targetCharacter = character;
            this.StopAllCoroutines();
            this.controlledCharacter.AttackCharacterContinuously(character:  this.targetCharacter);
            UnityEngine.Coroutine val_4 = this.StartCoroutine(routine:  this.targetUpdateRoutine());
        }
        private void onTakeHit(TzarGames.TzarHero.ICharacterDamageInfo damageInfo)
        {
            var val_2;
            var val_2 = 0;
            val_2 = val_2 + 1;
            val_2 = damageInfo;
            this.lastHitInstigator = damageInfo;
        }
        public void SetAiType(TzarGames.Endless.EndlessAiBehaviourType type)
        {
            this.aiType = type;
            this.targetCharacter = 0;
            if(this.isGoingToDefendPosition == false)
            {
                    return;
            }
            
            this.isGoingToDefendPosition = false;
        }
        [System.Diagnostics.DebuggerHiddenAttribute]
        private System.Collections.IEnumerator targetUpdateRoutine()
        {
            typeof(EndlessEnemyAI.<targetUpdateRoutine>c__Iterator0).__il2cppRuntimeField_10 = this;
            return (System.Collections.IEnumerator)new System.Object();
        }
        public TzarGames.TzarHero.TH_Character FindEnemyInRadius(float searchRadius, UnityEngine.Vector3 position)
        {
            float val_19;
            float val_20;
            var val_21;
            float val_22;
            TzarGames.TzarHero.TH_Character val_23;
            val_19 = position.z;
            val_20 = searchRadius;
            System.Collections.Generic.List<TzarGames.TzarHero.TH_Character> val_1 = TzarGames.TzarHero.TH_Character.GetAllCharactersInRadius(position:  new UnityEngine.Vector3() {x = position.x, y = position.y, z = val_19}, radius:  val_20);
            val_21 = 0;
            if(val_1 == null)
            {
                    return (TzarGames.TzarHero.TH_Character)val_21;
            }
            
            if(val_1.Count != 0)
            {
                    UnityEngine.Vector3 val_3 = this.controlledCharacter.GroundPivotPosition;
                val_19 = val_3.x;
                val_20 = val_3.z;
                val_21 = 0;
                if(val_1.Count < 1)
            {
                    return (TzarGames.TzarHero.TH_Character)val_21;
            }
            
                val_22 = 3.402823E+38f;
                var val_19 = 0;
                do
            {
                TzarGames.TzarHero.TH_Character val_7 = val_1.Item[0];
                if(0 != val_7)
            {
                    val_23 = this.controlledCharacter;
                if((val_23.isCharacterValidForAttack(character:  val_7)) != false)
            {
                    val_23 = val_7.TemplateInstance.Group;
                if((this.controlledCharacter.TemplateInstance.Group.IsFriendly(group:  val_23)) != true)
            {
                    UnityEngine.Vector3 val_15 = val_7.GroundPivotPosition;
                UnityEngine.Vector3 val_16 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_19, y = val_3.y, z = val_20}, b:  new UnityEngine.Vector3() {x = val_15.x, y = val_15.y, z = val_15.z});
                float val_17 = UnityEngine.Vector3.SqrMagnitude(vector:  new UnityEngine.Vector3() {x = val_16.x, y = val_16.y, z = val_16.z});
                if(val_17 <= val_22)
            {
                    val_21 = val_7;
                val_22 = val_17;
            }
            
            }
            
            }
            
            }
            
                val_19 = val_19 + 1;
            }
            while(val_19 < val_1.Count);
            
                return (TzarGames.TzarHero.TH_Character)val_21;
            }
            
            val_21 = 0;
            return (TzarGames.TzarHero.TH_Character)val_21;
        }
        public TzarGames.TzarHero.TH_Character FindNearestPlayerCharacter()
        {
            TzarGames.TzarHero.TH_Character val_27;
            var val_28;
            var val_29;
            val_27 = this;
            if(TzarGames.GameFramework.GameManagerNetSyncBase.Connected == false)
            {
                goto label_3;
            }
            
            System.Collections.Generic.List<TzarGames.GameFramework.Player> val_6 = TzarGames.GameFramework.GameManager.Instance.Net.GetPlayersInSession(sessionID:  this.controlledCharacter);
            label_41:
            if((val_6 == null) || (val_6.Count == 0))
            {
                goto label_10;
            }
            
            val_27 = this.controlledCharacter;
            UnityEngine.Vector3 val_8 = val_27.GroundPivotPosition;
            val_28 = 0;
            if(val_6.Count < 1)
            {
                    return (TzarGames.TzarHero.TH_Character)val_28;
            }
            
            do
            {
                TzarGames.GameFramework.Player val_10 = val_6.Item[0];
                val_29 = 0;
                UnityEngine.Vector3 val_11 = 0.GroundPivotPosition;
                UnityEngine.Vector3 val_12 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_8.x, y = val_8.y, z = val_8.z}, b:  new UnityEngine.Vector3() {x = val_11.x, y = val_11.y, z = val_11.z});
                float val_13 = UnityEngine.Vector3.SqrMagnitude(vector:  new UnityEngine.Vector3() {x = val_12.x, y = val_12.y, z = val_12.z});
                var val_14 = (val_13 > (3.402823E+38f)) ? (val_28) : (val_29);
                var val_15 = (val_13 > (3.402823E+38f)) ? 3.402823E+38f : (val_13);
                val_27 = 0 + 1;
            }
            while(val_27 < val_6.Count);
            
            return (TzarGames.TzarHero.TH_Character)val_28;
            label_3:
            val_28 = 0;
            if(0 == TzarGames.GameFramework.GameManager.Instance)
            {
                    return (TzarGames.TzarHero.TH_Character)val_28;
            }
            
            val_28 = 0;
            if(TzarGames.GameFramework.GameManager.Instance.LocalPlayer == null)
            {
                    return (TzarGames.TzarHero.TH_Character)val_28;
            }
            
            TzarGames.GameFramework.Player val_23 = TzarGames.GameFramework.GameManager.Instance.LocalPlayer;
            if(val_23.PlayerComponent == null)
            {
                goto label_36;
            }
            
            System.Collections.Generic.List<TzarGames.GameFramework.Player> val_24 = new System.Collections.Generic.List<TzarGames.GameFramework.Player>();
            Add(item:  TzarGames.GameFramework.GameManager.Instance.LocalPlayer);
            goto label_41;
            label_10:
            UnityEngine.Debug.LogError(message:  0);
            label_36:
            val_28 = 0;
            return (TzarGames.TzarHero.TH_Character)val_28;
        }
        public void OnPushedToPool()
        {
            if(0 != this.controlledCharacter)
            {
                    this.controlledCharacter.remove_OnCharacterTakeHit(value:  new TH_Character.dlgHitEvent(object:  this, method:  System.Void TzarGames.Endless.EndlessEnemyAI::onTakeHit(TzarGames.TzarHero.ICharacterDamageInfo damageInfo)));
            }
            
            this.lastHitInstigator = 0;
            this.targetCharacter = 0;
            this.controlledCharacter = 0;
        }
        public void OnPulledFromPool()
        {
        
        }
    
    }

}
