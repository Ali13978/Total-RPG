using UnityEngine;
private sealed class EndlessInAppManager.<BuyFullGame>c__AnonStorey2
{
    // Fields
    internal System.Action<TzarGames.Common.IPurchaseResult> resultCallback;
    
    // Methods
    public EndlessInAppManager.<BuyFullGame>c__AnonStorey2()
    {
    
    }
    internal void <>m__0(TzarGames.Common.IPurchaseResult x)
    {
        var val_3;
        var val_4;
        var val_5;
        System.Action val_6;
        var val_3 = 0;
        val_3 = val_3 + 1;
        val_4 = x;
        if((x & 1) != 0)
        {
                TzarGames.Endless.EndlessGameState.Instance.SetGamePurchased(saveGame:  true);
            val_3 = 1152921504862703616;
            val_5 = null;
            val_5 = null;
            val_6 = TzarGames.Endless.EndlessInAppManager.OnGamePurchased;
            if(val_6 != null)
        {
                val_6 = TzarGames.Endless.EndlessInAppManager.OnGamePurchased;
            if(val_6 == null)
        {
                val_6 = 0;
        }
        
            val_6.Invoke();
        }
        
        }
        
        this.resultCallback.Invoke(obj:  x);
    }

}
