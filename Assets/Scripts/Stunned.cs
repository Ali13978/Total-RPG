using UnityEngine;
[Uninterrupted]
protected class TH_Character.Stunned : TH_Character.CharacterBaseState
{
    // Fields
    private System.Collections.IEnumerator coroutine;
    private float stunTime;
    
    // Methods
    public TH_Character.Stunned()
    {
        this.stunTime = 3f;
    }
    public override void OnStateBegin(StateMachine.State prevState)
    {
        TzarGames.TzarHero.TH_Character val_21;
        System.Delegate val_22;
        float val_23;
        var val_24;
        val_21 = this;
        this.OnStateBegin(prevState:  prevState);
        val_23 = null;
        UnityEngine.Vector2 val_1 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3());
        this.stunTime = mem[34807808];
        if(this.CharacterOwner.OnClient != true)
        {
                TzarGames.TzarHero.TH_Character val_5 = this.CharacterOwner;
            this.stunTime = this.stunTime;
        }
        
        TzarGames.TzarHero.TH_Character val_6 = this.CharacterOwner;
        if(val_6.movement != null)
        {
                TzarGames.TzarHero.TH_Character val_7 = this.CharacterOwner;
            var val_21 = 0;
            val_21 = val_21 + 1;
            val_24 = val_7.movement;
        }
        
        if(this.stunTime > 0f)
        {
                this.coroutine = this.stunCoroutine();
            val_22 = this.CharacterOwner;
            UnityEngine.Coroutine val_11 = val_22.StartCoroutine(routine:  this.coroutine);
        }
        
        if(this.CharacterOwner.OnServer != false)
        {
                TzarGames.GameFramework.RPCall<System.Single> val_16 = null;
            val_22 = val_16;
            val_16 = new TzarGames.GameFramework.RPCall<System.Single>(object:  this.CharacterOwner, method:  System.Void TzarGames.TzarHero.TH_Character::client_stun(float stunTime));
            typeof(System.Object[]).__il2cppRuntimeField_20 = this.stunTime;
            typeof(System.Object[]).__il2cppRuntimeField_24 = 268435457;
            this.CharacterOwner.RPC(methodDelegate:  val_22, rpcMode:  4, parameters:  null);
        }
        
        TzarGames.TzarHero.TH_Character val_17 = this.CharacterOwner;
        if(val_17.OnStun == null)
        {
                return;
        }
        
        TzarGames.TzarHero.TH_Character val_18 = this.CharacterOwner;
        val_21 = this.CharacterOwner;
        val_18.OnStun.Invoke(character:  val_21);
    }
    public override void OnStateEnd(StateMachine.State nextState)
    {
        var val_8;
        TzarGames.TzarHero.TH_Character val_9;
        var val_10;
        var val_11;
        val_9 = this;
        val_10 = 0;
        nextState.OnStateEnd(nextState:  nextState);
        TzarGames.TzarHero.TH_Character val_1 = this.CharacterOwner;
        if(val_1.movement != null)
        {
                TzarGames.TzarHero.TH_Character val_2 = this.CharacterOwner;
            var val_8 = 0;
            val_8 = val_8 + 1;
            val_10 = 16;
            val_11 = val_2.movement;
        }
        
        if(this.coroutine != null)
        {
                val_8 = this.CharacterOwner;
            val_8.StopCoroutine(routine:  this.coroutine);
            this.coroutine = 0;
        }
        
        TzarGames.TzarHero.TH_Character val_5 = this.CharacterOwner;
        if(val_5.OnExitFromStun == null)
        {
                return;
        }
        
        TzarGames.TzarHero.TH_Character val_6 = this.CharacterOwner;
        val_9 = this.CharacterOwner;
        val_6.OnExitFromStun.Invoke(character:  val_9);
    }
    [System.Diagnostics.DebuggerHiddenAttribute]
    private System.Collections.IEnumerator stunCoroutine()
    {
        typeof(TH_Character.Stunned.<stunCoroutine>c__Iterator0).__il2cppRuntimeField_10 = this;
        return (System.Collections.IEnumerator)new System.Object();
    }

}
