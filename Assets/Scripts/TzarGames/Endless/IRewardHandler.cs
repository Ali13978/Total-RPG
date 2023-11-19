using UnityEngine;

namespace TzarGames.Endless
{
    public interface IRewardHandler
    {
        // Properties
        public abstract TzarGames.Endless.Reward Reward { get; }
        
        // Methods
        public abstract TzarGames.Endless.Reward get_Reward(); // 0
    
    }

}
