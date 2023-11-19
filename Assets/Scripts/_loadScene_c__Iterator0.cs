using UnityEngine;
private sealed class PrivacyUI.<loadScene>c__Iterator0 : IEnumerator, IDisposable, IEnumerator<object>
{
    // Fields
    internal bool withDelay;
    internal TzarGames.Endless.UI.MainMenu.PrivacyUI $this;
    internal object $current;
    internal bool $disposing;
    internal int $PC;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    [System.Diagnostics.DebuggerHiddenAttribute]
    public PrivacyUI.<loadScene>c__Iterator0()
    {
    
    }
    public bool MoveNext()
    {
        int val_5;
        TzarGames.Endless.UI.MainMenu.PrivacyUI val_6;
        int val_5 = this.$PC;
        this.$PC = 0;
        val_5 = ((val_5 == 1) ? 1 : 0) << 2;
        var val_2 = (val_5 == 0) ? 3 : (val_5);
        if(val_2 != 3)
        {
                val_5 = 0;
            if(val_2 != 4)
        {
                return (bool)val_5;
        }
        
            val_6 = this.$this;
        }
        else
        {
                val_6 = this;
            this.$this.loadingMessage.SetActive(value:  true);
            if(this.withDelay != false)
        {
                val_5 = 1;
            this.$current = new UnityEngine.WaitForSeconds(seconds:  this.$this.nextSceneLoadDelay);
            if(this.$disposing == true)
        {
                return (bool)val_5;
        }
        
            this.$PC = val_5;
            return (bool)val_5;
        }
        
        }
        
        UnityEngine.AsyncOperation val_4 = UnityEngine.SceneManagement.SceneManager.LoadSceneAsync(sceneName:  0);
        val_5 = 0;
        this.$PC = 0;
        return (bool)val_5;
    }
    [System.Diagnostics.DebuggerHiddenAttribute]
    private object System.Collections.Generic.IEnumerator<object>.get_Current()
    {
        return (object)this.$current;
    }
    [System.Diagnostics.DebuggerHiddenAttribute]
    private object System.Collections.IEnumerator.get_Current()
    {
        return (object)this.$current;
    }
    [System.Diagnostics.DebuggerHiddenAttribute]
    public void Dispose()
    {
        this.$disposing = true;
        this.$PC = 0;
    }
    [System.Diagnostics.DebuggerHiddenAttribute]
    public void Reset()
    {
        System.NotSupportedException val_1 = new System.NotSupportedException();
    }

}
