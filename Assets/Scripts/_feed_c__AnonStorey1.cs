using UnityEngine;
private sealed class FacebookPlatform.<feed>c__AnonStorey1
{
    // Fields
    internal System.Action<bool> shareResultCallback;
    
    // Methods
    public FacebookPlatform.<feed>c__AnonStorey1()
    {
    
    }
    internal void <>m__0(Facebook.Unity.IShareResult result)
    {
        var val_12;
        Facebook.Unity.IShareResult val_13;
        var val_14;
        var val_15;
        var val_16;
        var val_17;
        var val_18;
        var val_19;
        val_13 = result;
        if(this.shareResultCallback == null)
        {
                return;
        }
        
        val_12 = null;
        var val_11 = 0;
        val_11 = val_11 + 1;
        val_14 = val_13;
        typeof(System.Object[]).__il2cppRuntimeField_20 = val_13 & 1;
        typeof(System.Object[]).__il2cppRuntimeField_21 = 23723171;
        var val_12 = 0;
        val_12 = val_12 + 1;
        val_15 = val_13;
        typeof(System.Object[]).__il2cppRuntimeField_28 = val_13;
        var val_13 = 0;
        val_13 = val_13 + 1;
        val_16 = val_13;
        typeof(System.Object[]).__il2cppRuntimeField_30 = val_13;
        var val_14 = 0;
        val_14 = val_14 + 1;
        val_17 = val_13;
        typeof(System.Object[]).__il2cppRuntimeField_38 = val_13;
        UnityEngine.Debug.LogFormat(format:  0, args:  "FB Feed result: cancelled: {0}, error: {1}, PostID: {2}, raw result: {3}");
        var val_15 = 0;
        val_15 = val_15 + 1;
        val_18 = val_13;
        if(((val_13 & 1) & 1) != 0)
        {
                val_13 = 1;
        }
        else
        {
                var val_16 = 0;
            val_16 = val_16 + 1;
            val_19 = val_13;
            val_13 = (~(System.String.IsNullOrEmpty(value:  0))) & 1;
        }
        
        this.shareResultCallback.Invoke(obj:  (val_13 == 0) ? 1 : 0);
    }

}
