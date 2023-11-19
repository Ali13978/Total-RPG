using UnityEngine;
internal sealed class SnapshotManager.ReadCallback : MulticastDelegate
{
    // Methods
    public SnapshotManager.ReadCallback(object object, IntPtr method)
    {
        mem[1152921512023316912] = object;
        mem[1152921512023316920] = method;
        mem[1152921512023316896] = method;
    }
    public virtual void Invoke(IntPtr arg0, IntPtr arg1)
    {
        var val_7;
        var val_8;
        var val_9;
        if(((X22 & 1) & 1) == 0)
        {
            goto label_2;
        }
        
        if((X22 + 76) == 1)
        {
            goto label_6;
        }
        
        if(X21 != 0)
        {
                if(((X21 + 237) & 1) != 0)
        {
            goto label_6;
        }
        
        }
        
        if((X21 + 237) == 0)
        {
            goto label_6;
        }
        
        long val_2 = X22.LocalClientId;
        if((X22 & 1) == 0)
        {
            goto label_7;
        }
        
        if((val_2 & 1) == 0)
        {
            goto label_8;
        }
        
        var val_11 = X21;
        if((X21 + 258) == 0)
        {
            goto label_9;
        }
        
        var val_5 = X21 + 152;
        var val_6 = 0;
        val_5 = val_5 + 8;
        label_11:
        if(((X21 + 152 + 8) + -8) == (X22 + 24))
        {
            goto label_10;
        }
        
        val_6 = val_6 + 1;
        val_5 = val_5 + 16;
        if(val_6 < (X21 + 258))
        {
            goto label_11;
        }
        
        label_9:
        val_7 = X21;
        goto label_12;
        label_2:
        if((X22 + 78) != 2)
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
        
        if((X21 + 258) == 0)
        {
            goto label_16;
        }
        
        var val_7 = X21 + 152;
        var val_8 = 0;
        val_7 = val_7 + 8;
        label_18:
        if(((X21 + 152 + 8) + -8) == X22.LocalClientId)
        {
            goto label_17;
        }
        
        val_8 = val_8 + 1;
        val_7 = val_7 + 16;
        if(val_8 < (X21 + 258))
        {
            goto label_18;
        }
        
        label_16:
        val_8 = X21;
        goto label_23;
        label_8:
        var val_4 = X21 + ((X22 + 76) << 4);
        val_9 = mem[(X21 + (X22 + 76) << 4) + 280];
        val_9 = (X21 + (X22 + 76) << 4) + 280;
        goto label_23;
        label_15:
        var val_9 = X21;
        val_9 = val_9 + (X22 + 76);
        goto label_23;
        label_10:
        var val_10 = val_5;
        val_10 = val_10 + (X22 + 76);
        val_11 = val_11 + val_10;
        val_7 = val_11 + 272;
        label_12:
        val_9 = mem[((X21 + ((X21 + 152 + 8) + X22 + 76)) + 272) + 8];
        val_9 = ((X21 + ((X21 + 152 + 8) + X22 + 76)) + 272) + 8;
        goto label_23;
        label_17:
        var val_12 = val_7;
        val_12 = val_12 + (X22 + 76);
        val_12 = X21 + val_12;
        val_8 = val_12 + 272;
        goto label_23;
    }
    public virtual System.IAsyncResult BeginInvoke(IntPtr arg0, IntPtr arg1, System.AsyncCallback callback, object object)
    {
        return (System.IAsyncResult)this;
    }
    public virtual void EndInvoke(System.IAsyncResult result)
    {
    
    }

}
