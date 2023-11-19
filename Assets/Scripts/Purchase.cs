using UnityEngine;
[DefaultState]
private class RubyShopUI.Purchase : RubyShopUI.ShopStateBase
{
    // Methods
    public RubyShopUI.Purchase()
    {
    
    }
    public override void OnStateBegin(StateMachine.State prevState)
    {
        prevState.OnStateBegin(prevState:  prevState);
        TzarGames.Endless.UI.RubyShopUI val_1 = this.Shop;
        TzarGames.Endless.UI.RubyShopUI val_2 = this.Shop;
        TzarGames.Endless.UI.RubyShopUI val_3 = this.Shop;
        TzarGames.Endless.UI.RubyShopUI val_4 = this.Shop;
        this.Shop.updateRubyCount();
        string val_6 = TzarGames.Endless.EndlessInAppManager.GetLocalizedPriceForSmallPack();
        TzarGames.Endless.UI.RubyShopUI val_7 = this.Shop;
        TzarGames.Endless.UI.RubyShopUI val_8 = this.Shop;
        var val_10 = (val_6 == null) ? "???" : (val_6);
        val_7.smallPackTextField.text = System.String.Format(format:  0, arg0:  TzarGames.Common.LocalizedStringAsset.op_Implicit(text:  0));
        string val_12 = TzarGames.Endless.EndlessInAppManager.GetLocalizedPriceForVeryBigPack();
        TzarGames.Endless.UI.RubyShopUI val_13 = this.Shop;
        TzarGames.Endless.UI.RubyShopUI val_14 = this.Shop;
        var val_16 = (val_12 == null) ? "???" : (val_12);
        val_13.veryBigPackTextField.text = System.String.Format(format:  0, arg0:  TzarGames.Common.LocalizedStringAsset.op_Implicit(text:  0));
        string val_18 = TzarGames.Endless.EndlessInAppManager.GetLocalizedPriceForMediumPack();
        TzarGames.Endless.UI.RubyShopUI val_19 = this.Shop;
        TzarGames.Endless.UI.RubyShopUI val_20 = this.Shop;
        var val_22 = (val_18 == null) ? "???" : (val_18);
        val_19.mediumPackTextField.text = System.String.Format(format:  0, arg0:  TzarGames.Common.LocalizedStringAsset.op_Implicit(text:  0));
        string val_24 = TzarGames.Endless.EndlessInAppManager.GetLocalizedPriceForBigPack();
        TzarGames.Endless.UI.RubyShopUI val_25 = this.Shop;
        TzarGames.Endless.UI.RubyShopUI val_26 = this.Shop;
        var val_28 = (val_24 == null) ? "???" : (val_24);
        val_25.bigPackTextField.text = System.String.Format(format:  0, arg0:  TzarGames.Common.LocalizedStringAsset.op_Implicit(text:  0));
    }
    public override void OnStateEnd(StateMachine.State nextState)
    {
        nextState.OnStateBegin(prevState:  nextState);
        TzarGames.Endless.UI.RubyShopUI val_1 = this.Shop;
        if(val_1.puchaseWindow == null)
        {
            
        }
    
    }

}
