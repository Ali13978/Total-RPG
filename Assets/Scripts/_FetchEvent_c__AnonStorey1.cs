using UnityEngine;
private sealed class NativeEventClient.<FetchEvent>c__AnonStorey1
{
    // Fields
    internal System.Action<GooglePlayGames.BasicApi.ResponseStatus, GooglePlayGames.BasicApi.Events.IEvent> callback;
    
    // Methods
    public NativeEventClient.<FetchEvent>c__AnonStorey1()
    {
    
    }
    internal void <>m__0(GooglePlayGames.Native.PInvoke.EventManager.FetchResponse response)
    {
        var val_6;
        GooglePlayGames.BasicApi.ResponseStatus val_7;
        GooglePlayGames.BasicApi.Events.IEvent val_8;
        var val_9;
        val_6 = response;
        ResponseStatus val_1 = val_6.ResponseStatus();
        GooglePlayGames.BasicApi.ResponseStatus val_2 = GooglePlayGames.Native.ConversionUtils.ConvertResponseStatus(status:  0);
        if(val_6.RequestSucceeded() != false)
        {
                val_6 = val_6.Data();
            val_7 = val_2;
            val_8 = val_6;
            val_9 = public System.Void System.Action<GooglePlayGames.BasicApi.ResponseStatus, GooglePlayGames.BasicApi.Events.IEvent>::Invoke(GooglePlayGames.BasicApi.ResponseStatus arg1, GooglePlayGames.BasicApi.Events.IEvent arg2);
        }
        else
        {
                val_8 = 0;
            val_7 = val_2;
            val_9 = public System.Void System.Action<GooglePlayGames.BasicApi.ResponseStatus, GooglePlayGames.BasicApi.Events.IEvent>::Invoke(GooglePlayGames.BasicApi.ResponseStatus arg1, GooglePlayGames.BasicApi.Events.IEvent arg2);
        }
        
        this.callback.Invoke(arg1:  val_7, arg2:  val_8);
    }

}
