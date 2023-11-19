using UnityEngine;
public sealed class CinemachineVirtualCameraBase.OnPostPipelineStageDelegate : MulticastDelegate
{
    // Methods
    public CinemachineVirtualCameraBase.OnPostPipelineStageDelegate(object object, IntPtr method)
    {
        mem[1152921511745023392] = object;
        mem[1152921511745023400] = method;
        mem[1152921511745023376] = method;
    }
    public virtual void Invoke(Cinemachine.CinemachineVirtualCameraBase vcam, Cinemachine.CinemachineCore.Stage stage, ref Cinemachine.CameraState newState, float deltaTime)
    {
        var val_13;
        var val_14;
        var val_15;
        var val_16;
        var val_17;
        var val_18;
        if(((X22 & 1) & 1) == 0)
        {
            goto label_2;
        }
        
        if((X22 + 78) != 4)
        {
            goto label_3;
        }
        
        if((X22 + 76) == 65535)
        {
            goto label_7;
        }
        
        if(X23 != 0)
        {
                if(((X23 + 237) & 1) != 0)
        {
            goto label_7;
        }
        
        }
        
        if((X23 + 237) == 0)
        {
            goto label_7;
        }
        
        long val_2 = X22.LocalClientId;
        if((X22 & 1) == 0)
        {
            goto label_8;
        }
        
        if((val_2 & 1) == 0)
        {
            goto label_9;
        }
        
        var val_19 = X23;
        if((X23 + 258) == 0)
        {
            goto label_10;
        }
        
        var val_11 = X23 + 152;
        var val_12 = 0;
        val_11 = val_11 + 8;
        label_12:
        if(((X23 + 152 + 8) + -8) == (X22 + 24))
        {
            goto label_11;
        }
        
        val_12 = val_12 + 1;
        val_11 = val_11 + 16;
        if(val_12 < (X23 + 258))
        {
            goto label_12;
        }
        
        label_10:
        val_13 = X23;
        goto label_13;
        label_2:
        if((X22 + 78) != 4)
        {
            goto label_14;
        }
        
        goto label_15;
        label_3:
        if((X22 + 76) == 65535)
        {
            goto label_19;
        }
        
        if(X23 != 0)
        {
                if(((X23 + 237) & 1) != 0)
        {
            goto label_19;
        }
        
        }
        
        if((X23 + 237) == 0)
        {
            goto label_19;
        }
        
        long val_3 = X22.LocalClientId;
        if((X22 & 1) == 0)
        {
            goto label_20;
        }
        
        if((val_3 & 1) == 0)
        {
            goto label_21;
        }
        
        var val_13 = 0;
        val_13 = val_13 + 1;
        val_14 = vcam;
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
        
        if((X23 + 258) == 0)
        {
            goto label_27;
        }
        
        var val_14 = X23 + 152;
        var val_15 = 0;
        val_14 = val_14 + 8;
        label_29:
        if(((X23 + 152 + 8) + -8) == X22.LocalClientId)
        {
            goto label_28;
        }
        
        val_15 = val_15 + 1;
        val_14 = val_14 + 16;
        if(val_15 < (X23 + 258))
        {
            goto label_29;
        }
        
        label_27:
        val_15 = X23;
        goto label_42;
        label_20:
        if((val_3 & 1) == 0)
        {
            goto label_31;
        }
        
        long val_5 = X22.LocalClientId;
        var val_16 = 0;
        val_16 = val_16 + 1;
        val_16 = vcam;
        goto label_43;
        label_9:
        var val_6 = X23 + ((X22 + 76) << 4);
        val_17 = mem[(X23 + (X22 + 76) << 4) + 280];
        val_17 = (X23 + (X22 + 76) << 4) + 280;
        goto label_42;
        label_21:
        Cinemachine.CinemachineVirtualCameraBase val_7 = 1152921504931713024 + ((X22 + 76) << 4);
        val_18 = mem[(1152921504931713024 + (X22 + 76) << 4) + 280];
        goto label_43;
        label_26:
        var val_17 = X23;
        val_17 = val_17 + (X22 + 76);
        goto label_42;
        label_31:
        Cinemachine.CinemachineVirtualCameraBase val_8 = 1152921504931713024 + (X22 + 76);
        goto label_43;
        label_11:
        var val_18 = val_11;
        val_18 = val_18 + (X22 + 76);
        val_19 = val_19 + val_18;
        val_13 = val_19 + 272;
        label_13:
        val_17 = mem[((X23 + ((X23 + 152 + 8) + X22 + 76)) + 272) + 8];
        val_17 = ((X23 + ((X23 + 152 + 8) + X22 + 76)) + 272) + 8;
        goto label_42;
        label_25:
        val_18 = mem[val_3 + 8];
        val_18 = val_3 + 8;
        goto label_43;
        label_28:
        var val_20 = val_14;
        val_20 = val_20 + (X22 + 76);
        val_20 = X23 + val_20;
        val_15 = val_20 + 272;
        goto label_42;
    }
    public virtual System.IAsyncResult BeginInvoke(Cinemachine.CinemachineVirtualCameraBase vcam, Cinemachine.CinemachineCore.Stage stage, ref Cinemachine.CameraState newState, float deltaTime, System.AsyncCallback callback, object object)
    {
        return (System.IAsyncResult)this;
    }
    public virtual void EndInvoke(ref Cinemachine.CameraState newState, System.IAsyncResult result)
    {
    
    }

}
