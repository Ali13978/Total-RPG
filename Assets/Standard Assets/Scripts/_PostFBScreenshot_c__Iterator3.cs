using UnityEngine;
private sealed class IOSSocialUseExample.<PostFBScreenshot>c__Iterator3 : IEnumerator, IDisposable, IEnumerator<object>
{
    // Fields
    internal int <width>__0;
    internal int <height>__0;
    internal UnityEngine.Texture2D <tex>__0;
    internal object $current;
    internal bool $disposing;
    internal int $PC;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    [System.Diagnostics.DebuggerHiddenAttribute]
    public IOSSocialUseExample.<PostFBScreenshot>c__Iterator3()
    {
    
    }
    public bool MoveNext()
    {
        int val_8;
        int val_8 = this.$PC;
        this.$PC = 0;
        val_8 = ((val_8 == 1) ? 1 : 0) << 2;
        var val_2 = (val_8 == 0) ? 3 : (val_8);
        if(val_2 != 4)
        {
                val_8 = 0;
            if(val_2 != 3)
        {
                return (bool)val_8;
        }
        
            val_8 = 1;
            this.$current = new UnityEngine.WaitForEndOfFrame();
            if(this.$disposing == true)
        {
                return (bool)val_8;
        }
        
            this.$PC = val_8;
            return (bool)val_8;
        }
        
        this.<width>__0 = UnityEngine.Screen.width;
        int val_5 = UnityEngine.Screen.height;
        this.<height>__0 = val_5;
        this.<tex>__0 = new UnityEngine.Texture2D(width:  this.<width>__0, height:  val_5, format:  3, mipmap:  false);
        ReadPixels(source:  new UnityEngine.Rect() {m_XMin = 0f, m_YMin = 0f, m_Width = 0f, m_Height = 0f}, destX:  0, destY:  0);
        this.<tex>__0.Apply();
        SA.Common.Pattern.Singleton<SA_EditorAd>.Instance.FacebookPost(text:  public static IOSSocialManager SA.Common.Pattern.Singleton<IOSSocialManager>::get_Instance(), url:  0, texture:  0);
        UnityEngine.Object.Destroy(obj:  0);
        val_8 = 0;
        this.$PC = 0;
        return (bool)val_8;
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
