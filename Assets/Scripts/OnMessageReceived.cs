using UnityEngine;
internal sealed class NativeMessageListenerHelper.OnMessageReceived : MulticastDelegate
{
    // Methods
    public NativeMessageListenerHelper.OnMessageReceived(object object, IntPtr method)
    {
        mem[1152921512155719200] = object;
        mem[1152921512155719208] = method;
        mem[1152921512155719184] = method;
    }
    public virtual void Invoke(long localClientId, string remoteEndpointId, byte[] data, bool isReliable)
    {
        var val_13;
        var val_14;
        var val_15;
        if(this != null)
        {
                isReliable = isReliable;
        }
        
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
        
        var val_17 = X23;
        if((X23 + 258) == 0)
        {
            goto label_9;
        }
        
        var val_11 = X23 + 152;
        var val_12 = 0;
        val_11 = val_11 + 8;
        label_11:
        if(((X23 + 152 + 8) + -8) == (X24 + 24))
        {
            goto label_10;
        }
        
        val_12 = val_12 + 1;
        val_11 = val_11 + 16;
        if(val_12 < (X23 + 258))
        {
            goto label_11;
        }
        
        label_9:
        val_13 = X23;
        goto label_12;
        label_2:
        if((X24 + 78) != 4)
        {
            goto label_13;
        }
        
        bool val_3 = isReliable;
        goto label_14;
        label_6:
        bool val_4 = isReliable;
        label_14:
        label_23:
        label_13:
        bool val_5 = isReliable;
        label_7:
        if((val_2 & 1) == 0)
        {
            goto label_15;
        }
        
        if((X23 + 258) == 0)
        {
            goto label_16;
        }
        
        var val_13 = X23 + 152;
        var val_14 = 0;
        val_13 = val_13 + 8;
        label_18:
        if(((X23 + 152 + 8) + -8) == X24.LocalClientId)
        {
            goto label_17;
        }
        
        val_14 = val_14 + 1;
        val_13 = val_13 + 16;
        if(val_14 < (X23 + 258))
        {
            goto label_18;
        }
        
        label_16:
        val_14 = X23;
        goto label_19;
        label_8:
        var val_7 = X23 + ((X24 + 76) << 4);
        val_15 = mem[(X23 + (X24 + 76) << 4) + 280];
        val_15 = (X23 + (X24 + 76) << 4) + 280;
        goto label_20;
        label_15:
        var val_15 = X23;
        bool val_8 = isReliable;
        val_15 = val_15 + (X24 + 76);
        goto label_23;
        label_10:
        var val_16 = val_11;
        val_16 = val_16 + (X24 + 76);
        val_17 = val_17 + val_16;
        val_13 = val_17 + 272;
        label_12:
        val_15 = mem[((X23 + ((X23 + 152 + 8) + X24 + 76)) + 272) + 8];
        val_15 = ((X23 + ((X23 + 152 + 8) + X24 + 76)) + 272) + 8;
        label_20:
        bool val_9 = isReliable;
        goto label_23;
        label_17:
        var val_18 = val_13;
        val_18 = val_18 + (X24 + 76);
        val_18 = X23 + val_18;
        val_14 = val_18 + 272;
        label_19:
        bool val_10 = isReliable;
        goto label_23;
    }
    public virtual System.IAsyncResult BeginInvoke(long localClientId, string remoteEndpointId, byte[] data, bool isReliable, System.AsyncCallback callback, object object)
    {
        bool val_1 = isReliable;
        return (System.IAsyncResult)this;
    }
    public virtual void EndInvoke(System.IAsyncResult result)
    {
    
    }

}
