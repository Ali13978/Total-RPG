using UnityEngine;
protected abstract class TH_Character.SimpleAttack : TH_Character.Attack
{
    // Fields
    private float lastAttackStartTime;
    [System.Diagnostics.DebuggerBrowsableAttribute]
    private UnityEngine.Vector3 <attackDirection>k__BackingField;
    [System.Diagnostics.DebuggerBrowsableAttribute]
    private TzarGames.TzarHero.TH_InteractiveObject <lastTarget>k__BackingField;
    
    // Properties
    protected UnityEngine.Vector3 attackDirection { get; set; }
    protected TzarGames.TzarHero.TH_InteractiveObject lastTarget { get; set; }
    
    // Methods
    protected TH_Character.SimpleAttack()
    {
        val_1 = new TH_Character.CharacterBaseState();
    }
    protected UnityEngine.Vector3 get_attackDirection()
    {
        return new UnityEngine.Vector3() {x = this.<attackDirection>k__BackingField};
    }
    private void set_attackDirection(UnityEngine.Vector3 value)
    {
        this.<attackDirection>k__BackingField = value;
        mem[1152921511555397744] = value.y;
        mem[1152921511555397748] = value.z;
    }
    protected TzarGames.TzarHero.TH_InteractiveObject get_lastTarget()
    {
        return (TzarGames.TzarHero.TH_InteractiveObject)this.<lastTarget>k__BackingField;
    }
    protected void set_lastTarget(TzarGames.TzarHero.TH_InteractiveObject value)
    {
        this.<lastTarget>k__BackingField = value;
    }
    protected virtual void startAttack()
    {
        this.lastAttackStartTime = UnityEngine.Time.time;
        TzarGames.TzarHero.TH_Character val_2 = this.CharacterOwner;
        val_2.pendingAttackFromClient = false;
        TzarGames.TzarHero.TH_Character val_3 = this.CharacterOwner;
        if(0 != val_3.characterAnimation)
        {
                TzarGames.TzarHero.TH_Character val_5 = this.CharacterOwner;
        }
        
        this.CharacterOwner.StopMove();
        TzarGames.TzarHero.TH_Character val_7 = this.CharacterOwner;
        this.<attackDirection>k__BackingField = val_7.attackDirection;
        mem[1152921511555799280] = typeof(TzarGames.TzarHero.CharacterAnimationBase).__il2cppRuntimeField_1F0;
        mem[1152921511555799284] = ???;
        TzarGames.TzarHero.TH_Character val_8 = this.CharacterOwner;
        TzarGames.TzarHero.TH_Character val_9 = this.CharacterOwner;
        if(val_9.OnStartAttack == null)
        {
                return;
        }
        
        TzarGames.TzarHero.TH_Character val_10 = this.CharacterOwner;
        val_10.OnStartAttack.Invoke();
    }
    public override void OnStateBegin(StateMachine.State prevState)
    {
        this.OnStateBegin(prevState:  prevState);
        goto typeof(TH_Character.SimpleAttack).__il2cppRuntimeField_200;
    }
    public override void OnStateEnd(StateMachine.State nextState)
    {
        var val_10;
        this.OnStateEnd(nextState:  nextState);
        TzarGames.TzarHero.TH_Character val_1 = this.CharacterOwner;
        if(0 == val_1.characterAnimation)
        {
                return;
        }
        
        TzarGames.TzarHero.TH_Character val_3 = this.CharacterOwner;
        this = ???;
        val_10 = ???;
        goto typeof(TzarGames.TzarHero.CharacterAnimationBase).__il2cppRuntimeField_1F0;
    }
    public override void Update()
    {
        float val_50;
        float val_51;
        UnityEngine.Transform val_52;
        float val_53;
        float val_54;
        float val_55;
        var val_56;
        var val_57;
        this.Update();
        val_50 = this.lastAttackStartTime;
        val_51 = UnityEngine.Time.time - val_50;
        TzarGames.TzarHero.TH_Character val_4 = this.CharacterOwner;
        if(val_51 >= this.CharacterOwner.AttackPerSecond)
        {
            goto label_3;
        }
        
        if(((0 == val_4.targetObject) || (this.CharacterOwner.PlayerOwner == null)) || (this.CharacterOwner.PlayerOwner.itsMe == false))
        {
            goto label_75;
        }
        
        TzarGames.TzarHero.TH_Character val_12 = this.CharacterOwner;
        val_52 = val_12.targetObject.cachedTransform;
        UnityEngine.Vector3 val_13 = val_52.position;
        val_51 = val_13.x;
        val_50 = val_13.z;
        val_53 = val_51;
        val_54 = val_13.y;
        val_55 = val_50;
        this.CharacterOwner.SetDesiredRotationToPosition(position:  new UnityEngine.Vector3() {x = val_53, y = val_54, z = val_55});
        goto label_75;
        label_3:
        if(val_4.pendingAttackFromClient == true)
        {
            goto label_17;
        }
        
        TzarGames.TzarHero.TH_Character val_14 = this.CharacterOwner;
        if(val_14.bAttackContinuosly == false)
        {
            goto label_58;
        }
        
        TzarGames.TzarHero.TH_Character val_15 = this.CharacterOwner;
        if(0 != val_15.nextObjectToAttack)
        {
                TzarGames.TzarHero.TH_Character val_17 = this.CharacterOwner;
            if((UnityEngine.Object.op_Implicit(exists:  0)) != false)
        {
                TzarGames.TzarHero.TH_Character val_19 = this.CharacterOwner;
            if(val_19.nextObjectToAttack != null)
        {
                TzarGames.TzarHero.TH_Character val_20 = this.CharacterOwner;
            TzarGames.TzarHero.TH_Character val_21 = this.CharacterOwner;
            val_52 = val_21.nextObjectToAttack;
            val_20.targetObject = val_52;
            TzarGames.TzarHero.TH_Character val_22 = this.CharacterOwner;
            val_22.nextObjectToAttack = 0;
        }
        
        }
        
        }
        
        TzarGames.TzarHero.TH_Character val_23 = this.CharacterOwner;
        if(0 == val_23.targetObject)
        {
            goto label_42;
        }
        
        TzarGames.TzarHero.TH_Character val_25 = this.CharacterOwner;
        if((UnityEngine.Object.op_Implicit(exists:  0)) == false)
        {
            goto label_42;
        }
        
        TzarGames.TzarHero.TH_Character val_27 = this.CharacterOwner;
        TzarGames.TzarHero.TH_Character val_28 = this.CharacterOwner;
        float val_29 = val_27.GetAttackRadius();
        val_29 = val_29 + val_27._minDistanceToWaypoint;
        if((val_27.IsObjectInRadius(obj:  val_28.targetObject, radius:  val_29)) == false)
        {
            goto label_45;
        }
        
        TzarGames.TzarHero.TH_Character val_31 = this.CharacterOwner;
        val_56 = 0;
        goto label_49;
        label_42:
        TzarGames.TzarHero.TH_Character val_32 = this.CharacterOwner;
        val_32.targetObject = 0;
        label_58:
        this.GotoNextOrDefaultState();
        goto label_75;
        label_45:
        this.GotoNextOrDefaultState();
        TzarGames.TzarHero.TH_Character val_34 = this.CharacterOwner;
        val_57 = 0;
        goto label_56;
        label_49:
        if((this.CharacterOwner.isCharacterValidForAttack(character:  null)) == false)
        {
            goto label_58;
        }
        
        TzarGames.TzarHero.TH_Character val_38 = this.CharacterOwner;
        TzarGames.TzarHero.TH_Character val_39 = this.CharacterOwner;
        UnityEngine.Vector3 val_40 = val_39.targetObject.cachedTransform.position;
        UnityEngine.Vector3 val_42 = this.CharacterOwner.position;
        val_53 = val_40.x;
        val_54 = val_40.y;
        val_55 = val_40.z;
        UnityEngine.Vector3 val_43 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_53, y = val_54, z = val_55}, b:  new UnityEngine.Vector3() {x = val_42.x, y = val_42.y, z = val_42.z});
        val_51 = val_43.x;
        val_50 = val_43.z;
        val_38.attackDirection = val_43;
        mem2[0] = val_43.y;
        mem2[0] = val_50;
        label_17:
        label_75:
        TzarGames.TzarHero.TH_Character val_44 = this.CharacterOwner;
        if(0 == val_44.targetObject)
        {
                return;
        }
        
        TzarGames.TzarHero.TH_Character val_47 = this.CharacterOwner;
        UnityEngine.Vector3 val_48 = val_47.targetObject.cachedTransform.position;
        this.CharacterOwner.SetDesiredRotationToPosition(position:  new UnityEngine.Vector3() {x = val_48.x, y = val_48.y, z = val_48.z});
        return;
        label_56:
        this.CharacterOwner.Follow(character:  null, attack:  true, distance:  0f);
        goto label_75;
    }

}
