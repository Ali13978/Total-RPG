using UnityEngine;

namespace GooglePlayGames.Native
{
    internal class NativeEventClient : IEventsClient
    {
        // Fields
        private readonly GooglePlayGames.Native.PInvoke.EventManager mEventManager;
        
        // Methods
        internal NativeEventClient(GooglePlayGames.Native.PInvoke.EventManager manager)
        {
            this.mEventManager = GooglePlayGames.OurUtils.Misc.CheckNotNull<GooglePlayGames.BasicApi.IPlayGamesClient>(value:  0);
        }
        public void FetchAllEvents(GooglePlayGames.BasicApi.DataSource source, System.Action<GooglePlayGames.BasicApi.ResponseStatus, System.Collections.Generic.List<GooglePlayGames.BasicApi.Events.IEvent>> callback)
        {
            var val_8;
            System.Action<T1, T2> val_9;
            object val_1 = new System.Object();
            if(null != 0)
            {
                    val_8 = val_1;
                typeof(NativeEventClient.<FetchAllEvents>c__AnonStorey0).__il2cppRuntimeField_10 = callback;
                GooglePlayGames.BasicApi.IPlayGamesClient val_2 = GooglePlayGames.OurUtils.Misc.CheckNotNull<GooglePlayGames.BasicApi.IPlayGamesClient>(value:  0);
                val_9 = GooglePlayGames.Native.CallbackUtils.ToOnGameThread<GooglePlayGames.BasicApi.ResponseStatus, System.Object>(toConvert:  0);
            }
            else
            {
                    val_8 = 16;
                mem[16] = callback;
                GooglePlayGames.BasicApi.IPlayGamesClient val_4 = GooglePlayGames.OurUtils.Misc.CheckNotNull<GooglePlayGames.BasicApi.IPlayGamesClient>(value:  0);
                val_9 = GooglePlayGames.Native.CallbackUtils.ToOnGameThread<GooglePlayGames.BasicApi.ResponseStatus, System.Object>(toConvert:  0);
            }
            
            mem[16] = val_9;
            this.mEventManager.FetchAll(source:  GooglePlayGames.Native.ConversionUtils.AsDataSource(source:  0), callback:  new System.Action<FetchAllResponse>(object:  val_1, method:  System.Void NativeEventClient.<FetchAllEvents>c__AnonStorey0::<>m__0(GooglePlayGames.Native.PInvoke.EventManager.FetchAllResponse response)));
        }
        public void FetchEvent(GooglePlayGames.BasicApi.DataSource source, string eventId, System.Action<GooglePlayGames.BasicApi.ResponseStatus, GooglePlayGames.BasicApi.Events.IEvent> callback)
        {
            typeof(NativeEventClient.<FetchEvent>c__AnonStorey1).__il2cppRuntimeField_10 = callback;
            GooglePlayGames.BasicApi.IPlayGamesClient val_2 = GooglePlayGames.OurUtils.Misc.CheckNotNull<GooglePlayGames.BasicApi.IPlayGamesClient>(value:  0);
            GooglePlayGames.BasicApi.IPlayGamesClient val_3 = GooglePlayGames.OurUtils.Misc.CheckNotNull<GooglePlayGames.BasicApi.IPlayGamesClient>(value:  0);
            this.mEventManager.Fetch(source:  GooglePlayGames.Native.ConversionUtils.AsDataSource(source:  0), eventId:  eventId, callback:  new System.Action<FetchResponse>(object:  new System.Object(), method:  System.Void NativeEventClient.<FetchEvent>c__AnonStorey1::<>m__0(GooglePlayGames.Native.PInvoke.EventManager.FetchResponse response)));
        }
        public void IncrementEvent(string eventId, uint stepsToIncrement)
        {
            GooglePlayGames.BasicApi.IPlayGamesClient val_1 = GooglePlayGames.OurUtils.Misc.CheckNotNull<GooglePlayGames.BasicApi.IPlayGamesClient>(value:  0);
            this.mEventManager.Increment(eventId:  eventId, steps:  stepsToIncrement);
        }
    
    }

}
