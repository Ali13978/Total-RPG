using UnityEngine;

namespace TzarGames.Endless
{
    public interface IDeatchmatchPlayerScore
    {
        // Properties
        public abstract int PlayerID { get; }
        public abstract int Score { get; }
        
        // Methods
        public abstract int get_PlayerID(); // 0
        public abstract int get_Score(); // 0
    
    }

}
