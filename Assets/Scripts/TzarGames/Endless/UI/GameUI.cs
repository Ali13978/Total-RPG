using UnityEngine;

namespace TzarGames.Endless.UI
{
    public class GameUI : GameUIBase
    {
        // Fields
        [UnityEngine.SerializeField]
        private string uiWindowTag;
        [UnityEngine.SerializeField]
        private TzarGames.Endless.UI.PlayerCharacterUI hud;
        [UnityEngine.SerializeField]
        private TzarGames.GameFramework.UI.GameUIBase mapMenu;
        [UnityEngine.SerializeField]
        private TzarGames.GameFramework.UI.GameUIBase cutsceneWindow;
        [UnityEngine.SerializeField]
        private TzarGames.GameFramework.UI.GameUIBase DeathMenu;
        [UnityEngine.SerializeField]
        private TzarGames.Endless.UI.GameplayMenuUI gameplayMenu;
        [UnityEngine.SerializeField]
        private TzarGames.Endless.UI.Lobby.LobbyUI lobby;
        [UnityEngine.SerializeField]
        private TzarGames.Endless.UI.XpPointManagementUI xpManagement;
        [UnityEngine.SerializeField]
        private TzarGames.Endless.AdsRewardUI adsRewardWindow;
        [UnityEngine.SerializeField]
        private TzarGames.Endless.UI.StatisticsUI statistics;
        [UnityEngine.SerializeField]
        private TzarGames.Endless.UI.StageCompleteUI stageCompleteUI;
        [UnityEngine.SerializeField]
        private TzarGames.Endless.UI.BuyGameUI buyGameUI;
        [UnityEngine.SerializeField]
        private TzarGames.Endless.UI.AlertUI alert;
        [UnityEngine.SerializeField]
        private UnityEngine.UI.Button settingsButton;
        [UnityEngine.SerializeField]
        private UnityEngine.UI.Button inventoryButton;
        [UnityEngine.SerializeField]
        private TzarGames.Endless.UI.FadeUI fadeBackground;
        [UnityEngine.SerializeField]
        private UnityEngine.GameObject xpManagementButton;
        [UnityEngine.SerializeField]
        private TzarGames.Endless.UI.RubyShopUI rubyShop;
        [UnityEngine.SerializeField]
        private TzarGames.Endless.UI.GoldShopUI goldShop;
        [UnityEngine.SerializeField]
        private TzarGames.Endless.UI.ShopUI itemShop;
        [UnityEngine.SerializeField]
        private TzarGames.Endless.UI.InventoryUI inventory;
        [UnityEngine.SerializeField]
        private TzarGames.Endless.UI.ForgeUI forge;
        [UnityEngine.SerializeField]
        private TzarGames.Endless.UI.TaskListUI taskList;
        [UnityEngine.SerializeField]
        private TzarGames.Endless.UI.QuestRewardUI questReward;
        [UnityEngine.SerializeField]
        private TzarGames.GameFramework.UI.GameUIBase loading;
        private System.Collections.Generic.List<TzarGames.GameFramework.UI.GameUIBase> allMenus;
        private System.Collections.Generic.List<TzarGames.GameFramework.UI.GameUIBase> gameMenus;
        private System.Collections.Generic.List<TzarGames.Endless.UI.GameUI.UiBaseState> stateHistory;
        [UnityEngine.SerializeField]
        private TzarGames.Common.LocalizedStringAsset stageMessage;
        [UnityEngine.SerializeField]
        private TzarGames.Common.LocalizedStringAsset lobbyMessage;
        [UnityEngine.SerializeField]
        private TzarGames.Common.LocalizedStringAsset newLevelMessage;
        
        // Properties
        public TzarGames.Endless.UI.PlayerCharacterUI HUD { get; }
        
