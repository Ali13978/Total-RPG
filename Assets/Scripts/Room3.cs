using UnityEngine;
private class FinalBossLogic.Room3 : FinalBossLogic.RoomBaseState
{
    // Methods
    public FinalBossLogic.Room3()
    {
        mem[1152921510684726620] = 1077936128;
        val_1 = new FinalBossLogic.BaseState();
    }
    protected override void Next()
    {
        TzarGames.Endless.FinalBossLogic val_1 = this.Logic;
        this.ForceGotoState<FinalBossLogic.Room4>(stateData:  val_1.room4);
    }

}
