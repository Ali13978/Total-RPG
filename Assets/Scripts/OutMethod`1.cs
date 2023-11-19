using UnityEngine;
internal sealed class PInvokeUtilities.OutMethod<T> : MulticastDelegate
{
    // Methods
    public PInvokeUtilities.OutMethod<T>(object object, IntPtr method)
    {
        mem[1152921512181237648] = object;
        mem[1152921512181237656] = method;
        mem[1152921512181237632] = method;
    }
    public virtual UIntPtr Invoke([In] [Out] T[] out_bytes, UIntPtr out_size)
    {
        var val_17;
        var val_18;
        var val_19;
        var val_20;
        var val_21;
        var val_22;
        var val_23;
        if(this != null)
        {
                val_17 = out_size;
        }
        
        if(((X21 & 1) & 1) == 0)
        {
            goto label_2;
        }
        
        if((X21 + 78) != 2)
        {
            goto label_3;
        }
        
        if((X21 + 76) == 65535)
        {
            goto label_7;
        }
        
        if(X22 != 0)
        {
                if(((X22 + 237) & 1) != 0)
        {
            goto label_7;
        }
        
        }
        
        if((X22 + 237) == 0)
        {
            goto label_7;
        }
        
        long val_2 = X21.LocalClientId;
        if((X21 & 1) == 0)
        {
            goto label_8;
        }
        
        if((val_2 & 1) == 0)
        {
            goto label_9;
        }
        
        var val_23 = X22;
        if((X22 + 258) == 0)
        {
            goto label_10;
        }
        
        var val_15 = X22 + 152;
        var val_16 = 0;
        val_15 = val_15 + 8;
        label_12:
        if(((X22 + 152 + 8) + -8) == (X21 + 24))
        {
            goto label_11;
        }
        
        val_16 = val_16 + 1;
        val_15 = val_15 + 16;
        if(val_16 < (X22 + 258))
        {
            goto label_12;
        }
        
        label_10:
        val_18 = X22;
        goto label_13;
        label_2:
        if((X21 + 78) != 2)
        {
            goto label_14;
        }
        
        goto label_15;
        label_3:
        if((X21 + 76) == 65535)
        {
            goto label_19;
        }
        
        if(X22 != 0)
        {
                if(((X22 + 237) & 1) != 0)
        {
            goto label_19;
        }
        
        }
        
        if((X22 + 237) == 0)
        {
            goto label_19;
        }
        
        long val_3 = X21.LocalClientId;
        if((X21 & 1) == 0)
        {
            goto label_20;
        }
        
        if((val_3 & 1) == 0)
        {
            goto label_21;
        }
        
        var val_17 = 0;
        val_17 = val_17 + 1;
        val_19 = out_bytes;
        goto label_25;
        label_14:
        label_7:
        label_15:
        label_42:
        label_19:
        label_43:
        label_8:
        if((val_2 & 1) == 0)
        {
            goto label_26;
        }
        
        if((X22 + 258) == 0)
        {
            goto label_27;
        }
        
        var val_18 = X22 + 152;
        var val_19 = 0;
        val_18 = val_18 + 8;
        label_29:
        if(((X22 + 152 + 8) + -8) == X21.LocalClientId)
        {
            goto label_28;
        }
        
        val_19 = val_19 + 1;
        val_18 = val_18 + 16;
        if(val_19 < (X22 + 258))
        {
            goto label_29;
        }
        
        label_27:
        val_20 = X22;
        goto label_42;
        label_20:
        if((val_3 & 1) == 0)
        {
            goto label_31;
        }
        
        long val_6 = X21.LocalClientId;
        var val_20 = 0;
        val_20 = val_20 + 1;
        val_21 = out_bytes;
        val_17 = X21 + 76;
        goto label_43;
        label_9:
        var val_8 = X22 + ((X21 + 76) << 4);
        val_22 = mem[(X22 + (X21 + 76) << 4) + 280];
        val_22 = (X22 + (X21 + 76) << 4) + 280;
        goto label_42;
        label_21:
        T[] val_9 = 1152921507565898640 + ((X21 + 76) << 4);
        val_23 = mem[(1152921507565898640 + (X21 + 76) << 4) + 280];
        goto label_43;
        label_26:
        var val_21 = X22;
        val_21 = val_21 + (X21 + 76);
        goto label_42;
        label_31:
        T[] val_10 = 1152921507565898640 + (X21 + 76);
        goto label_43;
        label_11:
        var val_22 = val_15;
        val_22 = val_22 + (X21 + 76);
        val_23 = val_23 + val_22;
        val_18 = val_23 + 272;
        label_13:
        val_22 = mem[((X22 + ((X22 + 152 + 8) + X21 + 76)) + 272) + 8];
        val_22 = ((X22 + ((X22 + 152 + 8) + X21 + 76)) + 272) + 8;
        goto label_42;
        label_25:
        val_23 = mem[val_3 + 8];
        val_23 = val_3 + 8;
        goto label_43;
        label_28:
        var val_24 = val_18;
        val_24 = val_24 + (X21 + 76);
        val_24 = X22 + val_24;
        val_20 = val_24 + 272;
        goto label_42;
    }
    public virtual System.IAsyncResult BeginInvoke([In] [Out] T[] out_bytes, UIntPtr out_size, System.AsyncCallback callback, object object)
    {
        return (System.IAsyncResult)this;
    }
    public virtual UIntPtr EndInvoke(System.IAsyncResult result)
    {
        UnityEngine.Vector2 val_1 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3());
        return (UIntPtr)null;
    }

}
