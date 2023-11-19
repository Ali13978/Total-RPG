using UnityEngine;
private class WaveSpawner.PendingWave : WaveSpawner.WaveSpawnerBaseState
{
    // Fields
    private float pendingTime;
    private float pendingStartTime;
    
    // Methods
    public WaveSpawner.PendingWave()
    {
    
    }
    public override void OnStateBegin(StateMachine.State prevState)
    {
        float val_1 = UnityEngine.Time.time;
        this.pendingStartTime = val_1;
        UnityEngine.Vector2 val_2 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = val_1});
        this.pendingTime = X21;
    }
    public override void Update()
    {
        float val_1 = UnityEngine.Time.time;
        val_1 = val_1 - this.pendingStartTime;
        if(val_1 < this.pendingTime)
        {
                return;
        }
        
        bool val_3 = this.Owner.GotoState<SpawningWave>(stateData:  0);
    }

}
