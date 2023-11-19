using UnityEngine;
private sealed class RestoreSaveDataUI.<ConfirmRestore>c__AnonStorey0
{
    // Fields
    internal TzarGames.Endless.EndlessSaveManager saveManager;
    internal TzarGames.Endless.UI.MainMenu.RestoreSaveDataUI $this;
    
    // Methods
    public RestoreSaveDataUI.<ConfirmRestore>c__AnonStorey0()
    {
    
    }
    internal void <>m__0(TzarGames.Endless.EndlessSaveData saveData)
    {
        if(this.$this.currentFile == null)
        {
                return;
        }
        
        this.$this.currentFile = 0;
        if(saveData != null)
        {
                this.saveManager.SaveData(data:  saveData);
            TzarGames.Endless.EndlessGameState.Instance.ReloadGame();
            return;
        }
        
        this.$this.showResultScreen();
    }

}
