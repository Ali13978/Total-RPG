using UnityEngine;

namespace TzarGames.Endless.UI
{
    public class DeathUI : GameUIBase
    {
        // Fields
        [UnityEngine.SerializeField]
        private TzarGames.Common.UI.UIBase mainWindow;
        [UnityEngine.SerializeField]
        private TzarGames.Common.UI.UIBase loseProgressDialog;
        [UnityEngine.SerializeField]
        private TzarGames.Common.UI.UIBase hardcoreDeadWindow;
        [UnityEngine.SerializeField]
        private TzarGames.Common.UI.UIBase restartWindow;
        [UnityEngine.SerializeField]
        private TzarGames.Common.UI.UIBase noAdsWindow;
        [UnityEngine.SerializeField]
        private TzarGames.Endless.UI.GameUI gameUI;
        [UnityEngine.SerializeField]
        private TzarGames.Common.ShowAds ads;
        [UnityEngine.SerializeField]
        private TzarGames.Endless.EndlessAnalyticsEvent deathAnalyticsEvent;
        [UnityEngine.SerializeField]
        private TzarGames.Common.CustomAnalyticsEventTracker _eventTracker;
        [UnityEngine.SerializeField]
        private UnityEngine.GameObject respawnByAdsButton;
        [UnityEngine.SerializeField]
        private UnityEngine.GameObject respawnByRubyButton;
        private TzarGames.Endless.PlayerCharacter _character;
        
        // Methods
        public DeathUI()
        {
        
        }
        public void Restart()
        {
            TzarGames.Endless.EndlessGameState.Instance.RestartCurrentPromoLevel();
            if(this.restartWindow == null)
            {
                
            }
        
        }
        protected override void OnPlayerOwnerSet(TzarGames.GameFramework.Player owner)
        {
            var val_5;
            this.OnPlayerOwnerSet(owner:  owner);
            if(owner == null)
            {
                    return;
            }
            
            if(owner.itsMe == false)
            {
                    return;
            }
            
            if(owner.PlayerComponent == null)
            {
                    return;
            }
            
            val_5 = 0;
            this._character = ;
            if(0 == )
            {
                    return;
            }
            
            this._character.add_OnCharacterDead(value:  new TH_Character.dlgDeadEvent(object:  this, method:  System.Void TzarGames.Endless.UI.DeathUI::CharacterOnOnCharacterDead(TzarGames.TzarHero.DeadEventData deadEventData)));
        }
        private void CharacterOnOnCharacterDead(TzarGames.TzarHero.DeadEventData deadEventData)
        {
            TzarGames.Endless.EndlessAnalyticsEvent val_11 = this.deathAnalyticsEvent;
            if(0 == val_11)
            {
                    return;
            }
            
            val_11 = this._eventTracker;
            if(deadEventData == null)
            {
                    return;
            }
            
            if(0 == val_11)
            {
                    return;
            }
            
            if(0 != deadEventData.Killer)
            {
                    if(0 != deadEventData.Killer.Template)
            {
                    Add(key:  "killed_by", value:  deadEventData.Killer.Template.CharacterName);
            }
            
            }
            
            this._eventTracker.SendEvent(customEvent:  this.deathAnalyticsEvent, paramaters:  new System.Collections.Generic.Dictionary<System.String, System.Object>());
        }
        private void OnDestroy()
        {
            if(0 == this._character)
            {
                    return;
            }
            
            this._character.remove_OnCharacterDead(value:  new TH_Character.dlgDeadEvent(object:  this, method:  System.Void TzarGames.Endless.UI.DeathUI::CharacterOnOnCharacterDead(TzarGames.TzarHero.DeadEventData deadEventData)));
        }
        public void NotifyVisible()
        {
            var val_14;
            var val_15;
            var val_16;
            var val_17;
            TzarGames.Common.UI.UIBase val_18;
            val_14 = this;
            TzarGames.Endless.EndlessGameState val_1 = TzarGames.Endless.EndlessGameState.Instance;
            val_15 = 0;
            if(0 == val_1)
            {
                goto label_15;
            }
            
            val_16 = val_1.SelectedCharacter;
            var val_14 = 0;
            val_14 = val_14 + 1;
            val_15 = 9;
            val_17 = val_16;
            if((val_16 & 1) == 0)
            {
                goto label_11;
            }
            
            val_18 = this.hardcoreDeadWindow;
            if(val_18 != null)
            {
                goto label_16;
            }
            
            goto label_13;
            label_11:
            if(val_1.IsInPromoGameState() == false)
            {
                goto label_15;
            }
            
            val_18 = this.restartWindow;
            if(val_18 != null)
            {
                goto label_16;
            }
            
            label_13:
            label_16:
            val_14 = ???;
            val_16 = ???;
            goto typeof(TzarGames.Common.UI.UIBase).__il2cppRuntimeField_160;
            label_15:
            if((val_14 + 120.IsReady()) != false)
            {
                    return;
            }
            
            val_14 + 120.RequestAd();
        }
        public void OnExitToLobbyClicked()
        {
            if(this.loseProgressDialog == null)
            {
                
            }
        
        }
        public void CancelExitToLobby()
        {
            if(this.loseProgressDialog == null)
            {
                
            }
        
        }
        public void CancelNoAdsWindow()
        {
            if(this.noAdsWindow == null)
            {
                
            }
        
        }
        public void ConfirmExitToLobbyClicked()
        {
            if(this.loseProgressDialog == null)
            {
                
            }
        
        }
        public void ExitToMainMenu()
        {
            TzarGames.Endless.EndlessGameState.Instance.ExitToMainMenu();
            if(this.hardcoreDeadWindow == null)
            {
                
            }
        
        }
        public void OnWatchAdvertPressed()
        {
            if(this.ads.IsReady() != false)
            {
                    this.ads.ShowAd();
                return;
            }
            
            if(this.noAdsWindow == null)
            {
                
            }
        
        }
        public void OnRespawnByRubyPressed()
        {
            TzarGames.GameFramework.GameManager val_1 = TzarGames.GameFramework.GameManager.Instance;
            if(0.CanRespawnLocalPlayerByRuby() != false)
            {
                    0.RespawnLocalPlayerByRuby();
                return;
            }
            
            this.gameUI.ShowRubyShop();
        }
        public void OnAdvertWatched()
        {
            TzarGames.GameFramework.GameManager val_1 = TzarGames.GameFramework.GameManager.Instance;
            if(0.CanLocalPlayerRespawnedByAdvert() != false)
            {
                    0.RespawnLocalPlayerByAdvert();
                return;
            }
            
            UnityEngine.Debug.LogError(message:  0);
        }
        private void Update()
        {
            if(this.mainWindow.gameObject.activeInHierarchy != false)
            {
                    if(this.mainWindow.IsVisible != false)
            {
                    TzarGames.GameFramework.GameManager val_4 = TzarGames.GameFramework.GameManager.Instance;
                this.respawnByAdsButton.SetActive(value:  0.CanLocalPlayerRespawnedByAdvert());
            }
            
            }
            
            if(this.noAdsWindow.gameObject.activeInHierarchy == false)
            {
                    return;
            }
            
            if(this.noAdsWindow.IsVisible == false)
            {
                    return;
            }
            
            if(this.ads.IsReady() == false)
            {
                    return;
            }
            
            this.ads.ShowAd();
        }
    
    }

}
