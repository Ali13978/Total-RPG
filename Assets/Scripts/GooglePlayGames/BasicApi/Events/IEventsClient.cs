using UnityEngine;

namespace GooglePlayGames.BasicApi.Events
{
    public interface IEventsClient
    {
        // Methods
        public abstract void FetchAllEvents(GooglePlayGames.BasicApi.DataSource source, System.Action<GooglePlayGames.BasicApi.ResponseStatus, System.Collections.Generic.List<GooglePlayGames.BasicApi.Events.IEvent>> callback); // 0
        public abstract void FetchEvent(GooglePlayGames.BasicApi.DataSource source, string eventId, System.Action<GooglePlayGames.BasicApi.ResponseStatus, GooglePlayGames.BasicApi.Events.IEvent> callback); // 0
        public abstract void IncrementEvent(string eventId, uint stepsToIncrement); // 0
    
    }

}
