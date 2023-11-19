using UnityEngine;

namespace TzarGames.Endless.UI
{
    public class RubyShopUI : GameUIBase
    {
        // Fields
        [UnityEngine.SerializeField]
        private TzarGames.Common.UI.TextUI rubyCountText;
        [UnityEngine.SerializeField]
        private TzarGames.Common.LocalizedStringAsset rubyCountFormat;
        [UnityEngine.SerializeField]
        private TzarGames.Common.LocalizedStringAsset veryBigPackText;
        [UnityEngine.SerializeField]
        private TzarGames.Common.LocalizedStringAsset smallPackText;
        [UnityEngine.SerializeField]
        private TzarGames.Common.LocalizedStringAsset mediumPackText;
        [UnityEngine.SerializeField]
        private TzarGames.Common.LocalizedStringAsset bigPackText;
        [UnityEngine.SerializeField]
        private TzarGames.Common.LocalizedStringAsset status_DuplicateTransaction;
        [UnityEngine.SerializeField]
        private TzarGames.Common.LocalizedStringAsset status_ExistingPurchasePending;
        [UnityEngine.SerializeField]
        private TzarGames.Common.LocalizedStringAsset status_PaymentDeclined;
        [UnityEngine.SerializeField]
        private TzarGames.Common.LocalizedStringAsset status_ProductUnavailable;
        [UnityEngine.SerializeField]
        private TzarGames.Common.LocalizedStringAsset status_PurchasingUnavailable;
        [UnityEngine.SerializeField]
        private TzarGames.Common.LocalizedStringAsset status_SignatureInvalid;
        [UnityEngine.SerializeField]
        private TzarGames.Common.LocalizedStringAsset status_UserCancelled;
        [UnityEngine.SerializeField]
        private TzarGames.Common.LocalizedStringAsset status_Unknown;
        [UnityEngine.SerializeField]
        private TzarGames.Common.UI.TextUI smallPackTextField;
        [UnityEngine.SerializeField]
        private TzarGames.Common.UI.TextUI mediumPackTextField;
        [UnityEngine.SerializeField]
        private TzarGames.Common.UI.TextUI bigPackTextField;
        [UnityEngine.SerializeField]
        private TzarGames.Common.UI.TextUI veryBigPackTextField;
        [UnityEngine.SerializeField]
        private TzarGames.Common.UI.UIBase puchaseWindow;
        [UnityEngine.SerializeField]
        private TzarGames.Common.UI.UIBase waitWindow;
        [UnityEngine.SerializeField]
        private UnityEngine.GameObject cancelWaitButton;
        [UnityEngine.SerializeField]
        private float cancelWaitTime;
        [UnityEngine.SerializeField]
        private TzarGames.Common.UI.UIBase successWindow;
        [UnityEngine.SerializeField]
        private TzarGames.Common.UI.UIBase failWindow;
        [UnityEngine.SerializeField]
        private TzarGames.Common.UI.TextUI failureReasonText;
        [UnityEngine.SerializeField]
        private float successShowTime;
        [UnityEngine.SerializeField]
        private UnityEngine.Events.UnityEvent onPurchaseSuccess;
        [UnityEngine.SerializeField]
        private TzarGames.Common.Events.StringEvent onPurchaseFailed;
        private float minWaitTime;
        private float lastWaitStartTime;
        
