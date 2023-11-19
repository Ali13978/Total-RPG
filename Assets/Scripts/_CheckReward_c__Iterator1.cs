using UnityEngine;
private sealed class QuestManager.<CheckReward>c__Iterator1 : IEnumerator, IDisposable, IEnumerator<object>
{
    // Fields
    internal float delay;
    internal bool <needSave>__0;
    internal System.Collections.Generic.List<TzarGames.Endless.Quests.EndlessQuest> <rewardedQuests>__0;
    internal System.Collections.Generic.List<TzarGames.Endless.Quests.EndlessQuest> quests;
    internal bool saveAsStageQuest;
    internal TzarGames.Common.SerializableData data;
    internal uint currentStage;
    internal System.Collections.Generic.List.Enumerator<TzarGames.Endless.Quests.EndlessQuest> $locvar0;
    internal TzarGames.Endless.Quests.EndlessQuest <rewardedQuest>__1;
    internal TzarGames.Endless.PlayerCharacter playerCharacter;
    internal object $current;
    internal bool $disposing;
    internal int $PC;
    private TzarGames.Endless.Quests.QuestManager.<CheckReward>c__Iterator1.<CheckReward>c__AnonStorey3 $locvar1;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    [System.Diagnostics.DebuggerHiddenAttribute]
    public QuestManager.<CheckReward>c__Iterator1()
    {
    
    }
    public bool MoveNext()
    {
        var val_15;
        List.Enumerator<TzarGames.Endless.Quests.EndlessQuest> val_16;
        int val_25;
        <CheckReward>c__AnonStorey3 val_26;
        System.Collections.Generic.List<TzarGames.Endless.Quests.EndlessQuest> val_27;
        System.Action val_28;
        <CheckReward>c__AnonStorey3 val_29;
        var val_30;
        var val_31;
        var val_32;
        this.$PC = 0;
        var val_2 = (this.$PC < 3) ? (this.$PC + 3) : 0;
        if(val_2 == 5)
        {
            goto label_1;
        }
        
        if(val_2 == 4)
        {
            goto label_2;
        }
        
        val_25 = 0;
        if(val_2 != 3)
        {
                return (bool)val_25;
        }
        
        val_25 = 1;
        this.$current = new UnityEngine.WaitForSeconds(seconds:  this.delay);
        if(this.$disposing == true)
        {
                return (bool)val_25;
        }
        
        this.$PC = val_25;
        return (bool)val_25;
        label_1:
        if(this.$PC != 2)
        {
            goto label_41;
        }
        
        val_26 = this.$locvar1;
        goto label_7;
        label_2:
        if(0 == TzarGames.Endless.EndlessGameState.Instance)
        {
                UnityEngine.Debug.LogError(message:  0);
            val_25 = 0;
            return (bool)val_25;
        }
        
        this.<needSave>__0 = false;
        System.Collections.Generic.List<TzarGames.Endless.Quests.EndlessQuest> val_6 = null;
        val_27 = val_6;
        val_6 = new System.Collections.Generic.List<TzarGames.Endless.Quests.EndlessQuest>();
        System.Collections.Generic.List<TzarGames.Endless.Quests.EndlessQuest> val_24 = this.quests;
        this.<rewardedQuests>__0 = val_27;
        val_24 = val_24.Count - 1;
        if((val_24 & 2147483648) == 0)
        {
                val_28 = 1152921510796389328;
            val_29 = 1152921510796670672;
            do
        {
            val_27 = this.quests.Item[val_24];
            if((1152921510796388304 != 1) && (((val_27 & 1) & 1) != 0))
        {
                mem2[0] = true;
            this.<rewardedQuests>__0.Add(item:  val_27);
            if(this.saveAsStageQuest != false)
        {
                TzarGames.Endless.Quests.QuestUtils.SetStageQuestData(data:  this.<rewardedQuests>__0, stageNum:  this.data, quest:  this.currentStage);
        }
        else
        {
                TzarGames.Endless.Quests.QuestUtils.SetQuestData(data:  this.<rewardedQuests>__0, quest:  this.data);
        }
        
            bool val_10 = this.quests.Remove(item:  val_27);
            this.<needSave>__0 = true;
            TzarGames.Endless.ICharacterInfo val_12 = TzarGames.Endless.EndlessGameState.Instance.SelectedCharacter;
            var val_25 = 0;
            val_25 = val_25 + 1;
            val_30 = val_12;
            val_31 = val_12;
            if(val_31 != null)
        {
            
        }
        else
        {
                val_27 = 0;
            val_31 = 44;
        }
        
            mem[44] = 1;
        }
        
            val_24 = val_24 - 1;
        }
        while((val_24 & 2147483648) == 0);
        
        }
        
        List.Enumerator<T> val_14 = this.<rewardedQuests>__0.GetEnumerator();
        mem[1152921510798108144] = val_15;
        this.$locvar0 = val_16;
        label_41:
        if(((this.$locvar0 & 1) & 1) == 0)
        {
            goto label_34;
        }
        
        this.<rewardedQuest>__1 = this.$locvar0.InitializationCallback;
        object val_19 = new System.Object();
        val_26 = this;
        this.$locvar1 = null;
        typeof(QuestManager.<CheckReward>c__Iterator1.<CheckReward>c__AnonStorey3).__il2cppRuntimeField_18 = this;
        this.$locvar1.isCompleted = false;
        val_27 = this.currentStage;
        val_29 = this.$locvar1;
        val_28 = null;
        val_28 = new System.Action(object:  val_29, method:  System.Void QuestManager.<CheckReward>c__Iterator1.<CheckReward>c__AnonStorey3::<>m__0());
        TzarGames.Endless.Quests.QuestManager.RewardCharacterForQuest(character:  val_28, currentStage:  this.playerCharacter, quest:  val_27, completeCallback:  this.<rewardedQuest>__1);
        label_7:
        if((QuestManager.<CheckReward>c__Iterator1.<CheckReward>c__AnonStorey3) == null)
        {
            goto label_38;
        }
        
        UnityEngine.Object.Destroy(obj:  0);
        goto label_41;
        label_34:
        this.$locvar0.Dispose();
        ulong val_21 = this.playerCharacter.Gold;
        string val_22 = 0 + "Total gold after reward: "("Total gold after reward: ");
        UnityEngine.Debug.Log(message:  0);
        if((this.<needSave>__0) == false)
        {
            goto label_49;
        }
        
        TzarGames.GameFramework.GameManager val_23 = TzarGames.GameFramework.GameManager.Instance;
        if(val_23 == null)
        {
            goto label_52;
        }
        
        val_27 = 1152921504861052928;
        val_32 = null;
        val_32 = null;
        val_23 = (((TzarGames.GameFramework.GameManager.__il2cppRuntimeField_typeHierarchy + (TzarGames.Endless.EndlessGameManager.__il2cppRuntimeField_typeHierarchyDepth) << 3) + -8) == val_32) ? (val_23) : 0;
        goto label_56;
        label_38:
        this.$current = 0;
        if(this.$disposing != true)
        {
                this.$PC = 2;
        }
        
        val_25 = 1;
        return (bool)val_25;
        label_52:
        label_56:
        0.SaveGameWithPlayerData();
        label_49:
        val_25 = 0;
        this.$PC = 0;
        return (bool)val_25;
    }
    [System.Diagnostics.DebuggerHiddenAttribute]
    private object System.Collections.Generic.IEnumerator<object>.get_Current()
    {
        return (object)this.$current;
    }
    [System.Diagnostics.DebuggerHiddenAttribute]
    private object System.Collections.IEnumerator.get_Current()
    {
        return (object)this.$current;
    }
    [System.Diagnostics.DebuggerHiddenAttribute]
    public void Dispose()
    {
        this.$disposing = true;
        this.$PC = 0;
        if(this.$PC != 2)
        {
                return;
        }
        
        this.$locvar0.Dispose();
    }
    [System.Diagnostics.DebuggerHiddenAttribute]
    public void Reset()
    {
        System.NotSupportedException val_1 = new System.NotSupportedException();
    }

}
