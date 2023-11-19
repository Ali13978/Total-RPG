using UnityEngine;

namespace TzarGames.Endless.Quests
{
    public class KillBossQuestBehaviour : MonoBehaviour
    {
        // Fields
        private TzarGames.Endless.UI.NotificationBehaviour _notificationBehaviour;
        [UnityEngine.SerializeField]
        private UnityEngine.Events.UnityEvent onQuestStarted;
        [UnityEngine.SerializeField]
        private UnityEngine.Events.UnityEvent onQuestFinished;
        private bool isFinished;
        private TzarGames.TzarHero.TH_Character boss;
        
        // Methods
        public KillBossQuestBehaviour()
        {
        
        }
        private void Start()
        {
            if(TzarGames.Endless.EndlessGameState.Instance.CurrentQuest != null)
            {
                    0 = 0;
            }
            
            TzarGames.Endless.UI.NotificationBehaviour val_5 = this.gameObject.AddComponent<TzarGames.Endless.UI.NotificationBehaviour>();
            this._notificationBehaviour = val_5;
            val_5.SetConstantMessage(message:  TzarGames.Common.LocalizedStringAsset.op_Implicit(text:  0));
            this.onQuestStarted.Invoke();
        }
        public void SetCharacterAsBoss(TzarGames.GameFramework.TzarBehaviour character)
        {
            UnityEngine.Object val_7;
            TzarGames.TzarHero.TH_Character val_8;
            var val_9;
            object val_10;
            var val_11;
            var val_12;
            val_7 = character;
            val_8 = this.boss;
            if(0 == val_8)
            {
                goto label_3;
            }
            
            val_9 = "Boss is already setted";
            val_10 = 0;
            goto label_6;
            label_3:
            val_8 = 1152921504921595904;
            if(val_7 == null)
            {
                goto label_7;
            }
            
            val_11 = null;
            goto label_10;
            label_7:
            val_7 = val_7.GetComponent<TzarGames.TzarHero.TH_Character>();
            if(0 == val_7)
            {
                goto label_13;
            }
            
            if(val_7 == null)
            {
                goto label_14;
            }
            
            val_11 = null;
            label_10:
            label_14:
            val_12 = 0;
            goto label_16;
            label_13:
            val_9 = "Invalid character";
            val_10 = 0;
            label_6:
            UnityEngine.Debug.LogError(message:  val_10);
            return;
            label_16:
            this.boss = ;
            add_OnCharacterDead(value:  new TH_Character.dlgDeadEvent(object:  this, method:  System.Void TzarGames.Endless.Quests.KillBossQuestBehaviour::BossOnOnCharacterDead(TzarGames.TzarHero.DeadEventData deadEventData)));
        }
        private void BossOnOnCharacterDead(TzarGames.TzarHero.DeadEventData deadEventData)
        {
            this.finishQuest();
        }
        private void finishQuest()
        {
            var val_10;
            var val_11;
            var val_12;
            if(this.isFinished != false)
            {
                    return;
            }
            
            val_10 = 0;
            if(TzarGames.Endless.EndlessGameState.Instance.CurrentQuest != null)
            {
                    val_10 = 0;
            }
            
            TzarGames.Endless.ICharacterInfo val_5 = TzarGames.Endless.EndlessGameState.Instance.SelectedCharacter;
            if(0 != )
            {
                    mem2[0] = 1;
                var val_10 = 0;
                val_10 = val_10 + 1;
                val_11 = val_5;
            }
            else
            {
                    UnityEngine.Debug.LogError(message:  0);
                return;
            }
            
            var val_11 = 0;
            val_11 = val_11 + 1;
            val_12 = val_5;
            TzarGames.Endless.Quests.QuestUtils.SetStageQuestData(data:  val_5, stageNum:  val_5, quest:  val_5);
            this._notificationBehaviour.SetConstantMessage(message:  TzarGames.Common.LocalizedStringAsset.op_Implicit(text:  0));
            this.onQuestFinished.Invoke();
        }
    
    }

}
