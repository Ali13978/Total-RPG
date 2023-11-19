using UnityEngine;
protected sealed class TH_PlayerCharacter.dlgPositionPick : MulticastDelegate
{
    // Methods
    public TH_PlayerCharacter.dlgPositionPick(object object, IntPtr method)
    {
        mem[1152921511609762496] = object;
        mem[1152921511609762504] = method;
        mem[1152921511609762480] = method;
    }
    public virtual bool Invoke(UnityEngine.Vector3 position)
    {
        var val_7;
        var val_8;
        var val_9;
        if(((X20 & 1) & 1) == 0)
        {
            goto label_2;
        }
        
        if((X20 + 76) == 1)
        {
            goto label_6;
        }
        
        if(X19 != 0)
        {
                if(((X19 + 237) & 1) != 0)
        {
            goto label_6;
        }
        
        }
        
        if((X19 + 237) == 0)
        {
            goto label_6;
        }
        
        long val_2 = X20.LocalClientId;
        if((X20 & 1) == 0)
        {
            goto label_7;
        }
        
        if((val_2 & 1) == 0)
        {
            goto label_8;
        }
        
        var val_11 = X19;
        if((X19 + 258) == 0)
        {
            goto label_9;
        }
        
        var val_5 = X19 + 152;
        var val_6 = 0;
        val_5 = val_5 + 8;
        label_11:
        if(((X19 + 152 + 8) + -8) == (X20 + 24))
        {
            goto label_10;
        }
        
        val_6 = val_6 + 1;
        val_5 = val_5 + 16;
        if(val_6 < (X19 + 258))
        {
            goto label_11;
        }
        
        label_9:
        val_7 = X19;
        goto label_12;
        label_2:
        if((X20 + 78) != 1)
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
        
        if((X19 + 258) == 0)
        {
            goto label_16;
        }
        
        var val_7 = X19 + 152;
        var val_8 = 0;
        val_7 = val_7 + 8;
        label_18:
        if(((X19 + 152 + 8) + -8) == X20.LocalClientId)
        {
            goto label_17;
        }
        
        val_8 = val_8 + 1;
        val_7 = val_7 + 16;
        if(val_8 < (X19 + 258))
        {
            goto label_18;
        }
        
        label_16:
        val_8 = X19;
        goto label_23;
        label_8:
        var val_4 = X19 + ((X20 + 76) << 4);
        val_9 = mem[(X19 + (X20 + 76) << 4) + 280];
        val_9 = (X19 + (X20 + 76) << 4) + 280;
        goto label_23;
        label_15:
        var val_9 = X19;
        val_9 = val_9 + (X20 + 76);
        goto label_23;
        label_10:
        var val_10 = val_5;
        val_10 = val_10 + (X20 + 76);
        val_11 = val_11 + val_10;
        val_7 = val_11 + 272;
        label_12:
        val_9 = mem[((X19 + ((X19 + 152 + 8) + X20 + 76)) + 272) + 8];
        val_9 = ((X19 + ((X19 + 152 + 8) + X20 + 76)) + 272) + 8;
        goto label_23;
        label_17:
        var val_12 = val_7;
        val_12 = val_12 + (X20 + 76);
        val_12 = X19 + val_12;
        val_8 = val_12 + 272;
        goto label_23;
    }
    public virtual System.IAsyncResult BeginInvoke(UnityEngine.Vector3 position, System.AsyncCallback callback, object object)
    {
        return (System.IAsyncResult)this;
    }
    public virtual bool EndInvoke(System.IAsyncResult result)
    {
        UnityEngine.Vector2 val_1 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3());
        return (bool)null;
    }

}
