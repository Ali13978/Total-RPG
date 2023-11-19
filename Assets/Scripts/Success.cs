using UnityEngine;
private class RubyShopUI.Success : RubyShopUI.ShopStateBase
{
    // Methods
    public RubyShopUI.Success()
    {
    
    }
    public override void OnStateBegin(StateMachine.State prevState)
    {
        prevState.OnStateBegin(prevState:  prevState);
        TzarGames.Endless.UI.RubyShopUI val_1 = this.Shop;
        if(val_1.successWindow == null)
        {
            
        }
    
    }
    public override void OnStateEnd(StateMachine.State nextState)
    {
        nextState.OnStateBegin(prevState:  nextState);
        TzarGames.Endless.UI.RubyShopUI val_1 = this.Shop;
        TzarGames.Endless.UI.RubyShopUI val_2 = this.Shop;
        val_2.onPurchaseSuccess.Invoke();
    }

}
