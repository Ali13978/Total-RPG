using UnityEngine;
private sealed class ObbManager.<loadNextScene>c__Iterator1 : IEnumerator, IDisposable, IEnumerator<object>
{
    // Fields
    internal ObbManager $this;
    internal object $current;
    internal bool $disposing;
    internal int $PC;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    [System.Diagnostics.DebuggerHiddenAttribute]
    public ObbManager.<loadNextScene>c__Iterator1()
    {
    
    }
    public bool MoveNext()
    {
        int val_6;
        ObbManager val_7;
        string val_8;
        int val_6 = this.$PC;
        this.$PC = 0;
        val_6 = ((val_6 == 1) ? 1 : 0) << 2;
        var val_2 = (val_6 == 0) ? 3 : (val_6);
        if(val_2 == 4)
        {
            goto label_1;
        }
        
        val_6 = 0;
        if(val_2 != 3)
        {
                return (bool)val_6;
        }
        
        val_7 = this.$this;
        if(this.$this != null)
        {
            goto label_3;
        }
        
        val_7 = this.$this;
        if(val_7 == null)
        {
            goto label_4;
        }
        
        label_3:
        val_8 = this.$this.preparingResources.Text;
        this.$this.statusText.text = val_8;
        val_6 = 1;
        this.$current = 0;
        if(this.$disposing == true)
        {
                return (bool)val_6;
        }
        
        this.$PC = val_6;
        return (bool)val_6;
        label_1:
        string val_4 = 0 + "Loading ";
        UnityEngine.Debug.Log(message:  0);
        val_8 = this.$this;
        if(TzarGames.Common.Privacy.PrivacyAnswerGiven != false)
        {
            
        }
        
        UnityEngine.SceneManagement.SceneManager.LoadScene(sceneName:  0);
        val_6 = 0;
        this.$PC = 0;
        return (bool)val_6;
        label_4:
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
