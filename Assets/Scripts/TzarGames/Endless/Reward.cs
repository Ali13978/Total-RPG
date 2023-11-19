using UnityEngine;

namespace TzarGames.Endless
{
    public class Reward : CommonAsset
    {
        // Methods
        public Reward()
        {
        
        }
        public virtual string GetRewardMessage(int count)
        {
            return 0;
        }
        public virtual void ProcessReward(int count)
        {
        
        }
        public virtual bool CanRewardedInGameState()
        {
            return false;
        }
        public virtual bool CanRewardedInMainMenu()
        {
            return true;
        }
        public virtual bool IsReadyToProcess()
        {
            return true;
        }
    
    }

}
