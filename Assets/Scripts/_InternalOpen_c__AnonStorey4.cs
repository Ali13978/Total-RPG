using UnityEngine;
private sealed class NativeSavedGameClient.<InternalOpen>c__AnonStorey3.<InternalOpen>c__AnonStorey4
{
    // Fields
    internal GooglePlayGames.Native.NativeSavedGameClient.NativeConflictResolver resolver;
    internal GooglePlayGames.Native.PInvoke.NativeSnapshotMetadata original;
    internal GooglePlayGames.Native.PInvoke.NativeSnapshotMetadata unmerged;
    internal GooglePlayGames.Native.NativeSavedGameClient.<InternalOpen>c__AnonStorey3 <>f__ref$3;
    
    // Methods
    public NativeSavedGameClient.<InternalOpen>c__AnonStorey3.<InternalOpen>c__AnonStorey4()
    {
    
    }
    internal void <>m__0()
    {
        NativeSavedGameClient.<InternalOpen>c__AnonStorey3 val_3;
        GooglePlayGames.Native.NativeSavedGameClient val_4;
        val_3 = this.<>f__ref$3;
        if(val_3 == null)
        {
            goto label_0;
        }
        
        val_4 = this.<>f__ref$3.$this;
        goto label_1;
        label_0:
        val_4 = this.<>f__ref$3.$this;
        if((this.<>f__ref$3) == null)
        {
            goto label_2;
        }
        
        val_3 = this.<>f__ref$3;
        label_1:
        label_4:
        label_5:
        label_6:
        label_9:
        val_4.InternalOpen(filename:  this.<>f__ref$3.filename, source:  this.<>f__ref$3.source, resolutionStrategy:  this.<>f__ref$3.resolutionStrategy, prefetchDataOnConflict:  ((this.<>f__ref$3.prefetchDataOnConflict) == true) ? 1 : 0, conflictCallback:  this.<>f__ref$3.conflictCallback, completedCallback:  this.<>f__ref$3.completedCallback);
        return;
        label_2:
        if((this.<>f__ref$3) != null)
        {
            goto label_4;
        }
        
        if((this.<>f__ref$3) != null)
        {
            goto label_5;
        }
        
        if((this.<>f__ref$3) != null)
        {
            goto label_6;
        }
        
        var val_2 = ((this.<>f__ref$3.prefetchDataOnConflict) == true) ? 1 : 0;
        if((this.<>f__ref$3) == null)
        {
            goto label_7;
        }
        
        goto label_9;
        label_7:
        if((this.<>f__ref$3) != null)
        {
            goto label_9;
        }
    
    }
    internal void <>m__1(byte[] originalData, byte[] unmergedData)
    {
        this.<>f__ref$3.conflictCallback.Invoke(resolver:  this.resolver, original:  this.original, originalData:  originalData, unmerged:  this.unmerged, unmergedData:  unmergedData);
    }

}
