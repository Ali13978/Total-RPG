using UnityEngine;
private sealed class PlayGamesUserProfile.<LoadImage>c__Iterator0 : IEnumerator, IDisposable, IEnumerator<object>
{
    // Fields
    internal UnityEngine.WWW <www>__1;
    internal GooglePlayGames.PlayGamesUserProfile $this;
    internal object $current;
    internal bool $disposing;
    internal int $PC;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    [System.Diagnostics.DebuggerHiddenAttribute]
    public PlayGamesUserProfile.<LoadImage>c__Iterator0()
    {
    
    }
    public bool MoveNext()
    {
        int val_13;
        GooglePlayGames.PlayGamesUserProfile val_14;
        UnityEngine.WWW val_15;
        int val_13 = this.$PC;
        this.$PC = 0;
        val_13 = ((val_13 == 1) ? 1 : 0) << 2;
        var val_2 = (val_13 == 0) ? 3 : (val_13);
        if(val_2 == 3)
        {
            goto label_1;
        }
        
        val_13 = 0;
        if(val_2 != 4)
        {
                return (bool)val_13;
        }
        
        val_14 = this;
        val_15 = this.<www>__1;
        goto label_3;
        label_1:
        if((System.String.IsNullOrEmpty(value:  0)) == false)
        {
            goto label_7;
        }
        
        UnityEngine.Debug.Log(message:  0);
        val_14 = this.$this;
        this.$this.mImage = UnityEngine.Texture2D.blackTexture;
        goto label_23;
        label_7:
        UnityEngine.WWW val_6 = null;
        val_15 = val_6;
        val_6 = new UnityEngine.WWW(url:  this.$this.mAvatarUrl);
        val_14 = this;
        this.<www>__1 = val_15;
        label_3:
        if(isDone == false)
        {
            goto label_14;
        }
        
        if(error == null)
        {
            goto label_16;
        }
        
        this.$this.mImage = UnityEngine.Texture2D.blackTexture;
        string val_10 = error;
        string val_11 = 0 + "Error downloading image: "("Error downloading image: ");
        UnityEngine.Debug.Log(message:  0);
        goto label_23;
        label_14:
        val_13 = 1;
        this.$current = 0;
        if(this.$disposing == true)
        {
                return (bool)val_13;
        }
        
        this.$PC = val_13;
        return (bool)val_13;
        label_16:
        this.$this.mImage = texture;
        label_23:
        val_13 = 0;
        this.$this.mImageLoading = false;
        this.$PC = 0;
        return (bool)val_13;
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
