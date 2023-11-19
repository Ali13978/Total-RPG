using UnityEngine;
[Uninterrupted]
protected class TH_Character.Cinematic : TH_Character.CharacterBaseState
{
    // Fields
    private System.Action<TzarGames.TzarHero.TH_Character> onCinematicFinished;
    
    // Methods
    public TH_Character.Cinematic()
    {
    
    }
    private void onCinematicFinishedHandler()
    {
        if(this.Owner.CurrentState != null)
        {
                this.GotoNextOrDefaultState();
        }
        
        if(this.onCinematicFinished == null)
        {
                return;
        }
        
        this.onCinematicFinished.Invoke(obj:  this.CharacterOwner);
    }
    public override void OnStateBegin(StateMachine.State prevState)
    {
        var val_4;
        this.OnStateBegin(prevState:  prevState);
        val_4 = 0;
        this.onCinematicFinished = 7254272;
        TzarGames.TzarHero.TH_Character val_1 = this.CharacterOwner;
        string val_2 = 11993091.AnimationName;
        System.Action val_3 = new System.Action(object:  this, method:  System.Void TH_Character.Cinematic::onCinematicFinishedHandler());
        if(val_1.characterAnimation == null)
        {
            
        }
    
    }

}
