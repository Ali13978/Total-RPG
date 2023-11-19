using UnityEngine;
protected class TH_CharacterAnim_Legacy.CustomAnimation : TH_CharacterAnim_Legacy.CharacterAnimState
{
    // Fields
    private TzarGames.TzarHero.TH_CharacterAnim_Legacy.CustomAnimData animData;
    
    // Methods
    public TH_CharacterAnim_Legacy.CustomAnimation()
    {
    
    }
    public override void OnStateBegin(StateMachine.State prevState)
    {
        var val_4;
        prevState.OnStateBegin(prevState:  prevState);
        val_4 = 0;
        if(true != 0)
        {
                val_4 = 0;
        }
        
        this.animData = ;
        TzarGames.TzarHero.TH_CharacterAnim_Legacy val_2 = this.Animation;
        bool val_3 = val_2._animation.Play(animation:  this.animData.AnimName);
    }
    public override void OnStateEnd(StateMachine.State nextState)
    {
        TzarGames.TzarHero.TH_CharacterAnim_Legacy val_1 = this.Animation;
        TzarGames.TzarHero.TH_CharacterAnim_Legacy val_2 = this.Animation;
        val_1._animation.CrossFade(animation:  val_2.IdleAnimationName, fadeLength:  0.2f);
        this.animData = 0;
    }
    public override void Update()
    {
        if(this.animData.ReturnAfterFinish == false)
        {
                return;
        }
        
        TzarGames.TzarHero.TH_CharacterAnim_Legacy val_1 = this.Animation;
        if((val_1._animation.IsPlaying(name:  this.animData.AnimName)) != false)
        {
                return;
        }
        
        this.GotoNextOrDefaultState();
    }

}
