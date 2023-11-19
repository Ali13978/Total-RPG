using UnityEngine;
private sealed class NativeEventClient.<FetchAllEvents>c__AnonStorey0
{
    // Fields
    internal System.Action<GooglePlayGames.BasicApi.ResponseStatus, System.Collections.Generic.List<GooglePlayGames.BasicApi.Events.IEvent>> callback;
    
    // Methods
    public NativeEventClient.<FetchAllEvents>c__AnonStorey0()
    {
    
    }
    internal void <>m__0(GooglePlayGames.Native.PInvoke.EventManager.FetchAllResponse response)
    {
        System.Collections.Generic.List<GooglePlayGames.BasicApi.Events.IEvent> val_9;
        ResponseStatus val_1 = response.ResponseStatus();
        if(response.RequestSucceeded() == false)
        {
            goto label_3;
        }
        
        System.Collections.Generic.List<GooglePlayGames.Native.PInvoke.NativeEvent> val_5 = response.Data();
        System.Collections.Generic.IEnumerable<TResult> val_6 = System.Linq.Enumerable.Cast<GooglePlayGames.BasicApi.SavedGame.ISavedGameMetadata>(source:  0);
        val_9 = System.Linq.Enumerable.ToList<UnityEngine.Component>(source:  0);
        if(this.callback != null)
        {
            goto label_7;
        }
        
        goto label_6;
        label_3:
        System.Collections.Generic.List<GooglePlayGames.BasicApi.Events.IEvent> val_8 = null;
        val_9 = val_8;
        val_8 = new System.Collections.Generic.List<GooglePlayGames.BasicApi.Events.IEvent>();
        if(this.callback != null)
        {
            goto label_7;
        }
        
        label_6:
        label_7:
        this.callback.Invoke(arg1:  GooglePlayGames.Native.ConversionUtils.ConvertResponseStatus(status:  0), arg2:  val_9);
    }

}
