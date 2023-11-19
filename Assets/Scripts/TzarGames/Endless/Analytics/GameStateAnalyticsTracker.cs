using UnityEngine;

namespace TzarGames.Endless.Analytics
{
    public class GameStateAnalyticsTracker : MonoBehaviour
    {
        // Fields
        [UnityEngine.SerializeField]
        private TzarGames.Common.CustomAnalyticsEvent initStartedEvent;
        [UnityEngine.SerializeField]
        private TzarGames.Endless.EndlessAnalyticsEvent stageStartedEvent;
        [UnityEngine.SerializeField]
        private TzarGames.Endless.EndlessAnalyticsEvent lobbyLoadedEvent;
        [UnityEngine.SerializeField]
        private TzarGames.Endless.EndlessAnalyticsEvent appPausedEvent;
        [UnityEngine.SerializeField]
        private TzarGames.Endless.EndlessAnalyticsEvent appResumedEvent;
        [UnityEngine.SerializeField]
        private TzarGames.Common.CustomAnalyticsEventTracker _eventTracker;
        
        // Methods
        public GameStateAnalyticsTracker()
        {
        
        }
        private void Awake()
        {
            TzarGames.Endless.EndlessGameState.add_OnStageStarted(value:  new System.Action(object:  this, method:  System.Void TzarGames.Endless.Analytics.GameStateAnalyticsTracker::EndlessGameStateOnOnStageStarted()) = new System.Action(object:  this, method:  System.Void TzarGames.Endless.Analytics.GameStateAnalyticsTracker::EndlessGameStateOnOnStageStarted()));
            TzarGames.Endless.EndlessGameState.add_OnLobbyLoaded(value:  new System.Action(object:  this, method:  System.Void TzarGames.Endless.Analytics.GameStateAnalyticsTracker::EndlessGameState_OnLobbyLoaded()) = new System.Action(object:  this, method:  System.Void TzarGames.Endless.Analytics.GameStateAnalyticsTracker::EndlessGameState_OnLobbyLoaded()));
            this._eventTracker.SendEvent(customEvent:  this.initStartedEvent);
        }
        private void EndlessGameState_OnLobbyLoaded()
        {
            this._eventTracker.SendEvent(customEvent:  this.lobbyLoadedEvent);
        }
        private void EndlessGameStateOnOnStageStarted()
        {
            this._eventTracker.SendEvent(customEvent:  this.stageStartedEvent);
        }
        private void OnDestroy()
        {
            TzarGames.Endless.EndlessGameState.remove_OnStageStarted(value:  new System.Action(object:  this, method:  System.Void TzarGames.Endless.Analytics.GameStateAnalyticsTracker::EndlessGameStateOnOnStageStarted()) = new System.Action(object:  this, method:  System.Void TzarGames.Endless.Analytics.GameStateAnalyticsTracker::EndlessGameStateOnOnStageStarted()));
            TzarGames.Endless.EndlessGameState.remove_OnLobbyLoaded(value:  new System.Action(object:  this, method:  System.Void TzarGames.Endless.Analytics.GameStateAnalyticsTracker::EndlessGameState_OnLobbyLoaded()) = new System.Action(object:  this, method:  System.Void TzarGames.Endless.Analytics.GameStateAnalyticsTracker::EndlessGameState_OnLobbyLoaded()));
        }
        private void OnApplicationPause(bool pauseStatus)
        {
            TzarGames.Endless.EndlessAnalyticsEvent val_1;
            if(pauseStatus == false)
            {
                goto label_0;
            }
            
            val_1 = this.appPausedEvent;
            if(this._eventTracker != null)
            {
                goto label_3;
            }
            
            goto label_2;
            label_0:
            val_1 = this.appResumedEvent;
            if(this._eventTracker != null)
            {
                goto label_3;
            }
            
            label_2:
            label_3:
            this._eventTracker.SendEvent(customEvent:  val_1);
        }
    
    }

}
