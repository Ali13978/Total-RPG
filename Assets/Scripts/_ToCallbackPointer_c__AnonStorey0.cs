using UnityEngine;
private sealed class RealTimeEventListenerHelper.<ToCallbackPointer>c__AnonStorey0
{
    // Fields
    internal System.Action<GooglePlayGames.Native.PInvoke.NativeRealTimeRoom> callback;
    
    // Methods
    public RealTimeEventListenerHelper.<ToCallbackPointer>c__AnonStorey0()
    {
    
    }
    internal void <>m__0(IntPtr result)
    {
        GooglePlayGames.Native.PInvoke.NativeRealTimeRoom val_1 = GooglePlayGames.Native.PInvoke.NativeRealTimeRoom.FromPointer(selfPointer:  0);
        if(this.callback != null)
        {
                this.callback.Invoke(obj:  val_1);
            return;
        }
        
        if(val_1 == null)
        {
                return;
        }
        
        val_1.Dispose();
    }

}
