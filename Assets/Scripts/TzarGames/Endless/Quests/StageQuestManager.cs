using UnityEngine;

namespace TzarGames.Endless.Quests
{
    public class StageQuestManager : QuestProviderBase
    {
        // Fields
        [UnityEngine.SerializeField]
        private TzarGames.Endless.Quests.SingleQuestInfo[] singleQuests;
        [UnityEngine.SerializeField]
        private TzarGames.Endless.QuestList[] _questLists;
        [UnityEngine.SerializeField]
        private TzarGames.Endless.Quests.RepeatingQuestInfo[] repeatingQuests;
        [UnityEngine.SerializeField]
        private float rewardCheckDelay;
        private bool questsLoaded;
        
        // Methods
        public StageQuestManager()
        {
            this.rewardCheckDelay = 2f;
        }
        public void StartQuest(TzarGames.Endless.Quests.EndlessQuest quest)
        {
            var val_7;
            var val_8;
            TzarGames.Endless.ICharacterInfo val_2 = TzarGames.Endless.EndlessGameState.Instance.SelectedCharacter;
            if(true == 1)
            {
                    return;
            }
            
            var val_7 = 0;
            val_7 = val_7 + 1;
            val_7 = val_2;
            typeof(TzarGames.Endless.Quests.EndlessQuest[]).__il2cppRuntimeField_20 = quest;
            var val_8 = 0;
            val_8 = val_8 + 1;
            val_8 = val_2;
            TzarGames.Endless.Quests.QuestUtils.AddStageQuestsToCharacter(data:  val_2, quests:  val_2, stageNum:  -1906753856);
            TzarGames.Endless.PlayerCharacter val_5 = TzarGames.Endless.EndlessGameManager.LocalPlayerCharacter;
            TzarGames.Endless.EndlessGameState.Instance.StartQuest(task:  quest);
        }
        private static TzarGames.Endless.PlayerCharacter getCharacterByCharacterInfo(TzarGames.Endless.ICharacterInfo characterInfo)
        {
            return TzarGames.Endless.EndlessGameManager.LocalPlayerCharacter;
        }
        private void Awake()
        {
            TzarGames.GameFramework.GameManager.Instance.OnLocalPlayerObjectSpawned.AddListener(call:  new UnityEngine.Events.UnityAction<TzarGames.GameFramework.Player>(object:  this, method:  System.Void TzarGames.Endless.Quests.StageQuestManager::<Awake>m__0(TzarGames.GameFramework.Player player)));
        }
        [System.Diagnostics.DebuggerHiddenAttribute]
        private System.Collections.IEnumerator loadQuestsAndRewards()
        {
            typeof(StageQuestManager.<loadQuestsAndRewards>c__Iterator0).__il2cppRuntimeField_50 = this;
            return (System.Collections.IEnumerator)new System.Object();
        }
        private static void getRepeatingQuests(System.Collections.Generic.List<TzarGames.Endless.Quests.EndlessQuest> quests, uint stage, TzarGames.Endless.Quests.RepeatingQuestInfo[] repeatingQuests)
        {
            if(repeatingQuests == null)
            {
                    return;
            }
            
            if(X3 == 0)
            {
                    return;
            }
            
            if((X3 + 24) < 1)
            {
                    return;
            }
            
            label_10:
            var val_1 = X3 + 0;
            var val_4 = (X3 + 0) + 32 + 24;
            if(val_4 > repeatingQuests)
            {
                goto label_8;
            }
            
            if(((X3 + 0) + 32 + 28) == 0)
            {
                goto label_7;
            }
            
            val_4 = repeatingQuests - val_4;
            val_4 = val_4 - ((val_4 / ((X3 + 0) + 32 + 28)) * ((X3 + 0) + 32 + 28));
            if(val_4 != null)
            {
                goto label_8;
            }
            
            label_7:
            stage.Add(item:  (X3 + 0) + 32 + 16);
            label_8:
            if((0 + 1) < (X3 + 24))
            {
                goto label_10;
            }
        
        }
        private static void getSingleQuestsForStage(System.Collections.Generic.List<TzarGames.Endless.Quests.EndlessQuest> quests, uint stage, TzarGames.Endless.Quests.SingleQuestInfo[] singleQuests)
        {
            if(X3 == 0)
            {
                    return;
            }
            
            if((X3 + 24) < 1)
            {
                    return;
            }
            
            do
            {
                var val_1 = X3 + 0;
                if(((X3 + 0) + 32 + 24) == singleQuests)
            {
                    stage.Add(item:  (X3 + 0) + 32 + 16);
            }
            
            }
            while((0 + 1) < (X3 + 24));
        
        }
        private static System.Collections.Generic.List<TzarGames.Endless.Quests.EndlessQuest> getAvailableQuestsForStage(TzarGames.Endless.QuestList[] questLists, TzarGames.Common.SerializableData data, uint currentStage, TzarGames.Endless.Quests.RepeatingQuestInfo[] repeatingQuests, TzarGames.Endless.Quests.SingleQuestInfo[] singleQuests)
        {
            var val_54;
            uint val_67;
            TzarGames.Endless.Quests.RepeatingQuestInfo[] val_68;
            uint val_69;
            var val_70;
            var val_71;
            TzarGames.Endless.Quests.IStageQuestsInfo val_72;
            var val_73;
            var val_74;
            var val_75;
            var val_77;
            UnityEngine.Object val_78;
            var val_79;
            System.Collections.Generic.List<TzarGames.Endless.Quests.EndlessQuest> val_80;
            var val_81;
            var val_82;
            var val_83;
            var val_84;
            var val_85;
            var val_86;
            var val_87;
            var val_88;
            var val_89;
            var val_90;
            var val_91;
            System.Collections.Generic.List<T> val_92;
            var val_93;
            val_67 = X5;
            val_68 = repeatingQuests;
            val_69 = currentStage;
            TzarGames.Endless.EndlessGameState val_2 = TzarGames.Endless.EndlessGameState.Instance;
            val_70 = 0;
            if(0 == val_2)
            {
                    return (System.Collections.Generic.List<TzarGames.Endless.Quests.EndlessQuest>)new System.Collections.Generic.List<TzarGames.Endless.Quests.EndlessQuest>();
            }
            
            System.Collections.Generic.List<TzarGames.Endless.QuestList> val_5 = new System.Collections.Generic.List<TzarGames.Endless.QuestList>();
            val_69 = "NULL QUEST";
            val_71 = 0;
            goto label_4;
            label_17:
            val_71 = 1;
            label_4:
            if(val_71 >= data.floats)
            {
                goto label_6;
            }
            
            TzarGames.Common.SerializableData val_6 = data + 8;
            if(0 != ((data + 8).obscuredFloats))
            {
                goto label_10;
            }
            
            UnityEngine.Debug.LogError(message:  0);
            goto label_17;
            label_10:
            Add(item:  (data + 8).obscuredFloats);
            goto label_17;
            label_6:
            int val_8 = Count;
            val_67 = val_69;
            if(val_8 == 0)
            {
                goto label_19;
            }
            
            TzarGames.Endless.Quests.IStageQuestsInfo val_9 = TzarGames.Endless.Quests.QuestUtils.GetStageQuestInfo(data:  val_8, stageNum:  val_67);
            val_72 = val_9;
            if(val_72 == null)
            {
                goto label_20;
            }
            
            typeof(System.Object[]).__il2cppRuntimeField_20 = "Current quest list id: ";
            var val_66 = 0;
            val_66 = val_66 + 1;
            val_73 = val_72;
            goto label_28;
            label_19:
            UnityEngine.Debug.Log(message:  0);
            val_70 = 0;
            return (System.Collections.Generic.List<TzarGames.Endless.Quests.EndlessQuest>)new System.Collections.Generic.List<TzarGames.Endless.Quests.EndlessQuest>();
            label_20:
            val_72 = TzarGames.Endless.Quests.QuestUtils.getStageInfo(data:  val_9, stageNum:  val_67);
            if(val_72 == null)
            {
                goto label_32;
            }
            
            int val_11 = Count;
            val_74 = public TzarGames.Endless.QuestList System.Collections.Generic.List<TzarGames.Endless.QuestList>::get_Item(int index);
            TzarGames.Endless.QuestList val_13 = Item[UnityEngine.Random.Range(min:  0, max:  0)];
            var val_67 = 0;
            val_67 = val_67 + 1;
            val_74 = 1;
            val_75 = val_72;
            goto label_39;
            label_28:
            typeof(System.Object[]).__il2cppRuntimeField_28 = val_72;
            typeof(System.Object[]).__il2cppRuntimeField_2C = 268435457;
            typeof(System.Object[]).__il2cppRuntimeField_30 = " for stage ";
            typeof(System.Object[]).__il2cppRuntimeField_38 = val_68;
            typeof(System.Object[]).__il2cppRuntimeField_3C = 268435457;
            string val_15 = +0;
            goto label_52;
            label_32:
            UnityEngine.Debug.LogError(message:  0);
            val_70 = 0;
            return (System.Collections.Generic.List<TzarGames.Endless.Quests.EndlessQuest>)new System.Collections.Generic.List<TzarGames.Endless.Quests.EndlessQuest>();
            label_39:
            val_68 = val_68;
            TzarGames.Endless.Quests.QuestUtils.SerializeStageQuestInfo(data:  val_72, questInfo:  val_67, stageNum:  val_72);
            val_2.SaveGame();
            var val_68 = 0;
            val_68 = val_68 + 1;
            val_77 = val_72;
            string val_18 = 0 + "Chosen quest list id: "("Chosen quest list id: ");
            label_52:
            UnityEngine.Debug.Log(message:  0);
            List.Enumerator<T> val_19 = GetEnumerator();
            label_73:
            if((0 & 1) == 0)
            {
                goto label_66;
            }
            
            val_78 = val_72.InitializationCallback;
            var val_69 = 0;
            val_69 = val_69 + 1;
            val_79 = val_72;
            if(val_78.Clone() != val_72)
            {
                goto label_73;
            }
            
            goto label_74;
            label_66:
            val_78 = 0;
            label_74:
            val_72.Dispose();
            val_80 = 1152921504617496576;
            if(0 == val_78)
            {
                    var val_70 = 0;
                val_70 = val_70 + 1;
                val_81 = val_72;
                string val_26 = 0 + "Failed to get stage quest list with given ID: "("Failed to get stage quest list with given ID: ");
                UnityEngine.Debug.LogError(message:  0);
                int val_27 = Count;
                val_82 = public TzarGames.Endless.QuestList System.Collections.Generic.List<TzarGames.Endless.QuestList>::get_Item(int index);
                val_78 = Item[UnityEngine.Random.Range(min:  0, max:  0)];
                var val_71 = 0;
                val_71 = val_71 + 1;
                val_82 = 1;
                val_83 = val_72;
                TzarGames.Endless.Quests.QuestUtils.SerializeStageQuestInfo(data:  val_72, questInfo:  val_69, stageNum:  val_72);
                val_2.SaveGame();
                var val_72 = 0;
                val_72 = val_72 + 1;
                val_84 = val_72;
                string val_32 = 0 + "Fallback quest list id: "("Fallback quest list id: ");
                UnityEngine.Debug.Log(message:  0);
            }
            
            val_80 = new System.Collections.Generic.List<TzarGames.Endless.Quests.EndlessQuest>();
            if(null != 0)
            {
                    AddRange(collection:  val_29.quests);
                TzarGames.Endless.Quests.StageQuestManager.getRepeatingQuests(quests:  val_80, stage:  10649600, repeatingQuests:  val_68);
                TzarGames.Endless.Quests.StageQuestManager.getSingleQuestsForStage(quests:  val_80, stage:  10649600, singleQuests:  val_68);
            }
            else
            {
                    AddRange(collection:  val_29.quests);
                TzarGames.Endless.Quests.StageQuestManager.getRepeatingQuests(quests:  val_80, stage:  10649600, repeatingQuests:  val_68);
                TzarGames.Endless.Quests.StageQuestManager.getSingleQuestsForStage(quests:  val_80, stage:  10649600, singleQuests:  val_68);
            }
            
            List.Enumerator<T> val_33 = GetEnumerator();
            label_126:
            if((0 & 1) == 0)
            {
                goto label_106;
            }
            
            if(0 != val_72.InitializationCallback)
            {
                goto label_109;
            }
            
            string val_36 = val_78.Name;
            string val_37 = 0 + "Null quest in quest list ";
            UnityEngine.Debug.LogError(message:  0);
            goto label_126;
            label_109:
            if((val_2.IsStageWithBoss(stage:  val_68)) != false)
            {
                    if(val_2 != 0)
            {
                goto label_126;
            }
            
            }
            
            Unitycoding.UIWidgets.RadialMenuItem val_39 = UnityEngine.Object.Instantiate<Unitycoding.UIWidgets.RadialMenuItem>(original:  0);
            val_39.OnRectTransformDimensionsChange();
            Add(item:  val_39);
            goto label_126;
            label_106:
            val_72.Dispose();
            var val_73 = 0;
            val_73 = val_73 + 1;
            val_85 = val_72;
            if(TzarGames.GameFramework.GameManager.Instance != null)
            {
                    val_86 = null;
                val_86 = null;
                val_87 = 1152921510795593616;
            }
            else
            {
                    val_87 = 1152921510795593616;
            }
            
            System.Collections.Generic.List<TzarGames.Endless.Quests.EndlessQuest> val_46 = new System.Collections.Generic.List<TzarGames.Endless.Quests.EndlessQuest>();
            if(val_72 < 1)
            {
                goto label_143;
            }
            
            var val_80 = 0;
            label_171:
            var val_74 = 0;
            val_74 = val_74 + 1;
            val_88 = val_72;
            int val_75 = Count;
            val_75 = val_75 - 1;
            if((val_75 & 2147483648) != 0)
            {
                goto label_170;
            }
            
            val_89 = public TzarGames.Endless.Quests.EndlessQuest System.Collections.Generic.List<TzarGames.Endless.Quests.EndlessQuest>::get_Item(int index);
            TzarGames.Endless.Quests.EndlessQuest val_49 = Item[val_75];
            if(0 == 0)
            {
                goto label_156;
            }
            
            var val_76 = 0;
            var val_77 = 2945632;
            label_158:
            if(1027 == null)
            {
                goto label_157;
            }
            
            val_76 = val_76 + 1;
            val_77 = val_77 + 16;
            if(val_76 < 0)
            {
                goto label_158;
            }
            
            label_156:
            val_89 = 0;
            val_90 = TzarGames.Endless.Quests.QuestStageInfo.__il2cppRuntimeField_byval_arg;
            goto label_159;
            label_157:
            val_90 = 387193296;
            label_159:
            if(0 == 0)
            {
                goto label_162;
            }
            
            var val_78 = 0;
            var val_79 = 2945632;
            label_164:
            if(1027 == null)
            {
                goto label_163;
            }
            
            val_78 = val_78 + 1;
            val_79 = val_79 + 16;
            if(val_78 < 0)
            {
                goto label_164;
            }
            
            label_162:
            val_89 = 1;
            val_91 = TzarGames.Endless.Quests.QuestStageInfo.__il2cppRuntimeField_byval_arg;
            goto label_165;
            label_163:
            val_91 = 24199837;
            label_165:
            if(val_49 != null)
            {
                
            }
            
            if(null == 1)
            {
                    Add(item:  val_49);
            }
            else
            {
                    val_49.<Owner>k__BackingField = GetCharacterInfoByPlayer(player:  TzarGames.Endless.EndlessGameManager.LocalPlayerCharacter.PlayerOwner);
            }
            
            label_170:
            val_80 = val_80 + 1;
            if(val_80 != val_72)
            {
                goto label_171;
            }
            
            label_143:
            List.Enumerator<T> val_50 = GetEnumerator();
            label_189:
            if((0 & 1) == 0)
            {
                goto label_201;
            }
            
            List.Enumerator<T> val_52 = GetEnumerator();
            label_184:
            if((0 & 1) == 0)
            {
                goto label_175;
            }
            
            System.Action<GooglePlayGames.BasicApi.Nearby.InitializationStatus> val_55 = val_54.InitializationCallback;
            if(((0 == val_55) || ((val_72.InitializationCallback & 1) == 0)) || ((Contains(item:  val_55)) == true))
            {
                goto label_184;
            }
            
            Add(item:  val_55);
            goto label_184;
            label_175:
            val_93 = 1064;
            val_92 = 0;
            val_54.Dispose();
            if((1064 == 1064) || (val_92 == 0))
            {
                goto label_189;
            }
            
            goto label_189;
            label_201:
            val_72.Dispose();
            int val_61 = Count - 1;
            if((val_61 & 2147483648) != 0)
            {
                    return (System.Collections.Generic.List<TzarGames.Endless.Quests.EndlessQuest>)new System.Collections.Generic.List<TzarGames.Endless.Quests.EndlessQuest>();
            }
            
            val_67 = 1152921510796389328;
            val_69 = 1152921510798004064;
            do
            {
                TzarGames.Endless.Quests.EndlessQuest val_62 = Item[val_61];
                if((Contains(item:  val_62)) != false)
            {
                    bool val_65 = Remove(item:  val_62);
                UnityEngine.Object.Destroy(obj:  0);
            }
            
                val_61 = val_61 - 1;
            }
            while((val_61 & 2147483648) == 0);
            
            return (System.Collections.Generic.List<TzarGames.Endless.Quests.EndlessQuest>)new System.Collections.Generic.List<TzarGames.Endless.Quests.EndlessQuest>();
        }
        private void <Awake>m__0(TzarGames.GameFramework.Player player)
        {
            if(this.questsLoaded != false)
            {
                    return;
            }
            
            this.questsLoaded = true;
            UnityEngine.Coroutine val_2 = this.StartCoroutine(routine:  this.loadQuestsAndRewards());
        }
    
    }

}
