using UnityEngine;

namespace TzarGames.Endless.UI
{
    public class PlayerCharacterUI : UICharacterHUD
    {
        // Fields
        [UnityEngine.HeaderAttribute]
        [UnityEngine.SerializeField]
        private TzarGames.Common.UI.TextUI goldText;
        [UnityEngine.SerializeField]
        private TzarGames.Common.UI.TextUI rubyText;
        [UnityEngine.SerializeField]
        private UnityEngine.GameObject chatWindow;
        [UnityEngine.SerializeField]
        private UnityEngine.GameObject skillWindow;
        [UnityEngine.SerializeField]
        private TzarGames.Endless.UI.InteractionUI interaction;
        [UnityEngine.SerializeField]
        private TzarGames.Common.UI.TextUI allyName;
        [UnityEngine.SerializeField]
        private UnityEngine.UI.Slider allyHealthBar;
        private ulong lastCharacterGold;
        private ulong lastCharacterRuby;
        [UnityEngine.SerializeField]
        private UnityEngine.GameObject statsButton;
        [UnityEngine.SerializeField]
        private UnityEngine.GameObject adsButton;
        [UnityEngine.SerializeField]
        private TzarGames.Endless.AdsRewardUI rewardWindow;
        private TzarGames.Endless.EndlessGameState gameState;
        [UnityEngine.HeaderAttribute]
        [UnityEngine.SerializeField]
        private TzarGames.Endless.UI.NotificationUI notification;
        [UnityEngine.SerializeField]
        private float itemTakeNotificationTime;
        [UnityEngine.SerializeField]
        private TzarGames.Common.UI.TextUI questInfoText;
        [UnityEngine.SerializeField]
        private TzarGames.Common.LocalizedStringAsset itemTakeNotificationMessage;
        [UnityEngine.SerializeField]
        private TzarGames.Endless.NewItemNotificator itemNotificator;
        [UnityEngine.SerializeField]
        private UnityEngine.Events.UnityEvent onShown;
        
        // Properties
        public TzarGames.Common.UI.TextUI QuestInfoText { get; }
        public TzarGames.Endless.PlayerCharacter PlayerCharacter { get; }
        
