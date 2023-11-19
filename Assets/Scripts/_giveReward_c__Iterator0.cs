using UnityEngine;
private sealed class AdsRewardUI.<giveReward>c__Iterator0 : IEnumerator, IDisposable, IEnumerator<object>
{
    // Fields
    internal uint <stage>__0;
    internal TzarGames.Endless.EndlessGameState <game>__0;
    internal TzarGames.Endless.AdRewardInfo <currentAdInfo>__1;
    internal uint <goldReward>__0;
    internal float <goldSpeed>__0;
    internal float <time>__0;
    internal uint <currentGold>__0;
    internal bool checkChance;
    internal int maxItems;
    internal TzarGames.Endless.AdRewardItem[] <items>__0;
    internal TzarGames.Endless.AdRewardItem[] $locvar0;
    internal int $locvar1;
    internal TzarGames.Endless.AdRewardItem <item>__2;
    internal TzarGames.Endless.UI.RewardItemUI <itemUI>__3;
    internal TzarGames.Endless.AdsRewardUI $this;
    internal object $current;
    internal bool $disposing;
    internal int $PC;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    [System.Diagnostics.DebuggerHiddenAttribute]
    public AdsRewardUI.<giveReward>c__Iterator0()
    {
    
    }
    public bool MoveNext()
    {
        var val_27;
        float val_28;
        uint val_29;
        var val_30;
        string val_31;
        var val_32;
        uint val_33;
        TzarGames.Endless.AdRewardInfo val_34;
        var val_35;
        TzarGames.Common.SerializableData val_36;
        TzarGames.Endless.AdRewardItem[] val_37;
        var val_38;
        var val_39;
        int val_40;
        int val_41;
        var val_42;
        TzarGames.Endless.EndlessSaveData val_43;
        TzarGames.Endless.AdsRewardUI val_44;
        var val_45;
        int val_24 = this.$PC;
        this.$PC = 0;
        val_24 = (val_24 < 3) ? (val_24 + 3) : 0;
        if(val_24 == 3)
        {
            goto label_1;
        }
        
        if(val_24 == 4)
        {
            goto label_2;
        }
        
        val_27 = 0;
        if(val_24 != 5)
        {
                return (bool)val_41;
        }
        
        val_28 = this.<time>__0;
        goto label_81;
        label_2:
        float val_2 = UnityEngine.Time.deltaTime;
        val_2 = (this.<time>__0) + val_2;
        this.<time>__0 = val_2;
        float val_3 = UnityEngine.Time.deltaTime;
        val_3 = (this.<goldSpeed>__0) * val_3;
        val_29 = val_24 + (this.<currentGold>__0);
        this.<currentGold>__0 = val_29;
        val_30 = this;
        if(this.$this == null)
        {
                val_29 = this.<currentGold>__0;
        }
        
        val_31 = System.String.Format(format:  0, arg0:  "{0}");
        this.$this.goldValue.text = val_31;
        val_28 = this.<time>__0;
        goto label_9;
        label_1:
        val_30 = this;
        this.$this.getRewardButton.SetActive(value:  false);
        this.$this.goldValue.text = "0";
        TzarGames.Common.Utils.DestroyAllChilds(transform:  this.$this.goldValue);
        this.<stage>__0 = 1;
        this.<game>__0 = TzarGames.Endless.EndlessGameState._instance;
        if(0 == TzarGames.Endless.EndlessGameState._instance)
        {
            goto label_18;
        }
        
        if((this.<game>__0.currentSaveGame) == null)
        {
            goto label_20;
        }
        
        val_33 = this.<game>__0.currentSaveGame.SelectedCharacter;
        if(val_33 != null)
        {
            goto label_21;
        }
        
        goto label_22;
        label_18:
        val_34 = this.$this.adRewards;
        goto label_39;
        label_20:
        val_33 = 0;
        label_22:
        val_32 = 0;
        label_21:
        if(mem[282584257676929] == 0)
        {
            goto label_28;
        }
        
        var val_25 = mem[282584257676823];
        var val_26 = 0;
        val_25 = val_25 + 8;
        label_27:
        if(((mem[282584257676823] + 8) + -8) == null)
        {
            goto label_26;
        }
        
        val_26 = val_26 + 1;
        val_25 = val_25 + 16;
        if(val_26 < mem[282584257676929])
        {
            goto label_27;
        }
        
        goto label_28;
        label_26:
        var val_27 = val_25;
        val_27 = val_27 + 1;
        val_32 = val_32 + val_27;
        val_32 = val_32 + 272;
        label_28:
        this.<stage>__0 = val_33;
        if((this.<game>__0.currentSaveGame) == null)
        {
            goto label_30;
        }
        
        val_36 = this.<game>__0.currentSaveGame.SelectedCharacter;
        if(val_36 != null)
        {
            goto label_31;
        }
        
        goto label_32;
        label_30:
        val_36 = 0;
        label_32:
        val_35 = 0;
        label_31:
        if(mem[282584257676929] == 0)
        {
            goto label_36;
        }
        
        var val_28 = mem[282584257676823];
        var val_29 = 0;
        val_28 = val_28 + 8;
        label_35:
        if(((mem[282584257676823] + 8) + -8) == null)
        {
            goto label_34;
        }
        
        val_29 = val_29 + 1;
        val_28 = val_28 + 16;
        if(val_29 < mem[282584257676929])
        {
            goto label_35;
        }
        
        goto label_36;
        label_34:
        var val_30 = val_28;
        val_30 = val_30 + 6;
        val_35 = val_35 + val_30;
        val_35 = val_35 + 272;
        label_36:
        if((TzarGames.Endless.AdRewardInfo.IsAnyStageAdWatched(data:  val_36)) != false)
        {
                val_34 = this.$this.adRewards;
        }
        else
        {
                val_34 = this.$this.firstAdRewards;
        }
        
        label_39:
        this.<currentAdInfo>__1 = val_34;
        float val_32 = this.$this.firstAdRewards.goldRewardRandomPercent;
        float val_31 = 100f;
        float val_33 = (float)this.$this.firstAdRewards.goldRewardStageMultiplier;
        val_31 = val_32 / val_31;
        val_32 = val_33 * val_31;
        val_33 = -(val_33 * val_31);
        float val_9 = UnityEngine.Random.Range(min:  val_33, max:  val_32);
        val_9 = val_9 + (float)this.$this.firstAdRewards.goldRewardStageMultiplier;
        val_9 = ((float)(double)this.<stage>__0) * val_9;
        this.<goldReward>__0 = this.<stage>__0;
        float val_34 = this.$this.goldCountTime;
        this.<time>__0 = 0f;
        this.<currentGold>__0 = 0;
        val_34 = ((float)(double)this.<stage>__0) / val_34;
        this.<goldSpeed>__0 = val_34;
        val_28 = 0f;
        label_9:
        if(val_28 < 0)
        {
            goto label_43;
        }
        
        this.$this.goldValue.text = System.String.Format(format:  0, arg0:  "{0}");
        this.$this.onGoldFinished.Invoke();
        var val_11 = (this.checkChance == true) ? 1 : 0;
        CodeStage.AntiCheat.ObscuredTypes.ObscuredBool val_12 = CodeStage.AntiCheat.ObscuredTypes.ObscuredBool.op_Implicit(value:  false);
        val_37 = this.<currentAdInfo>__1.TryGetItemRewards(checkChance:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredBool() {currentCryptoKey = val_12.currentCryptoKey, hiddenValue = val_12.hiddenValue, inited = val_12.inited & 4294967295, fakeValue = val_12.inited & 4294967295, fakeValueActive = val_12.inited & 4294967295}, maxCount:  this.maxItems);
        val_38 = this;
        val_39 = this;
        val_40 = 0;
        this.<items>__0 = val_37;
        this.$locvar0 = val_37;
        this.$locvar1 = 0;
        goto label_53;
        label_43:
        val_41 = 1;
        this.$current = 0;
        if(this.$disposing == true)
        {
                return (bool)val_41;
        }
        
        this.$PC = val_41;
        return (bool)val_41;
        label_81:
        if(val_28 < 0)
        {
            goto label_64;
        }
        
        val_44 = this.$this;
        if(this.$this != null)
        {
            goto label_65;
        }
        
        val_44 = this.$this;
        if(val_44 == null)
        {
            goto label_88;
        }
        
        label_65:
        TzarGames.Endless.UI.RewardItemUI val_15 = UnityEngine.Object.Instantiate<TzarGames.Endless.UI.RewardItemUI>(original:  0, parent:  this.$this.rewardItemPrefab);
        this.<itemUI>__3 = val_15;
        val_15.Icon = this.<item>__2.item.Sprite;
        this.<itemUI>__3.Label = TzarGames.Common.LocalizedStringAsset.op_Implicit(text:  0);
        this.$this.onItemFinished.Invoke();
        val_39 = this;
        val_38 = this;
        val_40 = this.$locvar1 + 1;
        this.$locvar1 = val_40;
        val_37 = this.$locvar0;
        label_53:
        if(val_40 >= this.$locvar0.Length)
        {
            goto label_78;
        }
        
        TzarGames.Endless.AdRewardItem[] val_17 = this.$locvar0 + (((this.$locvar1 + 1)) << 3);
        this.<time>__0 = 0f;
        this.<item>__2 = mem[(val_14 + ((this.$locvar1 + 1)) << 3) + 32];
        goto label_81;
        label_78:
        TzarGames.Endless.PlayerCharacter val_18 = TzarGames.Endless.EndlessGameManager.LocalPlayerCharacter;
        val_31 = this.<items>__0;
        val_18.GiveRewardToCharacter(playerCharacter:  val_18, gold:  this.<goldReward>__0, items:  val_31);
        if(0 == (this.<game>__0))
        {
            goto label_85;
        }
        
        val_43 = this.<game>__0.currentSaveGame;
        if(val_43 == null)
        {
            goto label_88;
        }
        
        TzarGames.Endless.EndlessCharacterData val_20 = val_43.SelectedCharacter;
        if(val_20 == null)
        {
            goto label_88;
        }
        
        var val_35 = 0;
        val_35 = val_35 + 1;
        val_45 = val_20;
        goto label_92;
        label_64:
        val_28 = this.<time>__0;
        float val_21 = UnityEngine.Time.deltaTime;
        val_21 = val_28 + val_21;
        this.<time>__0 = val_21;
        this.$current = 0;
        if(this.$disposing != true)
        {
                this.$PC = 2;
        }
        
        val_41 = 1;
        return (bool)val_41;
        label_92:
        val_31 = val_20;
        val_20.IncrementWatchCount(stage:  this.<stage>__0, data:  val_31);
        TzarGames.GameFramework.GameManager.Instance.SaveGameWithPlayerData();
        label_85:
        this.$this.getRewardButton.SetActive(value:  true);
        val_41 = 0;
        this.$PC = 0;
        return (bool)val_41;
        label_88:
        val_42 = ;
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
