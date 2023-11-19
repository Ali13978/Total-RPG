using UnityEngine;
[DefaultState]
private class GameBundleLoader.Initialization : GameBundleLoader.BaseState
{
    // Methods
    public GameBundleLoader.Initialization()
    {
    
    }
    public override void OnStateBegin(StateMachine.State prevState)
    {
        this.OnStateBegin(prevState:  prevState);
        TzarGames.Endless.GameBundleLoader val_1 = this.Loader;
        this.setStatus(status:  TzarGames.Common.LocalizedStringAsset.op_Implicit(text:  0));
        UnityEngine.Coroutine val_5 = this.Loader.StartCoroutine(routine:  this.Initialize());
    }
    public override void OnStateEnd(StateMachine.State nextState)
    {
        nextState.OnStateEnd(nextState:  nextState);
    }
    [System.Diagnostics.DebuggerHiddenAttribute]
    protected System.Collections.IEnumerator Initialize()
    {
        typeof(GameBundleLoader.Initialization.<Initialize>c__Iterator0).__il2cppRuntimeField_38 = this;
        return (System.Collections.IEnumerator)new System.Object();
    }

}