        // Methods
        public PlayerCharacterUI()
        {
            this.lastCharacterGold = 0;
            this.lastCharacterRuby = 0;
            this.itemTakeNotificationTime = 5f;
        }
        public TzarGames.Common.UI.TextUI get_QuestInfoText()
        {
            return (TzarGames.Common.UI.TextUI)this.questInfoText;
        }
        protected override void Update()
        {
            var val_4;
            this.Update();
            if(0 == this.gameState)
            {
                    return;
            }
            
            if(this.gameState.IsInLobby() != false)
            {
                    val_4 = this.rewardWindow.AdsAvailable;
            }
            else
            {
                    val_4 = 0;
            }
            
            this.adsButton.SetActive(value:  false);
        }
        public override void NotifyShown()
        {
            UnityEngine.GameObject val_14;
            TzarGames.GameFramework.Player val_15;
            this.NotifyShown();
            TzarGames.Endless.EndlessGameState val_1 = TzarGames.Endless.EndlessGameState.Instance;
            if(0 != val_1)
            {
                    bool val_3 = val_1.IsInLobby();
                this.chatWindow.SetActive(value:  val_3);
                this.skillWindow.SetActive(value:  (~val_3) & 1);
                val_14 = this.statsButton;
                val_14.SetActive(value:  val_3);
            }
            
            T[] val_7 = this.GetComponentsInChildren<TzarGames.GameFramework.UI.GameUIBase>();
            if((val_7 != null) && (val_7.Length >= 1))
            {
                    do
            {
                val_14 = val_7[0];
                if(0 != val_14)
            {
                    val_15 = 0;
                if(val_14.PlayerOwner == null)
            {
                    val_15 = this.PlayerOwner;
                val_14.SetPlayerOwner(player:  val_15);
            }
            
            }
            
            }
            while((0 + 1) < val_7.Length);
            
            }
            
            UnityEngine.Coroutine val_14 = this.StartCoroutine(routine:  this.checkForNewItems());
            this.onShown.Invoke();
        }
        protected override void OnPlayerOwnerSet(TzarGames.GameFramework.Player player)
        {
            var val_1;
            this.OnPlayerOwnerSet(player:  player);
            val_1 = null;
            val_1 = null;
            this.questInfoText.text = System.String.Empty;
            this.interaction.SetPlayerOwner(player:  player);
        }
        [System.Diagnostics.DebuggerHiddenAttribute]
        private System.Collections.IEnumerator checkForNewItems()
        {
            typeof(PlayerCharacterUI.<checkForNewItems>c__Iterator0).__il2cppRuntimeField_10 = this;
            return (System.Collections.IEnumerator)new System.Object();
        }
        private void OnDestroy()
        {
            var val_6;
            var val_7;
            if(this.PlayerOwner == null)
            {
                    return;
            }
            
            val_6 = this.PlayerOwner;
            if(val_2.PlayerComponent == null)
            {
                    return;
            }
            
            TzarGames.GameFramework.Player val_3 = this.PlayerOwner;
            if(val_3.PlayerComponent != null)
            {
                    val_7 = null;
                val_7 = null;
                var val_5 = (((TzarGames.GameFramework.IPlayerComponent.__il2cppRuntimeField_typeHierarchy + (TzarGames.TzarHero.TH_Character.__il2cppRuntimeField_typeHierarchyDepth) << 3) + -8) == val_7) ? val_3.PlayerComponent : 0;
            }
            
            0.remove_OnCharacterLevelUp(value:  new TH_Character.dlgCharacterEvent(object:  this, method:  System.Void TzarGames.Endless.UI.PlayerCharacterUI::Handle_OnCharacterLevelUp(TzarGames.TzarHero.TH_Character character)));
        }
        private void CharacterOnOnItemAddedToInventory(TzarGames.GameFramework.ITakeItemEvent eventData)
        {
            var val_5;
            var val_5 = 0;
            val_5 = val_5 + 1;
            val_5 = eventData;
            TzarGames.GameFramework.Item val_3 = eventData.GetOriginalTemplate();
            this.notification.AddTempNotificationWithIcon(message:  System.String.Format(format:  0, arg0:  TzarGames.Common.LocalizedStringAsset.op_Implicit(text:  0)), icon:  0, time:  this.itemTakeNotificationTime);
        }
        private void Handle_OnCharacterLevelUp(TzarGames.TzarHero.TH_Character character)
        {
            UnityEngine.Coroutine val_2 = this.StartCoroutine(routine:  this.checkForNewItems());
        }
        public TzarGames.Endless.PlayerCharacter get_PlayerCharacter()
        {
            if(this.Character == null)
            {
                    return (TzarGames.Endless.PlayerCharacter);
            }
            
            0 = 0;
            return (TzarGames.Endless.PlayerCharacter);
        }
        protected override void updateCharacterStats()
        {
            string val_26;
            var val_27;
            var val_28;
            var val_29;
            var val_30;
            UnityEngine.Object val_31;
            var val_32;
            float val_33;
            var val_34;
            val_26 = this;
            this.updateCharacterStats();
            ulong val_2 = this.PlayerCharacter.Gold;
            if(this.lastCharacterGold != val_2)
            {
                    this.lastCharacterGold = val_2;
                this.goldText.text = val_2;
            }
            
            System.Collections.Generic.IEnumerable<TzarGames.TzarHero.TH_Character> val_4 = this.PlayerCharacter.Allies;
            var val_26 = 0;
            val_26 = val_26 + 1;
            val_27 = val_4;
            var val_27 = 0;
            val_27 = val_27 + 1;
            val_28 = val_4;
            if(((val_4 & 1) & 1) == 0)
            {
                goto label_15;
            }
            
            var val_28 = 0;
            val_28 = val_28 + 1;
            val_29 = val_4;
            goto label_20;
            label_15:
            val_30 = 0;
            val_31 = 0;
            goto label_21;
            label_20:
            val_31 = val_4;
            val_30 = 0;
            label_21:
            if(val_4 != null)
            {
                    var val_29 = 0;
                val_29 = val_29 + 1;
                val_32 = val_4;
            }
            
            UnityEngine.GameObject val_11 = this.allyName.gameObject;
            if(0 == val_31)
            {
                goto label_33;
            }
            
            val_11.SetActive(value:  true);
            this.allyHealthBar.gameObject.SetActive(value:  true);
            TzarGames.TzarHero.TH_CharacterTemplate val_13 = val_31.TemplateInstance;
            if(val_13 == null)
            {
                goto label_37;
            }
            
            val_33 = val_13.ActualHitPoints;
            val_31 = val_13;
            goto label_38;
            label_33:
            val_11.SetActive(value:  false);
            this.allyHealthBar.gameObject.SetActive(value:  false);
            goto label_41;
            label_37:
            val_33 = 0.ActualHitPoints;
            val_31 = 0;
            label_38:
            float val_17 = val_31.HitPoints;
            val_33 = val_33 / val_17;
            float val_30 = System.Math.Abs(val_17 - val_33);
            this.allyName.text = TzarGames.Common.LocalizedStringAsset.op_Implicit(text:  0);
            label_41:
            if(0 == this.gameState)
            {
                    TzarGames.Endless.EndlessGameState val_21 = TzarGames.Endless.EndlessGameState.Instance;
                this.gameState = val_21;
                if(0 == val_21)
            {
                    return;
            }
            
            }
            
            TzarGames.Endless.ICharacterInfo val_24 = this.gameState.SelectedCharacter;
            var val_31 = 0;
            val_31 = val_31 + 1;
            val_34 = val_24;
            if(val_24 == this.lastCharacterRuby)
            {
                    return;
            }
            
            this.lastCharacterRuby = val_24;
            val_26 = ;
            this.rubyText.text = val_24;
        }
    
    }

}
