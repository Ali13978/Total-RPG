using UnityEngine;
private class GoldShopUI.ConfirmationDialog : GoldShopUI.ShopStateBase
{
    // Methods
    public GoldShopUI.ConfirmationDialog()
    {
    
    }
    public override void OnStateBegin(StateMachine.State prevState)
    {
        prevState.OnStateBegin(prevState:  prevState);
        TzarGames.Endless.UI.GoldShopUI val_1 = this.Shop;
        if(val_1.dialogWindow == null)
        {
            
        }
    
    }
    public override void OnStateEnd(StateMachine.State nextState)
    {
        nextState.OnStateBegin(prevState:  nextState);
        TzarGames.Endless.UI.GoldShopUI val_1 = this.Shop;
        if(val_1.dialogWindow == null)
        {
            
        }
    
    }

}
