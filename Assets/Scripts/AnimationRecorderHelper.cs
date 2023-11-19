using UnityEngine;
public static class AnimationRecorderHelper
{
    // Methods
    public static string GetTransformPathName(UnityEngine.Transform rootTransform, UnityEngine.Transform targetTransform)
    {
        UnityEngine.Object val_10;
        var val_11;
        string val_12;
        var val_13;
        val_10 = X2;
        val_11 = targetTransform;
        val_12 = val_10.name;
        if(0 != val_10)
        {
            goto label_8;
        }
        
        val_11 = 1152921504608284672;
        val_13 = null;
        val_13 = null;
        val_12 = System.String.Empty;
        return val_12;
        label_18:
        val_10 = val_10.parent;
        label_8:
        if(0 == val_10.parent)
        {
                return val_12;
        }
        
        string val_9 = 0 + val_10.parent.name + "/"("/");
        if(val_10 != null)
        {
            goto label_18;
        }
        
        goto label_18;
    }

}
