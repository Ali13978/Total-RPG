using UnityEngine;

namespace TzarGames.Endless
{
    public class EndlessAdManager : AdsServiceManager
    {
        // Methods
        public EndlessAdManager()
        {
        
        }
        protected override void Start()
        {
            this.Start();
            this.add_OnAdSkippedOrFinished(value:  new System.Action<TzarGames.Common.IAdsService>(object:  this, method:  System.Void TzarGames.Endless.EndlessAdManager::OnOnAdSkippedOrFinished(TzarGames.Common.IAdsService adsService)));
            this.add_OnAdStarted(value:  new System.Action<TzarGames.Common.IAdsService>(object:  this, method:  System.Void TzarGames.Endless.EndlessAdManager::OnOnAdStarted(TzarGames.Common.IAdsService adsService)));
        }
        private void OnOnAdStarted(TzarGames.Common.IAdsService adsService)
        {
            string val_1 = 0 + "Ad started ";
            UnityEngine.Debug.Log(message:  0);
            TzarGames.Endless.EndlessGameState._instance.paused = true;
            UnityEngine.Time.timeScale = 0f;
        }
        private void OnOnAdSkippedOrFinished(TzarGames.Common.IAdsService adsService)
        {
            string val_1 = 0 + "Ad skipped or finished ";
            UnityEngine.Debug.Log(message:  0);
            TzarGames.Endless.EndlessGameState._instance.paused = false;
            UnityEngine.Time.timeScale = 1f;
        }
    
    }

}
