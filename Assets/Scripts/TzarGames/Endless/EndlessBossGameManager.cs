using UnityEngine;

namespace TzarGames.Endless
{
    public class EndlessBossGameManager : EndlessStoryGameManager
    {
        // Fields
        [UnityEngine.SerializeField]
        private TzarGames.Endless.Quests.KillBossQuest bossQuest;
        [UnityEngine.SerializeField]
        private UnityEngine.Events.UnityEvent onBossDefeated;
        private TzarGames.TzarHero.TH_Character bossCharacter;
        
        // Methods
        public EndlessBossGameManager()
        {
        
        }
        public void SetObjectAsBoss(TzarGames.GameFramework.TzarBehaviour obj)
        {
            TzarGames.TzarHero.TH_Character val_9;
            var val_10;
            object val_11;
            val_9 = this.bossCharacter;
            if(0 != val_9)
            {
                    return;
            }
            
            if(0 != obj)
            {
                goto label_6;
            }
            
            val_10 = "null boss object";
            val_11 = 0;
            goto label_9;
            label_6:
            val_9 = 0;
            this.bossCharacter = ;
            if(0 != )
            {
                goto label_19;
            }
            
            TzarGames.TzarHero.TH_Character val_6 = obj.GetComponent<TzarGames.TzarHero.TH_Character>();
            this.bossCharacter = val_6;
            if(0 != val_6)
            {
                goto label_19;
            }
            
            val_10 = "Boss is not character";
            val_11 = 0;
            label_9:
            UnityEngine.Debug.LogError(message:  val_11);
            return;
            label_19:
            this.bossCharacter.add_OnCharacterDead(value:  new TH_Character.dlgDeadEvent(object:  this, method:  System.Void TzarGames.Endless.EndlessBossGameManager::Character_OnCharacterDead(TzarGames.TzarHero.DeadEventData deadEventData)));
        }
        public void HideBoss()
        {
            if(0 == this.bossCharacter)
            {
                    return;
            }
            
            this.bossCharacter.gameObject.SetActive(value:  false);
        }
        private void Character_OnCharacterDead(TzarGames.TzarHero.DeadEventData deadEventData)
        {
            this.setBossAsDefeatedAndSave(bossQuest:  this.bossQuest);
            this.onBossDefeated.Invoke();
        }
        private void setBossAsDefeatedAndSave(TzarGames.Endless.Quests.KillBossQuest bossQuest)
        {
            var val_7;
            TzarGames.Endless.Quests.EndlessQuest val_8;
            var val_9;
            var val_10;
            var val_11;
            if(0 == TzarGames.Endless.EndlessGameState._instance)
            {
                    return;
            }
            
            if(null == 0)
            {
                goto label_6;
            }
            
            val_8 = SelectedCharacter;
            if(val_8 != null)
            {
                goto label_7;
            }
            
            goto label_8;
            label_6:
            val_8 = 0;
            label_8:
            val_7 = 0;
            label_7:
            if(mem[282584257676929] == 0)
            {
                goto label_12;
            }
            
            var val_6 = mem[282584257676823];
            var val_7 = 0;
            val_6 = val_6 + 8;
            label_11:
            if(((mem[282584257676823] + 8) + -8) == null)
            {
                goto label_10;
            }
            
            val_7 = val_7 + 1;
            val_6 = val_6 + 16;
            if(val_7 < mem[282584257676929])
            {
                goto label_11;
            }
            
            goto label_12;
            label_10:
            var val_8 = val_6;
            val_8 = val_8 + 6;
            val_7 = val_7 + val_8;
            val_7 = val_7 + 272;
            label_12:
            Unitycoding.UIWidgets.RadialMenuItem val_3 = UnityEngine.Object.Instantiate<Unitycoding.UIWidgets.RadialMenuItem>(original:  0);
            val_9 = bossQuest;
            val_10 = TzarGames.Endless.Quests.QuestUtils.GetQuestData(dataSource:  0, questId:  0);
            if(val_10 == null)
            {
                goto label_16;
            }
            
            var val_9 = 0;
            val_9 = val_9 + 1;
            val_9 = 1;
            val_11 = val_10;
            goto label_20;
            label_16:
            if(val_3 != null)
            {
                goto label_22;
            }
            
            goto label_22;
            label_20:
            val_10 = val_10;
            val_3.OnDestroy();
            label_22:
            val_3.BossKilled = true;
            TzarGames.Endless.Quests.QuestUtils.SetQuestData(data:  0, quest:  val_8);
            UnityEngine.Object.Destroy(obj:  0);
        }
        public void ExitFromStage()
        {
            TzarGames.Endless.EndlessGameManager.SetHeroDataToGameState();
            if(this.bossQuest.RaisesStage != false)
            {
                    TzarGames.Endless.EndlessGameState._instance.CompleteCurrentStageAndExitToLobby();
                return;
            }
            
            TzarGames.Endless.EndlessGameState._instance.SaveGame();
            TzarGames.Endless.EndlessGameState._instance.ExitFromGame();
        }
    
    }

}
