using UnityEngine;
internal sealed class Builder.OnMultiplayerInvitationEventCallback : MulticastDelegate
{
    // Methods
    public Builder.OnMultiplayerInvitationEventCallback(object object, IntPtr method)
    {
        mem[1152921511964535856] = object;
        mem[1152921511964535864] = method;
        mem[1152921511964535840] = method;
    }
    public virtual void Invoke(GooglePlayGames.Native.Cwrapper.Types.MultiplayerEvent arg0, string arg1, IntPtr arg2, IntPtr arg3)
    {
        var val_7;
        var val_8;
        var val_9;
        if(((X24 & 1) & 1) == 0)
        {
            goto label_2;
        }
        
        if((X24 + 76) == 1)
        {
            goto label_6;
        }
        
        if(X23 != 0)
        {
                if(((X23 + 237) & 1) != 0)
        {
            goto label_6;
        }
        
        }
        
        if((X23 + 237) == 0)
        {
            goto label_6;
        }
        
        long val_2 = X24.LocalClientId;
        if((X24 & 1) == 0)
        {
            goto label_7;
        }
        
        if((val_2 & 1) == 0)
        {
            goto label_8;
        }
        
        var val_11 = X23;
        if((X23 + 258) == 0)
        {
            goto label_9;
        }
        
        var val_5 = X23 + 152;
        var val_6 = 0;
        val_5 = val_5 + 8;
        label_11:
        if(((X23 + 152 + 8) + -8) == (X24 + 24))
        {
            goto label_10;
        }
        
        val_6 = val_6 + 1;
        val_5 = val_5 + 16;
        if(val_6 < (X23 + 258))
        {
            goto label_11;
        }
        
        label_9:
        val_7 = X23;
        goto label_12;
        label_2:
        if((X24 + 78) != 4)
        {
            goto label_13;
        }
        
        goto label_14;
        label_6:
        label_14:
        label_23:
        label_13:
        label_7:
        if((val_2 & 1) == 0)
        {
            goto label_15;
        }
        
        if((X23 + 258) == 0)
        {
            goto label_16;
        }
        
        var val_7 = X23 + 152;
        var val_8 = 0;
        val_7 = val_7 + 8;
        label_18:
        if(((X23 + 152 + 8) + -8) == X24.LocalClientId)
        {
            goto label_17;
        }
        
        val_8 = val_8 + 1;
        val_7 = val_7 + 16;
        if(val_8 < (X23 + 258))
        {
            goto label_18;
        }
        
        label_16:
        val_8 = X23;
        goto label_23;
        label_8:
        var val_4 = X23 + ((X24 + 76) << 4);
        val_9 = mem[(X23 + (X24 + 76) << 4) + 280];
        val_9 = (X23 + (X24 + 76) << 4) + 280;
        goto label_23;
        label_15:
        var val_9 = X23;
        val_9 = val_9 + (X24 + 76);
        goto label_23;
        label_10:
        var val_10 = val_5;
        val_10 = val_10 + (X24 + 76);
        val_11 = val_11 + val_10;
        val_7 = val_11 + 272;
        label_12:
        val_9 = mem[((X23 + ((X23 + 152 + 8) + X24 + 76)) + 272) + 8];
        val_9 = ((X23 + ((X23 + 152 + 8) + X24 + 76)) + 272) + 8;
        goto label_23;
        label_17:
        var val_12 = val_7;
        val_12 = val_12 + (X24 + 76);
        val_12 = X23 + val_12;
        val_8 = val_12 + 272;
        goto label_23;
    }
    public virtual System.IAsyncResult BeginInvoke(GooglePlayGames.Native.Cwrapper.Types.MultiplayerEvent arg0, string arg1, IntPtr arg2, IntPtr arg3, System.AsyncCallback callback, object object)
    {
        return (System.IAsyncResult)this;
    }
    public virtual void EndInvoke(System.IAsyncResult result)
    {
    
    }

}
