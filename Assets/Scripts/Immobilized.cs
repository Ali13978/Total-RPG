using UnityEngine;
[Uninterrupted]
protected class PlayerCharacterBase.Immobilized : TH_Character.CharacterBaseState
{
    // Fields
    private bool prevMovementState;
    
    // Methods
    public PlayerCharacterBase.Immobilized()
    {
    
    }
    public override void OnStateBegin(StateMachine.State prevState)
    {
        var val_17;
        var val_18;
        var val_19;
        var val_20;
        var val_21;
        val_17 = 0;
        this.OnStateBegin(prevState:  prevState);
        if(this.CharacterOwner.Movement == null)
        {
                return;
        }
        
        var val_17 = 0;
        val_17 = val_17 + 1;
        val_17 = 21;
        val_18 = this.CharacterOwner.Movement;
        UnityEngine.Vector3 val_8 = UnityEngine.Vector3.zero;
        var val_18 = 0;
        val_18 = val_18 + 1;
        val_17 = 8;
        val_19 = this.CharacterOwner.Movement;
        TzarGames.GameFramework.ICharacterMovement val_11 = this.CharacterOwner.Movement;
        var val_19 = 0;
        val_19 = val_19 + 1;
        val_17 = 15;
        val_20 = val_11;
        this.prevMovementState = val_11 & 1;
        var val_20 = 0;
        val_20 = val_20 + 1;
        val_17 = 16;
        val_21 = this.CharacterOwner.Movement;
    }
    public override void OnStateEnd(StateMachine.State nextState)
    {
        var val_7;
        var val_8;
        val_7 = 0;
        nextState.OnStateEnd(nextState:  nextState);
        if(this.CharacterOwner.Movement == null)
        {
                return;
        }
        
        var val_7 = 0;
        val_7 = val_7 + 1;
        val_7 = 16;
        val_8 = this.CharacterOwner.Movement;
        var val_6 = (this.prevMovementState == true) ? 1 : 0;
    }

}
