using UnityEngine;
private sealed class RestoreFailedSaveDataUI.<downloadFixedSaveDataRoutine>c__Iterator1 : IEnumerator, IDisposable, IEnumerator<object>
{
    // Fields
    internal string <url>__0;
    internal UnityEngine.WWW <www>__2;
    internal string <json>__3;
    internal TzarGames.Endless.EndlessSaveData <data>__4;
    internal TzarGames.Endless.UI.MainMenu.RestoreFailedSaveDataUI $this;
    internal object $current;
    internal bool $disposing;
    internal int $PC;
    private TzarGames.Endless.UI.MainMenu.RestoreFailedSaveDataUI.<downloadFixedSaveDataRoutine>c__Iterator1.<downloadFixedSaveDataRoutine>c__AnonStorey3 $locvar0;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    [System.Diagnostics.DebuggerHiddenAttribute]
    public RestoreFailedSaveDataUI.<downloadFixedSaveDataRoutine>c__Iterator1()
    {
    
    }
    public bool MoveNext()
    {
        RestoreFailedSaveDataUI.<downloadFixedSaveDataRoutine>c__Iterator1 val_25;
        int val_26;
        <downloadFixedSaveDataRoutine>c__AnonStorey3 val_27;
        UnityEngine.WWW val_28;
        <downloadFixedSaveDataRoutine>c__AnonStorey3 val_29;
        val_25 = this;
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
        
        val_26 = 0;
        if(val_2 != 4)
        {
                return (bool)val_26;
        }
        
        val_27 = this.$locvar0;
        goto label_4;
        label_2:
        val_28 = this.<www>__2;
        if(this.$PC != 2)
        {
            goto label_5;
        }
        
        string val_3 = val_28.error;
        val_29 = 1152921504608284672;
        if((System.String.IsNullOrEmpty(value:  0)) == false)
        {
            goto label_9;
        }
        
        UnityEngine.MonoBehaviour.print(message:  0);
        System.Byte[] val_6 = this.<www>__2.bytes;
        this.<json>__3 = TzarGames.SaveManager.LoadFromMemoryAsString(data:  0);
        if((System.String.IsNullOrEmpty(value:  0)) == false)
        {
            goto label_15;
        }
        
        UnityEngine.Debug.LogError(message:  0);
        this.$this.loadCoroutine = 0;
        this.$this.showResultScreen(status:  2);
        goto label_58;
        label_1:
        if(TzarGames.Endless.FacebookPlatform.IsLoggedIn == true)
        {
            goto label_27;
        }
        
        val_27 = val_25;
        this.$locvar0 = new System.Object();
        typeof(RestoreFailedSaveDataUI.<downloadFixedSaveDataRoutine>c__Iterator1.<downloadFixedSaveDataRoutine>c__AnonStorey3).__il2cppRuntimeField_18 = val_25;
        this.$locvar0.waiting = true;
        val_29 = this.$locvar0;
        System.Action<System.Boolean> val_12 = new System.Action<System.Boolean>(object:  val_29, method:  System.Void RestoreFailedSaveDataUI.<downloadFixedSaveDataRoutine>c__Iterator1.<downloadFixedSaveDataRoutine>c__AnonStorey3::<>m__0(bool result));
        TzarGames.Endless.FacebookPlatform.Login(callback:  0);
        label_4:
        if((RestoreFailedSaveDataUI.<downloadFixedSaveDataRoutine>c__Iterator1.<downloadFixedSaveDataRoutine>c__AnonStorey3) != null)
        {
                val_26 = 1;
            this.$current = 0;
            if(this.$disposing == true)
        {
                return (bool)val_26;
        }
        
            this.$PC = val_26;
            return (bool)val_26;
        }
        
        if(TzarGames.Endless.FacebookPlatform.IsLoggedIn == false)
        {
            goto label_38;
        }
        
        label_27:
        string val_16 = TzarGames.Endless.EndlessSaveManager.GetDeviceID();
        val_29 = System.String.Format(format:  0, arg0:  "{0}downloadfixedfile?fb_user_token={1}&device_id={2}", arg1:  "http://total-rpg-web-services.azurewebsites.net/", arg2:  TzarGames.Endless.FacebookPlatform.AccessToken);
        this.<url>__0 = val_29;
        UnityEngine.WWW val_18 = null;
        val_28 = val_18;
        val_18 = new UnityEngine.WWW(url:  val_29);
        this.<www>__2 = val_28;
        label_5:
        this.$current = val_28;
        if(this.$disposing != true)
        {
                this.$PC = 2;
        }
        
        val_26 = 1;
        return (bool)val_26;
        label_38:
        UnityEngine.Debug.LogError(message:  0);
        this.$this.showResultScreen(status:  0);
        val_25 = this.$this;
        val_26 = 0;
        this.$this.loadCoroutine = 0;
        return (bool)val_26;
        label_9:
        this.$this.loadCoroutine = 0;
        string val_19 = this.<www>__2.text;
        UnityEngine.Debug.LogError(message:  0);
        string val_20 = this.<www>__2.error;
        UnityEngine.Debug.LogError(message:  0);
        string val_21 = this.<www>__2.text;
        if((UnityEngine.JsonUtility.FromJson<EncodedData>(json:  0)) == null)
        {
            goto label_56;
        }
        
        this.$this.showResultScreen(status:  val_29);
        goto label_58;
        label_15:
        EncodedData val_23 = UnityEngine.JsonUtility.FromJson<EncodedData>(json:  0);
        val_29 = this.$this;
        this.<data>__4 = val_23;
        this.$this.currentCrashSaveData = val_23;
        this.<>__Finally0();
        val_26 = 0;
        this.$this.loadCoroutine = 0;
        this.$PC = 0;
        return (bool)val_26;
        label_56:
        val_29 = this.<www>__2.error;
        this.$this.showResultScreen(status:  val_29);
        label_58:
        this.<>__Finally0();
        val_26 = 0;
        return (bool)val_26;
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
        if((this.<www>__2) == null)
        {
                return;
        }
        
        var val_2 = 0;
        val_2 = val_2 + 1;
        val_2 = this.<www>__2;
    }

}
