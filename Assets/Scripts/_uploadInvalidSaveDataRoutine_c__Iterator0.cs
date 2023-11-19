using UnityEngine;
private sealed class RestoreFailedSaveDataUI.<uploadInvalidSaveDataRoutine>c__Iterator0 : IEnumerator, IDisposable, IEnumerator<object>
{
    // Fields
    internal byte[] <zipFileBytes>__0;
    internal UnityEngine.WWWForm <form>__0;
    internal string <url>__0;
    internal UnityEngine.Networking.UnityWebRequest <w>__2;
    internal TzarGames.Endless.UI.MainMenu.RestoreFailedSaveDataUI $this;
    internal object $current;
    internal bool $disposing;
    internal int $PC;
    private TzarGames.Endless.UI.MainMenu.RestoreFailedSaveDataUI.<uploadInvalidSaveDataRoutine>c__Iterator0.<uploadInvalidSaveDataRoutine>c__AnonStorey2 $locvar0;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    [System.Diagnostics.DebuggerHiddenAttribute]
    public RestoreFailedSaveDataUI.<uploadInvalidSaveDataRoutine>c__Iterator0()
    {
    
    }
    public bool MoveNext()
    {
        RestoreFailedSaveDataUI.<uploadInvalidSaveDataRoutine>c__Iterator0 val_23;
        int val_24;
        <uploadInvalidSaveDataRoutine>c__AnonStorey2 val_25;
        <uploadInvalidSaveDataRoutine>c__AnonStorey2 val_26;
        UnityEngine.Networking.UnityWebRequest val_27;
        TzarGames.Endless.UI.MainMenu.RestoreFailedSaveDataUI val_28;
        Status val_29;
        val_23 = this;
        this.$PC = 0;
        var val_2 = (this.$PC < 3) ? (this.$PC + 3) : 0;
        if(val_2 == 3)
        {
            goto label_1;
        }
        
        if(val_2 == 5)
        {
            goto label_2;
        }
        
        val_24 = 0;
        if(val_2 != 4)
        {
                return (bool)val_24;
        }
        
        val_25 = this.$locvar0;
        goto label_4;
        label_1:
        if(TzarGames.Common.Privacy.CanCollectData == false)
        {
            goto label_11;
        }
        
        if(TzarGames.Endless.FacebookPlatform.IsLoggedIn == true)
        {
            goto label_14;
        }
        
        val_25 = val_23;
        this.$locvar0 = new System.Object();
        typeof(RestoreFailedSaveDataUI.<uploadInvalidSaveDataRoutine>c__Iterator0.<uploadInvalidSaveDataRoutine>c__AnonStorey2).__il2cppRuntimeField_18 = val_23;
        this.$locvar0.waiting = true;
        val_26 = this.$locvar0;
        System.Action<System.Boolean> val_8 = new System.Action<System.Boolean>(object:  val_26, method:  System.Void RestoreFailedSaveDataUI.<uploadInvalidSaveDataRoutine>c__Iterator0.<uploadInvalidSaveDataRoutine>c__AnonStorey2::<>m__0(bool result));
        TzarGames.Endless.FacebookPlatform.Login(callback:  0);
        label_4:
        if((RestoreFailedSaveDataUI.<uploadInvalidSaveDataRoutine>c__Iterator0.<uploadInvalidSaveDataRoutine>c__AnonStorey2) == null)
        {
            goto label_20;
        }
        
        val_24 = 1;
        this.$current = 0;
        if(this.$disposing == true)
        {
                return (bool)val_24;
        }
        
        this.$PC = val_24;
        return (bool)val_24;
        label_2:
        val_27 = this.<w>__2;
        if(this.$PC != 2)
        {
            goto label_23;
        }
        
        if(val_27.isNetworkError != true)
        {
                if((this.<w>__2.isHttpError) == false)
        {
            goto label_27;
        }
        
        }
        
        string val_12 = this.<w>__2.error;
        UnityEngine.MonoBehaviour.print(message:  0);
        val_26 = this.<w>__2.error;
        this.$this.showResultScreen(status:  val_26);
        this.$this.loadCoroutine = 0;
        this.<>__Finally0();
        val_24 = 0;
        return (bool)val_24;
        label_11:
        UnityEngine.Debug.LogError(message:  0);
        val_28 = this.$this;
        val_29 = 4;
        goto label_52;
        label_20:
        if(TzarGames.Endless.FacebookPlatform.IsLoggedIn == false)
        {
            goto label_39;
        }
        
        label_14:
        System.Byte[] val_16 = TzarGames.Endless.EndlessSaveManager.GetInvalidFilesArchive();
        this.<zipFileBytes>__0 = val_16;
        if(val_16 == null)
        {
            goto label_40;
        }
        
        this.<form>__0 = new UnityEngine.WWWForm();
        AddBinaryData(fieldName:  "file", contents:  this.<zipFileBytes>__0, fileName:  "invalidFiles.zip", mimeType:  "multipart/form-data");
        val_26 = TzarGames.Endless.EndlessSaveManager.GetDeviceID();
        string val_20 = System.String.Format(format:  0, arg0:  "{0}uploadinvalidfile?fb_user_token={1}&device_id={2}", arg1:  "http://total-rpg-web-services.azurewebsites.net/", arg2:  TzarGames.Endless.FacebookPlatform.AccessToken);
        this.<url>__0 = val_20;
        val_27 = UnityEngine.Networking.UnityWebRequest.Post(uri:  0, formData:  val_20);
        this.<w>__2 = val_27;
        label_23:
        this.$current = val_27.SendWebRequest();
        if(this.$disposing != true)
        {
                this.$PC = 2;
        }
        
        val_24 = 1;
        return (bool)val_24;
        label_39:
        UnityEngine.Debug.LogError(message:  0);
        val_28 = this.$this;
        val_29 = 0;
        goto label_52;
        label_40:
        UnityEngine.Debug.Log(message:  0);
        val_28 = this.$this;
        val_29 = 1;
        label_52:
        val_28.showResultScreen(status:  val_29);
        val_23 = this.$this;
        val_24 = 0;
        this.$this.loadCoroutine = 0;
        return (bool)val_24;
        label_27:
        UnityEngine.MonoBehaviour.print(message:  0);
        this.<>__Finally0();
        this.$this.loadCoroutine = 0;
        this.$PC = 0;
        return (bool)val_24;
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
        if(this.$PC != 2)
        {
                return;
        }
        
        this.<>__Finally0();
    }
    [System.Diagnostics.DebuggerHiddenAttribute]
    public void Reset()
    {
        System.NotSupportedException val_1 = new System.NotSupportedException();
    }
    private void <>__Finally0()
    {
        var val_2;
        if((this.<w>__2) == null)
        {
                return;
        }
        
        var val_2 = 0;
        val_2 = val_2 + 1;
        val_2 = this.<w>__2;
    }

}
