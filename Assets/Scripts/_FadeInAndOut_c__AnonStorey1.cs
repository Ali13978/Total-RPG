using UnityEngine;
private sealed class CinematicController.<FadeInAndOut>c__AnonStorey1
{
    // Fields
    internal TzarGames.Endless.UI.GameUI ui;
    internal TzarGames.Endless.CinematicController $this;
    
    // Methods
    public CinematicController.<FadeInAndOut>c__AnonStorey1()
    {
    
    }
    internal void <>m__0()
    {
        this.ui.FadeOut(onCompleteCallback:  0);
        this.$this.onFadeInComplete.Invoke();
    }

}
