using UnityEngine;
private class GameBundleLoader.Failed : GameBundleLoader.BaseState
{
    // Methods
    public GameBundleLoader.Failed()
    {
    
    }
    public override void OnStateBegin(StateMachine.State prevState)
    {
        this.OnStateBegin(prevState:  prevState);
        TzarGames.Endless.GameBundleLoader val_1 = this.Loader;
        if(prevState == null)
        {
                return;
        }
        
        TzarGames.Endless.GameBundleLoader val_2 = this.Loader;
        this = val_2.OnLoadingFailed;
        this.Invoke();
    }
    public override void OnStateEnd(StateMachine.State nextState)
    {
        nextState.OnStateEnd(nextState:  nextState);
        TzarGames.Endless.GameBundleLoader val_1 = this.Loader;
        if(val_1.failedUI == null)
        {
            
        }
    
    }

}
