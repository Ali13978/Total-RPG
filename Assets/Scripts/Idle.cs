using UnityEngine;
private class CharacterAI.Idle : CharacterAI.BaseState
{
    // Methods
    public CharacterAI.Idle()
    {
    
    }
    public override void OnStateBegin(StateMachine.State prevState)
    {
        prevState.OnStateBegin(prevState:  prevState);
        TzarGames.TzarHero.CharacterAI val_1 = this.AI;
        if(0 == val_1.controlledCharacter)
        {
                return;
        }
        
        TzarGames.TzarHero.CharacterAI val_3 = this.AI;
        val_3.controlledCharacter.StopAttack();
    }

}
