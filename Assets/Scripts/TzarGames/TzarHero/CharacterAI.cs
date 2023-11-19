using UnityEngine;

namespace TzarGames.TzarHero
{
    public class CharacterAI : StateMachine
    {
        // Fields
        [UnityEngine.HeaderAttribute]
        [UnityEngine.SerializeField]
        private TzarGames.TzarHero.TH_Character controlledCharacter;
        [UnityEngine.SerializeField]
        private TzarGames.TzarHero.CharacterAI.AiBehaviour aiBehaviour;
        [UnityEngine.SerializeField]
        private float tickInterval;
        [UnityEngine.SerializeField]
        private float startDelay;
        [UnityEngine.HeaderAttribute]
        [UnityEngine.SerializeField]
        private float enemyDetectRadius;
        [UnityEngine.SerializeField]
        private float maxDefendDistance;
        [UnityEngine.SerializeField]
        private float followRadius;
        [UnityEngine.SerializeField]
        private bool checkObstacles;
        [UnityEngine.SerializeField]
        private float obstacleCheckRadius;
        [UnityEngine.SerializeField]
        private UnityEngine.LayerMask obstacleLayers;
        [UnityEngine.HeaderAttribute]
        [UnityEngine.SerializeField]
        private float minWalkDistance;
        [UnityEngine.SerializeField]
        private float maxWalkDistance;
        [UnityEngine.SerializeField]
        private float minWalkStopTime;
        [UnityEngine.SerializeField]
        private float maxWalkStopTime;
        [UnityEngine.SerializeField]
        private float stuckSpeed;
        private TzarGames.TzarHero.CharacterAI.AiBehaviour lastBehaviour;
        [System.Diagnostics.DebuggerBrowsableAttribute]
        private TzarGames.TzarHero.TH_Character <Target>k__BackingField;
        private bool isOn;
        
        // Properties
        public TzarGames.TzarHero.TH_Character Target { get; set; }
        public bool On { get; set; }
        public TzarGames.TzarHero.CharacterAI.AiBehaviour Behaviour { get; set; }
        
        // Methods
        public CharacterAI()
        {
            this.enemyDetectRadius = 10f;
            this.maxDefendDistance = 10f;
            this.tickInterval = 0.5f;
            this.obstacleCheckRadius = 0.5f;
            this.followRadius = 5f;
            this.stuckSpeed = 0.1f;
            this.minWalkDistance = ;
            this.maxWalkDistance = ;
            this.minWalkStopTime = 1f;
            this.maxWalkStopTime = 2f;
            this.isOn = true;
        }
        public TzarGames.TzarHero.TH_Character get_Target()
        {
            return (TzarGames.TzarHero.TH_Character)this.<Target>k__BackingField;
        }
        public void set_Target(TzarGames.TzarHero.TH_Character value)
        {
            this.<Target>k__BackingField = value;
        }
        public bool get_On()
        {
            return (bool)this.isOn;
        }
        public void set_On(bool value)
        {
            var val_1 = (this.isOn == true) ? 1 : 0;
            val_1 = val_1 ^ value;
            if(val_1 != false)
            {
                    this.StopAllCoroutines();
                if(value != false)
            {
                    UnityEngine.Coroutine val_3 = this.StartCoroutine(routine:  this.tick());
            }
            
            }
            
            this.isOn = value;
        }
        private void OnEnable()
        {
            UnityEngine.Coroutine val_2 = this.StartCoroutine(routine:  this.tick());
        }
        [System.Diagnostics.DebuggerHiddenAttribute]
        private System.Collections.IEnumerator tick()
        {
            typeof(CharacterAI.<tick>c__Iterator0).__il2cppRuntimeField_10 = this;
            return (System.Collections.IEnumerator)new System.Object();
        }
        public TzarGames.TzarHero.CharacterAI.AiBehaviour get_Behaviour()
        {
            return (AiBehaviour)this.aiBehaviour;
        }
        public void set_Behaviour(TzarGames.TzarHero.CharacterAI.AiBehaviour value)
        {
            this.aiBehaviour = value;
        }
        private void updateState()
        {
            var val_2;
            object val_3;
            if(this.aiBehaviour == 2)
            {
                goto label_1;
            }
            
            if(this.aiBehaviour == 1)
            {
                goto label_2;
            }
            
            if(this.aiBehaviour != 0)
            {
                    return;
            }
            
            val_2 = 1152921511468561040;
            val_3 = 0;
            goto label_5;
            label_1:
            val_2 = 1152921511468562064;
            val_3 = 0;
            goto label_5;
            label_2:
            val_2 = 1152921511468563088;
            val_3 = 0;
            label_5:
            bool val_1 = this.GotoState<DefendTarget>(stateData:  val_3);
        }
        private void Reset()
        {
            this.controlledCharacter = this.GetComponent<TzarGames.TzarHero.TH_Character>();
        }
    
    }

}
