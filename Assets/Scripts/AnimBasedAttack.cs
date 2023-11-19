using UnityEngine;
protected class TH_Character.AnimBasedAttack : TH_Character.Attack
{
    // Methods
    public TH_Character.AnimBasedAttack()
    {
        val_1 = new TH_Character.CharacterBaseState();
    }
    public override void OnStateBegin(StateMachine.State prevState)
    {
        this.OnStateBegin(prevState:  prevState);
        this.startAttack();
        TzarGames.TzarHero.TH_Character val_1 = this.CharacterOwner;
        if(val_1.OnStartAttack == null)
        {
                return;
        }
        
        TzarGames.TzarHero.TH_Character val_2 = this.CharacterOwner;
        val_2.OnStartAttack.Invoke();
    }
    public override void OnStateEnd(StateMachine.State nextState)
    {
        this.OnStateEnd(nextState:  nextState);
        TzarGames.TzarHero.TH_Character val_1 = this.CharacterOwner;
        val_1.animBasedCombatSystem.StopAttack();
    }
    private void startAttack()
    {
        if(this.CharacterOwner == null)
        {
            
        }
    
    }
    public override void Update()
    {
        this.Update();
        TzarGames.TzarHero.TH_Character val_1 = this.CharacterOwner;
        if(val_1.animBasedCombatSystem.IsAttacking == true)
        {
            goto label_3;
        }
        
        TzarGames.TzarHero.TH_Character val_3 = this.CharacterOwner;
        if(val_3.bAttackContinuosly == false)
        {
            goto label_7;
        }
        
        TzarGames.TzarHero.TH_Character val_4 = this.CharacterOwner;
        TzarGames.TzarHero.TH_Character val_5 = this.TargetCharacter;
        if((val_5.isCharacterValidForAttack(character:  val_5)) == false)
        {
            goto label_7;
        }
        
        TzarGames.TzarHero.TH_Character val_8 = this.CharacterOwner;
        float val_10 = val_8.GetAttackRadius();
        val_10 = val_10 + val_8._minDistanceToWaypoint;
        if((val_8.IsObjectInRadius(obj:  this.TargetCharacter, radius:  val_10)) == false)
        {
            goto label_9;
        }
        
        this.startAttack();
        label_3:
        if(0 == this.TargetCharacter)
        {
                return;
        }
        
        UnityEngine.Vector3 val_17 = this.TargetCharacter.position;
        this.CharacterOwner.SetDesiredRotationToPosition(position:  new UnityEngine.Vector3() {x = val_17.x, y = val_17.y, z = val_17.z});
        return;
        label_7:
        this.GotoNextOrDefaultState();
        return;
        label_9:
        this.GotoNextOrDefaultState();
        this.CharacterOwner.Follow(character:  this.TargetCharacter, attack:  true, distance:  0f);
    }

}
