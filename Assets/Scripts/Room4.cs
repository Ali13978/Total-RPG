using UnityEngine;
private class FinalBossLogic.Room4 : FinalBossLogic.RoomBaseState
{
    // Methods
    public FinalBossLogic.Room4()
    {
        mem[1152921510684968028] = 1077936128;
        val_1 = new FinalBossLogic.BaseState();
    }
    protected override void Next()
    {
        this.ForceGotoState<FinalBossLogic.Final>(stateData:  0);
    }

}
