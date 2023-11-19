using UnityEngine;

namespace TzarGames.Endless
{
    public class RubyReward : Reward
    {
        // Fields
        [UnityEngine.SerializeField]
        private int rubyCount;
        
        // Properties
        public int RubyCount { get; }
        
        // Methods
        public RubyReward()
        {
            this.rubyCount = 1;
            val_1 = new TzarGames.Common.CommonAsset();
        }
        public int get_RubyCount()
        {
            return (int)this.rubyCount;
        }
    
    }

}
