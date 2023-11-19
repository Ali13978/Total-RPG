using UnityEngine;

namespace TzarGames.Endless
{
    public class EndlessPowerPlaceGameManager : EndlessStoryGameManager
    {
        // Fields
        [UnityEngine.SerializeField]
        private UnityEngine.GameObject forceEffectPrefab;
        [UnityEngine.SerializeField]
        private TzarGames.Endless.EndlessSpawner[] spawners;
        [UnityEngine.SerializeField]
        private UnityEngine.Events.UnityEvent onAllEnemiesDestroyed;
        [UnityEngine.SerializeField]
        private UnityEngine.Events.UnityEvent onCompleted;
        private bool allDestroyed;
        private int destroyedSpawners;
        private TzarGames.Endless.UI.NotificationBehaviour _notificationBehaviour;
        
        // Methods
        public EndlessPowerPlaceGameManager()
        {
            val_1 = new TzarGames.Endless.EndlessGameManager();
        }
        private void HandleUnityAction()
        {
            bool val_3 = this.allDestroyed;
            if((val_3 & 255) == true)
            {
                    return;
            }
            
            val_3 = val_3 >> 32;
            bool val_2 = val_3 + 1;
            this.destroyedSpawners = val_2;
            if(val_2 != this.spawners.Length)
            {
                    return;
            }
            
            this.allDestroyed = true;
            this.onAllEnemiesDestroyed.Invoke();
        }
        protected override void Start()
        {
            var val_11;
            var val_12;
            this.Start();
            val_11 = 0;
            goto label_1;
            label_8:
            AddListener(call:  X21);
            val_11 = 1;
            label_1:
            if(val_11 >= this.spawners.Length)
            {
                goto label_3;
            }
            
            TzarGames.Endless.EndlessSpawner val_11 = this.spawners[1];
            UnityEngine.Events.UnityAction val_1 = new UnityEngine.Events.UnityAction(object:  this, method:  System.Void TzarGames.Endless.EndlessPowerPlaceGameManager::HandleUnityAction());
            if(this.spawners[0x1][0].onAllObjectsDestroyed != null)
            {
                goto label_8;
            }
            
            goto label_8;
            label_3:
            val_12 = 0;
            if(0 != TzarGames.Endless.EndlessGameState.Instance)
            {
                    val_12 = 0;
                if(TzarGames.Endless.EndlessGameState.Instance.CurrentQuest != null)
            {
                    val_12 = 0;
            }
            
            }
            
            if(0 == )
            {
                    return;
            }
            
            TzarGames.Endless.UI.NotificationBehaviour val_9 = this.gameObject.AddComponent<TzarGames.Endless.UI.NotificationBehaviour>();
            this._notificationBehaviour = val_9;
            val_9.SetConstantMessage(message:  TzarGames.Common.LocalizedStringAsset.op_Implicit(text:  0));
        }
        public void ActivateForceField()
        {
            UnityEngine.Coroutine val_3 = this.StartCoroutine(routine:  this.forceFieldRoutine(player:  TzarGames.Endless.EndlessGameManager.LocalPlayerCharacter));
        }
        [System.Diagnostics.DebuggerHiddenAttribute]
        private System.Collections.IEnumerator forceFieldRoutine(TzarGames.Endless.PlayerCharacter player)
        {
            if(null != 0)
            {
                    typeof(EndlessPowerPlaceGameManager.<forceFieldRoutine>c__Iterator0).__il2cppRuntimeField_10 = player;
            }
            else
            {
                    mem[16] = player;
            }
            
            typeof(EndlessPowerPlaceGameManager.<forceFieldRoutine>c__Iterator0).__il2cppRuntimeField_20 = this;
            return (System.Collections.IEnumerator)new System.Object();
        }
        private void onCinematicFinished(TzarGames.TzarHero.TH_Character player)
        {
            this.SetAsCompleted();
        }
        private void SetAsCompleted()
        {
            uint val_12;
            var val_13;
            var val_14;
            var val_15;
            val_12 = 1152921504721543168;
            val_13 = 0;
            if(0 != TzarGames.Endless.EndlessGameState.Instance)
            {
                    val_13 = 0;
                if(TzarGames.Endless.EndlessGameState.Instance.CurrentQuest != null)
            {
                    val_13 = 0;
            }
            
            }
            
            if(0 != )
            {
                    val_12 = TzarGames.Endless.EndlessGameState.Instance.SelectedCharacter;
                this._notificationBehaviour.SetConstantMessage(message:  TzarGames.Common.LocalizedStringAsset.op_Implicit(text:  0));
                IsPowerPlaceCompleted = true;
                var val_12 = 0;
                val_12 = val_12 + 1;
                val_14 = val_12;
                var val_13 = 0;
                val_13 = val_13 + 1;
                val_15 = val_12;
                TzarGames.Endless.Quests.QuestUtils.SetStageQuestData(data:  0, stageNum:  val_12, quest:  val_12);
            }
            
            this.onCompleted.Invoke();
        }
        public void ExitFromStage()
        {
            TzarGames.Endless.EndlessGameManager.SetHeroDataToGameState();
            TzarGames.Endless.EndlessGameState.Instance.CompleteCurrentStageAndExitToLobby();
        }
    
    }

}
