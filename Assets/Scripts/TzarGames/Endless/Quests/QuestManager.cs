using UnityEngine;

namespace TzarGames.Endless.Quests
{
    public class QuestManager : MonoBehaviour
    {
        // Fields
        [UnityEngine.SerializeField]
        private TzarGames.Endless.Quests.EndlessQuest[] quests;
        [UnityEngine.SerializeField]
        private float rewardDelay;
        private System.Collections.Generic.List<TzarGames.Endless.Quests.EndlessQuest> questInstances;
        
        // Methods
        public QuestManager()
        {
            this.rewardDelay = 1f;
            this.questInstances = new System.Collections.Generic.List<TzarGames.Endless.Quests.EndlessQuest>();
        }
        [System.Diagnostics.DebuggerHiddenAttribute]
        private System.Collections.IEnumerator Start()
        {
            typeof(QuestManager.<Start>c__Iterator0).__il2cppRuntimeField_30 = this;
            return (System.Collections.IEnumerator)new System.Object();
        }
        public static void RewardCharacterForQuest(TzarGames.Endless.PlayerCharacter character, uint currentStage, TzarGames.Endless.Quests.EndlessQuest quest, System.Action completeCallback)
        {
            var val_13;
            float val_1 = (float)(double)quest * S0;
            val_1 = (float)W25 * val_1;
            ulong val_2 = currentStage.Gold;
            string val_3 = 0 + "Gold before: "("Gold before: ");
            float val_4 = (int)val_1 + W25;
            UnityEngine.Debug.Log(message:  0);
            if(currentStage != 0)
            {
                    currentStage.AddGold(goldAdd:  val_4);
            }
            else
            {
                    0.AddGold(goldAdd:  val_4);
            }
            
            ulong val_5 = currentStage.Gold;
            string val_6 = 0 + "Gold after: "("Gold after: ");
            UnityEngine.Debug.Log(message:  0);
            float val_7 = (float)(double)quest * S0;
            val_7 = (3.479606E+07f) * val_7;
            float val_8 = (int)val_7 + ("Gold after: ");
            currentStage.ChangeXPBy(amount:  val_8);
            TzarGames.GameFramework.Item[] val_9 = completeCallback.GetItemsReward();
            val_13 = 0;
            goto label_11;
            label_17:
            bool val_10 = currentStage.TakeItem(itemInstance:  X25, dropperInfo:  0);
            val_13 = 1;
            label_11:
            if(val_13 >= val_9.Length)
            {
                goto label_13;
            }
            
            TzarGames.GameFramework.ItemInstance val_11 = val_9[1].CreateItemInstance();
            if(currentStage != 0)
            {
                goto label_17;
            }
            
            goto label_17;
            label_13:
            object val_12 = new System.Object();
            if(null != 0)
            {
                    typeof(TzarGames.Endless.Quests.EndlessQuestReward).__il2cppRuntimeField_10 = completeCallback;
                typeof(TzarGames.Endless.Quests.EndlessQuestReward).__il2cppRuntimeField_18 = val_4;
                typeof(TzarGames.Endless.Quests.EndlessQuestReward).__il2cppRuntimeField_20 = val_8;
            }
            else
            {
                    mem[16] = completeCallback;
                mem[24] = val_4;
                mem[32] = val_8;
            }
            
            typeof(TzarGames.Endless.Quests.EndlessQuestReward).__il2cppRuntimeField_28 = val_9;
            TzarGames.Endless.Quests.QuestManager.ShowReward(reward:  val_12 = new System.Object(), completeCalback:  val_12);
        }
        public static void ShowReward(TzarGames.Endless.Quests.IEndlessQuestReward reward, System.Action completeCalback)
        {
            System.Action val_9 = X2;
            UnityEngine.UI.Extensions.BoundTooltipItem val_1 = UnityEngine.Object.FindObjectOfType<UnityEngine.UI.Extensions.BoundTooltipItem>();
            if(0 == val_1)
            {
                    return;
            }
            
            if(0 != TzarGames.Endless.EndlessGameState.Instance)
            {
                    TzarGames.Endless.EndlessGameState.Instance.Paused = true;
            }
            
            val_1.ShowQuestReward(questReward:  completeCalback, callback:  val_9 = X2);
            val_9 = TzarGames.Endless.EndlessGameState.Instance;
            if(0 == val_9)
            {
                    return;
            }
            
            TzarGames.Endless.EndlessGameState.Instance.Paused = false;
        }
        [System.Diagnostics.DebuggerHiddenAttribute]
        public static System.Collections.IEnumerator CheckReward(TzarGames.Endless.PlayerCharacter playerCharacter, float delay, TzarGames.Common.SerializableData data, uint currentStage, System.Collections.Generic.List<TzarGames.Endless.Quests.EndlessQuest> quests, bool saveAsStageQuest)
        {
            if(null != 0)
            {
                    typeof(QuestManager.<CheckReward>c__Iterator1).__il2cppRuntimeField_10 = delay;
                typeof(QuestManager.<CheckReward>c__Iterator1).__il2cppRuntimeField_20 = saveAsStageQuest;
                typeof(QuestManager.<CheckReward>c__Iterator1).__il2cppRuntimeField_30 = currentStage;
                typeof(QuestManager.<CheckReward>c__Iterator1).__il2cppRuntimeField_28 = W5 & 1;
                typeof(QuestManager.<CheckReward>c__Iterator1).__il2cppRuntimeField_38 = quests;
            }
            else
            {
                    mem[16] = delay;
                mem[32] = saveAsStageQuest;
                mem[40] = W5 & 1;
                mem[48] = currentStage;
                mem[56] = quests;
            }
            
            typeof(QuestManager.<CheckReward>c__Iterator1).__il2cppRuntimeField_60 = data;
            return (System.Collections.IEnumerator)new System.Object();
        }
        private void OnDestroy()
        {
            System.Collections.Generic.List<TzarGames.Endless.Quests.EndlessQuest> val_3 = this.questInstances;
            val_3 = val_3.Count - 1;
            if((val_3 & 2147483648) != 0)
            {
                    return;
            }
            
            do
            {
                TzarGames.Endless.Quests.EndlessQuest val_2 = this.questInstances.Item[val_3];
                UnityEngine.Object.Destroy(obj:  0);
                val_3 = val_3 - 1;
            }
            while((val_3 & 2147483648) == 0);
        
        }
    
    }

}
