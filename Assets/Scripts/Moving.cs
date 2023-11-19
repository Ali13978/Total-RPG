using UnityEngine;
[DefaultState]
protected class TH_CharacterAnim_Legacy.Moving : TH_CharacterAnim_Legacy.CharacterAnimState
{
    // Methods
    public TH_CharacterAnim_Legacy.Moving()
    {
    
    }
    public override void OnStateBegin(StateMachine.State prevState)
    {
        prevState.OnStateBegin(prevState:  prevState);
    }
    public override void Update()
    {
        this.Update();
        this.Animation.CrossfadeMovement(fadeLength:  0.2f);
    }

}
