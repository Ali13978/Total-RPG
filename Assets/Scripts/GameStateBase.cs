using UnityEngine;
private class EndlessGameState.GameStateBase : StateMachine.State
{
    // Properties
    public TzarGames.Endless.EndlessGameState GameState { get; }
    
    // Methods
    public EndlessGameState.GameStateBase()
    {
    
    }
    public TzarGames.Endless.EndlessGameState get_GameState()
    {
        if(this.Owner == null)
        {
                return (TzarGames.Endless.EndlessGameState);
        }
        
        0 = 0;
        return (TzarGames.Endless.EndlessGameState);
    }
    public virtual void LoadSceneAsync(string sceneName, bool unloadUnusedAssets = True, System.Action loadedCallback)
    {
        unloadUnusedAssets = unloadUnusedAssets;
        UnityEngine.Coroutine val_3 = this.GameState.StartCoroutine(routine:  this.loadSceneRoutine(sceneName:  sceneName, unloadUnusedAssets:  unloadUnusedAssets, loadedCallback:  loadedCallback));
    }
    [System.Diagnostics.DebuggerHiddenAttribute]
    private System.Collections.IEnumerator loadSceneRoutine(string sceneName, bool unloadUnusedAssets, System.Action loadedCallback)
    {
        if(null != 0)
        {
                typeof(EndlessGameState.GameStateBase.<loadSceneRoutine>c__Iterator0).__il2cppRuntimeField_10 = sceneName;
            typeof(EndlessGameState.GameStateBase.<loadSceneRoutine>c__Iterator0).__il2cppRuntimeField_24 = unloadUnusedAssets;
            typeof(EndlessGameState.GameStateBase.<loadSceneRoutine>c__Iterator0).__il2cppRuntimeField_28 = loadedCallback;
        }
        else
        {
                mem[16] = sceneName;
            typeof(EndlessGameState.GameStateBase.<loadSceneRoutine>c__Iterator0).__il2cppRuntimeField_24 = unloadUnusedAssets;
            mem[40] = loadedCallback;
        }
        
        typeof(EndlessGameState.GameStateBase.<loadSceneRoutine>c__Iterator0).__il2cppRuntimeField_30 = this;
        return (System.Collections.IEnumerator)new System.Object();
    }
    public virtual void OnSceneLoaded(UnityEngine.SceneManagement.Scene scene, UnityEngine.SceneManagement.LoadSceneMode mode)
    {
    
    }

}