        // Methods
        public GameUI()
        {
            this.uiWindowTag = "UI Window";
            this.allMenus = new System.Collections.Generic.List<TzarGames.GameFramework.UI.GameUIBase>();
            this.gameMenus = new System.Collections.Generic.List<TzarGames.GameFramework.UI.GameUIBase>();
            this.stateHistory = new System.Collections.Generic.List<UiBaseState>();
        }
        public TzarGames.Endless.UI.PlayerCharacterUI get_HUD()
        {
            return (TzarGames.Endless.UI.PlayerCharacterUI)this.hud;
        }
        private void Start()
        {
            var val_29;
            var val_30;
            var val_31;
            var val_32;
            System.Action val_1 = new System.Action(object:  this, method:  System.Void TzarGames.Endless.UI.GameUI::EndlessGameStateOnOnNeedPurchaseFullGame());
            TzarGames.Endless.EndlessGameState.add_OnNeedPurchaseFullGame(value:  0);
            System.Action val_2 = new System.Action(object:  this, method:  System.Void TzarGames.Endless.UI.GameUI::EndlessGameStateOnOnGameContinued());
            TzarGames.Endless.EndlessGameState.add_OnGameContinued(value:  0);
            if(0 == TzarGames.Endless.EndlessGameState.Instance)
            {
                goto label_3;
            }
            
            if(TzarGames.Endless.EndlessGameState.Instance.IsInGameState() == false)
            {
                goto label_5;
            }
            
            var val_29 = 0;
            val_29 = val_29 + 1;
            val_29 = TzarGames.Endless.EndlessGameState.Instance.SelectedCharacter;
            goto label_11;
            label_3:
            this.alert.Disable();
            goto label_13;
            label_5:
            if(TzarGames.Endless.EndlessGameState.Instance.IsInLobby() == false)
            {
                goto label_15;
            }
            
            var val_30 = 0;
            val_30 = val_30 + 1;
            val_30 = TzarGames.Endless.EndlessGameState.Instance.SelectedCharacter;
            goto label_21;
            label_15:
            bool val_16 = TzarGames.Endless.EndlessGameState.Instance.IsInTutorial();
            this.alert.Disable();
            goto label_34;
            label_11:
            val_31 = System.String.Format(format:  0, arg0:  TzarGames.Common.LocalizedStringAsset.op_Implicit(text:  0));
            this.alert.Show(message:  ((System.String.IsNullOrEmpty(value:  0)) != true) ? (val_31) : UnityEngine.Object.FindObjectOfType<UnityEngine.UI.Extensions.BoundTooltipItem>().GetCustomStoryName());
            goto label_34;
            label_21:
            this.alert.Show(message:  System.String.Format(format:  0, arg0:  TzarGames.Common.LocalizedStringAsset.op_Implicit(text:  0)));
            label_34:
            if(TzarGames.Endless.EndlessGameState.Instance.IsInLobby() != false)
            {
                    val_32 = 1;
            }
            else
            {
                    val_32 = 0;
            }
            
            this.xpManagementButton.SetActive(value:  false);
            label_13:
            System.Action val_28 = new System.Action(object:  this, method:  System.Void TzarGames.Endless.UI.GameUI::gameState_onLoadingStarted());
            TzarGames.Endless.EndlessGameState.add_OnLoadingStarted(value:  0);
        }
        private void EndlessGameStateOnOnGameContinued()
        {
            this.DisableAndFadeInHalf(onCompleteCallback:  0);
        }
        private void EndlessGameStateOnOnNeedPurchaseFullGame()
        {
            bool val_1 = this.GotoState<GameUI.BuyGame>(stateData:  0);
        }
        public void ShowAlert(string message)
        {
            this.alert.Show(message:  message);
        }
        public void ShowRubyShop()
        {
            bool val_1 = this.GotoState<GameUI.RubyShop>(stateData:  0);
        }
        public void ShowGoldShop()
        {
            bool val_1 = this.GotoState<GameUI.GoldShop>(stateData:  0);
        }
        public void ShowItemShop()
        {
            bool val_1 = this.GotoState<GameUI.ItemShop>(stateData:  0);
        }
        public void ShowInventory()
        {
            bool val_1 = this.GotoState<GameUI.Inventory>(stateData:  0);
        }
        public void ShowForge()
        {
            bool val_1 = this.GotoState<GameUI.Forge>(stateData:  0);
        }
        public void ShowTaskList()
        {
            bool val_1 = this.GotoState<GameUI.TaskList>(stateData:  0);
        }
        public void ShowMap()
        {
            bool val_1 = this.GotoState<GameUI.Map>(stateData:  0);
        }
        public void ShowQuestReward(TzarGames.Endless.Quests.IEndlessQuestReward questReward, System.Action callback)
        {
            if(null != 0)
            {
                    typeof(GameUI.QuestData).__il2cppRuntimeField_10 = questReward;
            }
            else
            {
                    mem[16] = questReward;
            }
            
            typeof(GameUI.QuestData).__il2cppRuntimeField_18 = callback;
            bool val_2 = this.GotoState<GameUI.QuestReward>(stateData:  new System.Object());
        }
        public void ShowPreviousStateMenu()
        {
            System.Collections.Generic.List<UiBaseState> val_12;
            var val_13;
            System.Collections.Generic.List<UiBaseState> val_14;
            var val_15;
            if(this.stateHistory.Count < 1)
            {
                    return;
            }
            
            val_12 = this.stateHistory;
            if(val_12 != null)
            {
                    val_13 = val_12.Count;
            }
            else
            {
                    val_13 = 0.Count;
                val_12 = 0;
            }
            
            val_12.RemoveAt(index:  val_13 - 1);
            if(this.stateHistory.Count < 1)
            {
                    return;
            }
            
            val_14 = this.stateHistory;
            if(val_14 != null)
            {
                    val_15 = val_14.Count;
            }
            else
            {
                    val_15 = 0.Count;
                val_14 = 0;
            }
            
            bool val_11 = this.GotoState(stateType:  val_14.Item[val_15 - 1].GetType(), stateData:  0);
        }
        public void ShowGameHUD()
        {
            bool val_1 = this.GotoState<GameUI.Gameplay>(stateData:  0);
        }
        public void ShowGameplayMenu(bool show)
        {
            var val_2;
            object val_3;
            if(show != false)
            {
                    val_2 = 1152921510912398480;
                val_3 = 0;
            }
            else
            {
                    val_2 = 1152921510912285456;
                val_3 = 0;
            }
            
            bool val_1 = this.GotoState<GameUI.Gameplay>(stateData:  val_3);
        }
        public void ShowStageCompleteMenu(bool show)
        {
            var val_2;
            object val_3;
            if(show != false)
            {
                    val_2 = 1152921510912511504;
                val_3 = 0;
            }
            else
            {
                    val_2 = 1152921510912285456;
                val_3 = 0;
            }
            
            bool val_1 = this.GotoState<GameUI.Gameplay>(stateData:  val_3);
        }
        public void ShowLoading()
        {
            bool val_1 = this.GotoState<GameUI.Loading>(stateData:  0);
        }
        public void ShowXpManagement()
        {
            bool val_1 = this.GotoState<GameUI.XpManagement>(stateData:  0);
        }
        public void ShowStatistics()
        {
            bool val_1 = this.GotoState<GameUI.Statistics>(stateData:  0);
        }
        public void ShowAdRewardWindow()
        {
            if(this.adsRewardWindow.AdsAvailable == false)
            {
                    return;
            }
            
            bool val_2 = this.GotoState<GameUI.AdReward>(stateData:  0);
        }
        public void ShowLowerStageUI()
        {
            if(TzarGames.Endless.EndlessGameState.Instance.CanGoToLowerStage() == false)
            {
                    return;
            }
            
            bool val_3 = this.GotoState<GameUI.LowerStageSelectMenu>(stateData:  0);
        }
        public void HideStageSelectionPanels()
        {
            bool val_1 = this.GotoState<GameUI.Gameplay>(stateData:  0);
        }
        public void ShowUpperStageUI()
        {
            bool val_1 = this.GotoState<GameUI.UpperStageSelectMenu>(stateData:  0);
        }
        public void DisableAndFadeIn(System.Action onCompleteCallback)
        {
            bool val_1 = this.GotoState<GameUI.Empty>(stateData:  0);
            this.showFadingBackground(show:  true, full:  true, onCompleteCallback:  onCompleteCallback);
        }
        public void DisableAndFadeInHalf(System.Action onCompleteCallback)
        {
            bool val_1 = this.GotoState<GameUI.Empty>(stateData:  0);
            this.showFadingBackground(show:  true, full:  false, onCompleteCallback:  onCompleteCallback);
        }
        public void FadeIn(System.Action onCompleteCallback)
        {
            this.showFadingBackground(show:  true, full:  true, onCompleteCallback:  onCompleteCallback);
        }
        public void FadeOut(System.Action onCompleteCallback)
        {
            this.fadeBackground.FadeOut(completeCallback:  onCompleteCallback);
        }
        public void Disable()
        {
            bool val_1 = this.GotoState<GameUI.Empty>(stateData:  0);
        }
        private void showFadingBackground(bool show, bool full = False, System.Action onCompleteCallback)
        {
            if(show == false)
            {
                goto label_1;
            }
            
            if(this.fadeBackground.enabled != true)
            {
                    this.fadeBackground.enabled = true;
            }
            
            if(full == false)
            {
                goto label_5;
            }
            
            this.fadeBackground.FadeInFull(completeCallback:  onCompleteCallback);
            return;
            label_1:
            this.fadeBackground.FadeOut(completeCallback:  onCompleteCallback);
            return;
            label_5:
            this.fadeBackground.FadeInHalf(completeCallback:  onCompleteCallback);
        }
        public void ShowForeignMenu(TzarGames.GameFramework.UI.GameUIBase menu)
        {
            bool val_1 = menu.GotoState<GameUI.ForeignMenu>(stateData:  menu);
        }
        private void showMenu(TzarGames.GameFramework.UI.GameUIBase menu, bool show)
        {
            var val_12;
            UnityEngine.Object val_13;
            bool val_14;
            var val_15;
            var val_16;
            val_12 = menu;
            val_13 = val_12.GetComponent<TzarGames.Common.UI.UIBase>();
            if(0 != val_13)
            {
                    val_14 = show;
            }
            else
            {
                    val_15 = val_12.gameObject;
                val_14 = show;
                val_15.SetActive(value:  val_14);
            }
            
            if(show == false)
            {
                    return;
            }
            
            val_12 = ???;
            val_16 = ???;
            goto typeof(TzarGames.GameFramework.UI.GameUIBase).__il2cppRuntimeField_170;
        }
        public void ExitToLobby()
        {
            var val_6;
            bool val_1 = this.GotoState<GameUI.Empty>(stateData:  0);
            this.showFadingBackground(show:  true, full:  true, onCompleteCallback:  0);
            val_6 = 0;
            if(TzarGames.GameFramework.GameManager.Instance != null)
            {
                    val_6 = 0;
            }
            
            if(0 != )
            {
                    ExitToLobby();
                return;
            }
            
            UnityEngine.Debug.LogError(message:  0);
            TzarGames.Endless.EndlessGameState.Instance.ExitToMainMenu();
        }
        public void ShowCutsceneWindow(bool show)
        {
            if(show != false)
            {
                    bool val_1 = this.GotoState<GameUI.Cutscene>(stateData:  0);
                return;
            }
            
            if(this.CurrentState == null)
            {
                    return;
            }
        
        }
        protected override void OnPlayerOwnerSet(TzarGames.GameFramework.Player owner)
        {
            var val_3;
            var val_17;
            var val_18;
            TzarGames.Endless.UI.ForgeUI val_19;
            this.OnPlayerOwnerSet(owner:  owner);
            List.Enumerator<T> val_1 = this.allMenus.GetEnumerator();
            label_7:
            if((0 & 1) == 0)
            {
                goto label_2;
            }
            
            System.Action<GooglePlayGames.BasicApi.Nearby.InitializationStatus> val_4 = val_3.InitializationCallback;
            if(0 == val_4)
            {
                goto label_7;
            }
            
            val_4.SetPlayerOwner(player:  owner);
            goto label_7;
            label_2:
            val_17 = 0;
            val_18 = 1;
            val_3.Dispose();
            bool val_6 = this.GotoState<GameUI.Gameplay>(stateData:  0);
            this.hud.Character.add_OnCharacterDead(value:  new TH_Character.dlgDeadEvent(object:  this, method:  System.Void TzarGames.Endless.UI.GameUI::onPlayerCharacterDead(TzarGames.TzarHero.DeadEventData deadInfo)));
            this.hud.Character.add_OnCharacterAlive(value:  new TH_Character.dlgCharacterEvent(object:  this, method:  System.Void TzarGames.Endless.UI.GameUI::onPlayerCharacterAlive(TzarGames.TzarHero.TH_Character character)));
            this.hud.Character.add_OnCharacterLevelUp(value:  new TH_Character.dlgCharacterEvent(object:  this, method:  System.Void TzarGames.Endless.UI.GameUI::CharacterOnOnCharacterLevelUp(TzarGames.TzarHero.TH_Character character)));
            if(0 != TzarGames.Endless.EndlessGameState.Instance)
            {
                    if(TzarGames.Endless.EndlessGameState.Instance.IsInLobby() != false)
            {
                    this.itemShop.InitializeItems();
                this.inventory.RefreshItems();
                val_19 = this.forge;
                val_19.RefreshItems();
                return;
            }
            
            }
            
            val_19 = this.itemShop;
            val_19.UnloadResources();
        }
        private void CharacterOnOnCharacterLevelUp(TzarGames.TzarHero.TH_Character character)
        {
            this.alert.Show(message:  TzarGames.Common.LocalizedStringAsset.op_Implicit(text:  0));
        }
        private void OnDestroy()
        {
            dlgCharacterEvent val_13;
            System.Action val_1 = new System.Action(object:  this, method:  System.Void TzarGames.Endless.UI.GameUI::EndlessGameStateOnOnNeedPurchaseFullGame());
            TzarGames.Endless.EndlessGameState.remove_OnNeedPurchaseFullGame(value:  0);
            System.Action val_2 = new System.Action(object:  this, method:  System.Void TzarGames.Endless.UI.GameUI::gameState_onLoadingStarted());
            TzarGames.Endless.EndlessGameState.remove_OnLoadingStarted(value:  0);
            System.Action val_3 = new System.Action(object:  this, method:  System.Void TzarGames.Endless.UI.GameUI::EndlessGameStateOnOnGameContinued());
            TzarGames.Endless.EndlessGameState.remove_OnGameContinued(value:  0);
            val_13 = 1152921504721543168;
            if(0 != this.hud)
            {
                    if(0 != this.hud.Character)
            {
                    this.hud.Character.remove_OnCharacterDead(value:  new TH_Character.dlgDeadEvent(object:  this, method:  System.Void TzarGames.Endless.UI.GameUI::onPlayerCharacterDead(TzarGames.TzarHero.DeadEventData deadInfo)));
                this.hud.Character.remove_OnCharacterAlive(value:  new TH_Character.dlgCharacterEvent(object:  this, method:  System.Void TzarGames.Endless.UI.GameUI::onPlayerCharacterAlive(TzarGames.TzarHero.TH_Character character)));
                TH_Character.dlgCharacterEvent val_12 = null;
                val_13 = val_12;
                val_12 = new TH_Character.dlgCharacterEvent(object:  this, method:  System.Void TzarGames.Endless.UI.GameUI::CharacterOnOnCharacterLevelUp(TzarGames.TzarHero.TH_Character character));
                this.hud.Character.remove_OnCharacterLevelUp(value:  val_13);
            }
            
            }
            
            this.itemShop.UnloadResources();
        }
        private void gameState_onLoadingStarted()
        {
            this.ShowLoading();
        }
        private void onPlayerCharacterDead(TzarGames.TzarHero.DeadEventData deadInfo)
        {
            bool val_1 = this.GotoState<GameUI.Death>(stateData:  0);
        }
        private void onPlayerCharacterAlive(TzarGames.TzarHero.TH_Character character)
        {
            bool val_1 = this.GotoState<GameUI.Gameplay>(stateData:  0);
        }
    
    }

}
