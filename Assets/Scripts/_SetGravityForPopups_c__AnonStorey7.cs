using UnityEngine;
private sealed class NativeClient.<SetGravityForPopups>c__AnonStorey7
{
    // Fields
    internal GooglePlayGames.BasicApi.Gravity gravity;
    internal GooglePlayGames.Native.NativeClient $this;
    
    // Methods
    public NativeClient.<SetGravityForPopups>c__AnonStorey7()
    {
    
    }
    internal void <>m__0()
    {
        GooglePlayGames.Native.NativeClient val_3;
        GooglePlayGames.IClientImpl val_4;
        var val_5;
        val_3 = this.$this;
        if(val_3 != null)
        {
                val_4 = this.$this.clientImpl;
        }
        else
        {
                val_4 = this.$this.clientImpl;
            if(this.$this != null)
        {
                val_3 = this.$this;
        }
        else
        {
                val_3 = 0;
        }
        
        }
        
        IntPtr val_1 = val_3.GetApiClient();
        var val_3 = 0;
        val_3 = val_3 + 1;
        val_5 = val_4;
        goto val_1;
    }

}
