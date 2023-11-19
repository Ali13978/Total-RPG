using UnityEngine;
internal sealed class RealTimeEventListenerHelper.OnDataReceivedCallback : MulticastDelegate
{
    // Methods
    public RealTimeEventListenerHelper.OnDataReceivedCallback(object object, IntPtr method)
    {
        mem[1152921512003591984] = object;
        mem[1152921512003591992] = method;
        mem[1152921512003591968] = method;
    }
    public virtual void Invoke(IntPtr arg0, IntPtr arg1, IntPtr arg2, UIntPtr arg3, bool arg4, IntPtr arg5)
    {
        var val_13;
        var val_14;
        var val_15;
        var val_16;
        var val_17;
        var val_18;
        var val_19;
        var val_20;
        var val_21;
        var val_22;
        var val_23;
        var val_24;
        var val_25;
        var val_26;
        var val_27;
        var val_28;
        val_13 = arg5;
        val_14 = arg4;
        val_15 = arg3;
        val_16 = arg2;
        val_17 = arg1;
        val_18 = arg0;
        if(this != null)
        {
                arg4 = val_14;
        }
        
        if(((X26 & 1) & 1) == 0)
        {
            goto label_2;
        }
        
        if((X26 + 76) == 1)
        {
            goto label_6;
        }
        
        if(X25 != 0)
        {
                if(((X25 + 237) & 1) != 0)
        {
            goto label_6;
        }
        
        }
        
        if((X25 + 237) == 0)
        {
            goto label_6;
        }
        
        val_20 = X26;
        long val_2 = X26.LocalClientId;
        if((val_20 & 1) == 0)
        {
            goto label_7;
        }
        
        if((val_2 & 1) == 0)
        {
            goto label_8;
        }
        
        var val_15 = X25;
        if((X25 + 258) == 0)
        {
            goto label_9;
        }
        
        var val_11 = X25 + 152;
        val_21 = 0;
        val_11 = val_11 + 8;
        label_11:
        if(((X25 + 152 + 8) + -8) == (X26 + 24))
        {
            goto label_10;
        }
        
        val_21 = val_21 + 1;
        val_11 = val_11 + 16;
        if(val_21 < (X25 + 258))
        {
            goto label_11;
        }
        
        label_9:
        val_22 = X25;
        goto label_12;
        label_2:
        if((X26 + 78) != 6)
        {
            goto label_13;
        }
        
        bool val_3 = val_14;
        goto label_14;
        label_6:
        bool val_4 = val_14;
        label_14:
        label_22:
        label_13:
        bool val_5 = val_14;
        return;
        label_7:
        val_23 = mem[X26 + 76];
        val_23 = X26 + 76;
        if((val_2 & 1) == 0)
        {
            goto label_15;
        }
        
        val_24 = mem[X25];
        val_24 = X25;
        if((X25 + 258) == 0)
        {
            goto label_16;
        }
        
        var val_12 = 0;
        val_21 = (X25 + 152) + 8;
        label_18:
        if(((X25 + 152 + 8) + -8) == X26.LocalClientId)
        {
            goto label_17;
        }
        
        val_12 = val_12 + 1;
        val_21 = val_21 + 16;
        if(val_12 < (X25 + 258))
        {
            goto label_18;
        }
        
        label_16:
        val_25 = X25;
        goto label_19;
        label_8:
        var val_7 = X25 + ((X26 + 76) << 4);
        val_26 = mem[(X25 + (X26 + 76) << 4) + 280];
        val_26 = (X25 + (X26 + 76) << 4) + 280;
        goto label_20;
        label_15:
        var val_13 = X25;
        bool val_8 = val_14;
        val_13 = val_13 + val_23;
        val_24 = mem[(X25 + X26 + 76) + 272];
        val_24 = (X25 + X26 + 76) + 272;
        val_27 = mem[(X25 + X26 + 76) + 272 + 8];
        val_27 = (X25 + X26 + 76) + 272 + 8;
        goto label_21;
        label_10:
        var val_14 = val_11;
        val_14 = val_14 + (X26 + 76);
        val_15 = val_15 + val_14;
        val_22 = val_15 + 272;
        label_12:
        val_26 = mem[((X25 + ((X25 + 152 + 8) + X26 + 76)) + 272) + 8];
        val_26 = ((X25 + ((X25 + 152 + 8) + X26 + 76)) + 272) + 8;
        label_20:
        val_24 = mem[((X25 + ((X25 + 152 + 8) + X26 + 76)) + 272) + 8];
        val_24 = val_26;
        bool val_9 = val_14;
        val_27 = val_26;
        label_21:
        val_15 = ???;
        val_13 = ???;
        val_17 = ???;
        val_16 = ???;
        val_14 = ???;
        val_18 = ???;
        val_19 = ???;
        val_28 = ???;
        goto ((X25 + ((X25 + 152 + 8) + X26 + 76)) + 272) + 8;
        label_17:
        val_21 = val_21 + val_28;
        val_21 = val_24 + val_21;
        val_25 = val_21 + 272;
        label_19:
        var val_10 = val_14 & 1;
        goto label_22;
    }
    public virtual System.IAsyncResult BeginInvoke(IntPtr arg0, IntPtr arg1, IntPtr arg2, UIntPtr arg3, bool arg4, IntPtr arg5, System.AsyncCallback callback, object object)
    {
        bool val_1 = arg4;
        return (System.IAsyncResult)this;
    }
    public virtual void EndInvoke(System.IAsyncResult result)
    {
    
    }

}
