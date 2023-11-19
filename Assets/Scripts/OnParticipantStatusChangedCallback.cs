using UnityEngine;
internal sealed class RealTimeEventListenerHelper.OnParticipantStatusChangedCallback : MulticastDelegate
{
    // Methods
    public RealTimeEventListenerHelper.OnParticipantStatusChangedCallback(object object, IntPtr method)
    {
        mem[1152921512003086640] = object;
        mem[1152921512003086648] = method;
        mem[1152921512003086624] = method;
    }
    public virtual void Invoke(IntPtr arg0, IntPtr arg1, IntPtr arg2)
    {
        var val_7;
        var val_8;
        var val_9;
        if(((X23 & 1) & 1) == 0)
        {
            goto label_2;
        }
        
        if((X23 + 76) == 1)
        {
            goto label_6;
        }
        
        if(X22 != 0)
        {
                if(((X22 + 237) & 1) != 0)
        {
            goto label_6;
        }
        
        }
        
        if((X22 + 237) == 0)
        {
            goto label_6;
        }
        
        long val_2 = X23.LocalClientId;
        if((X23 & 1) == 0)
        {
            goto label_7;
        }
        
        if((val_2 & 1) == 0)
        {
            goto label_8;
        }
        
        var val_11 = X22;
        if((X22 + 258) == 0)
        {
            goto label_9;
        }
        
        var val_5 = X22 + 152;
        var val_6 = 0;
        val_5 = val_5 + 8;
        label_11:
        if(((X22 + 152 + 8) + -8) == (X23 + 24))
        {
            goto label_10;
        }
        
        val_6 = val_6 + 1;
        val_5 = val_5 + 16;
        if(val_6 < (X22 + 258))
        {
            goto label_11;
        }
        
        label_9:
        val_7 = X22;
        goto label_12;
        label_2:
        if((X23 + 78) != 3)
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
        
        if((X22 + 258) == 0)
        {
            goto label_16;
        }
        
        var val_7 = X22 + 152;
        var val_8 = 0;
        val_7 = val_7 + 8;
        label_18:
        if(((X22 + 152 + 8) + -8) == X23.LocalClientId)
        {
            goto label_17;
        }
        
        val_8 = val_8 + 1;
        val_7 = val_7 + 16;
        if(val_8 < (X22 + 258))
        {
            goto label_18;
        }
        
        label_16:
        val_8 = X22;
        goto label_23;
        label_8:
        var val_4 = X22 + ((X23 + 76) << 4);
        val_9 = mem[(X22 + (X23 + 76) << 4) + 280];
        val_9 = (X22 + (X23 + 76) << 4) + 280;
        goto label_23;
        label_15:
        var val_9 = X22;
        val_9 = val_9 + (X23 + 76);
        goto label_23;
        label_10:
        var val_10 = val_5;
        val_10 = val_10 + (X23 + 76);
        val_11 = val_11 + val_10;
        val_7 = val_11 + 272;
        label_12:
        val_9 = mem[((X22 + ((X22 + 152 + 8) + X23 + 76)) + 272) + 8];
        val_9 = ((X22 + ((X22 + 152 + 8) + X23 + 76)) + 272) + 8;
        goto label_23;
        label_17:
        var val_12 = val_7;
        val_12 = val_12 + (X23 + 76);
        val_12 = X22 + val_12;
        val_8 = val_12 + 272;
        goto label_23;
    }
    public virtual System.IAsyncResult BeginInvoke(IntPtr arg0, IntPtr arg1, IntPtr arg2, System.AsyncCallback callback, object object)
    {
        return (System.IAsyncResult)this;
    }
    public virtual void EndInvoke(System.IAsyncResult result)
    {
    
    }

}
