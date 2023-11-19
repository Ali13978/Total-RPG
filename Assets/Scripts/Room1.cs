using UnityEngine;
private class FinalBossLogic.Room1 : FinalBossLogic.RoomBaseState
{
    // Methods
    public FinalBossLogic.Room1()
    {
        mem[1152921510684243804] = 1077936128;
        val_1 = new FinalBossLogic.BaseState();
    }
    protected override void Next()
    {
        TzarGames.Endless.FinalBossLogic val_1 = this.Logic;
        this.ForceGotoState<FinalBossLogic.Room2>(stateData:  val_1.room2);
    }

}
