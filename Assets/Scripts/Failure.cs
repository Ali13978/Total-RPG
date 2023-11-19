using UnityEngine;
private class RubyShopUI.Failure : RubyShopUI.ShopStateBase
{
    // Methods
    public RubyShopUI.Failure()
    {
    
    }
    public override void OnStateBegin(StateMachine.State prevState)
    {
        prevState.OnStateBegin(prevState:  prevState);
        TzarGames.Endless.UI.RubyShopUI val_1 = this.Shop;
        if(val_1.failWindow == null)
        {
            
        }
    
    }
    public override void OnStateEnd(StateMachine.State nextState)
    {
        nextState.OnStateBegin(prevState:  nextState);
        TzarGames.Endless.UI.RubyShopUI val_1 = this.Shop;
        if(val_1.failWindow == null)
        {
            
        }
    
    }

}
