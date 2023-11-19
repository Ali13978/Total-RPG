using UnityEngine;
private class FinalBossLogic.Final : FinalBossLogic.BaseState
{
    // Methods
    public FinalBossLogic.Final()
    {
    
    }
    public override void OnStateBegin(StateMachine.State prevState)
    {
        prevState.OnStateBegin(prevState:  prevState);
        TzarGames.Endless.FinalBossLogic val_1 = this.Logic;
        TzarGames.Endless.FinalBossLogic val_2 = this.Logic;
        val_1.bossAI.SetDefendPoint(point:  val_2.final_defendPoint);
    }

}
