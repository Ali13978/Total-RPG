using UnityEngine;
public class TH_Character.RandomRun : TH_Character.Moving
{
    // Methods
    public TH_Character.RandomRun()
    {
        val_1 = new TH_Character.CharacterBaseState();
    }
    public override void OnStateBegin(StateMachine.State prevState)
    {
        this.OnStateBegin(prevState:  prevState);
        this.FindNewPos();
    }
    private void FindNewPos()
    {
        UnityEngine.Vector3 val_2 = this.CharacterOwner.position;
        int val_3 = UnityEngine.Random.Range(min:  0, max:  -5);
        int val_4 = UnityEngine.Random.Range(min:  0, max:  -5);
        UnityEngine.Vector3 val_5 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z}, b:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f});
        if((this.CharacterOwner.GoToPosition(targetPosition:  new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z}, reachPositionHandler:  0, stoppingDistance:  0f)) == true)
        {
                return;
        }
        
        UnityEngine.Debug.Log(message:  0);
        TzarGames.TzarHero.TH_Character val_9 = this.CharacterOwner;
        this = TH_Character.RandomRun.wait(secs:  1f, rstate:  val_9);
        UnityEngine.Coroutine val_11 = val_9.StartCoroutine(routine:  this);
    }
    [System.Diagnostics.DebuggerHiddenAttribute]
    public static System.Collections.IEnumerator wait(float secs, TzarGames.TzarHero.TH_Character.RandomRun rstate)
    {
        if(null != 0)
        {
                typeof(TH_Character.RandomRun.<wait>c__Iterator0).__il2cppRuntimeField_10 = secs;
        }
        else
        {
                mem[16] = secs;
        }
        
        typeof(TH_Character.RandomRun.<wait>c__Iterator0).__il2cppRuntimeField_18 = X1;
        return (System.Collections.IEnumerator)new System.Object();
    }
    public override void OnCompleteMoveToPosition()
    {
        this.FindNewPos();
    }
    public override void OnStucked()
    {
        this.OnStucked();
        this.FindNewPos();
    }

}