        // Methods
        public RubyShopUI()
        {
            this.cancelWaitTime = 15f;
            this.successShowTime = 3f;
            this.minWaitTime = 1f;
        }
        public override void NotifyShown()
        {
            this.NotifyShown();
            this.updateRubyCount();
            this.ResetToDefaultState();
        }
        private void updateRubyCount()
        {
            UnityEngine.Object val_8;
            var val_9;
            val_8 = TzarGames.Endless.EndlessGameState.Instance;
            if(0 == val_8)
            {
                    return;
            }
            
            val_8 = this.rubyCountText;
            var val_8 = 0;
            val_8 = val_8 + 1;
            val_9 = TzarGames.Endless.EndlessGameState.Instance.SelectedCharacter;
            val_8.text = System.String.Format(format:  0, arg0:  TzarGames.Common.LocalizedStringAsset.op_Implicit(text:  0));
        }
        public void ShowPurchaseWindow()
        {
            bool val_1 = this.GotoState<RubyShopUI.Purchase>(stateData:  0);
        }
        private void setFailureReasonText(TzarGames.Common.PurchaseFailureReason reason)
        {
            string val_1 = TzarGames.Common.LocalizedStringAsset.op_Implicit(text:  0);
            if(((reason < 8) ? (reason + 3) : 0) > 10)
            {
                    return;
            }
            
            var val_11 = 25486308 + (reason < 0x8 ? (reason + 3) : 0) << 2;
            val_11 = val_11 + 25486308;
            goto (25486308 + (reason < 0x8 ? (reason + 3) : 0) << 2 + 25486308);
        }
        [System.Diagnostics.DebuggerHiddenAttribute]
        private System.Collections.IEnumerator showResult(TzarGames.Common.IPurchaseResult result)
        {
            if(null != 0)
            {
                    typeof(RubyShopUI.<showResult>c__Iterator0).__il2cppRuntimeField_10 = result;
            }
            else
            {
                    mem[16] = result;
            }
            
            typeof(RubyShopUI.<showResult>c__Iterator0).__il2cppRuntimeField_18 = this;
            return (System.Collections.IEnumerator)new System.Object();
        }
        [System.Diagnostics.DebuggerHiddenAttribute]
        private System.Collections.IEnumerator showSuccessAndReturn()
        {
            typeof(RubyShopUI.<showSuccessAndReturn>c__Iterator1).__il2cppRuntimeField_10 = this;
            return (System.Collections.IEnumerator)new System.Object();
        }
        public void OnCancelPress()
        {
        
        }
        public void OnCancelWaitPress()
        {
            this.ShowPurchaseWindow();
        }
        public void OnBuyVeryBigPackPress()
        {
            bool val_1 = this.GotoState<RubyShopUI.Wait>(stateData:  0);
            System.Action<TzarGames.Common.IPurchaseResult> val_2 = new System.Action<TzarGames.Common.IPurchaseResult>(object:  this, method:  System.Void TzarGames.Endless.UI.RubyShopUI::<OnBuyVeryBigPackPress>m__0(TzarGames.Common.IPurchaseResult x));
            TzarGames.Endless.EndlessInAppManager.BuyVeryBigRubyPack(resultCallback:  0);
        }
        public void OnBuySmallPackPress()
        {
            bool val_1 = this.GotoState<RubyShopUI.Wait>(stateData:  0);
            System.Action<TzarGames.Common.IPurchaseResult> val_2 = new System.Action<TzarGames.Common.IPurchaseResult>(object:  this, method:  System.Void TzarGames.Endless.UI.RubyShopUI::<OnBuySmallPackPress>m__1(TzarGames.Common.IPurchaseResult x));
            TzarGames.Endless.EndlessInAppManager.BuySmallRubyPack(resultCallback:  0);
        }
        public void OnBuyMediumPackPress()
        {
            bool val_1 = this.GotoState<RubyShopUI.Wait>(stateData:  0);
            System.Action<TzarGames.Common.IPurchaseResult> val_2 = new System.Action<TzarGames.Common.IPurchaseResult>(object:  this, method:  System.Void TzarGames.Endless.UI.RubyShopUI::<OnBuyMediumPackPress>m__2(TzarGames.Common.IPurchaseResult x));
            TzarGames.Endless.EndlessInAppManager.BuyMediumRubyPack(resultCallback:  0);
        }
        public void OnBuyBigPackPress()
        {
            bool val_1 = this.GotoState<RubyShopUI.Wait>(stateData:  0);
            System.Action<TzarGames.Common.IPurchaseResult> val_2 = new System.Action<TzarGames.Common.IPurchaseResult>(object:  this, method:  System.Void TzarGames.Endless.UI.RubyShopUI::<OnBuyBigPackPress>m__3(TzarGames.Common.IPurchaseResult x));
            TzarGames.Endless.EndlessInAppManager.BuyBigRubyPack(resultCallback:  0);
        }
        private void <OnBuyVeryBigPackPress>m__0(TzarGames.Common.IPurchaseResult x)
        {
            UnityEngine.Coroutine val_2 = this.StartCoroutine(routine:  this.showResult(result:  x));
        }
        private void <OnBuySmallPackPress>m__1(TzarGames.Common.IPurchaseResult x)
        {
            UnityEngine.Coroutine val_2 = this.StartCoroutine(routine:  this.showResult(result:  x));
        }
        private void <OnBuyMediumPackPress>m__2(TzarGames.Common.IPurchaseResult x)
        {
            UnityEngine.Coroutine val_2 = this.StartCoroutine(routine:  this.showResult(result:  x));
        }
        private void <OnBuyBigPackPress>m__3(TzarGames.Common.IPurchaseResult x)
        {
            UnityEngine.Coroutine val_2 = this.StartCoroutine(routine:  this.showResult(result:  x));
        }
    
    }

}
