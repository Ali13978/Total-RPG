using UnityEngine;
public sealed class LobbyClient.DeathmatchRequestCompleteDelegate : MulticastDelegate
{
    // Methods
    public LobbyClient.DeathmatchRequestCompleteDelegate(object object, IntPtr method)
    {
        mem[1152921511390138752] = object;
        mem[1152921511390138760] = method;
        mem[1152921511390138736] = method;
    }
    public virtual void Invoke(bool result, string password, string serverAddress, int port, string levelName)
    {
        var val_13;
        var val_14;
        var val_15;
        if(this != null)
        {
                result = result;
        }
        
        if(((X25 & 1) & 1) == 0)
        {
            goto label_2;
        }
        
        if((X25 + 76) == 1)
        {
            goto label_6;
        }
        
        if(X24 != 0)
        {
                if(((X24 + 237) & 1) != 0)
        {
            goto label_6;
        }
        
        }
        
        if((X24 + 237) == 0)
        {
            goto label_6;
        }
        
        long val_2 = X25.LocalClientId;
        if((X25 & 1) == 0)
        {
            goto label_7;
        }
        
        if((val_2 & 1) == 0)
        {
            goto label_8;
        }
        
        var val_17 = X24;
        if((X24 + 258) == 0)
        {
            goto label_9;
        }
        
        var val_11 = X24 + 152;
        var val_12 = 0;
        val_11 = val_11 + 8;
        label_11:
        if(((X24 + 152 + 8) + -8) == (X25 + 24))
        {
            goto label_10;
        }
        
        val_12 = val_12 + 1;
        val_11 = val_11 + 16;
        if(val_12 < (X24 + 258))
        {
            goto label_11;
        }
        
        label_9:
        val_13 = X24;
        goto label_12;
        label_2:
        if((X25 + 78) != 5)
        {
            goto label_13;
        }
        
        bool val_3 = result;
        goto label_14;
        label_6:
        bool val_4 = result;
        label_14:
        label_23:
        label_13:
        bool val_5 = result;
        label_7:
        if((val_2 & 1) == 0)
        {
            goto label_15;
        }
        
        if((X24 + 258) == 0)
        {
            goto label_16;
        }
        
        var val_13 = X24 + 152;
        var val_14 = 0;
        val_13 = val_13 + 8;
        label_18:
        if(((X24 + 152 + 8) + -8) == X25.LocalClientId)
        {
            goto label_17;
        }
        
        val_14 = val_14 + 1;
        val_13 = val_13 + 16;
        if(val_14 < (X24 + 258))
        {
            goto label_18;
        }
        
        label_16:
        val_14 = X24;
        goto label_19;
        label_8:
        var val_7 = X24 + ((X25 + 76) << 4);
        val_15 = mem[(X24 + (X25 + 76) << 4) + 280];
        val_15 = (X24 + (X25 + 76) << 4) + 280;
        goto label_20;
        label_15:
        var val_15 = X24;
        bool val_8 = result;
        val_15 = val_15 + (X25 + 76);
        goto label_23;
        label_10:
        var val_16 = val_11;
        val_16 = val_16 + (X25 + 76);
        val_17 = val_17 + val_16;
        val_13 = val_17 + 272;
        label_12:
        val_15 = mem[((X24 + ((X24 + 152 + 8) + X25 + 76)) + 272) + 8];
        val_15 = ((X24 + ((X24 + 152 + 8) + X25 + 76)) + 272) + 8;
        label_20:
        bool val_9 = result;
        goto label_23;
        label_17:
        var val_18 = val_13;
        val_18 = val_18 + (X25 + 76);
        val_18 = X24 + val_18;
        val_14 = val_18 + 272;
        label_19:
        bool val_10 = result;
        goto label_23;
    }
    public virtual System.IAsyncResult BeginInvoke(bool result, string password, string serverAddress, int port, string levelName, System.AsyncCallback callback, object object)
    {
        bool val_1 = result;
        return (System.IAsyncResult)this;
    }
    public virtual void EndInvoke(System.IAsyncResult result)
    {
    
    }

}
