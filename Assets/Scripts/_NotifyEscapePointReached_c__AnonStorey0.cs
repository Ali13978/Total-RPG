using UnityEngine;
private sealed class FinalBossLogic.RoomBaseState.<NotifyEscapePointReached>c__AnonStorey0
{
    // Fields
    internal TzarGames.TzarHero.TH_Character boss;
    internal TzarGames.Endless.FinalBossLogic.RoomBaseState $this;
    
    // Methods
    public FinalBossLogic.RoomBaseState.<NotifyEscapePointReached>c__AnonStorey0()
    {
    
    }
    internal void <>m__0()
    {
        var val_11;
        var val_12;
        this.$this.isEscaping = false;
        var val_11 = 0;
        val_11 = val_11 + 1;
        val_11 = this.boss.Movement;
        TzarGames.Endless.FinalBossLogic val_3 = this.$this.Logic;
        val_3.bossAI.enabled = true;
        TzarGames.Endless.FinalBossLogic val_4 = this.$this.Logic;
        val_12 = 0;
        goto label_14;
        label_19:
        X21.enabled = true;
        val_12 = 1;
        label_14:
        if(val_12 >= val_5.Length)
        {
            goto label_16;
        }
        
        if((val_4.bossAI.GetComponents<TzarGames.TzarHero.Skills.BasicSkillAI>()[1]) != 0)
        {
            goto label_19;
        }
        
        goto label_19;
        label_16:
        TzarGames.Endless.FinalBossLogic val_7 = this.$this.Logic;
        string val_8 = val_7.bossDefaultLayer.Name;
        this.boss.gameObject.layer = UnityEngine.LayerMask.NameToLayer(layerName:  0);
        this.boss.IgnoreDamage.RemoveModificator(owner:  this.$this);
        this.$this.room.OnBossEscaped.Invoke();
    }

}
