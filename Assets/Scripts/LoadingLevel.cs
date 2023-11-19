using UnityEngine;
private class GameBundleLoader.LoadingLevel : GameBundleLoader.BaseState
{
    // Fields
    private AssetBundles.AssetBundleLoadOperation request;
    
    // Methods
    public GameBundleLoader.LoadingLevel()
    {
    
    }
    public override void OnStateBegin(StateMachine.State prevState)
    {
        this.OnStateBegin(prevState:  prevState);
        this.request = 0;
        TzarGames.Endless.GameBundleLoader val_1 = this.Loader;
        TzarGames.Endless.GameBundleLoader val_2 = this.Loader;
        this.setStatus(status:  TzarGames.Common.LocalizedStringAsset.op_Implicit(text:  0));
        this.updateProgress(progress:  0f);
        TzarGames.Endless.GameBundleLoader val_5 = this.Loader;
        UnityEngine.Coroutine val_7 = this.Loader.StartCoroutine(routine:  this.InitializeLevelAsync(levelName:  val_5.sceneName));
    }
    public override void OnStateEnd(StateMachine.State nextState)
    {
        nextState.OnStateEnd(nextState:  nextState);
        TzarGames.Endless.GameBundleLoader val_1 = this.Loader;
        if(val_1.loadingUI == null)
        {
            
        }
    
    }
    [System.Diagnostics.DebuggerHiddenAttribute]
    protected System.Collections.IEnumerator InitializeLevelAsync(string levelName)
    {
        if(null != 0)
        {
                typeof(GameBundleLoader.LoadingLevel.<InitializeLevelAsync>c__Iterator0).__il2cppRuntimeField_20 = levelName;
        }
        else
        {
                mem[32] = levelName;
        }
        
        typeof(GameBundleLoader.LoadingLevel.<InitializeLevelAsync>c__Iterator0).__il2cppRuntimeField_38 = this;
        return (System.Collections.IEnumerator)new System.Object();
    }
    private void updateProgress(float progress)
    {
        TzarGames.Endless.GameBundleLoader val_1 = this.Loader;
        TzarGames.Endless.GameBundleLoader val_2 = this.Loader;
        double val_7 = (double)progress;
        val_7 = val_7 * (double)val_2.downloadSize;
        double val_3 = (double)val_2.downloadSize * (9.5367431640625E-07);
        TzarGames.Endless.GameBundleLoader val_5 = this.Loader;
        val_5.progressText.text = System.String.Format(format:  0, arg0:  "{0:0.0} / {1:0.0} Mb", arg1:  val_7 * (9.5367431640625E-07));
    }

}
