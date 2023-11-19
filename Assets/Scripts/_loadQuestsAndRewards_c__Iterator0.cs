using UnityEngine;
private sealed class StageQuestManager.<loadQuestsAndRewards>c__Iterator0 : IEnumerator, IDisposable, IEnumerator<object>
{
    // Fields
    internal TzarGames.Endless.EndlessGameState <gameState>__0;
    internal TzarGames.Endless.ICharacterInfo <selectedCharacter>__0;
    internal TzarGames.Common.SerializableData <data>__0;
    internal uint <currentStage>__0;
    internal TzarGames.Endless.PlayerCharacter <playerCharacter>__0;
    internal UnityEngine.Coroutine <crt>__1;
    internal uint <prevStage>__0;
    internal System.Collections.Generic.List<TzarGames.Endless.Quests.EndlessQuest> <prevStageQuests>__0;
    internal TzarGames.Endless.Quests.StageQuestManager $this;
    internal object $current;
    internal bool $disposing;
    internal int $PC;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    [System.Diagnostics.DebuggerHiddenAttribute]
    public StageQuestManager.<loadQuestsAndRewards>c__Iterator0()
    {
    
    }
    public bool MoveNext()
    {
        var val_21;
        uint val_22;
        var val_23;
        var val_24;
        TzarGames.Common.SerializableData val_25;
        TzarGames.Common.SerializableData val_26;
        var val_27;
        var val_28;
        System.Collections.Generic.List<TzarGames.Endless.Quests.EndlessQuest> val_29;
        var val_30;
        TzarGames.Endless.QuestList[] val_31;
        TzarGames.Common.SerializableData val_32;
        uint val_33;
        TzarGames.Endless.Quests.StageQuestManager val_34;
        System.Collections.Generic.List<TzarGames.Endless.Quests.EndlessQuest> val_35;
        TzarGames.Endless.Quests.StageQuestManager val_36;
        int val_20 = this.$PC;
        this.$PC = 0;
        val_20 = ((val_20 == 1) ? 1 : 0) << 2;
        var val_2 = (val_20 == 0) ? 3 : (val_20);
        if(val_2 == 3)
        {
            goto label_1;
        }
        
        val_21 = 0;
        if(val_2 != 4)
        {
                return (bool)val_21;
        }
        
        label_36:
        val_22 = (this.<currentStage>__0) - 1;
        this.<prevStage>__0 = val_22;
        val_23 = mem[this.$this];
        if(val_23 == 0)
        {
            goto label_3;
        }
        
        val_24 = this;
        val_25 = mem[mem[this.$this] + 40];
        val_25 = mem[this.$this] + 40;
        val_26 = this.<data>__0;
        val_27 = val_23;
        goto label_17;
        label_1:
        TzarGames.Endless.EndlessGameState val_3 = TzarGames.Endless.EndlessGameState.Instance;
        this.<gameState>__0 = val_3;
        if(0 == val_3)
        {
                val_21 = 0;
            return (bool)val_21;
        }
        
        this.<selectedCharacter>__0 = this.<gameState>__0.SelectedCharacter;
        TzarGames.Endless.ICharacterInfo val_7 = this.<gameState>__0.SelectedCharacter;
        var val_21 = 0;
        val_21 = val_21 + 1;
        val_28 = val_7;
        goto label_15;
        label_3:
        val_24 = this;
        val_26 = this.<data>__0;
        val_27 = mem[this.$this];
        val_25 = mem[mem[this.$this] + 40];
        val_25 = mem[this.$this] + 40;
        val_22 = this.<prevStage>__0;
        if(val_27 == 0)
        {
            goto label_16;
        }
        
        val_23 = val_27;
        goto label_17;
        label_16:
        val_23 = mem[this.$this];
        if(val_23 == 0)
        {
            goto label_38;
        }
        
        label_17:
        this.<prevStageQuests>__0 = TzarGames.Endless.Quests.StageQuestManager.getAvailableQuestsForStage(questLists:  27269, data:  val_25, currentStage:  val_26, repeatingQuests:  val_22, singleQuests:  mem[this.$this] + 48);
        if(mem[this.$this] == 0)
        {
                val_29 = this.<prevStageQuests>__0;
        }
        
        UnityEngine.Coroutine val_11 = mem[this.$this].StartCoroutine(routine:  TzarGames.Endless.Quests.QuestManager.CheckReward(playerCharacter:  val_29, delay:  mem[this.$this] + 56, data:  this.<playerCharacter>__0, currentStage:  val_26, quests:  (this.<currentStage>__0) - 1, saveAsStageQuest:  val_29));
        val_21 = 0;
        this.$PC = 0;
        return (bool)val_21;
        label_15:
        this.<data>__0 = val_7;
        var val_22 = 0;
        val_22 = val_22 + 1;
        val_30 = this.<selectedCharacter>__0;
        this.<currentStage>__0 = this.<selectedCharacter>__0;
        TzarGames.Endless.PlayerCharacter val_14 = TzarGames.Endless.EndlessGameManager.LocalPlayerCharacter;
        this.<playerCharacter>__0 = val_14;
        if(this.$this == null)
        {
            goto label_26;
        }
        
        val_31 = this.$this._questLists;
        val_32 = this.<data>__0;
        val_33 = this.<currentStage>__0;
        val_34 = this.$this;
        goto label_27;
        label_26:
        val_34 = this.$this;
        val_31 = this.$this._questLists;
        val_32 = this.<data>__0;
        val_33 = this.<currentStage>__0;
        if(val_34 == null)
        {
            goto label_28;
        }
        
        label_27:
        val_35 = TzarGames.Endless.Quests.StageQuestManager.getAvailableQuestsForStage(questLists:  val_14, data:  val_31, currentStage:  val_32, repeatingQuests:  val_33, singleQuests:  this.$this.repeatingQuests);
        if(this.$this != null)
        {
            goto label_29;
        }
        
        goto label_30;
        label_28:
        val_35 = TzarGames.Endless.Quests.StageQuestManager.getAvailableQuestsForStage(questLists:  val_14, data:  val_31, currentStage:  val_32, repeatingQuests:  val_33, singleQuests:  this.$this.repeatingQuests);
        label_30:
        label_29:
        mem2[0] = val_35;
        if((mem[this.$this + 24]) == 0)
        {
            goto label_36;
        }
        
        int val_17 = mem[this.$this + 24].Count;
        if(val_17 < 1)
        {
            goto label_36;
        }
        
        val_36 = this.$this;
        if(this.$this != null)
        {
            goto label_37;
        }
        
        val_36 = null;
        if(val_36 == null)
        {
            goto label_38;
        }
        
        label_37:
        UnityEngine.Coroutine val_19 = this.$this.StartCoroutine(routine:  TzarGames.Endless.Quests.QuestManager.CheckReward(playerCharacter:  val_17, delay:  this.$this.rewardCheckDelay, data:  this.<playerCharacter>__0, currentStage:  this.<data>__0, quests:  this.<currentStage>__0, saveAsStageQuest:  mem[this.$this + 24]));
        this.<crt>__1 = val_19;
        this.$current = val_19;
        if(this.$disposing == true)
        {
                return (bool)val_21;
        }
        
        this.$PC = 1;
        return (bool)val_21;
        label_38:
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
    }
    [System.Diagnostics.DebuggerHiddenAttribute]
    public void Reset()
    {
        System.NotSupportedException val_1 = new System.NotSupportedException();
    }

}
