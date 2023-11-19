using UnityEngine;
private class GameUI.Gameplay : GameUI.UiBaseState
{
    // Methods
    public GameUI.Gameplay()
    {
    
    }
    public override void OnStateBegin(StateMachine.State prevState)
    {
        TzarGames.Endless.UI.PlayerCharacterUI val_24;
        var val_25;
        var val_26;
        this.OnStateBegin(prevState:  prevState);
        if(0 != TzarGames.Endless.EndlessGameState.Instance)
        {
                if(TzarGames.Endless.EndlessGameState.Instance.Paused != false)
        {
                TzarGames.Endless.EndlessGameState.Instance.Paused = false;
        }
        
        }
        
        TzarGames.Endless.UI.GameUI val_6 = this.UI;
        val_24 = val_7.hud;
        this.UI.showMenu(menu:  val_24, show:  true);
        if(0 != TzarGames.Endless.EndlessGameState.Instance)
        {
                bool val_23 = TzarGames.Endless.EndlessGameState.Instance.IsInGameState();
            val_24 = TzarGames.Endless.EndlessGameState.Instance.IsInLobby();
            TzarGames.Endless.UI.GameUI val_14 = this.UI;
            val_23 = val_23 | val_24;
            val_14.settingsButton.gameObject.SetActive(value:  val_23);
            TzarGames.Endless.UI.GameUI val_17 = this.UI;
            val_25 = val_17.inventoryButton.gameObject;
            val_26 = val_23;
        }
        else
        {
                TzarGames.Endless.UI.GameUI val_19 = this.UI;
            val_19.settingsButton.gameObject.SetActive(value:  false);
            TzarGames.Endless.UI.GameUI val_21 = this.UI;
            val_25 = val_21.inventoryButton.gameObject;
            val_26 = 1;
        }
        
        val_25.SetActive(value:  true);
    }
    public override void OnStateEnd(StateMachine.State nextState)
    {
        this.OnStateEnd(nextState:  nextState);
        TzarGames.Endless.UI.GameUI val_1 = this.UI;
        this.UI.showMenu(menu:  val_2.hud, show:  false);
    }

}
