using UnityEngine;
private class CharacterAI.RandomWalking : CharacterAI.BaseState
{
    // Fields
    private bool walking;
    private UnityEngine.Coroutine updateCoroutine;
    private float lastWaitTime;
    private float waitTime;
    private float stuckTime;
    private UnityEngine.Vector3 lastPos;
    private bool checkingForStuck;
    private float stuckCheckTime;
    
    // Methods
    public CharacterAI.RandomWalking()
    {
        this.stuckTime = 1f;
    }
    public override void OnStateBegin(StateMachine.State prevState)
    {
        prevState.OnStateBegin(prevState:  prevState);
        TzarGames.TzarHero.CharacterAI val_1 = this.AI;
        val_1.controlledCharacter.ResetToDefaultState();
        this.chooseWaitTime();
        this.updateCoroutine = this.AI.StartCoroutine(routine:  this.update());
    }
    public override void OnStateEnd(StateMachine.State nextState)
    {
        nextState.OnStateEnd(nextState:  nextState);
        if(this.updateCoroutine == null)
        {
                return;
        }
        
        this.AI.StopCoroutine(routine:  this.updateCoroutine);
        this.updateCoroutine = 0;
    }
    private void chooseWaitTime()
    {
        TzarGames.TzarHero.CharacterAI val_1 = this.AI;
        TzarGames.TzarHero.CharacterAI val_2 = this.AI;
        this.waitTime = UnityEngine.Random.Range(min:  val_1.minWalkStopTime, max:  val_2.maxWalkStopTime);
    }
    [System.Diagnostics.DebuggerHiddenAttribute]
    private System.Collections.IEnumerator update()
    {
        typeof(CharacterAI.RandomWalking.<update>c__Iterator0).__il2cppRuntimeField_18 = this;
        return (System.Collections.IEnumerator)new System.Object();
    }
    private UnityEngine.Vector3 findRandomPoint()
    {
        float val_20;
        float val_21;
        float val_22;
        TzarGames.TzarHero.CharacterAI val_1 = this.AI;
        UnityEngine.Vector3 val_2 = UnityEngine.Vector3.zero;
        TzarGames.TzarHero.CharacterAI val_3 = this.AI;
        TzarGames.TzarHero.CharacterAI val_4 = this.AI;
        float val_7 = ((UnityEngine.Random.Range(min:  0, max:  0)) < 1) ? -1f : 1f;
        TzarGames.TzarHero.CharacterAI val_8 = this.AI;
        TzarGames.TzarHero.CharacterAI val_9 = this.AI;
        TzarGames.TzarHero.CharacterAI val_13 = this.AI;
        val_7 = (UnityEngine.Random.Range(min:  val_3.minWalkDistance, max:  val_4.maxWalkDistance)) * val_7;
        UnityEngine.Vector3 val_15 = UnityEngine.Vector3.ClampMagnitude(vector:  new UnityEngine.Vector3() {x = val_7, y = val_2.y, z = (UnityEngine.Random.Range(min:  val_8.minWalkDistance, max:  val_9.maxWalkDistance)) * (((UnityEngine.Random.Range(min:  0, max:  0)) < 1) ? -1f : 1f)}, maxLength:  val_13.maxWalkDistance);
        UnityEngine.Vector3 val_16 = val_1.controlledCharacter.GroundPivotPosition;
        UnityEngine.Vector3 val_17 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_16.x, y = val_16.y, z = val_16.z}, b:  new UnityEngine.Vector3() {x = val_15.x, y = val_15.y, z = val_15.z});
        val_20 = val_17.x;
        val_21 = val_17.y;
        val_22 = val_17.z;
        TzarGames.TzarHero.CharacterAI val_18 = this.AI;
        if((val_18.controlledCharacter.Pathfinder & 1) == 0)
        {
                return new UnityEngine.Vector3() {x = val_20, y = val_21, z = val_22};
        }
        
        val_20 = 0f;
        val_21 = 0f;
        val_22 = 0f;
        return new UnityEngine.Vector3() {x = val_20, y = val_21, z = val_22};
    }

}
