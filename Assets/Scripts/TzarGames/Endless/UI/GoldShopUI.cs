using UnityEngine;

namespace TzarGames.Endless.UI
{
    public class GoldShopUI : GameUIBase
    {
        // Fields
        [UnityEngine.SerializeField]
        private TzarGames.Common.UI.TextUI goldCountText;
        [UnityEngine.SerializeField]
        private string goldCountFormat;
        [UnityEngine.SerializeField]
        private TzarGames.Common.UI.TextUI rubyCountText;
        [UnityEngine.SerializeField]
        private string rubyCountFormat;
        [UnityEngine.SerializeField]
        private TzarGames.Common.UI.UIBase puchaseWindow;
        [UnityEngine.SerializeField]
        private TzarGames.Common.UI.UIBase dialogWindow;
        [UnityEngine.SerializeField]
        private TzarGames.Common.UI.UIBase successWindow;
        [UnityEngine.SerializeField]
        private TzarGames.Common.UI.UIBase failWindow;
        [UnityEngine.SerializeField]
        private TzarGames.Common.UI.TextUI failureReasonText;
        [UnityEngine.SerializeField]
        private float successShowTime;
        private float minWaitTime;
        private float lastWaitStartTime;
        private TzarGames.Endless.GoldPackTypes packType;
        
        // Methods
        public GoldShopUI()
        {
            this.goldCountFormat = "{0}";
            this.successShowTime = 0f;
            this.minWaitTime = 1f;
            this.rubyCountFormat = "{0}";
        }
        public override void NotifyShown()
        {
            this.NotifyShown();
            this.updateGoldCount();
            this.ResetToDefaultState();
        }
        private void updateGoldCount()
        {
            string val_11;
            string val_12;
            var val_13;
            val_11 = this;
            if(this.PlayerOwner == null)
            {
                    return;
            }
            
            TzarGames.GameFramework.Player val_2 = this.PlayerOwner;
            ulong val_3 = 0.Gold;
            val_12 = System.String.Format(format:  0, arg0:  this.goldCountFormat);
            this.goldCountText.text = val_12;
            if(0 == TzarGames.Endless.EndlessGameState.Instance)
            {
                    return;
            }
            
            TzarGames.Endless.ICharacterInfo val_8 = TzarGames.Endless.EndlessGameState.Instance.SelectedCharacter;
            var val_11 = 0;
            val_11 = val_11 + 1;
            val_13 = val_8;
            val_12 = val_8;
            val_11 = System.String.Format(format:  0, arg0:  this.rubyCountFormat);
            this.rubyCountText.text = val_11;
        }
        public void ShowPurchaseWindow()
        {
            bool val_1 = this.GotoState<GoldShopUI.Purchase>(stateData:  0);
        }
        [System.Diagnostics.DebuggerHiddenAttribute]
        private System.Collections.IEnumerator showResult(bool result)
        {
            if(null != 0)
            {
                    typeof(GoldShopUI.<showResult>c__Iterator0).__il2cppRuntimeField_10 = result;
            }
            else
            {
                    mem[16] = result;
            }
            
            typeof(GoldShopUI.<showResult>c__Iterator0).__il2cppRuntimeField_18 = this;
            return (System.Collections.IEnumerator)new System.Object();
        }
        [System.Diagnostics.DebuggerHiddenAttribute]
        private System.Collections.IEnumerator showSuccessAndReturn()
        {
            typeof(GoldShopUI.<showSuccessAndReturn>c__Iterator1).__il2cppRuntimeField_10 = this;
            return (System.Collections.IEnumerator)new System.Object();
        }
        public void OnCancelBuyPress()
        {
            bool val_1 = this.GotoState<GoldShopUI.Purchase>(stateData:  0);
        }
        public void OnConfirmBuyPress()
        {
            System.Action<System.Boolean> val_3 = new System.Action<System.Boolean>(object:  this, method:  System.Void TzarGames.Endless.UI.GoldShopUI::<OnConfirmBuyPress>m__0(bool result));
            TzarGames.Endless.GoldExchange.BuyGoldPack(packType:  0, playerTemplateInstance:  this.packType, resultCallback:  TzarGames.Endless.EndlessGameManager.LocalPlayerCharacter.PlayerTemplateInstance);
        }
        public void OnBuyRubyClick()
        {
            bool val_1 = this.GotoState<GoldShopUI.Purchase>(stateData:  0);
        }
        public void OnBuySmallPackPress()
        {
            bool val_1 = this.GotoState<GoldShopUI.ConfirmationDialog>(stateData:  0);
            this.packType = 0;
        }
        public void OnBuyMediumPackPress()
        {
            bool val_1 = this.GotoState<GoldShopUI.ConfirmationDialog>(stateData:  0);
            this.packType = 1;
        }
        public void OnBuyBigPackPress()
        {
            bool val_1 = this.GotoState<GoldShopUI.ConfirmationDialog>(stateData:  0);
            this.packType = 2;
        }
        private void <OnConfirmBuyPress>m__0(bool result)
        {
            UnityEngine.Coroutine val_3 = this.StartCoroutine(routine:  this.showResult(result:  result));
        }
    
    }

}
