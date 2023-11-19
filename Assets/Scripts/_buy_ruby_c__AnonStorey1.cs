using UnityEngine;
private sealed class EndlessInAppManager.<buy_ruby>c__AnonStorey1
{
    // Fields
    internal string productId;
    internal System.Action<TzarGames.Common.IPurchaseResult> resultCallback;
    
    // Methods
    public EndlessInAppManager.<buy_ruby>c__AnonStorey1()
    {
    
    }
    internal void <>m__0(TzarGames.Common.IPurchaseResult result)
    {
        var val_8;
        var val_9;
        var val_10;
        var val_11;
        var val_8 = 0;
        val_8 = val_8 + 1;
        val_9 = 1;
        val_10 = result;
        if(((result & 1) & 1) != 0)
        {
                int val_3 = TzarGames.Endless.EndlessInAppManager.getRubyCountForProductId(productId:  null);
            var val_9 = 0;
            val_9 = val_9 + 1;
            val_9 = 5;
            val_11 = TzarGames.Endless.EndlessGameState.Instance.SelectedCharacter;
            val_8 = TzarGames.Endless.EndlessGameState.Instance;
            val_8.SaveGame();
        }
        
        if(this.resultCallback == null)
        {
                return;
        }
        
        this.resultCallback.Invoke(obj:  result);
    }

}
