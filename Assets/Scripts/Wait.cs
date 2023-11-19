using UnityEngine;
private class RubyShopUI.Wait : RubyShopUI.ShopStateBase
{
    // Methods
    public RubyShopUI.Wait()
    {
    
    }
    public override void OnStateBegin(StateMachine.State prevState)
    {
        prevState.OnStateBegin(prevState:  prevState);
        TzarGames.Endless.UI.RubyShopUI val_1 = this.Shop;
        TzarGames.Endless.UI.RubyShopUI val_2 = this.Shop;
        val_2.lastWaitStartTime = UnityEngine.Time.time;
        TzarGames.Endless.UI.RubyShopUI val_4 = this.Shop;
        val_4.cancelWaitButton.SetActive(value:  false);
        this.Shop.StopCoroutine(routine:  this.cancelWaitButtonActivation());
        UnityEngine.Coroutine val_9 = this.Shop.StartCoroutine(routine:  this.cancelWaitButtonActivation());
    }
    public override void OnStateEnd(StateMachine.State nextState)
    {
        nextState.OnStateBegin(prevState:  nextState);
        TzarGames.Endless.UI.RubyShopUI val_1 = this.Shop;
        this.Shop.StopCoroutine(routine:  this.cancelWaitButtonActivation());
    }
    [System.Diagnostics.DebuggerHiddenAttribute]
    private System.Collections.IEnumerator cancelWaitButtonActivation()
    {
        typeof(RubyShopUI.Wait.<cancelWaitButtonActivation>c__Iterator0).__il2cppRuntimeField_10 = this;
        return (System.Collections.IEnumerator)new System.Object();
    }

}
