using UnityEngine;
private class GameBundleLoader.WaitForUserAction : GameBundleLoader.BaseState
{
    // Methods
    public GameBundleLoader.WaitForUserAction()
    {
    
    }
    public override void OnStateBegin(StateMachine.State prevState)
    {
        this.OnStateBegin(prevState:  prevState);
        TzarGames.Endless.GameBundleLoader val_1 = this.Loader;
        this.setStatus(status:  TzarGames.Common.LocalizedStringAsset.op_Implicit(text:  0));
        TzarGames.Endless.GameBundleLoader val_3 = this.Loader;
        TzarGames.Endless.GameBundleLoader val_4 = this.Loader;
        TzarGames.Endless.GameBundleLoader val_5 = this.Loader;
        if(val_4.downloadSize != 0)
        {
                val_5.sizeOfFile.enabled = true;
            TzarGames.Endless.GameBundleLoader val_6 = this.Loader;
            float val_7 = (float)val_6.downloadSize * (9.536743E-07f);
            TzarGames.Endless.GameBundleLoader val_8 = this.Loader;
            TzarGames.Endless.GameBundleLoader val_9 = this.Loader;
            val_8.sizeOfFile.text = System.String.Format(format:  0, arg0:  TzarGames.Common.LocalizedStringAsset.op_Implicit(text:  0));
            return;
        }
        
        val_5.sizeOfFile.enabled = false;
    }
    public override void OnStateEnd(StateMachine.State nextState)
    {
        nextState.OnStateEnd(nextState:  nextState);
        TzarGames.Endless.GameBundleLoader val_1 = this.Loader;
        if(val_1.userActionUI == null)
        {
            
        }
    
    }

}
