using UnityEngine;

namespace TzarGames.Endless.UI.MainMenu
{
    public class RewardCheckerUI : MonoBehaviour
    {
        // Fields
        [UnityEngine.SerializeField]
        private UnityEngine.Events.UnityEvent onAnyRewardAvailable;
        
        // Methods
        public RewardCheckerUI()
        {
        
        }
        private void Start()
        {
            var val_6;
            var val_7;
            val_6 = 0;
            goto label_1;
            label_14:
            val_6 = 1;
            label_1:
            if(val_6 >= val_1.Length)
            {
                    return;
            }
            
            T val_5 = this.GetComponentsInChildren<TzarGames.Endless.IRewardHandler>()[1];
            if(val_5 == 0)
            {
                goto label_5;
            }
            
            var val_8 = val_5;
            if((val_1[0x1][0] + 258) == 0)
            {
                goto label_6;
            }
            
            var val_6 = val_1[0x1][0] + 152;
            var val_7 = 0;
            val_6 = val_6 + 8;
            label_8:
            if(((val_1[0x1][0] + 152 + 8) + -8) == null)
            {
                goto label_7;
            }
            
            val_7 = val_7 + 1;
            val_6 = val_6 + 16;
            if(val_7 < (val_1[0x1][0] + 258))
            {
                goto label_8;
            }
            
            label_6:
            val_7 = val_5;
            goto label_9;
            label_5:
            UnityEngine.Debug.LogError(message:  0);
            goto label_14;
            label_7:
            val_8 = val_8 + (((val_1[0x1][0] + 152 + 8)) << 4);
            val_7 = val_8 + 272;
            label_9:
            if((TzarGames.Endless.Rewarder.Instance.CanGetReward(reward:  val_5)) == false)
            {
                goto label_14;
            }
            
            this.onAnyRewardAvailable.Invoke();
        }
    
    }

}
