using UnityEngine;
[DefaultState]
private class EndlessGameState.Initial : EndlessGameState.GameStateBase
{
    // Methods
    public EndlessGameState.Initial()
    {
    
    }
    public override void OnStateBegin(StateMachine.State prevState)
    {
        prevState.OnStateBegin(prevState:  prevState);
        TzarGames.Endless.EndlessGameState val_1 = this.GameState;
        CodeStage.AntiCheat.ObscuredTypes.ObscuredBool val_2 = TzarGames.Endless.EndlessGameState.GenuineCheckFailed;
        TzarGames.Endless.EndlessGameState val_3 = this.GameState;
        if((CodeStage.AntiCheat.ObscuredTypes.ObscuredBool.op_Implicit(value:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredBool() {inited = val_3.doGenuineCheck, fakeValue = val_3.doGenuineCheck, fakeValueActive = val_3.doGenuineCheck})) != false)
        {
                if(UnityEngine.Application.genuineCheckAvailable != false)
        {
                if(UnityEngine.Application.genuine == false)
        {
            goto label_7;
        }
        
        }
        
        }
        
        UnityEngine.Debug.Log(message:  0);
        UnityEngine.Debug.Log(message:  0);
        this.GameState.beginLoadGame();
        return;
        label_7:
        CodeStage.AntiCheat.ObscuredTypes.ObscuredBool val_9 = CodeStage.AntiCheat.ObscuredTypes.ObscuredBool.op_Implicit(value:  false);
        bool val_10 = val_9.inited & 4294967295;
        TzarGames.Endless.EndlessGameState.GenuineCheckFailed = new CodeStage.AntiCheat.ObscuredTypes.ObscuredBool() {inited = val_9.currentCryptoKey, fakeValue = val_9.currentCryptoKey, fakeValueActive = val_9.currentCryptoKey};
        if(TzarGames.Endless.EndlessGameState.OnGenuineCheckFailed == null)
        {
                return;
        }
        
        TzarGames.Endless.EndlessGameState.OnGenuineCheckFailed.Invoke();
    }
    public override void OnStateEnd(StateMachine.State nextState)
    {
        nextState.OnStateEnd(nextState:  nextState);
        if(TzarGames.Endless.EndlessGameState.OnInitializationFinished == null)
        {
                return;
        }
        
        TzarGames.Endless.EndlessGameState.OnInitializationFinished.Invoke();
    }

}
