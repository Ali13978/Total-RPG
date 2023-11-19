using UnityEngine;

namespace TzarGames.Endless
{
    public abstract class RewardHandler : MonoBehaviour, IRewardHandler
    {
        // Fields
        [UnityEngine.SerializeField]
        private TzarGames.Endless.Reward _reward;
        [UnityEngine.SerializeField]
        private UnityEngine.Events.UnityEvent OnRewardActive;
        [UnityEngine.SerializeField]
        private UnityEngine.Events.UnityEvent OnRewardDisabled;
        
        // Properties
        public TzarGames.Endless.Reward Reward { get; }
        
        // Methods
        protected RewardHandler()
        {
        
        }
        public TzarGames.Endless.Reward get_Reward()
        {
            return (TzarGames.Endless.Reward)this._reward;
        }
        private void Start()
        {
            this.checkReward();
        }
        private void checkReward()
        {
            UnityEngine.Events.UnityEvent val_2;
            if((21745.CanGetReward(reward:  this._reward)) == false)
            {
                goto label_2;
            }
            
            val_2 = this.OnRewardActive;
            if(val_2 != null)
            {
                goto label_5;
            }
            
            goto label_4;
            label_2:
            val_2 = this.OnRewardDisabled;
            if(val_2 != null)
            {
                goto label_5;
            }
            
            label_4:
            label_5:
            val_2.Invoke();
        }
        public abstract void Open(); // 0
        protected void giveReward()
        {
            TzarGames.Endless.Rewarder.<Instance>k__BackingField.ProcessUniqueReward(reward:  this._reward);
            this.checkReward();
        }
    
    }

}
