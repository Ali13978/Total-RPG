using UnityEngine;

namespace TzarGames.Endless.UI.MainMenu
{
    public class MainMenuUI : UIBase, IItemDatabaseProvider
    {
        // Fields
        [UnityEngine.SerializeField]
        private TzarGames.Common.UI.TextUI stageLabel;
        [UnityEngine.SerializeField]
        private TzarGames.Common.LocalizedStringAsset stageFormat;
        [UnityEngine.SerializeField]
        private TzarGames.Common.UI.TextUI characterNameLabel;
        [UnityEngine.SerializeField]
        private TzarGames.Endless.PlayerCharacterBase _playerCharacter;
        [UnityEngine.SerializeField]
        private TzarGames.GameFramework.ItemDatabaseData itemDatabase;
        [UnityEngine.SerializeField]
        private TzarGames.Common.UI.UIBase autenticatingStatus;
        [UnityEngine.SerializeField]
        private TzarGames.Common.UI.UIBase socialMenu;
        [UnityEngine.SerializeField]
        private UnityEngine.UI.Button continueButton;
        [UnityEngine.SerializeField]
        private UnityEngine.GameObject harcoreModeLabel;
        [UnityEngine.SerializeField]
        private UnityEngine.GameObject isDeadLabel;
        [UnityEngine.SerializeField]
        private UnityEngine.GameObject hardcoreEnvironment;
        [UnityEngine.SerializeField]
        private UnityEngine.GameObject rateButton;
        
        // Properties
        public TzarGames.GameFramework.ItemDatabaseData ItemDatabase { get; }
        
