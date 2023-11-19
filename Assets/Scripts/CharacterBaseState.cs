using UnityEngine;
public class TH_Character.CharacterBaseState : StateMachine.State
{
    // Properties
    public TzarGames.TzarHero.TH_Character CharacterOwner { get; }
    public TzarGames.GameFramework.Player PlayerOwner { get; }
    public TzarGames.TzarHero.TH_InteractiveObject targetObject { get; }
    
    // Methods
    public TH_Character.CharacterBaseState()
    {
    
    }
    public TzarGames.TzarHero.TH_Character get_CharacterOwner()
    {
        if(this.Owner == null)
        {
                return (TzarGames.TzarHero.TH_Character);
        }
        
        0 = 0;
        return (TzarGames.TzarHero.TH_Character);
    }
    public TzarGames.GameFramework.Player get_PlayerOwner()
    {
        TzarGames.TzarHero.TH_Character val_1 = this.CharacterOwner;
        if(val_1 != null)
        {
                return val_1.PlayerOwner;
        }
        
        return val_1.PlayerOwner;
    }
    public TzarGames.TzarHero.TH_InteractiveObject get_targetObject()
    {
        if(this.CharacterOwner != null)
        {
                return (TzarGames.TzarHero.TH_InteractiveObject)val_1.targetObject;
        }
        
        return (TzarGames.TzarHero.TH_InteractiveObject)val_1.targetObject;
    }
    public virtual void StopMove()
    {
    
    }
    public virtual void OnPathCalculationComplete(bool success)
    {
    
    }
    public virtual void OnCompleteMoveToPosition()
    {
    
    }
    public virtual void OnStucked()
    {
    
    }
    public override void OnStateBegin(StateMachine.State prevState)
    {
        var val_4;
        prevState.OnStateBegin(prevState:  prevState);
        TzarGames.TzarHero.TH_Character val_1 = this.CharacterOwner;
        TzarGames.TzarHero.TH_Character val_3 = this.CharacterOwner;
        val_3.callbacksToExecuteAfterAttack.Clear();
        val_4 = 0;
        goto label_5;
        label_10:
        val_3.callbacksToExecuteAfterAttack.Invoke();
        val_4 = 1;
        label_5:
        if(val_4 >= val_2.Length)
        {
                return;
        }
        
        if(val_1.callbacksToExecuteAfterAttack.ToArray()[1] != 0)
        {
            goto label_10;
        }
        
        goto label_10;
    }
    public virtual bool OverrideDamage(TzarGames.TzarHero.ICharacterDamageInfo damageInfo, out float stateDamage)
    {
        stateDamage = 0f;
        return false;
    }

}
