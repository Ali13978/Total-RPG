using UnityEngine;
private sealed class CinematicController.<FadeScreenAndTeleportPlayerTo>c__AnonStorey2
{
    // Fields
    internal TzarGames.Endless.PlayerCharacter playerCharacter;
    internal UnityEngine.Transform point;
    internal TzarGames.Endless.UI.GameUI ui;
    internal TzarGames.Endless.CinematicController $this;
    
    // Methods
    public CinematicController.<FadeScreenAndTeleportPlayerTo>c__AnonStorey2()
    {
    
    }
    internal void <>m__0()
    {
        System.Collections.IEnumerator val_4;
        if(this.$this != null)
        {
                val_4 = this.movePlayerCharacter(character:  this.playerCharacter, point:  this.point);
        }
        else
        {
                val_4 = this.movePlayerCharacter(character:  this.playerCharacter, point:  this.point);
        }
        
        UnityEngine.Coroutine val_3 = this.$this.StartCoroutine(routine:  val_4);
        this.ui.FadeOut(onCompleteCallback:  0);
        this.$this.onFadeInComplete.Invoke();
    }

}
