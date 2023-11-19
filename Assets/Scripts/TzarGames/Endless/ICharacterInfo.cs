using UnityEngine;

namespace TzarGames.Endless
{
    public interface ICharacterInfo
    {
        // Properties
        public abstract string Name { get; }
        public abstract uint CurrentStage { get; }
        public abstract uint CurrentPromoStage { get; }
        public abstract uint MaxStage { get; }
        public abstract ulong Ruby { get; }
        public abstract TzarGames.Common.SerializableData Data { get; }
        public abstract bool IsHardcore { get; }
        public abstract bool Dead { get; set; }
        public abstract TzarGames.Endless.CharacterStatistics Statistics { get; }
        
        // Methods
        public abstract string get_Name(); // 0
        public abstract uint get_CurrentStage(); // 0
        public abstract uint get_CurrentPromoStage(); // 0
        public abstract uint get_MaxStage(); // 0
        public abstract ulong get_Ruby(); // 0
        public abstract void AddRuby(int rubyValue); // 0
        public abstract TzarGames.Common.SerializableData get_Data(); // 0
        public abstract TzarGames.Endless.IHeroData GetHeroData(); // 0
        public abstract bool get_IsHardcore(); // 0
        public abstract bool get_Dead(); // 0
        public abstract void set_Dead(bool value); // 0
        public abstract TzarGames.Endless.CharacterStatistics get_Statistics(); // 0
    
    }

}
