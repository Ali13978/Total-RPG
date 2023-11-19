using UnityEngine;

namespace TzarGames.Endless.Quests
{
    public static class QuestUtils
    {
        // Fields
        private const string STAGE_QUEST_KEY = "QUESTMANAGER_STAGE_QUEST_KEY";
        private const string QUEST_KEY = "QUESTMANAGER_QUEST_KEY";
        
        // Methods
        private static string getStageKey(uint stage)
        {
            return (string)0 + "QUESTMANAGER_STAGE_QUEST_KEY_";
        }
        private static string getQuestKey(int id)
        {
            return (string)0 + "QUESTMANAGER_QUEST_KEY_";
        }
        public static TzarGames.Endless.Quests.IStageQuestsInfo GetStageQuestInfo(TzarGames.Common.SerializableData data, uint stageNum)
        {
            string val_2 = stageNum.GetString(id:  TzarGames.Endless.Quests.QuestUtils.getStageKey(stage:  20326));
            if((System.String.IsNullOrEmpty(value:  0)) == false)
            {
                    return UnityEngine.JsonUtility.FromJson<EncodedData>(json:  0);
            }
            
            return 0;
        }
        public static TzarGames.Endless.Quests.IStageQuestsInfo GetOrCreateStageInfo(TzarGames.Common.SerializableData data, uint stageNum)
        {
            return TzarGames.Endless.Quests.QuestUtils.getStageInfo(data:  data, stageNum:  stageNum);
        }
        private static TzarGames.Endless.Quests.QuestStageInfo getStageInfo(TzarGames.Common.SerializableData data, uint stageNum)
        {
            var val_6;
            string val_2 = stageNum.GetString(id:  TzarGames.Endless.Quests.QuestUtils.getStageKey(stage:  20323));
            if((System.String.IsNullOrEmpty(value:  0)) != true)
            {
                    val_6 = UnityEngine.JsonUtility.FromJson<EncodedData>(json:  0);
                if(val_6 != null)
            {
                    return (TzarGames.Endless.Quests.QuestStageInfo)val_6;
            }
            
                UnityEngine.Debug.LogError(message:  0);
            }
            
            TzarGames.Endless.Quests.QuestsBase val_5 = null;
            val_6 = val_5;
            val_5 = new TzarGames.Endless.Quests.QuestsBase();
            if(TzarGames.Endless.Quests != null)
            {
                    return (TzarGames.Endless.Quests.QuestStageInfo)val_6;
            }
            
            typeof(TzarGames.Endless.Quests.QuestStageInfo).__il2cppRuntimeField_18 = 1;
            return (TzarGames.Endless.Quests.QuestStageInfo)val_6;
        }
        private static void setStageInfo(TzarGames.Common.SerializableData data, TzarGames.Endless.Quests.QuestStageInfo stageInfo, uint stageNum)
        {
            stageInfo.SetString(id:  TzarGames.Endless.Quests.QuestUtils.getStageKey(stage:  data), stringValue:  UnityEngine.JsonUtility.ToJson(obj:  0));
        }
        public static void SerializeStageQuestInfo(TzarGames.Common.SerializableData data, TzarGames.Endless.Quests.IStageQuestsInfo questInfo, uint stageNum)
        {
            System.Type val_1 = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle());
            string val_2 = 0 + "Failed to cast to ";
            UnityEngine.Debug.LogError(message:  0);
        }
        public static void SetQuestData(TzarGames.Common.SerializableData data, TzarGames.Endless.Quests.EndlessQuest quest)
        {
            object val_1 = new System.Object();
            typeof(TzarGames.Endless.Quests.QuestInfo).__il2cppRuntimeField_10 = X2;
            typeof(TzarGames.Endless.Quests.QuestInfo).__il2cppRuntimeField_18 = X2;
            quest.SetString(id:  TzarGames.Endless.Quests.QuestUtils.getQuestKey(id:  X2), stringValue:  UnityEngine.JsonUtility.ToJson(obj:  0));
        }
        public static TzarGames.Endless.Quests.IQuestInfo GetQuestData(TzarGames.Common.SerializableData dataSource, int questId)
        {
            string val_1 = TzarGames.Endless.Quests.QuestUtils.getQuestKey(id:  20321);
            if((questId.HasString(id:  val_1)) == false)
            {
                    return 0;
            }
            
            string val_3 = questId.GetString(id:  val_1);
            return UnityEngine.JsonUtility.FromJson<EncodedData>(json:  0);
        }
        public static void SetStageQuestData(TzarGames.Common.SerializableData data, uint stageNum, TzarGames.Endless.Quests.EndlessQuest quest)
        {
            int val_4;
            TzarGames.Endless.Quests.EndlessQuest val_7;
            uint val_8;
            var val_9;
            object val_10;
            var val_11;
            val_7 = quest;
            val_8 = stageNum;
            TzarGames.Endless.Quests.QuestStageInfo val_1 = TzarGames.Endless.Quests.QuestUtils.getStageInfo(data:  20329, stageNum:  val_8);
            if(val_1 == null)
            {
                goto label_1;
            }
            
            List.Enumerator<T> val_2 = X23.GetEnumerator();
            label_6:
            if((0 & 1) == 0)
            {
                goto label_3;
            }
            
            val_9 = val_4.InitializationCallback;
            if(W26 != X3)
            {
                goto label_6;
            }
            
            mem2[0] = X3;
            TzarGames.Endless.Quests.QuestUtils.setStageInfo(data:  X3, stageInfo:  val_8, stageNum:  val_1);
            val_4.Dispose();
            return;
            label_1:
            val_10 = 0;
            goto label_13;
            label_3:
            val_4.Dispose();
            val_11 = 4;
            val_8 = null;
            val_11 = mem[null + 48];
            if("Failed to find quest with id" == null)
            {
                    val_11 = 0;
            }
            
            val_11 = 0;
            typeof(System.Object[]).__il2cppRuntimeField_20 = "Failed to find quest with id";
            val_4 = X3;
            typeof(System.Object[]).__il2cppRuntimeField_28 = val_4;
            typeof(System.Object[]).__il2cppRuntimeField_2C = 268435457;
            typeof(System.Object[]).__il2cppRuntimeField_30 = " on stage ";
            typeof(System.Object[]).__il2cppRuntimeField_38 = val_7;
            typeof(System.Object[]).__il2cppRuntimeField_3C = 268435457;
            val_7 = +0;
            val_10 = 0;
            label_13:
            UnityEngine.Debug.LogError(message:  val_10);
        }
        public static TzarGames.Common.SerializableData GetStageQuestData(TzarGames.Common.SerializableData data, uint stageNum, int questId)
        {
            int val_4;
            int val_7;
            var val_8;
            object val_9;
            val_7 = W3;
            if((TzarGames.Endless.Quests.QuestUtils.getStageInfo(data:  20325, stageNum:  stageNum)) == null)
            {
                goto label_1;
            }
            
            List.Enumerator<T> val_2 = stageNum.GetEnumerator();
            label_5:
            if((0 & 1) == 0)
            {
                goto label_3;
            }
            
            System.Action<GooglePlayGames.BasicApi.Nearby.InitializationStatus> val_5 = val_4.InitializationCallback;
            if(0 != val_7)
            {
                goto label_5;
            }
            
            val_4.Dispose();
            return (TzarGames.Common.SerializableData)val_8;
            label_1:
            val_9 = 0;
            goto label_9;
            label_3:
            val_4.Dispose();
            typeof(System.Object[]).__il2cppRuntimeField_20 = "Failed to find quest with id";
            val_4 = val_7;
            typeof(System.Object[]).__il2cppRuntimeField_28 = val_4;
            typeof(System.Object[]).__il2cppRuntimeField_2C = 268435457;
            val_7 = " on stage ";
            typeof(System.Object[]).__il2cppRuntimeField_30 = val_7;
            typeof(System.Object[]).__il2cppRuntimeField_38 = questId;
            typeof(System.Object[]).__il2cppRuntimeField_3C = 268435457;
            string val_6 = +0;
            val_9 = 0;
            label_9:
            UnityEngine.Debug.LogError(message:  val_9);
            val_8 = 0;
            return (TzarGames.Common.SerializableData)val_8;
        }
        public static void AddStageQuestsToCharacter(TzarGames.Common.SerializableData data, TzarGames.Endless.Quests.EndlessQuest[] quests, uint stageNum)
        {
            var val_5;
            var val_8;
            var val_9;
            var val_10;
            var val_11;
            val_9 = W3;
            TzarGames.Endless.Quests.QuestStageInfo val_1 = TzarGames.Endless.Quests.QuestUtils.getStageInfo(data:  20320, stageNum:  quests);
            if(val_1 == null)
            {
                goto label_1;
            }
            
            val_8 = 1152921510801352928;
            val_9 = 1152921510801358048;
            val_10 = 0;
            goto label_2;
            label_18:
            val_10 = 1;
            label_2:
            if(val_10 >= (stageNum + 24))
            {
                goto label_4;
            }
            
            uint val_2 = stageNum + 8;
            List.Enumerator<T> val_3 = X24.GetEnumerator();
            label_10:
            if((0 & 1) == 0)
            {
                goto label_7;
            }
            
            if(val_5.InitializationCallback != ((stageNum + 8) + 32))
            {
                goto label_10;
            }
            
            val_5.Dispose();
            goto label_18;
            label_7:
            val_11 = public System.Void List.Enumerator<TzarGames.Endless.Quests.QuestInfo>::Dispose();
            val_5.Dispose();
            typeof(TzarGames.Endless.Quests.QuestInfo).__il2cppRuntimeField_10 = (stageNum + 8) + 32;
            typeof(TzarGames.Endless.Quests.QuestInfo).__il2cppRuntimeField_18 = (stageNum + 8) + 32;
            (stageNum + 8) + 32.Add(item:  new System.Object());
            goto label_18;
            label_4:
            TzarGames.Endless.Quests.QuestUtils.setStageInfo(data:  val_1, stageInfo:  quests, stageNum:  val_1);
            return;
            label_1:
            UnityEngine.Debug.LogError(message:  0);
        }
    
    }

}
