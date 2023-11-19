using UnityEngine;

namespace TzarGames.Endless.UI.MainMenu
{
    public class RateAppButtonUI : MonoBehaviour
    {
        // Fields
        [UnityEngine.SerializeField]
        private UnityEngine.Events.UnityEvent onNotYetPressed;
        [UnityEngine.SerializeField]
        private UnityEngine.Events.UnityEvent onRateAndroid;
        
        // Methods
        public RateAppButtonUI()
        {
        
        }
        private void Start()
        {
            TzarGames.Endless.EndlessGameState val_1 = TzarGames.Endless.EndlessGameState.Instance;
            if(0 == val_1)
            {
                    return;
            }
            
            if((val_1.CommonSaveGameData.HasInt(id:  "RATE_APP_BUTTON_PRESSED")) != false)
            {
                    return;
            }
            
            this.onNotYetPressed.Invoke();
        }
        public void Rate()
        {
            if(0 == TzarGames.Endless.EndlessGameState.Instance)
            {
                    return;
            }
            
            this.onRateAndroid.Invoke();
        }
    
    }

}
