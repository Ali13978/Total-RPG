using UnityEngine;
private sealed class GraphRequest.<TakeScreenshot>c__Iterator0 : IEnumerator, IDisposable, IEnumerator<object>
{
    // Fields
    internal int <width>__0;
    internal int <height>__0;
    internal UnityEngine.Texture2D <tex>__0;
    internal byte[] <screenshot>__0;
    internal UnityEngine.WWWForm <wwwForm>__0;
    internal Facebook.Unity.Example.GraphRequest $this;
    internal object $current;
    internal bool $disposing;
    internal int $PC;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    [System.Diagnostics.DebuggerHiddenAttribute]
    public GraphRequest.<TakeScreenshot>c__Iterator0()
    {
    
    }
    public bool MoveNext()
    {
        int val_10;
        int val_10 = this.$PC;
        this.$PC = 0;
        val_10 = ((val_10 == 1) ? 1 : 0) << 2;
        var val_2 = (val_10 == 0) ? 3 : (val_10);
        if(val_2 != 4)
        {
                val_10 = 0;
            if(val_2 != 3)
        {
                return (bool)val_10;
        }
        
            val_10 = 1;
            this.$current = new UnityEngine.WaitForEndOfFrame();
            if(this.$disposing == true)
        {
                return (bool)val_10;
        }
        
            this.$PC = val_10;
            return (bool)val_10;
        }
        
        this.<width>__0 = UnityEngine.Screen.width;
        int val_5 = UnityEngine.Screen.height;
        this.<height>__0 = val_5;
        this.<tex>__0 = new UnityEngine.Texture2D(width:  this.<width>__0, height:  val_5, format:  3, mipmap:  false);
        ReadPixels(source:  new UnityEngine.Rect() {m_XMin = 0f, m_YMin = 0f, m_Width = 0f, m_Height = 0f}, destX:  0, destY:  0);
        this.<tex>__0.Apply();
        this.<screenshot>__0 = UnityEngine.ImageConversion.EncodeToPNG(tex:  0);
        this.<wwwForm>__0 = new UnityEngine.WWWForm();
        AddBinaryData(fieldName:  "image", contents:  this.<screenshot>__0, fileName:  "InteractiveConsole.png");
        this.<wwwForm>__0.AddField(fieldName:  "message", value:  "herp derp.  I did a thing!  Did I do this right?");
        Facebook.Unity.FB.API(query:  0, method:  "me/photos", callback:  1, formData:  new Facebook.Unity.FacebookDelegate<Facebook.Unity.IGraphResult>(object:  this.$this, method:  System.Void Facebook.Unity.Example.MenuBase::HandleResult(Facebook.Unity.IResult result)));
        val_10 = 0;
        this.$PC = 0;
        return (bool)val_10;
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
