using UnityEngine;
[Uninterrupted]
protected class TH_Character.Skill : TH_Character.CharacterBaseState
{
    // Fields
    private TzarGames.TzarHero.Skills.CharacterSkill skill;
    
    // Methods
    public TH_Character.Skill()
    {
    
    }
    private void returnToDefaultState()
    {
        this.GotoNextOrDefaultState();
    }
    public override void OnStateBegin(StateMachine.State prevState)
    {
        var val_4;
        this.OnStateBegin(prevState:  prevState);
        val_4 = 0;
        this.skill = ;
        if(0 == )
        {
                this.GotoNextOrDefaultState();
            return;
        }
        
        this.skill.add_OnFinished(value:  new System.Action<TzarGames.GameFramework.Skills.Skill>(object:  this, method:  System.Void TH_Character.Skill::onSkillFinished(TzarGames.GameFramework.Skills.Skill finishedSkill)));
        this.skill.Start();
    }
    private void onSkillFinished(TzarGames.GameFramework.Skills.Skill finishedSkill)
    {
        this.GotoNextOrDefaultState();
    }
    public override void OnStateEnd(StateMachine.State nextState)
    {
        nextState.OnStateEnd(nextState:  nextState);
        this.skill.remove_OnFinished(value:  new System.Action<TzarGames.GameFramework.Skills.Skill>(object:  this, method:  System.Void TH_Character.Skill::onSkillFinished(TzarGames.GameFramework.Skills.Skill finishedSkill)));
        this.skill.Stop();
        this.skill = 0;
    }
    public override void Update()
    {
        this.Update();
        this.CharacterOwner.updateMovement();
        if(this.skill.RotateToTarget == false)
        {
                return;
        }
        
        TzarGames.TzarHero.TH_Character val_3 = this.CharacterOwner;
        if(0 == val_3.targetObject)
        {
                return;
        }
        
        TzarGames.TzarHero.TH_Character val_6 = this.CharacterOwner;
        UnityEngine.Vector3 val_7 = val_6.targetObject.cachedTransform.position;
        this.CharacterOwner.SetDesiredRotationToPosition(position:  new UnityEngine.Vector3() {x = val_7.x, y = val_7.y, z = val_7.z});
    }
    public override bool OverrideDamage(TzarGames.TzarHero.ICharacterDamageInfo damageInfo, out float stateDamage)
    {
        var val_2;
        if(((this.skill & 1) & 1) != 0)
        {
                val_2 = 1;
            return (bool)val_2;
        }
        
        val_2 = 0;
        stateDamage = 0f;
        return (bool)val_2;
    }

}
