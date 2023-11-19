using UnityEngine;

namespace GooglePlayGames.BasicApi.Events
{
    public interface IEvent
    {
        // Properties
        public abstract string Id { get; }
        public abstract string Name { get; }
        public abstract string Description { get; }
        public abstract string ImageUrl { get; }
        public abstract ulong CurrentCount { get; }
        public abstract GooglePlayGames.BasicApi.Events.EventVisibility Visibility { get; }
        
        // Methods
        public abstract string get_Id(); // 0
        public abstract string get_Name(); // 0
        public abstract string get_Description(); // 0
        public abstract string get_ImageUrl(); // 0
        public abstract ulong get_CurrentCount(); // 0
        public abstract GooglePlayGames.BasicApi.Events.EventVisibility get_Visibility(); // 0
    
    }

}
