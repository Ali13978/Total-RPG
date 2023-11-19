using UnityEngine;

namespace TzarGames.Endless.Quests
{
    public interface IQuestInfo
    {
        // Properties
        public abstract int Id { get; }
        public abstract TzarGames.Common.SerializableData Data { get; }
        
        // Methods
        public abstract int get_Id(); // 0
        public abstract TzarGames.Common.SerializableData get_Data(); // 0
    
    }

}
