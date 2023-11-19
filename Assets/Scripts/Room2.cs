using UnityEngine;
private class FinalBossLogic.Room2 : FinalBossLogic.RoomBaseState
{
    // Methods
    public FinalBossLogic.Room2()
    {
        mem[1152921510684485212] = 1077936128;
        val_1 = new FinalBossLogic.BaseState();
    }
    protected override void Next()
    {
        TzarGames.Endless.FinalBossLogic val_1 = this.Logic;
        this.ForceGotoState<FinalBossLogic.Room3>(stateData:  val_1.room3);
    }

}
