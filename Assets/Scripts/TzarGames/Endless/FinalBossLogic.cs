using UnityEngine;

namespace TzarGames.Endless
{
    public class FinalBossLogic : StateMachine
    {
        // Fields
        private TzarGames.Endless.EndlessEnemyAI bossAI;
        [UnityEngine.SerializeField]
        private TzarGames.Endless.MoveCharacterToPosition mover;
        [UnityEngine.SerializeField]
        private TzarGames.TzarHero.TH_Character illusion;
        [UnityEngine.SerializeField]
        private TzarGames.Common.StringID bossEscapeLayer;
        [UnityEngine.SerializeField]
        private TzarGames.Common.StringID bossDefaultLayer;
        [UnityEngine.SerializeField]
        private TzarGames.Endless.FinalBossLogic.RoomInfo room1;
        [UnityEngine.SerializeField]
        private TzarGames.Endless.FinalBossLogic.RoomInfo room2;
        [UnityEngine.SerializeField]
        private TzarGames.Endless.FinalBossLogic.RoomInfo room3;
        [UnityEngine.SerializeField]
        private TzarGames.Endless.FinalBossLogic.RoomInfo room4;
        [UnityEngine.SerializeField]
        private UnityEngine.Transform final_defendPoint;
        private System.Collections.Generic.List<TzarGames.TzarHero.TH_Character> illusions;
        
        // Methods
        public FinalBossLogic()
        {
            typeof(FinalBossLogic.RoomInfo).__il2cppRuntimeField_18 = 1117782016;
            this.room1 = new System.Object();
            typeof(FinalBossLogic.RoomInfo).__il2cppRuntimeField_18 = 1114636288;
            this.room2 = new System.Object();
            typeof(FinalBossLogic.RoomInfo).__il2cppRuntimeField_18 = 1109393408;
            this.room3 = new System.Object();
            typeof(FinalBossLogic.RoomInfo).__il2cppRuntimeField_18 = 1101004800;
            this.room4 = new System.Object();
            this.illusions = new System.Collections.Generic.List<TzarGames.TzarHero.TH_Character>();
        }
        public void NotifySpawned(TzarGames.GameFramework.TzarBehaviour behaviour)
        {
            TzarGames.Endless.EndlessEnemyAI val_1 = behaviour.GetComponent<TzarGames.Endless.EndlessEnemyAI>();
            this.bossAI = val_1;
            this.mover.SetCharacter(targetCharacter:  val_1.GetControlledCharacter());
            this.bossAI.GetControlledCharacter().add_OnCharacterDead(value:  new TH_Character.dlgDeadEvent(object:  this, method:  System.Void TzarGames.Endless.FinalBossLogic::FinalBossLogic_OnCharacterDead(TzarGames.TzarHero.DeadEventData deadEventData)));
            bool val_5 = this.GotoState<FinalBossLogic.Room1>(stateData:  this.room1);
        }
        private void FinalBossLogic_OnCharacterDead(TzarGames.TzarHero.DeadEventData deadEventData)
        {
            var val_5;
            var val_6;
            List.Enumerator<T> val_1 = this.illusions.GetEnumerator();
            label_6:
            if((0 & 1) == 0)
            {
                goto label_2;
            }
            
            System.Action<GooglePlayGames.BasicApi.Nearby.InitializationStatus> val_2 = 0.InitializationCallback;
            if(val_2.isDead == true)
            {
                goto label_6;
            }
            
            val_2.Kill();
            goto label_6;
            label_2:
            val_5 = 0;
            val_6 = 1;
            0.Dispose();
            if((val_6 & 1) != 0)
            {
                    return;
            }
            
            if(val_5 == 0)
            {
                    return;
            }
        
        }
        public void NotifyEscapeTriggerTouched(TzarGames.TzarHero.TH_Character character)
        {
            UnityEngine.GameObject val_2 = this.bossAI.gameObject;
            if(0 != character.gameObject)
            {
                    return;
            }
            
            if(this.CurrentState == null)
            {
                    return;
            }
        
        }
        private void Update()
        {
            if(this.CurrentState == null)
            {
                
            }
        
        }
        [UnityEngine.ContextMenu]
        private void damageBoss()
        {
            float val_5;
            TzarGames.TzarHero.TH_Character val_1 = this.bossAI.GetControlledCharacter();
            if(val_1 != null)
            {
                    val_5 = val_1.BaseHealth;
            }
            else
            {
                    val_5 = 0.BaseHealth;
            }
            
            float val_4 = -0.205f;
            val_4 = val_5 * val_4;
            val_1.IncreaseHealth(amount:  val_4);
        }
        [UnityEngine.ContextMenu]
        private void autoTestLogic()
        {
            UnityEngine.Coroutine val_2 = this.StartCoroutine(routine:  this.testLogic());
        }
        [System.Diagnostics.DebuggerHiddenAttribute]
        private System.Collections.IEnumerator testLogic()
        {
            typeof(FinalBossLogic.<testLogic>c__Iterator0).__il2cppRuntimeField_10 = this;
            return (System.Collections.IEnumerator)new System.Object();
        }
    
    }

}