        // Methods
        public MainMenuUI()
        {
        
        }
        private void setSocialAuthenticating(bool on)
        {
            on = on;
            var val_1 = (~on) & 1;
            goto typeof(TzarGames.Common.UI.UIBase).__il2cppRuntimeField_160;
        }
        public TzarGames.GameFramework.ItemDatabaseData get_ItemDatabase()
        {
            return (TzarGames.GameFramework.ItemDatabaseData)this.itemDatabase;
        }
        public void UpdateHardcoreEnvironment()
        {
            var val_10;
            if(0 == TzarGames.Endless.EndlessGameState.Instance)
            {
                    return;
            }
            
            if(TzarGames.Endless.EndlessGameState.Instance.SelectedCharacter == null)
            {
                    return;
            }
            
            TzarGames.Endless.ICharacterInfo val_7 = TzarGames.Endless.EndlessGameState.Instance.SelectedCharacter;
            var val_10 = 0;
            val_10 = val_10 + 1;
            val_10 = val_7;
            this.hardcoreEnvironment.SetActive(value:  val_7 & 1);
        }
        public void ShowHardcoreEnvironment(bool show)
        {
            show = show;
            this.hardcoreEnvironment.SetActive(value:  show);
        }
        protected override void OnVisible()
        {
            var val_16;
            var val_17;
            var val_18;
            var val_19;
            UnityEngine.GameObject val_20;
            var val_21;
            this.OnVisible();
            var val_16 = 0;
            val_16 = val_16 + 1;
            val_16 = TzarGames.Endless.EndlessGameState.Instance.SelectedCharacter;
            this.stageLabel.text = System.String.Format(format:  0, arg0:  TzarGames.Common.LocalizedStringAsset.op_Implicit(text:  0));
            TzarGames.Endless.ICharacterInfo val_7 = TzarGames.Endless.EndlessGameState.Instance.SelectedCharacter;
            var val_17 = 0;
            val_17 = val_17 + 1;
            val_17 = val_7;
            this.characterNameLabel.text = val_7;
            this.updatePlayerCharacter();
            TzarGames.Endless.ICharacterInfo val_10 = TzarGames.Endless.EndlessGameState.Instance.SelectedCharacter;
            var val_18 = 0;
            val_18 = val_18 + 1;
            val_18 = val_10;
            if((val_10 & 1) == 0)
            {
                goto label_24;
            }
            
            this.harcoreModeLabel.SetActive(value:  true);
            TzarGames.Endless.ICharacterInfo val_13 = TzarGames.Endless.EndlessGameState.Instance.SelectedCharacter;
            var val_19 = 0;
            val_19 = val_19 + 1;
            val_19 = val_13;
            goto label_30;
            label_24:
            this.harcoreModeLabel.SetActive(value:  false);
            goto label_32;
            label_30:
            if((val_13 & 1) == 0)
            {
                goto label_32;
            }
            
            this.continueButton.gameObject.SetActive(value:  false);
            val_20 = this.isDeadLabel;
            val_21 = 1;
            goto label_36;
            label_32:
            val_20 = this.isDeadLabel;
            val_21 = 0;
            label_36:
            val_20.SetActive(value:  false);
            this.UpdateHardcoreEnvironment();
        }
        public void ShowLeaderboard()
        {
            if(TzarGames.Endless.SocialSystem.Instance.IsAuthenticated != false)
            {
                    TzarGames.Endless.SocialSystem.Instance.ShowDefaultLeaderboardUI();
                return;
            }
            
            this.setSocialAuthenticating(on:  true);
            TzarGames.Endless.SocialSystem.Instance.Authenticate(callback:  new System.Action<System.Boolean, System.String>(object:  this, method:  System.Void TzarGames.Endless.UI.MainMenu.MainMenuUI::<ShowLeaderboard>m__0(bool success, string message)));
        }
        private void updatePlayerCharacter()
        {
            this._playerCharacter.gameObject.SetActive(value:  true);
            this._playerCharacter.SetImmobilizedState(immobilized:  true);
            TzarGames.Endless.EndlessHeroData val_3 = TzarGames.Endless.EndlessGameState.Instance.GetHeroData();
            if(this._playerCharacter == null)
            {
                
            }
        
        }
        public void ContinueGame()
        {
            UnityEngine.Coroutine val_2 = this.StartCoroutine(routine:  this.continueGameRoutine());
        }
        public void StartMultiplayer()
        {
            UnityEngine.Coroutine val_2 = this.StartCoroutine(routine:  this.multiplayerRoutine());
        }
        [System.Diagnostics.DebuggerHiddenAttribute]
        private System.Collections.IEnumerator multiplayerRoutine()
        {
            return (System.Collections.IEnumerator)new System.Object();
        }
        [System.Diagnostics.DebuggerHiddenAttribute]
        private System.Collections.IEnumerator continueGameRoutine()
        {
            return (System.Collections.IEnumerator)new System.Object();
        }
        protected override void Start()
        {
            var val_7;
            UnityEngine.GameObject val_8;
            var val_9;
            this.Start();
            this.stageFormat.add_OnUpdated(value:  new System.Action<TzarGames.Common.LocalizedStringAsset>(object:  this, method:  System.Void TzarGames.Endless.UI.MainMenu.MainMenuUI::StageFormatOnOnUpdated(TzarGames.Common.LocalizedStringAsset localizedStringAsset)));
            TzarGames.Endless.EndlessGameState val_2 = TzarGames.Endless.EndlessGameState.Instance;
            if(0 == val_2)
            {
                    return;
            }
            
            if(val_2.SelectedCharacter == null)
            {
                goto label_13;
            }
            
            TzarGames.Endless.ICharacterInfo val_5 = val_2.SelectedCharacter;
            var val_7 = 0;
            val_7 = val_7 + 1;
            val_7 = val_5;
            if(val_5 < 6)
            {
                goto label_13;
            }
            
            val_8 = this.rateButton;
            val_9 = 1;
            goto label_15;
            label_13:
            val_8 = this.rateButton;
            val_9 = 0;
            label_15:
            val_8.SetActive(value:  false);
        }
        private void StageFormatOnOnUpdated(TzarGames.Common.LocalizedStringAsset localizedStringAsset)
        {
            var val_6;
            var val_6 = 0;
            val_6 = val_6 + 1;
            val_6 = TzarGames.Endless.EndlessGameState.Instance.SelectedCharacter;
            this.stageLabel.text = System.String.Format(format:  0, arg0:  TzarGames.Common.LocalizedStringAsset.op_Implicit(text:  0));
        }
        private void OnDestroy()
        {
            if(0 == this.stageFormat)
            {
                    return;
            }
            
            this.stageFormat.remove_OnUpdated(value:  new System.Action<TzarGames.Common.LocalizedStringAsset>(object:  this, method:  System.Void TzarGames.Endless.UI.MainMenu.MainMenuUI::StageFormatOnOnUpdated(TzarGames.Common.LocalizedStringAsset localizedStringAsset)));
        }
        private void <ShowLeaderboard>m__0(bool success, string message)
        {
            this.setSocialAuthenticating(on:  false);
            if(success == false)
            {
                    return;
            }
            
            TzarGames.Endless.SocialSystem.Instance.ShowDefaultLeaderboardUI();
        }
    
    }

}
